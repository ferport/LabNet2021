$(document).ready(function () {

    $("#firstName").focusout(function () {
        if ($("#firstName").val() == "") {
            $("#nameError").css("display", "block");
        }
        else {
            $("#nameError").css("display", "none");
        }

        if ($("#firstName").val().length > 10) {
            $("#nameErrorMax").css("display", "block");
        }
        else {
            $("#nameErrorMax").css("display", "none");
        }
    });


    $("#lastName").focusout(function () {
        if ($("#lastName").val() == "") {
            $("#lastNameError").css("display", "block");
        }
        else {
            $("#lastNameError").css("display", "none"); 
        }

        if ($("#lastName").val().length > 20) {
            $("#lastNameErrorMax").css("display", "block");
        }
        else {
            $("#lastNameErrorMax").css("display", "none");
        }
    });

    $("#submit").click(function (e) {
        if ($("#lastName").val() == "") {
            e.preventDefault();
            $("#lastNameError").css("display", "block");
        }
        else {
            $("#lastNameError").css("display", "none");
        }

        if ($("#firstName").val() == "") {
            e.preventDefault();
            $("#nameError").css("display", "block");
        }
        else {
            $("#nameError").css("display", "none");
        }

        if ($("#firstName").val().length > 10) {
            e.preventDefault();
            $("#nameErrorMax").css("display", "block");
        }
        else {
            $("#nameErrorMax").css("display", "none");
        }

        if ($("#lastName").val().length > 20) {
            e.preventDefault();
            $("#lastNameErrorMax").css("display", "block");
        }
        else {
            $("#lastNameErrorMax").css("display", "none");
        }
    });
});