using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("31411225-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxCancel
{
	[DispId(76032)]
	HxCancelStatus Cancel
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(76032)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(76032)]
		[param: In]
		set;
	}
}
