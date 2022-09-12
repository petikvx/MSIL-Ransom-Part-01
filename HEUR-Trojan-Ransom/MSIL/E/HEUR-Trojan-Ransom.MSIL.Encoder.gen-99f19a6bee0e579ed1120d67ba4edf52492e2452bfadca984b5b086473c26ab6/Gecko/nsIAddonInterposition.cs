using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d05cc5fd-ad88-41a6-854c-36fd94d69ddb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAddonInterposition
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal InterposeProperty(ref JsVal addonId, ref JsVal target, Guid iface, ref JsVal prop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal InterposeCall(ref JsVal addonId, ref JsVal originalFunc, ref JsVal originalThis, ref JsVal args);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetWhitelist();
}
