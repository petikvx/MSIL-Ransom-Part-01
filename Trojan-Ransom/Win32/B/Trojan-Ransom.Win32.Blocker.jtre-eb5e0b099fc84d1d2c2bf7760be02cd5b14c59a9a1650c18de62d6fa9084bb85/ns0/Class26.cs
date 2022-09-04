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
	private static readonly string string_0 = Class27.smethod_0(1853645087, 362782914, 704478901);

	private static readonly string string_1 = Class27.smethod_0(1624002176, 362782924, 704478899);

	private static readonly string string_2 = Class27.smethod_0(420545326, 362782938, 704478903);

	private static HybridDictionary hybridDictionary_0 = null;

	private static ResourceManager resourceManager_0 = null;

	private static Class1 class1_0 = new Class1();

	private static bool bool_0 = false;

	[SpecialName]
	private static bool smethod_0()
	{
		return bool.Parse(Class27.smethod_0(1054759804, 362783324, 704478903));
	}

	private static bool smethod_1(string[] string_3)
	{
		if (Class27.smethod_0(1872544248, 362783252, 704478903).ToLower() == Class27.smethod_0(1693996290, 362783260, 704478901) && string_3 != null && string_3.Length > 0)
		{
			string text = Class27.smethod_0(270477897, 362783260, 704478909);
			string text2 = Class27.smethod_0(1952940868, 362783260, 704478909);
			bool flag = bool.Parse(Class27.smethod_0(1070480796, 362783338, 704478903));
			string string_4 = Class27.smethod_0(656520349, 362783338, 704478909);
			Class28.Enum12 enum12_ = (bool.Parse(Class27.smethod_0(586332009, 362783346, 704478901)) ? Class28.Enum12.const_0 : Class28.Enum12.const_1);
			if (string_3[0] == Class27.smethod_0(154385137, 362783298, 704478893))
			{
				string location = Assembly.GetEntryAssembly()!.Location;
				if (Class28.smethod_0(location, text, text2, flag, bool_1: true, string_4, enum12_))
				{
					return smethod_0();
				}
				Environment.Exit(5);
			}
			if (string_3[0] == Class27.smethod_0(601283721, 362783318, 704478889))
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
			if (!(@class.method_1(DateTime.Now.Millisecond) != Class27.smethod_0(517605349, 362783246, 704478905)))
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += smethod_6;
				smethod_2(args);
			}
		}
	}

	private static void smethod_2(string[] string_3)
	{
		byte[] array = smethod_9(Class27.smethod_0(922676100, 362783434, 704478973));
		if (array == null)
		{
			throw new Exception(Class27.smethod_0(898208227, 362783242, 704478973));
		}
		smethod_5((Assembly)smethod_3(array), string_3);
		array = null;
	}

	private static object smethod_3(byte[] byte_0)
	{
		try
		{
			Class0 @class = new Class0();
			if (@class.method_1(DateTime.Now.Millisecond) != Class27.smethod_0(852027898, 362783370, 704478905))
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
			byte[] array = smethod_9(Class27.smethod_0(1444372462, 362783366, 704478887));
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
			resourceManager_0 = new ResourceManager(Class27.smethod_0(685854827, 362783620, 704478973), typeof(Class26).Assembly);
		}
		try
		{
			bool_0 = true;
			string text = smethod_10(string_3);
			return Class0.smethod_1((byte[])resourceManager_0.GetObject(Class0.smethod_2(text)), Class27.smethod_0(1130964228, 362783546, 704478927), Class27.smethod_0(1743451452, 362783400, 704478927));
		}
		finally
		{
			bool_0 = false;
		}
	}

	private static string smethod_10(string string_3)
	{
		string text = string_3;
		text = text.Replace(Class27.smethod_0(193821709, 362782776, 704478911), Class27.smethod_0(1066400519, 362782780, 704478905));
		text = text.Replace(Class27.smethod_0(1027060242, 362782722, 704478911), Class27.smethod_0(2114141106, 362782726, 704478905));
		text = text.Replace(Class27.smethod_0(1506598446, 362782746, 704478889), Class27.smethod_0(647201773, 362782750, 704478905));
		text = text.Replace(Class27.smethod_0(1764486574, 362782834, 704478889), Class27.smethod_0(1332334430, 362782838, 704478905));
		return text.Replace(Class27.smethod_0(1758579047, 362782784, 704478899), Class27.smethod_0(1736752264, 362782788, 704478905));
	}

	private static byte[] smethod_11(StringDictionary stringDictionary_0)
	{
		string text = null;
		byte[] array = null;
		string text2 = stringDictionary_0[string_1];
		string text3 = stringDictionary_0[string_0];
		bool flag = text2.ToLower().Equals(Class27.smethod_0(732930589, 362782778, 704478899));
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
		if (text.ToLower().Equals(Class27.smethod_0(1608733939, 362782760, 704478895)))
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
