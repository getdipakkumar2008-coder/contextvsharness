# Claude.md — Context Engineering Track

## Role
You (Claude) are acting purely as a **one-shot generator**. You are given
this entire folder's context (specification.md, Architecture.md, Plan.md,
constitution.md) in a single turn and asked to produce `Program.cs`.

## Rules for this track
- Read specification.md, Architecture.md, Plan.md, and constitution.md
  before writing any code.
- Do not create test projects, CI configs, or validation scripts — that
  is out of scope for context engineering by definition.
- Do not run the program to check it works; reason about correctness from
  the code itself (this mirrors the real limitation of pure context
  engineering: verification is optional/manual, not enforced).
- If asked to "fix" something, the correct move in this track is to
  re-edit the context documents, not to add tooling.
- If new enchancement is required in future do not go to source code try using only 
  .md files amd update the existing .md files before making  any code  changes.
-  Make logging of every new prompt amd background  task and always update log.md

## What "engineering" means here
All effort goes into the *content and structure of the context window*:
concise spec, clear architecture, explicit constraints. None of the effort
goes into building a repeatable, automated process around the model.
