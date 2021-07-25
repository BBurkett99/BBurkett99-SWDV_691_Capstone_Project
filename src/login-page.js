/*Login page until the database is up and running*/


const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");

loginButton.addEventListener("click", (e) => {
    e.preventDefault();
    const username = loginForm.username.value;
    const password = loginForm.password.value;

    if (username === "user" && password === "password") {
        alert("You have successfully logged in.");
        location.reload();
       window.location.href = "http://trackingyourhealth/home.html/azurewebsites.net/";
    } else {
        loginErrorMsg.style.opacity = 1;
    }
})
