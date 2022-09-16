using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xHR3d3mand;
using _0xHSa66atic;

namespace _0xHScru4ineer;

[ComImport]
[TypeIdentifier]
[CompilerGenerated]
[Guid("728AB32F-217D-11DA-B2A4-000E7BBB2B09")]
public interface ICertProperties : IEnumerable
{
	[IndexerName("ItemByIndex")]
	[DispId(0)]
	CCertProperty this[[In] int Index]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(1)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		get;
	}

	void _VtblGap1_4();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743814)]
	void InitializeFromCertificate([In] bool MachineContext, [In] EncodingType Encoding, [In][MarshalAs(UnmanagedType.BStr)] string strCertificate);
}
