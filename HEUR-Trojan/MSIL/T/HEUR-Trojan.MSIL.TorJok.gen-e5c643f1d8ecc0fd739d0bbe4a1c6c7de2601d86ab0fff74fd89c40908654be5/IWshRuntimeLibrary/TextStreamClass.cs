using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("0BB02EC0-EF49-11CF-8940-00A0C9054228")]
[ClassInterface(0)]
public sealed class TextStreamClass : ITextStream, TextStream
{
	[DispId(10000)]
	public virtual extern int Line
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10000)]
		get;
	}

	[DispId(-529)]
	public virtual extern int Column
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(-529)]
		get;
	}

	[DispId(10002)]
	public virtual extern bool AtEndOfStream
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10002)]
		get;
	}

	[DispId(10003)]
	public virtual extern bool AtEndOfLine
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10003)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern TextStreamClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10004)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string Read([In] int Characters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10005)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string ReadLine();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10006)]
	[return: MarshalAs(UnmanagedType.BStr)]
	public virtual extern string ReadAll();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10007)]
	public virtual extern void Write([In][MarshalAs(UnmanagedType.BStr)] string Text);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10008)]
	public virtual extern void WriteLine([In][MarshalAs(UnmanagedType.BStr)] string Text = "");

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10009)]
	public virtual extern void WriteBlankLines([In] int Lines);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10010)]
	public virtual extern void Skip([In] int Characters);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10011)]
	public virtual extern void SkipLine();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(10012)]
	public virtual extern void Close();
}
