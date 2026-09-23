# 👑 Royal Run

## 3D Endless Runner Game

**Royal Run** is a 3D endless runner game developed using **Unity and C#**. The player continuously runs through a procedurally generated environment, avoids obstacles, collects coins, and tries to survive for as long as possible while the game gradually becomes more challenging.

The project demonstrates practical concepts of **3D game development, C# programming, procedural level generation, physics-based movement, collision detection, user-interface management, audio integration, and real-time game-state management**.

---

## 📌 Project Overview

| Category | Details |
|---|---|
| 🎮 Project Name | Royal Run |
| 🕹️ Project Type | 3D Endless Runner |
| 🛠️ Game Engine | Unity |
| 💻 Programming Language | C# |
| 🎨 Render Pipeline | Universal Render Pipeline (URP) |
| 🎮 Input System | Unity New Input System |
| 🌍 Environment | Procedurally Generated |
| 🧩 Architecture | Modular C# Components |
| 💻 Target Platform | Desktop |
| 📚 Project Purpose | Academic / Educational / Portfolio |

---

# 🎯 Project Objective

The main objective of **Royal Run** is to develop an interactive 3D endless runner game that demonstrates how different game-development systems can work together in real time.

The project focuses on:

- Player movement
- Procedural environment generation
- Obstacle spawning
- Coin collection
- Score management
- Life management
- Dynamic difficulty
- User interface
- Audio feedback
- Collision detection
- Game-state management

The project also demonstrates how an effectively endless game environment can be created without manually designing the complete track in advance.

---

# 🎮 Gameplay Overview

In Royal Run, the player continuously runs through an endless environment.

The main gameplay loop is:

```text
Start Game
    ↓
Player Begins Running
    ↓
Procedurally Generated Track
    ↓
Avoid Obstacles
    ↓
Collect Coins
    ↓
Increase Score
    ↓
Speed Gradually Increases
    ↓
Continue Running
    ↓
Lose All Lives
    ↓
Game Over
```

The main objective is to **survive for as long as possible, collect coins, and achieve a high score**.

---

# ✨ Main Features

## ♾️ Infinite Procedural Generation

The game environment is created using reusable **track chunks**.

Instead of creating one extremely large level manually, the game generates and manages sections of the track during gameplay.

This approach provides:

- Continuous gameplay
- Reusable level sections
- Reduced requirement for a large fixed level
- Better replayability
- Easier level expansion
- A foundation for more advanced procedural generation

### Generation Concept

```text
Player Progress
      ↓
Check Available Track
      ↓
Generate / Reuse Next Chunk
      ↓
Add Obstacles / Coins
      ↓
Continue Gameplay
```

---

## 🚧 Dynamic Obstacles

Obstacles are placed throughout the generated track.

The player must move left or right to avoid them.

When the player collides with an obstacle:

```text
Player
   ↓
Collision Detected
   ↓
Life Reduced
   ↓
HUD Updated
   ↓
Continue / Game Over
```

Obstacles provide the primary survival challenge of the game.

---

## 🪙 Coin Collection

Coins are collectible objects placed throughout the running environment.

When the player reaches a coin:

1. The coin is collected.
2. The coin counter increases.
3. The collection event is processed.
4. Audio feedback can be triggered.
5. The HUD reflects the updated coin count.

Coins provide an additional gameplay objective besides simply surviving.

---

## ❤️ Three-Life System

Royal Run uses a three-life system.

The initial state is:

```text
Lives = 3
```

When the player hits an obstacle:

```text
3 Lives
   ↓
2 Lives
   ↓
1 Life
   ↓
0 Lives
   ↓
Game Over
```

The current number of remaining lives is displayed through the game's HUD.

---

## 📈 Score System

The game maintains a score representing the player's gameplay progress.

The score provides a measurable objective and encourages the player to continue running and improve their performance.

The longer the player survives and progresses, the greater the opportunity to achieve a higher score.

---

## ⚡ Dynamic Difficulty

Royal Run gradually increases the running speed as gameplay progresses.

