using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0c0a862c-1a47-43c0-ae9e-d51835e3e1a6")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMozBrowserFrame : nsIDOMMozBrowserFrame
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetMozbrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetMozbrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aMozbrowser);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReallyIsBrowserOrAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReallyIsAppAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReallyIsWidgetAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsExpectingSystemMessageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAppManifestURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAppManifestURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DisallowCreateFrameLoader();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AllowCreateFrameLoader();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateRemoteFrameLoader([MarshalAs(UnmanagedType.Interface)] nsITabParent aTabParent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitializeBrowserAPI();
}
