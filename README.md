# dotnet-dsa

Data Structures and Algorithms implemented using **.NET (C#)** with a strong focus on
**clarity, correctness, and interview readiness**.

This repository is part of a long-term learning journey to build strong fundamentals
in problem-solving, performance analysis, and clean coding using the .NET ecosystem.

---

## 🎯 Goals

- Learn **Data Structures and Algorithms** using idiomatic C#
- Understand **time and space complexity** deeply
- Write **clean, readable, and testable code**
- Avoid unnecessary abstractions and premature optimizations
- Build an **interview-ready reference** for DSA in .NET

---

## 📁 Repository Structure

```
dotnet-dsa
│
├── DotNetDSA.sln
├── NuGet.Config
├── README.md
│
├── src
│   └── DotNetDSA.Core
│       ├── Arrays
│       ├── Strings
│       ├── Hashing
│       ├── Sorting
│       ├── TwoPointers
│       ├── Common
│       └── Program.cs
│
└── tests
    └── DotNetDSA.Tests
        ├── Arrays
        ├── Strings
        ├── Hashing
        ├── Sorting
        ├── TwoPointers
        └── GlobalUsings.cs
```

---

## 🧠 Learning Philosophy

- **One problem per file**
- **One responsibility per class**
- No LINQ in early stages (explicit loops for clarity)
- No design patterns unless they add real value
- Code is written for **understanding first**, optimization later

---

## ✅ What Each Implementation Includes

- Clear C# implementation
- Explanation in comments
- Time complexity analysis
- Space complexity analysis
- Unit tests covering:
  - Normal cases
  - Edge cases
  - Boundary conditions

---

## 🧪 Testing

This project uses **xUnit** for testing.

Run all tests from the repository root:

```bash
dotnet test
```

---

## 🚧 Status

This is an **active learning repository**.

Topics are added incrementally in the following order:

1. Arrays
2. Strings
3. Hashing
4. Sorting
5. Two Pointers
6. (More to be added)

---

## 📌 Notes

- This repository is intentionally kept simple and focused.
- Advanced optimizations and abstractions may be added later
  once fundamentals are solid.
- The goal is **mastery**, not speed.

---

## 📜 License

This project is open-source and available for learning and reference purposes.
