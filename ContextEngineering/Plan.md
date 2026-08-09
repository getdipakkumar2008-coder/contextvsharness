# Plan — Context Engineering Track

## Process
1. Write one big prompt containing spec + architecture + constitution +
   examples of correct C# addition programs.
2. Send it to the model in a single turn.
3. Model emits `Program.cs` in one shot.
4. Human eyeballs the output. If wrong, human edits the *prompt* text and
   re-runs step 2. Repeat until it "looks right."

## Steps actually executed for this repo
- [x] Draft specification.md describing what "addition program" means.
- [x] Draft Architecture.md describing the expected shape.
- [x] Draft constitution.md describing the values that shaped the prompt.
- [x] Generate Program.cs directly from the combined context, no test run
      required before declaring it "done."
- [ ] No automated verification step exists in this track by design —
      that absence is the entire point of the comparison.

## Enhancement: subtraction feature
- [x] Update specification.md to require printing the difference as well
      as the sum.
- [x] Update Architecture.md's data-flow section to note the second
      inline computation.
- [x] Add the subtraction line directly into `Program.cs`'s `Main`, next
      to the existing addition line — no new file, no new layer, per this
      track's constitution.
- [ ] No test project added, by design — verified by manual run only.

## Enhancement: multiplication feature
- [x] Update specification.md to require printing the product as well.
- [x] Update Architecture.md's data-flow section to note the third
      inline computation.
- [x] Add the multiplication line directly into `Program.cs`'s `Main`,
      next to the existing addition/subtraction lines — no new file, no
      new layer, per this track's constitution.
- [ ] No test project added, by design — verified by manual run only.

## Feedback loop
```
Prompt (spec+arch+constitution) -> Model -> Code -> Human reads code -> (maybe) edit prompt -> repeat
```
Note there is no arrow from "run the code" back into the loop. Correctness
is judged by reading, not by execution evidence.
