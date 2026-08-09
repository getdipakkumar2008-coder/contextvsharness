# SpecKit Track

This repository now includes GitHub Spec Kit scaffolding for **spec-driven development (SDD)** alongside the existing harness-driven workflow.

## What was added

- `.specify/` project scaffolding (memory, templates, scripts, workflows)
- Copilot command + prompt files under:
  - `.github/agents/speckit.*.agent.md`
  - `.github/prompts/speckit.*.prompt.md`
- `.vscode/settings.json` recommendations installed by Spec Kit

These files were initialized from `github/spec-kit` (Copilot integration in commands mode), equivalent to running:

```bash
specify init --here --force --integration copilot --integration-options "--commands"
```

## Why this exists in this repo

- `HarnessEngineering/` demonstrates a **harness engineering** approach (build/test loop signals driving the agent process).
- This Spec Kit track demonstrates **spec-driven development** where spec artifacts (`spec.md`, `plan.md`, `tasks.md`) drive the agent loop.

See `/HarnessEngineering/Architecture.md` for the harness side of the comparison.

## How to use with GitHub Copilot

Typical flow in Copilot Chat:

1. `/speckit.constitution`
2. `/speckit.specify`
3. `/speckit.plan`
4. `/speckit.tasks`
5. `/speckit.implement`

Optional quality commands include `/speckit.clarify`, `/speckit.checklist`, `/speckit.analyze`, and `/speckit.converge`.

Core templates live in `.specify/templates/`, and helper scripts are under `.specify/scripts/bash/`.
