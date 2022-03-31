const getData = (id) => {
    let dataJson = localStorage.getItem(id);
    let data = [];

    if (dataJson !== null) {
        data = JSON.parse(dataJson);
    }

    return data;
};

const setData = (id, newData) => {
    const data = getData(id);

    localStorage.setItem(id, JSON.stringify([...data, newData]));

    return data.length;
};

const validInput = (data) => {
    let errorMessage = "";

    if (data.txtFirstName === "") {
        errorMessage += "First name is required<br>";
    }
    if (data.txtLastName === "") {
        errorMessage += "Last name is required<br>";
    }
    if (data.txtAddress === "") {
        errorMessage += "Address is required<br>";
    }
    if (data.txtCity === "") {
        errorMessage += "City is required<br>";
    }
    if (data.txtEmail === "") {
        errorMessage += "Email address is required<br>";
    }

    const postalCodeRegex = new RegExp(
        /^[ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVXY][ -]?\d[ABCEGHJKLMNPRSTVXY]\d$/i
    );
    if (data.txtPostalCode === "") {
        errorMessage += "Postal code is required<br>";
    } else if (!postalCodeRegex.test(data.txtPostalCode.toUpperCase())) {
        errorMessage += "Postal code is not valid<br>";
    }
    const phoneCodeRegex = new RegExp(
        /^([(]\d{3}[)](\d{3})-(\d{4}))|((\d{3})-(\d{3})-(\d{4}))$/i
    );
    if (data.txtPhone === "") {
        errorMessage += "Phone is required<br>";
    } else if (!phoneCodeRegex.test(data.txtPhone)) {
        errorMessage += "Phone is not valid<br>";
    }

    if (data.txtMake === "") {
        errorMessage += "Make is required<br>";
    }
    const yearCodeRegex = new RegExp(/^([0-9]{4})$/);
    if (data.txtYear === "") {
        errorMessage += "Year is required<br>";
    } else if (!yearCodeRegex.test(data.txtYear)) {
        errorMessage += "Year is not valid<br>";
    }
    if (data.txtModel === "") {
        errorMessage += "Model is required<br>";
    }

    return errorMessage;
};

export { getData, setData, validInput };