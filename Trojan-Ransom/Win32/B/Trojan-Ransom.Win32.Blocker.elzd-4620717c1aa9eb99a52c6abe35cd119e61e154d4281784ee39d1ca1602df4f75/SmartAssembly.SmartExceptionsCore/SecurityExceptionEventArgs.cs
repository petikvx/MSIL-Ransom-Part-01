using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SmartAssembly.SmartExceptionsCore;

public class SecurityExceptionEventArgs : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 2272)]
	private struct Struct13
	{
	}

	private SecurityException securityException_0;

	private bool bool_0;

	private static readonly object object_0;

	private static readonly object object_1 = new char[1136];

	private static readonly Array array_0;

	internal static byte byte_0/* Not supported: data(00) */;

	internal string string_0 = string.Empty;

	internal bool bool_1;

	internal bool bool_2 = true;

	public bool TryToContinue => bool_1;

	public bool ReportException
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public SecurityExceptionEventArgs(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}

	static SecurityExceptionEventArgs()
	{
		char[] array = new char[8];
		array[3] = '⽮';
		array[7] = '✜';
		array[5] = '㼚';
		array[1] = '៰';
		array[2] = '㪡';
		array[0] = '┒';
		array[6] = '\u10c9';
		array[4] = '㡍';
		array_0 = new string[43];
		object_0 = array;
	}
}
