👑 Royal Run — 3D Endless Runner Game
📌 Project Overview

Royal Run is a 3D endless runner game developed using Unity and C#. The player controls a character running continuously through an endlessly generated environment while avoiding obstacles and collecting coins.

The main objective of the game is to survive for as long as possible, achieve the highest score, and collect maximum coins. As the player progresses, the game gradually becomes more challenging by increasing the movement speed and continuously generating new sections of the level.

The project demonstrates important concepts of modern game development such as 3D environment design, physics-based player movement, procedural level generation, object spawning, collision detection, game-state management, user interface, audio integration, and dynamic difficulty.

🎯 Project Objectives

The major objectives of Royal Run are:

To develop an interactive 3D game using Unity.
To implement player movement using C# scripting.
To create an infinite procedurally generated environment.
To implement obstacle generation and collision detection.
To develop a scoring and coin collection system.
To implement a player health/life system.
To gradually increase game difficulty.
To provide visual and audio feedback to the player.
To develop an organized and reusable game architecture.
To demonstrate practical application of object-oriented programming using C#.
🎮 Game Concept

Royal Run follows the endless runner game concept.

The player starts running through a continuously generated path. Since the level is not completely predefined, new sections of the environment are generated while the player moves forward.

During the run, the player must:

Move left and right.
Avoid obstacles.
Collect coins.
Continue running for as long as possible.
Maintain the available lives.
Achieve a high score.

The game continues until the player's available lives are exhausted.

⭐ Main Features
1. Infinite Procedural Generation

One of the major features of Royal Run is its procedural level generation system.

Instead of creating the entire game track manually, the game generates sections or chunks dynamically.

Player Starts
     ↓
Generate Initial Chunks
     ↓
Player Moves Forward
     ↓
Generate New Chunk
     ↓
Remove/Recycle Old Chunk
     ↓
Generate Next Chunk
     ↓
Continue Infinitely

This allows the game to provide an effectively endless running environment.

Advantages
Reduces the need to manually design a huge level.
Saves memory by reusing objects.
Creates variation between runs.
Makes the game suitable for an endless-runner concept.
🏃 2. Player Movement

The player is controlled through a physics-based character controller.

The movement system uses Unity's Rigidbody/physics system together with C# scripts.

The player can move horizontally using:

Key	Action
A	Move Left
D	Move Right
←	Move Left
→	Move Right

The forward movement is continuously maintained by the game.

🪙 3. Coin Collection System

Coins are placed throughout the generated environment.

When the player comes into contact with a coin:

Player
   ↓
Collision Detection
   ↓
Coin Detected
   ↓
Coin Collected
   ↓
Coin Counter Increased
   ↓
Collection Sound
   ↓
Coin Removed

The collected coins are displayed through the game's UI.

The system provides the player with an additional objective besides simply surviving.

❤️ 4. Health / Life System

The player starts with 3 lives.

When the player collides with an obstacle:

Player Hits Obstacle
        ↓
    Lose 1 Life
        ↓
    Update HUD
        ↓
Lives Remaining?
   ↙          ↘
 YES           NO
 ↓              ↓
Continue      Game Over

This gives the player multiple opportunities instead of immediately ending the game after one collision.

🚧 5. Obstacle System

Obstacles are generated throughout the running environment.

The ObstacleSpawner system is responsible for placing obstacles within generated chunks.

The basic interaction is:

Obstacle Spawned
       ↓
Player Approaches
       ↓
Collision Detection
       ↓
Life Decreased
       ↓
Game Continues / Game Over

The obstacle system is an important component of the game's challenge mechanism.

📈 6. Dynamic Difficulty

Royal Run gradually becomes more difficult as the player survives longer.

The game increases the running speed over time.

For example:

Start
 ↓
Normal Speed
 ↓
Player Survives
 ↓
Speed Increases
 ↓
Higher Reaction Requirement
 ↓
More Difficult Gameplay

This prevents the game from remaining at the same difficulty level throughout the entire session.

🏆 7. Score System

The player's score is based primarily on their survival/progress through the level.

The longer the player survives and the farther they travel, the higher the score becomes.

The game therefore encourages the player to continuously improve their previous performance.

🔊 8. Audio System

Royal Run includes audio feedback to make the gameplay more interactive.

Examples include:

Background music
Coin collection sound
Gameplay sound effects

