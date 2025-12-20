#region

using Dalamud.Plugin.Ipc;
using WrathCombo.API.Enum;

// ReSharper disable RedundantSuppressNullableWarningExpression
// ReSharper disable StaticMemberInitializerReferesToMemberBelow

#endregion

namespace WrathCombo.API.IPC.RawMethods;

public partial class RawMethod
{
    internal static readonly
        ICallGateSubscriber<object, object>
        GetAutoRotationConfigState =
            Interface!.GetIpcSubscriber<object, object>
                ($"{WC}GetAutoRotationConfigState");

    internal static readonly
        ICallGateSubscriber<Guid, object, object, SetResult>
        SetAutoRotationConfigState =
            Interface!.GetIpcSubscriber<Guid, object, object, SetResult>
                ($"{WC}SetAutoRotationConfigState");
}