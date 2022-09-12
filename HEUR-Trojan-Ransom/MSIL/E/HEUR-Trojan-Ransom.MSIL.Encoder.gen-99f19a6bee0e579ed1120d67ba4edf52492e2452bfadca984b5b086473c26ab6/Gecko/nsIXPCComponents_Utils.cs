using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3ce3a6f8-2b59-439c-a57e-74e7b122fb3c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPCComponents_Utils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReportError(ref JsVal error, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPCComponents_utils_Sandbox GetSandboxAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal EvalInSandbox([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase source, ref JsVal sandbox, ref JsVal version, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase filename, int lineNo, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetSandboxAddonId(ref JsVal sandbox, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetSandboxMetadata(ref JsVal sandbox, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSandboxMetadata(ref JsVal sandbox, ref JsVal metadata, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal Import([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI, ref JsVal targetObj, IntPtr jsContext, int argc);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsModuleLoaded([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aResourceURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Unload([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase registryLocation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ImportGlobalProperties(ref JsVal aPropertyList, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	xpcIJSWeakReference GetWeakReference(ref JsVal obj, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceGC();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceCC([MarshalAs(UnmanagedType.Interface)] nsICycleCollectorListener aListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void FinishCC();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CcSlice(long budget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetMaxCCSliceTimeSinceClear();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ClearMaxCCTime();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceShrinkingGC();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SchedulePreciseGC(ScheduledGCCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SchedulePreciseShrinkingGC(ScheduledGCCallback callback);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnlinkGhostWindows();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetJSTestingFunctions(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal CallFunctionWithAsyncStack(ref JsVal function, [MarshalAs(UnmanagedType.Interface)] nsIStackFrame stack, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase asyncCause, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetGlobalForObject(ref JsVal obj, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsProxy(ref JsVal vobject, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal ExportFunction(ref JsVal vfunction, ref JsVal vscope, ref JsVal voptions, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal CreateObjectIn(ref JsVal vobj, ref JsVal voptions, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void MakeObjectPropsNormal(ref JsVal vobj, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsDeadWrapper(ref JsVal obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsCrossProcessWrapper(ref JsVal obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCrossProcessWrapperTag(ref JsVal obj, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RecomputeWrappers(ref JsVal vobj, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWantXrays(ref JsVal vscope, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForcePermissiveCOWs(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForcePrivilegedComponentsForScope(ref JsVal vscope, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetComponentsForScope(ref JsVal vscope, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Dispatch(ref JsVal runnable, ref JsVal scope, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStrictAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStrictAttribute([MarshalAs(UnmanagedType.U1)] bool aStrict, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWerrorAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWerrorAttribute([MarshalAs(UnmanagedType.U1)] bool aWerror, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStrict_modeAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStrict_modeAttribute([MarshalAs(UnmanagedType.U1)] bool aStrict_mode, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIonAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIonAttribute([MarshalAs(UnmanagedType.U1)] bool aIon, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetGCZeal(int zeal, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NukeSandbox(ref JsVal obj, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void BlockScriptForGlobal(ref JsVal global, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnblockScriptForGlobal(ref JsVal global, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsXrayWrapper(ref JsVal obj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal WaiveXrays(ref JsVal aVal, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal UnwaiveXrays(ref JsVal aVal, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.StringMarshaler")]
	string GetClassName(ref JsVal aObj, [MarshalAs(UnmanagedType.U1)] bool aUnwrap, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIClassInfo GetDOMClassInfo([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aClassName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetIncumbentGlobal(ref JsVal callback, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GenerateXPCWrappedJS(ref JsVal obj, ref JsVal scope, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetWatchdogTimestamp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aCategory);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetJSEngineTelemetryValue(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal CloneInto(ref JsVal value, ref JsVal scope, ref JsVal options, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetWebIDLCallerPrincipal();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrincipal GetObjectPrincipal(ref JsVal obj, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetCompartmentLocation(ref JsVal obj, IntPtr jsContext, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAddonInterposition([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase addonId, [MarshalAs(UnmanagedType.Interface)] nsIAddonInterposition interposition, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetAddonCallInterposition(ref JsVal target, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double Now();
}
