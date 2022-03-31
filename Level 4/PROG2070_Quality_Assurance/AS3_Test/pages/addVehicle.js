import { setData, validInput } from "./function.js";

const firstName = document.getElementById("txtFirstName");
const lastName = document.getElementById("txtLastName");
const address = document.getElementById("txtAddress");
const city = document.getElementById("txtCity");
const province = document.getElementById("txtProvince");
const postalCode = document.getElementById("txtPostalCode");
const phone = document.getElementById("txtPhone");
const email = document.getElementById("txtEmail");
const make = document.getElementById("txtMake");
const model = document.getElementById("txtModel");
const year = document.getElementById("txtYear");


const error = document.querySelector(".error");
const addVehicleForm = document.getElementById("addVehicleForm");

addVehicleForm.addEventListener("submit", (e) => {
    e.preventDefault();



    const data = {
        txtFirstName: firstName.value,
        txtLastName: lastName.value,
        txtAddress: address.value,
        txtCity: city.value,
        txtProvince: province.value,
        txtPostalCode: postalCode.value,
        txtPhone: phone.value,
        txtEmail: email.value,
        txtMake: make.value,
        txtModel: model.value,
        txtYear: year.value,
    };
    let errorMessage = validInput(data);
    error.innerHTML = errorMessage;

    if (errorMessage === "") {
        const id = setData("db", data);
        window.location.href = `/AS3_Test/view.html?id=${id}`;
    }
});