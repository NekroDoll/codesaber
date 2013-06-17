CodeSaber - A hand-crafted tool for code exploration

C# only

Two varieties:
=====================================================================
1) CodeSaber.exe
- Microsoft (R) Roslyn-based basic C# REPL
  (shout out to @gblock for the inspiration)
- Scripts (no class/global type declaration required) or assemblies
- Gist persistence of scripts (save to / load from)
- Verry basic autocomplete

2) CodeSaber.Ice.exe
- csc.exe-based C# compiler
- Assembly-based only (due to csc.exe)
- Basic gist export

License: Apache License v2.0

Roadmap
  - Color/syntax highlighting for REPL?
  - Add script file save/import/execution support in REPL
  - Add file persistence in ICE
  - Add nuget support?
