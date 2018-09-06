var textarea = document.getElementById("textarea");
var limit = 800; //height limit

textarea.oninput = function () {
    textarea.style.height = "";
    textarea.style.height = Math.min(textarea.scrollHeight, limit) + "px";
};

//init color picker
$(document).ready(function () {
    $('#colorpicker').farbtastic('#color');
});