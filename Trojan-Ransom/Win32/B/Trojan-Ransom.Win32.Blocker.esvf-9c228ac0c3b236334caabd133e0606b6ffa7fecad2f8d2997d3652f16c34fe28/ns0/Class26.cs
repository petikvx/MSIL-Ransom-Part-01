using System;
using System.Collections.Specialized;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class26
{
	private static readonly string string_0 = Class58.smethod_0(192142024, 945819355, 14528716);

	private static readonly string string_1 = Class58.smethod_0(489721783, 945819349, 14528714);

	private static readonly string string_2 = Class58.smethod_0(1558982969, 945819331, 14528718);

	private static HybridDictionary hybridDictionary_0 = null;

	private static ResourceManager resourceManager_0 = null;

	private static Class4 class4_0 = new Class4();

	private static bool bool_0 = false;

	[SpecialName]
	private static bool smethod_0()
	{
		try
		{
			return bool.Parse(Class58.smethod_0(1329628671, 945818693, 14528718));
		}
		catch (Exception exception_)
		{
			Class14.smethod_21(exception_);
			throw;
		}
	}

	private static bool smethod_1(string[] string_3)
	{
		string object_ = default(string);
		string object_2 = default(string);
		bool flag = default(bool);
		string text = default(string);
		Class28.Enum13 @enum = default(Class28.Enum13);
		string location = default(string);
		try
		{
			if (Class58.smethod_0(1714541216, 945818637, 14528718).ToLower() == Class58.smethod_0(2095381663, 945818629, 14528716) && string_3 != null && string_3.Length > 0)
			{
				object_ = Class58.smethod_0(1672514115, 945818629, 14528708);
				object_2 = Class58.smethod_0(1085422379, 945818629, 14528708);
				flag = bool.Parse(Class58.smethod_0(997253458, 945818739, 14528718));
				text = Class58.smethod_0(1842650399, 945818739, 14528708);
				@enum = (bool.Parse(Class58.smethod_0(1642160430, 945818731, 14528716)) ? Class28.Enum13.const_0 : Class28.Enum13.const_1);
				if (string_3[0] == Class58.smethod_0(247336809, 945818715, 14528724))
				{
					location = Assembly.GetEntryAssembly()!.Location;
					if (Class28.smethod_0(location, object_, object_2, flag, bool_1: true, text, @enum))
					{
						return smethod_0();
					}
					Environment.Exit(5);
				}
				if (string_3[0] == Class58.smethod_0(220721147, 945818703, 14528720))
				{
					if (Class28.smethod_1(object_, bool_0: true))
					{
						return smethod_0();
					}
					Environment.Exit(5);
				}
			}
			return true;
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, string_3, object_, object_2, flag, text, @enum, location);
			throw;
		}
	}

	[STAThread]
	private static void Main(string[] args)
	{
		Class0 @class = default(Class0);
		DateTime now = default(DateTime);
		AppDomain currentDomain = default(AppDomain);
		try
		{
			Class14.smethod_10();
			if (smethod_1(args))
			{
				@class = new Class0();
				Class0 class2 = @class;
				now = DateTime.Now;
				if (!(class2.method_1(now.Millisecond) != Class58.smethod_0(733281052, 945818647, 14528704)))
				{
					currentDomain = AppDomain.CurrentDomain;
					currentDomain.AssemblyResolve += smethod_6;
					smethod_2(args);
				}
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, args, @class, currentDomain, now);
			throw;
		}
	}

	private static void smethod_2(string[] string_3)
	{
		byte[] array = default(byte[]);
		try
		{
			array = smethod_9(Class58.smethod_0(729561969, 945818835, 14528644));
			if (array == null)
			{
				throw new Exception(Class58.smethod_0(2053047579, 945818643, 14528644));
			}
			smethod_5((Assembly)smethod_3(array), string_3);
			array = null;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, string_3, array);
			throw;
		}
	}

	private static object smethod_3(byte[] byte_0)
	{
		Class0 @class = default(Class0);
		DateTime now = default(DateTime);
		object obj = default(object);
		try
		{
			try
			{
				@class = new Class0();
				Class0 class2 = @class;
				now = DateTime.Now;
				if (class2.method_1(now.Millisecond) != Class58.smethod_0(186801028, 945818771, 14528704))
				{
					obj = null;
					return obj;
				}
				obj = Assembly.Load(byte_0);
				return obj;
			}
			catch (Exception)
			{
				obj = null;
				return obj;
			}
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, byte_0, @class, obj, now);
			throw;
		}
	}

	private static Assembly smethod_4()
	{
		Assembly assembly = default(Assembly);
		byte[] array = default(byte[]);
		Assembly assembly2 = default(Assembly);
		MemoryStream memoryStream = default(MemoryStream);
		try
		{
			assembly = null;
			try
			{
				array = smethod_9(Class58.smethod_0(1874230632, 945818783, 14528734));
				if (array == null)
				{
					assembly2 = null;
					return assembly2;
				}
				memoryStream = new MemoryStream(array);
				assembly = Assembly.Load(memoryStream.ToArray());
			}
			catch
			{
				assembly = null;
			}
			return assembly;
		}
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, assembly, array, memoryStream, assembly2);
			throw;
		}
	}

	private static void smethod_5(Assembly assembly_0, string[] string_3)
	{
		MethodInfo entryPoint = default(MethodInfo);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		try
		{
			entryPoint = assembly_0.EntryPoint;
			parameters = entryPoint.GetParameters();
			array = null;
			if (parameters != null && parameters.Length > 0)
			{
				array2 = new object[1] { string_3 };
				array = array2;
			}
			entryPoint.Invoke(null, array);
		}
		catch (Exception exception_)
		{
			Class14.smethod_27(exception_, assembly_0, string_3, entryPoint, parameters, array, array2);
			throw;
		}
	}

	[Obfuscation(StripAfterObfuscation = false, Feature = "cw method body protection", Exclude = true)]
	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		try
		{
			return smethod_7(resolveEventArgs_0);
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, object_0, resolveEventArgs_0);
			throw;
		}
	}

	private static Assembly smethod_7(ResolveEventArgs resolveEventArgs_0)
	{
		try
		{
			if (bool_0)
			{
				return null;
			}
			return (Assembly)smethod_14(resolveEventArgs_0.Name);
		}
		catch (Exception exception_)
		{
			Class14.smethod_22(exception_, resolveEventArgs_0);
			throw;
		}
	}

	[SpecialName]
	public static string smethod_8()
	{
		try
		{
			return Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		}
		catch (Exception exception_)
		{
			Class14.smethod_21(exception_);
			throw;
		}
	}

	private static byte[] smethod_9(string string_3)
	{
		byte[] array = default(byte[]);
		string object_ = default(string);
		try
		{
			array = null;
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager(Class58.smethod_0(1484607751, 945819037, 14528644), typeof(Class26).Assembly);
			}
			try
			{
				bool_0 = true;
				object_ = smethod_10(string_3);
				array = Class0.smethod_1((byte[])resourceManager_0.GetObject(Class0.smethod_2(object_)), Class58.smethod_0(1352435735, 945818915, 14528694), Class58.smethod_0(1129397034, 945818801, 14528694));
			}
			finally
			{
				bool_0 = false;
			}
			return array;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, string_3, array, object_);
			throw;
		}
	}

	private static string smethod_10(string string_3)
	{
		string text = default(string);
		try
		{
			text = string_3;
			text = text.Replace(Class58.smethod_0(1740459212, 945819169, 14528710), Class58.smethod_0(144884031, 945819173, 14528704));
			text = text.Replace(Class58.smethod_0(1585183139, 945819163, 14528710), Class58.smethod_0(1540670140, 945819167, 14528704));
			text = text.Replace(Class58.smethod_0(1277982988, 945819139, 14528720), Class58.smethod_0(372133317, 945819143, 14528704));
			text = text.Replace(Class58.smethod_0(2019440438, 945819243, 14528720), Class58.smethod_0(1782374787, 945819247, 14528704));
			text = text.Replace(Class58.smethod_0(660606097, 945819225, 14528714), Class58.smethod_0(715035269, 945819229, 14528704));
			return text;
		}
		catch (Exception exception_)
		{
			Class14.smethod_23(exception_, string_3, text);
			throw;
		}
	}

	private static byte[] smethod_11(StringDictionary stringDictionary_0)
	{
		string text = default(string);
		byte[] array = default(byte[]);
		string text2 = default(string);
		string text3 = default(string);
		bool flag = default(bool);
		AppDomain currentDomain = default(AppDomain);
		StringCollection stringCollection = default(StringCollection);
		char[] array2 = default(char[]);
		string[] array3 = default(string[]);
		int i = default(int);
		char[] array4 = default(char[]);
		try
		{
			text = null;
			array = null;
			text2 = stringDictionary_0[string_1];
			text3 = stringDictionary_0[string_0];
			flag = text2.ToLower().Equals(Class58.smethod_0(2085428725, 945819171, 14528714));
			currentDomain = AppDomain.CurrentDomain;
			stringCollection = new StringCollection();
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
				string text4 = text;
				array2 = new char[1] { Path.PathSeparator };
				array3 = text4.Split(array2);
				for (i = 0; i < array3.Length; i++)
				{
					string obj = array3[i];
					array4 = new char[3]
					{
						' ',
						'\t',
						Path.PathSeparator
					};
					text = obj.Trim(array4);
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
		catch (Exception exception_)
		{
			Class14.smethod_32(exception_, new object[12]
			{
				stringDictionary_0, text, array, text2, text3, flag, currentDomain, stringCollection, array3, i,
				array2, array4
			});
			throw;
		}
	}

	private static byte[] smethod_12(StringCollection stringCollection_0, string string_3)
	{
		int num = default(int);
		string text = default(string);
		try
		{
			num = 0;
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
		catch (Exception exception_)
		{
			Class14.smethod_25(exception_, stringCollection_0, string_3, num, text);
			throw;
		}
	}

	private static byte[] smethod_13(string string_3)
	{
		FileStream fileStream = default(FileStream);
		byte[] array = default(byte[]);
		try
		{
			fileStream = null;
			array = null;
			try
			{
				fileStream = File.OpenRead(string_3);
				array = new byte[fileStream.Length];
				fileStream.Read(array, 0, array.Length);
				fileStream.Flush();
			}
			finally
			{
				fileStream?.Close();
				fileStream = null;
			}
			return array;
		}
		catch (Exception exception_)
		{
			Class14.smethod_24(exception_, string_3, fileStream, array);
			throw;
		}
	}

	private static object smethod_14(string string_3)
	{
		string text = default(string);
		StringDictionary stringDictionary = default(StringDictionary);
		string text2 = default(string);
		byte[] array = default(byte[]);
		Assembly assembly = default(Assembly);
		object obj2 = default(object);
		try
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
			text = string_3.ToLower();
			if (hybridDictionary_0[text] != null)
			{
				return (Assembly)hybridDictionary_0[text];
			}
			stringDictionary = smethod_15(string_3);
			text2 = stringDictionary[string_0];
			array = null;
			if (text2.ToLower().Equals(Class58.smethod_0(1107107420, 945819185, 14528726)))
			{
				assembly = smethod_4();
				hybridDictionary_0[text] = assembly;
				return assembly;
			}
			array = smethod_9(string_3);
			if (array == null)
			{
				array = smethod_9(text2);
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
			obj2 = smethod_3(array);
			array = null;
			hybridDictionary_0[text] = obj2;
			return obj2;
		}
		catch (Exception exception_)
		{
			Class14.smethod_28(exception_, string_3, text, stringDictionary, text2, array, assembly, obj2);
			throw;
		}
	}

	private static StringDictionary smethod_15(string string_3)
	{
		StringDictionary stringDictionary = default(StringDictionary);
		char[] array = default(char[]);
		string[] array2 = default(string[]);
		int i = default(int);
		char[] array3 = default(char[]);
		char[] array4 = default(char[]);
		string[] array5 = default(string[]);
		char[] array6 = default(char[]);
		char[] array7 = default(char[]);
		try
		{
			stringDictionary = new StringDictionary();
			array = new char[1] { ',' };
			array2 = string_3.Split(array);
			for (i = 0; i < array2.Length; i++)
			{
				string obj = array2[i];
				array3 = new char[2] { ' ', ',' };
				string text = obj.Trim(array3);
				array4 = new char[1] { '=' };
				array5 = text.Split(array4);
				if (array5.Length < 2)
				{
					stringDictionary.Add(string_0, array5[0]);
					continue;
				}
				StringDictionary stringDictionary2 = stringDictionary;
				string obj2 = array5[0];
				array6 = new char[2] { ' ', '=' };
				string key = obj2.Trim(array6);
				string obj3 = array5[1];
				array7 = new char[2] { ' ', '=' };
				stringDictionary2.Add(key, obj3.Trim(array7));
			}
			return stringDictionary;
		}
		catch (Exception exception_)
		{
			Class14.smethod_31(exception_, string_3, stringDictionary, array2, i, array5, array, array3, array4, array6, array7);
			throw;
		}
	}
}
