# GitHub Copilot Instructions for "Just Ignore Me Passing (Continued)"

## Mod Overview and Purpose
The "Just Ignore Me Passing (Continued)" mod is a continuation of Andreas Pardeike's original "Just Ignore Me Passing" mod for RimWorld. The primary purpose of this mod is to improve the construction workflow within the game by ensuring that construction tasks are not interrupted by pawns passing through blueprints or unfinished structures. This small enhancement provides a smoother and more realistic construction experience, enhancing overall gameplay.

## Key Features and Systems
- **Seamless Construction**: Pawns can pass through blueprints and unfinished structures without interrupting ongoing construction tasks.
- **Player Experience**: Enhances the quality of life for players by eliminating unnecessary interruptions, making large construction projects easier to manage.

## Coding Patterns and Conventions
- **C# Conventions**: Follow standard C# coding conventions, including meaningful naming of classes, methods, and variables.
- **Class Definitions**: Class names should be descriptive of their function. For instance, `GenConstruct_BlocksConstruction` clearly indicates its role in the construction process.
- **Methods**: Use `Prefix` methods for Harmony patches where applicable to ensure backward compatibility and maximum efficiency.

## XML Integration
- **About.xml**: This file includes the mod's metadata. Ensure it accurately reflects the mod name, author, and dependencies.
- **Manifest.xml**: Details the package structure and any external dependencies, such as `brrainz.harmony`.

## Harmony Patching
- **Introduction**: Utilize Harmony for non-destructive method patching to modify RimWorld's existing methods without changing their source code.
- **Example Usage**:
  - In `GenConstruct_BlocksConstruction.cs`, the `Prefix` function is likely used to intercept and modify the original game logic concerning construction interruption.
- **Best Practices**: Ensure that Harmony patches are robust, efficient, and do not introduce new bugs or performance issues.

## Suggestions for Copilot
- **Auto-completion**: Encourage the use of Copilot to automatically complete repetitive coding tasks such as property definitions, method stubs, and documentation comments.
- **Template Use**: Leverage Copilot's ability to create templates for frequently used code structures, such as class definitions and Harmony patches.
- **Error Handling**: Utilize Copilot for writing consistent error handling patterns to maintain code reliability.

## Developer Tips
- **Testing**: Always test your changes with only this mod enabled before combining it with others. This helps isolate any issues introduced by the mod itself.
- **Version Control**: Use version control effectively to manage changes and collaborate with other developers on GitHub or through Discord as mentioned.
- **Community Support**: Engage with the community via Discord for problem-solving and feedback. Avoid creating discussion threads for error reporting as notifications are not sent.

By adhering to these guidelines and utilizing tools like GitHub Copilot effectively, you can maintain and enhance the "Just Ignore Me Passing (Continued)" mod, ensuring it delivers a high-quality experience for RimWorld players.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

