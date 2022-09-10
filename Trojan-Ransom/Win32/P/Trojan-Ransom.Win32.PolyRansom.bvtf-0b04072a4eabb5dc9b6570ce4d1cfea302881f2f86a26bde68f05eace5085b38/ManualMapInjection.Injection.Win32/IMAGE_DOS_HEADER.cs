using System.Runtime.InteropServices;

namespace ManualMapInjection.Injection.Win32;

public struct IMAGE_DOS_HEADER
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
	public char[] e_magic;

	public ushort e_cblp;

	public ushort e_cp;

	public ushort e_crlc;

	public ushort e_cparhdr;

	public ushort e_minalloc;

	public ushort e_maxalloc;

	public ushort e_ss;

	public ushort e_sp;

	public ushort e_csum;

	public ushort e_ip;

	public ushort e_cs;

	public ushort e_lfarlc;

	public ushort e_ovno;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
	public ushort[] e_res1;

	public ushort e_oemid;

	public ushort e_oeminfo;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
	public ushort[] e_res2;

	public int e_lfanew;

	private string _e_magic => new string(e_magic);

	public bool isValid => _e_magic == "MZ";
}
