
const gradovi = {
	"beograd": {
		ime: "Beograd",
		tekst: "Beograd, Beograd, Beograd......"
	},
	"novi-sad": {
		ime: "Novi Sad",
		tekst: "Novi Sad, Novi Sad, Novi Sad......"
	},
	"kraljevo": {
		ime: "Kraljevo",
		tekst: "Kraljevo, Kraljevo, Kraljevo......"
	},
	"nis": {
		ime: "Niš",
		tekst: "Niš, Niš, Niš......"
	},
	"kragujevac": {
		ime: "Kragujevac",
		tekst: "Kragujevac, Kragujevac, Kragujevac......"
	}
};

window.onload = () => {
	const params = new URLSearchParams(window.location.search);
	const grad = params.get("grad");
	if (grad && gradovi[grad]) {
		document.getElementById("grad-ime").innerText = gradovi[grad].ime;
		document.getElementById("grad-tekst").innerText = gradovi[grad].tekst;
	} else {
		document.getElementById("grad-ime").innerText = "Nepoznat grad";
		document.getElementById("grad-tekst").innerText = "Nema informacija.";
	}
};

const URL = "https://naslovi.net/vremenska-prognoza/";

// Kada se promeni izbor u padajućem meniju
document.getElementById("grad").addEventListener("change", (e) => {
    // Promeni src iframe-a na osnovu izabranog grada
    document.querySelector("iframe").src = URL + e.currentTarget.value;

    // Otvori novi prozor sa informacijama o izabranom gradu
    window.open("/grad.html?grad=" + encodeURIComponent(e.currentTarget.value), 
        "Grad", 
        "width=500,height=300,left=100,top=100,menubar=no,toolbar=no"
    );
});
