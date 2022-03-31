import { getData } from "./function.js";

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
const jdPower = document.getElementById("jdPower");

const init = async () => {
    let query = window.location.search;
    let param = new URLSearchParams(query);
    let id = param.get("id");
    let data = getData("db")[id];

    firstName.value = data.txtFirstName;
    lastName.value = data.txtLastName;
    address.value = data.txtAddress;
    city.value = data.txtCity;
    province.value = data.txtProvince;
    postalCode.value = data.txtPostalCode;
    phone.value = data.txtPhone;
    email.value = data.txtEmail;
    make.value = data.txtMake;
    model.value = data.txtModel;
    year.value = data.txtYear;
    jdPower.textContent = `http://www.jdpower.com/cars/${year.value}/${make.value}/${model.value}`;
    jdPower.href = `http://www.jdpower.com/cars/${year.value}/${make.value}/${model.value}`;

    console.log(data);
};

window.addEventListener("DOMContentLoaded", init);