The basic concept is:

```text
Game Start
    ↓
Normal Speed
    ↓
Player Survives
    ↓
Speed Increases
    ↓
Reaction Time Decreases
    ↓
Higher Challenge
```

This prevents the game from remaining at the same difficulty throughout the entire run.

---

## 🔊 Audio Experience

The project includes audio feedback to make gameplay more interactive.

Audio can be used for:

- Background music
- Coin collection
- Gameplay events
- Player feedback

Audio feedback helps communicate important gameplay events to the player.

---

# 🕹️ Controls

| Action | Keyboard |
|---|---|
| Move Left | `A` |
| Move Right | `D` |
| Move Left | `← Left Arrow` |
| Move Right | `→ Right Arrow` |
| Exit Game | `Esc` *(if implemented/configured)* |

---

# 🏗️ System Architecture

Royal Run follows a modular architecture where different gameplay responsibilities are handled by separate C# components.

```text
                         ROYAL RUN
                             │
            ┌────────────────┼────────────────┐
            │                │                │
            ▼                ▼                ▼
      GameManager      LevelGenerator      UIManager
            │                │                │
            │                ├── Chunks       ├── Score
            │                ├── Obstacles    ├── Coins
            │                └── Coins        └── Lives
            │
            ├── Game State
            ├── Score
            ├── Lives
            └── Game Over
                             │
                             ▼
                      Player Movement
                             │
                             ▼
                      Collision System
                         /          \
                        /            \
                       ▼              ▼
                  Obstacle          Coin
                       │              │
                       ▼              ▼
                   - Life         + Coins
```

The modular structure makes the project easier to understand, maintain, debug and extend.

---

# 🧩 Core Components

## `GameManager.cs`

`GameManager.cs` acts as the central controller for important gameplay logic.

### Responsibilities

- Manage the game state
- Manage score
- Manage lives
- Handle game-over conditions
- Coordinate important gameplay events

---

## `LevelGenerator.cs`

`LevelGenerator.cs` manages the endless running environment.

### Responsibilities

- Generate track sections
- Manage reusable chunks
- Extend the track during gameplay
- Support continuous player progression
- Maintain the playable environment ahead of the player

---

## `ObstacleSpawner.cs`

`ObstacleSpawner.cs` manages obstacle placement.

### Responsibilities

- Place obstacles inside generated sections
- Create gameplay challenges
- Provide obstacle configurations for the running track

---

## `movement.cs`

`movement.cs` controls player movement.

### Responsibilities

- Read player input
- Handle horizontal movement
- Control player movement behavior
- Work with the configured physics system

### Supported Movement

```text
A / ←  → Move Left

D / →  → Move Right
```

---

## `UIManager.cs`

`UIManager.cs` manages the game's user interface.

### Responsibilities

- Display score
- Display coin count
- Display remaining lives
- Update gameplay information

The HUD allows the player to understand their current game state during gameplay.

---

# 🗂️ Project Structure

The project follows a standard Unity project structure.

```text
Royal-run/
│
├── Assets/
│   │
│   ├── Scenes/
│   │
│   ├── Scripts/
│   │   ├── GameManager.cs
│   │   ├── LevelGenerator.cs
│   │   ├── ObstacleSpawner.cs
│   │   ├── movement.cs
│   │   └── UIManager.cs
│   │
│   ├── Prefabs/
│   │
│   ├── Materials/
│   │
│   ├── Models/
│   │
│   ├── Audio/
│   │
│   └── UI/
│
├── Packages/
│
├── ProjectSettings/
│
└── README.md
```

> The exact folders and additional assets may vary depending on the project version and imported Unity packages.

---

# 🔄 Game Flow

The overall game flow can be represented as:

