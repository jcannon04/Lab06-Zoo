# Lab06 - Zoo & Lab07 - Interfaces 

## Overview
The Lab06 - Zoo Console Application is a simple yet engaging program that models a zoo. It demonstrates the fundamental principles of Object-Oriented Programming (OOP) by utilizing inheritance, polymorphism, encapsulation, and abstraction to create a hierarchy of animal classes.

## Class Hierarchy
The application's class structure revolves around an inheritance hierarchy with a base class named Animal and five concrete classes that represent different animals found in the zoo. Each concrete class inherits from the Animal class and utilizes or overrides its properties and methods. 

## Features
Animal Class: The Animal class serves as the base class and defines the basic attributes of an animal, such as Name, Color, NumOfLegs, Sound, and more.

Mammal and Bird Classes: The Mammal and Bird classes are derived from the Animal class. They further specialize the animal hierarchy by adding specific behaviors and attributes for mammals and birds.

Concrete Animal Classes: The application includes three concrete animal classes: BabySeal, Giraffe, and Pigeon. These classes represent specific animals found in the zoo.

Polymorphism: The Speak(), Eat(), Sleep(), and Move() methods are overridden in the concrete classes to provide specialized behavior for each animal type.

Encapsulation: The properties in each class are encapsulated to ensure data integrity and controlled access.

## How to Use
Clone the repository to your local machine.

Open the solution in a C# compatible IDE, such as Visual Studio.

Navigate to the Program.cs file in the console application project.

Run the application.

The console will prompt you to interact with different animals in the zoo. You can choose options to make each animal speak, eat, sleep, and move.

Observe how the program demonstrates OOP principles by utilizing inheritance and polymorphism to exhibit different behaviors for each animal type.

Dont forget to run the unit tests!

## Conclusion
The Lab06 - Zoo Console Application provides an interactive and educational experience, showcasing the power of OOP concepts in designing a simple zoo model. It demonstrates the practical applications of inheritance, polymorphism, encapsulation, and abstraction to create a well-structured and maintainable codebase. Enjoy exploring the virtual zoo and understanding the behaviors of various animals in a fun and engaging manner!