# 🚀 Unity Rocket Game

A 3D rocket navigation game built with Unity and C#. Pilot your rocket, avoid obstacles, and land safely to progress through levels!

---

## 📝 Game Overview

In this game, you control a rocket and must navigate through various obstacles to reach the landing pad. Each level presents new challenges and layouts. Use your thrusters wisely to avoid crashing and reach the finish!

---

## 🎮 Features

- 3D rocket movement and controls
- Launchpads and landing pads
- Obstacles and boundaries
- Multiple levels
- Cinemachine camera system

## 🛠️ Getting Started

### Prerequisites

- [Unity](https://unity.com/) (version 2020.3 or newer recommended)
- [Git](https://git-scm.com/)

### Running the Game

1. **Clone the repository:**
   ```sh
   git clone https://github.com/yourusername/unity-rocket-game.git
   ```
2. **Open the project in Unity:**
   - Launch Unity Hub
   - Click "Open" and select the project folder

3. **Play:**
   - Open any scene from the `Assets/Scenes` folder (e.g., `Tutorial.unity`)
   - Press the Play button in the Unity Editor

---

## 🎮 How to Play

- **Movement Controls:**
  - **Thrust Upwards:** Hold `Space` to fire the rocket’s thruster and ascend.
  - **Rotate Left:** Hold `A` to rotate the rocket left.
  - **Rotate Right:** Hold `D` to rotate the rocket right.

- **Objective:**  
  Reach the platform tagged as `Finish` without colliding with obstacles.

- **Game Events:**
  - **Collision with Obstacles:** The rocket explodes, and the level restarts.
  - **Landing on Finish Pad:** You win the level and progress to the next one.
  - **Cheat Mode:** Press `Z` to toggle cheat mode (disables collision consequences).

- **Particles & Audio:**
  - Thrusters and collisions are accompanied by particle effects and sound for an immersive experience.

---

## 🗂️ Project Structure
Assets/
├── Audio/
├── Effects/
├── Materials/
├── Scenes/
├── Scripts/
│ ├── Movement.cs
│ ├── Collisonfuncs.cs
│ └── ...
└── ...
