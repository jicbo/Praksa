document.addEventListener('DOMContentLoaded', () => {
    const slike = document.querySelectorAll('.Slikica'); // Dohvatamo sve slike sa klasom 'Slika'

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


    function getAudioPath(imageId) {
        switch (imageId) {
            case 'gitara':
                return 'Audios/gitara.mp3';
            case 'violina':
                return 'Audios/violina.mp3';
            case 'klavir':
                return 'Audios/klavir.mp3';
            case 'bubnjevi':
                return 'Audios/bubnjevi.mp3';
            case 'kontrabas':
                return 'Audios/kontrabas.mp3';
            case 'saksofon':
                return 'Audios/saksofon.mp3';
            default:
                return '';
        }
    }
});





document.addEventListener("DOMContentLoaded", function() {
    // Pronađite sve paragrafe unutar elemenata sa klasom "td3"
    var saznajViseParagraphs = document.querySelectorAll('.td3 p');

    // Iterirajte kroz svaki pronađeni paragraf i dodajte event listener
    saznajViseParagraphs.forEach(function(paragraph) {
        paragraph.addEventListener('click', function() {
            // Dobijte id atribut roditeljskog <td> elementa paragrafa
            var parentTd = paragraph.parentNode;
            var instrumentId = parentTd.querySelector('img').id;

            // Odredi koju datoteku treba otvoriti na osnovu id-a instrumenta
            var filename;
            switch (instrumentId) {
                case 'gitara':
                    filename = 'zicani.txt';
                    break;
                case 'violina':
                    filename = 'zicani.txt'; // Primer: Violina koristi isti fajl kao i gitara
                    break;
                case 'klavir':
                    filename = 'dirke.txt';
                    break;
                case 'bubnjevi':
                    filename = 'udaraljke.txt';
                    break;
                case 'kontrabas':
                    filename = 'zicani.txt'; // Primer: Kontrabas koristi isti fajl kao i gitara
                    break;
                case 'saksofon':
                    filename = 'duvacki.txt';
                    break;
                default:
                    filename = ''; // Nije potrebno otvarati datoteku ako id nije prepoznat
                    break;
            }

            // Proverite da li je filename postavljen na neku vrednost
            if (filename) {
                // Otvorite tekstualnu datoteku u novom prozoru/tabu
                window.open(filename, '_blank');
            } else {
                console.error('Nije pronađena odgovarajuća datoteka za instrument: ' + instrumentId);
            }
        });
    });
});




document.addEventListener("DOMContentLoaded", function() {
    // Pronađite sve slike unutar elemenata sa klasom "Slika" u tabeli
    var slike = document.querySelectorAll('.TabelaDiv .Slika');

    // Iterirajte kroz svaku pronađenu sliku i dodajte event listener
    slike.forEach(function(slika) {
        slika.addEventListener('click', function() {
            // Dobijte vrednost data-link atributa slike
            var link = slika.getAttribute('data-link');

            // Proverite da li je link validan
            if (link) {
                // Otvorite link u novom tabu
                window.open(link, '_blank');
            } else {
                console.error('Nedostaje data-link atribut za sliku: ' + slika.src);
            }
        });
    });
});
