/*Brad Burkett

Login Page

SWDV 691: Capstone Project
*/


const loginForm = document.getElementById("login-form");
const loginButton = document.getElementById("login-form-submit");
const loginErrorMsg = document.getElementById("login-error-msg");
/*This is sample until the database is connected*/
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
