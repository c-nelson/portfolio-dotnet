const durationInput = document.querySelector('#duration');
const startButton = document.querySelector('#start');
const pauseButton = document.querySelector('#pause');
const circle = document.querySelector('circle');

const perimeter = circle.getAttribute('r') * 2 * Math.PI;
circle.setAttribute('stroke-dasharray', perimeter);

let duration;
const tickInterval = 50;
const timer = new Timer(durationInput, startButton, pauseButton, tickInterval, {
	onStart(totalDuration) {
		duration = totalDuration;
	},
	onTick(timeRemaining) {
		circle.setAttribute('stroke-dashoffset', perimeter * timeRemaining / duration - perimeter);
		circle.setAttribute('stroke', colorGrad(1 - timeRemaining / duration));
	}
});

function colorGrad(percent) {
	let hue = (1 - percent) * 120;
	return `hsl(${hue},60%,50%)`;
}
