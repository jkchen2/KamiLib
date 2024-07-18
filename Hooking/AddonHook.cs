using System;
using Dalamud.Hooking;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace KamiLib.Hooking;
/* TODO: FIX (0 references)
public static unsafe class AddonHook
{
    public static Hook<T> Hook<T>(nint addon, uint vFuncIndex, T function) where T : Delegate => Service.GameInteropProvider.HookFromAddress(new nint(((AtkUnitBase*)addon)->AtkEventListener.vfunc[vFuncIndex]), function);
    public static Hook<T> Hook<T>(void* addon, uint vFuncIndex, T function) where T : Delegate => Service.GameInteropProvider.HookFromAddress(new nint(((AtkUnitBase*)addon)->AtkEventListener.vfunc[vFuncIndex]), function);
}
*/
