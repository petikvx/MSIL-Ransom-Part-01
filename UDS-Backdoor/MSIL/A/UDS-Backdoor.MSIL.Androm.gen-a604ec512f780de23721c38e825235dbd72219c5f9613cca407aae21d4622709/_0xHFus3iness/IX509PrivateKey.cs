using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xH6ivisive;
using _0xHAi1wo1thie1;

namespace _0xHFus3iness;

[ComImport]
[TypeIdentifier]
[Guid("728AB30C-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
public interface IX509PrivateKey
{
	[DispId(1610743830)]
	bool LegacyCsp
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743830)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743830)]
		[param: In]
		set;
	}

	[DispId(1610743834)]
	X509KeySpec KeySpec
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743834)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743834)]
		[param: In]
		set;
	}

	[DispId(1610743836)]
	int Length
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743836)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743836)]
		[param: In]
		set;
	}

	[DispId(1610743838)]
	X509PrivateKeyExportFlags ExportPolicy
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743838)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743838)]
		[param: In]
		set;
	}

	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743809)]
	void Create();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743810)]
	void Close();

	void _VtblGap2_19();

	void _VtblGap3_2();
}
