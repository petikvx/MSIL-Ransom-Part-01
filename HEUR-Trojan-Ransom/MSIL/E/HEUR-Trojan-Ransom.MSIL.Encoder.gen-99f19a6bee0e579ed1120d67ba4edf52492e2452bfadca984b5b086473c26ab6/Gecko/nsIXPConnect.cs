using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f339ea52-10ce-4103-b1f2-fd9659040e3c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPConnect
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPConnectJSObjectHolder InitClassesWithNewWrappedGlobal(IntPtr aJSContext, [MarshalAs(UnmanagedType.Interface)] nsISupports aCOMObj, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal aPrincipal, uint aFlags, IntPtr aOptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr WrapNative(IntPtr aJSContext, IntPtr aScope, [MarshalAs(UnmanagedType.Interface)] nsISupports aCOMObj, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPConnectJSObjectHolder WrapNativeHolder(IntPtr aJSContext, IntPtr aScope, [MarshalAs(UnmanagedType.Interface)] nsISupports aCOMObj, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WrapNativeToJSVal(IntPtr aJSContext, IntPtr aScope, [MarshalAs(UnmanagedType.Interface)] nsISupports aCOMObj, IntPtr aCache, Guid aIID, [MarshalAs(UnmanagedType.U1)] bool aAllowWrapper, ref MutableJSVal aVal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr WrapJS(IntPtr aJSContext, IntPtr aJSObj, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant JSValToVariant(IntPtr cx, ref JsVal aJSVal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPConnectWrappedNative GetWrappedNativeOfJSObject(IntPtr aJSContext, IntPtr aJSObj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetNativeOfWrapper(IntPtr aJSContext, IntPtr aJSObj);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetCurrentJSContext();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetSafeJSContext();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStackFrame GetCurrentJSStackAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetCurrentNativeCallContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugDump(short depth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugDumpObject([MarshalAs(UnmanagedType.Interface)] nsISupports aCOMObj, short depth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DebugDumpJSStack([MarshalAs(UnmanagedType.U1)] bool showArgs, [MarshalAs(UnmanagedType.U1)] bool showLocals, [MarshalAs(UnmanagedType.U1)] bool showThisProps);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr WrapJSAggregatedToNative([MarshalAs(UnmanagedType.Interface)] nsISupports aOuter, IntPtr aJSContext, IntPtr aJSObj, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPConnectWrappedNative GetWrappedNativeOfNativeObject(IntPtr aJSContext, IntPtr aScope, [MarshalAs(UnmanagedType.Interface)] nsISupports aCOMObj, ref Guid aIID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFunctionThisTranslator(ref Guid aIID, [MarshalAs(UnmanagedType.Interface)] nsIXPCFunctionThisTranslator aTranslator);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetWrappedNativePrototype(IntPtr aJSContext, IntPtr aScope, [MarshalAs(UnmanagedType.Interface)] nsIClassInfo aClassInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal VariantToJS(IntPtr ctx, IntPtr scope, [MarshalAs(UnmanagedType.Interface)] nsIVariant value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant JSToVariant(IntPtr ctx, ref JsVal value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr CreateSandbox(IntPtr cx, [MarshalAs(UnmanagedType.Interface)] nsIPrincipal principal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal EvalInSandboxObject([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase source, [MarshalAs(UnmanagedType.LPStr)] string filename, IntPtr cx, IntPtr sandbox, int version);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReportAllJSExceptions([MarshalAs(UnmanagedType.U1)] bool reportAllJSExceptions);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GarbageCollect(uint reason);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NotifyDidPaint();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteScript([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aStream, IntPtr aJSContext, IntPtr aJSScript);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr ReadScript([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aStream, IntPtr aJSContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void WriteFunction([MarshalAs(UnmanagedType.Interface)] nsIObjectOutputStream aStream, IntPtr aJSContext, IntPtr aJSObject);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr ReadFunction([MarshalAs(UnmanagedType.Interface)] nsIObjectInputStream aStream, IntPtr aJSContext);
}
