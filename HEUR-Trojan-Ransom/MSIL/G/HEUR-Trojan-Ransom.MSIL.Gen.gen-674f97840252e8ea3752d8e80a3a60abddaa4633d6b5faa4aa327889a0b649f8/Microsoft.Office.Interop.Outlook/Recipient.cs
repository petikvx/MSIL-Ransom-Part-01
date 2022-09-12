using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Office.Interop.Outlook;

[ComImport]
[Guid("00063045-0000-0000-C000-000000000046")]
[TypeIdentifier]
[CompilerGenerated]
public interface Recipient
{
	[DispId(3093)]
	int Type
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3093)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(3093)]
		[param: In]
		set;
	}

	void _VtblGap1_19();

	void _VtblGap2_2();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(113)]
	bool Resolve();
}
