# **Tic-Tac-Toe-Game**
This is a repo for my tic-tac-toe game. This is a project assigned from "The C# Player's Guide" book.

## **Things learned from this project**
1. The use of classes and instances
2. Scope of classes, methods, and variables
3. Splitting up of different tasks into smaller and more manageable components
4. Implementation of enums, foreach loops, 'out' parameters, multidimensional arrays
5. The importance of readability and concise code

## **Final Comments**
This project really gave me insight on the importance of splitting up tasks into smaller, more manageable components (Divide and Conquer). This reduced the clutter of the overall project and allowed for easier editing of specific parts of the game.

Some things I can definitely improve upon is deciding how to efficiently split up tasks into classes and methods, and organizing methods so that they are directly related to their class name. Additionally, I should keep in mind not to split up tasks too much as this could lead to an excessive amount of methods.

## Project Code Description
---
#### ```Board``` Class
- Ultimately works behind the scenes with the Player class to input states into the 3x3 game board.
###### ```Constructor```
* Initializes a new 3x3 game board with undecided states in each square
* Initializes the first move to be 'X'
###### ```InputMoveToBoard```
* InputMoveToBoard method takes the current turn's player and the game board, and asks the user for a square selection through the Player class. 
* The selection, if valid, is sent to BoardPosition, and returns a position Tuple for the row and column of the corresponding matrix.
###### ```BoardPosition```
* BoardPosition method takes a user input square value and returns the corresponding matrix coordinate
###### ```CheckIfUndecided```
* CheckIfUndecided method takes the position Tuple and checks the board coordinate to see if a state has already been selected.

---
#### ```GameStatus``` Class
- Ultimately checks the game's status to see if anyone has won, if the game is a draw.
###### ```Winner```
* Winner method takes the current board and checks if either player has won or not using WinCheck.
###### ```WinCheck```
* WinCheck method checks the game board, for each state, to see if there are three states in a row.
###### ```DrawCheck```
* DrawCheck method checks to see if there is any empty squares on the game board. If there is no winner and DrawCheck returns true, the game will have ended in a draw.

---
#### ```Initializer``` Class
- As the name suggests, initializes the game at the start, but also displays text when the game is over.
###### ```Intro```
* Introduces the game at the beginning and also takes user input of player names and returns them as strings.
###### ```Ending```
* Based on the winner, or if the game is a draw, outputs corresponding text confirming the end state of the game.

---
#### ```Player``` Class
- Instances of the class will be made for each player, and will be used throughout the game.
###### ```Constructor```
* Takes the names from the Initializer class and stores it into each player instance.
###### ```PlayerMove```
* Asks user input for a game board position, and if the entry is valid, will return a position Tuple, containing rows and columns, using BoardPosition.

---
#### ```Program``` Class (Main)
- Simply runs the game using static classes and instances of various classes. This is where the game all comes together.

---
#### ```Renderer``` Class
- As the name suggests, renders a visual representation of the current state of the game board, on the console.
###### ```Constructor```
* Initializes empty multidimensional arrays for the game board. 
* Also initializes the instruction board, which shows players which numbers on the numpad correlates to which game square.
###### ```Instructions```
* Displays the instruction board and explains to players how to input valid square selections.
###### ```DrawBoard```
* Draws the current state of the game board when called.
###### ```PrintAll```
* Depending on the board input, loops through each board index and prints the current board state to the console.
###### ```ConvertBoard```
* Takes the board instance from the Board class, and translates the 3x3 state array to the visual representation of the game board. This is because the visual board has a different array size than the 3x3 state array.
###### ```AddToRenderBoard```
* Based on the state input and array index from ConvertBoard, the method will input an 'X' or 'O' into the corresponding index of the visual board.
###### ```TranslatedCoord```
* This is the method which translates the 3x3 state array index to the visual board index.

---
#### ```StartPlayer``` Class
- Determines which player will start first, using a random number generator from the Random class.
###### ```GameStarter```
* Takes both player instances, uses the Order method shown below, and 'randomly' outputs who plays as 'X' or 'O'.
###### ```Order```
* Uses Random class instances to generate numbers from 0 to 100, and whichever is greater is the player who starts first.

---
#### ```State``` Enumerator
- Enum for the three states: 'Undecided', 'X', and 'O'.
