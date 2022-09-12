using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("97e0c418-1c1e-4106-bad1-9fcb11dff2fe")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransferable
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsILoadContext aContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray FlavorsTransferableCanExport();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetTransferData([MarshalAs(UnmanagedType.LPStr)] string aFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aData, ref uint aDataLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAnyTransferData([MarshalAs(UnmanagedType.LPStr)] ref string aFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aData, ref uint aDataLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsLargeDataSet();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupportsArray FlavorsTransferableCanImport();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTransferData([MarshalAs(UnmanagedType.LPStr)] string aFlavor, [MarshalAs(UnmanagedType.Interface)] nsISupports aData, uint aDataLen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddDataFlavor([MarshalAs(UnmanagedType.LPStr)] string aDataFlavor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveDataFlavor([MarshalAs(UnmanagedType.LPStr)] string aDataFlavor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFormatConverter GetConverterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetConverterAttribute([MarshalAs(UnmanagedType.Interface)] nsIFormatConverter aConverter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsPrivateDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsPrivateDataAttribute([MarshalAs(UnmanagedType.U1)] bool aIsPrivateData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetRequestingNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetRequestingNodeAttribute([MarshalAs(UnmanagedType.Interface)] nsIDOMNode aRequestingNode);
}
