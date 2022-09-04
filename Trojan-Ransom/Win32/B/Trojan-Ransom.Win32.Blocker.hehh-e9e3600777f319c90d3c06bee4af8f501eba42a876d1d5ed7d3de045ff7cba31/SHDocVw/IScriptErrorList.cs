using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("F3470F24-15FD-11D2-BB2E-00805FF7EFCA")]
[TypeLibType(4176)]
public interface IScriptErrorList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	void advanceError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	void retreatError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	int canAdvanceError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	int canRetreatError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(14)]
	int getErrorLine();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(15)]
	int getErrorChar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(16)]
	int getErrorCode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(17)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string getErrorMsg();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(18)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string getErrorUrl();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	int getAlwaysShowLockState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(19)]
	int getDetailsPaneOpen();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(20)]
	void setDetailsPaneOpen(int fDetailsPaneOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(21)]
	int getPerErrorDisplay();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(22)]
	void setPerErrorDisplay(int fPerErrorDisplay);
}
