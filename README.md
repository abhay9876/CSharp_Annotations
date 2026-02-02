# CSharp_Annotations

This repository is dedicated to understanding and practicing **C# annotations (attributes)**.
It focuses on how attributes are defined, applied, and accessed using **Reflection**, starting
from basic built-in attributes to custom, real-world attribute–based designs.

The repository is designed to help developers write **clean, metadata-driven, and maintainable**
C# code using annotations effectively.

---

##  annotations Branch

The `annotations` branch includes hands-on practice for the complete attribute workflow:

- Built-in attributes such as `override` and `Obsolete`
- Creating custom attributes
- Applying attributes at class, method, and field levels
- Reading attribute metadata using Reflection
- Implementing real-world scenarios like:
  - Validation
  - Logging
  - Execution time tracking
  - Access control

---

## 📝 Exercises & Practice Problems

### Core Attribute Exercises

- Demonstrate correct method overriding by creating a parent `Animal` class with a `MakeSound()` method and overriding it in a `Dog` class using `override`.
- Use the `Obsolete` attribute to mark a deprecated method in a `LegacyAPI` class and introduce a new replacement method.
- Create a custom attribute `TaskInfo` with properties such as priority and assigned person, apply it to a method, and retrieve its values using Reflection.
- Implement a repeatable attribute `BugReport` that can be applied multiple times to the same method and retrieve all applied instances via Reflection.

### Custom Attribute Use Cases

- Create an `ImportantMethod` attribute to mark critical methods with an optional importance level and identify them at runtime.
- Create a `Todo` attribute to track pending tasks with description, assigned developer, and priority, and list all pending tasks using Reflection.
- Implement a `LogExecutionTime` attribute to measure and display method execution time using `Stopwatch`.
- Create a `MaxLength` attribute to enforce maximum length validation on string fields and throw exceptions when constraints are violated.
- Implement role-based access control using a `RoleAllowed` attribute to restrict method execution based on user roles.

---

## Learning Outcomes

By completing this repository, you will gain:

- Strong understanding of C# attributes and annotations
- Practical experience using Reflection
- Ability to design metadata-driven logic
- Experience applying attributes for validation, logging, performance, and security
- Skills to write cleaner and more maintainable C# applications

---

## Author  
**Abhay Singh**  
B.Tech | Aspiring .NET Developer  
Focused on Advanced C#, Generics, Collections Framework, and DSA with real-world application mindset. 
