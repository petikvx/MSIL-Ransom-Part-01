using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xHSli2ken;

namespace _0xH5ecade;

[ComImport]
[Guid("728AB32E-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
[TypeIdentifier]
public interface ICertProperty
{
	[DispId(1610743810)]
	CERTENROLL_PROPERTYID PropertyId
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743810)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743810)]
		[param: In]
		set;
	}

	[DispId(1610743812)]
	string RawData
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743812)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	void _VtblGap1_2();
}
