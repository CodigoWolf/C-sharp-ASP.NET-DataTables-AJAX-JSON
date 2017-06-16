function __login() {
    $("#login-form").on("submit", function(e){
        e.preventDefault();

        var data = {
            objUsuario: {
                idUsuario: 1,
                user: $("#usuario").val(),
                password: $("#password").val()
            }
        }

        $.ajax({
            method: "POST",
            url: "Index.aspx/Login",
            data: JSON.stringify(data),
            contentType: "application/json; charset=utf-8",
            dataType: "json"
        }).done(function (info) {
            //Respuesta del servidor
            console.log(info);
            $(".mensaje").html( info.d );
        })



    });
}