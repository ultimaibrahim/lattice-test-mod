# Lattice Test Mod

A do-nothing mod used to test [Lattice](https://github.com/ultimaibrahim/lattice)'s verifier and publishing flow. It is not a real Block Story mod.

- **What it does:** nothing. It only carries the metadata Lattice reads (id, name, version, author).
- **Install:** you should not; it has no effect in the game.
- **Remove:** delete `LatticeTestMod.dll` from your mods folder if you did.
- **Build:** `dotnet build -c Release`. The release workflow builds the zip in GitHub Actions and attaches a build attestation.

MIT licensed. No game files, no decompiled code.
