using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using ns1;

namespace ns0;

internal class Class26
{
	private static readonly string string_0 = Class27.smethod_0(1082945938, 150494731, 2132766607);

	private static readonly string string_1 = Class27.smethod_0(1264393871, 150494725, 2132766601);

	private static readonly string string_2 = Class27.smethod_0(1527590837, 150494739, 2132766605);

	private static HybridDictionary hybridDictionary_0 = null;

	private static ResourceManager resourceManager_0 = null;

	private static Class1 class1_0 = new Class1();

	private static bool bool_0 = false;

	[SpecialName]
	private static bool smethod_0()
	{
		return bool.Parse(Class27.smethod_0(512814017, 150494357, 2132766605));
	}

	private static bool smethod_1(string[] string_3)
	{
		if (Class27.smethod_0(2031742654, 150494429, 2132766605).ToLower() == Class27.smethod_0(423543207, 150494421, 2132766607) && string_3 != null && string_3.Length > 0)
		{
			string text = Class27.smethod_0(254015052, 150494421, 2132766599);
			string text2 = Class27.smethod_0(803387532, 150494421, 2132766599);
			bool flag = bool.Parse(Class27.smethod_0(1217476982, 150494371, 2132766605));
			string string_4 = Class27.smethod_0(1470423446, 150494371, 2132766599);
			Class28.Enum12 enum12_ = (bool.Parse(Class27.smethod_0(676631184, 150494395, 2132766607)) ? Class28.Enum12.const_0 : Class28.Enum12.const_1);
			if (string_3[0] == Class27.smethod_0(1862214651, 150494347, 2132766615))
			{
				string location = Assembly.GetEntryAssembly()!.Location;
				if (Class28.smethod_0(location, text, text2, flag, bool_1: true, string_4, enum12_))
				{
					return smethod_0();
				}
				Environment.Exit(5);
			}
			if (string_3[0] == Class27.smethod_0(689513540, 150494367, 2132766611))
			{
				if (Class28.smethod_1(text, bool_0: true))
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
			if (!(@class.method_1(DateTime.Now.Millisecond) != Class27.smethod_0(1493001111, 150494407, 2132766595)))
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += smethod_6;
				smethod_2(args);
			}
		}
	}

	private static void smethod_2(string[] string_3)
	{
		byte[] array = smethod_9(Class27.smethod_0(1042676661, 150494211, 2132766663));
		if (array == null)
		{
			throw new Exception(Class27.smethod_0(1921959417, 150494403, 2132766663));
		}
		smethod_5((Assembly)smethod_3(array), string_3);
		array = null;
	}

	private static object smethod_3(byte[] byte_0)
	{
		try
		{
			Class0 @class = new Class0();
			if (@class.method_1(DateTime.Now.Millisecond) != Class27.smethod_0(1099250160, 150494275, 2132766595))
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
			byte[] array = smethod_9(Class27.smethod_0(1557548716, 150494287, 2132766621));
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
			resourceManager_0 = new ResourceManager(Class27.smethod_0(1726682699, 150494541, 2132766663), typeof(Class26).Assembly);
		}
		try
		{
			bool_0 = true;
			string text = smethod_10(string_3);
			return Class0.smethod_1((byte[])resourceManager_0.GetObject(Class0.smethod_2(text)), Class27.smethod_0(1053472398, 150494707, 2132766709), Class27.smethod_0(1190349105, 150494305, 2132766709));
		}
		finally
		{
			bool_0 = false;
		}
	}

	private static string smethod_10(string string_3)
	{
		string text = string_3;
		text = text.Replace(Class27.smethod_0(2038378021, 150494961, 2132766597), Class27.smethod_0(115308969, 150494965, 2132766595));
		text = text.Replace(Class27.smethod_0(929688571, 150494923, 2132766597), Class27.smethod_0(631826503, 150494927, 2132766595));
		text = text.Replace(Class27.smethod_0(565463895, 150494931, 2132766611), Class27.smethod_0(442040687, 150494935, 2132766595));
		text = text.Replace(Class27.smethod_0(1948229313, 150494907, 2132766611), Class27.smethod_0(482727819, 150494911, 2132766595));
		return text.Replace(Class27.smethod_0(1979856375, 150494857, 2132766601), Class27.smethod_0(880524445, 150494861, 2132766595));
	}

	private static byte[] smethod_11(StringDictionary stringDictionary_0)
	{
		string text = null;
		byte[] array = null;
		string text2 = stringDictionary_0[string_1];
		string text3 = stringDictionary_0[string_0];
		bool flag = text2.ToLower().Equals(Class27.smethod_0(1307903743, 150494963, 2132766601));
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
		if (text.ToLower().Equals(Class27.smethod_0(1090758409, 150494945, 2132766613)))
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
