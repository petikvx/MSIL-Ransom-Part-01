using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf;

public sealed class JsonFormatter
{
	public sealed class Settings
	{
		public static Settings Default { get; }

		public bool FormatDefaultValues { get; }

		public TypeRegistry TypeRegistry { get; }

		public bool FormatEnumsAsIntegers { get; }

		static Settings()
		{
			Default = new Settings(formatDefaultValues: false);
		}

		public Settings(bool formatDefaultValues)
			: this(formatDefaultValues, TypeRegistry.Empty)
		{
		}

		public Settings(bool formatDefaultValues, TypeRegistry typeRegistry)
			: this(formatDefaultValues, typeRegistry, formatEnumsAsIntegers: false)
		{
		}

		private Settings(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers)
		{
			FormatDefaultValues = formatDefaultValues;
			TypeRegistry = typeRegistry ?? TypeRegistry.Empty;
			FormatEnumsAsIntegers = formatEnumsAsIntegers;
		}

		public Settings WithFormatDefaultValues(bool formatDefaultValues)
		{
			return new Settings(formatDefaultValues, TypeRegistry, FormatEnumsAsIntegers);
		}

		public Settings WithTypeRegistry(TypeRegistry typeRegistry)
		{
			return new Settings(FormatDefaultValues, typeRegistry, FormatEnumsAsIntegers);
		}

		public Settings WithFormatEnumsAsIntegers(bool formatEnumsAsIntegers)
		{
			return new Settings(FormatDefaultValues, TypeRegistry, formatEnumsAsIntegers);
		}
	}

	private static class OriginalEnumValueHelper
	{
		private static readonly Dictionary<System.Type, Dictionary<object, string>> dictionaries;

		[NonSerialized]
		internal static GetString getString_0;

		internal static string GetOriginalName(object value)
		{
			System.Type type = value.GetType();
			Dictionary<object, string> value2;
			lock (dictionaries)
			{
				if (!dictionaries.TryGetValue(type, out value2))
				{
					value2 = GetNameMapping(type);
					dictionaries[type] = value2;
				}
			}
			value2.TryGetValue(value, out var value3);
			return value3;
		}

		private static Dictionary<object, string> GetNameMapping(System.Type enumType)
		{
			return (from f in enumType.GetTypeInfo().DeclaredFields
				where f.IsStatic
				where f.GetCustomAttributes<OriginalNameAttribute>().FirstOrDefault()?.PreferredAlias ?? true
				select f).ToDictionary((FieldInfo f) => f.GetValue(null), delegate(FieldInfo f)
			{
				OriginalNameAttribute? originalNameAttribute = f.GetCustomAttributes<OriginalNameAttribute>().FirstOrDefault();
				object obj;
				if (originalNameAttribute == null)
				{
					obj = null;
				}
				else
				{
					obj = originalNameAttribute!.Name;
					if (obj != null)
					{
						goto IL_0021;
					}
				}
				obj = f.Name;
				goto IL_0021;
				IL_0021:
				return (string)obj;
			});
		}

