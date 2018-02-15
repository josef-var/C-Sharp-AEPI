document.getElementById("Back").addEventListener("click", goBack);
document.getElementById("NewGame").addEventListener("click", NewGame);
document.getElementById("Lesser").addEventListener("click", Lesser);
document.getElementById("Greater").addEventListener("click", Greater);

var tries;
var min;
var max;
var random;

function NewGame() {
    tries = 0;
    min = 1;
    max = 1000;
    random = 500;
    document.getElementById("pcnr").value = random;
    document.getElementById("tries").value = tries;
    document.getElementById("min").innerHTML = min;
    document.getElementById("max").innerHTML = max;
}

function getRandomInt(min, max) {
    console.log(min + "-" + max);
	tries++;
    document.getElementById("tries").value = tries;
    document.getElementById("min").innerHTML = min;
    document.getElementById("max").innerHTML = max;
	document.getElementById("pcnr").value = Math.floor(Math.random() * (max - min + 1)) + min;
}

function Lesser() {
    max = parseInt(document.getElementById("pcnr").value);
    getRandomInt(min, max);
}
function Greater() {
    min = parseInt(document.getElementById("pcnr").value);
    getRandomInt(min, max);
}
function goBack() {
    window.history.back();
}
