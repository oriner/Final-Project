document.addEventListener("DOMContentLoaded", function() {
    const form = document.querySelector("form");
    const usernameInput = document.getElementById("Username");
    const passwordInput = document.getElementById("Password");

    form.addEventListener("submit", function(event) {
        let valid = true;
        
        // Clear previous error messages
        document.querySelectorAll(".error").forEach(function(el) {
            el.textContent = "";
        });

        // Validate username
        if (usernameInput.value.trim() === "") {
            valid = false;
            const error = document.createElement("div");
            error.className = "error";
            error.textContent = "Username is required.";
            usernameInput.parentNode.appendChild(error);
        }

        // Validate password
        if (passwordInput.value.trim() === "") {
            valid = false;
            const error = document.createElement("div");
            error.className = "error";
            error.textContent = "Password is required.";
            passwordInput.parentNode.appendChild(error);
        }

        if (!valid) {
            event.preventDefault();
        }
    });
});
