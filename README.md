# 🎯 C# Practice Repository
Welcome to my **C# practice repository** 🚀
This repo documents my journey of learning C# — starting from **console applications** and moving toward **modern GUI-based apps** using **.NET MAUI**.
---
## 📁 Projects
### 🔹 Basics
#### 🎲 Number Guessing Game — Console
A simple console game where the player guesses a randomly generated number between **1–100**.

**What it practices:**
* 🔁 Loops & conditionals
* ⌨️ User input & type conversion
* 🎲 `Random` number generation
* 🧩 **Method refactoring and code organization**

**Refactored Architecture:**
The game has been refactored into clean, reusable methods following best practices:
* `GetValidNumber()` - Input validation and error handling
* `greetUser()` - Welcome message display
* `randomNumber()` - Random number generation
* `Counter()` - Core game logic and attempt tracking
* `PlayAgain()` - Replay prompt with boolean return
* `Main()` - Clean program flow controller

This refactoring demonstrates:
* Single Responsibility Principle (each method does one thing)
* Method parameters and return values
* Separation of concerns
* Improved code readability and maintainability

---
#### 🖥️ Number Guessing Game — GUI (.NET MAUI)
A **graphical version** of the Number Guessing Game built using **.NET MAUI** and **XAML**.
**Key highlights:**
* 🎨 Clean and responsive UI
* 🧠 Event-driven logic
* 🔘 Button-based interaction
* 💬 Instant feedback for each guess
**Concepts practiced:**
* .NET MAUI project structure
* XAML layouts
* Code-behind logic
* Cross-platform app development
---
#### 📝 To-Do List — Console
A **command-line task management app** that lets users add tasks for different days of the week.
**Key features:**
* 📅 Day-based task organization
* ➕ Add multiple tasks in one session
* ✅ Input validation with switch statements
* 🔄 Loop-based workflow (continue until user exits)
**What it practices:**
* `while` loops for continuous user interaction
* `switch` statements for day validation
* String manipulation and case handling
* Boolean logic for flow control
* User-friendly console interface design
---
#### 🤖 User (Chatbot Console)
A **conversational console chatbot** that interacts with users based on their mood and offers assistance.
**Key features:**
* 👋 Personalized greeting with user's name
* 😊😔 Mood classification (Good/Bad) with appropriate responses
* 💬 Interactive conversation flow
* ✅ Confirmation and retry logic
* 🔄 Recursive restart capability
**What it practices:**
* `switch` statements for response classification
* String manipulation and concatenation
* Boolean conversion from user input
* Method recursion (`Main()` restart)
* Multi-step user interaction flow
* Input validation and error handling
* Type conversion (`string` to `bool`)
---
## 🎯 Goals
✔ Practice C# fundamentals through hands-on projects  
✔ Build strong coding habits  
✔ Learn Git & GitHub workflow  
✔ Create a public learning portfolio  
✔ Transition from console → GUI apps  
✔ Master code refactoring and clean code principles  
---
## 📈 Progress Tracker
* ✅ Completed **W3Schools C# Course (100%)**
* ✅ Built first **Console Project** (Number Guessing Game)
* ✅ **Refactored Number Guessing Game** into clean methods
* ✅ Added **.NET MAUI GUI Application**
* ✅ Created **To-Do List Console App** with loops and validation
* ✅ Built **Chatbot Console App** with mood classification and conversation flow
* 🚀 Currently building more beginner-friendly projects
---
## 📚 What I'm Learning
* Control flow (loops, conditionals, switch statements)
* User input & validation
* Random number generation
* Console vs GUI applications
* .NET MAUI & XAML basics
* Version control with Git & GitHub
* String manipulation and type conversion
* Method recursion and program flow control
* Boolean logic and type conversion
* **Code refactoring and clean architecture**
* **Method design: parameters, return values, and single responsibility**
* **Separating concerns for maintainable code**
---
## 🧩 Folder Structure
```text
basic/
├── NumberGuessingGame/        # Console version (refactored)
├── NumberGuessingGameUI/      # .NET MAUI GUI version
├── To_DO_LIst/                # Console To-Do List app
└── User/                      # Chatbot Console app
```
---
## 🛠️ Technologies & Tools
* **Language:** C# (.NET 6+)
* **Framework:** .NET MAUI (for GUI apps)
* **IDE:** Visual Studio / Visual Studio Code
* **Version Control:** Git & GitHub
---
## 🚀 How to Run
**Console Applications:**
```bash
cd basic/[ProjectName]
dotnet run
```
**.NET MAUI Applications:**
```bash
cd basic/NumberGuessingGameUI
dotnet build
dotnet run
```
---
## 📖 Learning Resources
* [W3Schools C# Tutorial](https://www.w3schools.com/cs/) - Completed ✅
* Microsoft .NET Documentation
* .NET MAUI Official Docs
* Clean Code Principles & Refactoring Practices
---
## 🧠 Key Learnings
### Code Refactoring
Through refactoring the Number Guessing Game, I learned:
* **Breaking down complex code** into smaller, focused methods
* **Single Responsibility Principle** - each method does one thing well
* **Method signatures** - using parameters to pass data in, return values to send data out
* **Code organization** - keeping related logic together while maintaining separation of concerns
* **Readability** - writing self-documenting code through clear method names

---
✨ *This repository represents my learning journey — every commit, every project is progress.*
