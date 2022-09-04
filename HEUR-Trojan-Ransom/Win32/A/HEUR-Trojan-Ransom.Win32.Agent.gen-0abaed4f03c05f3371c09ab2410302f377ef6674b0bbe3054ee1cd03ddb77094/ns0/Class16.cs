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
	private static readonly string string_0 = Class48.smethod_0(2012484109, 1639920047, 1160447493);

	private static readonly string string_1 = Class48.smethod_0(1483934015, 1639920049, 1160447491);

	private static readonly string string_2 = Class48.smethod_0(1549426877, 1639919943, 1160447495);

	private static HybridDictionary hybridDictionary_0 = null;

	private static ResourceManager resourceManager_0 = null;

	private static Class3 class3_0 = new Class3();

	private static bool bool_0 = false;

	[SpecialName]
	private static bool smethod_0()
	{
		return bool.Parse(Class48.smethod_0(1504358979, 1639920441, 1160447495));
	}

	private static bool smethod_1(string[] string_3)
	{
		if (Class48.smethod_0(191145825, 1639920497, 1160447495).ToLower() == Class48.smethod_0(2078539636, 1639920505, 1160447493) && string_3 != null && string_3.Length > 0)
		{
			string text = Class48.smethod_0(1447567542, 1639920505, 1160447501);
			string text2 = Class48.smethod_0(1327125845, 1639920505, 1160447501);
			bool flag = bool.Parse(Class48.smethod_0(620098099, 1639920399, 1160447495));
			string string_4 = Class48.smethod_0(336231250, 1639920399, 1160447501);
			Class18.Enum12 enum12_ = (bool.Parse(Class48.smethod_0(267549021, 1639920407, 1160447493)) ? Class18.Enum12.const_0 : Class18.Enum12.const_1);
			if (string_3[0] == Class48.smethod_0(1250909177, 1639920423, 1160447517))
			{
				string location = Assembly.GetEntryAssembly()!.Location;
				if (Class18.smethod_0(location, text, text2, flag, bool_1: true, string_4, enum12_))
				{
					return smethod_0();
				}
				Environment.Exit(5);
			}
			if (string_3[0] == Class48.smethod_0(729207528, 1639920435, 1160447513))
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
			if (!(@class.method_1(DateTime.Now.Millisecond) != Class48.smethod_0(1752015195, 1639920491, 1160447497)))
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += smethod_6;
				smethod_2(args);
			}
		}
	}

	private static void smethod_2(string[] string_3)
	{
		byte[] array = smethod_9(Class48.smethod_0(525666789, 1639920559, 1160447565));
		if (array == null)
		{
			throw new Exception(Class48.smethod_0(669365525, 1639920495, 1160447565));
		}
		smethod_5((Assembly)smethod_3(array), string_3);
		array = null;
	}

	private static object smethod_3(byte[] byte_0)
	{
		try
		{
			Class0 @class = new Class0();
			if (@class.method_1(DateTime.Now.Millisecond) != Class48.smethod_0(2064137571, 1639920623, 1160447497))
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
			byte[] array = smethod_9(Class48.smethod_0(1567245365, 1639920611, 1160447511));
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
			resourceManager_0 = new ResourceManager(Class48.smethod_0(1315334117, 1639920361, 1160447565), typeof(Class16).Assembly);
		}
		try
		{
			bool_0 = true;
			string text = smethod_10(string_3);
			return Class0.smethod_1((byte[])resourceManager_0.GetObject(Class0.smethod_2(text)), Class48.smethod_0(274822072, 1639920219, 1160447587), Class48.smethod_0(1711127606, 1639920589, 1160447587));
		}
		finally
		{
			bool_0 = false;
		}
	}

	private static string smethod_10(string string_3)
	{
		string text = string_3;
		text = text.Replace(Class48.smethod_0(1074831441, 1639919973, 1160447503), Class48.smethod_0(98695888, 1639919969, 1160447497));
		text = text.Replace(Class48.smethod_0(471866617, 1639919983, 1160447503), Class48.smethod_0(2063727111, 1639919979, 1160447497));
		text = text.Replace(Class48.smethod_0(1382176330, 1639919879, 1160447513), Class48.smethod_0(2088259897, 1639919875, 1160447497));
		text = text.Replace(Class48.smethod_0(186362235, 1639919903, 1160447513), Class48.smethod_0(1106327978, 1639919899, 1160447497));
		return text.Replace(Class48.smethod_0(1432480792, 1639919917, 1160447491), Class48.smethod_0(28728513, 1639919913, 1160447497));
	}

	private static byte[] smethod_11(StringDictionary stringDictionary_0)
	{
		string text = null;
		byte[] array = null;
		string text2 = stringDictionary_0[string_1];
		string text3 = stringDictionary_0[string_0];
		bool flag = text2.ToLower().Equals(Class48.smethod_0(268768514, 1639919975, 1160447491));
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
		if (text.ToLower().Equals(Class48.smethod_0(966667332, 1639919957, 1160447519)))
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
