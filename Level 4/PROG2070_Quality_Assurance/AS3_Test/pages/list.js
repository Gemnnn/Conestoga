import { getData } from "./function.js";

const listSection = document.getElementById("listSection");

const init = async () => {
    const data = getData("db");
    const container = listSection.childNodes[1];

    for (let i = 0; i < data.length; i++) {
        const viewContent = document.createElement("div");
        const input = data[i];
        viewContent.className = "viewContent";
        viewContent.innerHTML = `
    
        <h4 class="title">Seller's Information</h4>
        <h4 class="title">Vehicle's Information</h4>
        <div class="information">
            <div><span>First Name: </span>${input.txtFirstName}</div>
            <div><span>Last Name: </span>${input.txtLastName}</div>
            <div><span>Address: </span>${input.txtAddress}</div>
            <div><span>City: </span>${input.txtCity}</div>
            <div><span>Province: </span>${input.txtProvince.toUpperCase()}</div>
            <div><span>Postal Code: </span>${input.txtPostalCode}</div>
            <div><span>Phone Number: </span>${input.txtPhone}</div>
            <div><span>Email: </span>${input.txtEmail}</div>
        </div>
    
        <div class="information">
            <div><span>Make: </span>${input.txtMake}</div>
            <div><span>Model: </span>${input.txtModel}</div>
            <div><span>Year: </span>${input.txtYear}</div>
            <div><span>JD Power: </span><a href="http://www.jdpower.com/cars/${
            input.txtYear
        }/${input.make}/${input.model}">http://www.jdpower.com/cars/${
            input.txtYear
        }/${input.make}/${input.model}</a></div>
        </div>`;
        container.append(viewContent);
    }
};

window.addEventListener("DOMContentLoaded", init);