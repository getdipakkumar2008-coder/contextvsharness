# Architecture — Harness Engineering Track

## Shape of the solution
Two projects, deliberately separated so the harness has something concrete
to build and test independently of "does the whole console app look ok":

```
HarnessEngineering/
  HarnessEngineeringAdd/
    src/
      HarnessEngineeringAdd.csproj
      Calculator.cs        <- pure logic, no I/O
      Program.cs            <- thin console adapter
    tests/
      HarnessEngineeringAdd.Tests.csproj
      CalculatorTests.cs    <- xUnit tests, run by the harness
```

## Why it looks like this
Harness engineering optimizes the *process/tooling* around the model, not
just the prompt text:

- **Separation of concerns** — `Calculator` (logic) is isolated from
  `Program` (I/O) specifically so it can be unit-tested without stdin
  mocking.
- **Executable ground truth** — the test project is not documentation, it
  is a machine-checked contract. The harness runs `dotnet build` and
  `dotnet test` and treats non-zero exit codes as failure signals it must
  act on, not something a human discovers later.
- **Loop-friendly layout** — because logic and tests are separate
  projects, the harness can re-run `dotnet test` after every edit and get
  a fast, unambiguous pass/fail signal to drive the next iteration.

## Data flow
```
Program.cs -> Console.ReadLine (x2) -> Calculator.Add(a, b)      -> Console.WriteLine
                                     -> Calculator.Subtract(a, b) -> Console.WriteLine
                                     -> Calculator.Multiply(a, b) -> Console.WriteLine
                                              ^
                                              |
CalculatorTests.cs ---- dotnet test ---------+   (harness-verified, independent of console I/O)
```

`Subtract` and `Multiply` are added to the same `Calculator` class as
`Add` (all pure, no I/O), and `CalculatorTests.cs` gains an equivalent
set of `[Theory]` cases for each so they stay covered by the same
build/test loop.
