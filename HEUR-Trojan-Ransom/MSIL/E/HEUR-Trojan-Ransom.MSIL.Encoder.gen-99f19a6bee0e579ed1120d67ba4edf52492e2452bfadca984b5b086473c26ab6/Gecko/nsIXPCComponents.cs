using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("aa28aaf6-70ce-4b03-9514-afe43c7dfda8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPCComponents : nsIXPCComponentsBase
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIXPCComponents_Interfaces GetInterfacesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIXPCComponents_InterfacesByID GetInterfacesByIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new IntPtr GetResultsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool IsSuccessCode(int result);

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetClassesByIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStackFrame GetStackAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIComponentManager GetManagerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIXPCComponents_Utils GetUtilsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetExceptionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetConstructorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetLastResultAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetReturnCodeAttribute(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReturnCodeAttribute(JsVal aReturnCode, IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ReportError(ref JsVal error, IntPtr jsContext);
}
