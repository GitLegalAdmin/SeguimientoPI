$(document).ready(function () {
    $('#loginForm').on('submit', function (e) {
        e.preventDefault();
        const username = $('#Username').val();
        const password = $('#Password').val();

        var login = {
            Username: username,
            Password: password
        }
        var bodypost = JSON.stringify(login);

        $.ajax({
            url: 'https://localhost:7236/api/auth/login', // URL del backend
            type: 'POST',
            contentType: 'application/json',
            data: bodypost,
            success: function (response) {
                //console.log(response);
                localStorage.setItem('token', response.token);
                localStorage.setItem('user', JSON.stringify(response.user));
                window.location.href = 'index.html'; // Redirigir al SPA
            },
            error: function () {
                $('#loginMessage').text('Error en el login').css('color', 'red');
            }
        });
    });
});