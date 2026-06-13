# IL2CppSharp.Hooking.BepInEx

BepInEx logging adapter for `IL2CppSharp.Hooking`.

## Role

- Bridges `BepInEx.Logging.ManualLogSource` to `IHookLogger`.
- Keeps the core hook engine independent from BepInEx.
- Provides the integration point BepInEx IL2CPP plugins should reference.

## Depends on

- `IL2CppSharp.Hooking`
- `BepInEx.Core`

## Usage

```csharp
using IL2CppSharp.Hooking;
using IL2CppSharp.Hooking.BepInEx;

HookEngine.Initialize(new BepInExHookLogger(Logger));
```

## Public build notes

- This is a standalone adapter library, not a BepInEx plugin by itself.
- By default, it uses package references for `IL2CppSharp.Hooking` and `BepInEx.Core`.
- If the dependent libraries have not been published as packages yet, copy `Directory.Build.props.example` to `Directory.Build.props` and point the project properties at local checkouts.

## Build

```bash
dotnet build -c Release /p:GeneratePackageOnBuild=false
```

## License

MIT. See [LICENSE](LICENSE).
