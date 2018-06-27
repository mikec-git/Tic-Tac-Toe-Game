# Tic-Tac-Toe-Game
This is a repo for my tic-tac-toe game. This is a project assigned from "The C# Player's Guide" book.

## Things learned from this project
* The use of classes and instances
* Scope of classes, methods, and variables
* Splitting up of different tasks into smaller and more manageable components
* Implementation of enums, foreach loops, 'out' parameters, multidimensional arrays
* The importance of readability and consise code

## Final Comments
This project really gave me insight on the importance of splitting up tasks into smaller, more manageable components (Divide and Conquer). This reduced the clutter of the overall project and allowed editing specific parts much easier. 

Some things I can definitely improve upon is deciding which components to split up for certain tasks, and organizing methods so that they are related to their class name. 

## Project Description
##### Board Class
- Ultimately works behind the scenes with the Player class to input states into the 3x3 game board.
###### Constructor
* Initializes a new 3x3 game board with undecided states in each square
* Initializes the first move to be 'X'
###### InputMoveToBoard
* InputMoveToBoard method takes the current turn's player and the game board, and asks the user for a square selection through the Player class. 
* The selection, if valid, is sent to BoardPosition, and returns a position Tuple for the row and column of the corresponding matrix.
###### BoardPosition
* BoardPosition method takes a user input square value and returns the corresponding matrix coordinate
###### CheckIfUndecided
* CheckIfUndecided method takes the position Tuple and checks the board coordinate to see if a state has already been selected.

##### GameStatus Class
- Ultimately checks the game's status to see if anyone has won, if the game is a draw.
###### Winner
* Winner method takes the current board and checks if either player has won or not using WinCheck.
###### WinCheck
* WinCheck method checks the game board, for each state, to see if there are three states in a row.
###### DrawCheck
* DrawCheck method checks to see if there is any empty squares on the game board. If there is no winner and DrawCheck returns true, the game will have ended in a draw.


