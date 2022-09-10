using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Text;

namespace CommandLineParser;

public class CommandLineArgumentParser
{
	private class Argument
	{
		private string longName;

		private string shortName;

		private bool explicitShortName;

		private bool seenValue;

		private FieldInfo field;

		private Type elementType;

		private CommandLineArgumentType flags;

		private ArrayList collectionValues;

		private ErrorReporter reporter;

		private bool isDefault;

		public Type ValueType
		{
			get
			{
				if (!IsCollection)
				{
					return Type;
				}
				return elementType;
			}
		}

		public string LongName => longName;

		public bool ExplicitShortName => explicitShortName;

		public string ShortName => shortName;

		public bool IsRequired => 0 != (flags & CommandLineArgumentType.Required);

		public bool SeenValue => seenValue;

		public bool AllowMultiple => 0 != (flags & CommandLineArgumentType.Multiple);

		public bool Unique => 0 != (flags & CommandLineArgumentType.Unique);

		public Type Type => field.FieldType;

		public bool IsCollection => IsCollectionType(Type);

		public bool IsDefault => isDefault;

		public Argument(CommandLineArgumentAttribute attribute, FieldInfo field, ErrorReporter reporter)
		{
			longName = LongName(attribute, field);
			explicitShortName = ExplicitShortName(attribute);
			shortName = ShortName(attribute, field);
			elementType = ElementType(field);
			flags = Flags(attribute, field);
			this.field = field;
			seenValue = false;
			this.reporter = reporter;
			isDefault = attribute != null && attribute is DefaultCommandLineArgumentAttribute;
			if (IsCollection)
			{
				collectionValues = new ArrayList();
			}
		}

		public bool Finish(object destination)
		{
			if (IsCollection)
			{
				field.SetValue(destination, collectionValues.ToArray(elementType));
			}
			return ReportMissingRequiredArgument();
		}

		private bool ReportMissingRequiredArgument()
		{
			if (IsRequired && !SeenValue)
			{
				if (IsDefault)
				{
					reporter($"Missing required argument '<{LongName}>'.");
				}
				else
				{
					reporter($"Missing required argument '/{LongName}'.");
				}
				return true;
			}
			return false;
		}

		private void ReportDuplicateArgumentValue(string value)
		{
			reporter($"Duplicate '{LongName}' argument '{value}'");
		}

		public bool SetValue(string value, object destination)
		{
			if (SeenValue && !AllowMultiple)
			{
				reporter($"Duplicate '{LongName}' argument");
				return false;
			}
			seenValue = true;
			if (!ParseValue(ValueType, value, out var value2))
			{
				return false;
			}
			if (IsCollection)
			{
				if (Unique && collectionValues.Contains(value2))
				{
					ReportDuplicateArgumentValue(value);
					return false;
				}
				collectionValues.Add(value2);
			}
			else
			{
				field.SetValue(destination, value2);
			}
			return true;
		}

		private void ReportBadArgumentValue(string value)
		{
			reporter($"'{value}' is not a valid value for the '{LongName}' command line option");
		}

		private bool ParseValue(Type type, string stringData, out object value)
		{
			if ((stringData != null || (object)type == typeof(bool)) && (stringData == null || stringData.Length > 0))
			{
				try
				{
					if ((object)type == typeof(string))
					{
						value = stringData;
						return true;
					}
					if ((object)type != typeof(bool))
					{
						if ((object)type == typeof(int))
						{
							value = int.Parse(stringData);
							return true;
						}
						if ((object)type == typeof(uint))
						{
							value = int.Parse(stringData);
							return true;
						}
						value = Enum.Parse(type, stringData, ignoreCase: true);
						return true;
					}
					switch (stringData)
					{
					case "-":
						value = false;
						return true;
					case null:
					case "+":
						value = true;
						return true;
					}
				}
				catch
				{
				}
			}
			ReportBadArgumentValue(stringData);
			value = null;
			return false;
		}
	}

	private ArrayList arguments;

	private Hashtable argumentMap;

	private Argument defaultArgument;

	private ErrorReporter reporter;

