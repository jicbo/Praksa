Array.from(document.querySelectorAll(".image img")).forEach(img => {
    img.addEventListener("click", () => {
        window.open(img.id + ".html", `Domaće životinje | ${img.id}`, `width=500,height=300,left=100,top=100,menubar=no,toolbar=no`);
    });
    img.addEventListener("mouseover", () => {
        document.getElementById("audio-" + img.id).play();
        new Audio(`./audio/${img.id}.mp3`).play();
    });
});
