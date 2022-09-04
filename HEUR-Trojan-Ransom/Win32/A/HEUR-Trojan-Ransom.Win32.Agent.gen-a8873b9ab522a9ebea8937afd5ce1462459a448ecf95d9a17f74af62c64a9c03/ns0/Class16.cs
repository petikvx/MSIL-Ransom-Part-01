using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal class Class16
{
	private static readonly string string_0 = Class48.smethod_0(1676696484, 1505469611, 626905454);

	private static readonly string string_1 = Class48.smethod_0(407474723, 1505469605, 626905448);

	private static readonly string string_2 = Class48.smethod_0(1146159237, 1505469619, 626905452);

	private static HybridDictionary hybridDictionary_0 = null;

	private static ResourceManager resourceManager_0 = null;

	private static Class3 class3_0 = new Class3();

	private static bool bool_0 = false;

	[SpecialName]
	private static bool smethod_0()
	{
		return bool.Parse(Class48.smethod_0(639015191, 1505470005, 626905452));
	}

	private static bool smethod_1(string[] string_3)
	{
		if (Class48.smethod_0(1906980089, 1505470077, 626905452).ToLower() == Class48.smethod_0(1134652597, 1505470069, 626905454) && string_3 != null && string_3.Length > 0)
		{
			string text = Class48.smethod_0(507655006, 1505470069, 626905446);
			string text2 = Class48.smethod_0(226905334, 1505470069, 626905446);
			bool flag = bool.Parse(Class48.smethod_0(1883378079, 1505469955, 626905452));
			string string_4 = Class48.smethod_0(948923060, 1505469955, 626905446);
			Class18.Enum12 enum12_ = (bool.Parse(Class48.smethod_0(1915442913, 1505469979, 626905454)) ? Class18.Enum12.const_0 : Class18.Enum12.const_1);
			if (string_3[0] == Class48.smethod_0(2048466657, 1505469995, 626905462))
			{
				string location = Assembly.GetEntryAssembly()!.Location;
				if (Class18.smethod_0(location, text, text2, flag, bool_1: true, string_4, enum12_))
				{
					return smethod_0();
				}
				Environment.Exit(5);
			}
			if (string_3[0] == Class48.smethod_0(669042632, 1505470015, 626905458))
			{
				if (Class18.smethod_1(text, bool_0: true))
				{
					return smethod_0();
				}
				Environment.Exit(5);
			}
		}
		return true;
	}

	[STAThread]
	private static void Main(string[] args)
	{
		if (smethod_1(args))
		{
			Class0 @class = new Class0();
			if (!(@class.method_1(DateTime.Now.Millisecond) != Class48.smethod_0(322050620, 1505470055, 626905442)))
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += smethod_6;
				smethod_2(args);
			}
		}
	}

	private static void smethod_2(string[] string_3)
	{
		byte[] array = smethod_9(Class48.smethod_0(1602370668, 1505470115, 626905382));
		if (array == null)
		{
			throw new Exception(Class48.smethod_0(1256758824, 1505470051, 626905382));
		}
		smethod_5((Assembly)smethod_3(array), string_3);
		array = null;
	}

	private static object smethod_3(byte[] byte_0)
	{
		try
		{
			Class0 @class = new Class0();
			if (@class.method_1(DateTime.Now.Millisecond) != Class48.smethod_0(965379323, 1505470179, 626905442))
			{
				return null;
			}
			return Assembly.Load(byte_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	private static Assembly smethod_4()
	{
		Assembly assembly = null;
		try
		{
			byte[] array = smethod_9(Class48.smethod_0(30966612, 1505470191, 626905468));
			if (array == null)
			{
				return null;
			}
			MemoryStream memoryStream = new MemoryStream(array);
			return Assembly.Load(memoryStream.ToArray());
		}
		catch
		{
			return null;
		}
	}

	private static void smethod_5(Assembly assembly_0, string[] string_3)
	{
		MethodInfo entryPoint = assembly_0.EntryPoint;
		ParameterInfo[] parameters = entryPoint.GetParameters();
		object[] parameters2 = null;
		if (parameters != null && parameters.Length > 0)
		{
			parameters2 = new object[1] { string_3 };
		}
		entryPoint.Invoke(null, parameters2);
	}

	[Obfuscation(StripAfterObfuscation = false, Feature = "cw method body protection", Exclude = true)]
	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return smethod_7(resolveEventArgs_0);
	}

	private static Assembly smethod_7(ResolveEventArgs resolveEventArgs_0)
	{
		if (bool_0)
		{
			return null;
		}
		return (Assembly)smethod_14(resolveEventArgs_0.Name);
	}

	[SpecialName]
	public static string smethod_8()
	{
		return Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
	}

	private static byte[] smethod_9(string string_3)
	{
		byte[] array = null;
		if (resourceManager_0 == null)
		{
			resourceManager_0 = new ResourceManager(Class48.smethod_0(1101038574, 1505470445, 626905382), typeof(Class16).Assembly);
		}
		try
		{
			bool_0 = true;
			string text = smethod_10(string_3);
			return Class0.smethod_1((byte[])resourceManager_0.GetObject(Class0.smethod_2(text)), Class48.smethod_0(380062522, 1505470291, 626905364), Class48.smethod_0(1736779253, 1505470145, 626905364));
		}
		finally
		{
			bool_0 = false;
		}
	}

	private static string smethod_10(string string_3)
	{
		string text = string_3;
		text = text.Replace(Class48.smethod_0(1465882637, 1505469521, 626905444), Class48.smethod_0(1068867583, 1505469525, 626905442));
		text = text.Replace(Class48.smethod_0(1929645619, 1505469547, 626905444), Class48.smethod_0(2032617754, 1505469551, 626905442));
		text = text.Replace(Class48.smethod_0(2109385024, 1505469555, 626905458), Class48.smethod_0(696282555, 1505469559, 626905442));
		text = text.Replace(Class48.smethod_0(298622070, 1505469467, 626905458), Class48.smethod_0(1662626630, 1505469471, 626905442));
		return text.Replace(Class48.smethod_0(2144740655, 1505469481, 626905448), Class48.smethod_0(451093426, 1505469485, 626905442));
	}

	private static byte[] smethod_11(StringDictionary stringDictionary_0)
	{
		string text = null;
		byte[] array = null;
		string text2 = stringDictionary_0[string_1];
		string text3 = stringDictionary_0[string_0];
		bool flag = text2.ToLower().Equals(Class48.smethod_0(144240467, 1505469523, 626905448));
		AppDomain currentDomain = AppDomain.CurrentDomain;
		StringCollection stringCollection = new StringCollection();
		text = currentDomain.SetupInformation.ApplicationBase;
		if (!flag)
		{
			text = Path.Combine(text, text2);
		}
		stringCollection.Add(text);
		stringCollection.Add(Path.Combine(text, text3));
		array = smethod_12(stringCollection, text3);
		if (array != null)
		{
			return array;
		}
		stringCollection = new StringCollection();
		text = currentDomain.SetupInformation.get_PrivateBinPath();
		if (text != null && text.Trim().Length > 0)
		{
			string[] array2 = text.Split(new char[1] { Path.PathSeparator });
			for (int i = 0; i < array2.Length; i++)
			{
				text = array2[i].Trim(' ', '\t', Path.PathSeparator);
				if (!Path.IsPathRooted(text))
				{
					text = Path.Combine(currentDomain.SetupInformation.ApplicationBase, text);
				}
				if (!flag)
				{
					text = Path.Combine(text, text2);
				}
				stringCollection.Add(text);
				stringCollection.Add(Path.Combine(text, text3));
			}
			return smethod_12(stringCollection, text3);
		}
		return null;
	}

	private static byte[] smethod_12(StringCollection stringCollection_0, string string_3)
	{
		int num = 0;
		string text;
		while (true)
		{
			if (num < stringCollection_0.Count)
			{
				text = Path.Combine(stringCollection_0[num], string_3 + string_2);
				if (File.Exists(text))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return smethod_13(text);
	}

	private static byte[] smethod_13(string string_3)
	{
		FileStream fileStream = null;
		byte[] array = null;
		try
		{
			fileStream = File.OpenRead(string_3);
			array = new byte[fileStream.Length];
			fileStream.Read(array, 0, array.Length);
			fileStream.Flush();
			return array;
		}
		finally
		{
			fileStream?.Close();
			fileStream = null;
		}
	}

	private static object smethod_14(string string_3)
	{
		if (string_3 == null)
		{
			return null;
		}
		if (hybridDictionary_0 == null)
		{
			hybridDictionary_0 = new HybridDictionary();
		}
		string_3 = string_3.Trim();
		string key = string_3.ToLower();
		if (hybridDictionary_0[key] != null)
		{
			return (Assembly)hybridDictionary_0[key];
		}
		StringDictionary stringDictionary = smethod_15(string_3);
		string text = stringDictionary[string_0];
		byte[] array = null;
		if (text.ToLower().Equals(Class48.smethod_0(1754619464, 1505469505, 626905460)))
		{
			Assembly assembly = smethod_4();
			hybridDictionary_0[key] = assembly;
			return assembly;
		}
		array = smethod_9(string_3);
		if (array == null)
		{
			array = smethod_9(text);
		}
		if (array == null)
		{
			try
			{
				array = smethod_11(stringDictionary);
			}
			catch
			{
				array = null;
			}
		}
		if (array == null)
		{
			return null;
		}
		object obj2 = smethod_3(array);
		array = null;
		hybridDictionary_0[key] = obj2;
		return obj2;
	}

	private static StringDictionary smethod_15(string string_3)
	{
		StringDictionary stringDictionary = new StringDictionary();
		string[] array = string_3.Split(new char[1] { ',' });
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Trim(' ', ',').Split(new char[1] { '=' });
			if (array2.Length < 2)
			{
				stringDictionary.Add(string_0, array2[0]);
				continue;
			}
			stringDictionary.Add(array2[0].Trim(' ', '='), array2[1].Trim(' ', '='));
		}
		return stringDictionary;
	}
}
