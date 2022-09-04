using System;
using System.Runtime.InteropServices;

namespace Lexplorer;

public struct PROCESSENTRY32
{
	public uint dwSize;

	public uint cntUsage;

	public uint th32ProcessID;

	public IntPtr th32DefaultHeapID;

	public uint th32ModuleID;

	public uint cntThreads;

	public uint th32ParentProcessID;

	public int pcPriClassBase;

	public uint dwFlags;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	public string szExeFile;
}
