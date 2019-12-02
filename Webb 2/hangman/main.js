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

//console.log(current);
btn.addEventListener("click", function () {
    //here i want to compare input with every char in the list
    //console.log(input.value);
    //console.log("clicked");
    //console.log(current.length);
    run = true;
    for (let ii = 0; ii < guessed.length; ii++) {
        if (input.value == guessed[ii]) {
            run = false;
        }
    }
    if (run) {
        let count = 0;
        //console.log(current.length);
        for (let i = 0; i < current.length; i++) {
            //console.log("ree");

            if (input.value == current[i]) {
                console.log("yeah");
                let str = document.querySelector('.p' + i.toString());
                console.log('.p' + i.toString());

                str.innerHTML = current[i];
                //console.log(current[i]);
                //console.log("AYE");
                count++;
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
//for loop here to iteration and check if input == current array[0]
