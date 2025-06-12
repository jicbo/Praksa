document.addEventListener('DOMContentLoaded', function() {
    // Selektujemo sve slike u divu .DoleSlike
    const slike = document.querySelectorAll('.DoleSlike .Slicica');

    // Iteriramo kroz svaku sliku i dodajemo event listener za klik
    slike.forEach(function(slika) {
        slika.addEventListener('click', function() {
            // Dobijamo putanju do slike koju je korisnik kliknuo
            const novaSlikaSrc = slika.src;

            // Postavljamo novu sliku u div .Slika
            const glavnaSlika = document.querySelector('.Slika img');
            glavnaSlika.src = novaSlikaSrc;

            // Dobijamo naziv planete iz alt atributa slike (primer: "mars.jpg" će dati "mars")
            const nazivPlanete = slika.alt.split('.')[0];

            // Formiramo putanju do odgovarajućeg teksta za tu planetu
            const novaPutanjaZaTekst = `Text/${nazivPlanete}.txt`;

            // Postavljamo novu putanju za <iframe>
            const tekstIframe = document.querySelector('.Tekst');
            tekstIframe.src = novaPutanjaZaTekst;
        });
    });
});
