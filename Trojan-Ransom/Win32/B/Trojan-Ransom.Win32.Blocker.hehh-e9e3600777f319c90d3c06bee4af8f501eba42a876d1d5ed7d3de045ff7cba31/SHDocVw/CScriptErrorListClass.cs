using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("EFD01300-160F-11D2-BB2E-00805FF7EFCA")]
[ClassInterface(0)]
[TypeLibType(18)]
public class CScriptErrorListClass : IScriptErrorList, CScriptErrorList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern CScriptErrorListClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10)]
	public virtual extern void advanceError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	public virtual extern void retreatError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	public virtual extern int canAdvanceError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	public virtual extern int canRetreatError();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(14)]
	public virtual extern int getErrorLine();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(15)]
	public virtual extern int getErrorChar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(16)]
	public virtual extern int getErrorCode();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(17)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string getErrorMsg();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(18)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string getErrorUrl();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	public virtual extern int getAlwaysShowLockState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(19)]
	public virtual extern int getDetailsPaneOpen();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(20)]
	public virtual extern void setDetailsPaneOpen(int fDetailsPaneOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(21)]
	public virtual extern int getPerErrorDisplay();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(22)]
	public virtual extern void setPerErrorDisplay(int fPerErrorDisplay);
}
