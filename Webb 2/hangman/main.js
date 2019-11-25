let words = ['another', 'test'];
let input = document.querySelector('#input');
let btn = document.querySelector('#btn');
let newWord = document.querySelector('#newWord');

current = words[0] //fix this later so you can change
for (let i = 0; i < current.length; i++) {
    console.log("yes")
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

btn.addEventListener("click", myFunction() {
    //here i want to compare input with every char in the list
    let count = 0;
    for (let i = 0; i < current.length; i++) {
        if (input == current[i]) {
            let str = document.querySelector('p' + i.toString());
            str.innerHTML = current[i];
            console.log("AYE");
            count++;
        }
        if (count = 0) {
            console.log("no");
        }
    }
});
//for loop here to iteration and check if input == current array[0]
