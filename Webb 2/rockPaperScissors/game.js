let Rock = document.querySelector('.Rock');
let Paper = document.querySelector('.Paper');
let Scissors = document.querySelector('.Scissors');
const status = document.querySelector('#status');
const score = document.querySelector('#score');

let userScore = 0,
    cpuScore = 0,
    cpuChoice = '',
    selection = ['Rock', 'Paper', 'Scissors'];

Rock.addEventListener('click', function () {
    game('Rock');

});

Paper.addEventListener('click', function () {
    game('Paper');

});

Scissors.addEventListener('click', function () {
    game('Scissors');

});

let isPlaying = true;

function game(userChoice) {
    if (isPlaying) {
        cpuChoice = selection[Math.floor(Math.random() * selection.length)];
        console.log('The computer chooses ' + cpuChoice);
        console.log('You choose ' + userChoice);

        switch (userChoice) {
            case 'Rock':
                if (cpuChoice == 'Rock') {
                    status.innerHTML = 'Nobody Wins';
                } else if (cpuChoice == 'Paper') {
                    status.innerHTML = 'You lose';
                    cpuScore++;
                } else if (cpuChoice == 'Scissors') {
                    status.innerHTML = 'You win';
                } else {
                    console.log('Error Rock');
                    break;
                }
                case 'Paper':
                    if (cpuChoice == 'Paper') {
                        status.innerHTML = 'Nobody Wins'
                    } else if (cpuChoice == 'Scissors') {
                        status.innerHTML = 'You lose';
                        cpuScore++;
                    } else if (cpuChoice == 'Rock') {
                        status.innerHTML = 'You win';
                        userScore++;
                    } else {
                        console.log('Error Paper');
                    }
                    break;

                case 'Scissors':
                    if (cpuChoice == 'Scissors') {
                        status.innerHTML = 'Nobody Wins';
                    } else if (cpuChoice == 'Rock') {
                        status.innerHTML = 'You lose';
                        cpuScore++;
                    } else if (cpuChoice == 'Paper') {
                        status.innerHTML = 'You win';
                        userScore++;
                    } else {
                        console.log('Error Scissors');
                    }
                    break;
                default:
                    console.log('Error Invalid');
                    break;
        }
        score.innerHTML = ('You have ' + userScore + ' while the computer has ' + cpuScore)
        if (userScore == 5) {
            status.innerHTML = 'You win the game!'
            isPlaying = false;
            restart();
        } else if (cpuScore == 5) {
            status.innerHTML = 'You lose the game!'
            isPlaying = false;
            restart();
        }

        function restart() {
            var btn = document.createElement("BUTTON");
            btn.innerHTML = "Restart";
            document.body.appendChild(btn);
            btn.addEventListener('click', function () {
                userScore = 0;
                cpuScore = 0;
                window.location.reload(true);

            });
        }
    }

}