Audio provides immediate feedback when important events occur.

For example:

Collect Coin
     ↓
Coin Sound
     ↓
Player receives feedback
🖥️ 9. User Interface

The game provides an in-game HUD to display important information.

Typical information includes:

--------------------------------
          ROYAL RUN
--------------------------------

Score: 1250

Coins: 35

Lives: ❤️ ❤️ ❤️

--------------------------------

The UI allows the player to understand their current game status without leaving the gameplay screen.

🛠️ Technology Stack
Technology	Purpose
Unity	Game engine
Unity 2022.3+ / Unity 6	Development environment
C#	Game programming
Universal Render Pipeline (URP)	Rendering
Unity New Input System	Player controls
Rigidbody / Physics	Player movement and collision
Unity UI	HUD and game interface
🏗️ System Architecture

The project follows a modular architecture where different scripts are responsible for different game functions.

                         ROYAL RUN
                            │
             ┌──────────────┼──────────────┐
             │              │              │
             ▼              ▼              ▼
       GameManager    LevelGenerator    UIManager
             │              │              │
             │              │              │
             ▼              ▼              ▼
       Game State       Level Chunks      HUD
       Score             Obstacles        Score
       Lives             Coins            Coins
       Game Over         Generation       Lives
             │
             ▼
       Player Movement
             │
             ▼
       Collision System
             │
      ┌──────┴──────┐
      ▼             ▼
   Obstacles       Coins
      │             │
      ▼             ▼
 Lose Life       Increase Coins
📂 Project Structure

The major scripts are organized inside:

Assets/
└── Scripts/
    ├── GameManager.cs
    ├── LevelGenerator.cs
    ├── ObstacleSpawner.cs
    ├── movement.cs
    └── UIManager.cs
GameManager.cs

The GameManager acts as the central controller of the game.

It manages important game states such as:

Starting the game
Score
Lives
Game progression
Game-over state
Overall gameplay logic

It can be considered the main coordination component of the project.

LevelGenerator.cs

The LevelGenerator manages the generation of the endless environment.

Its responsibilities include:

Generating ground sections.
Creating new chunks.
Maintaining the running path.
Reusing/generated sections.
Supporting the infinite-level concept.

This component is one of the most important parts of the project.

ObstacleSpawner.cs

The ObstacleSpawner is responsible for placing obstacles within the generated sections.

It helps make each generated section more challenging by adding obstacles to the player's path.

movement.cs

The movement script controls the player's movement.

It handles:

Left movement.
Right movement.
Player physics.
Movement input.
Interaction with the game environment.
UIManager.cs

The UIManager controls the information displayed on the screen.

It is responsible for updating elements such as:

Score
Coins
Lives
Game status

This separates the user interface logic from the core gameplay logic.

🔄 Overall Game Flow

The complete game flow can be represented as:

             START GAME
                  ↓
          Initialize Systems
                  ↓
         Initialize Player
                  ↓
          Generate Chunks
                  ↓
          Start Running
                  ↓
       ┌──────────┴──────────┐
       ↓                     ↓
   Collect Coin         Hit Obstacle
       ↓                     ↓
 Increase Coins          Lose Life
       │                     │
       └──────────┬──────────┘
                  ↓
          Continue Running
                  ↓
        Increase Difficulty
                  ↓
        Generate New Chunk
                  ↓
        Check Remaining Lives
             ↙         ↘
           YES          NO
            ↓            ↓
       Continue       GAME OVER
🔁 Procedural Generation Flow

The procedural generation system is particularly important for explaining the technical aspect of the project.

       Player Position
             ↓
     Check Generation Area
             ↓
     Is New Chunk Required?
          ↙       ↘
        YES        NO
         ↓          ↓
 Generate Chunk   Continue
         ↓
 Spawn Ground
         ↓
 Spawn Obstacles
         ↓
 Spawn Coins
         ↓
 Add Chunk
         ↓
 Continue Gameplay
🧩 Important Game Concepts Demonstrated

This project demonstrates several computer science and software development concepts.

Object-Oriented Programming

C# classes are used to separate responsibilities between different components.

Examples:

GameManager
LevelGenerator
ObstacleSpawner
UIManager
Player Movement

Each component performs a specific role.

Event-Based Interaction

Gameplay events such as collisions and coin collection trigger specific actions.

Physics

Unity's physics system is used for player movement and collision detection.

