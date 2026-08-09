# Architecture — Context Engineering Track

## Shape of the solution
A single flat console project, `ContextEngineeringAdd`, with one file:
`Program.cs`. All logic — input, computation, output, error handling —
lives inline in `Main`.

```
ContextEngineering/
  ContextEngineeringAdd/
    ContextEngineeringAdd.csproj
    Program.cs
```

## Why it looks like this
Context engineering optimizes the *prompt* the model sees, not the
*process* the model operates under. Because there is no harness re-running
the code, checking outputs, or feeding errors back automatically, the
resulting architecture tends to be:

- **Monolithic** — no incentive to split responsibilities because nothing
  external (a test runner, a linter, a CI gate) rewards separation.
- **Un-versioned against reality** — the "correctness" of the code is
  whatever the model believed while reading the context; it is not
  verified by actually running it as part of the generation process.
- **Prompt-fragile** — if the spec text is reworded, the resulting
  architecture can change unpredictably, since structure is an emergent
  side-effect of wording, not an enforced constraint.

## Data flow
```
Console.ReadLine (x2) -> double.Parse -> a + b -> Console.WriteLine
                                       -> a - b -> Console.WriteLine
                                       -> a * b -> Console.WriteLine
```
No layers, no interfaces, no dependency injection — everything is direct.
Subtraction and multiplication are added inline in `Main`, the same way
addition is, since this track has no separate logic layer to extend.
