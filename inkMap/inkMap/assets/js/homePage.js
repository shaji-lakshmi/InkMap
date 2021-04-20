function showSignInContent() {
    var target = document.getElementById("LandingMenu");
    var showTarget = document.getElementById("signInModule");
    target.style.display = "none";
    showTarget.style.display = "block";
}

function showLandingMenu() {
    var showTarget = document.getElementById("LandingMenu");
    var target = document.getElementById("signInModule");
    var createModule = document.getElementById("createAccountModule");
    var createTitle = document.getElementById("createAccountTitle");
    showTarget.style.display = "block";
    target.style.display = "none";
    createModule.style.display = "none";
    createTitle.style.display = "none";
}

function showCustomerAccountModule() {
    var target = document.getElementById("LandingMenu");
    var showTargetHeading = document.getElementById("createAccountTitle");
    var showTarget = document.getElementById("createAccountModule");
    target.style.display = "none";
    showTarget.style.display = "flex";
    showTargetHeading.style.display = "flex";
}