using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

public class GClass1
{
	private class Class8 : Dictionary<string, Class9>
	{
	}

	private GClass1()
	{
	}

	public static bool smethod_0<T>(ref T gparam_0)
	{
		return smethod_2(ref gparam_0, bool_0: true, bool_1: true);
	}

	public static bool smethod_1<T>(ref T gparam_0, bool bool_0)
	{
		return smethod_2(ref gparam_0, bool_0, bool_1: true);
	}

	public static bool smethod_2<T>(ref T gparam_0, bool bool_0, bool bool_1)
	{
		bool flag = true;
		Class8 class8_ = null;
		try
		{
			Type type = gparam_0.GetType();
			int num = 0;
			int num2 = default(int);
			string[] commandLineArgs = default(string[]);
			StringBuilder stringBuilder = default(StringBuilder);
			string text = default(string);
			string text3 = default(string);
			Class9 @class = default(Class9);
			object value = default(object);
			string text2 = default(string);
			int num3 = default(int);
			bool result = default(bool);
			while (true)
			{
				switch (num)
				{
				case 7:
					if (num2 < commandLineArgs.Length)
					{
						if (commandLineArgs[num2][0] != '-' && commandLineArgs[num2][0] != '/')
						{
							stringBuilder.AppendFormat("{0} ", commandLineArgs[num2]);
							goto case 20;
						}
						text = commandLineArgs[num2].Substring(1);
						num = 8;
						break;
					}
					if (stringBuilder.Length > 0)
					{
						foreach (Class9 value2 in class8_.Values)
						{
							int num5 = 0;
							while (true)
							{
								switch (num5)
								{
								case 1:
									if (string.IsNullOrEmpty(text3))
									{
										value2.PropertyInfo_0.SetValue(gparam_0, stringBuilder.ToString(), null);
										num5 = 2;
									}
									else
									{
										value2.PropertyInfo_0.SetValue(gparam_0, $"{text3} {stringBuilder.ToString()}", null);
										num5 = 3;
									}
									continue;
								case 0:
									break;
								default:
									goto end_IL_0118;
								case 2:
									goto end_IL_0118;
								}
								if (value2.Boolean_0)
								{
									text3 = (string)value2.PropertyInfo_0.GetValue(gparam_0, null);
									num5 = 1;
									continue;
								}
								goto IL_012b;
								continue;
								end_IL_0118:
								break;
							}
							break;
							IL_012b:;
						}
					}
					smethod_3(ref gparam_0, ref class8_);
					num = 24;
					break;
				case 20:
				case 21:
				case 23:
					num2++;
					goto case 7;
				case 22:
					@class.PropertyInfo_0.SetValue(gparam_0, value, null);
					num = 23;
					break;
				case 19:
					if (text2 != string.Empty)
					{
						stringBuilder.AppendFormat("{0} ", text2);
						num = 20;
						break;
					}
					goto case 20;
				case 18:
					if (text2 != string.Empty)
					{
						num2++;
					}
					if (@class == null)
					{
						stringBuilder.AppendFormat("{0} ", @class);
						num = 19;
					}
					else if ((object)@class.PropertyInfo_0.PropertyType == typeof(bool))
					{
						if (!(text2 == string.Empty))
						{
							throw new Exception($"A value was specified for the '{text}' parameter but none was expected.");
						}
						@class.PropertyInfo_0.SetValue(gparam_0, true, null);
						num = 21;
					}
					else
					{
						if (text2 == string.Empty)
						{
							throw new Exception($"No value was specified for the '{text}' parameter but one was expected.");
						}
						value = smethod_12(text2, @class.PropertyInfo_0.PropertyType);
						num = 22;
					}
					break;
				case 17:
					text2 = smethod_5(num2, commandLineArgs);
					num = 18;
					break;
				case 16:
					if (class8_.ContainsKey(text))
					{
						@class = class8_[text];
						num = 17;
						break;
					}
					if (num3 == 1)
					{
						foreach (string key in class8_.Keys)
						{
							int num4 = 0;
							while (num4 == 0)
							{
								if (key.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) == 0)
								{
									@class = class8_[key];
									num4 = 1;
									continue;
								}
								goto IL_02c5;
							}
							break;
							IL_02c5:;
						}
					}
					else if (num3 > 1)
					{
						throw new Exception($"The command line value '{text}' could refer to more than one expected parameter.");
					}
					goto case 17;
				case 14:
					result = flag;
					num = 15;
					break;
				case 13:
					flag = false;
					num = 14;
					break;
				case 11:
					result = flag;
					num = 12;
					break;
				case 10:
					flag = false;
					num = 11;
					break;
				case 9:
					if (bool_0)
					{
						if ("detailedhelp".IndexOf(text, StringComparison.CurrentCultureIgnoreCase) == 0)
						{
							if (text.Length == "detailedhelp".Length || num3 == 0)
							{
								smethod_8(ref class8_);
								num = 10;
								break;
							}
							if (num3 > 0)
							{
								throw new Exception($"The command line value '{text}' could refer to more than one expected parameter.");
							}
						}
						else if ("help".IndexOf(text, StringComparison.CurrentCultureIgnoreCase) == 0 || text == "?")
						{
							if (text.Length == "help".Length || num3 == 0)
							{
								smethod_6(ref class8_);
								num = 13;
								break;
							}
							if (num3 > 0)
							{
								throw new Exception($"The command line value '{text}' could refer to more than one expected parameter.");
							}
						}
					}
					@class = null;
					num = 16;
					break;
				case 8:
					num3 = smethod_4(text, ref class8_);
					num = 9;
					break;
				case 6:
					num2 = 1;
					num = 7;
					break;
				case 5:
					stringBuilder = new StringBuilder();
					num = 6;
					break;
				case 4:
					commandLineArgs[0] = string.Empty;
					num = 5;
					break;
				case 3:
					num = 4;
					break;
				case 2:
					commandLineArgs = Environment.GetCommandLineArgs();
					num = 3;
					break;
				case 1:
					class8_ = smethod_11(gparam_0);
					num = 2;
					break;
				case 0:
					type.IsDefined(typeof(GAttribute2), inherit: false);
					num = 1;
					break;
				case 12:
					return result;
				case 15:
					return result;
				default:
					return flag;
				}
			}
		}
		catch (Exception ex)
		{
			int num6 = 0;
			ConsoleColor foregroundColor = default(ConsoleColor);
			while (true)
			{
				switch (num6)
				{
				case 4:
					Console.WriteLine("Unable to read property data from the specified class, so unable to show help.  In addition, the following exception was thrown:\n\n{0}", ex.Message);
					num6 = 5;
					continue;
				case 3:
					Console.ForegroundColor = ConsoleColor.Red;
					num6 = 4;
					continue;
				case 1:
					if (bool_0)
					{
						if (class8_ != null)
						{
							smethod_7(ex, ref class8_);
							num6 = 2;
						}
						else
						{
							foregroundColor = Console.ForegroundColor;
							num6 = 3;
						}
						continue;
					}
					break;
				case 0:
					flag = false;
					num6 = 1;
					continue;
				default:
					Console.ForegroundColor = foregroundColor;
					break;
				case 2:
					break;
				}
				break;
			}
			if (!bool_1)
			{
				throw ex;
			}
			return flag;
		}
	}

	private static void smethod_3<T>(ref T gparam_0, ref Class8 class8_0)
	{
		bool flag = false;
		object[] customAttributes = default(object[]);
		for (int num = 0; num == 0; num = 1)
		{
			customAttributes = gparam_0.GetType().GetCustomAttributes(typeof(GAttribute2), inherit: false);
		}
		if (customAttributes != null && customAttributes.Length > 0)
		{
			flag = true;
		}
		object value = default(object);
		foreach (Class9 value2 in class8_0.Values)
		{
			for (int num2 = 0; num2 == 0; num2 = 1)
			{
				value = value2.PropertyInfo_0.GetValue(gparam_0, null);
			}
			if (!value2.Boolean_1 || value != null)
			{
				if (!flag)
				{
					continue;
				}
				foreach (GInterface0 item in value2.List_0)
				{
					if (!item.imethod_0(value))
					{
						throw new Exception($"[{value2.PropertyInfo_0.Name}] Parameter Validation Error - {item.String_1}");
					}
				}
				continue;
			}
			throw new Exception($"[{value2.PropertyInfo_0.Name}] Parameter Validation Error - This required parameter must be specified.");
		}
	}

	private static int smethod_4(string string_0, ref Class8 class8_0)
	{
		if (1 == 0)
		{
		}
		int num = 0;
		foreach (string key in class8_0.Keys)
		{
			if (key.IndexOf(string_0, StringComparison.CurrentCultureIgnoreCase) == 0)
			{
				num++;
			}
		}
		return num;
	}

	private static string smethod_5(int int_0, string[] string_0)
	{
		if (1 == 0)
		{
		}
		string result = string.Empty;
		if (int_0 + 1 < string_0.Length && string_0[int_0 + 1][0] != '-' && string_0[int_0 + 1][0] != '/')
		{
			result = string_0[int_0 + 1];
		}
		return result;
	}

	private static void smethod_6(ref Class8 class8_0)
	{
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		int num = 0;
		string text = default(string);
		AssemblyDescriptionAttribute assemblyDescriptionAttribute = default(AssemblyDescriptionAttribute);
		object[] customAttributes = default(object[]);
		while (true)
		{
			switch (num)
			{
			case 10:
				Class7.smethod_1(4, string.Format("\n{0}{1}", new string(' ', 4), "When specifying names for parameters, the name can be abbreviated as long as the abbreviation used is not ambiguous."));
				num = 11;
				break;
			case 9:
				Console.WriteLine("\nREMARKS\n{0}{1}", new string(' ', 4), $"For more information, type \"{text} -detailedhelp\".");
				num = 10;
				break;
			case 8:
				Class7.smethod_1(4, smethod_9(ref class8_0));
				num = 9;
				break;
			case 6:
			case 7:
				Console.Write("\nSYNTAX\n{0}{1} ", new string(' ', 4), text);
				num = 8;
				break;
			case 5:
				if (assemblyDescriptionAttribute.Description.Trim().Length > 0)
				{
					Class7.smethod_1(4, assemblyDescriptionAttribute.Description);
					num = 6;
				}
				else
				{
					Class7.smethod_1(4, "(no description provided)");
					num = 7;
				}
				break;
			case 4:
				if (customAttributes.Length > 0)
				{
					assemblyDescriptionAttribute = customAttributes[0] as AssemblyDescriptionAttribute;
					num = 5;
					break;
				}
				Class7.smethod_1(4, "(no description provided)");
				goto case 6;
			case 3:
				customAttributes = entryAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), inherit: false);
				num = 4;
				break;
			case 2:
				Console.Write("SYNOPSIS\n{0}", new string(' ', 4));
				num = 3;
				break;
			case 1:
				Console.WriteLine("NAME\n{0}{1}\n", new string(' ', 4), text);
				num = 2;
				break;
			case 0:
				text = $"{entryAssembly.GetName().Name}";
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private static void smethod_7(Exception exception_0, ref Class8 class8_0)
	{
		ConsoleColor foregroundColor = Console.ForegroundColor;
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				smethod_6(ref class8_0);
				num = 4;
				break;
			case 2:
				Console.ForegroundColor = foregroundColor;
				num = 3;
				break;
			case 1:
				Console.WriteLine("{0}\n", exception_0.Message);
				num = 2;
				break;
			case 0:
				Console.ForegroundColor = ConsoleColor.Red;
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private static void smethod_8(ref Class8 class8_0)
	{
		Assembly entryAssembly = Assembly.GetEntryAssembly();
		int num = 0;
		string arg = default(string);
		AssemblyDescriptionAttribute assemblyDescriptionAttribute = default(AssemblyDescriptionAttribute);
		object[] customAttributes = default(object[]);
		while (true)
		{
			switch (num)
			{
			case 13:
				Class7.smethod_1(4, string.Format("\n{0}{1}", new string(' ', 4), "When specifying names for parameters, the name can be abbreviated as long as the abbreviation used is not ambiguous."));
				num = 14;
				break;
			case 12:
				Console.Write("\nREMARKS");
				num = 13;
				break;
			case 11:
				Console.WriteLine("{0}-detailedhelp [optional]\n{1}Displays a detailed help screen.", new string(' ', 4), new string(' ', 8));
				num = 12;
				break;
			case 10:
				foreach (string key in class8_0.Keys)
				{
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						case 2:
							Class7.smethod_1(8, class8_0[key].String_0);
							num2 = 3;
							continue;
						case 1:
							if ((object)class8_0[key].PropertyInfo_0.PropertyType != typeof(bool))
							{
								Console.Write("<{0}> ", class8_0[key].PropertyInfo_0.PropertyType.Name);
							}
							if (!class8_0[key].Boolean_1)
							{
								Console.Write("[optional] ");
							}
							Console.Write("\n{0}", new string(' ', 8));
							num2 = 2;
							continue;
						case 0:
							Console.Write("{0}-{1} ", new string(' ', 4), key);
							num2 = 1;
							continue;
						}
						break;
					}
					Console.WriteLine();
				}
				Console.WriteLine("{0}-help [optional]\n{1}Displays an abbreviated help screen.\n", new string(' ', 4), new string(' ', 8));
				num = 11;
				break;
			case 9:
				Console.WriteLine("\nPARAMETERS");
				num = 10;
				break;
			case 8:
				Class7.smethod_1(4, smethod_9(ref class8_0));
				num = 9;
				break;
			case 6:
			case 7:
				Console.Write("\nSYNTAX\n{0}{1} ", new string(' ', 4), arg);
				num = 8;
				break;
			case 5:
				if (assemblyDescriptionAttribute.Description.Trim().Length > 0)
				{
					Class7.smethod_1(4, assemblyDescriptionAttribute.Description);
					num = 6;
				}
				else
				{
					Class7.smethod_1(4, "(no description provided)");
					num = 7;
				}
				break;
			case 4:
				if (customAttributes.Length > 0)
				{
					assemblyDescriptionAttribute = customAttributes[0] as AssemblyDescriptionAttribute;
					num = 5;
					break;
				}
				Class7.smethod_1(4, "(no description provided)");
				goto case 6;
			case 3:
				customAttributes = entryAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), inherit: false);
				num = 4;
				break;
			case 2:
				Console.Write("SYNOPSIS\n{0}", new string(' ', 4));
				num = 3;
				break;
			case 1:
				Console.WriteLine("NAME\n{0}{1}\n", new string(' ', 4), arg);
				num = 2;
				break;
			case 0:
				arg = $"{entryAssembly.GetName().Name}";
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	private static string smethod_9(ref Class8 class8_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int num = 0; num == 0; num = 1)
		{
			foreach (string key in class8_0.Keys)
			{
				int num2 = 0;
				while (num2 == 0)
				{
					if (class8_0[key].Boolean_1)
					{
						stringBuilder.AppendFormat("-{0}{1} ", key, smethod_10(class8_0[key].PropertyInfo_0.PropertyType));
						num2 = 1;
						continue;
					}
					stringBuilder.AppendFormat("[-{0}{1}] ", key, smethod_10(class8_0[key].PropertyInfo_0.PropertyType));
					break;
				}
			}
			stringBuilder.Append("[-help] [-detailedhelp]");
		}
		return stringBuilder.ToString();
	}

	private static string smethod_10(Type type_0)
	{
		if (1 == 0)
		{
		}
		string result = string.Empty;
		if (type_0.Name != typeof(bool).Name)
		{
			result = $" <{type_0.Name}>";
		}
		return result;
	}

	private static Class8 smethod_11(object object_0)
	{
		Class8 @class = new Class8();
		int num = 0;
		GInterface0 gInterface = default(GInterface0);
		object obj = default(object);
		int num2 = default(int);
		object[] customAttributes = default(object[]);
		PropertyInfo propertyInfo = default(PropertyInfo);
		Class9 class2 = default(Class9);
		int num3 = default(int);
		PropertyInfo[] array = default(PropertyInfo[]);
		GAttribute5 gAttribute = default(GAttribute5);
		object[] customAttributes2 = default(object[]);
		PropertyInfo[] properties = default(PropertyInfo[]);
		while (true)
		{
			switch (num)
			{
			case 14:
				gInterface = obj as GInterface0;
				num = 15;
				break;
			case 13:
				if (num2 >= customAttributes.Length)
				{
					@class.Add(propertyInfo.Name, class2);
					goto IL_0033;
				}
				obj = customAttributes[num2];
				num = 14;
				break;
			case 3:
				if (num3 < array.Length)
				{
					propertyInfo = array[num3];
					num = 4;
					break;
				}
				return @class;
			case 12:
				num2 = 0;
				num = 13;
				break;
			case 11:
				customAttributes = propertyInfo.GetCustomAttributes(inherit: false);
				num = 12;
				break;
			case 10:
				class2.PropertyInfo_0 = propertyInfo;
				num = 11;
				break;
			case 9:
				class2.Boolean_0 = gAttribute.Boolean_1;
				num = 10;
				break;
			case 8:
				class2.Boolean_1 = gAttribute.Boolean_0;
				num = 9;
				break;
			case 7:
				class2.String_0 = gAttribute.String_0;
				num = 8;
				break;
			case 6:
				if (customAttributes2.Length <= 1)
				{
					gAttribute = (GAttribute5)customAttributes2[0];
					num = 7;
					break;
				}
				throw new Exception("[Parameter] attribute cannot be used more than once per property.");
			case 5:
				if (propertyInfo.IsDefined(typeof(GAttribute5), inherit: false))
				{
					customAttributes2 = propertyInfo.GetCustomAttributes(typeof(GAttribute5), inherit: false);
					num = 6;
					break;
				}
				goto IL_0033;
			case 4:
				class2 = new Class9();
				num = 5;
				break;
			case 2:
				num3 = 0;
				num = 3;
				break;
			case 1:
				array = properties;
				num = 2;
				break;
			case 0:
				properties = object_0.GetType().GetProperties();
				num = 1;
				break;
			default:
				{
					if (gInterface != null)
					{
						class2.List_0.Add(gInterface);
					}
					num2++;
					goto case 13;
				}
				IL_0033:
				num3++;
				goto case 3;
			}
		}
	}

	private static object smethod_12(string string_0, Type type_0)
	{
		if (1 == 0)
		{
		}
		object obj = null;
		try
		{
			if (type_0.IsArray)
			{
				return string_0.Split(new char[1] { ',' });
			}
			return Convert.ChangeType(string_0, type_0);
		}
		catch (Exception innerException)
		{
			throw new Exception($"Unable to convert command line parameter to {type_0.Name}.", innerException);
		}
	}
}
