/// <reference path="../config/jsendpoints.js" />

var ClientesCreate = {
    GetClientes: function () {
        fetch(apiEndpoints.clientes.selectAll)
            .then(response => response.json())
            .then(data => {
                console.log("Datos que llegan del API:", data);
                ClientesCreate.Clientes = data;
                ClientesCreate.FillDataTable('tClientes', data);
            });
    },
    FillDataTable: function (tableId, data) {
        $('#' + tableId).DataTable({
            data: data,
            columns: [
                { title: "ID", data: "clienteId" },
                { title: "Nombre", data: "clienteNombre" },
                { title: "RFC", data: "clienteRFC" },
                { title: "CURP", data: "clienteCurp" },
                { title: "VAT", data: "clienteVAT" },
                { title: "Idioma", data: "idiomaDescripcion" },
                { title: "Tipo Comunicación", data: "tipoComunicacionDescrip" },
                { title: "Tipo Cliente", data: "tipoClienteDescrip" },
                { title: "Moneda", data: "monedaDescrip" },
                { title: "Sitio Web", data: "clienteWebSite" },
                { title: "Email", data: "clienteEmail" },
                { title: "Proveedor Fac. Elec.", data: "proveedorFacElecDescrip" },
                { title: "Tipo Envío Fac.", data: "tipoEnvioFacDescrip" },
                { title: "Observaciones", data: "clienteObservacion" },
                { title: "Responsable", data: "responsableNombre" },
                { title: "Tipo Tarifa", data: "tipotarifaDescrip" }
            ],
            destroy: true // Permite reinicializar la tabla
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
    Clientes: [],
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
    ClientesCreate.GetClientes();
   
});
