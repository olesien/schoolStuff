const Rock = document.querySelector('.Rock');
const Paper = document.querySelector('.Paper');
const Scissors = document.querySelector('.Scissors');
const status = document.querySelector('#status');
const score = document.querySelector('#score');
const user = document.querySelector('#user');
const cpu = document.querySelector('#cpu');

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
        user.innerHTML = ('You pick ' + userChoice);
        cpu.innerHTML = ('The computer picks ' + cpuChoice);
//        console.log('The computer chooses ' + cpuChoice);
//        console.log('You choose ' + userChoice);

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
            restart('win');
        } else if (cpuScore == 5) {
            restart('lose');
        }

        function restart(winlose) {
            status.innerHTML = ('You ' + winlose + ' the game!')
            isPlaying = false;
            var btn = document.createElement("BUTTON");
            btn.innerHTML = "Restart";
            document.body.appendChild(btn);
            btn.addEventListener('click', function () {
                window.location.reload(true);

            });
        }
    }

}
