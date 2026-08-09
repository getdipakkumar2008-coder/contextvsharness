# contextvsharness

This repository compares complementary ways of working with AI coding agents: **context/spec-driven workflows** and **harness-driven workflows**.

## Tracks

- **`HarnessEngineering/`**  
  Demonstrates harness engineering around a .NET solution (`HarnessEngineeringAdd`) where build/test loop signals steer the agent process.

- **`SpecKit/`**  
  Adds GitHub Spec Kit scaffolding (`.specify/`, Copilot slash-command assets) to drive work from specs (`specify -> plan -> tasks -> implement`) instead of ad-hoc prompting.

- **`DotnetSkills/`**  
  Vendors selected reusable .NET-focused agent skills from `dotnet/skills` to improve project structure, build, and testing guidance during Copilot sessions.

For harness architecture details, see `HarnessEngineering/Architecture.md`.
