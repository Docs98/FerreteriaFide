function verificacioncorreo() {
    var Email = $('#EmailUser').val()
    re = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (!re.test(Email)) {
        alert('email no valido');
        return false;
    }
    else alert('email valido');
}