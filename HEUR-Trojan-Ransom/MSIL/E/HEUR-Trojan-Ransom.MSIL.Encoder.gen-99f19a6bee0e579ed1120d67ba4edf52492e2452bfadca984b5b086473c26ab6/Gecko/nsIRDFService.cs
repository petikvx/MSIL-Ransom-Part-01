using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("BFD05261-834C-11d2-8EAC-00805F29F370")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetResource([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetUnicodeResource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetAnonymousResource();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFLiteral GetLiteral([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFDate GetDateLiteral(long aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFInt GetIntLiteral(int aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFBlob GetBlobLiteral(IntPtr aValue, int aLength);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAnonymousResource([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterResource([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource, [MarshalAs(UnmanagedType.U1)] bool aReplace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterResource([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RegisterDataSource([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.U1)] bool aReplace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void UnregisterDataSource([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFDataSource GetDataSource([MarshalAs(UnmanagedType.LPStr)] string aURI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFDataSource GetDataSourceBlocking([MarshalAs(UnmanagedType.LPStr)] string aURI);
}
