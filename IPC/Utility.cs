#region

using WrathCombo.API.IPC.RawMethods;

#endregion

namespace WrathCombo.API;

public static partial class WrathIPCWrapper
{
    public static bool CanWeave(float? estimatedWeaveTime = null) =>
        SafeInvokeRawMethod(() => RawMethod.CanWeave.InvokeFunc(estimatedWeaveTime));

    public static bool CanDelayedWeave(float? weaveStart, float? weaveEnd) =>
        SafeInvokeRawMethod(() =>
            RawMethod.CanDelayedWeave.InvokeFunc(weaveStart, weaveEnd));

    public static bool
        ActionReady(uint actionId, bool? recastCheck, bool? castCheck) =>
        SafeInvokeRawMethod(() =>
            RawMethod.ActionReady.InvokeFunc(actionId, recastCheck, castCheck));
}