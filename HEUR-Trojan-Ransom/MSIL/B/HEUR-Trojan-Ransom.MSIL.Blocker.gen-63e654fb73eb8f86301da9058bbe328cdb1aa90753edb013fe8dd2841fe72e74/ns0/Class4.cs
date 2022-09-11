using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Xml;

namespace ns0;

internal sealed class Class4
{
	private const string string_0 = " ";

	private string string_1;

	private XmlReader xmlReader_0;

	private Class3 class3_0;

	private Class4(string string_2, Class3 class3_1)
	{
		string_1 = string_2;
		class3_0 = new Class3();
		if (class3_1 == null)
		{
			return;
		}
		class3_0.Nullable_1 = class3_1.Nullable_1;
		class3_0.Nullable_0 = class3_1.Nullable_0;
		foreach (KeyValuePair<string, Class2> item in class3_1.Dictionary_0)
		{
			class3_0.Dictionary_0.Add(item.Key, item.Value);
		}
	}

	public static Class3 smethod_0(string string_2)
	{
		return smethod_1(string_2, null);
	}

	public static Class3 smethod_1(string string_2, Class3 class3_1)
	{
		return new Class4(string_2, class3_1).method_0();
	}

	private Class3 method_0()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		((CodeAccessPermission)new FileIOPermission((FileIOPermissionAccess)1, string_1)).Assert();
		try
		{
			if (File.Exists(string_1))
			{
				using FileStream input = new FileStream(string_1, FileMode.Open, FileAccess.Read);
				using (xmlReader_0 = XmlReader.Create(input, new XmlReaderSettings
				{
					IgnoreComments = true,
					IgnoreWhitespace = true,
					IgnoreProcessingInstructions = true
				}))
				{
					if (method_1())
					{
						return class3_0;
					}
				}
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
		return null;
	}

	public static byte[] smethod_2(byte[] byte_0, byte[] byte_1)
	{
		Class1.smethod_3(byte_0, byte_1);
		return byte_0;
	}

	private bool method_1()
	{
		if (!method_9())
		{
			return false;
		}
		while (true)
		{
			if (xmlReader_0.Read())
			{
				if (!method_8(" "))
				{
					if (xmlReader_0.NodeType == XmlNodeType.Element)
					{
						string name = xmlReader_0.Name;
						if (smethod_3(name, " "))
						{
							if (!method_2())
							{
								break;
							}
						}
						else if (smethod_3(name, " "))
						{
							if (!method_3())
							{
								break;
							}
						}
						else if (!smethod_3(name, " ") || !method_4())
						{
							break;
						}
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private bool method_2()
	{
		if (bool.TryParse(xmlReader_0.GetAttribute(" "), out var result))
		{
			class3_0.Nullable_1 = result;
			return true;
		}
		return false;
	}

	private bool method_3()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		string attribute = xmlReader_0.GetAttribute(" ");
		try
		{
			class3_0.Nullable_0 = (UriIdnScope)Enum.Parse(typeof(UriIdnScope), attribute, ignoreCase: true);
			return true;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	private bool method_4()
	{
		while (true)
		{
			if (xmlReader_0.Read())
			{
				if (!method_8(" "))
				{
					if (xmlReader_0.NodeType == XmlNodeType.Element)
					{
						string name = xmlReader_0.Name;
						if (smethod_3(name, " "))
						{
							if (!method_5())
							{
								break;
							}
							continue;
						}
						if (smethod_3(name, " "))
						{
							if (!method_6())
							{
								break;
							}
							continue;
						}
						if (!smethod_3(name, " "))
						{
							break;
						}
						method_7();
						continue;
					}
					return false;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private static bool smethod_3(string string_2, string string_3)
	{
		return string.Compare(string_2, string_3, StringComparison.OrdinalIgnoreCase) == 0;
	}

	private bool method_5()
	{
		string attribute = xmlReader_0.GetAttribute(" ");
		string attribute2 = xmlReader_0.GetAttribute(" ");
		if (!string.IsNullOrEmpty(attribute) && !string.IsNullOrEmpty(attribute2))
		{
			try
			{
				GenericUriParserOptions genericUriParserOptions_ = (GenericUriParserOptions)Enum.Parse(typeof(GenericUriParserOptions), attribute2);
				Class2 @class = new Class2(attribute, genericUriParserOptions_);
				class3_0.Dictionary_0[@class.String_0] = @class;
				return true;
			}
			catch (ArgumentException)
			{
				return false;
			}
		}
		return false;
	}

	private bool method_6()
	{
		string attribute = xmlReader_0.GetAttribute(" ");
		if (string.IsNullOrEmpty(attribute))
		{
			return false;
		}
		class3_0.Dictionary_0.Remove(attribute);
		return true;
	}

	private void method_7()
	{
		class3_0.Dictionary_0.Clear();
	}

	private bool method_8(string string_2)
	{
		if (xmlReader_0.NodeType == XmlNodeType.EndElement)
		{
			return string.Compare(xmlReader_0.Name, string_2, StringComparison.OrdinalIgnoreCase) == 0;
		}
		return false;
	}

	private bool method_9()
	{
		if (!xmlReader_0.ReadToFollowing(" "))
		{
			return false;
		}
		if (xmlReader_0.Depth != 0)
		{
			return false;
		}
		do
		{
			if (!xmlReader_0.ReadToFollowing(" "))
			{
				return false;
			}
		}
		while (xmlReader_0.Depth != 1);
		return true;
	}
}
