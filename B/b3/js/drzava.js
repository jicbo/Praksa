// Funkcija za dobijanje parametra iz URL-a
function getParameterByName(name, url) {
    if (!url) url = window.location.href;
    name = name.replace(/[\[\]]/g, '\\$&');
    var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
        results = regex.exec(url);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, ' '));
}

// Definišite objekte sa podacima o svakoj državi
var drzave = {
    "srbija": {
        "naziv": "SRBIJA",
        "glavni_grad": "Beograd",
        "stanovnici": "6,834 miliona",
        "povrsina": "88.499 km²"
    },
    "madjarska": {
        "naziv": "MAĐARSKA",
        "glavni_grad": "Budimpešta",
        "stanovnici": "9,730 miliona",
        "povrsina": "93,030 km²"
    },
    "hrvatska": {
        "naziv": "HRVATSKA",
        "glavni_grad": "Zagreb",
        "stanovnici": "3,899 miliona",
        "povrsina": "56.594 km²"
    },
    "bih": {
        "naziv": "BOSNA I HERCEGOVINA",
        "glavni_grad": "Sarajevo",
        "stanovnici": "3,271 miliona",
        "povrsina": "51.209 km²"
    },
    "crna_gora": {
        "naziv": "CRNA GORA",
        "glavni_grad": "Podgorica",
        "stanovnici": "619.211",
        "povrsina": "13.812 km²"
    },
    "albanija": {
        "naziv": "ALBANIJA",
        "glavni_grad": "Tirana",
        "stanovnici": "2,812 miliona",
        "povrsina": "28.748 km²"
    },
    "makedonija": {
        "naziv": "MAKEDONIJA",
        "glavni_grad": "Skoplje",
        "stanovnici": "2,065 miliona",
        "povrsina": "25.713 km²"
    },
    "bugarska": {
        "naziv": "BUGARSKA",
        "glavni_grad": "Sofija",
        "stanovnici": "6,863 miliona",
        "povrsina": "110.993 km²"
    },
    "rumunija": {
        "naziv": "RUMUNIJA",
        "glavni_grad": "Bukurešt",
        "stanovnici": "19,12 miliona",
        "povrsina": "238.397 km²"
    }
};

// Dodavanje slušalaca događaja za .zastava elemente
Array.from(document.querySelectorAll(".zastava")).forEach(zas => {
    zas.addEventListener("mouseenter", () => document.getElementById(`audio-${zas.id}`)?.play());
    zas.addEventListener("mouseleave", () => {
        const audio = document.getElementById(`audio-${zas.id}`);
        audio.pause();
        audio.currentTime = 0;
    });
    zas.addEventListener("click", () => {
        window.open(`/drzava.html?drzava=${zas.id}`, `Srbija i susedi | ${zas.id}`, `width=500,height=300,left=100,top=100,menubar=no,toolbar=no`);
    });
});

// Funkcija za popunjavanje podataka o državi na stranici drzava.html
function popuniPodatkeODrzavi() {
    var drzava = getParameterByName('drzava');
    if (drzave.hasOwnProperty(drzava)) {
        document.getElementById("naziv-drzave").innerText = drzave[drzava].naziv;
        document.getElementById("glavni-grad").innerText = `Glavni grad: ${drzave[drzava].glavni_grad}`;
        document.getElementById("stanovnici").innerText = `Broj stanovnika: ${drzave[drzava].stanovnici}`;
        document.getElementById("povrsina").innerText = `Površina: ${drzave[drzava].povrsina}`;
    } else {
        console.error("Država nije pronađena: " + drzava);
    }
}

// Pozivanje funkcije za popunjavanje podataka o državi pri učitavanju stranice
popuniPodatkeODrzavi();
