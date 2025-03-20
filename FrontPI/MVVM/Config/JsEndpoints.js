const baseUrl = 'https://localhost:7236'; // URL base de tu API

const apiEndpoints = {
    //auth: {
    //    login: `${baseUrl}/api/auth/login`
    //},
    users: {
        gral: `${baseUrl}/api/Users`,
        add: `${baseUrl}/api/Users/add`,
        edit: (id) => `${baseUrl}/api/Users/edit/${id}`,
        changePassword: (id) => `${baseUrl}/api/users/change-password/${id}`,
        delete: (id) => `${baseUrl}/api/users/${id}`,
        getByUserName: (userName) => `${baseUrl}/api/users/getByUserName${userName}`
    },
    clientes: {
        gral: `${baseUrl}/api/Clientes`,
        selectAll: `${baseUrl}/api/Clientes/SelectAll`, //Ejemplo
    }
};



