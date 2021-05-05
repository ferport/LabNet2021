$(document).ready(function() {

    $("#nombre").focusout(function(){
        if($("#nombre").val() == "")
        {
            $("#errorNombre").css("display","flex");
       
        }
        else
        {
            $("#errorNombre").css("display","none");
            return 0;
        }    
    });
    

    $("#apellido").focusout(function(){
        if($("#apellido").val() == "")
        {
            $("#errorApellido").css("display","flex");
            return 1;
        }
        else
        {
            $("#errorApellido").css("display","none");
            return 0;
        }
        
    });

    $("#enviar").click(function(e){
        if($("#apellido").val() == "")
        {
            e.preventDefault();
            $("#errorApellido").css("display","flex");
        }
        else
        {
            $("#errorApellido").css("display","none");
        }

        if($("#nombre").val() == "")
        {
            e.preventDefault();
            $("#errorNombre").css("display","flex");
        }
        else
        {
            $("#errorNombre").css("display","none");
        }    
    });

    $("#limpiar").click(function(){
        $(".limpiar").val("");
    });
});