```text
                  ┌─────────────┐
                  │  Start Game │
                  └──────┬──────┘
                         ↓
                  ┌─────────────┐
                  │ Initialize  │
                  │ Game State  │
                  └──────┬──────┘
                         ↓
                  ┌─────────────┐
                  │  Generate   │
                  │    Track    │
                  └──────┬──────┘
                         ↓
                  ┌─────────────┐
                  │ Player Runs │
                  └──────┬──────┘
                         ↓
              ┌──────────┴──────────┐
              ↓                     ↓
        Collect Coin           Hit Obstacle
              ↓                     ↓
       Increase Coins          Lose 1 Life
              │                     │
              └──────────┬──────────┘
                         ↓
                    Update HUD
                         ↓
                Increase Difficulty
                         ↓
                Generate Next Chunk
                         ↓
                    Lives > 0 ?
                     /       \
                   Yes        No
                    ↓          ↓
                Continue    Game Over
```

---

# 🧠 Game Development Concepts

Royal Run demonstrates several important game-development and programming concepts.

## Object-Oriented Programming

C# scripts separate different responsibilities into classes and components.

## Physics

Unity's physics system is used to support movement and interaction between gameplay objects.

## Collision Detection

Collisions connect gameplay objects with actions such as:

- Losing a life
- Collecting a coin
- Triggering gameplay events

## Procedural Generation

The environment is created and managed through reusable chunks rather than requiring one fixed endless scene.

## State Management

The game maintains important gameplay values such as:

```text
Score
Coins
Lives
Game State
Difficulty / Speed
```

## User Interface

The HUD provides immediate information about the player's current progress.

## Audio Integration

Audio provides feedback for important gameplay events and improves the overall game experience.

---

# 🎨 Rendering

Royal Run uses the:

**Universal Render Pipeline (URP)**

URP is Unity's rendering pipeline used to manage the rendering of the 3D environment and game objects.

The project uses Unity's 3D environment to present:

- Player
- Track
- Obstacles
- Coins
- Environment elements
- UI

---

# 🎮 Unity Input System

The project uses Unity's **New Input System** for player controls.

The input flow is:

```text
Keyboard Input
      ↓
Unity Input System
      ↓
Movement Script
      ↓
Player Movement
```

This separates input handling from the actual player movement implementation.

---

# 🔧 Technologies Used

| Technology | Purpose |
|---|---|
| Unity | Game engine and development environment |
| C# | Gameplay programming |
| Universal Render Pipeline | 3D rendering |
| Unity New Input System | Player input |
| Unity Physics | Movement and collision interaction |
| Unity UI | HUD and gameplay information |
| Unity Audio | Music and sound effects |
| Git | Version control |
| GitHub | Source-code repository |

---

# 💻 System Requirements

## Development Requirements

Recommended requirements include:

- Unity 2022.3 or later
- C# support through Unity
- Windows, macOS or Linux development environment
- Keyboard
- 8 GB RAM or more recommended for comfortable Unity Editor usage
- GPU capable of running the configured 3D/URP project

> The original project is documented for Unity 2022.3 or later. When opening it with a newer Unity 6 version, Unity may request package or project-data updates.

---

# 📥 Installation

## Method 1 — Clone the Repository

Clone the repository using Git:

```bash
git clone https://github.com/prayagsahu/Royal-run.git
```

Then open the downloaded project folder through Unity Hub.

---

## Method 2 — Download ZIP

1. Open the GitHub repository.
2. Click **Code**.
3. Select **Download ZIP**.
4. Extract the ZIP file.
5. Open **Unity Hub**.
6. Select **Add → Add project from disk**.
7. Select the extracted `Royal-run` folder.
8. Open the project using a compatible Unity version.

---

# ▶️ How to Run the Game

After opening the project in Unity:

### Step 1 — Wait for Import

Allow Unity to finish importing assets and packages.

### Step 2 — Open the Gameplay Scene

Open the appropriate gameplay scene from:

```text
Assets → Scenes
```

### Step 3 — Check the Console

Make sure there are no compilation errors.

### Step 4 — Enter Play Mode

Press:

```text
▶ Play
```

### Step 5 — Control the Player

Use:

```text
A / ←  = Move Left

D / →  = Move Right
```

### Step 6 — Test the Gameplay

Verify:

