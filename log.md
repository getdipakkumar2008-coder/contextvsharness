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

---

## Prompt

> Need to add substraction functionality feature of two numbers.

## Background work performed

Note: both `Claude.md` files were updated (by the user) before this
prompt to add two standing rules: (1) future enhancements must update the
`.md` docs first, before touching source code, and (2) every new prompt
and its background work must be logged here in `log.md`. This entry
follows both rules.

1. Updated docs first, per the new `Claude.md` rule, in both tracks:
   - `ContextEngineering/specification.md` — added a requirement to
     print the difference alongside the sum.
   - `ContextEngineering/Architecture.md` — extended the data-flow
     diagram with the `a - b` step; noted it's added inline, same as
     addition, since this track has no separate logic layer.
   - `ContextEngineering/Plan.md` — added an "Enhancement: subtraction
     feature" section with its own checklist.
   - `HarnessEngineering/specification.md` — added `Calculator.Subtract`
     and its required test coverage to the requirements.
   - `HarnessEngineering/Architecture.md` — extended the data-flow
     diagram and noted `Subtract` lives on the same `Calculator` class.
   - `HarnessEngineering/Plan.md` — added an "Enhancement: subtraction
     feature" checklist ending in a build/test verification step.

2. Implemented the feature to match the updated docs:
   - `ContextEngineering/ContextEngineeringAdd/Program.cs` — added
     `double difference = a - b;` and a second `Console.WriteLine` next
     to the existing addition line (still one file, no new layer).
   - `HarnessEngineering/HarnessEngineeringAdd/src/Calculator.cs` —
     added `public double Subtract(double a, double b) => a - b;`.
   - `HarnessEngineering/HarnessEngineeringAdd/src/Program.cs` — wired
     `calculator.Subtract(a, b)` alongside `Add` and printed the result.
   - `HarnessEngineering/HarnessEngineeringAdd/tests/CalculatorTests.cs`
     — added a `Subtract_ReturnsExpectedDifference` `[Theory]` with 5
     cases (positive, negative, mixed sign, zero, decimal).

3. Verified per each track's own definition of "done":
   - `dotnet test HarnessEngineering/HarnessEngineeringAdd/tests/HarnessEngineeringAdd.Tests.csproj`
     → **Passed! 10/10** (5 original `Add` cases + 5 new `Subtract`
     cases), confirming the Harness Engineering track's build/test gate
     was actually satisfied before calling this done.
   - `dotnet run` on `ContextEngineeringAdd.csproj` with piped input `9`
     and `4` → printed `Result: 9 + 4 = 13` and `Result: 9 - 4 = 5`,
     confirming the Context Engineering program works via manual run
     (still no automated test, by design of that track).

---

## Prompt

> Let us add two number multiplication functionality feature.

## Background work performed

1. Updated docs first, per the standing `Claude.md` rule, in both tracks:
   - `ContextEngineering/specification.md` — added a requirement to
     print the product alongside the sum and difference.
   - `ContextEngineering/Architecture.md` — extended the data-flow
     diagram with the `a * b` step, noting it's inline like the rest.
   - `ContextEngineering/Plan.md` — added an "Enhancement: multiplication
     feature" checklist.
   - `HarnessEngineering/specification.md` — added `Calculator.Multiply`
     and its required test coverage.
   - `HarnessEngineering/Architecture.md` — extended the data-flow
     diagram; noted `Multiply` lives on the same `Calculator` class.
   - `HarnessEngineering/Plan.md` — added an "Enhancement: multiplication
     feature" checklist ending in a build/test verification step.

2. Implemented the feature to match the updated docs:
   - `ContextEngineering/ContextEngineeringAdd/Program.cs` — added
     `double product = a * b;` and a third `Console.WriteLine`.
   - `HarnessEngineering/HarnessEngineeringAdd/src/Calculator.cs` —
     added `public double Multiply(double a, double b) => a * b;`.
   - `HarnessEngineering/HarnessEngineeringAdd/src/Program.cs` — wired
     `calculator.Multiply(a, b)` alongside `Add`/`Subtract`.
   - `HarnessEngineering/HarnessEngineeringAdd/tests/CalculatorTests.cs`
     — added a `Multiply_ReturnsExpectedProduct` `[Theory]` with 5 cases
     (positive, mixed sign, negative pair, zero, decimal).

3. Verified per each track's own definition of "done":
   - `dotnet test HarnessEngineering/HarnessEngineeringAdd/tests/HarnessEngineeringAdd.Tests.csproj`
     → **Passed! 15/15** (10 prior + 5 new `Multiply` cases).
   - `dotnet run` on `ContextEngineeringAdd.csproj` with piped input `6`
     and `7` → printed `Result: 6 + 7 = 13`, `Result: 6 - 7 = -1`,
     `Result: 6 * 7 = 42`, confirming correctness via manual run.

## Outcome

Subtraction is now implemented identically in spirit across both tracks
(same `a - b` operation, same output format) but the *process* to get
there stayed different: Context Engineering added the line straight into
`Main` and was judged by a manual run; Harness Engineering added a method
to the testable `Calculator` class and was judged by `dotnet test`
passing 10/10. The doc sets were updated before any code changed, per
each track's updated `Claude.md` rules.

---

## Prompt

> Let us add two number multiplication functionality feature. (repeated)

## Background work performed

Checked current state instead of redoing work: `Calculator.Multiply`,
`Program.cs` wiring, and `Program.cs` inline `a * b` in the Context
Engineering track were all already present from the prior turn (`dotnet
test` still 15/15). No changes made — reported existing state back to the
user and asked whether something different was intended (e.g. division).

---

## Prompt

> after adding speckkit and dotnetskill it does not make any difference in
> implementation?

## Background work performed

1. Investigated why `speckit` (`.github/agents/*.agent.md`,
   `.github/prompts/*.prompt.md`) and `DotnetSkills`
   (`DotnetSkills/skills/*.md`) had no observable effect on my behavior.
2. Found the root cause: neither location is scanned by Claude Code.
   Skills are only auto-loaded from `.claude/skills/<name>/SKILL.md`
   (project or user level) — there was no `.claude` directory in this
   repo at all. `speckit` is GitHub Copilot's Spec Kit format (a
   different tool entirely); `DotnetSkills` already had correct
   Claude-Code-style frontmatter but was sitting in a vendored, unscanned
   folder.
3. Asked the user how to proceed; they chose to integrate `DotnetSkills`
   into Claude Code (leaving `speckit` alone, since it targets Copilot).
4. Copied the four vendored skill files into proper skill folders so
   Claude Code will discover them:
   - `.claude/skills/run-tests/SKILL.md`
   - `.claude/skills/assertion-quality/SKILL.md`
   - `.claude/skills/directory-build-organization/SKILL.md`
   - `.claude/skills/setup-local-sdk/SKILL.md`
5. Updated `HarnessEngineering/Claude.md` to point at the new skills —
   prefer the `run-tests` skill's detected command form over ad hoc
   `dotnet test` calls, and use `assertion-quality` when asked to judge
   `CalculatorTests.cs` assertion quality.

## Outcome

`speckit` remains inert by design (it's Copilot-specific tooling, not
something Claude Code loads). `DotnetSkills` is now registered under
`.claude/skills/` and referenced from `HarnessEngineering/Claude.md`; it
will be picked up as invocable skills starting from the next fresh
session (this session's skill list was already fetched at start, before
the files existed in the scanned location).
