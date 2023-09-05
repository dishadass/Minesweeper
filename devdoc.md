# Minesweeper


# MineSweeper Developer Documentation

This developer documentation provides an in-depth overview of the MineSweeper codebase, explaining the purpose of each class, its methods, properties, and the algorithms used in the game.

## Table of Contents
1. **Introduction**
2. **Project Structure**
3. **Class Documentation**
   - **MainForm**
   - **Form2**
   - **Field**
4. **Algorithms**
   - **Mine Placement**
   - **Counting Adjacent Mines**
   - **Discovering Safe Squares**
5. **Customization Options**
6. **Conclusion**

### 1. Introduction

MineSweeper is a classic puzzle game implemented in C# using Windows Forms. The game consists of uncovering safe squares on a grid while avoiding hidden mines. This documentation will delve into the code structure, class details, and the algorithms used in the game.

### 2. Project Structure

The project is structured as follows:

- **Form1.cs**: The main menu and game setup form.
- **Form2.cs**: The game form where the MineSweeper grid is displayed.
- **Field.cs**: Handles the game logic and grid operations.
- **Program.cs**: The entry point of the application.
- **Properties**: Contains application-specific settings.

### 3. Class Documentation

#### 3.1. MainForm(Form1)

**Purpose**: This class represents the main menu form where the player can select the game difficulty and start a new game.

**Methods and Properties**:
- `Play(object sender, EventArgs e)`: Starts a new game based on the selected difficulty.
- `button2_Click(object sender, EventArgs e)`: Closes all open game forms.
- `easyToolStripMenuItem_Click(object sender, EventArgs e)`, `mediumToolStripMenuItem_Click(object sender, EventArgs e)`, `expertToolStripMenuItem_Click(object sender, EventArgs e)`: Start a new game with predefined difficulty levels.
- `exitToolStripMenuItem_Click(object sender, EventArgs e)`: Exits the application.

#### 3.2. Form2

**Purpose**: This class represents the MineSweeper game form where the grid is displayed, and the gameplay occurs.

**Methods and Properties**:
- `Button_Click(object sender, MouseEventArgs e)`: Handles user interactions with the game grid.
- `Form2(String text,int row, int col,int size,int mines)`: Initializes the game form with specified settings.
- `Load(object sender, EventArgs e)`: Handles form load events.

This code file defines a Windows Forms application for a Minesweeper game. The Form2 class represents the game interface, and it consists of buttons organized in a grid to simulate the game board. 

    The Form2 class is defined as a partial class that inherits from the Form class provided by Windows Forms.

    Constructors:
        There are two constructors for Form2. The default constructor (public Form2()) is used for initializing the form. The parameterized constructor (public Form2(String text, int row, int col, int size, int mines)) is used to create an instance of the game board with specified parameters.

    In the parameterized constructor:
        The window title is set based on the text parameter.
        An instance of the Field class (representing the game logic and board) is created with the provided row, col,

#### 3.3. Field

**Purpose**: This class handles the game logic, grid operations, and mine placement.



Field Class Documentation

The Field class is an integral part of the Minesweeper game application. It manages the game board and the core game logic. Below is an overview of the Field class:

Private Fields:

    Mine_Map: A 2D boolean array representing the mine map. Each element of this array is either true (indicating the presence of a mine) or false (indicating an empty cell).
    Discovered: A HashSet of integers that keeps track of positions corresponding to cells that have been discovered or revealed during the game.
    Flagged: A HashSet of integers that stores the positions of cells flagged by the player.
    Started: A boolean flag that indicates whether the game has started.
    Row: An integer representing the number of rows in the game board.
    Col: An integer representing the number of columns in the game board.
    Mines: An integer representing the total number of mines on the game board.

Constructor:

    Field(int row, int col, int mines): The constructor initializes an instance of the Field class with specified dimensions (number of rows and columns) and the total number of mines on the game board. It sets up the initial state of the game, including an empty mine map.

Methods:

    IsMine(int i, int j): This method checks if a specific cell contains a mine. It returns true if there is a mine in the cell and false otherwise.
    Initialize(int first_click_x, int first_click_y): This method initializes the game board by placing mines and ensuring that the first click is always safe. It uses randomization to distribute mines while avoiding the first-click cell and ensuring mine placement safety.
    CountMines(int click_x, int click_y): This method counts the number of mines in the vicinity of a given cell. It considers the 3x3 grid centered around the cell and counts the neighboring mines.
    GetNeighbors(int x, int y): Returns a HashSet of integers representing the positions of neighboring cells to a given cell. This method calculates the immediate vicinity of a cell and returns the positions of neighboring cells.
    GetSafeIsland(int click_x, int click_y): This method reveals safe cells around an empty cell using Breadth-First Search (BFS). It explores the connected empty cells in a safe manner, revealing them to the player.
    Win(): Checks if the game has been won by comparing the count of discovered cells and mines with the total number of cells on the game board. If all safe cells have been discovered, the game is won..

### 4. Algorithms

#### 4.1. Mine Placement

Mines are randomly placed on the grid during initialization, ensuring the first clicked square is safe. The `Random` class is used to generate mine locations.

#### 4.2. Counting Adjacent Mines

When a square is clicked, the algorithm counts the number of mines in adjacent squares. It iterates through neighboring squares and increments the count if a mine is found.

#### 4.3. Discovering Safe Squares

When clicking on an empty square, a recursive algorithm discovers all adjacent safe squares by exploring neighboring squares until it reaches squares with numbers. It prevents uncovering mines.

### 5. Customization Options

The game allows customization through various difficulty levels (Easy, Medium, Expert) and a custom mode where the player defines grid size and mine count.