		static OriginalEnumValueHelper()
		{
			Strings.CreateGetStringDelegate(typeof(OriginalEnumValueHelper));
			bool bool_ = false;
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399756), getString_0(107399751)).Replace(getString_0(107399714), getString_0(107399709)));
			if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399704)))
			{
				throw new SecurityException(getString_0(107399679));
			}
			dictionaries = new Dictionary<System.Type, Dictionary<object, string>>();
		}

		[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
	}

	internal const string AnyTypeUrlField = "@type";

	internal const string AnyDiagnosticValueField = "@value";

	internal const string AnyWellKnownTypeValueField = "value";

	private const string TypeUrlPrefix = "type.googleapis.com";

	private const string NameValueSeparator = ": ";

	private const string PropertySeparator = ", ";

	private static readonly JsonFormatter diagnosticFormatter;

	private static readonly string[] CommonRepresentations;

	private readonly Settings settings;

	private const string Hex = "0123456789abcdef";

	[NonSerialized]
	internal static GetString getString_0;

	public static JsonFormatter Default { get; }

	private bool DiagnosticOnly => this == diagnosticFormatter;

	static JsonFormatter()
	{
		Strings.CreateGetStringDelegate(typeof(JsonFormatter));
		Default = new JsonFormatter(Settings.Default);
		diagnosticFormatter = new JsonFormatter(Settings.Default);
		CommonRepresentations = new string[160]
		{
			getString_0(107368240),
			getString_0(107368231),
			getString_0(107368190),
			getString_0(107368181),
			getString_0(107368204),
			getString_0(107368195),
			getString_0(107368154),
			getString_0(107368145),
			getString_0(107368168),
			getString_0(107368163),
			getString_0(107368126),
			getString_0(107368121),
			getString_0(107368144),
			getString_0(107368139),
			getString_0(107368134),
			getString_0(107368093),
			getString_0(107368084),
			getString_0(107368107),
			getString_0(107368098),
			getString_0(107367545),
			getString_0(107367568),
			getString_0(107367559),
			getString_0(107367518),
			getString_0(107367509),
			getString_0(107367532),
			getString_0(107367523),
			getString_0(107367482),
			getString_0(107367473),
			getString_0(107367496),
			getString_0(107367455),
			getString_0(107367446),
			getString_0(107367469),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107367460),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107367423),
			getString_0(107399572),
			getString_0(107367414),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107357720),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107399572),
			getString_0(107367437),
			getString_0(107367428),
			getString_0(107367387),
			getString_0(107367378),
			getString_0(107367401),
			getString_0(107367360),
			getString_0(107367351),
			getString_0(107367374),
			getString_0(107367365),
			getString_0(107367324),
			getString_0(107367315),
			getString_0(107367338),
			getString_0(107367329),
			getString_0(107367800),
			getString_0(107367823),
			getString_0(107367814),
			getString_0(107367773),
			getString_0(107367764),
			getString_0(107367787),
			getString_0(107367778),
			getString_0(107367737),
			getString_0(107367760),
			getString_0(107367751),
			getString_0(107367710),
			getString_0(107367701),
			getString_0(107367724),
			getString_0(107367715),
			getString_0(107367674),
			getString_0(107367665),
			getString_0(107367688),
			getString_0(107367647),
			getString_0(107367638),
			getString_0(107367661)
		};
		for (int i = 0; i < CommonRepresentations.Length; i++)
		{
			if (CommonRepresentations[i] == getString_0(107399572))
			{
				CommonRepresentations[i] = ((char)i).ToString();
			}
		}
	}

	public JsonFormatter(Settings settings)
	{
		this.settings = settings;
	}

	public string Format(IMessage message)
	{
		StringWriter stringWriter = new StringWriter();
		Format(message, stringWriter);
		return stringWriter.ToString();
	}

	public void Format(IMessage message, TextWriter writer)
	{
		ProtoPreconditions.CheckNotNull(message, getString_0(107367652));
		ProtoPreconditions.CheckNotNull(writer, getString_0(107367607));
		if (message.Descriptor.IsWellKnownType)
		{
			WriteWellKnownTypeValue(writer, message.Descriptor, message);
		}
		else
		{
			WriteMessage(writer, message);
		}
	}

	public static string ToDiagnosticString(IMessage message)
	{
		ProtoPreconditions.CheckNotNull(message, getString_0(107367652));
		return diagnosticFormatter.Format(message);
	}

	private void WriteMessage(TextWriter writer, IMessage message)
	{
		if (message == null)
		{
			WriteNull(writer);
			return;
		}
		if (DiagnosticOnly && message is ICustomDiagnosticMessage customDiagnosticMessage)
		{
			writer.Write(customDiagnosticMessage.ToDiagnosticString());
			return;
		}
		writer.Write(getString_0(107367630));
		bool flag = WriteMessageFields(writer, message, assumeFirstFieldWritten: false);
		writer.Write(flag ? getString_0(107367625) : getString_0(107410685));
	}

	private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten)
	{
		MessageDescriptor.FieldCollection fields = message.Descriptor.Fields;
		bool flag = !assumeFirstFieldWritten;
		foreach (FieldDescriptor item in fields.InFieldNumberOrder())
		{
			IFieldAccessor accessor = item.Accessor;
			if (item.ContainingOneof != null && item.ContainingOneof.Accessor.GetCaseFieldDescriptor(message) != item)
			{
				continue;
			}
			object value = accessor.GetValue(message);
			if (item.ContainingOneof != null || settings.FormatDefaultValues || !IsDefaultValue(accessor, value))
			{
				if (!flag)
				{
					writer.Write(getString_0(107410722));
				}
				WriteString(writer, accessor.Descriptor.JsonName);
				writer.Write(getString_0(107367620));
				WriteValue(writer, value);
				flag = false;
			}
		}
		return !flag;
	}

	internal static string ToJsonName(string name)
	{
		StringBuilder stringBuilder = new StringBuilder(name.Length);
		bool flag = false;
		foreach (char c in name)
		{
			if (c == '_')
			{
				flag = true;
			}
			else if (flag)
			{
				stringBuilder.Append(char.ToUpperInvariant(c));
				flag = false;
			}
			else
			{
				stringBuilder.Append(c);
			}
		}
		return stringBuilder.ToString();
	}

	private static void WriteNull(TextWriter writer)
	{
		writer.Write(getString_0(107410731));
	}

	private static bool IsDefaultValue(IFieldAccessor accessor, object value)
	{
		if (accessor.Descriptor.IsMap)
		{
			return ((IDictionary)value).Count == 0;
		}
		if (accessor.Descriptor.IsRepeated)
		{
			return ((IList)value).Count == 0;
		}
		switch (accessor.Descriptor.FieldType)
		{
		default:
			throw new ArgumentException(getString_0(107367583));
		case FieldType.Double:
			return (double)value == 0.0;
		case FieldType.Float:
			return (float)value == 0f;
		case FieldType.UInt64:
		case FieldType.Fixed64:
			return (ulong)value == 0L;
		case FieldType.Bool:
			return !(bool)value;
		case FieldType.String:
			return (string)value == getString_0(107399572);
		case FieldType.Group:
		case FieldType.Message:
			return value == null;
		case FieldType.Bytes:
			return (ByteString)value == ByteString.Empty;
		case FieldType.Fixed32:
		case FieldType.UInt32:
			return (uint)value == 0;
		case FieldType.Int64:
		case FieldType.SFixed64:
		case FieldType.SInt64:
			return (long)value == 0L;
		case FieldType.Int32:
		case FieldType.SFixed32:
		case FieldType.SInt32:
		case FieldType.Enum:
			return (int)value == 0;
		}
	}

	public void WriteValue(TextWriter writer, object value)
	{
		if (value == null)
		{
			WriteNull(writer);
		}
		else if (value is bool)
		{
			writer.Write(((bool)value) ? getString_0(107411136) : getString_0(107407977));
		}
		else if (value is ByteString)
		{
			writer.Write('"');
			writer.Write(((ByteString)value).ToBase64());
			writer.Write('"');
		}
		else if (value is string)
		{
			WriteString(writer, (string)value);
		}
		else if (value is IDictionary)
		{
			WriteDictionary(writer, (IDictionary)value);
		}
		else if (value is IList)
		{
			WriteList(writer, (IList)value);
		}
		else if (!(value is int) && !(value is uint))
		{
			if (!(value is long) && !(value is ulong))
			{
				if (value is System.Enum)
				{
					if (settings.FormatEnumsAsIntegers)
					{
						WriteValue(writer, (int)value);
						return;
					}
					string originalName = OriginalEnumValueHelper.GetOriginalName(value);
					if (originalName != null)
					{
						WriteString(writer, originalName);
					}
					else
					{
						WriteValue(writer, (int)value);
					}
				}
				else if (!(value is float) && !(value is double))
				{
					if (!(value is IMessage))
					{
						throw new ArgumentException(getString_0(107465346) + value.GetType());
					}
					Format((IMessage)value, writer);
				}
				else
				{
					string text = ((IFormattable)value).ToString(getString_0(107367590), CultureInfo.InvariantCulture);
					if (!(text == getString_0(107367585)) && !(text == getString_0(107465340)) && !(text == getString_0(107465359)))
					{
						writer.Write(text);
						return;
					}
					writer.Write('"');
					writer.Write(text);
					writer.Write('"');
				}
			}
			else
			{
				writer.Write('"');
				IFormattable formattable = (IFormattable)value;
				writer.Write(formattable.ToString(getString_0(107359676), CultureInfo.InvariantCulture));
				writer.Write('"');
			}
		}
		else
		{
			IFormattable formattable2 = (IFormattable)value;
			writer.Write(formattable2.ToString(getString_0(107359676), CultureInfo.InvariantCulture));
		}
	}

	private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value)
	{
		if (value == null)
		{
			WriteNull(writer);
		}
		else if (descriptor.IsWrapperType)
		{
			if (value is IMessage)
			{
				IMessage message = (IMessage)value;
				value = message.Descriptor.Fields[1].Accessor.GetValue(message);
			}
			WriteValue(writer, value);
		}
		else if (descriptor.FullName == Timestamp.Descriptor.FullName)
		{
			WriteTimestamp(writer, (IMessage)value);
		}
		else if (descriptor.FullName == Duration.Descriptor.FullName)
		{
			WriteDuration(writer, (IMessage)value);
		}
		else if (descriptor.FullName == FieldMask.Descriptor.FullName)
		{
			WriteFieldMask(writer, (IMessage)value);
		}
		else if (descriptor.FullName == Struct.Descriptor.FullName)
		{
			WriteStruct(writer, (IMessage)value);
		}
		else if (descriptor.FullName == ListValue.Descriptor.FullName)
		{
			IFieldAccessor accessor = descriptor.Fields[1].Accessor;
			WriteList(writer, (IList)accessor.GetValue((IMessage)value));
		}
		else if (descriptor.FullName == Value.Descriptor.FullName)
		{
			WriteStructFieldValue(writer, (IMessage)value);
		}
		else if (descriptor.FullName == Any.Descriptor.FullName)
		{
			WriteAny(writer, (IMessage)value);
		}
		else
		{
			WriteMessage(writer, (IMessage)value);
		}
	}

	private void WriteTimestamp(TextWriter writer, IMessage value)
	{
		int nanoseconds = (int)value.Descriptor.Fields[2].Accessor.GetValue(value);
		long seconds = (long)value.Descriptor.Fields[1].Accessor.GetValue(value);
		writer.Write(Timestamp.ToJson(seconds, nanoseconds, DiagnosticOnly));
	}

	private void WriteDuration(TextWriter writer, IMessage value)
	{
		int nanoseconds = (int)value.Descriptor.Fields[2].Accessor.GetValue(value);
		long seconds = (long)value.Descriptor.Fields[1].Accessor.GetValue(value);
		writer.Write(Duration.ToJson(seconds, nanoseconds, DiagnosticOnly));
	}

	private void WriteFieldMask(TextWriter writer, IMessage value)
	{
		IList<string> paths = (IList<string>)value.Descriptor.Fields[1].Accessor.GetValue(value);
		writer.Write(FieldMask.ToJson(paths, DiagnosticOnly));
	}

	private void WriteAny(TextWriter writer, IMessage value)
	{
		if (DiagnosticOnly)
		{
			WriteDiagnosticOnlyAny(writer, value);
			return;
		}
		string text = (string)value.Descriptor.Fields[1].Accessor.GetValue(value);
		ByteString data = (ByteString)value.Descriptor.Fields[2].Accessor.GetValue(value);
		string typeName = Any.GetTypeName(text);
		MessageDescriptor messageDescriptor = settings.TypeRegistry.Find(typeName);
		if (messageDescriptor == null)
		{
			throw new InvalidOperationException(string.Format(getString_0(107465269), typeName));
		}
		IMessage message = messageDescriptor.Parser.ParseFrom(data);
		writer.Write(getString_0(107367630));
		WriteString(writer, getString_0(107465232));
		writer.Write(getString_0(107367620));
		WriteString(writer, text);
		if (messageDescriptor.IsWellKnownType)
		{
			writer.Write(getString_0(107410722));
			WriteString(writer, getString_0(107394525));
			writer.Write(getString_0(107367620));
			WriteWellKnownTypeValue(writer, messageDescriptor, message);
		}
		else
		{
			WriteMessageFields(writer, message, assumeFirstFieldWritten: true);
		}
		writer.Write(getString_0(107367625));
	}

	private void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value)
	{
		string text = (string)value.Descriptor.Fields[1].Accessor.GetValue(value);
		ByteString byteString = (ByteString)value.Descriptor.Fields[2].Accessor.GetValue(value);
		writer.Write(getString_0(107367630));
		WriteString(writer, getString_0(107465232));
		writer.Write(getString_0(107367620));
		WriteString(writer, text);
		writer.Write(getString_0(107410722));
		WriteString(writer, getString_0(107465223));
		writer.Write(getString_0(107367620));
		writer.Write('"');
		writer.Write(byteString.ToBase64());
		writer.Write('"');
		writer.Write(getString_0(107367625));
	}

	private void WriteStruct(TextWriter writer, IMessage message)
	{
		writer.Write(getString_0(107367630));
		IDictionary obj = (IDictionary)message.Descriptor.Fields[1].Accessor.GetValue(message);
		bool flag = true;
		foreach (DictionaryEntry item in obj)
		{
			string text = (string)item.Key;
			IMessage message2 = (IMessage)item.Value;
			if (!string.IsNullOrEmpty(text) && message2 != null)
			{
				if (!flag)
				{
					writer.Write(getString_0(107410722));
				}
				WriteString(writer, text);
				writer.Write(getString_0(107367620));
				WriteStructFieldValue(writer, message2);
				flag = false;
				continue;
			}
			throw new InvalidOperationException(getString_0(107465182));
		}
		writer.Write(flag ? getString_0(107410685) : getString_0(107367625));
	}

	private void WriteStructFieldValue(TextWriter writer, IMessage message)
	{
		FieldDescriptor caseFieldDescriptor = message.Descriptor.Oneofs[0].Accessor.GetCaseFieldDescriptor(message);
		if (caseFieldDescriptor == null)
		{
			throw new InvalidOperationException(getString_0(107465105));
		}
		object value = caseFieldDescriptor.Accessor.GetValue(message);
		switch (caseFieldDescriptor.FieldNumber)
		{
		default:
			throw new InvalidOperationException(getString_0(107465580) + caseFieldDescriptor.FieldNumber);
		case 1:
			WriteNull(writer);
			break;
		case 2:
		case 3:
		case 4:
			WriteValue(writer, value);
			break;
		case 5:
		case 6:
		{
			IMessage message2 = (IMessage)caseFieldDescriptor.Accessor.GetValue(message);
			WriteWellKnownTypeValue(writer, message2.Descriptor, message2);
			break;
		}
		}
	}

	internal void WriteList(TextWriter writer, IList list)
	{
		writer.Write(getString_0(107465503));
		bool flag = true;
		foreach (object item in list)
		{
			if (!flag)
			{
				writer.Write(getString_0(107410722));
			}
			WriteValue(writer, item);
			flag = false;
		}
		writer.Write(flag ? getString_0(107411318) : getString_0(107465498));
	}

	internal void WriteDictionary(TextWriter writer, IDictionary dictionary)
	{
		writer.Write(getString_0(107367630));
		bool flag = true;
		foreach (DictionaryEntry item in dictionary)
		{
			if (!flag)
			{
				writer.Write(getString_0(107410722));
			}
			string text;
			if (item.Key is string)
			{
				text = (string)item.Key;
			}
			else if (item.Key is bool)
			{
				text = (((bool)item.Key) ? getString_0(107411136) : getString_0(107407977));
			}
			else
			{
				if (!(item.Key is int) && !((item.Key is uint) | (item.Key is long)) && !(item.Key is ulong))
				{
					if (item.Key == null)
					{
						throw new ArgumentException(getString_0(107465493));
					}
					throw new ArgumentException(getString_0(107465476) + item.Key.GetType());
				}
				text = ((IFormattable)item.Key).ToString(getString_0(107359676), CultureInfo.InvariantCulture);
			}
			WriteString(writer, text);
			writer.Write(getString_0(107367620));
			WriteValue(writer, item.Value);
			flag = false;
		}
		writer.Write(flag ? getString_0(107410685) : getString_0(107367625));
	}

	internal static void WriteString(TextWriter writer, string text)
	{
		writer.Write('"');
		for (int i = 0; i < text.Length; i++)
		{
			char c = text[i];
			if (c < '\u00a0')
			{
				writer.Write(CommonRepresentations[(uint)c]);
				continue;
			}
			if (char.IsHighSurrogate(c))
			{
				i++;
				if (i != text.Length && char.IsLowSurrogate(text[i]))
				{
					HexEncodeUtf16CodeUnit(writer, c);
					HexEncodeUtf16CodeUnit(writer, text[i]);
					continue;
				}
				throw new ArgumentException(getString_0(107465399));
			}
			if (!char.IsLowSurrogate(c))
			{
				switch (c)
				{
				case '\u00ad':
				case '\u06dd':
				case '\u070f':
				case '\u17b4':
				case '\u17b5':
				case '\ufeff':
				case '\ufff9':
				case '\ufffa':
				case '\ufffb':
					HexEncodeUtf16CodeUnit(writer, c);
					continue;
				}
				if ((c >= '\u0600' && c <= '\u0603') || (c >= '\u200b' && c <= '\u200f') || (c >= '\u2028' && c <= '\u202e') || (c >= '\u2060' && c <= '\u2064') || (c >= '\u206a' && c <= '\u206f'))
				{
					HexEncodeUtf16CodeUnit(writer, c);
				}
				else
				{
					writer.Write(c);
				}
				continue;
			}
			throw new ArgumentException(getString_0(107464838));
		}
		writer.Write('"');
	}

	private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c)
	{
		writer.Write(getString_0(107464725));
		writer.Write(getString_0(107464752)[((int)c >> 12) & 0xF]);
		writer.Write(getString_0(107464752)[((int)c >> 8) & 0xF]);
		writer.Write(getString_0(107464752)[((int)c >> 4) & 0xF]);
		writer.Write(getString_0(107464752)[c & 0xF]);
	}
}