	public string Usage
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			int length;
			foreach (Argument argument in arguments)
			{
				length = stringBuilder.Length;
				stringBuilder.Append("    /");
				stringBuilder.Append(argument.LongName);
				Type valueType = argument.ValueType;
				if ((object)valueType == typeof(int))
				{
					stringBuilder.Append(":<int>");
				}
				else if ((object)valueType == typeof(uint))
				{
					stringBuilder.Append(":<uint>");
				}
				else if ((object)valueType == typeof(bool))
				{
					stringBuilder.Append("[+|-]");
				}
				else if ((object)valueType == typeof(string))
				{
					stringBuilder.Append(":<string>");
				}
				else
				{
					stringBuilder.Append(":{");
					bool flag = true;
					FieldInfo[] fields = valueType.GetFields();
					foreach (FieldInfo fieldInfo in fields)
					{
						if (fieldInfo.IsStatic)
						{
							if (flag)
							{
								flag = false;
							}
							else
							{
								stringBuilder.Append('|');
							}
							stringBuilder.Append(fieldInfo.Name);
						}
					}
					stringBuilder.Append('}');
				}
				if (argument.ShortName != argument.LongName && argumentMap[argument.ShortName.ToLower()] == argument)
				{
					stringBuilder.Append(' ', IndentLength(stringBuilder.Length - length));
					stringBuilder.Append("short form /");
					stringBuilder.Append(argument.ShortName);
				}
				stringBuilder.Append(Environment.NewLine);
			}
			length = stringBuilder.Length;
			stringBuilder.Append("    @<file>");
			stringBuilder.Append(' ', IndentLength(stringBuilder.Length - length));
			stringBuilder.Append("Read response file for more options");
			stringBuilder.Append(Environment.NewLine);
			if (defaultArgument != null)
			{
				length = stringBuilder.Length;
				stringBuilder.Append("    <");
				stringBuilder.Append(defaultArgument.LongName);
				stringBuilder.Append(">");
				stringBuilder.Append(Environment.NewLine);
			}
			return stringBuilder.ToString();
		}
	}

	public CommandLineArgumentParser(Type argumentSpecification, ErrorReporter reporter)
	{
		this.reporter = reporter;
		arguments = new ArrayList();
		argumentMap = new Hashtable();
		FieldInfo[] fields = argumentSpecification.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			if (!fieldInfo.IsStatic && !fieldInfo.IsInitOnly && !fieldInfo.IsLiteral)
			{
				CommandLineArgumentAttribute attribute = GetAttribute(fieldInfo);
				if (attribute is DefaultCommandLineArgumentAttribute)
				{
					defaultArgument = new Argument(attribute, fieldInfo, reporter);
				}
				else
				{
					arguments.Add(new Argument(attribute, fieldInfo, reporter));
				}
			}
		}
		foreach (Argument argument3 in arguments)
		{
			argumentMap[argument3.LongName.ToLower()] = argument3;
			if (argument3.ExplicitShortName && argument3.ShortName != null && argument3.ShortName.Length > 0)
			{
				argumentMap[argument3.ShortName.ToLower()] = argument3;
			}
		}
		foreach (Argument argument4 in arguments)
		{
			if (!argument4.ExplicitShortName && argument4.ShortName != null && argument4.ShortName.Length > 0 && !argumentMap.ContainsKey(argument4.ShortName.ToLower()))
			{
				argumentMap[argument4.ShortName.ToLower()] = argument4;
			}
		}
	}

	private static CommandLineArgumentAttribute GetAttribute(FieldInfo field)
	{
		object[] customAttributes = field.GetCustomAttributes(typeof(CommandLineArgumentAttribute), inherit: false);
		if (customAttributes.Length == 1)
		{
			return (CommandLineArgumentAttribute)customAttributes[0];
		}
		return null;
	}

	private void ReportUnrecognizedArgument(string argument)
	{
		reporter($"Unrecognized command line argument '{argument}'");
	}

	private bool ParseArgumentList(string[] args, object destination)
	{
		bool flag = false;
		if (args != null)
		{
			int num = args.Length;
			for (int i = 0; i < num; i++)
			{
				string text = args[i];
				if (text == null)
				{
					continue;
				}
				string text2 = text.ToLower();
				if (text.Length <= 0)
				{
					continue;
				}
				switch (text[0])
				{
				case '@':
				{
					flag = (flag |= LexFileArguments(text.Substring(1), out var args2)) | ParseArgumentList(args2, destination);
					break;
				}
				default:
					if (defaultArgument != null)
					{
						flag |= !defaultArgument.SetValue(text2, destination);
						break;
					}
					ReportUnrecognizedArgument(text);
					flag = true;
					break;
				case '-':
				case '/':
				{
					int num2 = text2.IndexOfAny(new char[3] { ':', '+', '-' }, 1);
					string text3 = text2.Substring(1, (num2 == -1) ? (text.Length - 1) : (num2 - 1));
					string text4;
					if (text.Length > 1 + text3.Length && text[1 + text3.Length] == ':')
					{
						text4 = text.Substring(text3.Length + 2);
					}
					else if (num2 == -1)
					{
						if (i + 1 < num)
						{
							text4 = args[i + 1];
							switch (text4[0])
							{
							default:
								i++;
								break;
							case '+':
							case '-':
							case ':':
								text4 = null;
								break;
							}
						}
						else
						{
							text4 = "";
						}
					}
					else
					{
						text4 = text.Substring(text3.Length + 1);
					}
					Argument argument = (Argument)argumentMap[text3.ToLower()];
					if (argument == null)
					{
						ReportUnrecognizedArgument(text);
						flag = true;
					}
					else
					{
						flag |= !argument.SetValue(text4, destination);
					}
					break;
				}
				}
			}
		}
		return flag;
	}

	public bool Parse(string[] args, object destination)
	{
		bool flag = ParseArgumentList(args, destination);
		foreach (Argument argument in arguments)
		{
			flag |= argument.Finish(destination);
		}
		if (defaultArgument != null)
		{
			flag |= defaultArgument.Finish(destination);
		}
		return !flag;
	}

	private static int IndentLength(int lineLength)
	{
		return Math.Max(4, 40 - lineLength);
	}

	private bool LexFileArguments(string fileName, out string[] arguments)
	{
		string text = null;
		try
		{
			using FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			text = new StreamReader(stream).ReadToEnd();
		}
		catch (Exception ex)
		{
			reporter($"Error: Can't open command line argument file '{fileName}' : '{ex.Message}'");
			arguments = null;
			return false;
		}
		bool result = false;
		ArrayList arrayList = new ArrayList();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		int i = 0;
		try
		{
			while (true)
			{
				if (char.IsWhiteSpace(text[i]))
				{
					i++;
					continue;
				}
				if (text[i] == '#')
				{
					for (i++; text[i] != '\n'; i++)
					{
					}
					continue;
				}
				do
				{
					if (text[i] != '\\')
					{
						if (text[i] == '"')
						{
							flag = !flag;
							i++;
						}
						else
						{
							stringBuilder.Append(text[i]);
							i++;
						}
						continue;
					}
					int num = 1;
					i++;
					while (i == text.Length && text[i] == '\\')
					{
						num++;
					}
					if (i != text.Length && text[i] == '"')
					{
						stringBuilder.Append('\\', num >> 1);
						if (((uint)num & (true ? 1u : 0u)) != 0)
						{
							stringBuilder.Append('"');
						}
						else
						{
							flag = !flag;
						}
					}
					else
					{
						stringBuilder.Append('\\', num);
					}
				}
				while (!char.IsWhiteSpace(text[i]) || flag);
				arrayList.Add(stringBuilder.ToString());
				stringBuilder.Length = 0;
			}
		}
		catch (IndexOutOfRangeException)
		{
			if (flag)
			{
				reporter($"Error: Unbalanced '\"' in command line argument file '{fileName}'");
				result = true;
			}
			else if (stringBuilder.Length > 0)
			{
				arrayList.Add(stringBuilder.ToString());
			}
		}
		arguments = (string[])arrayList.ToArray(typeof(string));
		return result;
	}

	private static string LongName(CommandLineArgumentAttribute attribute, FieldInfo field)
	{
		if (attribute != null && !attribute.DefaultLongName)
		{
			return attribute.LongName;
		}
		return field.Name;
	}

	private static string ShortName(CommandLineArgumentAttribute attribute, FieldInfo field)
	{
		if (ExplicitShortName(attribute))
		{
			return attribute.ShortName;
		}
		return LongName(attribute, field).Substring(0, 1);
	}

	private static bool ExplicitShortName(CommandLineArgumentAttribute attribute)
	{
		if (attribute != null)
		{
			return !attribute.DefaultShortName;
		}
		return false;
	}

	private static Type ElementType(FieldInfo field)
	{
		if (IsCollectionType(field.FieldType))
		{
			return field.FieldType.GetElementType();
		}
		return null;
	}

	private static CommandLineArgumentType Flags(CommandLineArgumentAttribute attribute, FieldInfo field)
	{
		if (attribute != null)
		{
			return attribute.Type;
		}
		if (IsCollectionType(field.FieldType))
		{
			return CommandLineArgumentType.MultipleUnique;
		}
		return CommandLineArgumentType.AtMostOnce;
	}

	private static bool IsCollectionType(Type type)
	{
		return type.IsArray;
	}

	private static bool IsValidElementType(Type type)
	{
		if ((object)type != null)
		{
			if ((object)type != typeof(int) && (object)type != typeof(uint) && (object)type != typeof(string) && (object)type != typeof(bool))
			{
				return type.IsEnum;
			}
			return true;
		}
		return false;
	}
}
