# 🎯 C# Practice Repository

Welcome to my **C# practice repository** 🚀
This repository documents my journey of learning **C#**, starting with **console-based applications** and gradually moving toward **modern GUI apps** using **.NET MAUI**.

Each project focuses on **core programming fundamentals**, **clean code**, and **progressive refactoring**.

---

## 📁 Projects

### 🔹 Basics

---

### 🎲 Number Guessing Game — Console

A simple console game where the player guesses a randomly generated number between **1–100**.

**What it practices:**

* 🔁 Loops & conditionals
* ⌨️ User input & type conversion
* 🎲 `Random` number generation
* 🧩 **Method refactoring and code organization**

**Refactored Architecture:**

* `GetValidNumber()` – Input validation and error handling
* `GreetUser()` – Welcome message display
* `RandomNumber()` – Random number generation
* `Counter()` – Core game logic and attempt tracking
* `PlayAgain()` – Replay prompt with boolean return
* `Main()` – Clean program flow controller

**Key Learnings:**

* Single Responsibility Principle
* Passing data using return values
* Clean and readable program flow

---

### 🖥️ Number Guessing Game — GUI (.NET MAUI)

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

### 📝 To-Do List — Console (Refactored)

A **command-line task management app** that allows users to add tasks for specific days of the week.

**Key features:**

* 📅 Day-based task organization
* ➕ Add multiple tasks in a single session
* 🔄 Continuous workflow using loops
* ❌ Rejects invalid day input gracefully

**Refactored Validation Logic:**

* Days are stored in a **string array**
* User input is validated using a loop
* Case-insensitive comparison with normalization
* Only valid days are accepted before continuing

**What it practices:**

* `while` loops for repeated user interaction
* Array-based input validation
* String comparison using `StringComparison.OrdinalIgnoreCase`
* Boolean flags for control flow
* Method-based program structure

**Refactoring Highlights:**

* Clear separation of concerns
* Reusable `Days()` method for validation
* Improved readability and maintainability
* Beginner-friendly, scalable logic

---

### 🤖 User (Chatbot Console — Refactored)

A **conversational console chatbot** that interacts with users based on their mood and provides responses accordingly.

**Key features:**

* 👋 Personalized greeting
* 😊😔 Mood classification (Good / Bad)
* 💬 Interactive conversation flow
* 🔄 Restart capability

**Refactored Architecture:**

* `GreetUser()` – Handles greeting and name input
* `AskMood()` – Mood input with switch-case validation
* `MoodType()` – Captures user intent
* `Response()` – Confirmation handling using boolean logic
* `TryAgain()` – Restart control
* `Main()` – Clean loop-based program flow

**What it practices:**

* `switch` statements
* Boolean logic from user input
* Method chaining via return values
* Input validation and retry logic
* Clean console UI interaction

---

## 🎯 Goals

✔ Practice C# fundamentals through hands-on projects
✔ Build strong coding habits
✔ Learn Git & GitHub workflow
✔ Create a public learning portfolio
✔ Transition from console → GUI apps
✔ Master **refactoring and clean code principles**

---

## 📈 Progress Tracker

* ✅ Completed **W3Schools C# Course (100%)**
* ✅ Built **Number Guessing Game (Console)**
* ✅ Refactored Number Guessing Game into clean methods
* ✅ Built **.NET MAUI GUI version**
* ✅ Built **To-Do List Console App**
* ✅ **Refactored To-Do List** with array-based validation
* ✅ Built **Chatbot Console App**
* ✅ Refactored Chatbot into modular methods
* 🚀 Continuously adding beginner-friendly projects

---

## 📚 What I’m Learning

* Control flow (loops, conditionals, switch)
* User input & validation
* Arrays and string comparison
* Console vs GUI applications
* .NET MAUI & XAML
* Git & GitHub workflow
* Boolean logic and return values
* Method chaining and data flow
* **Clean code and refactoring principles**
* **Designing methods with single responsibility**

---

## 🧩 Folder Structure

```text
basic/
├── NumberGuessingGame/        # Console version (refactored)
├── NumberGuessingGameUI/      # .NET MAUI GUI version
├── To_DO_List/               # Console To-Do List app (refactored)
└── User/                     # Chatbot Console app (refactored)
```

---

## 🛠️ Technologies & Tools

* **Language:** C# (.NET 6+)
* **Framework:** .NET MAUI
* **IDE:** Visual Studio
* **Version Control:** Git & GitHub

---

## 🚀 How to Run

### Console Applications

```bash
cd basic/[ProjectName]
dotnet run
```

### .NET MAUI Application

```bash
cd basic/NumberGuessingGameUI
dotnet build
dotnet run
```

---

## 🧠 Key Learnings

Through refactoring multiple projects, I learned:

* Breaking complex logic into smaller methods
* Writing readable and maintainable code
* Validating user input properly
* Passing data using method return values
* Designing clean program flow
* Thinking logically instead of hard-coding

---

✨ *This repository reflects my continuous learning journey — every refactor is an improvement, and every project builds confidence.*

