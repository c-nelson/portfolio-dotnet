class Timer {
	constructor(durationInput, startButton, pauseButton, tickInterval, callbacks) {
		this.durationInput = durationInput;
		this.startButton = startButton;
		this.pauseButton = pauseButton;
		this.tickInterval = tickInterval;
		this.timeSubtract = this.tickInterval / 1000;
		if (callbacks) {
			this.onStart = callbacks.onStart;
			this.onTick = callbacks.onTick;
			this.onComplete = callbacks.onComplete;
		}
		this.startButton.addEventListener('click', this.start);
		this.pauseButton.addEventListener('click', this.pause);
	}

	start = () => {
		if (this.onStart) this.onStart(this.timeRemaining);
		this.tick();
		this.intervalId = setInterval(this.tick, this.tickInterval);
	};

	pause = () => {
		clearInterval(this.intervalId);
	};

	tick = () => {
		if (this.timeRemaining <= 0) {
			this.pause();
			if (this.onComplete) this.onComplete();
		} else {
			this.timeRemaining = this.timeRemaining - this.timeSubtract;
			if (this.onTick) this.onTick(this.timeRemaining);
		}
	};

	get timeRemaining() {
		return parseFloat(this.durationInput.value);
	}

	set timeRemaining(time) {
		this.durationInput.value = time.toFixed(2);
	}
}
