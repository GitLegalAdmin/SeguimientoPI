/// <reference path="../config/jsendpoints.js" />

var ClientesCreate = {
    GetResponsable: function () {
        fetch(apiEndpoints.clientes.Getresponsables)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.Responsables = data;
                ClientesCreate.FillSelect('responsable', data);
            });
    },
    GetTipoComunicacion: function () {
        fetch(apiEndpoints.clientes.GetTipoComunicacion)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.TipoComunicacion = data;
                ClientesCreate.FillSelect('tipoComunicacion', data);
            });
    },
    GetMoneda: function () {
        fetch(apiEndpoints.clientes.GetMoneda)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.Moneda = data;
                ClientesCreate.FillSelect('moneda', data);
            });
    },
    GetTipoCliente: function () {
        fetch(apiEndpoints.clientes.GetTipoCliente)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.TipoCliente = data;
                ClientesCreate.FillSelect('tipoCliente', data);
            });
    },
    GetIdioma: function () {
        fetch(apiEndpoints.clientes.Getidioma)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.Idioma = data;
                ClientesCreate.FillSelect('idioma', data);
            });
    },
    GetTipoTarifa: function () {
        fetch(apiEndpoints.clientes.GetTipoTarifa)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.TipoTarifa = data;
                ClientesCreate.FillSelect('tipoTarifa', data);
            });
    },
    FillSelect: function (selectId, data) {
        var select = document.getElementById(selectId);
        select.innerHTML = ''; // Limpiar opciones existentes
        data.forEach(function (item) {
            var option = document.createElement('option');
            option.value = item.value; // Asume que los datos tienen una propiedad 'value'
            option.text = item.text; // Asume que los datos tienen una propiedad 'text'
            select.appendChild(option);
        });
    },
    oncreate: function (vnode) {
        // Inicializar los elementos de la vista
    },
    onupdate: function (vnode) {
        // Actualizar los elementos de la vista
    },
    Responsables: [],
    TipoComunicacion: [],
    Moneda: [],
    TipoCliente: [],
    Idioma: [],
    TipoTarifa: []
}

$(document).ready(function () {
    ClientesCreate.GetIdioma();
    ClientesCreate.GetMoneda();
    ClientesCreate.GetResponsable();
    ClientesCreate.GetTipoCliente();
    ClientesCreate.GetTipoComunicacion();
    ClientesCreate.GetTipoTarifa();
});
