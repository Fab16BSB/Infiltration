![License: MIT](https://img.shields.io/badge/License-MIT-green)
![University: IUT Montreuil](https://img.shields.io/badge/IUT%20Montreuil-Computer%20Science-red)
![Engine: Unity](https://img.shields.io/badge/Unity-5.x-lightgrey)
![Language: C#](https://img.shields.io/badge/C%23-7.0-blueviolet)
![Project Type](https://img.shields.io/badge/Game-Infiltration-blue)
![Contributors](https://img.shields.io/badge/contributors-4-orange)
![Stars](https://img.shields.io/github/stars/Fab16BSB/Infiltration?color=orange)
![Fork](https://img.shields.io/github/forks/Fab16BSB/Infiltration?color=orange)
![Watchers](https://img.shields.io/github/watchers/Fab16BSB/Infiltration?color=orange)

# 🕵️ Infiltration

## 🌍 Multilingual README Versions

| 🇫🇷 Français | 🇬🇧 English | 🇪🇸 Español |
|-------------|------------|------------|
| [README.fr.md](./README.fr.md) | You are here! | [README.es.md](./README.es.md) |

---

## 📘 Project Overview

This project was developed during the **second year of a Computer Science degree (DUT)** at the **IUT de Montreuil** in 2016. It served as the final project for the **Video Game Development** course.

We were a team of **4 students**. The objective was to design a complete stealth game using **Unity** and **C#**.

> ⚠️ The game is **exclusively available in French**.

---

## 🎭 The Story: "The Stolen Idea"

You are interviewing for an internship at **Woodle**, a renowned tech company. During the interview, you present a revolutionary project idea.

The company decides not to hire you... but you soon discover they have **stolen your idea** to develop it themselves!

Injustice! You decide to take matters into your own hands. Your mission: **infiltrate Woodle's headquarters at night** using various secret identities. Your ultimate goal is to access the central server to **erase all traces of your project** and prevent the company from profiting from your work.

---

## 🕹️ Game Presentation

**Infiltration** blends narrative, strategy, and stealth:

- **Identity System (Lives):** Your identities are your "lives." If you are caught, you lose your cover and must return under a **new identity** to continue the mission.
- **Stealth & Discretion:**
    - **Visual:** Avoid the guards' vision cones.
    - **Auditory:** A **noise** system is integrated. Walk carefully; heavy footsteps can alert nearby guards.
- **Tactical Hiding:** You can hide in **trash cans** to escape guard surveillance, but beware: this is only possible if no enemy has spotted you yet!
- **Narrative:** A scripted tutorial mode sets the stage with the job interview and the company's betrayal.
- **Varied Levels:** Each team member designed specific challenges to test your reflexes and patience.

### ⚠️ A Real Challenge
The game offers an **exacting level of difficulty**:
* **Cunning Enemies:** Some guards have unpredictable behaviors and won't be easily bypassed.
* **No Hiding Once Spotted:** If an enemy already has you in their line of sight, it's too late to hide in a bin. You must stay out of sight BEFORE seeking refuge.

---

## ⚙️ Technologies Used

- **Game Engine:** Unity (2016 Version)
- **Language:** C#
- **Platform:** Windows (x86)

---

## 💻 Installation and Execution

### 🚀 Play Immediately (Release Version)

A ready-to-play version (Build) is available in the **Releases** section of this repository.

1. Go to the [Releases](https://github.com/Fab16BSB/Infiltration/releases/tag/v1.0) tab.
2. Download the `Infiltration_Archive.zip` file.
3. Extract the archive (contains the `.exe`, the `_Data` folder, and `.pdb` debug files).
4. Run **infiltration.exe**.

### 🛠️ Open the Project (Source Code)

To explore the scripts or scenes:
1. Clone this repository.
2. Open the folder with **Unity Hub** (version 5.x recommended for compatibility).

---

## ⌨️ Controls and Commands

The game offers great flexibility to suit your playstyle, whether you are right-handed or left-handed.

### 🏃 Movement and Actions
| Action | Keys (Right-handed) | Keys (Alternative / Left-handed) |
| :--- | :--- | :--- |
| **Movement** | `W` `A` `S` `D` | `Arrow Keys` (↑ ← ↓ →) |
| **Run** | `Left Shift` | `Right Shift` |
| **Slow down / Stealth** | `Left Ctrl` | `Right Ctrl` |
| **Open Door** | `Space` | `Space` |

> 💡 **Pro-tip:** Running generates significant noise (`XX`), while walking while holding `Ctrl` allows you to be completely silent (`--`).

### 🎧 Sound Immersion
The game features a **full soundscape**. Audio is a core gameplay element: listen closely to guards' footsteps and alarms to anticipate danger!

### 🚪 How to Quit the Game
* **Recommended Method:** Use the `Ctrl` + `Alt` + `Tab` shortcut to exit the window and close the application manually.

---

## 🎮 Gameplay Overview

### Main Menu
The game's home interface where you can launch the infiltration mission.
![Main Menu](images/main_menu.png)

---

### Tutorial Phase
The game begins with a narrative phase to learn the basics of stealth.
![Tutorial - Start](images/tutoriel1.png)
*Objective: Access the main computer on the top floor.*

![Tutorial - Mechanics](images/tutoriel2.png)
*Learning noise management and collecting key items like ID cards.*

---

### Stealth and Surveillance
Once inside Woodle's premises, vigilance is key. Guards patrol with dynamic vision cones whose color indicates their alert status.

![Level 1 - Guards](images/lvl1_1.png)
*Dodge the guards' field of vision to keep your identity intact.*

![Level 1 - Exploration](images/lvl1_3.png)
*Pick up the map to reveal the location of nearby items.*

---

### 👮 Enemy Behavior

The detection system is based on advanced management of guard vision and hearing. Pay attention to their beam color and alert icons:

* **Patrol (Yellow Beam):** The guard's normal state. They follow a predefined path, unaware of your presence.
* **Aural Suspicion (Red Beam + `?`):** Guards are sensitive to noise (marked by `X` or `XX` on your HUD). If they hear a sound, they abandon their patrol to move immediately to the **exact location** of the noise to investigate.
* **Visual Detection (Red Beam + `!`):** If you enter a guard's field of vision, they formally identify you. Your current identity is compromised, and you lose a "life."
* **Sleep (Purple Beam):** You may encounter sleeping guards. They cannot see, but stay quiet—a loud noise can wake them up instantly!

### 📸 Alert States in Action

![Aural Alert](images/lvl1_4.png)  
*A red beam with a **?** indicates the enemy heard a suspicious noise and is moving to check the area.*

![Immediate Detection](images/lvl1_5.png)  
*A red beam with a **!** signals immediate visual detection: you have been spotted.*

---

### Hiding System
An essential mechanic for survival, subject to strict conditions.
![Trash Can System](images/lvl1_2.png)
*You can hide in trash cans, but only if you are not already in an enemy's line of sight.*

---

### HUD Details (Interface)
The in-game interface displays crucial information for your survival:

* **Identities (Lives):** Located at the top left, these show the number of covers remaining before mission failure.
* **Noise Indicator:** Located at the top right, it changes based on your actions:
    * `--`: You are perfectly silent.
    * `X`: Light noise, be careful of nearby guards.
    * `XX`: Loud noise, you risk alerting the entire zone.
* **Inventory:** View your quest items and access cards in real-time.

---

## 🧑‍💻 The Team

Four of us worked on this project with the following breakdown:

- **Boris Eng**: Story co-author, tutorial creation, and all environment/decor design.
- **Thomas Dunglas**: HUD (User Interface) creation and design of one complete level.
- **Lucas**: Design and creation of one complete level.
- **Me**: Story co-author, tutorial creation, and gameplay mechanics.

---

## 🙌 Acknowledgments

I would like to thank my professors at IUT de Montreuil for proposing this project and for their valuable technical advice during this course.