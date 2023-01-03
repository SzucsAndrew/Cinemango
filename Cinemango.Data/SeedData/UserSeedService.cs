using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinemango.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Cinemango.Data.SeedData
{
    public class UserSeedService : IUserSeedService
    {
        private readonly UserManager<Felhasznalo> userManager;

        public UserSeedService( UserManager<Felhasznalo> userManager)
        {
            this.userManager = userManager;
        }

        public async Task SeedUserAsync()
        {
            if( !(await userManager.GetUsersInRoleAsync("Administrators")).Any() )
            {
                var felhasznalo = new Felhasznalo
                {
                    UserName = "admin@cinemango.hu",
                    Email = "admin@cinemango.hu",
                    TeljesNev = "Adminisztrátor Aladár",
                    SecurityStamp = Guid.NewGuid().ToString()
                };

                var createResult = await userManager.CreateAsync(felhasznalo, "P@ssword1");

                if( userManager.Options.SignIn.RequireConfirmedAccount)
                {
                    // Regisztációt meg kell erősíteni.
                    var code = await userManager.GenerateEmailConfirmationTokenAsync(felhasznalo);
                    var result = await userManager.ConfirmEmailAsync(felhasznalo, code);
                }

                var addToRoleReult = await userManager.AddToRoleAsync(felhasznalo, "Administrators");

                if( !createResult.Succeeded || !addToRoleReult.Succeeded )
                {
                    throw new ApplicationException("Nem sikerült létrehozni az adminisztrátor felhasználót: " +
                        string.Join(", ", createResult.Errors.Concat(addToRoleReult.Errors).Select(e => e.Description)));
                }
            }
        }
    }
}
