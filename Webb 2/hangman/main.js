let words = ['another', 'test', 'abcde', 'malmöbo'];
let input = document.querySelector('#input');
let btn = document.querySelector('#btn');
let newWord = document.querySelector('#newWord');
let cWord = 0;
let status = document.querySelector('.status');
let status2 = document.querySelector('.status2');

let current;


let count, wrong, guessed;
main();

function main() {
    count = 0;
    wrong = 0;
    guessed = "0123456789";
    current = words[cWord] //fix this later so you can change
    //console.log(current.length);
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
    //need to add something that removes
} //end of rerun loop here
btn.addEventListener("click", function () {
    //here i want to compare input with every char in the list
    run = true;
    status2.innerHTML = "";
    for (let ii = 0; ii < guessed.length; ii++) {
        if (input.value == guessed[ii]) {
            run = false;
        }
    }
    if (run) {
        temp = 0;
        for (let i = 0; i < current.length; i++) {

            if (input.value == current[i]) {
                status.innerHTML = "Correct letter!";
                let str = document.querySelector('.p' + i.toString());
                //console.log('.p' + i.toString());

                str.innerHTML = current[i];
                count++;
                temp++;
                //BELOW I WANT TO CHECK IF WON
                //---

                if (count == current.length) {
                    status.innerHTML = "You won";

                    status2.innerHTML = "You had " + wrong + " wrong guesses!";
                    switchWord();
                }
                //---
            } else if (i == current.length - 1 && temp == 0) {
                status.innerHTML = "Wrong letter!";
                //console.log("re");
                wrong++;
            }
            guessed += input.value;

        }
        guessed += input.value;
    } else {
        status.innerHTML = "already guessed that word!";
    }

    input.value = "";
});

//below is for the new word button
newWord.addEventListener("click", function () {
    switchWord();
});

function switchWord() {

    if (cWord < words.length - 1) {
        cWord++;
        //console.log("added here");
    } else {
        cWord = 0;
    }
    remove();
    main();

}

function remove() {
    for (let i = 0; i < current.length; i++) {
        let tempWord = '.p' + i.toString();
        //console.log(tempWord);
        let temp = document.querySelector(tempWord);
        temp.remove();
    }
}

//for loop here to iteration and check if input == current array[0]
