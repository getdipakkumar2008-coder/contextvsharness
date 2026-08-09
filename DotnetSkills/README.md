# DotnetSkills Track

This track vendors a **targeted subset** of reusable Agent Skills from [`dotnet/skills`](https://github.com/dotnet/skills) relevant to this repo's small .NET console + library + xUnit workflow.

## Vendored skills

- `skills/setup-local-sdk.md`
  - Source plugin: `plugins/dotnet`
  - Purpose: local SDK setup guidance for reproducible environments
- `skills/run-tests.md`
  - Source plugin: `plugins/dotnet-test`
  - Purpose: reliable `dotnet test` command selection and filtering guidance
- `skills/assertion-quality.md`
  - Source plugin: `plugins/dotnet-test`
  - Purpose: evaluating test assertion depth/quality in existing test suites
- `skills/directory-build-organization.md`
  - Source plugin: `plugins/dotnet-msbuild`
  - Purpose: project/build structure guidance with `Directory.Build.*` conventions

Each vendored file includes a source attribution line linking to its original `dotnet/skills` path.

## Why these were selected

These skills match this repository's current .NET needs:

- project/build structure practices
- running tests correctly and consistently
- maintaining useful test quality standards
- keeping SDK/tooling setup reproducible for contributors

## How to use with Copilot in this repo

Use these files as reference context in prompts (for example, ask Copilot to follow `DotnetSkills/skills/run-tests.md` when proposing test commands). Depending on your Copilot/agent setup, these can also be incorporated into agent workflows as reusable skill guidance.
