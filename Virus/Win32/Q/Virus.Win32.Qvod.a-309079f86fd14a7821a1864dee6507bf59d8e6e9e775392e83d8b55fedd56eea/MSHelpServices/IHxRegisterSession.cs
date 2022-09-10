using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("31411218-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxRegisterSession
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75265)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string CreateTransaction([In][MarshalAs(UnmanagedType.BStr)] string bstrInToken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75268)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string PostponeTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75269)]
	void ContinueTransaction([In][MarshalAs(UnmanagedType.BStr)] string bstrToken);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75266)]
	void CommitTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75267)]
	void RevertTransaction();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(75270)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object GetRegistrationObject([In] HxRegisterSession_InterfaceType type);
}
