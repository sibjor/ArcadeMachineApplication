# ArcadeMachineApplication
 Navigates between and executes games presented at Forsbergs Christmas Market 2024

## Stack
* WPF (xaml and csharp)
* Packages like: wpggif, wpfjson

## Diagram of system structure:
```mermaid
  graph TD;
      A[Game Submodule 1]-->B[LauncherRepo];
      C[Game Submodule 2]-->B[LauncherRepo];
```

## How it works:
* The authors give access to their binary repo (with a structure described later), so a submodule of it can be added to this repo
* The launcher presents the games made by the authors, navigating between the submodule directories

## Binary repo structure:
* The build folder created your engine of choice
* With a .gif file representing your game
* With a metadata.json file with filled values, the keys defined by this project however

