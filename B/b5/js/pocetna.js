// Definišemo linkove ka Wikipedia stranama za različite instrumente
const wikiLinks = {
	gitara: "https://sr.wikipedia.org/wiki/%D0%93%D0%B8%D1%82%D0%B0%D1%80%D0%B0",
	violina: "https://sr.wikipedia.org/wiki/%D0%92%D0%B8%D0%BE%D0%BB%D0%B8%D0%BD%D0%B0",
	klavir: "https://sr.wikipedia.org/wiki/%D0%9A%D0%BB%D0%B0%D0%B2%D0%B8%D1%80",
	bubnjevi: "https://sr.wikipedia.org/wiki/%D0%91%D1%83%D0%B1%D1%9A%D0%B5%D0%B2%D0%B8",
	harmonika: "https://sr.wikipedia.org/wiki/%D0%A5%D0%B0%D1%80%D0%BC%D0%BE%D0%BD%D0%B8%D0%BA%D0%B0",
	kontrafagot: "https://sr.wikipedia.org/wiki/%D0%9A%D0%BE%D0%BD%D1%82%D1%80%D0%B0%D1%84%D0%B0%D0%B3%D0%BE%D1%82"
}

// Dodajemo event listener za svaki instrument da otvori odgovarajući Wikipedia link u novom prozoru
Array.from(document.querySelectorAll(".instrument img")).forEach(inst => {
	inst.addEventListener("click", () => window.open(wikiLinks[inst.id], "_blank"));
})

// Dodajemo event listener za svaki "Saznaj više" link da otvori novu stranicu sa instrumentima
Array.from(document.querySelectorAll(".saznaj-vise")).forEach(link => {
	link.addEventListener("click", e => {
		e.preventDefault(); // Sprečavamo podrazumevano ponašanje linka
		window.open(link.href, "Instrumenti", `width=500,height=300,left=100,top=100,menubar=no,toolbar=no`); // Otvaramo novi prozor sa specifikacijama
	});
})

// Dodajemo event listener za svaku sliku zvučnika da pušta i zaustavlja zvuk prilikom prelaska miša preko slike
Array.from(document.querySelectorAll(`[alt="zvucnik"]`)).forEach(zv => {
	zv.addEventListener("mouseenter", () => {
		document.getElementById(`audio-${zv.id.split("-")[0]}`)?.play(); // Pustamo zvuk instrumenta
	});
	zv.addEventListener("mouseleave", () => {
		const audio = document.getElementById(`audio-${zv.id.split("-")[0]}`);
		audio.pause(); // Zaustavljamo zvuk
		audio.currentTime = 0; // Vraćamo zvuk na početak
	});
})

// Funkcija koja se izvršava kada se stranica učita
document.addEventListener('DOMContentLoaded', function() {
	const urlParams = new URLSearchParams(window.location.search); // Parsiramo URL parametre
	const instrumentClass = urlParams.get('klasa'); // Uzimamo vrednost parametra 'klasa'
	if (instrumentClass) {
		document.getElementById(instrumentClass).classList.add('active'); // Dodajemo klasu 'active' odgovarajućem instrumentu
	} else {
		// Prikazujemo podrazumevani odsek ako nije naveden nijedan parametar
		document.getElementById('zicani').classList.add('active'); // Dodajemo klasu 'active' za 'zicani' instrumente
	}
});
