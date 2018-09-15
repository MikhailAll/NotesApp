// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    $("#lg-headerBtn").click(function() {
        insertTag("<h2></h2>");
    });

    $("#md-headerBtn").click(function() {
        insertTag("<h3></h3>");
    });

    $("#sm-headerBtn").click(function() {
        insertTag("<h4></h4>");
    });

    $("#boldBtn").click(function() {
        insertTag("<b></b>");
    });

});

var constructorTextarea = $("#constructorTextarea");
var previewArea = $("#previewArea");

function renderPreview() {
    previewArea.empty();
    previewArea.append(constructorTextarea.val().replace(/\r\n|\n/g, '<br>'));
}

function insertTag(value) {
    constructorTextarea.val(constructorTextarea.val() + value);
}