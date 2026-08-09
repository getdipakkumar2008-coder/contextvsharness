# Constitution — Harness Engineering Track

These are the values baked into the *process/tooling* (not just the
prompt) for this track:

1. **Trust execution, not narration.** A claim of correctness is only
   valid once `dotnet build` and `dotnet test` actually pass. Reading code
   and believing it is not sufficient.
2. **Testability drives structure.** Logic (`Calculator`) is separated
   from I/O (`Program`) specifically so it can be verified in isolation —
   architecture serves the harness's ability to check its own work.
3. **Iterate on real signal.** When something fails, the harness reads the
   actual compiler/test error text and fixes the root cause, rather than
   rewording a prompt and hoping for a different one-shot output.
4. **The harness owns verification, not the human.** The human defines
   the contract (spec) and reviews the result, but the pass/fail gate
   during development is automated (build + test), not manual read-through.
5. **Repeatability.** The same process (build, test, fix, repeat) applies
   to any future change to this codebase — it is not a one-off ritual tied
   to a single clever prompt.
