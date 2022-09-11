using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Shareware.Shareware.core;

public class UFuncs
{
	public static void FileHide(string DirP)
	{
		File.SetAttributes(DirP, FileAttributes.Hidden);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void OpenAsAdmin(string FilePth, string Argument)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		new Process();
		ProcessStartInfo processStartInfo2 = processStartInfo;
		processStartInfo2.UseShellExecute = true;
		processStartInfo2.FileName = FilePth;
		processStartInfo2.Arguments = Argument;
		processStartInfo2.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo2.Verb = "runas";
		processStartInfo2 = null;
		Process.Start(processStartInfo);
		ProjectData.EndApp();
	}

	public string ConvertFileToBase64(string fileName)
	{
		return Convert.ToBase64String(File.ReadAllBytes(fileName));
	}

	public byte ConvertBase64ToFile(string Bstr64)
	{
		return Convert.ToByte(Bstr64);
	}

	public string EncodeBase64(string input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
	}

	public string DecodeBase64(string input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(input));
	}
}
