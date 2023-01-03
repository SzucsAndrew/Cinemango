using Cinemango.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cinemango
{
    public record Vetites(
        int Id,
        DateTime Idopont,
        int TeremId,
        string Terem,
        VetitesTipus Tipus)
    { }

    public class FilmDetails
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "IMDB ID")]
        public string ImdbId { get; set; }

        [Required]
        [Display(Name = "Cím")]
        public string Cim { get; set; }

        [Required]
        [Display(Name = "Eredeti cím")]
        public string EredetiCim { get; set; }

        [Required]
        [Display(Name = "Kiadás éve")]
        public int KiadasEve { get; set; }

        [Required]
        [Display(Name = "Leírás")]
        public string LeirasHtml { get; set; }

        [Display(Name = "Előzetes URL")]
        [Url]
        public string? ElozetesUrl { get; set; }
    }

    public record Film(
        int Id,
        string ImdbId,
        string Cim,
        string EredetiCim,
        int KiadasEve,
        string LeirasHtml,
        string? ElozetesUrl,
        IEnumerable<Vetites> Vetitesek)
    { }

    public record JegyTipus(
        int Id,
        string Nev,
        int Ar)
    { }

    public record VetitesUlohely(
        UlohelyOldal? Oldal,
        int Sor,
        int Szek,
        bool Foglalt)
    { }

    public record Terem(int Id, string Nev, int UlohelyekSzama)
    { }

    public record TeremSzerkesztes(int Id, [Required] string Nev)
    { }

    public record TeremLetrehozas([Required] string Nev, [Required] int Sorok, [Required] int Szekek)
    { }
}