- Player movement
- Track generation
- Obstacles
- Coins
- Score
- Lives
- Difficulty progression
- Audio
- Game-over behavior

---

# 🧪 Testing

The major gameplay functions should be tested before project presentation.

| Test ID | Test Case | Expected Result |
|---|---|---|
| TC-01 | Start Game | Game initializes successfully |
| TC-02 | Press `A` | Player moves left |
| TC-03 | Press `D` | Player moves right |
| TC-04 | Press `←` | Player moves left |
| TC-05 | Press `→` | Player moves right |
| TC-06 | Collect Coin | Coin count increases |
| TC-07 | Hit Obstacle | One life is removed |
| TC-08 | Continue Running | New track sections become available |
| TC-09 | Continue Playing | Score increases |
| TC-10 | Survive Longer | Running speed increases |
| TC-11 | Lose All Lives | Game-over condition occurs |
| TC-12 | Audio Event | Configured audio feedback plays |
| TC-13 | HUD Update | Score, coins and lives update correctly |

---

# 🐛 Troubleshooting

## Game Scene Appears Empty

Make sure you have opened the correct gameplay scene instead of an empty `Untitled` scene.

Check:

```text
Assets
   └── Scenes
        └── Gameplay Scene
```

Open the correct scene and press **Play**.

---

## Player Does Not Move

Check:

- Input System configuration
- Movement script
- Player object
- Rigidbody configuration
- Input bindings
- Console errors

---

## Track Does Not Generate

Check:

- `LevelGenerator`
- Chunk references
- Prefab references
- Scene references
- Unity Console errors

---

## Coins Do Not Update

Check:

- Coin Collider
- Player Collider
- Trigger settings
- Coin collection logic
- UIManager reference

---

## Lives Do Not Decrease

Check:

- Player Collider
- Obstacle Collider
- Rigidbody configuration
- Collision/Trigger settings
- GameManager reference

---

## Console Shows Errors

Open:

```text
Window → General → Console
```

Fix compilation errors before testing gameplay.

---

# 📊 Performance Considerations

Procedural generation can create many runtime objects if the environment is not managed efficiently.

Possible performance improvements include:

- Reusing chunks
- Limiting the number of active chunks
- Removing or recycling chunks behind the player
- Reusing obstacles and collectibles
- Reducing unnecessary object creation
- Using object pooling for frequently created objects
- Optimizing large or complex assets

These improvements become increasingly important as the project grows.

---

# 🚀 Future Enhancements

The current project provides a foundation for additional gameplay and technical features.

## 🎭 Character Selection

Allow the player to select from multiple playable characters.

## 🎨 Character Customization

Add customizable appearances and unlockable cosmetic items.

## ⚡ Power-Ups

Introduce temporary gameplay abilities.

Possible examples:

- Temporary protection
- Coin attraction
- Temporary speed effects

## 🌍 Multiple Environments

Add different visual environments such as:

- City
- Forest
- Desert
- Snow
- Futuristic environment

## 🏆 High Score System

Store and display the player's highest score between game sessions.

## 🌐 Online Leaderboard

Add a backend service for storing and comparing player scores.

## 📱 Mobile Support

Add touch and swipe controls for Android and iOS.

## 🏅 Achievement System

Introduce achievements based on:

- Distance
- Coins collected
- Survival time
- Score
- Gameplay milestones

## 🎵 Advanced Audio

Expand the audio system with:

- Multiple background tracks
- Additional sound effects
- Dynamic music
- Volume controls
- Audio settings

---

# 📚 Learning Outcomes

The project provides practical experience with:

- Unity Editor workflow
- C# programming
- Object-oriented programming
- 3D game development
- Unity physics
- Collision detection
- Procedural generation
- Runtime object management
- Input handling
- UI development
- Audio integration
- Game-state management
- Debugging
- Testing
- Git and GitHub

---

# 🎓 Academic Relevance

Royal Run is suitable as an academic Game Programming project because it combines several programming and game-development concepts into one working application.

The project demonstrates the relationship between:

