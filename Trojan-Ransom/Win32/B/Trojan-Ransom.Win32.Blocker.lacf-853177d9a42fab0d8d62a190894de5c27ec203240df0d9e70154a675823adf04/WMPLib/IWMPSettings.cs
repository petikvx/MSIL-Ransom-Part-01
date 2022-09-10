using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[CompilerGenerated]
[Guid("9104D1AB-80C9-4FED-ABF0-2E6417A6DF14")]
[TypeIdentifier]
public interface IWMPSettings
{
	[DispId(107)]
	int volume
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(107)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(107)]
		[param: In]
		set;
	}

	void _VtblGap1_17();
}
