# C# Practice Repository

This repository tracks my progress learning C# and .NET development. Started on January 7, 2025.

## About

I'm learning C# to pursue a career in .NET development. This repo contains practice projects that helped me understand core programming concepts, from basic console applications to GUI development with .NET MAUI.

Each project represents a step forward in my learning journey. I've focused on writing clean, readable code and refactoring my initial implementations as I learn better practices.

## Projects

### Number Guessing Game (Console)
A simple number guessing game where the player tries to guess a random number between 1-100.

**Concepts applied:**
- Loops and conditionals
- User input validation
- Random number generation
- Method extraction and code organization

**Key refactoring:**
Initially wrote everything in Main(). Later broke it down into smaller methods: `GetValidNumber()`, `GreetUser()`, `RandomNumber()`, `Counter()`, and `PlayAgain()`. This made the code much easier to read and maintain.

### Number Guessing Game (GUI - .NET MAUI)
Same game logic as the console version, but with a graphical interface built using .NET MAUI and XAML.

**What I learned:**
- Basic .NET MAUI project structure
- XAML for UI layout
- Event-driven programming
- Separating UI from business logic

### To-Do List (Console)
A command-line task manager that lets users add tasks to specific days of the week.

**Features:**
- Add multiple tasks per day
- Day-based organization
- Input validation using string arrays
- Tasks displayed as bullet points per day

**Recent improvements:**
- Added validation to reject null/empty inputs
- Implemented loop-based day validation
- Used `StringComparison.OrdinalIgnoreCase` for flexible input matching
- Refactored into separate methods for better organization

### Chatbot (Console)
A simple conversational chatbot that asks about the user's mood and responds accordingly.

**Implementation:**
- Uses switch statements for mood classification
- Boolean logic for user responses
- Method chaining with return values
- Input validation and retry logic

**Code structure:**
Separated concerns into `GreetUser()`, `AskMood()`, `MoodType()`, `Response()`, and `TryAgain()` methods instead of one long Main() method.

## Progress

**Completed:**
- W3Schools C# Course (100%)
- 4 console applications with proper refactoring
- 1 .NET MAUI GUI application
- Basic understanding of clean code principles

**Currently learning:**
- ASP.NET Core for web development
- Entity Framework for database operations
- More advanced OOP concepts
- Design patterns

## Tech Stack

- C# (.NET 6+)
- .NET MAUI
- Visual Studio
- Git/GitHub

## Running the Projects

Console applications:
```bash
cd basic/[ProjectName]
dotnet run
```

.NET MAUI application:
```bash
cd basic/NumberGuessingGameUI
dotnet build
dotnet run
```

## What's Next

Planning to build a simple ASP.NET web application to learn web development with C#. Also want to add database functionality to my existing projects using SQL Server or SQLite.

## Notes to Self

Things I've learned through mistakes:
- Always validate user input - learned this after my first To-Do app crashed on empty inputs
- Breaking code into methods makes debugging so much easier
- Writing clear method names is harder than it looks but worth it
- Git commits should be more frequent - I keep forgetting to commit small changes

---

*Learning in public. Started January 7, 2025.*
