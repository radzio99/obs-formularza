function validateForm() {
    var form = document.getElementById("registrationForm");
    var name = form.querySelector("[name='Imie']").value;
    var surname = form.querySelector("[name='Nazwisko']").value;
    var email = form.querySelector("[name='Email']").value;
    var password = form.querySelector("[name='Haslo']").value;
    var confirmPassword = form.querySelector("[name='PotwierdzenieHasla']").value;
    var phone = form.querySelector("[name='NumerTelefonu']").value;
    var age = form.querySelector("[name='Wiek']").value;

    var isValid = true;

    if (name.length < 2) {
        document.getElementById("nameError").innerText = "Imię musi zawierać minimum 2 znaki";
        isValid = false;
    } else {
        document.getElementById("nameError").innerText = "";
    }

    if (surname.length < 2) {
        document.getElementById("surnameError").innerText = "Nazwisko musi zawierać minimum 2 znaki";
        isValid = false;
    } else {
        document.getElementById("surnameError").innerText = "";
    }

    var emailRegex = /.+@.+\..+/;
    if (!emailRegex.test(email)) {
        document.getElementById("emailError").innerText = "Podaj poprawny adres email";
        isValid = false;
    } else {
        document.getElementById("emailError").innerText = "";
    }

    var passwordRegex = /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$/;
    if (!passwordRegex.test(password)) {
        document.getElementById("passwordError").innerText = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą i małą literę oraz mieć co najmniej 8 znaków.";
        isValid = false;
    } else {
        document.getElementById("passwordError").innerText = "";
    }

    if (password !== confirmPassword) {
        document.getElementById("confirmPasswordError").innerText = "Hasło i jego potwierdzenie nie są takie same";
        isValid = false;
    } else {
        document.getElementById("confirmPasswordError").innerText = "";
    }

    var phoneRegex = /^[0-9]{9}$/; 
    if (!phoneRegex.test(phone)) {
        document.getElementById("phoneError").innerText = "Podaj poprawny numer telefonu (9 cyfr)";
        isValid = false;
    } else {
        document.getElementById("phoneError").innerText = "";
    }

    var ageInt = parseInt(age);
    if (isNaN(ageInt) || ageInt < 10 || ageInt > 80) {
        document.getElementById("ageError").innerText = "Wiek musi być liczbą między 10 a 80";
        isValid = false;
    } else {
        document.getElementById("ageError").innerText = "";
    }

    return isValid;
}
