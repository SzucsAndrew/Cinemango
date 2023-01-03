// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function refreshPage(result) {
    if (result && result.url) {
        if (result.url === "reload") {
            window.location.reload();
        } else {
            window.location.href = result.url;
        }
    }
}