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

        console.log(bodypost);

        $.ajax({
            url: 'https://localhost:7236/api/auth/login', // URL del backend
            type: 'POST',
            contentType: 'application/json',
            data: bodypost,
            success: function (response) {
                localStorage.setItem('token', response.token);
                window.location.href = 'index.html'; // Redirigir al SPA
            },
            error: function () {
                $('#loginMessage').text('Error en el login').css('color', 'red');
            }
        });
    });
});