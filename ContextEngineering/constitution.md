# Constitution — Context Engineering Track

These are the values baked into the *prompt itself* (not into any external
tool) for this track:

1. **Clarity of instruction over structure of process.** The quality of
   the result depends on how precisely this document set is worded.
2. **Single-pass trust.** The model's one-shot output, given a good enough
   context, is treated as sufficient — no external re-check is required
   by the process.
3. **Human-in-the-loop-by-reading.** Verification means a human reads the
   generated code and the docs side by side, not that a machine ran it.
4. **Minimalism.** Do not ask the model to build test scaffolding, CI, or
   validation tooling — that would turn this into the Harness Engineering
   track.
5. **Context is the unit of engineering.** Improving results means
   improving the wording/organization of specification.md, Architecture.md,
   Plan.md, and this file — not building infrastructure around the model.
