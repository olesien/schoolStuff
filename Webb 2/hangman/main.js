let words = ['another', 'test'];
let input = document.querySelector('#input');
let btn = document.querySelector('#btn');
let newWord = document.querySelector('#newWord');
let guessed = "0123456789";

current = words[0] //fix this later so you can change
for (let i = 0; i < current.length; i++) {
    //console.log("yes")
    var para = document.createElement("p");
    var iString = 'p' + i.toString();
    para.className = iString;

    para.classList.add(iString);
    para.setAttribute("class", iString);

    var node = document.createTextNode("");
    para.appendChild(node);

    var element = document.getElementById("div1");
    var child = document.getElementById("p1");
    element.insertBefore(para, child); //add class but too lazy
}

btn.addEventListener("click", function () {
    //here i want to compare input with every char in the list
    run = true;
    for (let ii = 0; ii < guessed.length; ii++) {
        if (input.value == guessed[ii]) {
            run = false;
        }
    }
    if (run) {
        let count = 0;
        for (let i = 0; i < current.length; i++) {

            if (input.value == current[i]) {
                console.log("yeah");
                let str = document.querySelector('.p' + i.toString());
                console.log('.p' + i.toString());

                str.innerHTML = current[i];
                count++;
                //BELOW I WANT TO CHECK IF WON
                //---

                //---
            }
            if (i == current.length - 1 && count == 0) {
                console.log("no");
            }
            guessed += input.value;

        }
        guessed += input.value;
    } else {
        console.log("already guessed that word!");
    }

});

//below is for the new word button
newWord.addEventListener("click", function () {

});
//for loop here to iteration and check if input == current array[0]
