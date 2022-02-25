var sendInvoice = false;

function itemChecked(){
    document.getElementById('olmessage').innerHTML = "";
    document.getElementById('olmessage').style.color="blue";
    var yellow = item1.value + " has been added." + "<br/>";
    var purple = item2.value + " has been added." + "<br/>";
    var orange = item3.value + " has been added." + "<br/>";
    var green = item4.value + " has been added." + "<br/>";
    var blue = item5.value + " has been added." + "<br/>";
    var black = item6.value + " has been added." + "<br/>";
    
    document.getElementById('olmessage').style.color="red";
    var price = 0;
    
    if (item1.checked){
        document.getElementById('olmessage').innerHTML += yellow
        price = price + 6;
    }
    if (item1.unchecked){
        price = price - 6;
    }
    if (item2.checked){
        document.getElementById('olmessage').innerHTML += purple
        price = price + 6;
    }
    if (item2.unchecked){
        price = price - 6;
    }
    if (item3.checked){
        document.getElementById('olmessage').innerHTML += orange
        price = price + 6;
    }
    if (item3.unchecked){
        price = price - 6;
    }
    if (item4.checked){
        document.getElementById('olmessage').innerHTML += green
        price = price + 6;
    }
    if (item4.unchecked){
        price = price - 6;
    }
    if (item5.checked){
        document.getElementById('olmessage').innerHTML += blue
        price = price + 6;
    }
    if (item5.unchecked){
        price = price - 6;
    }
    if (item6.checked){
        document.getElementById('olmessage').innerHTML += black
        price = price + 6;
    }
    if (item6.unchecked){
        price = price - 6;
    }
    document.getElementById('orderTotal').innerHTML = "$ " + price;
    
    if (price<10){
        sendInvoice = false;
    }
    else{
        sendInvoice = true;
        return money = price;
    }
}

function validCheck(){
        var userProvince = document.getElementById("selProvince");
        var selectedValue = userProvince.options[userProvince.selectedIndex].value;
        InvoiceDisplay()
        pcheck()
        noEmpty(txtName, "Please enter your name", nameError)
        noEmpty(txtAddress1, "Please enter your address", addressError)
        creditCheck(credit, "Credit Number must be" + "<br/>" + "0000-0000-0000-0000 format", creditError)
        emailCheck(email, "E-mail format must be \"test@test.com\"", emailError)
        noEmpty(txtCity, "Please enter your city", cityError)
        provinceCheck(selectedValue, "Province must be selected", proviceError)
        passwordCheck(txtPassword, txtConfirm, "Password and Confirm must be the same", confirmError)
    }
    
function preValidCheck(isValid, errMessage, errElement, input){
    if (!isValid){
        if (errMessage !== undefined && errMessage !== null 
        && errElement !== undefined && errElement !== null){
            errElement.innerHTML = errMessage;
        }
        if (input !== undefined && input !== null){
            input.classList.add("errorbox");
            input.focus();
        }
    }
    else {
        if (errElement !== undefined && errElement !== null){
            errElement.innerHTML ="";
        }
        if (input !== undefined && input !== null){
            input.classList.remove("errorbox");
        }
    }
}

function noEmpty(input, errMessage, errElement){
    var isValid = (input.value.trim() !== "");
    preValidCheck(isValid, errMessage, errElement, input);
    return isValid;
}

function creditCheck(input, errMessage, errElement){
    var isValid = (input.value.trim().match(/^\d{4}[-]\d{4}[-]\d{4}[-]\d{4}$/) !== null);
    preValidCheck(isValid, errMessage, errElement, input);
    return isValid;
}

function emailCheck(input, errMessage, errElement){
    var isValid = (input.value.trim().match
    (/^\w+([\.-]?\w+)*@\w([\.-]?\w+)*(\.\w{1,3})+(\.\w{2,3})?$/))
    preValidCheck(isValid, errMessage, errElement, input);
    return isValid;
}

function provinceCheck(input, errMessage, errElement){
    var isValid = input;
    preValidCheck(isValid, errMessage, errElement, input);
    return isValid;
}


function pcheck(){
    inputPassword = document.getElementById('txtPassword').value;
    inputConfirm = document.getElementById('txtConfirm').value;
    if (inputPassword =="" && inputConfirm ==""){
        document.getElementById('confirmError').innerHTML = "";
    }
    else if (inputPassword === inputConfirm){
        document.getElementById('confirmError').style.color = "green";
        document.getElementById('confirmError').innerHTML = "Password matching";
    }
    if (inputPassword !== inputConfirm){
        document.getElementById('confirmError').style.color = "red";
        document.getElementById('confirmError').innerHTML = "Password must be matched";
    }
}


function InvoiceDisplay(){
    if (sendInvoice == true){
        calculatePrice(money)
        document.getElementById('InvoiceError').style.color = "Green";
        document.getElementById('InvoiceError').innerHTML = "The minimum amount has been fulfilled.";
        document.getElementById('InvoiceName').innerHTML = txtName.value;
        document.getElementById('InvoiceAddress1').innerHTML = txtAddress1.value;
        document.getElementById('InvoiceAddress2').innerHTML = txtAddress2.value;
        document.getElementById('InvoiceCreditCard').innerHTML = credit.value;
        document.getElementById('InvoiceCity').innerHTML = txtCity.value;
        document.getElementById('InvoiceEmail').innerHTML = email.value;
        document.getElementById('InvoicePassword').innerHTML = txtPassword.value;
        document.getElementById('InvoiceProvince').innerHTML = document.getElementById("selProvince").value;   
    }
    else if (sendInvoice == false){
        document.getElementById('InvoiceError').style.color = "red";
        document.getElementById('InvoiceError').innerHTML = "The price must be at least $10";
        document.getElementById('InvoiceName').innerHTML = "";
        document.getElementById('InvoiceAddress1').innerHTML = "";
        document.getElementById('InvoiceAddress2').innerHTML = "";
        document.getElementById('InvoiceCreditCard').innerHTML = "";
        document.getElementById('InvoiceCity').innerHTML = "";
        document.getElementById('InvoiceEmail').innerHTML = "";
        document.getElementById('InvoicePassword').innerHTML = "";
        document.getElementById('InvoiceProvince').innerHTML = "";    
        document.getElementById('InvoicePrice').innerHTML = "";
        document.getElementById('InvoiceTax').innerHTML = "";
        document.getElementById('InvoiceTotal').innerHTML = "";   
    }
}

function calculatePrice(price){
    var taxprice = price * 0.13;
    var tatal = taxprice + price;

    document.getElementById('InvoicePrice').innerHTML = price;
    document.getElementById('InvoiceTax').innerHTML = taxprice;
    document.getElementById('InvoiceTotal').innerHTML = tatal;
}