Procedural Generation

The environment is generated dynamically instead of being completely predefined.

Object Reuse

Chunks and game objects can be reused to reduce unnecessary creation and destruction.

State Management

The game needs to maintain different states such as:

Playing
   ↓
Paused / Active
   ↓
Game Over
💻 Controls
Control	Function
A	Move Left
D	Move Right
Left Arrow	Move Left
Right Arrow	Move Right
Esc	Exit, if implemented
🎮 How to Run the Project
Step 1 — Open Unity Hub

Open Unity Hub and select the Royal Run project.

Step 2 — Open the Project

Use the Unity version compatible with the project.

Step 3 — Open the Game Scene

Navigate to:

Assets
   ↓
Scenes
   ↓
Main Game Scene

Open the appropriate .unity scene.

Step 4 — Run

Press:

▶ Play

The game should start inside the Unity Editor.

🧪 Testing

The project can be tested using the following cases:

Test Case	Expected Result
Start game	Player begins running
Press A	Player moves left
Press D	Player moves right
Collect coin	Coin count increases
Hit obstacle	One life is lost
Continue running	New environment sections appear
Survive longer	Score increases
Lose all lives	Game Over occurs
Audio event	Appropriate sound is played
🎓 Academic Significance

Royal Run demonstrates how theoretical programming concepts can be applied to an interactive software system.

The project combines:

C# programming
Object-oriented programming
Game development
Physics simulation
Procedural generation
Collision detection
User interface development
Input handling
Audio integration
Real-time system management

Therefore, the project is not only a game but also an example of integrating multiple software engineering and programming concepts into a single interactive application.

🚀 Possible Future Enhancements

The project can be extended with additional features such as:

Multiple playable characters.
Character customization.
Different environments.
Power-ups.
Daily challenges.
High-score leaderboard.
Save/load player progress.
Multiple difficulty modes.
Additional obstacle types.
More advanced animations.
Mobile touch controls.
Online leaderboard.
Achievement system.
👨‍🏫 Short Faculty Presentation Explanation

If your faculty asks:

"Explain your project."

You can say:

Royal Run is a 3D endless runner game developed using Unity and C#. The main objective is to allow the player to continuously run through a procedurally generated environment while avoiding obstacles and collecting coins. The game uses a dynamic level-generation system to create new chunks during gameplay, making the environment effectively endless.

The project is divided into several modules, including GameManager for controlling the overall game state, LevelGenerator for generating the environment, ObstacleSpawner for placing obstacles, a movement controller for player interaction, and UIManager for displaying score, coins, and lives.

The game also implements collision detection, a three-life health system, dynamic difficulty, scoring, coin collection, audio feedback, and a user interface. The project demonstrates practical implementation of C# programming, object-oriented design, Unity physics, procedural generation, and real-time game-state management.

🎤 Important Questions Faculty May Ask
1. Why did you choose Unity?

Answer:

Unity provides an integrated environment for 3D game development and supports C# scripting, physics, animation, UI, audio, and rendering. It also provides tools that simplify the development and testing of interactive applications.

2. Why did you use C#?

C# is Unity's primary scripting language and supports object-oriented programming, which makes it suitable for organizing different game components into separate classes.

3. What is procedural generation?

Procedural generation is the technique of creating game content algorithmically rather than manually creating every part of the environment.

4. Why use procedural generation?

It allows the game to continuously generate new sections of the environment and reduces the requirement to manually create an extremely large level.

5. What is the role of GameManager?

GameManager acts as a central controller for important gameplay operations such as score, lives, game states, and game-over management.

6. What happens when the player hits an obstacle?

Collision detection identifies the interaction between the player and obstacle, after which the player's life count is reduced. If no lives remain, the game enters the Game Over state.

7. How does the game become more difficult?

The game gradually increases the running speed as the player progresses, which increases the reaction requirement and overall difficulty.

8. What is URP?

URP stands for Universal Render Pipeline. It is Unity's rendering pipeline designed to provide optimized and scalable graphics across different platforms.

9. What is the purpose of the UIManager?

UIManager is responsible for updating the information presented to the player, such as score, coins, and remaining lives.

10. What makes the project technically interesting?

The main technical feature is the combination of procedural level generation, real-time gameplay management, physics-based movement, collision detection, dynamic difficulty, and UI/audio systems within a single application.

