$(document).ready(function () {
    // Verificar autenticación al cargar el SPA
    const token = localStorage.getItem('token');
    if (!token) {
        window.location.href = 'auth_login.html'; // Redirigir al login si no hay token
        return;
    }

    // Cargar la vista inicial
    loadView('Home/Index');

    // Manejar la navegación
    $('.treeview-menu a').on('click', function (e) {
        e.preventDefault();
        const view = $(this).data('view');
        console.log(view);
        loadView(view);
    });

    // Manejar el logout
    $('#logoutButton').on('click', function (e) {
        e.preventDefault();
        localStorage.removeItem('token');
        window.location.href = 'auth_login.html'; // Redirigir al login
    });

    // Función para cargar vistas
    function loadView(view) {
        $.get(`views/${view}.html`, function (data) {
            $('#MainContent').html(data);
        }).fail(function () {
            $('#MainContent').html('<p>Error cargando la vista.</p>');
        });
    }
});