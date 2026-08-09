# Specification — Context Engineering Track

## Goal
Produce a C# console program that adds two numbers, built by relying on
**context engineering**: a single, well-crafted prompt/context window that
contains all the instructions, examples, and constraints the model needs.
There is no persistent tooling, no test harness, no automated validation
loop — the "engineering" happens entirely in how the *context* (this one
prompt) is worded.

## Requirements
- Accept two numbers (hardcoded or via Console.ReadLine).
- Print their sum.
- Handle basic invalid input gracefully with a try/catch.

## How this spec is used
This file, along with `Architecture.md`, `Plan.md`, `constitution.md`, and
`Claude.md`, is pasted (or referenced) directly into the model's context in
one shot. The model reads all of it at once and produces the final code in
a single generation pass. If the output is wrong, the *fix* is to edit this
prompt/context and regenerate — there is no incremental, tool-verified
feedback loop.

## Non-goals
- No automated tests.
- No CI/build verification step.
- No iterative self-correction against real execution output.
