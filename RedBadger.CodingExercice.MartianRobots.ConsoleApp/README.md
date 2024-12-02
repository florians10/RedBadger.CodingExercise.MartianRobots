1. Initial thoughts
	* Martian Robots seems like a classic example 
	* where a object with a initial state (in our case a robot with initial coordinates and direction)
	* which suffers different changes to its state during the execution of the program - (in our case moving forward or changing direction)

2. Implementation description
	* in initial brainstorming session, my intention is to create a object called Robot which will store its current position and create individual services
	* for moving the robot such as Moving forward, Turning Left and Turning Right; using strategy pattern and inheriting the same interface.
	* On top of this, we will have a controller service which will oversee the movement of a robot in the given grid.
	* To track down the historical position where past robots got lost, a new service has been created to share this information
	* With this in mind we have:
		* Program.cs - entry point of the console, responsible with initiating the dependencies and running a WorldRunnerService
		* WorldRunnerService - responsible with receiving the inputs and executing each run of robot
		* RobotControllerService - robot service to execute the instructions of robots
		* GridControllerService - grid service to keep track of grid configurations and historical events e.g. historical positions of lost robots
		* Move Strategies - using strategy pattern, it defines independent behavior against a robot and can be switched at runtime.

3. Running the console
	* to run the service, RedBadger.CodingExercice.MartianRobots.ConsoleApp project can be run as a ConsoleApp, it does not require any setup, just run it 
	* it will promit a welcoming message and some brief guidance on what to enter, but in line with the expected sample input given
	* short transcript on how the run should look like in relation to the sample input
		-----------------------------------
		Please enter limits for the grid:
		5 3
		Grid created
		Please enter robot details:
		1 1 E
		RFRFRFRF
		1 1 E
		Please enter robot details:
		3 2 N
		FRRFLLFFRRFLL
		3 3 N LOST
		Please enter robot details:
		-----------------------------------


4. Testing 
	* There is only one single unit test present which tests the given input / ouput. It is considered that this tests most/all the requirements and criterias including:
		* robots moving and turning on grid - considering the limits of grid
		* grid recording the historical positions where robots got lost
		* execution checking and ingoring the move of a robot where another robot got lost in the past.

5. Improvements
	* logging, input validation, edge cases, more descriptive comments etc - there's always space for improvements, but also always good if the requirements are met firstly haha
