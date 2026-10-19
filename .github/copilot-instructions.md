# GitHub Copilot Instructions for Caravan Cooler (Continued)

## Mod Overview and Purpose

**Mod Name**: Caravan Cooler (Continued)  
**Mod Author**: ToyWalrus (Updated by Mlie)  
**PackageId**: Mlie.CaravanCooler

The Caravan Cooler mod aims to enhance the caravan experience in RimWorld by providing a mobile refrigeration solution for perishable food items. While traditional coolers do not function during caravan trips, the Caravan Cooler fills this gap, ensuring food remains fresh over long journeys across the rim.

## Key Features and Systems

- **Mobile Refrigeration**: The Caravan Cooler acts as a portable refrigeration unit for caravans, keeping food items from spoiling during travels.
- **Crafting and Usage**: The Caravan Cooler is crafted at a machining table and must be loaded into caravans for functionality.
- **Unique Mechanics**: Though it functions differently from standard coolers, its effectiveness is showcased during caravan formation and travel.
- **User Feedback**: Positive user feedback highlights the practical utility and convenience provided by the Caravan Cooler in various gameplay scenarios.

## Coding Patterns and Conventions

- **Naming Conventions**: Use PascalCase for class and method names. 
- **Code Organization**: Locate related functionality in logically named classes and methods, e.g., `CaravanCooler`, `CaravanInfo`.
- **Modularity**: Design the mod with a focus on encapsulation, ensuring that components can be extended or modified with minimal disruption to existing systems.

## XML Integration

- **Defining Objects**: Use XML files to define research projects and items, such as `ResearchProjectDef` and `ThingDef`.
  - Example files: `CoolerResearchDef.xml` and `CoolerThingDef.xml`.
- **XML Patches**: Implement XML patches to alter game mechanics seamlessly without overwriting core game files. This mod includes patches like `ResearchTabPositioningPatch.xml`.

## Harmony Patching

Utilize Harmony, a powerful library for patching functions at runtime, to integrate the Caravan Cooler's functionality without altering the core game's source code.

- **Example Patches**:
  - `FormCaravan_PostClose.cs` for postfix methods to insert additional functionality after the caravan formation screen.
  - `Caravan_TickInterval.cs` for managing periodic updates to caravan status involving coolers.

## Suggestions for Copilot

When using GitHub Copilot to assist with development on the Caravan Cooler mod, consider the following suggestions:

1. **Understand RimWorld's API**: Familiarize yourself with the RimWorld modding API to leverage Copilot’s suggestions effectively.
2. **Leverage Harmony Documentation**: When creating patches, consult the Harmony documentation to ensure compatibility with RimWorld's changing internals.
3. **Code Completeness**: Use Copilot for generating boilerplate code, such as repetitive XML definitions or Harmony patch structures.
4. **Debugging and Testing**: Always test code suggestions in a controlled environment before deploying to ensure correctness and reliability.
5. **Maintainability**: Encourage maintainable, well-documented code to facilitate future updates or debugging.

By following these guidelines, developers can effectively utilize GitHub Copilot to enhance and extend the Caravan Cooler mod's functionality with minimal disruption.

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

