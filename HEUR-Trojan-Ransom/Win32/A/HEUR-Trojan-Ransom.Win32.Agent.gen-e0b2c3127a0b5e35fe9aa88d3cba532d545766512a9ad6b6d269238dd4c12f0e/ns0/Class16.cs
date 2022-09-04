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
	private static readonly string string_0 = Class48.smethod_0(1387120070, 135681157, 323859800);

	private static readonly string string_1 = Class48.smethod_0(1238982981, 135681163, 323859806);

	private static readonly string string_2 = Class48.smethod_0(59681277, 135681181, 323859802);

	private static HybridDictionary hybridDictionary_0 = null;

	private static ResourceManager resourceManager_0 = null;

	private static Class3 class3_0 = new Class3();

	private static bool bool_0 = false;

	[SpecialName]
	private static bool smethod_0()
	{
		return bool.Parse(Class48.smethod_0(518086769, 135681563, 323859802));
	}

	private static bool smethod_1(string[] string_3)
	{
		if (Class48.smethod_0(1035464399, 135681619, 323859802).ToLower() == Class48.smethod_0(39876360, 135681627, 323859800) && string_3 != null && string_3.Length > 0)
		{
			string text = Class48.smethod_0(298110797, 135681627, 323859792);
			string text2 = Class48.smethod_0(540004605, 135681627, 323859792);
			bool flag = bool.Parse(Class48.smethod_0(757709161, 135681581, 323859802));
			string string_4 = Class48.smethod_0(1175179047, 135681581, 323859792);
			Class18.Enum12 enum12_ = (bool.Parse(Class48.smethod_0(671204597, 135681589, 323859800)) ? Class18.Enum12.const_0 : Class18.Enum12.const_1);
			if (string_3[0] == Class48.smethod_0(1875592883, 135681541, 323859776))
			{
				string location = Assembly.GetEntryAssembly()!.Location;
				if (Class18.smethod_0(location, text, text2, flag, bool_1: true, string_4, enum12_))
				{
					return smethod_0();
				}
				Environment.Exit(5);
			}
			if (string_3[0] == Class48.smethod_0(2072677299, 135681553, 323859780))
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
			if (!(@class.method_1(DateTime.Now.Millisecond) != Class48.smethod_0(189888325, 135681609, 323859796)))
			{
				AppDomain currentDomain = AppDomain.CurrentDomain;
				currentDomain.AssemblyResolve += smethod_6;
				smethod_2(args);
			}
		}
	}

	private static void smethod_2(string[] string_3)
	{
		byte[] array = smethod_9(Class48.smethod_0(7696979, 135681677, 323859728));
		if (array == null)
		{
			throw new Exception(Class48.smethod_0(1912845751, 135681613, 323859728));
		}
		smethod_5((Assembly)smethod_3(array), string_3);
		array = null;
	}

	private static object smethod_3(byte[] byte_0)
	{
		try
		{
			Class0 @class = new Class0();
			if (@class.method_1(DateTime.Now.Millisecond) != Class48.smethod_0(389483403, 135681741, 323859796))
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
			byte[] array = smethod_9(Class48.smethod_0(1283908687, 135681729, 323859786));
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
			resourceManager_0 = new ResourceManager(Class48.smethod_0(1348595494, 135681987, 323859728), typeof(Class16).Assembly);
		}
		try
		{
			bool_0 = true;
			string text = smethod_10(string_3);
			return Class0.smethod_1((byte[])resourceManager_0.GetObject(Class0.smethod_2(text)), Class48.smethod_0(66932666, 135681917, 323859746), Class48.smethod_0(689159698, 135681775, 323859746));
		}
		finally
		{
			bool_0 = false;
		}
	}

	private static string smethod_10(string string_3)
	{
		string text = string_3;
		text = text.Replace(Class48.smethod_0(1523561350, 135681151, 323859794), Class48.smethod_0(1026025038, 135681147, 323859796));
		text = text.Replace(Class48.smethod_0(1800731187, 135681093, 323859794), Class48.smethod_0(1595411478, 135681089, 323859796));
		text = text.Replace(Class48.smethod_0(769347412, 135681117, 323859780), Class48.smethod_0(73762437, 135681113, 323859796));
		text = text.Replace(Class48.smethod_0(1214076819, 135681077, 323859780), Class48.smethod_0(1576813937, 135681073, 323859796));
		return text.Replace(Class48.smethod_0(11209404, 135681031, 323859806), Class48.smethod_0(96085288, 135681027, 323859796));
	}

	private static byte[] smethod_11(StringDictionary stringDictionary_0)
	{
		string text = null;
		byte[] array = null;
		string text2 = stringDictionary_0[string_1];
		string text3 = stringDictionary_0[string_0];
		bool flag = text2.ToLower().Equals(Class48.smethod_0(72569880, 135681149, 323859806));
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
		if (text.ToLower().Equals(Class48.smethod_0(518460789, 135681135, 323859778)))
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
