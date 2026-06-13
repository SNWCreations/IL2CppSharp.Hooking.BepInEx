using System;
using BepInEx.Logging;

namespace IL2CppSharp.Hooking.BepInEx;

/// <summary>
/// Adapts a BepInEx ManualLogSource to the core runtime hook logger abstraction.
/// </summary>
public sealed class BepInExHookLogger(ManualLogSource log) : IHookLogger
{
    private readonly ManualLogSource _log = log ?? throw new ArgumentNullException(nameof(log));

    public void Debug(string message) => _log.LogDebug(message);

    public void Info(string message) => _log.LogInfo(message);

    public void Warning(string message) => _log.LogWarning(message);

    public void Error(string message) => _log.LogError(message);
}
