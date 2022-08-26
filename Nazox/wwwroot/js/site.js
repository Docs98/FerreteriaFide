function verificacioncorreo() {

    var Email = $('#EmailUser').val()
    var username = $('#NameUser').val()
    var userpassword = $('#PasslUser').val()
    var userTel = $('#TeleflUser').val()

    if ((Email == "") || (username == "") || (userpassword == "") || (userTel == "")) {
        alert("Los campos no pueden quedar vacios");
        return false;
    }


    re = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (!re.test(Email)) {
        alert('email no valido');
        return false;
    }
}