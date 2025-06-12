document.addEventListener('DOMContentLoaded', () => {
    const slike = document.querySelectorAll('.Slika'); // Dohvatamo sve slike sa klasom 'Slika'

    slike.forEach(slika => {
        let audio = null;

        // Dodajemo event listener za ulazak miša na sliku
        slika.addEventListener('mouseover', () => {
            const slikaId = slika.id;
            const audioPath = getAudioPath(slikaId);

            // Reprodukujemo zvuk samo ako nije već reprodukovan
            if (!audio) {
                audio = new Audio(audioPath);
                audio.play();
            }
        });

        // Dodajemo event listener za izlazak miša sa slike
        slika.addEventListener('mouseout', () => {
            // Zaustavljamo reprodukciju zvuka ako postoji
            if (audio) {
                audio.pause();
                audio.currentTime = 0; // Vraćamo reprodukciju na početak
                audio = null; // Resetujemo referencu na Audio objekat
            }
        });
    });

    // Funkcija koja vraća putanju do zvuka na osnovu ID-a slike
    function getAudioPath(imageId) {
        switch (imageId) {
            case 'kuce':
                return 'Audios/kuce.mp3';
            case 'pace':
                return 'Audios/pace.mp3';
            case 'mace':
                return 'Audios/mace.mp3';
            case 'pile':
                return 'Audios/pile.mp3';
            case 'tele':
                return 'Audios/tele.mp3';
            default:
                return '';
        }
    }
});




document.addEventListener('DOMContentLoaded', () => {
    const slike = document.querySelectorAll('.Slika'); // Dohvatamo sve slike sa klasom 'Slika'

    slike.forEach(slika => {
        const slikaId = slika.id;
        const tekstFajl = `${slikaId}.txt`; // Formiramo naziv TXT fajla na osnovu ID-a slike

        // Dodajemo event listener za klik na sliku
        slika.addEventListener('click', () => {
            // Koristimo AJAX da učitamo sadržaj TXT fajla
            const xhr = new XMLHttpRequest();
            xhr.onreadystatechange = function() {
                if (xhr.readyState === XMLHttpRequest.DONE) {
                    if (xhr.status === 200) {
                        const tekst = xhr.responseText;
                        // Kreiramo novi prozor za prikaz teksta
                        const noviProzor = window.open('', '_blank');
                        noviProzor.document.write(`<pre>${tekst}</pre>`);
                        noviProzor.document.close();
                    } else {
                        console.error('Greška prilikom učitavanja TXT fajla.');
                    }
                }
            };
            xhr.open('GET', tekstFajl, true);
            xhr.send();
        });
    });
});