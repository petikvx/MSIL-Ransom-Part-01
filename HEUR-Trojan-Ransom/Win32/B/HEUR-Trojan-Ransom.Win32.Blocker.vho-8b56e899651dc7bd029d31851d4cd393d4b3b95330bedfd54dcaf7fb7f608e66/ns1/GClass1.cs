using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using AgileDotNet.ErrorReporting.SecureTeamWs;

namespace ns1;

public class GClass1
{
	private static string string_0;

	private static string string_1;

	private static string string_2;

	private static string string_3;

	private Exception exception_0;

	public GClass1(Exception exception_1)
	{
		exception_0 = exception_1;
	}

	static GClass1()
	{
		string_3 = "UnknownCompanyId";
		string_0 = typeof(GClass1).Assembly.GetName().Version!.ToString();
		AssemblyCompanyAttribute assemblyCompanyAttribute = (AssemblyCompanyAttribute)typeof(GClass1).Assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), inherit: true)[0];
		string_1 = assemblyCompanyAttribute.Company;
		AssemblyProductAttribute assemblyProductAttribute = (AssemblyProductAttribute)typeof(GClass1).Assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), inherit: true)[0];
		string_2 = assemblyProductAttribute.Product;
	}

	public void method_0()
	{
		try
		{
			MemoryStream memoryStream = smethod_0(exception_0, bool_0: true);
			memoryStream.Position = 0L;
			StreamReader streamReader = new StreamReader(memoryStream);
			string string_ = streamReader.ReadToEnd();
			method_1(string_);
		}
		catch (Exception exception_)
		{
			MemoryStream memoryStream2 = smethod_0(exception_, bool_0: false);
			memoryStream2.Position = 0L;
			StreamReader streamReader2 = new StreamReader(memoryStream2);
			string string_2 = streamReader2.ReadToEnd();
			method_1(string_2);
		}
	}

	private void method_1(string string_4)
	{
		ErrorReporting errorReporting = new ErrorReporting();
		errorReporting.CreateErrorReport(string_4);
	}

	private static MemoryStream smethod_0(Exception exception_1, bool bool_0)
	{
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.Indent = true;
		xmlWriterSettings.Encoding = Encoding.UTF8;
		MemoryStream memoryStream = new MemoryStream();
		using XmlWriter xmlWriter = XmlWriter.Create(memoryStream, xmlWriterSettings);
		xmlWriter.WriteStartDocument();
		xmlWriter.WriteStartElement("ErrorReportData");
		xmlWriter.WriteAttributeString("Version", "5.3.0.0");
		xmlWriter.WriteAttributeString("CompanyId", smethod_1());
		xmlWriter.WriteAttributeString("CompanyName", smethod_2());
		xmlWriter.WriteAttributeString("Type", exception_1.GetType().AssemblyQualifiedName);
		xmlWriter.WriteAttributeString("Description", bool_0 ? exception_1.Message : exception_1.ToString());
		xmlWriter.WriteAttributeString("ProductName", smethod_3());
		xmlWriter.WriteAttributeString("Release", smethod_4());
		xmlWriter.WriteAttributeString("OS", Environment.OSVersion.VersionString);
		if (exception_1.StackTrace != null && bool_0)
		{
			smethod_5(xmlWriter, exception_1);
		}
		xmlWriter.WriteEndElement();
		xmlWriter.WriteEndDocument();
		return memoryStream;
	}

	public static string smethod_1()
	{
		return "9GFC7Tqg14g=";
	}

	public static string smethod_2()
	{
		return "Kaldaza.";
	}

	public static string smethod_3()
	{
		return "Kaldaza.";
	}

	public static string smethod_4()
	{
		return "2.5.2";
	}

	private static void smethod_5(XmlWriter xmlWriter_0, Exception exception_1)
	{
		xmlWriter_0.WriteStartElement("StackFrames");
		List<StackFrame> list = (List<StackFrame>)exception_1.Data["StackFrames"];
		Dictionary<StackFrame, object[]> dictionary = (Dictionary<StackFrame, object[]>)exception_1.Data["AgileDotNetStackFrames"];
		string[] array = exception_1.StackTrace!.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		if (list != null && list.Count > 0)
		{
			StackFrame stackFrame = list[0];
			MethodBase method = stackFrame.GetMethod();
			string value = method.DeclaringType!.FullName + "." + method.Name;
			for (int i = 0; i < array.Length && !array[i].Contains(value); i++)
			{
				smethod_6(xmlWriter_0, array[i]);
			}
			foreach (StackFrame item in list)
			{
				xmlWriter_0.WriteStartElement("StackFrame");
				MethodBase method2 = item.GetMethod();
				string value2 = smethod_10(method2);
				xmlWriter_0.WriteAttributeString("Text", value2);
				if (dictionary.ContainsKey(item))
				{
					object[] object_ = dictionary[item];
					string value3 = smethod_7(method2, object_);
					xmlWriter_0.WriteAttributeString("Args", value3);
				}
				xmlWriter_0.WriteEndElement();
			}
		}
		else
		{
			string[] array2 = array;
			foreach (string string_ in array2)
			{
				smethod_6(xmlWriter_0, string_);
			}
		}
		xmlWriter_0.WriteEndElement();
	}

	internal static void smethod_6(XmlWriter xmlWriter_0, string string_4)
	{
		xmlWriter_0.WriteStartElement("StackFrame");
		Regex regex = new Regex("(?<name>[\\w|\\.|=|`|<|>]+)(?=\\()(?<mparams>\\(.*\\))");
		Match match = regex.Match(string_4);
		Group group = match.Groups["mparams"];
		Group group2 = match.Groups["name"];
		int num = group2.Value.LastIndexOf('.');
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(group2.Value.Substring(0, num));
		stringBuilder.Append(" ");
		stringBuilder.Append(group2.Value.Substring(num + 1));
		stringBuilder.Append(group.Value);
		stringBuilder.Append(";");
		xmlWriter_0.WriteAttributeString("Text", stringBuilder.ToString());
		xmlWriter_0.WriteEndElement();
	}

	private static string smethod_7(MethodBase methodBase_0, object[] object_0)
	{
		bool isStatic = methodBase_0.IsStatic;
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write(object_0.Length);
		for (int i = 0; i < object_0.Length; i++)
		{
			string string_;
			Type type_;
			if (!isStatic && i == 0)
			{
				string_ = "this";
				type_ = methodBase_0.DeclaringType;
			}
			else
			{
				ParameterInfo parameterInfo = methodBase_0.GetParameters()[i - ((!isStatic) ? 1 : 0)];
				string_ = parameterInfo.Name;
				type_ = parameterInfo.ParameterType;
			}
			smethod_8(binaryWriter, type_, string_, object_0[i], 0);
		}
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	internal static void smethod_8(BinaryWriter binaryWriter_0, Type type_0, string string_4, object object_0, int int_0)
	{
		binaryWriter_0.Write((string_4 == null) ? "Not Available" : string_4);
		string text = smethod_11(type_0.Assembly);
		binaryWriter_0.Write((text == null) ? "Unknown assembly name" : text);
		string value = smethod_9(type_0);
		binaryWriter_0.Write(value);
		if (object_0 == null)
		{
			binaryWriter_0.Write((byte)0);
			return;
		}
		if (object_0 is Array)
		{
			binaryWriter_0.Write((byte)1);
			Array array = (Array)object_0;
			int rank = array.Rank;
			binaryWriter_0.Write(rank);
			for (int i = 0; i < rank; i++)
			{
				int lowerBound = array.GetLowerBound(i);
				int upperBound = array.GetUpperBound(i);
				binaryWriter_0.Write(lowerBound);
				binaryWriter_0.Write(upperBound);
			}
			if (int_0 < 2)
			{
				List<int> list = new List<int>();
				for (int j = 0; j < array.Rank; j++)
				{
					list.Add(array.GetUpperBound(j) + 1);
				}
				int num = 0;
				int value2 = Math.Min(30, array.Length);
				binaryWriter_0.Write(value2);
				{
					foreach (object item in array)
					{
						string text2 = "";
						int num2 = num;
						foreach (int item2 in list)
						{
							text2 = num2 % item2 + ", " + text2;
							num2 /= item2;
						}
						text2 = text2.Substring(0, text2.Length - 2);
						text2 = "[" + text2 + "]";
						smethod_8(binaryWriter_0, array.GetType().GetElementType(), text2, item, 0);
						if (num <= 30)
						{
							num++;
							continue;
						}
						break;
					}
					return;
				}
			}
			binaryWriter_0.Write(0);
			return;
		}
		binaryWriter_0.Write((byte)2);
		binaryWriter_0.Write(object_0.ToString());
		if (int_0 < 2)
		{
			FieldInfo[] fields = object_0.GetType().GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			binaryWriter_0.Write(fields.Length);
			FieldInfo[] array2 = fields;
			foreach (FieldInfo fieldInfo in array2)
			{
				object value3 = fieldInfo.GetValue(object_0);
				smethod_8(binaryWriter_0, fieldInfo.FieldType, fieldInfo.Name, value3, ++int_0);
			}
		}
		else
		{
			binaryWriter_0.Write(0);
		}
	}

	private static string smethod_9(Type type_0)
	{
		string result = "Unknown type name";
		if ((type_0.IsGenericType || type_0.IsGenericParameter) && !string.IsNullOrEmpty(type_0.Name))
		{
			result = ((!string.IsNullOrEmpty(type_0.Namespace)) ? $"{type_0.Namespace}.{type_0.Name}" : type_0.Name);
		}
		else if (type_0.FullName != null)
		{
			result = type_0.FullName;
		}
		return result;
	}

	private static string smethod_10(MethodBase methodBase_0)
	{
		string value = smethod_11(methodBase_0.DeclaringType!.Assembly);
		string fullName = methodBase_0.DeclaringType!.FullName;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value);
		stringBuilder.Append("!");
		stringBuilder.Append(fullName);
		stringBuilder.Append(" ");
		if (methodBase_0.IsFamilyAndAssembly)
		{
			stringBuilder.Append("protected internal");
		}
		else if (methodBase_0.IsPrivate)
		{
			stringBuilder.Append("private");
		}
		else if (methodBase_0.IsPublic)
		{
			stringBuilder.Append("public");
		}
		else if (methodBase_0.IsFamily)
		{
			stringBuilder.Append("protected");
		}
		else if (methodBase_0.IsAssembly)
		{
			stringBuilder.Append("internal");
		}
		stringBuilder.Append(" ");
		if (methodBase_0.IsStatic)
		{
			stringBuilder.Append("static");
		}
		else if (methodBase_0.IsVirtual)
		{
			stringBuilder.Append("virtual");
		}
		if (!methodBase_0.IsConstructor)
		{
			stringBuilder.Append(" ");
			stringBuilder.Append(((MethodInfo)methodBase_0).ReturnType.Name);
			stringBuilder.Append(" ");
		}
		stringBuilder.Append(methodBase_0.Name);
		stringBuilder.Append("(");
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		for (int i = 0; i < parameters.Length; i++)
		{
			stringBuilder.Append(parameters[i].ParameterType.Name);
			stringBuilder.Append(" ");
			stringBuilder.Append(parameters[i].Name);
			if (i != parameters.Length - 1)
			{
				stringBuilder.Append(", ");
			}
		}
		stringBuilder.Append(");");
		return stringBuilder.ToString();
	}

	private static string smethod_11(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}
}
