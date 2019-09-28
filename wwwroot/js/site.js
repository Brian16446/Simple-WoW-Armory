// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#close-form').click(function () {
    $('#search-form').hide();
    $('#show-form').show();
})

$('#show-form').click(function () {
    $('#search-form').show();
    $('#show-form').hide();
})