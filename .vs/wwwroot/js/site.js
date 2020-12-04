

window.addEventListener('DOMContentLoaded', (e) => {
    console.log('DOM fully loaded and parsed');
    init(); //Burgermenu toggler 

    
    
   
});

function init() {
    console.log("initialized envoirentment");
    const toggler = document.querySelector("body > header > nav > div > div.menu-wrap > input");
    const mAtags = document.querySelector("body > header > nav > div > div.menu-wrap > div.mobile-menu > div:nth-child(2) > div > ul > li > a");
    const body = document.querySelector("body");


    toggler.addEventListener("click", () => {
        toggler.classList.toggle("active");
        body.classList.toggle("noscroll");
    });

    mAtags.forEach(e => {
        e.addEventListener("click", () => {
            toggler.classList.toggle("active");
            body.classList.toggle("scroll");
        });
        
    });

   

}
