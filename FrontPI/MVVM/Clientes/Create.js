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
    GetTipoEnvioFac: function () {
        fetch(apiEndpoints.clientes.GetTipoEnvioFac)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.TipoEnvioFac = data;
                ClientesCreate.FillSelect('tipoEnvioFac', data);
            });
    },
    GetProveedorFacElec: function () {
        fetch(apiEndpoints.clientes.GetProveedorFacElec)
            .then(response => response.json())
            .then(data => {
                ClientesCreate.ProveedorFacElec = data;
                ClientesCreate.FillSelect('proveedorFacElec', data);
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
    Guardar: function (event) {
        event.preventDefault(); // Prevenir el envío del formulario por defecto

        var form = event.target;
        var formData = {
            ClienteId: 0, // Asignar un valor por defecto o manejarlo según tu lógica
            ClienteClave: null, // Asignar un valor por defecto o manejarlo según tu lógica
            ClienteNombre: form.clienteNombre.value,
            ClienteTipoPersonaSAT: null, // Asignar un valor por defecto o manejarlo según tu lógica
            ClienteRFC: form.clienteRFC.value,
            ClienteCurp: form.clienteCUP.value,
            ClienteVAT: form.clienteVAT.value,
            IdiomaId: parseInt(form.idioma.value),
            TipoComunicacionId: parseInt(form.tipoComunicacion.value),
            TipoClienteId: parseInt(form.tipoCliente.value),
            MonedaId: parseInt(form.moneda.value),
            ClienteWebSite: form.clienteWebSite.value,
            ClienteEmail: form.clienteEmail.value,
            ProveedorFacElecId: parseInt(form.proveedorFacElec.value),
            TipoEnvioFacId: parseInt(form.tipoEnvioFac.value),
            ClienteObservacion: form.clienteObservacion.value,
            ClienteRecMarca: null, // Asignar un valor por defecto o manejarlo según tu lógica
            ClienteRecPatente: null, // Asignar un valor por defecto o manejarlo según tu lógica
            ClienteFechaAlta: null, // Asignar un valor por defecto o manejarlo según tu lógica
            ResponsableId: parseInt(form.responsable.value),
            TipoTarifaId: parseInt(form.tipoTarifa.value),
            Usuarioregistra: null // Asignar un valor por defecto o manejarlo según tu lógica
        };

        fetch(apiEndpoints.clientes.Guardar, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(formData)
        })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    alert('Cliente guardado exitosamente');
                    // Redirigir o realizar alguna acción adicional
                } else {
                    alert('Error al guardar el cliente');
                }
            })
            .catch(error => {
                console.error('Error:', error);
                alert('Error al guardar el cliente');
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
    TipoTarifa: [],
    TipoEnvioFac: [],
    ProveedorFacElec: []
}

$(document).ready(function () {
    ClientesCreate.GetIdioma();
    ClientesCreate.GetMoneda();
    ClientesCreate.GetResponsable();
    ClientesCreate.GetTipoCliente();
    ClientesCreate.GetTipoComunicacion();
    ClientesCreate.GetTipoTarifa();
    ClientesCreate.GetTipoEnvioFac();
    ClientesCreate.GetProveedorFacElec();
});
