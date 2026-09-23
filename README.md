# 👑 Royal Run

**Royal Run** is a 3D endless runner game built with Unity. Dash through an infinite, procedurally generated obstacle course, collect coins, and survive as the speed intensifies!

---

## 🎮 Gameplay Features

*   **Infinite Procedural Generation**: The world is built in real-time using "chunks" to ensure no two runs are exactly the same.
*   **Dynamic Difficulty**: The game speed gradually increases over time, challenging your reflexes.
*   **Score & Currency**: Earn score based on distance survived and collect coins to boost your tally.
*   **Health System**: You have 3 lives. Colliding with obstacles costs a life, but the game continues until you run out.
*   **Audio Experience**: Immersive sound effects for coin collection and background music.

## 🛠 Tech Stack

*   **Engine**: Unity 2022.3 (or later)
*   **Language**: C#
*   **Render Pipeline**: Universal Render Pipeline (URP)
*   **Input**: Unity New Input System
*   **Architecture**:
    *   **GameManager**: Handles core game loop, scoring, life management, and game over states.
    *   **LevelGenerator**: Manages object pooling and procedural spawning of ground chunks.
    *   **UIManager**: Updates HUD elements (Score, Coins, Lives).
    *   **Movement**: Physics-based character controller using RigidBody.

## 🕹 Controls

| Action | Control |
| :--- | :--- |
| **Move Left/Right** | `A` / `D` or `Left Arrow` / `Right Arrow` |
| **Exit Game** | `Esc` (if implemented) |

## 📂 Project Structure

*   `Assets/Scripts/`
    *   `GameManager.cs`: Central hub for game logic.
    *   `LevelGenerator.cs`: Infinite terrain spawner.
    *   `ObstacleSpawner.cs`: Handles obstacle placement within chunks.
    *   `movement.cs`: Player movement logic.
    *   `UIManager.cs`: User interface updates.

---

*Project created for educational and portfolio demonstration purposes.*
