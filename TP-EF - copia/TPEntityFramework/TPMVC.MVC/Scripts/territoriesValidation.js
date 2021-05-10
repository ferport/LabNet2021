$(document).ready(function () {

    

    $("#id").focusout(function () {
        var id = $("#id").val();
        var reg = /^([0-9])*$/;
        if (id == "") {
            $("#idError").css("display", "block");
        }
        else {
            $("#idError").css("display", "none");
        }

        if (id.length != 5) {
            $("#idErrorLength").css("display", "block");
        }
        else {
            $("#idErrorLength").css("display", "none");
        }
        
        if (reg.test(id)) {
            $("#idErrorNumber").css("display", "none");
        }
        else
        {
            $("#idErrorNumber").css("display", "block");
        }
    });


    $("#description").focusout(function () {
        if ($("#description").val() == "") {
            $("#descriptionError").css("display", "block");
        }
        else {
            $("#descriptionError").css("display", "none");
        }

        if ($("#description").val().length > 50) {
            $("#descriptionErrorMax").css("display", "block");
        }
        else {
            $("#descriptionErrorMax").css("display", "none");
        }
    });

    $("#submit").click(function (e) {
        var id = $("#id").val();
        var reg = /^([0-9])*$/;
        if (id == "") {
            e.preventDefault();
            $("#idError").css("display", "block");
        }
        else {
            $("#idError").css("display", "none");
        }

        if (id.length != 5) {
            e.preventDefault();
            $("#idErrorLength").css("display", "block");
        }
        else {
            $("#idErrorLength").css("display", "none");
        }

        if (reg.test(id)) {
            $("#idErrorNumber").css("display", "none");

        }
        else {
            e.preventDefault();
            $("#idErrorNumber").css("display", "block");
        }

        if ($("#description").val() == "") {
            e.preventDefault();
            $("#descriptionError").css("display", "block");
        }
        else {
            $("#descriptionError").css("display", "none");
        }

        if ($("#description").val().length > 50) {
            e.preventDefault();
            $("#descriptionErrorMax").css("display", "block");
        }
        else {
            $("#descriptionErrorMax").css("display", "none");
        }
    });
});