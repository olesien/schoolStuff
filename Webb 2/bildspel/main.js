const left = document.querySelector(".fa-arrow-left");
const right = document.querySelector(".fa-arrow-right");
const image = document.querySelector(".image");
let current = 0;
let images = 3;

function imgFunc() {
    if (current >= images) {
        current = 0;
    } else if (current < 0) {
        current = images - 1;
    }
    image.src = "images/" + current + ".jpg";
}

imgFunc();

left.addEventListener('click', function () {
    current--;

    imgFunc();

});

right.addEventListener('click', function () {
    current++
    imgFunc();
});
