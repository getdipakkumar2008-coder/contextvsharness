# Work Log

## Prompt

> write a addition of two number using c# .1st program should this work by
> doing using context engineeering and same program should develope using
> Harness engineering. Give me two list of document having
> "specification.md ,Architecture.md ,Plan.md and Claude.md ,
> constitution.md" create these document i can really understand the real
> diffrence in context and Harness Engineering. Also Create a two project
> in same solution to do this code comparsion.

## Background work performed

1. Created solution folder structure under `C:\Code\Harnessvscontext`:
   - `ContextEngineering/ContextEngineeringAdd/`
   - `HarnessEngineering/HarnessEngineeringAdd/src/`
   - `HarnessEngineering/HarnessEngineeringAdd/tests/`

2. Wrote the **Context Engineering** doc set (prompt-driven, no
   tool-verified loop):
   - `ContextEngineering/specification.md`
   - `ContextEngineering/Architecture.md`
   - `ContextEngineering/Plan.md`
   - `ContextEngineering/constitution.md`
   - `ContextEngineering/Claude.md`

3. Wrote the **Harness Engineering** doc set (tool-verified build/test
   loop):
   - `HarnessEngineering/specification.md`
   - `HarnessEngineering/Architecture.md`
   - `HarnessEngineering/Plan.md`
   - `HarnessEngineering/constitution.md`
   - `HarnessEngineering/Claude.md`

4. Built the **Context Engineering** program: a single monolithic
   `Program.cs` in `ContextEngineeringAdd.csproj` — reads two numbers,
   prints the sum, no separate logic layer, no test project.

5. Built the **Harness Engineering** program, split for testability:
   - `Calculator.cs` — pure `Add(double, double)` logic, no I/O.
   - `Program.cs` — thin console adapter calling `Calculator`.
   - `HarnessEngineeringAdd.Tests` — xUnit project with 5 `[Theory]`
     cases (positive, negative, zero, mixed sign, decimal).

6. Created `HarnessVsContext.slnx` and added all three projects
   (`ContextEngineeringAdd`, `HarnessEngineeringAdd` src, and its test
   project) to the single solution.

7. Verified the difference in process, not just talk about it:
   - `dotnet build HarnessVsContext.slnx` → Build succeeded, 0 errors.
   - `dotnet test HarnessEngineering/HarnessEngineeringAdd/tests/HarnessEngineeringAdd.Tests.csproj`
     → **Passed! 5/5**, confirming the Harness Engineering track's
     "done means dotnet test is green" rule was actually satisfied.
   - `dotnet run` on `ContextEngineeringAdd.csproj` with piped input
     `4` and `7` → printed `Result: 4 + 7 = 11`, confirming the
     Context Engineering program works when read/run manually (no
     automated test backs this claim, by design of that track).

## Outcome

Both tracks solve the same problem (add two numbers in C#) but the doc
sets and code structure make the difference tangible:

| | Context Engineering | Harness Engineering |
|---|---|---|
| Unit of engineering | Prompt wording | Build/test process |
| Verification | Human reads code | `dotnet test` (5/5 passed) |
| Code shape | One file, monolithic | Logic/I/O split, testable |
| Feedback loop | Edit prompt, regenerate | Read real errors, fix, re-run |
