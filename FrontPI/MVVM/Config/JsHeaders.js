const originalFetch = window.fetch;
const originalAjax = $.ajax;

// Sobrescribe el comportamiento de fetch para agregar el encabezado Authorization
window.fetch = function (url, options) {
    // Si no se proporcionaron opciones, inicializa options como un objeto vacío
    options = options || {};

    // Si no hay un encabezado 'headers', inicializa headers como un objeto vacío
    options.headers = options.headers || {};

    // Agrega el encabezado de autorización a las opciones
    options.headers['Authorization'] = `Bearer ${localStorage.getItem('token')}`;

    // Llama al fetch original con las opciones modificadas
    return originalFetch(url, options);
};

// Sobrescribe el comportamiento de $.ajax para agregar el encabezado Authorization
$.ajax = function (options) {
    // Si options es una string, conviértela en un objeto (para casos donde solo se pasa la URL)
    if (typeof options === 'string') {
        options = { url: options };
    }

    // Inicializa headers si no existe
    options.headers = options.headers || {};

    // Agrega el encabezado de autorización
    options.headers['Authorization'] = `Bearer ${localStorage.getItem('token')}`;

    // Llama al ajax original con las opciones modificadas
    return originalAjax.call(this, options);
};

