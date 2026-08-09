# Claude.md — Harness Engineering Track

## Role
You (Claude Code) are acting as an **agentic harness operator**: you have
Read/Write/Edit/Bash tools, and you are expected to use them to build,
run, and verify this project — not just generate text once.

## Rules for this track
- After writing or changing `Calculator.cs`, `Program.cs`, or any test
  file, run `dotnet build` on both the app and test projects.
- Run `dotnet test` and read the actual output. A green run is the only
  acceptable definition of "done" for this track.
- If a build or test fails, read the specific error, fix the specific
  cause, and re-run — do not guess-and-restate.
- Do not mark this track complete based on code review alone; execution
  evidence (`dotnet test` output) is required.
- Keep `Calculator` free of Console I/O so it stays unit-testable.
- If new enchancement is required in the future do not go to source code try using only 
  .md files amd update the existing .md files before making  any code  changes.
-  Make logging of every new prompt amd background  task and always update log.md

## What "engineering" means here
Effort goes into the *process*: project layout that supports automated
verification, a real test suite, and a build/test/fix loop that the
harness drives itself. The prompt/context still matters, but it is only
the starting contract — the harness's tool use is what actually proves
the contract is met.
