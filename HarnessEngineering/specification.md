# Specification — Harness Engineering Track

## Goal
Produce a C# console program that adds two numbers, built by relying on
**harness engineering**: a repeatable, tool-driven process where the agent
(Claude Code) has file access, a compiler, and a test runner, and is
expected to *verify* its own work by actually building and running tests
— not just by reasoning over a prompt.

## Requirements
- A `Calculator` class exposing `Add(double a, double b) -> double`,
  independently testable without any console I/O.
- A `Calculator` class also exposing `Subtract(double a, double b) -> double`
  (returns `a - b`), independently testable without any console I/O.
- A thin `Program.cs` entry point that wires `Calculator` to the console
  and prints both the sum and the difference.
- A companion xUnit test project (`HarnessEngineeringAdd.Tests`) that
  exercises `Calculator.Add` with multiple cases (positive, negative,
  zero, decimals) and `Calculator.Subtract` with the equivalent cases.
- The definition of "done" is: **`dotnet test` passes**, not "the docs
  read well" or "the code looks plausible."

## How this spec is used
This file is one input among several that the harness (Claude Code, with
Read/Write/Bash/Edit tools) consumes across a multi-step, tool-verified
loop: write code -> build -> run tests -> read failures -> fix -> re-run.
The spec constrains *what* must be true; the harness enforces *that* it is
actually true via execution, not narrative.

## Non-goals
- Trusting a single-shot generation without running it.
- Treating "the model said it works" as evidence.
