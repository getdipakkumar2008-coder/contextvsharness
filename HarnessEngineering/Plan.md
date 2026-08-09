# Plan — Harness Engineering Track

## Process
1. Write specification.md (contract: what must be true) and Architecture.md
   (shape: how the code is organized to make that contract testable).
2. Harness (Claude Code) creates `Calculator.cs`, `Program.cs`, and a test
   project with real assertions.
3. Harness runs `dotnet build` on both projects.
4. Harness runs `dotnet test` on the test project.
5. If a build or test fails, the harness reads the actual compiler/test
   output (not a guess) and edits the code to fix it.
6. Repeat steps 3-5 until the build is green and all tests pass.
7. Only then is the task considered complete.

## Steps actually executed for this repo
- [x] Draft specification.md with an explicit, testable contract.
- [x] Draft Architecture.md separating logic from I/O for testability.
- [x] Create `Calculator.cs` with `Add(double, double)`.
- [x] Create `Program.cs` as a thin console wrapper around `Calculator`.
- [x] Create `CalculatorTests.cs` with multiple xUnit test cases.
- [ ] Run `dotnet build` and `dotnet test` (execute this after project
      generation, per this plan) and iterate on any failures.

## Feedback loop
```
Spec + Architecture -> Code + Tests -> dotnet build/test -> read real output
        ^                                                         |
        +---------------------- fix code, re-run ------------------+
```
The loop closes on *execution evidence* (compiler errors, test results),
not on a human's read-through or the model's self-assessment.
