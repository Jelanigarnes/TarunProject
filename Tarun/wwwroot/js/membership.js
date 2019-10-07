"use strict";

var errorMsg = "";

function checkEmptyInputs() {
    var inputBoxes = document.querySelectorAll('form input');
    var province = document.getElementById("province");
    var tags = ["First Name", "Last Name", "Address", "City", "Postal Code", "Age", "Password", "Confirm Password", "Email"];

    //This function checks all inut boxes and ensures that there is no blank field
    for (var i = 0; i < inputBoxes.length; i++) {
        if (inputBoxes[i].value === null || inputBoxes[i].value.trim() === "") {
            SetInputBoxToError(inputBoxes[i]);
            errorMsg += "Please enter a value for " + tags[i] + ".<br>";
        } else {
            SetInputBoxToDefault(inputBoxes[i]);

            if (i === 4) {
                //do additional checks for postalcode
                checkPostalCodeFormat();
            } else if (i === 5) {
                //when the counter is "age", do the additional checks for age
                checkAge();
            } else if (i === 6) {
                //checks passwords
                checkPasswordLength();
            } else if (i === 7) {
                checkIfPasswordsMatch();
            }
            else if (i === 8) {
                //do checks when the counter reaches "email"
                checkEmailFormat();
            }
        }
    }

    //also checks if the select box has a selection
    if (province.selectedIndex === -1) {
        errorMsg += "Please select a value for Province.<br>";
        SetInputBoxToError(province);
    } else {
        SetInputBoxToDefault(province);
    }
}

function checkIfPasswordsMatch() {
    var password = document.getElementById("password");
    var confirmPassword = document.getElementById("confirmPassword");
    if (confirmPassword.value !== password.value) {
        errorMsg += "The passwords didn't match!<br>";
        SetInputBoxToError(confirmPassword);
        SetInputBoxToError(password);
    } else {
        SetInputBoxToDefault(password);
        SetInputBoxToDefault(confirmPassword);
    }
}

function checkPostalCodeFormat() {
    var postalCode = document.getElementById("postalCode");
    var postalCodeProtocol = /[A-Z][0-9][A-Z][0-9][A-Z][0-9]/;
    if (postalCodeProtocol.test(postalCode.value.toUpperCase())) {
        SetInputBoxToDefault(postalCode);
    }
    else {
        errorMsg += "The postal code has to be in the A0A0A0 format.<br>";
        SetInputBoxToError(postalCode);
    }
}

function SetInputBoxToError(inputBox) {
    inputBox.style.backgroundColor = "pink";
}

function SetInputBoxToDefault(inputBox) {
    inputBox.style.backgroundColor = "";
}

function checkAge() {
    var age = document.getElementById("age");
    if (age.value < 18) {
        errorMsg += "The minimum age allowed is 18 years old.<br>";
        SetInputBoxToError(age);
    } else {
        SetInputBoxToDefault(age);
    }
}

function checkPasswordLength() {
    //This method will check the passwords length, and see if its < 6
    // as well as if they match
    var password = document.getElementById("password");
    if (password.value.length < 6) {
        errorMsg += "Please enter a password with a length of 6 or greater.<br>"
        SetInputBoxToError(password);
    } else {
        SetInputBoxToDefault(password);
    }
}

function checkEmailFormat() {
    //checks if there is an "@" and a "." in the email address
    //also checks if there are any characters preceding and proceeding the "@" & "."

    var email = document.getElementById("email");
    var emailProtocol = /\S+@\S+\.\S/;
    if (emailProtocol.test(email.value.toUpperCase())) {
        SetInputBoxToDefault(email);
    }
    else {
        errorMsg += "The entered email is in incorrect format.<br>";
        SetInputBoxToError(email);
    }
}

function setUpPage(event) {
    event.preventDefault();
    document.getElementById("errorDisplay").innerHTML = "";
    createEventListeners();
    displayErrorStyle("default");

    var inputBoxes = document.querySelectorAll("form input");
    var province = document.getElementById("province");
    province.selectedIndex = -1;

    SetInputBoxToDefault(province);
    for (var i = 0; i < inputBoxes.length; i++) {
        if (i === inputBoxes.length - 2) {
            //if the input buttons are reached, then break the loop to not  mess with how they look, and not change their text value.
            break;
        }

        inputBoxes[i].value = "";
        SetInputBoxToDefault(inputBoxes[i]);
    }
}

function validateForm(event) {
    errorMsg = "";
    event.preventDefault();
    checkEmptyInputs();

    var errorDisplay = document.getElementById("errorDisplay");
    errorDisplay.innerHTML = errorMsg;

    if (errorMsg !== "") {
        displayErrorStyle("red");
    } else {
        displaySuccessMessage();
    }
}

function displaySuccessMessage() {
    var name = document.getElementById("firstName").value + " " + document.getElementById("lastName").value;
    removeInputButtons();
    setAllInputFieldsToDisabled();
    displayErrorStyle("green");
    document.getElementById("errorDisplay").innerHTML = "Thank you " + name + ", you've successfully submitted your application!"
}

function setAllInputFieldsToDisabled() {
    //sets all the input fields to be disabled after the submission has been successful.
    var inputBoxes = document.querySelectorAll('form input');

    document.getElementById("province").disabled = true;
    for (var i = 0; i < inputBoxes.length; i++) {
        inputBoxes[i].disabled = true;
    }
}

function removeInputButtons() {
    //removes both the "clear" and "submit" buttons in the form if the 
    //submission is successful!
    var form = document.getElementsByTagName("form")[0];

    form.removeChild(form.lastElementChild);
    form.removeChild(form.lastElementChild);
}

function displayErrorStyle(colour) {
    //shows the "error message" style, it also shows the "success message" style, or even no message style.

    var errorDisplay = document.getElementById("errorDisplay");
    if (colour === "red") {
        errorDisplay.style.border = "2px solid red";
        errorDisplay.style.padding = "10px";
    } else if (colour === "green") {
        errorDisplay.style.border = "2px solid green";
        errorDisplay.style.padding = "10px";
        errorDisplay.style.backgroundColor = "lightgreen";
        document.getElementsByClassName("jumbotron")[0].style.backgroundColor = "lightgreen";
    } else if (colour === "default") {
        errorDisplay.style.border = "";
        errorDisplay.style.padding = "";
    }
}

function createEventListeners() {
    document.getElementById("submit").addEventListener("click", validateForm, false);
    document.getElementById("reset").addEventListener("click", setUpPage, false);
}

window.addEventListener("load", setUpPage, false);