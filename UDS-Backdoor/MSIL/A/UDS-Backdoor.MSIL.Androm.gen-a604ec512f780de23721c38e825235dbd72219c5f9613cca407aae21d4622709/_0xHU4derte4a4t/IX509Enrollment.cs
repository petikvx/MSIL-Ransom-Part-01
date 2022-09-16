using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xHBebloo6e6;
using _0xHHousefro4t;
using _0xHR3d3mand;

namespace _0xHU4derte4a4t;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("728AB346-217D-11DA-B2A4-000E7BBB2B09")]
public interface IX509Enrollment
{
	[DispId(1610743825)]
	string CertificateFriendlyName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743825)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743825)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_2();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743810)]
	void InitializeFromRequest([In][MarshalAs(UnmanagedType.Interface)] IX509CertificateRequest pRequest);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743811)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string CreateRequest([In] EncodingType Encoding = EncodingType.XCN_CRYPT_STRING_BASE64);

	void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	void InstallResponse([In] InstallResponseRestrictionFlags Restrictions, [In][MarshalAs(UnmanagedType.BStr)] string strResponse, [In] EncodingType Encoding, [In][MarshalAs(UnmanagedType.BStr)] string strPassword);

	void _VtblGap3_11();
}