```text
C# Programming
       +
Unity Engine
       +
Physics
       +
Input System
       +
Procedural Generation
       +
User Interface
       +
Audio
       +
Game State
       ↓
Interactive 3D Game
```

The project can therefore be used to demonstrate both programming knowledge and practical real-time application development during a project presentation or viva.

---

# 📸 Screenshots

Add screenshots of the actual working project to make the repository more professional.

Recommended screenshots:

1. Main gameplay screen
2. Player running on the track
3. Coin collection
4. Obstacle section
5. HUD showing score, coins and lives
6. Game-over screen
7. Unity Hierarchy
8. Unity Project/Assets structure
9. Important C# scripts
10. Procedurally generated track

Example structure:

```text
Screenshots/
├── gameplay.png
├── hud.png
├── coins.png
├── obstacles.png
├── game-over.png
└── unity-editor.png
```

Example Markdown:

```markdown
## 📸 Screenshots

### Main Gameplay

![Royal Run Gameplay](Screenshots/gameplay.png)

### HUD

![Royal Run HUD](Screenshots/hud.png)

### Game Over

![Royal Run Game Over](Screenshots/game-over.png)
```

---

# 📁 Recommended Repository Structure

A clean repository can be organized as follows:

```text
Royal-run/
│
├── Assets/
│
├── Packages/
│
├── ProjectSettings/
│
├── Screenshots/
│   ├── gameplay.png
│   ├── hud.png
│   ├── coins.png
│   ├── obstacles.png
│   └── game-over.png
│
├── Documentation/
│   └── Royal_Run_Project_Documentation.pdf
│
├── README.md
│
└── .gitignore
```

---

# 🔐 Git and GitHub

Before pushing the project to GitHub, unnecessary Unity-generated folders should normally be excluded.

Typical folders that should not be committed include:

```text
Library/
Temp/
Logs/
Obj/
Build/
Builds/
UserSettings/
```

Use an appropriate Unity `.gitignore` file to prevent unnecessary generated files from being uploaded.

---

# 📌 Project Information

| Field | Information |
|---|---|
| Project Name | Royal Run |
| Project Type | 3D Endless Runner |
| Engine | Unity |
| Programming Language | C# |
| Rendering | Universal Render Pipeline |
| Input | Unity New Input System |
| Main Concept | Procedurally Generated Endless Track |
| Development Focus | Game Programming |
| Target Platform | Desktop |
| Project Purpose | Academic / Educational / Portfolio |

---

# 👨‍💻 Author

**Lihuo Hor**

Computer Science Student  
University of Mumbai


# 📄 Project Documentation

The project can be supported by separate academic documentation covering:

- Introduction
- Background
- Problem Statement
- Objectives
- Scope
- Requirements Analysis
- System Design
- System Architecture
- Game Flow
- Implementation
- Testing
- Results
- Limitations
- Future Enhancements
- Conclusion
- References
- Viva Preparation

---

# 🏁 Conclusion

**Royal Run** is a 3D endless runner game that combines **Unity and C#** to create an interactive and continuously playable environment.

The project demonstrates:

- Procedural track generation
- Player movement
- Obstacle interaction
- Coin collection
- Score tracking
- Life management
- Dynamic difficulty
- User-interface management
- Audio feedback
- Collision detection
- Real-time game-state management

The modular architecture provides a foundation for future development. Additional environments, power-ups, character customization, achievements, mobile controls, persistent scores and online features can be added as the project evolves.

---

# ⭐ Project Highlights

```text
👑 Royal Run
│
├── 🎮 3D Endless Runner
├── ♾️ Procedural Track Generation
├── 🚧 Dynamic Obstacles
├── 🪙 Coin Collection
├── ❤️ Three-Life System
├── 📈 Score System
├── ⚡ Dynamic Difficulty
├── 🔊 Audio Feedback
├── 🖥️ HUD
├── 🎨 Unity URP
├── 💻 C# Programming
├── 🎮 New Input System
└── 🧩 Modular Architecture
```

---

## 👑 Royal Run

**Run Further. Collect More. Survive Longer.**
