using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Linq.JsonPath;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns19;
using ns2;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;

namespace ns9;

internal class Class7
{
	static Type smethod_0(Class29 class29_0)
	{
		JsonToken tokenType = class29_0.TokenType;
		switch (tokenType)
		{
		case JsonToken.StartArray:
			Class7.smethod_686(class29_0);
			if (class29_0.TokenType == JsonToken.StartObject)
			{
				return typeof(DataTable);
			}
			return Class7.smethod_0(class29_0).MakeArrayType();
		case JsonToken.Null:
		case JsonToken.Undefined:
		case JsonToken.EndArray:
			return typeof(string);
		default:
			throw Class7.smethod_161(class29_0, "Unexpected JSON token when reading DataTable: {0}".smethod_1(CultureInfo.InvariantCulture, tokenType));
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Date:
		case JsonToken.Bytes:
			return class29_0.ValueType;
		}
	}

	static string smethod_1(XmlNamespaceManager xmlNamespaceManager_0, Interface11 interface11_0, Class27 class27_0)
	{
		switch (interface11_0.NodeType)
		{
		case XmlNodeType.Element:
			if (interface11_0.NamespaceUri == "http://james.newtonking.com/projects/json")
			{
				return "$" + interface11_0.LocalName;
			}
			return Class7.smethod_736(class27_0, interface11_0, xmlNamespaceManager_0);
		case XmlNodeType.Attribute:
			if (interface11_0.NamespaceUri == "http://james.newtonking.com/projects/json")
			{
				return "$" + interface11_0.LocalName;
			}
			return "@" + Class7.smethod_736(class27_0, interface11_0, xmlNamespaceManager_0);
		case XmlNodeType.Text:
			return "#text";
		case XmlNodeType.CDATA:
			return "#cdata-section";
		case XmlNodeType.ProcessingInstruction:
			return "?" + Class7.smethod_736(class27_0, interface11_0, xmlNamespaceManager_0);
		case XmlNodeType.Comment:
			return "#comment";
		case XmlNodeType.DocumentType:
			return "!" + Class7.smethod_736(class27_0, interface11_0, xmlNamespaceManager_0);
		case XmlNodeType.Whitespace:
			return "#whitespace";
		case XmlNodeType.SignificantWhitespace:
			return "#significant-whitespace";
		default:
			throw new JsonSerializationException("Unexpected XmlNodeType when getting node name: " + interface11_0.NodeType);
		case XmlNodeType.XmlDeclaration:
			return "?xml";
		}
	}

	static bool smethod_2(Class30 class30_0, char char_0)
	{
		if (!char.IsLetterOrDigit(char_0) && char_0 != '_')
		{
			return char_0 == '$';
		}
		return true;
	}

	static void smethod_3(JsonSchemaModel jsonSchemaModel_0, JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonSchemaModel_0 != null && Class7.smethod_238(jsonValidatingReader_0, jsonSchemaModel_0, JsonSchemaType.Boolean))
		{
			Class7.smethod_589(jsonValidatingReader_0, jsonSchemaModel_0);
		}
	}

	static bool smethod_4(Class33 class33_0)
	{
		switch (class33_0.state_0)
		{
		case Class29.State.Property:
			Class7.smethod_417(class33_0, class33_0.bsonType_0);
			return true;
		default:
			throw new ArgumentOutOfRangeException();
		case Class29.State.Complete:
		case Class29.State.Closed:
			return false;
		case Class29.State.ObjectStart:
		case Class29.State.ArrayStart:
		case Class29.State.PostValue:
		{
			Class33.Class241 class241_ = class33_0.class241_0;
			if (class241_ == null)
			{
				if (!class33_0.SupportMultipleContent)
				{
					return false;
				}
				goto case Class29.State.Start;
			}
			int num = class241_.int_0 - 1;
			if (class241_.int_1 < num)
			{
				if (class241_.bsonType_0 == BsonType.Array)
				{
					Class7.smethod_650(class33_0);
					Class7.smethod_417(class33_0, class33_0.bsonType_0);
					return true;
				}
				Class7.smethod_186((Class29)class33_0, JsonToken.PropertyName, (object)Class7.smethod_650(class33_0));
				return true;
			}
			if (class241_.int_1 == num)
			{
				if (Class7.smethod_136(class33_0) != 0)
				{
					throw Class7.smethod_555((Class29)class33_0, "Unexpected end of object byte value.");
				}
				Class7.smethod_652(class33_0);
				if (class33_0.class241_0 != null)
				{
					Class7.smethod_452(class33_0, class241_.int_0);
				}
				JsonToken jsonToken_ = ((class241_.bsonType_0 == BsonType.Object) ? JsonToken.EndObject : JsonToken.EndArray);
				Class7.smethod_386((Class29)class33_0, jsonToken_);
				return true;
			}
			throw Class7.smethod_555((Class29)class33_0, "Read past end of current container context.");
		}
		case Class29.State.Start:
		{
			JsonToken jsonToken_2 = ((!class33_0.bool_3) ? JsonToken.StartObject : JsonToken.StartArray);
			int bsonType_ = ((!class33_0.bool_3) ? 3 : 4);
			Class7.smethod_386((Class29)class33_0, jsonToken_2);
			Class33.Class241 @class = new Class33.Class241((BsonType)bsonType_);
			Class7.smethod_170(class33_0, @class);
			@class.int_0 = Class7.smethod_532(class33_0);
			return true;
		}
		case Class29.State.ConstructorStart:
		case Class29.State.Constructor:
		case Class29.State.Error:
		case Class29.State.Finished:
			return false;
		}
	}

	static string? smethod_5(ulong ulong_0, Class77 class77_0)
	{
		string[] string_ = class77_0.string_1;
		ulong[] ulong_ = class77_0.ulong_0;
		int num = ulong_.Length - 1;
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		ulong num2 = ulong_0;
		while (num >= 0 && (num != 0 || ulong_[num] != 0L))
		{
			if ((ulong_0 & ulong_[num]) == ulong_[num])
			{
				ulong_0 -= ulong_[num];
				if (!flag)
				{
					stringBuilder.Insert(0, ", ");
				}
				string value = string_[num];
				stringBuilder.Insert(0, value);
				flag = false;
			}
			num--;
		}
		if (ulong_0 != 0L)
		{
			return null;
		}
		if (num2 == 0L)
		{
			if (ulong_.Length != 0 && ulong_[0] == 0L)
			{
				return string_[0];
			}
			return null;
		}
		return stringBuilder.ToString();
	}

	static IEnumerable<object> smethod_6(JToken jtoken_0, Type type_0)
	{
		return new JToken.Class186(-2)
		{
			jtoken_0 = jtoken_0,
			type_1 = type_0
		};
	}

	static void smethod_7(ILGenerator ilgenerator_0, PropertyInfo propertyInfo_0)
	{
		MethodInfo setMethod = propertyInfo_0.GetSetMethod(nonPublic: true);
		if (!setMethod.IsStatic)
		{
			ilgenerator_0.smethod_0(propertyInfo_0.DeclaringType);
		}
		ilgenerator_0.Emit(OpCodes.Ldarg_1);
		ilgenerator_0.smethod_3(propertyInfo_0.PropertyType);
		ilgenerator_0.smethod_4(setMethod);
		ilgenerator_0.smethod_5();
	}

	static void smethod_8(Class152 class152_0, Class38 class38_0, object object_0, Class145? class145_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty jsonProperty_1)
	{
		if (class145_0!.TypeCode == Enum21.const_40 && class152_0.method_10(Enum19.flag_1, class145_0, jsonProperty_0, class138_0, jsonProperty_1))
		{
			class38_0.vmethod_3();
			Class7.smethod_492(class145_0!.type_1, class152_0, class38_0);
			class38_0.vmethod_10("$value", bool_2: false);
			Class7.smethod_491(class38_0, class145_0!.TypeCode, object_0);
			class38_0.vmethod_4();
		}
		else
		{
			Class7.smethod_491(class38_0, class145_0!.TypeCode, object_0);
		}
	}

	static bool smethod_9(JToken jtoken_0)
	{
		if (jtoken_0.Type == JTokenType.Null)
		{
			return true;
		}
		if (jtoken_0 is Class179 @class && @class.Value == null)
		{
			return true;
		}
		return false;
	}

	static bool smethod_10(Type type_0)
	{
		return typeof(IConvertible).IsAssignableFrom(type_0);
	}

	static Class115 smethod_11(Type type_0, object[]? object_0)
	{
		return (Class115)JsonTypeReflector.class111_0.method_0(type_0)(object_0);
	}

	static void smethod_12(int int_0, Class43 class43_0, int int_1, byte[] byte_0)
	{
		Class7.smethod_584(byte_0, class43_0, int_0, int_1);
		if (class43_0.int_2 > 0)
		{
			if (Class7.smethod_587(ref int_0, int_1, byte_0, class43_0))
			{
				return;
			}
			int int_2 = Convert.ToBase64CharArray(class43_0.byte_0, 0, 3, class43_0.char_0, 0);
			Class7.smethod_173(0, int_2, class43_0.char_0, class43_0);
		}
		Class7.smethod_741(class43_0, byte_0, int_1, ref int_0);
		int num = int_1 + int_0;
		int num2 = 57;
		while (int_1 < num)
		{
			if (int_1 + num2 > num)
			{
				num2 = num - int_1;
			}
			int int_3 = Convert.ToBase64CharArray(byte_0, int_1, num2, class43_0.char_0, 0);
			Class7.smethod_173(0, int_3, class43_0.char_0, class43_0);
			int_1 += num2;
		}
	}

	static Class44<string, object> smethod_13(Class131 class131_0, object object_0)
	{
		Class151 @class = object_0 as Class151;
		if (@class == null)
		{
			if (!(object_0 is Class35 class35_))
			{
				throw new JsonException("The DefaultReferenceResolver can only be used internally.");
			}
			@class = Class7.smethod_166(class35_);
		}
		return @class.DefaultReferenceMappings;
	}

	static object smethod_14(Enum8 enum8_0, Class30 class30_0, bool bool_0)
	{
		if (bool_0)
		{
			switch (enum8_0)
			{
			case Enum8.const_4:
				Class7.smethod_186((Class29)class30_0, JsonToken.String, (object)Class8.string_6);
				return Class8.string_6;
			case Enum8.const_0:
			case Enum8.const_8:
				if (class30_0.enum6_0 == Enum6.const_0)
				{
					Class7.smethod_186((Class29)class30_0, JsonToken.Float, (object)double.NaN);
					return double.NaN;
				}
				goto default;
			default:
				throw Class7.smethod_555((Class29)class30_0, "Cannot read NaN value.");
			}
		}
		throw Class7.smethod_555((Class29)class30_0, "Error parsing NaN value.");
	}

	static string smethod_15(string string_0, char char_0)
	{
		if (Class109.smethod_0(string_0))
		{
			return string_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		Class109.Enum25 @enum = Class109.Enum25.const_0;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == ' ')
			{
				if (@enum != 0)
				{
					@enum = Class109.Enum25.const_3;
				}
			}
			else if (char.IsUpper(string_0[i]))
			{
				switch (@enum)
				{
				case Class109.Enum25.const_2:
				{
					bool flag = i + 1 < string_0.Length;
					if (i > 0 && flag)
					{
						char c = string_0[i + 1];
						if (!char.IsUpper(c) && c != char_0)
						{
							stringBuilder.Append(char_0);
						}
					}
					break;
				}
				case Class109.Enum25.const_1:
				case Class109.Enum25.const_3:
					stringBuilder.Append(char_0);
					break;
				}
				char value = char.ToLower(string_0[i], CultureInfo.InvariantCulture);
				stringBuilder.Append(value);
				@enum = Class109.Enum25.const_2;
			}
			else if (string_0[i] == char_0)
			{
				stringBuilder.Append(char_0);
				@enum = Class109.Enum25.const_0;
			}
			else
			{
				if (@enum == Class109.Enum25.const_3)
				{
					stringBuilder.Append(char_0);
				}
				stringBuilder.Append(string_0[i]);
				@enum = Class109.Enum25.const_1;
			}
		}
		return stringBuilder.ToString();
	}

	static void smethod_16(Class172 class172_0, Class38 class38_0, JsonSchema jsonSchema_0)
	{
		Class113.smethod_0(class38_0, "writer");
		Class113.smethod_0(class172_0, "resolver");
		Class7.smethod_507(new JsonSchemaWriter(class38_0, class172_0), jsonSchema_0);
	}

	static IList smethod_17(Class29 class29_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, out bool bool_0, Class139 class139_0)
	{
		if (!class139_0.CanDeserialize)
		{
			throw Class7.smethod_161(class29_0, "Cannot create and populate list type {0}.".smethod_1(CultureInfo.InvariantCulture, class139_0.type_1));
		}
		if (class139_0.delegate7_2 != null)
		{
			if (class139_0.HasParameterizedCreator)
			{
				bool_0 = true;
				return class139_0.method_6();
			}
			object obj = class139_0.delegate7_2!();
			if (class139_0.ShouldCreateWrapper)
			{
				obj = class139_0.method_5(obj);
			}
			bool_0 = false;
			return (IList)obj;
		}
		if (class139_0.bool_3)
		{
			bool_0 = true;
			IList list = class139_0.method_6();
			if (class139_0.ShouldCreateWrapper)
			{
				list = class139_0.method_5(list);
			}
			return list;
		}
		if (class139_0.DefaultCreator != null && (!class139_0.DefaultCreatorNonPublic || jsonSerializerInternalReader_0.class34_0.enum0_0 == Enum0.const_1))
		{
			object obj2 = class139_0.DefaultCreator!();
			if (class139_0.ShouldCreateWrapper)
			{
				obj2 = class139_0.method_5(obj2);
			}
			bool_0 = false;
			return (IList)obj2;
		}
		if (!class139_0.HasParameterizedCreatorInternal)
		{
			if (!class139_0.bool_5)
			{
				throw Class7.smethod_161(class29_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_1(CultureInfo.InvariantCulture, class139_0.UnderlyingType));
			}
			throw Class7.smethod_161(class29_0, "Unable to find a constructor to use for type {0}.".smethod_1(CultureInfo.InvariantCulture, class139_0.UnderlyingType));
		}
		bool_0 = true;
		return class139_0.method_6();
	}

	static void smethod_18(Class152 class152_0, Class38 class38_0, IDictionary idictionary_0, Class140? class140_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty jsonProperty_1)
	{
		object obj = ((idictionary_0 is Interface3 @interface) ? @interface.UnderlyingDictionary : idictionary_0);
		Class7.smethod_246(class152_0, class38_0, (Class137)class140_0, obj);
		class152_0.list_0.Add(obj);
		Class7.smethod_282((Class137)class140_0, class38_0, obj, class152_0, jsonProperty_0, jsonProperty_1, class138_0);
		if (class140_0!.class137_0 == null)
		{
			class140_0!.ItemContract = class152_0.class34_0.interface4_0.imethod_0(class140_0!.DictionaryValueType ?? typeof(object));
		}
		if (class140_0!.KeyContract == null)
		{
			class140_0!.KeyContract = class152_0.class34_0.interface4_0.imethod_0(class140_0!.DictionaryKeyType ?? typeof(object));
		}
		int top = class38_0.Top;
		foreach (DictionaryEntry item in idictionary_0)
		{
			string text = class152_0.method_11(class38_0, item.Key, class140_0!.KeyContract, out var bool_);
			text = ((class140_0!.DictionaryKeyResolver != null) ? class140_0!.DictionaryKeyResolver!(text) : text);
			try
			{
				object value = item.Value;
				Class137 class137_ = class140_0!.class137_1 ?? class152_0.method_2(value);
				if (class152_0.method_5(value, null, class137_, class140_0, jsonProperty_0))
				{
					class38_0.vmethod_10(text, bool_);
					Class7.smethod_712(class38_0, class152_0, value);
				}
				else if (class152_0.method_7(class38_0, value, null, class137_, class140_0, jsonProperty_0))
				{
					class38_0.vmethod_10(text, bool_);
					class152_0.method_3(class38_0, value, class137_, null, class140_0, jsonProperty_0);
				}
			}
			catch (Exception exception_)
			{
				if (!class152_0.method_0(obj, class140_0, text, null, class38_0.ContainerPath, exception_))
				{
					throw;
				}
				Class7.smethod_176(top, class38_0, class152_0);
			}
		}
		class38_0.vmethod_4();
		class152_0.list_0.RemoveAt(class152_0.list_0.Count - 1);
		Class7.smethod_82(class38_0, class152_0, (Class137)class140_0, obj);
	}

	static object smethod_19(Class22 class22_0, Class29 class29_0)
	{
		IDictionary<string, object> dictionary = new ExpandoObject();
		while (class29_0.vmethod_0())
		{
			switch (class29_0.TokenType)
			{
			case JsonToken.PropertyName:
			{
				string key = class29_0.Value!.ToString();
				if (!class29_0.vmethod_0())
				{
					throw Class7.smethod_161(class29_0, "Unexpected end when reading ExpandoObject.");
				}
				object obj2 = (dictionary[key] = Class7.smethod_758(class22_0, class29_0));
				break;
			}
			case JsonToken.EndObject:
				return dictionary;
			}
		}
		throw Class7.smethod_161(class29_0, "Unexpected end when reading ExpandoObject.");
	}

	static Delegate3 smethod_20(MethodInfo methodInfo_0)
	{
		return new Class137.Class147
		{
			methodInfo_0 = methodInfo_0
		}.method_0;
	}

	static bool smethod_21(Type type_0, Type type_1, out Type? type_2)
	{
		do
		{
			if (!type_0.smethod_4() || !(type_1 == type_0.GetGenericTypeDefinition()))
			{
				type_0 = type_0.smethod_6();
				continue;
			}
			type_2 = type_0;
			return true;
		}
		while (type_0 != null);
		type_2 = null;
		return false;
	}

	static string smethod_22(Type type_0, Class167 class167_0)
	{
		Attribute5 attribute = JsonTypeReflector.smethod_0<Attribute5>(type_0);
		if (!Class109.smethod_0(attribute?.Title))
		{
			return attribute.Title;
		}
		return null;
	}

	static string smethod_23(Class33 class33_0)
	{
		Class7.smethod_739(class33_0);
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = 0;
		while (true)
		{
			int num3 = num2;
			byte b;
			while (num3 < 128 && (b = class33_0.binaryReader_0.ReadByte()) > 0)
			{
				class33_0.byte_4[num3++] = b;
			}
			int num4 = num3 - num2;
			num += num4;
			if (num3 >= 128 || stringBuilder != null)
			{
				int num5 = Class7.smethod_633(class33_0, num3 - 1);
				int chars = Encoding.UTF8.GetChars(class33_0.byte_4, 0, num5 + 1, class33_0.char_1, 0);
				if (stringBuilder == null)
				{
					stringBuilder = new StringBuilder(256);
				}
				stringBuilder.Append(class33_0.char_1, 0, chars);
				if (num5 < num4 - 1)
				{
					num2 = num4 - num5 - 1;
					Array.Copy(class33_0.byte_4, num5 + 1, class33_0.byte_4, 0, num2);
					continue;
				}
				if (num3 < 128)
				{
					break;
				}
				num2 = 0;
				continue;
			}
			int chars2 = Encoding.UTF8.GetChars(class33_0.byte_4, 0, num4, class33_0.char_1, 0);
			Class7.smethod_452(class33_0, num + 1);
			return new string(class33_0.char_1, 0, chars2);
		}
		Class7.smethod_452(class33_0, num + 1);
		return stringBuilder.ToString();
	}

	static void smethod_24(Class192 class192_0, string string_0, JToken jtoken_0)
	{
		Class7.smethod_230(class192_0);
		class192_0.dictionary_0![string_0] = jtoken_0;
	}

	static bool smethod_25(MemberInfo memberInfo_0, BindingFlags bindingFlags_0)
	{
		if (memberInfo_0.smethod_1() != MemberTypes.Property)
		{
			return false;
		}
		PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
		if (!propertyInfo.smethod_0())
		{
			return false;
		}
		Type declaringType = propertyInfo.DeclaringType;
		if (!declaringType.smethod_4())
		{
			return false;
		}
		Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
		if (genericTypeDefinition == null)
		{
			return false;
		}
		MemberInfo[] member = genericTypeDefinition.GetMember(propertyInfo.Name, bindingFlags_0);
		if (member.Length == 0)
		{
			return false;
		}
		if (!Class7.smethod_632(member[0]).IsGenericParameter)
		{
			return false;
		}
		return true;
	}

	static JsonWriterException smethod_26(string string_0, string string_1, Exception? exception_0)
	{
		string_0 = Struct0.smethod_2(null, string_1, string_0);
		return new JsonWriterException(string_0, string_1, exception_0);
	}

	static bool smethod_27(object object_0, Type type_0, [Attribute1(true)] out string? string_0)
	{
		TypeConverter typeConverter_ = default(TypeConverter);
		if (Class7.smethod_511(ref typeConverter_, type_0))
		{
			string_0 = typeConverter_.ConvertToInvariantString(object_0);
			return true;
		}
		if (object_0 is Type type)
		{
			string_0 = type.AssemblyQualifiedName;
			return true;
		}
		string_0 = null;
		return false;
	}

	static bool smethod_28(Class192 class192_0, [Out][Attribute1(true)] string? string_0, ref JToken jtoken_0)
	{
		if (class192_0.dictionary_0 == null)
		{
			jtoken_0 = null;
			return false;
		}
		return class192_0.dictionary_0!.TryGetValue(string_0, out jtoken_0);
	}

	static void smethod_29(byte[] byte_0, Class42 class42_0)
	{
		Class113.smethod_0(byte_0, "value");
		if (byte_0.Length != 12)
		{
			throw Class7.smethod_188((Class38)class42_0, "An object id must be 12 bytes", (Exception?)null);
		}
		Class7.smethod_447((Class38)class42_0, JsonToken.Undefined, (object)null);
		Class7.smethod_76((object)byte_0, class42_0, BsonType.Oid);
	}

	static object smethod_30(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0, Class143? class143_0, JsonProperty? jsonProperty_0, JsonProperty? jsonProperty_1, [Out] string string_0, ref bool bool_0)
	{
		object obj = null;
		if (class143_0!.delegate7_0 != null)
		{
			if (class143_0!.CreatorParameters.Count > 0)
			{
				bool_0 = true;
				return jsonSerializerInternalReader_0.method_15(class29_0, class143_0, jsonProperty_0, class143_0!.delegate7_0, string_0);
			}
			obj = class143_0!.delegate7_0!(Class45.smethod_10<object>());
		}
		else if (class143_0!.DefaultCreator != null && (!class143_0!.DefaultCreatorNonPublic || jsonSerializerInternalReader_0.class34_0.enum0_0 == Enum0.const_1 || class143_0!.delegate7_1 == null))
		{
			obj = class143_0!.DefaultCreator!();
		}
		else if (class143_0!.delegate7_1 != null)
		{
			bool_0 = true;
			return jsonSerializerInternalReader_0.method_15(class29_0, class143_0, jsonProperty_0, class143_0!.delegate7_1, string_0);
		}
		if (obj == null)
		{
			if (!class143_0!.bool_5)
			{
				throw Class7.smethod_161(class29_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_1(CultureInfo.InvariantCulture, class143_0!.UnderlyingType));
			}
			throw Class7.smethod_161(class29_0, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".smethod_1(CultureInfo.InvariantCulture, class143_0!.UnderlyingType));
		}
		bool_0 = false;
		return obj;
	}

	static XmlDocument? smethod_31(string string_0)
	{
		return Class8.smethod_35(string_0, null);
	}

	static IEnumerable<JToken> smethod_32(Class176 class176_0)
	{
		return Class7.smethod_51(bool_0: false, class176_0);
	}

	static JsonSchemaType smethod_33(Enum16 enum16_0, JsonSchemaType jsonSchemaType_0, Class167 class167_0)
	{
		if (enum16_0 != Enum16.const_2)
		{
			return jsonSchemaType_0 | JsonSchemaType.Null;
		}
		return jsonSchemaType_0;
	}

	static JsonContainerType smethod_34(Class38 class38_0)
	{
		Struct0 struct0_ = class38_0.struct0_0;
		if (class38_0.list_0 != null && class38_0.list_0!.Count > 0)
		{
			class38_0.struct0_0 = class38_0.list_0![class38_0.list_0!.Count - 1];
			class38_0.list_0!.RemoveAt(class38_0.list_0!.Count - 1);
		}
		else
		{
			class38_0.struct0_0 = default(Struct0);
		}
		return struct0_.jsonContainerType_0;
	}

	static bool smethod_35(Type type_0)
	{
		if (type_0.smethod_4())
		{
			switch (type_0.GetGenericTypeDefinition().FullName)
			{
			case "System.Collections.Concurrent.ConcurrentQueue`1":
			case "System.Collections.Concurrent.ConcurrentStack`1":
			case "System.Collections.Concurrent.ConcurrentBag`1":
			case "System.Collections.Concurrent.ConcurrentDictionary`2":
			case "System.Collections.ObjectModel.ObservableCollection`1":
				return true;
			}
		}
		return false;
	}

	static void smethod_36(Class152 class152_0, Class38 class38_0, IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, Class141? class141_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty jsonProperty_1)
	{
		Class7.smethod_246(class152_0, class38_0, (Class137)class141_0, (object)idynamicMetaObjectProvider_0);
		class152_0.list_0.Add(idynamicMetaObjectProvider_0);
		Class7.smethod_282((Class137)class141_0, class38_0, (object)idynamicMetaObjectProvider_0, class152_0, jsonProperty_0, jsonProperty_1, class138_0);
		int top = class38_0.Top;
		Class137 class137_ = default(Class137);
		for (int i = 0; i < class141_0!.Properties.Count; i++)
		{
			JsonProperty jsonProperty = class141_0!.Properties[i];
			if (!jsonProperty.HasMemberAttribute)
			{
				continue;
			}
			try
			{
				if (Class7.smethod_336(ref class137_, class38_0, jsonProperty_0, (object?)idynamicMetaObjectProvider_0, jsonProperty, (Class138?)class141_0, out object object_, class152_0))
				{
					jsonProperty.method_0(class38_0);
					class152_0.method_3(class38_0, object_, class137_, jsonProperty, class141_0, jsonProperty_0);
				}
			}
			catch (Exception exception_)
			{
				if (!class152_0.method_0(idynamicMetaObjectProvider_0, class141_0, jsonProperty.string_0, null, class38_0.ContainerPath, exception_))
				{
					throw;
				}
				Class7.smethod_176(top, class38_0, class152_0);
			}
		}
		object object_2 = default(object);
		foreach (string item in idynamicMetaObjectProvider_0.smethod_0())
		{
			if (!Class7.smethod_420(idynamicMetaObjectProvider_0, ref object_2, class141_0, item))
			{
				continue;
			}
			try
			{
				Class137 class137_2 = class152_0.method_2(object_2);
				if (class152_0.method_9(object_2) && class152_0.method_7(class38_0, object_2, null, class137_2, class141_0, jsonProperty_0))
				{
					string string_ = ((class141_0!.PropertyNameResolver != null) ? class141_0!.PropertyNameResolver!(item) : item);
					class38_0.vmethod_9(string_);
					class152_0.method_3(class38_0, object_2, class137_2, null, class141_0, jsonProperty_0);
				}
			}
			catch (Exception exception_2)
			{
				if (!class152_0.method_0(idynamicMetaObjectProvider_0, class141_0, item, null, class38_0.ContainerPath, exception_2))
				{
					throw;
				}
				Class7.smethod_176(top, class38_0, class152_0);
			}
		}
		class38_0.vmethod_4();
		class152_0.list_0.RemoveAt(class152_0.list_0.Count - 1);
		Class7.smethod_82(class38_0, class152_0, (Class137)class141_0, (object)idynamicMetaObjectProvider_0);
	}

	static void smethod_37(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0, JsonProperty? jsonProperty_0, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> dictionary_0)
	{
		if (jsonProperty_0 != null && dictionary_0 != null)
		{
			JsonSerializerInternalReader.PropertyPresence value;
			switch (class29_0.TokenType)
			{
			default:
				value = JsonSerializerInternalReader.PropertyPresence.Value;
				break;
			case JsonToken.Null:
			case JsonToken.Undefined:
				value = JsonSerializerInternalReader.PropertyPresence.Null;
				break;
			case JsonToken.String:
				value = (JsonSerializerInternalReader.smethod_0(jsonProperty_0!.type_0, jsonProperty_0!.PropertyContract, (string)class29_0.Value) ? JsonSerializerInternalReader.PropertyPresence.Null : JsonSerializerInternalReader.PropertyPresence.Value);
				break;
			}
			dictionary_0[jsonProperty_0] = value;
		}
	}

	static void smethod_38(Class30 class30_0)
	{
		int num = class30_0.char_2!.Length;
		if ((double)(num - class30_0.int_3) <= (double)num * 0.1 || num >= 1073741823)
		{
			int num2 = class30_0.int_2 - class30_0.int_3;
			if (num2 > 0)
			{
				char[] char_ = class30_0.char_2;
				int int_ = class30_0.int_3;
				char[] char_2 = class30_0.char_2;
				Class7.smethod_309(0, char_2, char_, int_, num2);
			}
			class30_0.int_4 -= class30_0.int_3;
			class30_0.int_3 = 0;
			class30_0.int_2 = num2;
			class30_0.char_2[class30_0.int_2] = '\0';
		}
	}

	static int? smethod_39(string string_0)
	{
		int num = 0;
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case ']':
				num--;
				break;
			case '[':
				num++;
				break;
			case ',':
				if (num == 0)
				{
					return i;
				}
				break;
			}
		}
		return null;
	}

	static JToken? smethod_40(JToken jtoken_0, string string_0)
	{
		return jtoken_0.method_6(string_0, null);
	}

	static string smethod_41(DateTime dateTime_0)
	{
		return Class7.smethod_419(Enum3.const_3, Enum1.const_0, dateTime_0);
	}

	static JToken smethod_42(byte? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static JToken smethod_43(DateTime dateTime_0)
	{
		return new Class179(dateTime_0);
	}

	static bool smethod_44(JToken jtoken_0, JToken jtoken_1, Class213 class213_0)
	{
		return class213_0.vmethod_0(jtoken_1, jtoken_0, null);
	}

	static IEnumerable<JToken> smethod_45(bool bool_0, JToken jtoken_0)
	{
		return new JToken.Class182(-2)
		{
			jtoken_1 = jtoken_0,
			bool_1 = bool_0
		};
	}

	static bool smethod_46(Type type_0)
	{
		Enum21 @enum = Class7.smethod_524(type_0);
		if (@enum != 0)
		{
			return @enum != Enum21.const_1;
		}
		return false;
	}

	static void smethod_47(JsonSchemaModel jsonSchemaModel_0, JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonSchemaModel_0 != null)
		{
			string text = Convert.ToString(jsonValidatingReader_0.class29_0.Value, CultureInfo.InvariantCulture);
			if (jsonValidatingReader_0.schemaScope_0.dictionary_0.ContainsKey(text))
			{
				jsonValidatingReader_0.schemaScope_0.dictionary_0[text] = true;
			}
			if (!jsonSchemaModel_0.AllowAdditionalProperties && !Class7.smethod_111(text, jsonSchemaModel_0, jsonValidatingReader_0))
			{
				Class7.smethod_239(jsonValidatingReader_0, "Property '{0}' has not been defined and the schema does not allow additional properties.".smethod_1(CultureInfo.InvariantCulture, text), jsonSchemaModel_0);
			}
			jsonValidatingReader_0.schemaScope_0.CurrentPropertyName = text;
		}
	}

	static void smethod_48(Class239 class239_0)
	{
		class239_0.binaryWriter_0.Close();
	}

	static JsonProperty? smethod_49(string string_0, Type type_0, Class150 class150_0, DefaultContractResolver defaultContractResolver_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		JsonProperty jsonProperty = Class7.smethod_616(class150_0, string_0);
		if (jsonProperty != null && !(jsonProperty.type_0 != type_0))
		{
			return jsonProperty;
		}
		return null;
	}

	static void smethod_50(Class6 class6_0)
	{
		Class6.Class4[] class4_ = class6_0.class4_0;
		int num = class6_0.int_2 * 2 + 1;
		Class6.Class4[] array = new Class6.Class4[num + 1];
		for (int i = 0; i < class4_.Length; i++)
		{
			Class6.Class4 @class = class4_[i];
			while (@class != null)
			{
				int num2 = @class.int_0 & num;
				Class6.Class4 class4_2 = @class.class4_0;
				@class.class4_0 = array[num2];
				array[num2] = @class;
				@class = class4_2;
			}
		}
		class6_0.class4_0 = array;
		class6_0.int_2 = num;
	}

	static IEnumerable<JToken> smethod_51(bool bool_0, Class176 class176_0)
	{
		return new Class176.Class187(-2)
		{
			class176_0 = class176_0,
			bool_1 = bool_0
		};
	}

	static JsonSchemaType? smethod_52(JsonValidatingReader jsonValidatingReader_0)
	{
		return jsonValidatingReader_0.class29_0.TokenType switch
		{
			JsonToken.StartObject => JsonSchemaType.Object, 
			JsonToken.StartArray => JsonSchemaType.Array, 
			JsonToken.Integer => JsonSchemaType.Integer, 
			JsonToken.Float => JsonSchemaType.Float, 
			JsonToken.String => JsonSchemaType.String, 
			JsonToken.Boolean => JsonSchemaType.Boolean, 
			JsonToken.Null => JsonSchemaType.Null, 
			_ => null, 
		};
	}

	static void smethod_53(Class29 class29_0, bool bool_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, int int_0)
	{
		Class7.smethod_285((Class151)jsonSerializerInternalReader_0);
		if (bool_0)
		{
			Class7.smethod_310(class29_0);
			while (class29_0.Depth > int_0 && class29_0.vmethod_0())
			{
			}
		}
	}

	static void smethod_54(Class29 class29_0)
	{
		class29_0.state_0 = ((!class29_0.SupportMultipleContent) ? Class29.State.Finished : Class29.State.Start);
	}

	static void smethod_55(Class242 class242_0, Class239 class239_0)
	{
		Class7.smethod_191(class239_0, class242_0);
		class239_0.method_0(class242_0);
	}

	static void smethod_56(Type type_0, Class167 class167_0, Class143 class143_0)
	{
		class167_0.jsonSchema_0.Properties = new Dictionary<string, JsonSchema>();
		foreach (JsonProperty property in class143_0.Properties)
		{
			if (property.Ignored)
			{
				continue;
			}
			int num;
			if (property.NullValueHandling != Enum12.const_1)
			{
				Enum4 valueOrDefault = property.DefaultValueHandling.GetValueOrDefault();
				if (!Class7.smethod_508(Enum4.flag_1, valueOrDefault, class167_0) && property.ShouldSerialize == null)
				{
					num = ((property.GetIsSpecified != null) ? 1 : 0);
					goto IL_0082;
				}
			}
			num = 1;
			goto IL_0082;
			IL_0082:
			bool flag = (byte)num != 0;
			JsonSchema jsonSchema = Class7.smethod_77(class167_0, property.type_0, property.Required, !flag);
			if (property.DefaultValue != null)
			{
				jsonSchema.Default = Class7.smethod_335(property.DefaultValue);
			}
			class167_0.jsonSchema_0.Properties.Add(property.string_0, jsonSchema);
		}
		if (type_0.smethod_10())
		{
			class167_0.jsonSchema_0.AllowAdditionalProperties = false;
		}
	}

	static void smethod_57(Class38 class38_0, Class27 class27_0, List<Interface11> list_0, XmlNamespaceManager xmlNamespaceManager_0, string string_0, bool bool_0)
	{
		if (list_0.Count == 1 && !class27_0.method_1(list_0[0]))
		{
			class27_0.method_3(class38_0, list_0[0], xmlNamespaceManager_0, bool_0);
			return;
		}
		if (bool_0)
		{
			class38_0.vmethod_9(string_0);
		}
		class38_0.vmethod_5();
		for (int i = 0; i < list_0.Count; i++)
		{
			class27_0.method_3(class38_0, list_0[i], xmlNamespaceManager_0, bool_3: false);
		}
		class38_0.vmethod_6();
	}

	static Class34 smethod_58(Class36? class36_0)
	{
		Class34 @class = new Class34();
		if (class36_0 != null)
		{
			Class7.smethod_750(class36_0, @class);
		}
		return @class;
	}

	static void smethod_59(Class167 class167_0, Class167.Class168 class168_0)
	{
		class167_0.jsonSchema_0 = class168_0.Schema;
		class167_0.ilist_0.Add(class168_0);
		class167_0.class172_0.LoadedSchemas.Add(class168_0.Schema);
	}

	static IEnumerable<JToken> smethod_60(JToken jtoken_0, Class195 class195_0, JToken? jtoken_1, Class212 class212_0)
	{
		return Class212.smethod_0(class212_0.Filters, jtoken_0, jtoken_1, class195_0);
	}

	static string smethod_61(IEnumerable<JsonSchema> ienumerable_0)
	{
		return string.Join("-", ienumerable_0.Select((JsonSchema jsonSchema_0) => jsonSchema_0.string_7).OrderBy<string, string>((string string_0) => string_0, StringComparer.Ordinal));
	}

	static object smethod_62(Type type_0, Class115? class115_0, string string_0, bool bool_0)
	{
		Class113.smethod_0(type_0, "enumType");
		Class113.smethod_0(string_0, "value");
		if (!type_0.smethod_8())
		{
			throw new ArgumentException("Type provided must be an Enum.", "enumType");
		}
		Class77 @class = EnumUtils.class111_0.method_0(new Struct5<Type, Class115>(type_0, class115_0));
		string[] string_ = @class.string_0;
		string[] string_2 = @class.string_1;
		ulong[] ulong_ = @class.ulong_0;
		int? num = Class7.smethod_636(StringComparison.Ordinal, string_2, 0, string_0.Length, string_0);
		if (num.HasValue)
		{
			return Enum.ToObject(type_0, ulong_[num.Value]);
		}
		int num2 = -1;
		for (int i = 0; i < string_0.Length; i++)
		{
			if (!char.IsWhiteSpace(string_0[i]))
			{
				num2 = i;
				break;
			}
		}
		if (num2 == -1)
		{
			throw new ArgumentException("Must specify valid information for parsing in the string.");
		}
		char c = string_0[num2];
		if (char.IsDigit(c) || c == '-' || c == '+')
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			string_0 = string_0.Trim();
			object obj = null;
			try
			{
				obj = Convert.ChangeType(string_0, underlyingType, CultureInfo.InvariantCulture);
			}
			catch (FormatException)
			{
			}
			if (obj != null)
			{
				if (bool_0)
				{
					throw new FormatException("Integer string '{0}' is not allowed.".smethod_1(CultureInfo.InvariantCulture, string_0));
				}
				return Enum.ToObject(type_0, obj);
			}
		}
		ulong num3 = 0uL;
		int j = num2;
		while (true)
		{
			if (j <= string_0.Length)
			{
				int num4 = string_0.IndexOf(',', j);
				if (num4 == -1)
				{
					num4 = string_0.Length;
				}
				int num5 = num4;
				for (; j < num4 && char.IsWhiteSpace(string_0[j]); j++)
				{
				}
				while (num5 > j && char.IsWhiteSpace(string_0[num5 - 1]))
				{
					num5--;
				}
				int int_ = num5 - j;
				num = Class7.smethod_122(StringComparison.Ordinal, string_2, string_0, j, string_, int_);
				if (!num.HasValue)
				{
					num = Class7.smethod_122(StringComparison.OrdinalIgnoreCase, string_2, string_0, j, string_, int_);
				}
				if (!num.HasValue)
				{
					break;
				}
				num3 |= ulong_[num.Value];
				j = num4 + 1;
				continue;
			}
			return Enum.ToObject(type_0, num3);
		}
		num = Class7.smethod_636(StringComparison.OrdinalIgnoreCase, string_2, 0, string_0.Length, string_0);
		if (!num.HasValue)
		{
			throw new ArgumentException("Requested value '{0}' was not found.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		return Enum.ToObject(type_0, ulong_[num.Value]);
	}

	static JToken smethod_63(decimal decimal_0)
	{
		return new Class179(decimal_0);
	}

	static void smethod_64(Class176 class176_0, object object_0)
	{
		class176_0.vmethod_23(object_0, null);
	}

	static Class179 smethod_65(string? string_0)
	{
		return new Class179(string_0, JTokenType.Comment);
	}

	static JToken smethod_66(Class193 class193_0, Class29? class29_0)
	{
		Class113.smethod_0(class29_0, "reader");
		if (!((class29_0!.TokenType == JsonToken.None) ? ((class193_0 == null || class193_0.enum28_0 != 0) ? class29_0!.vmethod_0() : Class7.smethod_110(class29_0)) : (class29_0!.TokenType != JsonToken.Comment || class193_0 == null || class193_0.enum28_0 != 0 || Class7.smethod_110(class29_0))))
		{
			throw Class7.smethod_555(class29_0, "Error reading JToken from JsonReader.");
		}
		Interface1 interface1_ = class29_0 as Interface1;
		switch (class29_0!.TokenType)
		{
		case JsonToken.StartObject:
			return Class7.smethod_626(class29_0, class193_0);
		case JsonToken.StartArray:
			return Class7.smethod_92(class29_0, class193_0);
		case JsonToken.StartConstructor:
			return Class7.smethod_123(class29_0, class193_0);
		case JsonToken.PropertyName:
			return Class7.smethod_411(class29_0, class193_0);
		case JsonToken.Comment:
		{
			Class179 class4 = new Class179(class29_0!.Value!.ToString(), JTokenType.Comment);
			class4.method_5(interface1_, class193_0);
			return class4;
		}
		case JsonToken.Null:
		{
			Class179 class3 = new Class179(null, JTokenType.Null);
			class3.method_5(interface1_, class193_0);
			return class3;
		}
		case JsonToken.Undefined:
		{
			Class179 class2 = new Class179(null, JTokenType.Undefined);
			class2.method_5(interface1_, class193_0);
			return class2;
		}
		default:
			throw Class7.smethod_555(class29_0, "Error reading JToken from JsonReader. Unexpected token: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0!.TokenType));
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Date:
		case JsonToken.Bytes:
		{
			Class179 @class = new Class179(class29_0!.Value);
			@class.method_5(interface1_, class193_0);
			return @class;
		}
		}
	}

	static void smethod_67(Class29 class29_0)
	{
		if (!class29_0.vmethod_0())
		{
			throw class29_0.method_2();
		}
	}

	static byte smethod_68(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (byte)bigInteger;
			}
			return Convert.ToByte(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Byte.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static string smethod_69(Class34? class34_0, Type? type_0, object object_0)
	{
		StringWriter stringWriter = new StringWriter(new StringBuilder(256), CultureInfo.InvariantCulture);
		using (Class39 @class = new Class39(stringWriter))
		{
			@class.Formatting = class34_0!.Formatting;
			class34_0!.method_8(@class, object_0, type_0);
		}
		return stringWriter.ToString();
	}

	static char smethod_70(int int_0)
	{
		if (int_0 <= 9)
		{
			return (char)(int_0 + 48);
		}
		return (char)(int_0 - 10 + 97);
	}

	static void smethod_71(Class38 class38_0)
	{
		while (class38_0.Top > 0)
		{
			class38_0.vmethod_11();
		}
	}

	static void smethod_72(Class164 class164_0, JsonSchema jsonSchema_0)
	{
		class164_0.jsonSchema_0 = jsonSchema_0;
		class164_0.ilist_0.Add(jsonSchema_0);
		class164_0.class172_0.LoadedSchemas.Add(jsonSchema_0);
		class164_0.idictionary_0.Add(jsonSchema_0.Location, jsonSchema_0);
	}

	static string smethod_73(char char_0, TimeSpan timeSpan_0)
	{
		return Class7.smethod_579(timeSpan_0.ToString(), char_0);
	}

	static object? smethod_74(Class100 class100_0, object object_0, string string_0)
	{
		return class100_0.Members[string_0].Getter!(object_0);
	}

	static string smethod_75(Class33 class33_0)
	{
		int num = Class7.smethod_532(class33_0);
		Class7.smethod_452(class33_0, num);
		string result = Class7.smethod_169(num - 1, class33_0);
		class33_0.binaryReader_0.ReadByte();
		return result;
	}

	static void smethod_76(object object_0, Class42 class42_0, BsonType bsonType_0)
	{
		Class7.smethod_761(class42_0, (Class242)new Class246(object_0, bsonType_0));
	}

	static JsonSchema smethod_77(Class167 class167_0, Type type_0, Enum16 enum16_0, bool bool_0)
	{
		Class167.Class169 CS_0024_003C_003E8__locals0 = new Class167.Class169();
		CS_0024_003C_003E8__locals0.type_0 = type_0;
		Class113.smethod_0(CS_0024_003C_003E8__locals0.type_0, "type");
		string text = Class7.smethod_727(CS_0024_003C_003E8__locals0.type_0, bool_0: false, class167_0);
		string text2 = Class7.smethod_727(CS_0024_003C_003E8__locals0.type_0, bool_0: true, class167_0);
		if (!Class109.smethod_0(text))
		{
			JsonSchema jsonSchema = class167_0.class172_0.vmethod_0(text);
			if (jsonSchema != null)
			{
				if (enum16_0 != Enum16.const_2 && !Class7.smethod_494(JsonSchemaType.Null, jsonSchema.Type))
				{
					jsonSchema.Type |= JsonSchemaType.Null;
				}
				if (bool_0 && jsonSchema.Required != true)
				{
					jsonSchema.Required = true;
				}
				return jsonSchema;
			}
		}
		if (class167_0.ilist_0.Any((Class167.Class168 class168_0) => class168_0.Type == CS_0024_003C_003E8__locals0.type_0))
		{
			throw new JsonException("Unresolved circular reference for type '{0}'. Explicitly define an Id for the type using a JsonObject/JsonArray attribute or automatically generate a type Id using the UndefinedSchemaIdHandling property.".smethod_1(CultureInfo.InvariantCulture, CS_0024_003C_003E8__locals0.type_0));
		}
		Class137 @class = class167_0.ContractResolver.imethod_0(CS_0024_003C_003E8__locals0.type_0);
		Class9? obj = @class.Converter ?? @class.InternalConverter;
		Class7.smethod_59(class167_0, new Class167.Class168(CS_0024_003C_003E8__locals0.type_0, new JsonSchema()));
		if (text2 != null)
		{
			class167_0.jsonSchema_0.Id = text2;
		}
		if (bool_0)
		{
			class167_0.jsonSchema_0.Required = true;
		}
		class167_0.jsonSchema_0.Title = Class7.smethod_22(CS_0024_003C_003E8__locals0.type_0, class167_0);
		class167_0.jsonSchema_0.Description = Class7.smethod_229(class167_0, CS_0024_003C_003E8__locals0.type_0);
		if (obj != null)
		{
			class167_0.jsonSchema_0.Type = JsonSchemaType.Any;
		}
		else
		{
			switch (@class.enum26_0)
			{
			default:
				throw new JsonException("Unexpected contract type: {0}".smethod_1(CultureInfo.InvariantCulture, @class));
			case Enum26.const_1:
				class167_0.jsonSchema_0.Type = Class7.smethod_33(enum16_0, JsonSchemaType.Object, class167_0);
				class167_0.jsonSchema_0.Id = Class7.smethod_727(CS_0024_003C_003E8__locals0.type_0, bool_0: false, class167_0);
				Class7.smethod_56(CS_0024_003C_003E8__locals0.type_0, class167_0, (Class143)@class);
				break;
			case Enum26.const_2:
			{
				class167_0.jsonSchema_0.Type = Class7.smethod_33(enum16_0, JsonSchemaType.Array, class167_0);
				class167_0.jsonSchema_0.Id = Class7.smethod_727(CS_0024_003C_003E8__locals0.type_0, bool_0: false, class167_0);
				bool flag = JsonTypeReflector.smethod_0<Attribute6>(CS_0024_003C_003E8__locals0.type_0)?.bool_0 ?? true;
				Type type = Class7.smethod_369(CS_0024_003C_003E8__locals0.type_0);
				if (type != null)
				{
					class167_0.jsonSchema_0.Items = new List<JsonSchema>();
					class167_0.jsonSchema_0.Items.Add(Class7.smethod_77(class167_0, type, (!flag) ? Enum16.const_2 : Enum16.const_0, bool_0: false));
				}
				break;
			}
			case Enum26.const_3:
				class167_0.jsonSchema_0.Type = Class7.smethod_749(enum16_0, class167_0, CS_0024_003C_003E8__locals0.type_0);
				if (class167_0.jsonSchema_0.Type == JsonSchemaType.Integer && CS_0024_003C_003E8__locals0.type_0.smethod_8() && !CS_0024_003C_003E8__locals0.type_0.IsDefined(typeof(FlagsAttribute), inherit: true))
				{
					class167_0.jsonSchema_0.Enum = new List<JToken>();
					Class77 class2 = Class7.smethod_389(CS_0024_003C_003E8__locals0.type_0);
					for (int i = 0; i < class2.string_0.Length; i++)
					{
						ulong value = class2.ulong_0[i];
						JToken item = Class7.smethod_335(Enum.ToObject(CS_0024_003C_003E8__locals0.type_0, value));
						class167_0.jsonSchema_0.Enum.Add(item);
					}
				}
				break;
			case Enum26.const_4:
			{
				JsonSchemaType value2 = ((!Class7.smethod_213(@class.UnderlyingType)) ? JsonSchemaType.String : Class7.smethod_33(enum16_0, JsonSchemaType.String, class167_0));
				class167_0.jsonSchema_0.Type = value2;
				break;
			}
			case Enum26.const_5:
			{
				class167_0.jsonSchema_0.Type = Class7.smethod_33(enum16_0, JsonSchemaType.Object, class167_0);
				ReflectionUtils.smethod_3(CS_0024_003C_003E8__locals0.type_0, out var type_, out var type_2);
				if (type_ != null && class167_0.ContractResolver.imethod_0(type_).enum26_0 == Enum26.const_3)
				{
					class167_0.jsonSchema_0.AdditionalProperties = Class7.smethod_77(class167_0, type_2, Enum16.const_0, bool_0: false);
				}
				break;
			}
			case Enum26.const_7:
				class167_0.jsonSchema_0.Type = Class7.smethod_33(enum16_0, JsonSchemaType.Object, class167_0);
				class167_0.jsonSchema_0.Id = Class7.smethod_727(CS_0024_003C_003E8__locals0.type_0, bool_0: false, class167_0);
				Class7.smethod_222((Class142)@class, CS_0024_003C_003E8__locals0.type_0, class167_0);
				break;
			case Enum26.const_6:
			case Enum26.const_8:
				class167_0.jsonSchema_0.Type = JsonSchemaType.Any;
				break;
			}
		}
		return Class7.smethod_429(class167_0).Schema;
	}

	static uint smethod_78(string string_0)
	{
		uint num = default(uint);
		if (string_0 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < string_0.Length; i++)
			{
				num = (string_0[i] ^ num) * 16777619;
			}
		}
		return num;
	}

	static DataMemberAttribute? smethod_79(MemberInfo memberInfo_0)
	{
		if (memberInfo_0.smethod_1() == MemberTypes.Field)
		{
			return Class114<DataMemberAttribute>.smethod_0(memberInfo_0);
		}
		PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
		DataMemberAttribute dataMemberAttribute = Class114<DataMemberAttribute>.smethod_0(propertyInfo);
		if (dataMemberAttribute == null && propertyInfo.smethod_0())
		{
			Type type = propertyInfo.DeclaringType;
			while (dataMemberAttribute == null && type != null)
			{
				PropertyInfo propertyInfo2 = (PropertyInfo)Class7.smethod_95(type, (MemberInfo)propertyInfo);
				if (propertyInfo2 != null && propertyInfo2.smethod_0())
				{
					dataMemberAttribute = Class114<DataMemberAttribute>.smethod_0(propertyInfo2);
				}
				type = type.smethod_6();
			}
		}
		return dataMemberAttribute;
	}

	static void smethod_80(Class30 class30_0, bool bool_0)
	{
		class30_0.int_3++;
		if (!Class7.smethod_260(class30_0, 1, bool_0: false))
		{
			throw Class7.smethod_555((Class29)class30_0, "Unexpected end while parsing comment.");
		}
		bool flag;
		if (class30_0.char_2[class30_0.int_3] == '*')
		{
			flag = false;
		}
		else
		{
			if (class30_0.char_2[class30_0.int_3] != '/')
			{
				throw Class7.smethod_555((Class29)class30_0, "Error parsing comment. Expected: *, got {0}.".smethod_1(CultureInfo.InvariantCulture, class30_0.char_2[class30_0.int_3]));
			}
			flag = true;
		}
		class30_0.int_3++;
		int int_ = class30_0.int_3;
		while (true)
		{
			switch (class30_0.char_2[class30_0.int_3])
			{
			default:
				class30_0.int_3++;
				break;
			case '*':
				class30_0.int_3++;
				if (!flag && Class7.smethod_260(class30_0, 0, bool_0: true) && class30_0.char_2[class30_0.int_3] == '/')
				{
					Class7.smethod_374(class30_0, bool_0, int_, class30_0.int_3 - 1);
					class30_0.int_3++;
					return;
				}
				break;
			case '\r':
				if (!flag)
				{
					Class7.smethod_287(class30_0, bool_0: true);
					break;
				}
				Class7.smethod_374(class30_0, bool_0, int_, class30_0.int_3);
				return;
			case '\n':
				if (!flag)
				{
					Class7.smethod_630(class30_0);
					break;
				}
				Class7.smethod_374(class30_0, bool_0, int_, class30_0.int_3);
				return;
			case '\0':
				if (class30_0.int_2 == class30_0.int_3)
				{
					if (Class7.smethod_418(bool_0: true, class30_0) == 0)
					{
						if (!flag)
						{
							throw Class7.smethod_555((Class29)class30_0, "Unexpected end while parsing comment.");
						}
						Class7.smethod_374(class30_0, bool_0, int_, class30_0.int_3);
						return;
					}
				}
				else
				{
					class30_0.int_3++;
				}
				break;
			}
		}
	}

	static Class100 smethod_81(Type type_0, MethodBase? methodBase_0, params string[] string_0)
	{
		Class68 reflectionDelegateFactory = JsonTypeReflector.ReflectionDelegateFactory;
		Delegate7<object> delegate7_ = null;
		if (methodBase_0 != null)
		{
			delegate7_ = reflectionDelegateFactory.vmethod_1(methodBase_0);
		}
		else if (Class7.smethod_179(type_0, bool_0: false))
		{
			delegate7_ = new Class100.Class101
			{
				func_0 = reflectionDelegateFactory.vmethod_2<object>(type_0)
			}.method_0;
		}
		Class100 @class = new Class100(delegate7_);
		Class100.Class102 CS_0024_003C_003E8__locals0;
		Class100.Class103 CS_0024_003C_003E8__locals1;
		foreach (string text in string_0)
		{
			MemberInfo[] member = type_0.GetMember(text, BindingFlags.Instance | BindingFlags.Public);
			if (member.Length == 1)
			{
				MemberInfo memberInfo = member.Single();
				Class99 class2 = new Class99();
				switch (memberInfo.smethod_1())
				{
				case MemberTypes.Method:
				{
					MethodInfo methodInfo = (MethodInfo)memberInfo;
					if (!methodInfo.IsPublic)
					{
						break;
					}
					ParameterInfo[] parameters = methodInfo.GetParameters();
					if (parameters.Length == 0 && methodInfo.ReturnType != typeof(void))
					{
						CS_0024_003C_003E8__locals0 = new Class100.Class102();
						CS_0024_003C_003E8__locals0.delegate1_0 = reflectionDelegateFactory.vmethod_0<object>(methodInfo);
						class2.Getter = (object object_0) => CS_0024_003C_003E8__locals0.delegate1_0(object_0);
					}
					else if (parameters.Length == 1 && methodInfo.ReturnType == typeof(void))
					{
						CS_0024_003C_003E8__locals1 = new Class100.Class103();
						CS_0024_003C_003E8__locals1.delegate1_0 = reflectionDelegateFactory.vmethod_0<object>(methodInfo);
						class2.Setter = delegate(object object_0, object? object_1)
						{
							CS_0024_003C_003E8__locals1.delegate1_0(object_0, object_1);
						};
					}
					break;
				}
				case MemberTypes.Field:
				case MemberTypes.Property:
					if (Class7.smethod_290(memberInfo, bool_0: false))
					{
						class2.Getter = reflectionDelegateFactory.method_0<object>(memberInfo);
					}
					if (Class7.smethod_572(memberInfo, bool_0: false, bool_1: false))
					{
						class2.Setter = reflectionDelegateFactory.method_1<object>(memberInfo);
					}
					break;
				default:
					throw new ArgumentException("Unexpected member type '{0}' for member '{1}'.".smethod_2(CultureInfo.InvariantCulture, memberInfo.smethod_1(), memberInfo.Name));
				}
				class2.MemberType = Class7.smethod_632(memberInfo);
				@class.Members[text] = class2;
				continue;
			}
			throw new ArgumentException("Expected a single member with the name '{0}'.".smethod_1(CultureInfo.InvariantCulture, text));
		}
		return @class;
	}

	static void smethod_82(Class38 class38_0, Class152 class152_0, Class137 class137_0, object object_0)
	{
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(null, class38_0.Path, "Finished serializing {0}".smethod_1(CultureInfo.InvariantCulture, class137_0.UnderlyingType)), null);
		}
		class137_0.method_1(object_0, class152_0.class34_0.streamingContext_0);
	}

	static Class29 smethod_83(JToken jtoken_0)
	{
		return new Class32(jtoken_0);
	}

	static void smethod_84(ILGenerator ilgenerator_0, Class69 class69_0, FieldInfo fieldInfo_0)
	{
		if (!fieldInfo_0.IsStatic)
		{
			ilgenerator_0.smethod_0(fieldInfo_0.DeclaringType);
			ilgenerator_0.Emit(OpCodes.Ldfld, fieldInfo_0);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Ldsfld, fieldInfo_0);
		}
		ilgenerator_0.smethod_2(fieldInfo_0.FieldType);
		ilgenerator_0.smethod_5();
	}

	static JToken smethod_85(object? object_0)
	{
		if (object_0 is JToken result)
		{
			return result;
		}
		return new Class179(object_0);
	}

	static Class180 smethod_86(Class29 class29_0)
	{
		using StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		using Class39 class38_ = new Class39(stringWriter);
		Class7.smethod_298(class29_0, (Class38)class38_);
		return new Class180(stringWriter.ToString());
	}

	static DynamicMethod smethod_87(string string_0, Type? type_0, Type[] type_1, Type type_2)
	{
		if (type_2.smethod_3())
		{
			return new DynamicMethod(string_0, type_0, type_1, type_2.Module, skipVisibility: true);
		}
		return new DynamicMethod(string_0, type_0, type_1, type_2, skipVisibility: true);
	}

	static void smethod_88(Class176 class176_0)
	{
		class176_0.vmethod_18();
	}

	static Class178 smethod_89(Class29 class29_0)
	{
		return Class7.smethod_123(class29_0, (Class193?)null);
	}

	static Delegate4 smethod_90(MethodInfo methodInfo_0)
	{
		return new Class137.Class148
		{
			methodInfo_0 = methodInfo_0
		}.method_0;
	}

	static bool smethod_91(Class32 class32_0, Class176 class176_0)
	{
		JsonToken? jsonToken = Class7.smethod_480(class32_0, class176_0);
		if (jsonToken.HasValue)
		{
			Class7.smethod_386((Class29)class32_0, jsonToken.GetValueOrDefault());
			class32_0.jtoken_2 = class176_0;
			class32_0.jtoken_1 = class176_0;
			return true;
		}
		return Class7.smethod_351(class32_0, (JToken)class176_0);
	}

	static Class177 smethod_92(Class29 class29_0, Class193? class193_0)
	{
		if (class29_0.TokenType == JsonToken.None && !class29_0.vmethod_0())
		{
			throw Class7.smethod_555(class29_0, "Error reading JArray from JsonReader.");
		}
		Class7.smethod_407(class29_0);
		if (class29_0.TokenType != JsonToken.StartArray)
		{
			throw Class7.smethod_555(class29_0, "Error reading JArray from JsonReader. Current JsonReader item is not an array: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		}
		Class177 @class = new Class177();
		@class.method_5(class29_0 as Interface1, class193_0);
		Class7.smethod_644((Class176)@class, class29_0, class193_0);
		return @class;
	}

	static bool smethod_93(Class179 class179_0, Class179 class179_1)
	{
		if (class179_0.System_002EIEquatable_003Cns15_002EClass179_003E_002EEquals(class179_1))
		{
			return true;
		}
		if ((class179_0.Type == JTokenType.Integer && class179_1.Type == JTokenType.Float) || (class179_0.Type == JTokenType.Float && class179_1.Type == JTokenType.Integer))
		{
			return Class179.smethod_37(class179_0.Type, class179_0.Value, class179_1.Value) == 0;
		}
		if (class179_1.Type != JTokenType.String)
		{
			return false;
		}
		string b = (string)class179_1.Value;
		string a;
		switch (class179_0.Type)
		{
		case JTokenType.Date:
		{
			using (StringWriter stringWriter = Class7.smethod_470(64))
			{
				if (class179_0.Value is DateTimeOffset dateTimeOffset_)
				{
					Class51.smethod_3(stringWriter, dateTimeOffset_, Enum1.const_0, null, CultureInfo.InvariantCulture);
				}
				else
				{
					Class51.smethod_1(stringWriter, (DateTime)class179_0.Value, Enum1.const_0, null, CultureInfo.InvariantCulture);
				}
				a = stringWriter.ToString();
			}
			break;
		}
		default:
			return false;
		case JTokenType.Bytes:
			a = Convert.ToBase64String((byte[])class179_0.Value);
			break;
		case JTokenType.Uri:
			a = ((Uri)class179_0.Value).OriginalString;
			break;
		case JTokenType.Guid:
		case JTokenType.TimeSpan:
			a = class179_0.Value!.ToString();
			break;
		}
		return string.Equals(a, b, StringComparison.Ordinal);
	}

	static bool smethod_94(Class30 class30_0, bool bool_0)
	{
		while (true)
		{
			char c = class30_0.char_2[class30_0.int_3];
			switch (c)
			{
			case '/':
				Class7.smethod_80(class30_0, !bool_0);
				if (!bool_0)
				{
					return true;
				}
				continue;
			case '\n':
				Class7.smethod_630(class30_0);
				continue;
			case '\r':
				Class7.smethod_287(class30_0, bool_0: false);
				continue;
			case '\0':
				if (class30_0.int_2 == class30_0.int_3)
				{
					if (Class7.smethod_418(bool_0: false, class30_0) == 0)
					{
						class30_0.state_0 = Class29.State.Finished;
						return false;
					}
				}
				else
				{
					class30_0.int_3++;
				}
				continue;
			case '\t':
			case ' ':
				class30_0.int_3++;
				continue;
			case ')':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.EndConstructor);
				return true;
			case ',':
				class30_0.int_3++;
				Class7.smethod_717((Class29)class30_0);
				return false;
			case '}':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.EndObject);
				return true;
			case ']':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.EndArray);
				return true;
			}
			if (char.IsWhiteSpace(c))
			{
				class30_0.int_3++;
				continue;
			}
			if (class30_0.SupportMultipleContent && class30_0.Depth == 0)
			{
				Class7.smethod_717((Class29)class30_0);
				return false;
			}
			throw Class7.smethod_555((Class29)class30_0, "After parsing a value an unexpected character was encountered: {0}.".smethod_1(CultureInfo.InvariantCulture, c));
		}
	}

	static MemberInfo smethod_95(Type type_0, MemberInfo memberInfo_0)
	{
		if (memberInfo_0.smethod_1() == MemberTypes.Property)
		{
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
			Type[] types = (from parameterInfo_0 in propertyInfo.GetIndexParameters()
				select parameterInfo_0.ParameterType).ToArray();
			return type_0.GetProperty(propertyInfo.Name, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, propertyInfo.PropertyType, types, null);
		}
		return type_0.GetMember(memberInfo_0.Name, memberInfo_0.smethod_1(), BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).SingleOrDefault();
	}

	static void smethod_96(int int_0, int int_1, int int_2, Class30 class30_0)
	{
		if (int_0 == int_2)
		{
			class30_0.struct4_0 = new Struct4(class30_0.char_2, int_0, int_1 - int_0);
		}
		else
		{
			Class7.smethod_228(class30_0);
			if (int_1 > int_2)
			{
				class30_0.struct3_0.method_1(class30_0.interface0_0, class30_0.char_2, int_2, int_1 - int_2);
			}
			class30_0.struct4_0 = new Struct4(class30_0.struct3_0.InternalBuffer, 0, class30_0.struct3_0.Position);
		}
		class30_0.int_3 = int_1 + 1;
	}

	static void smethod_97(Class152 class152_0, Class38 class38_0, Type type_0, object object_0)
	{
		string text = Class7.smethod_445(object_0, class38_0, class152_0);
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class38_0.Path, "Writing object reference Id '{0}' for {1}.".smethod_2(CultureInfo.InvariantCulture, text, type_0)), null);
		}
		class38_0.vmethod_10("$id", bool_2: false);
		class38_0.vmethod_21(text);
	}

	static Class115? smethod_98(Attribute5 attribute5_0)
	{
		if (attribute5_0.NamingStrategyInstance == null)
		{
			if (attribute5_0.type_1 == null)
			{
				return null;
			}
			attribute5_0.NamingStrategyInstance = Class7.smethod_11(attribute5_0.type_1, attribute5_0.object_1);
		}
		return attribute5_0.NamingStrategyInstance;
	}

	static Class38 smethod_99(Class176 class176_0)
	{
		return new Class41(class176_0);
	}

	static string smethod_100(Class31 class31_0)
	{
		return class31_0.stringWriter_0.ToString();
	}

	static void smethod_101(JToken jtoken_0)
	{
		if (jtoken_0.class176_0 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		jtoken_0.class176_0!.vmethod_15(jtoken_0);
	}

	static JsonContainerType smethod_102(JsonToken jsonToken_0, Class29 class29_0)
	{
		return jsonToken_0 switch
		{
			JsonToken.EndObject => JsonContainerType.Object, 
			JsonToken.EndArray => JsonContainerType.Array, 
			JsonToken.EndConstructor => JsonContainerType.Constructor, 
			_ => throw Class7.smethod_555(class29_0, "Not a valid close JsonToken: {0}".smethod_1(CultureInfo.InvariantCulture, jsonToken_0)), 
		};
	}

	static JToken smethod_103(JToken? jtoken_0, bool bool_0, Class176 class176_0)
	{
		if (jtoken_0 == null)
		{
			return new Class179(null, JTokenType.Null);
		}
		if (bool_0)
		{
			return jtoken_0;
		}
		if (jtoken_0!.Parent != null || jtoken_0 == class176_0 || (jtoken_0!.HasValues && class176_0.Root == jtoken_0))
		{
			jtoken_0 = jtoken_0!.vmethod_0();
		}
		return jtoken_0;
	}

	static DateTime smethod_104(DateTime dateTime_0)
	{
		return dateTime_0.Kind switch
		{
			DateTimeKind.Unspecified => new DateTime(dateTime_0.Ticks, DateTimeKind.Utc), 
			DateTimeKind.Utc => dateTime_0, 
			DateTimeKind.Local => dateTime_0.ToUniversalTime(), 
			_ => dateTime_0, 
		};
	}

	static bool smethod_105(Class30 class30_0, char char_0)
	{
		switch (char_0)
		{
		case ')':
			if (class30_0.state_0 == Class29.State.Constructor || class30_0.state_0 == Class29.State.ConstructorStart)
			{
				return true;
			}
			goto IL_0096;
		case '\t':
		case '\n':
		case '\r':
		case ' ':
			return true;
		case '/':
		{
			if (!Class7.smethod_260(class30_0, 1, bool_0: false))
			{
				return false;
			}
			char c = class30_0.char_2[class30_0.int_3 + 1];
			if (c != '*')
			{
				return c == '/';
			}
			return true;
		}
		default:
			if (char.IsWhiteSpace(char_0))
			{
				return true;
			}
			goto IL_0096;
		case ',':
		case ']':
		case '}':
			{
				return true;
			}
			IL_0096:
			return false;
		}
	}

	static void smethod_106(object object_0, JToken jtoken_0)
	{
		if (object_0 == null)
		{
			throw new ArgumentNullException("annotation");
		}
		if (jtoken_0.object_0 == null)
		{
			jtoken_0.object_0 = ((!(object_0 is object[])) ? object_0 : new object[1] { object_0 });
			return;
		}
		object[] array = jtoken_0.object_0 as object[];
		if (array == null)
		{
			jtoken_0.object_0 = new object[2] { jtoken_0.object_0, object_0 };
			return;
		}
		int i;
		for (i = 0; i < array.Length && array[i] != null; i++)
		{
		}
		if (i == array.Length)
		{
			Array.Resize(ref array, i * 2);
			jtoken_0.object_0 = array;
		}
		array[i] = object_0;
	}

	static Class179? smethod_107(JToken jtoken_0)
	{
		if (jtoken_0 == null)
		{
			throw new ArgumentNullException("value");
		}
		if (jtoken_0 is JProperty jProperty)
		{
			jtoken_0 = jProperty.Value;
		}
		return jtoken_0 as Class179;
	}

	static bool smethod_108(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("s");
		}
		if (string_0.Length == 0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (!char.IsWhiteSpace(string_0[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	static string smethod_109(object? object_0)
	{
		if (object_0 == null)
		{
			return Class8.string_2;
		}
		return Class7.smethod_524(object_0!.GetType()) switch
		{
			Enum21.const_2 => Class7.smethod_655((char)object_0), 
			Enum21.const_4 => Class7.smethod_469((bool)object_0), 
			Enum21.const_6 => Class8.smethod_13((sbyte)object_0), 
			Enum21.const_8 => Class8.smethod_1((short)object_0), 
			Enum21.const_10 => Class8.smethod_2((ushort)object_0), 
			Enum21.const_12 => Class8.smethod_0((int)object_0), 
			Enum21.const_14 => Class8.smethod_12((byte)object_0), 
			Enum21.const_16 => Class8.smethod_3((uint)object_0), 
			Enum21.const_18 => Class8.smethod_4((long)object_0), 
			Enum21.const_20 => Class8.smethod_6((ulong)object_0), 
			Enum21.const_22 => Class8.smethod_7((float)object_0), 
			Enum21.const_24 => Class8.smethod_10((double)object_0), 
			Enum21.const_26 => Class7.smethod_41((DateTime)object_0), 
			Enum21.const_28 => Class7.smethod_352((DateTimeOffset)object_0), 
			Enum21.const_30 => Class8.smethod_14((decimal)object_0), 
			Enum21.const_32 => Class7.smethod_702((Guid)object_0), 
			Enum21.const_34 => Class7.smethod_590((TimeSpan)object_0), 
			Enum21.const_36 => Class8.smethod_5((BigInteger)object_0), 
			Enum21.const_38 => Class7.smethod_599((Uri)object_0), 
			Enum21.const_39 => Class7.smethod_323((string)object_0), 
			Enum21.const_41 => Class8.string_2, 
			_ => throw new ArgumentException("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".smethod_1(CultureInfo.InvariantCulture, object_0!.GetType())), 
		};
	}

	static bool smethod_110(Class29 class29_0)
	{
		if (class29_0.vmethod_0())
		{
			return Class7.smethod_407(class29_0);
		}
		return false;
	}

	static bool smethod_111(string string_0, JsonSchemaModel jsonSchemaModel_0, JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonSchemaModel_0.Properties != null && jsonSchemaModel_0.Properties.ContainsKey(string_0))
		{
			return true;
		}
		if (jsonSchemaModel_0.PatternProperties != null)
		{
			foreach (string key in jsonSchemaModel_0.PatternProperties.Keys)
			{
				if (Regex.IsMatch(string_0, key))
				{
					return true;
				}
			}
		}
		return false;
	}

	static bool smethod_112(string string_0, Enum3 enum3_0, string? string_1, CultureInfo cultureInfo_0, out DateTime dateTime_0)
	{
		if (string_0.Length > 0)
		{
			if (string_0[0] == '/')
			{
				if (string_0.Length >= 9 && string_0.StartsWith("/Date(", StringComparison.Ordinal) && string_0.EndsWith(")/", StringComparison.Ordinal) && Class7.smethod_235(ref dateTime_0, enum3_0, new Struct4(string_0.ToCharArray(), 0, string_0.Length)))
				{
					return true;
				}
			}
			else if (string_0.Length >= 19 && string_0.Length <= 40 && char.IsDigit(string_0[0]) && string_0[10] == 'T' && DateTime.TryParseExact(string_0, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateTime_0))
			{
				dateTime_0 = Class7.smethod_517(dateTime_0, enum3_0);
				return true;
			}
			if (!Class109.smethod_0(string_1) && Class7.smethod_244(string_1, ref dateTime_0, cultureInfo_0, enum3_0, string_0))
			{
				return true;
			}
		}
		dateTime_0 = default(DateTime);
		return false;
	}

	static Type smethod_113(Type type_0)
	{
		if (type_0.IsByRef && type_0.HasElementType)
		{
			return type_0.GetElementType();
		}
		return type_0;
	}

	static BigInteger? smethod_114(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: true, (JToken)@class, JToken.jtokenType_2))
		{
			if (@class.Value == null)
			{
				return null;
			}
			return Class7.smethod_442(@class.Value);
		}
		throw new ArgumentException("Can not convert {0} to BigInteger.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static IDictionary smethod_115(ref bool bool_0, Class29 class29_0, [Out] Class140 class140_0, JsonSerializerInternalReader jsonSerializerInternalReader_0)
	{
		if (class140_0.delegate7_1 != null)
		{
			if (class140_0.HasParameterizedCreator)
			{
				bool_0 = true;
				return class140_0.method_6();
			}
			bool_0 = false;
			return (IDictionary)class140_0.delegate7_1!();
		}
		if (class140_0.bool_3)
		{
			bool_0 = true;
			return class140_0.method_6();
		}
		if (class140_0.DefaultCreator != null && (!class140_0.DefaultCreatorNonPublic || jsonSerializerInternalReader_0.class34_0.enum0_0 == Enum0.const_1))
		{
			object obj = class140_0.DefaultCreator!();
			if (class140_0.ShouldCreateWrapper)
			{
				obj = class140_0.method_5(obj);
			}
			bool_0 = false;
			return (IDictionary)obj;
		}
		if (!class140_0.HasParameterizedCreatorInternal)
		{
			if (!class140_0.bool_5)
			{
				throw Class7.smethod_161(class29_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_1(CultureInfo.InvariantCulture, class140_0.UnderlyingType));
			}
			throw Class7.smethod_161(class29_0, "Unable to find a default constructor to use for type {0}.".smethod_1(CultureInfo.InvariantCulture, class140_0.UnderlyingType));
		}
		bool_0 = true;
		return class140_0.method_6();
	}

	static string smethod_116(string string_0)
	{
		return Class7.smethod_15(string_0, '_');
	}

	static void smethod_117(object object_0, Class176 class176_0)
	{
		class176_0.vmethod_18();
		class176_0.Add(object_0);
	}

	static void smethod_118(Class34 class34_0, Class38? class38_0, object object_0)
	{
		class34_0.vmethod_2(class38_0, object_0, null);
	}

	static int smethod_119(Class39 class39_0)
	{
		string newLine = class39_0.textWriter_0.NewLine;
		int length = newLine.Length;
		bool flag;
		if (flag = class39_0.char_3 != null && class39_0.char_3!.Length == 12 + length)
		{
			for (int i = 0; i != length; i++)
			{
				if (newLine[i] != class39_0.char_3[i])
				{
					flag = false;
					break;
				}
			}
		}
		if (!flag)
		{
			class39_0.char_3 = (newLine + new string(class39_0.char_0, 12)).ToCharArray();
		}
		return length;
	}

	static void smethod_120(Class30 class30_0)
	{
		if (!Class7.smethod_346(Class8.string_1, class30_0))
		{
			throw Class7.smethod_555((Class29)class30_0, "Error parsing boolean value.");
		}
		Class7.smethod_186((Class29)class30_0, JsonToken.Boolean, (object)false);
	}

	static JsonSchema smethod_121(Class172 class172_0, bool bool_0, Type type_0, Class167 class167_0)
	{
		Class113.smethod_0(type_0, "type");
		Class113.smethod_0(class172_0, "resolver");
		class167_0.class172_0 = class172_0;
		return Class7.smethod_77(class167_0, type_0, (!bool_0) ? Enum16.const_2 : Enum16.const_0, bool_0: false);
	}

	static int? smethod_122(StringComparison stringComparison_0, string[] string_0, string string_1, int int_0, string[] string_2, int int_1)
	{
		int? result = Class7.smethod_636(stringComparison_0, string_0, int_0, int_1, string_1);
		if (!result.HasValue)
		{
			result = Class7.smethod_636(stringComparison_0, string_2, int_0, int_1, string_1);
		}
		return result;
	}

	static Class178 smethod_123(Class29 class29_0, Class193? class193_0)
	{
		if (class29_0.TokenType == JsonToken.None && !class29_0.vmethod_0())
		{
			throw Class7.smethod_555(class29_0, "Error reading JConstructor from JsonReader.");
		}
		Class7.smethod_407(class29_0);
		if (class29_0.TokenType != JsonToken.StartConstructor)
		{
			throw Class7.smethod_555(class29_0, "Error reading JConstructor from JsonReader. Current JsonReader item is not a constructor: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		}
		Class178 @class = new Class178((string)class29_0.Value);
		@class.method_5(class29_0 as Interface1, class193_0);
		Class7.smethod_644((Class176)@class, class29_0, class193_0);
		return @class;
	}

	static void smethod_124(JsonSchemaWriter jsonSchemaWriter_0, Class38 class38_0, string string_0, IDictionary<string, JsonSchema> idictionary_0)
	{
		if (idictionary_0 == null)
		{
			return;
		}
		class38_0.vmethod_9(string_0);
		class38_0.vmethod_3();
		foreach (KeyValuePair<string, JsonSchema> item in idictionary_0)
		{
			class38_0.vmethod_9(item.Key);
			Class7.smethod_162(jsonSchemaWriter_0, item.Value);
		}
		class38_0.vmethod_4();
	}

	static void smethod_125(Class31 class31_0)
	{
		class31_0.class39_0.vmethod_12(class31_0.class29_0, bool_2: false, bool_3: false, bool_4: true);
	}

	static ulong smethod_126(object object_0)
	{
		bool bool_ = default(bool);
		return Class7.smethod_425(ref bool_, object_0.GetType()) switch
		{
			Enum21.const_2 => (char)object_0, 
			Enum21.const_4 => Convert.ToByte((bool)object_0), 
			Enum21.const_6 => (ulong)(sbyte)object_0, 
			Enum21.const_8 => (ulong)(short)object_0, 
			Enum21.const_10 => (ushort)object_0, 
			Enum21.const_12 => (ulong)(int)object_0, 
			Enum21.const_14 => (byte)object_0, 
			Enum21.const_16 => (uint)object_0, 
			Enum21.const_18 => (ulong)(long)object_0, 
			Enum21.const_20 => (ulong)object_0, 
			_ => throw new InvalidOperationException("Unknown enum type."), 
		};
	}

	static void smethod_127(IList<MemberInfo> ilist_0, Type type_0, BindingFlags bindingFlags_0)
	{
		if ((bindingFlags_0 & BindingFlags.NonPublic) == 0)
		{
			return;
		}
		BindingFlags bindingAttr = bindingFlags_0.smethod_7(BindingFlags.Public);
		while ((type_0 = type_0.smethod_6()) != null)
		{
			IEnumerable<FieldInfo> ienumerable_ = from fieldInfo_0 in type_0.GetFields(bindingAttr)
				where fieldInfo_0.IsPrivate
				select fieldInfo_0;
			ilist_0.smethod_1(ienumerable_);
		}
	}

	static bool smethod_128(Class179 class179_0, Class179 class179_1)
	{
		if (class179_0 != class179_1)
		{
			if (class179_0.jtokenType_10 == class179_1.jtokenType_10)
			{
				return Class179.smethod_37(class179_0.jtokenType_10, class179_0.object_1, class179_1.object_1) == 0;
			}
			return false;
		}
		return true;
	}

	static void smethod_129(Class27 class27_0, Class29 class29_0, Interface12 interface12_0, Interface11 interface11_0, string string_0, XmlNamespaceManager xmlNamespaceManager_0)
	{
		if (Class109.smethod_0(string_0))
		{
			throw Class7.smethod_161(class29_0, "XmlNodeConverter cannot convert JSON with an empty property name to XML.");
		}
		Dictionary<string, string> dictionary_ = null;
		string string_ = null;
		if (!class27_0.EncodeSpecialCharacters)
		{
			dictionary_ = (Class7.smethod_478(class27_0, class29_0) ? Class7.smethod_710(class27_0, class29_0, xmlNamespaceManager_0) : null);
			string_ = Class7.smethod_684(string_0);
			if (string_0.smethod_7('@'))
			{
				string text = string_0.Substring(1);
				string string_2 = Class7.smethod_684(text);
				Class7.smethod_481(string_2, class29_0, interface12_0, xmlNamespaceManager_0, interface11_0, text, string_0);
				return;
			}
			if (string_0.smethod_7('$'))
			{
				switch (string_0)
				{
				case "$id":
				case "$ref":
				case "$type":
				case "$value":
				{
					string string_3 = string_0.Substring(1);
					string string_4 = xmlNamespaceManager_0.LookupPrefix("http://james.newtonking.com/projects/json");
					Class7.smethod_481(string_4, class29_0, interface12_0, xmlNamespaceManager_0, interface11_0, string_3, string_0);
					return;
				}
				case "$values":
					string_0 = string_0.Substring(1);
					string_ = xmlNamespaceManager_0.LookupPrefix("http://james.newtonking.com/projects/json");
					class27_0.method_4(class29_0, interface12_0, interface11_0, string_0, xmlNamespaceManager_0, string_, dictionary_);
					return;
				}
			}
		}
		else if (Class7.smethod_478(class27_0, class29_0))
		{
			Class7.smethod_686(class29_0);
		}
		class27_0.method_4(class29_0, interface12_0, interface11_0, string_0, xmlNamespaceManager_0, string_, dictionary_);
	}

	static Struct6<JToken> smethod_130(JObject jobject_0)
	{
		return new Struct6<JToken>(from jproperty_0 in Class7.smethod_164(jobject_0)
			select jproperty_0.Value);
	}

	static string smethod_131(JToken jtoken_0)
	{
		Class113.smethod_0(jtoken_0, "token");
		if (jtoken_0 is JProperty jProperty)
		{
			jtoken_0 = jProperty.Value;
		}
		return jtoken_0.Type.ToString();
	}

	static void smethod_132(Type type_0, object? object_0, TextWriter textWriter_0, Class34 class34_0)
	{
		class34_0.method_8(new Class39(textWriter_0), object_0, type_0);
	}

	static void smethod_133(Class176.Class187 class187_0)
	{
		class187_0.int_0 = -3;
		if (class187_0.ienumerator_1 != null)
		{
			class187_0.ienumerator_1.Dispose();
		}
	}

	static bool? smethod_134(Class29 class29_0, string string_0)
	{
		if (Class109.smethod_0(string_0))
		{
			Class7.smethod_211(class29_0, JsonToken.Null, (object)null, bool_0: false);
			return null;
		}
		if (!bool.TryParse(string_0, out var result))
		{
			Class7.smethod_211(class29_0, JsonToken.String, (object)string_0, bool_0: false);
			throw Class7.smethod_555(class29_0, "Could not convert string to boolean: {0}.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		Class7.smethod_211(class29_0, JsonToken.Boolean, (object)result, bool_0: false);
		return result;
	}

	static JsonWriterException smethod_135(Class38 class38_0, object object_0)
	{
		return Class7.smethod_188(class38_0, "Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType()), (Exception?)null);
	}

	static byte smethod_136(Class33 class33_0)
	{
		Class7.smethod_452(class33_0, 1);
		return class33_0.binaryReader_0.ReadByte();
	}

	static int smethod_137(Class39 class39_0, uint uint_0, bool bool_0)
	{
		Class7.smethod_654(class39_0);
		int num = Class7.smethod_518((ulong)uint_0);
		if (bool_0)
		{
			num++;
			class39_0.char_2[0] = '-';
		}
		int num2 = num;
		do
		{
			uint num3 = uint_0 / 10u;
			uint num4 = uint_0 - num3 * 10;
			class39_0.char_2[--num2] = (char)(48 + num4);
			uint_0 = num3;
		}
		while (uint_0 != 0);
		return num;
	}

	static RegexOptions smethod_138(string string_0)
	{
		RegexOptions regexOptions = RegexOptions.None;
		for (int i = 0; i < string_0.Length; i++)
		{
			switch (string_0[i])
			{
			case 'm':
				regexOptions |= RegexOptions.Multiline;
				break;
			case 'i':
				regexOptions |= RegexOptions.IgnoreCase;
				break;
			case 'x':
				regexOptions |= RegexOptions.ExplicitCapture;
				break;
			case 's':
				regexOptions |= RegexOptions.Singleline;
				break;
			}
		}
		return regexOptions;
	}

	static void smethod_139(Enum8 enum8_0, Class30 class30_0, char char_0)
	{
		Class7.smethod_621((Class29)class30_0, bool_0: true);
		switch (enum8_0)
		{
		case Enum8.const_3:
		{
			Guid guid_;
			byte[] object_2 = ((class30_0.struct4_0.Length == 0) ? Class45.smethod_10<byte>() : ((class30_0.struct4_0.Length != 36 || !Class7.smethod_661(class30_0.struct4_0.ToString(), out guid_)) ? Convert.FromBase64CharArray(class30_0.struct4_0.Chars, class30_0.struct4_0.StartIndex, class30_0.struct4_0.Length) : guid_.ToByteArray()));
			Class7.smethod_211((Class29)class30_0, JsonToken.Bytes, (object)object_2, bool_0: false);
			return;
		}
		case Enum8.const_4:
		{
			string object_ = class30_0.struct4_0.ToString();
			Class7.smethod_211((Class29)class30_0, JsonToken.String, (object)object_, bool_0: false);
			class30_0.char_0 = char_0;
			return;
		}
		case Enum8.const_1:
		case Enum8.const_5:
		case Enum8.const_9:
			return;
		}
		if (class30_0.enum2_0 != 0)
		{
			DateTimeOffset dateTimeOffset_;
			if (enum8_0 switch
			{
				Enum8.const_6 => 1, 
				Enum8.const_7 => 2, 
				_ => (int)class30_0.enum2_0, 
			} == 1)
			{
				Struct4 struct4_ = class30_0.struct4_0;
				Enum3 enum3_ = class30_0.enum3_0;
				string string_ = class30_0.string_0;
				CultureInfo culture = class30_0.Culture;
				DateTime dateTime_ = default(DateTime);
				if (Class7.smethod_231(culture, enum3_, struct4_, ref dateTime_, string_))
				{
					Class7.smethod_211((Class29)class30_0, JsonToken.Date, (object)dateTime_, bool_0: false);
					return;
				}
			}
			else if (Class7.smethod_577(class30_0.struct4_0, class30_0.string_0, class30_0.Culture, out dateTimeOffset_))
			{
				Class7.smethod_211((Class29)class30_0, JsonToken.Date, (object)dateTimeOffset_, bool_0: false);
				return;
			}
		}
		Class7.smethod_211((Class29)class30_0, JsonToken.String, (object)class30_0.struct4_0.ToString(), bool_0: false);
		class30_0.char_0 = char_0;
	}

	static bool smethod_140(Class30 class30_0, char char_0, int int_0)
	{
		if (Class7.smethod_2(class30_0, char_0))
		{
			class30_0.int_3++;
			return false;
		}
		if (!char.IsWhiteSpace(char_0) && char_0 != ':')
		{
			throw Class7.smethod_555((Class29)class30_0, "Invalid JavaScript property identifier character: {0}.".smethod_1(CultureInfo.InvariantCulture, char_0));
		}
		class30_0.struct4_0 = new Struct4(class30_0.char_2, int_0, class30_0.int_3 - int_0);
		return true;
	}

	static string smethod_141(DateTimeOffset dateTimeOffset_0, Enum1 enum1_0)
	{
		using StringWriter stringWriter = Class7.smethod_470(64);
		stringWriter.Write('"');
		Class51.smethod_3(stringWriter, dateTimeOffset_0, enum1_0, null, CultureInfo.InvariantCulture);
		stringWriter.Write('"');
		return stringWriter.ToString();
	}

	static void smethod_142(Class176.Class187 class187_0)
	{
		class187_0.int_0 = -1;
		if (class187_0.ienumerator_0 != null)
		{
			class187_0.ienumerator_0.Dispose();
		}
	}

	static bool smethod_143(Type type_0)
	{
		TypeConverter typeConverter_ = default(TypeConverter);
		if (Class7.smethod_511(ref typeConverter_, type_0))
		{
			return true;
		}
		if (!(type_0 == typeof(Type)) && !type_0.IsSubclassOf(typeof(Type)))
		{
			return false;
		}
		return true;
	}

	static JToken smethod_144(string string_0, Class193? class193_0)
	{
		using Class29 @class = new Class30(new StringReader(string_0));
		JToken result = Class7.smethod_605(@class, class193_0);
		while (@class.vmethod_0())
		{
		}
		return result;
	}

	static bool smethod_145(Class212 class212_0, string string_0)
	{
		int num = class212_0.int_0;
		int num2 = 0;
		while (true)
		{
			if (num2 < string_0.Length)
			{
				if (num >= class212_0.string_0.Length || class212_0.string_0[num] != string_0[num2])
				{
					break;
				}
				num++;
				num2++;
				continue;
			}
			class212_0.int_0 = num;
			return true;
		}
		return false;
	}

	static void smethod_146(Class39 class39_0, uint uint_0, bool bool_0)
	{
		if (!bool_0 && uint_0 <= 9)
		{
			class39_0.textWriter_0.Write((char)(48 + uint_0));
			return;
		}
		int count = Class7.smethod_137(class39_0, uint_0, bool_0);
		class39_0.textWriter_0.Write(class39_0.char_2, 0, count);
	}

	static void smethod_147(Class42 class42_0, string string_0, string string_1)
	{
		Class113.smethod_0(string_0, "pattern");
		Class7.smethod_447((Class38)class42_0, JsonToken.Undefined, (object)null);
		Class7.smethod_761(class42_0, (Class242)new Class250(string_0, string_1));
	}

	static JsonSchema smethod_148(Class172 class172_0, Class29 class29_0)
	{
		Class113.smethod_0(class29_0, "reader");
		Class113.smethod_0(class172_0, "resolver");
		return Class7.smethod_466(new Class164(class172_0), class29_0);
	}

	static JsonSchemaNode smethod_149(JsonSchemaNode jsonSchemaNode_0, JsonSchema jsonSchema_0)
	{
		return new JsonSchemaNode(jsonSchemaNode_0, jsonSchema_0);
	}

	static object smethod_150(params int[] int_0)
	{
		Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
		Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a");
		Array array = Array.CreateInstance(type, int_0.Length);
		for (int i = 0; i < int_0.Length; i++)
		{
			object value = type.GetMethod("Create", new Type[2]
			{
				type2,
				typeof(string)
			})!.Invoke(null, new object[2] { 0, null });
			array.SetValue(value, i);
		}
		return array;
	}

	static void smethod_151(Class24 class24_0, Class38 class38_0, Regex regex_0, Class34 class34_0)
	{
		DefaultContractResolver defaultContractResolver = class34_0.ContractResolver as DefaultContractResolver;
		class38_0.vmethod_3();
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Pattern") : "Pattern");
		class38_0.vmethod_21(regex_0.ToString());
		class38_0.vmethod_9((defaultContractResolver != null) ? defaultContractResolver.method_4("Options") : "Options");
		Class7.smethod_118(class34_0, class38_0, (object)regex_0.Options);
		class38_0.vmethod_4();
	}

	static void smethod_152(IDictionary<string, JsonSchemaNode> idictionary_0, Class170 class170_0, JsonSchema jsonSchema_0, string string_0)
	{
		idictionary_0.TryGetValue(string_0, out var value);
		idictionary_0[string_0] = Class7.smethod_503(value, class170_0, jsonSchema_0);
	}

	static void smethod_153(bool bool_0, Class29 class29_0, Class137 class137_0)
	{
		if (!Class7.smethod_440(class29_0, class137_0, bool_0))
		{
			throw Class7.smethod_161(class29_0, "Unexpected end when reading JSON.");
		}
	}

	static bool smethod_154(bool bool_0, JToken jtoken_0, JTokenType[] jtokenType_0)
	{
		if (Array.IndexOf(jtokenType_0, jtoken_0.Type) == -1)
		{
			if (bool_0)
			{
				if (jtoken_0.Type != JTokenType.Null)
				{
					return jtoken_0.Type == JTokenType.Undefined;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	static bool smethod_155(double double_0, double double_1)
	{
		if (double_0 == double_1)
		{
			return true;
		}
		double num = (Math.Abs(double_0) + Math.Abs(double_1) + 10.0) * 2.220446049250313E-16;
		double num2 = double_0 - double_1;
		if (0.0 - num < num2)
		{
			return num > num2;
		}
		return false;
	}

	static void smethod_156(DefaultContractResolver defaultContractResolver_0, Class137 class137_0, Type type_0)
	{
		defaultContractResolver_0.method_2(type_0, out var list_, out var list_2, out var list_3, out var list_4, out var list_5);
		if (list_ != null)
		{
			class137_0.OnSerializingCallbacks.smethod_1(list_);
		}
		if (list_2 != null)
		{
			class137_0.OnSerializedCallbacks.smethod_1(list_2);
		}
		if (list_3 != null)
		{
			class137_0.OnDeserializingCallbacks.smethod_1(list_3);
		}
		if (list_4 != null)
		{
			class137_0.OnDeserializedCallbacks.smethod_1(list_4);
		}
		if (list_5 != null)
		{
			class137_0.OnErrorCallbacks.smethod_1(list_5);
		}
	}

	static bool smethod_157(Type type_0)
	{
		Class113.smethod_0(type_0, "t");
		if (type_0.smethod_4())
		{
			return type_0.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	static Type smethod_158(Type type_0)
	{
		object arg = ((object[])FSharpUtils.fsharpUtils_0!.GetUnionCases(null, type_0, null)).First();
		return (Type)FSharpUtils.fsharpUtils_0!.GetUnionCaseInfoDeclaringType(arg);
	}

	static string smethod_159(string string_0, Class164 class164_0)
	{
		return Uri.UnescapeDataString(string_0).Replace("~1", "/").Replace("~0", "~");
	}

	static byte[] smethod_160(Class29 class29_0, Class11 class11_0)
	{
		List<byte> list = new List<byte>();
		while (class29_0.vmethod_0())
		{
			switch (class29_0.TokenType)
			{
			case JsonToken.Integer:
				list.Add(Convert.ToByte(class29_0.Value, CultureInfo.InvariantCulture));
				break;
			case JsonToken.Comment:
				break;
			default:
				throw Class7.smethod_161(class29_0, "Unexpected token when reading bytes: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
			case JsonToken.EndArray:
				return list.ToArray();
			}
		}
		throw Class7.smethod_161(class29_0, "Unexpected end when reading bytes.");
	}

	static JsonSerializationException smethod_161(Class29 class29_0, string string_0)
	{
		return Class7.smethod_383(string_0, (Exception)null, class29_0);
	}

	static void smethod_162(JsonSchemaWriter jsonSchemaWriter_0, JsonSchema jsonSchema_0)
	{
		if (jsonSchema_0.Id != null && jsonSchemaWriter_0.class172_0.vmethod_0(jsonSchema_0.Id) != null)
		{
			jsonSchemaWriter_0.class38_0.vmethod_3();
			jsonSchemaWriter_0.class38_0.vmethod_9("$ref");
			jsonSchemaWriter_0.class38_0.vmethod_21(jsonSchema_0.Id);
			jsonSchemaWriter_0.class38_0.vmethod_4();
		}
		else
		{
			Class7.smethod_507(jsonSchemaWriter_0, jsonSchema_0);
		}
	}

	static void smethod_163(string string_0, JsonSchemaType jsonSchemaType_0, JsonSchemaWriter jsonSchemaWriter_0, Class38 class38_0)
	{
		if (Enum.IsDefined(typeof(JsonSchemaType), jsonSchemaType_0))
		{
			class38_0.vmethod_9(string_0);
			class38_0.vmethod_21(Class7.smethod_624(jsonSchemaType_0));
			return;
		}
		IEnumerator<JsonSchemaType> enumerator = (from jsonSchemaType_0 in EnumUtils.smethod_0(jsonSchemaType_0)
			where jsonSchemaType_0 != JsonSchemaType.None
			select jsonSchemaType_0).GetEnumerator();
		if (!enumerator.MoveNext())
		{
			return;
		}
		class38_0.vmethod_9(string_0);
		JsonSchemaType current = enumerator.Current;
		if (enumerator.MoveNext())
		{
			class38_0.vmethod_5();
			class38_0.vmethod_21(Class7.smethod_624(current));
			do
			{
				class38_0.vmethod_21(Class7.smethod_624(enumerator.Current));
			}
			while (enumerator.MoveNext());
			class38_0.vmethod_6();
		}
		else
		{
			class38_0.vmethod_21(Class7.smethod_624(current));
		}
	}

	static IEnumerable<JProperty> smethod_164(JObject jobject_0)
	{
		return jobject_0.class192_0.Cast<JProperty>();
	}

	static void smethod_165(Class29 class29_0, DataTable dataTable_0, Class34 class34_0)
	{
		DataRow dataRow = dataTable_0.NewRow();
		Class7.smethod_686(class29_0);
		while (class29_0.TokenType == JsonToken.PropertyName)
		{
			string text = (string)class29_0.Value;
			Class7.smethod_686(class29_0);
			DataColumn dataColumn = dataTable_0.Columns[text];
			if (dataColumn == null)
			{
				Type dataType = Class7.smethod_0(class29_0);
				dataColumn = new DataColumn(text, dataType);
				dataTable_0.Columns.Add(dataColumn);
			}
			if (dataColumn.DataType == typeof(DataTable))
			{
				if (class29_0.TokenType == JsonToken.StartArray)
				{
					Class7.smethod_686(class29_0);
				}
				DataTable dataTable = new DataTable();
				while (class29_0.TokenType != JsonToken.EndArray)
				{
					Class7.smethod_165(class29_0, dataTable, class34_0);
					Class7.smethod_686(class29_0);
				}
				dataRow[text] = dataTable;
			}
			else if (!dataColumn.DataType.IsArray || !(dataColumn.DataType != typeof(byte[])))
			{
				object obj2 = (dataRow[text] = ((class29_0.Value != null) ? (class34_0.method_5(class29_0, dataColumn.DataType) ?? DBNull.Value) : DBNull.Value));
			}
			else
			{
				if (class29_0.TokenType == JsonToken.StartArray)
				{
					Class7.smethod_686(class29_0);
				}
				List<object> list = new List<object>();
				while (class29_0.TokenType != JsonToken.EndArray)
				{
					list.Add(class29_0.Value);
					Class7.smethod_686(class29_0);
				}
				Array array = Array.CreateInstance(dataColumn.DataType.GetElementType(), list.Count);
				((ICollection)list).CopyTo(array, 0);
				dataRow[text] = array;
			}
			Class7.smethod_686(class29_0);
		}
		dataRow.EndEdit();
		dataTable_0.Rows.Add(dataRow);
	}

	static Class151 smethod_166(Class35 class35_0)
	{
		if (class35_0.jsonSerializerInternalReader_0 != null)
		{
			return class35_0.jsonSerializerInternalReader_0;
		}
		return class35_0.class152_0;
	}

	static Class135 smethod_167(string? string_0, Class151? class151_0, object object_0, Exception exception_0, object object_1)
	{
		if (class151_0!.class135_0 == null)
		{
			class151_0!.class135_0 = new Class135(object_1, object_0, string_0, exception_0);
		}
		if (class151_0!.class135_0!.Error != exception_0)
		{
			throw new InvalidOperationException("Current error context error is different to requested error.");
		}
		return class151_0!.class135_0;
	}

	static void smethod_168(int int_0, Class30 class30_0, char char_0, int int_1)
	{
		if (int_1 > int_0)
		{
			class30_0.struct3_0.method_1(class30_0.interface0_0, class30_0.char_2, int_0, int_1 - int_0);
		}
		class30_0.struct3_0.method_0(class30_0.interface0_0, char_0);
	}

	static string smethod_169(int int_0, Class33 class33_0)
	{
		if (int_0 == 0)
		{
			return string.Empty;
		}
		Class7.smethod_739(class33_0);
		StringBuilder stringBuilder = null;
		int num = 0;
		int num2 = 0;
		do
		{
			int count = ((int_0 - num <= 128 - num2) ? (int_0 - num) : (128 - num2));
			int num3 = class33_0.binaryReader_0.Read(class33_0.byte_4, num2, count);
			if (num3 != 0)
			{
				num += num3;
				num3 += num2;
				if (num3 != int_0)
				{
					int num4 = Class7.smethod_633(class33_0, num3 - 1);
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder(int_0);
					}
					int chars = Encoding.UTF8.GetChars(class33_0.byte_4, 0, num4 + 1, class33_0.char_1, 0);
					stringBuilder.Append(class33_0.char_1, 0, chars);
					if (num4 < num3 - 1)
					{
						num2 = num3 - num4 - 1;
						Array.Copy(class33_0.byte_4, num4 + 1, class33_0.byte_4, 0, num2);
					}
					else
					{
						num2 = 0;
					}
					continue;
				}
				int chars2 = Encoding.UTF8.GetChars(class33_0.byte_4, 0, num3, class33_0.char_1, 0);
				return new string(class33_0.char_1, 0, chars2);
			}
			throw new EndOfStreamException("Unable to read beyond the end of the stream.");
		}
		while (num < int_0);
		return stringBuilder.ToString();
	}

	static void smethod_170(Class33 class33_0, Class33.Class241 class241_0)
	{
		class33_0.list_1.Add(class241_0);
		class33_0.class241_0 = class241_0;
	}

	static JToken smethod_171(int int_0, JToken jtoken_0, Class195 class195_0)
	{
		if (jtoken_0 is Class177 @class)
		{
			if (@class.Count <= int_0)
			{
				if (class195_0 != null && class195_0.ErrorWhenNoMatch)
				{
					throw new JsonException("Index {0} outside the bounds of JArray.".smethod_1(CultureInfo.InvariantCulture, int_0));
				}
				return null;
			}
			return @class[int_0];
		}
		if (jtoken_0 is Class178 class2)
		{
			if (class2.Count <= int_0)
			{
				if (class195_0 != null && class195_0.ErrorWhenNoMatch)
				{
					throw new JsonException("Index {0} outside the bounds of JConstructor.".smethod_1(CultureInfo.InvariantCulture, int_0));
				}
				return null;
			}
			return class2[int_0];
		}
		if (class195_0 != null && class195_0.ErrorWhenNoMatch)
		{
			throw new JsonException("Index {0} not valid on {1}.".smethod_2(CultureInfo.InvariantCulture, int_0, jtoken_0.GetType().Name));
		}
		return null;
	}

	static void smethod_172(JsonProperty jsonProperty_0, Class143 class143_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, int int_0, JsonSerializerInternalReader.PropertyPresence propertyPresence_0, Class29 class29_0, object object_0, bool bool_0)
	{
		if (propertyPresence_0 != 0 && propertyPresence_0 != JsonSerializerInternalReader.PropertyPresence.Null)
		{
			return;
		}
		try
		{
			Enum16 @enum = ((!jsonProperty_0.Ignored) ? (jsonProperty_0.nullable_0 ?? class143_0.ItemRequired.GetValueOrDefault()) : Enum16.const_0);
			switch (propertyPresence_0)
			{
			case JsonSerializerInternalReader.PropertyPresence.Null:
				switch (@enum)
				{
				case Enum16.const_2:
					throw Class7.smethod_161(class29_0, "Required property '{0}' expects a value but got null.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0.string_0));
				case Enum16.const_3:
					throw Class7.smethod_161(class29_0, "Required property '{0}' expects a non-null value.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0.string_0));
				}
				break;
			case JsonSerializerInternalReader.PropertyPresence.None:
				if (@enum != Enum16.const_1 && @enum != Enum16.const_2)
				{
					if (bool_0 && !jsonProperty_0.Ignored)
					{
						if (jsonProperty_0.PropertyContract == null)
						{
							jsonProperty_0.PropertyContract = jsonSerializerInternalReader_0.method_1(jsonProperty_0.type_0);
						}
						if (Class7.smethod_580(jsonSerializerInternalReader_0, jsonProperty_0.DefaultValueHandling.GetValueOrDefault(jsonSerializerInternalReader_0.class34_0.enum4_0), Enum4.flag_2) && jsonProperty_0.Writable)
						{
							jsonProperty_0.ValueProvider!.imethod_0(object_0, jsonSerializerInternalReader_0.method_12(class29_0, Class7.smethod_493(jsonProperty_0), CultureInfo.InvariantCulture, jsonProperty_0.PropertyContract, jsonProperty_0.type_0));
						}
					}
					break;
				}
				throw Class7.smethod_161(class29_0, "Required property '{0}' not found in JSON.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0.string_0));
			}
		}
		catch (Exception exception_)
		{
			if (!jsonSerializerInternalReader_0.method_0(object_0, class143_0, jsonProperty_0.string_0, class29_0 as Interface1, class29_0.Path, exception_))
			{
				throw;
			}
			Class7.smethod_53(class29_0, bool_0: true, jsonSerializerInternalReader_0, int_0);
		}
	}

	static void smethod_173(int int_0, int int_1, char[] char_0, Class43 class43_0)
	{
		class43_0.textWriter_0.Write(char_0, int_0, int_1);
	}

	static void smethod_174(Class30 class30_0)
	{
		if (!Class7.smethod_346(Class8.string_3, class30_0))
		{
			throw Class7.smethod_555((Class29)class30_0, "Error parsing undefined value.");
		}
		Class7.smethod_386((Class29)class30_0, JsonToken.Undefined);
	}

	static Class177 smethod_175(string string_0, Class193? class193_0)
	{
		using Class29 @class = new Class30(new StringReader(string_0));
		Class177 result = Class7.smethod_92(@class, class193_0);
		while (@class.vmethod_0())
		{
		}
		return result;
	}

	static void smethod_176(int int_0, Class38 class38_0, Class152 class152_0)
	{
		Class7.smethod_285((Class151)class152_0);
		if (class38_0.WriteState == Enum20.const_5)
		{
			class38_0.vmethod_17();
		}
		while (class38_0.Top > int_0)
		{
			class38_0.vmethod_11();
		}
	}

	static ConstructorInfo? smethod_177(DefaultContractResolver defaultContractResolver_0, Type type_0)
	{
		ConstructorInfo[] constructors = type_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		if (constructors.Length == 1)
		{
			return constructors[0];
		}
		return null;
	}

	static JObject smethod_178(string string_0)
	{
		return Class7.smethod_486(string_0, (Class193?)null);
	}

	static bool smethod_179(Type type_0, bool bool_0)
	{
		Class113.smethod_0(type_0, "t");
		if (type_0.smethod_13())
		{
			return true;
		}
		return Class7.smethod_189(type_0, bool_0) != null;
	}

	static ConstructorInfo? smethod_180(Class150 class150_0, Type type_0, DefaultContractResolver defaultContractResolver_0)
	{
		IEnumerator<ConstructorInfo> enumerator = ((IEnumerable<ConstructorInfo>)type_0.GetConstructors()).GetEnumerator();
		if (enumerator.MoveNext())
		{
			ConstructorInfo current = enumerator.Current;
			if (!enumerator.MoveNext())
			{
				ParameterInfo[] parameters = current.GetParameters();
				if (parameters.Length != 0)
				{
					ParameterInfo[] array = parameters;
					int num = 0;
					while (true)
					{
						if (num < array.Length)
						{
							ParameterInfo parameterInfo = array[num];
							string name = parameterInfo.Name;
							Type parameterType = parameterInfo.ParameterType;
							JsonProperty jsonProperty = Class7.smethod_49(name, parameterType, class150_0, defaultContractResolver_0);
							if (jsonProperty == null || jsonProperty.Writable)
							{
								break;
							}
							num++;
							continue;
						}
						return current;
					}
					return null;
				}
			}
		}
		return null;
	}

	static JToken smethod_181(Guid? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static bool smethod_182(MemberInfo memberInfo_0)
	{
		if (memberInfo_0 is PropertyInfo propertyInfo)
		{
			if (Class7.smethod_670(propertyInfo))
			{
				return false;
			}
			return !Class7.smethod_434(propertyInfo.PropertyType);
		}
		if (memberInfo_0 is FieldInfo fieldInfo)
		{
			return !Class7.smethod_434(fieldInfo.FieldType);
		}
		return true;
	}

	static IEnumerable<JToken> smethod_183(JToken jtoken_0)
	{
		return Class7.smethod_45(bool_0: true, jtoken_0);
	}

	static DateTime smethod_184(DateTime dateTime_0)
	{
		return dateTime_0.Kind switch
		{
			DateTimeKind.Unspecified => new DateTime(dateTime_0.Ticks, DateTimeKind.Local), 
			DateTimeKind.Utc => dateTime_0.ToLocalTime(), 
			DateTimeKind.Local => dateTime_0, 
			_ => dateTime_0, 
		};
	}

	static bool smethod_185(JsonProperty jsonProperty_0, Class152 class152_0, Class38 class38_0, object object_0)
	{
		if (jsonProperty_0.GetIsSpecified == null)
		{
			return true;
		}
		bool flag = jsonProperty_0.GetIsSpecified!(object_0);
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class38_0.Path, "IsSpecified result for property '{0}' on {1}: {2}".smethod_3(CultureInfo.InvariantCulture, jsonProperty_0.string_0, jsonProperty_0.DeclaringType, flag)), null);
		}
		return flag;
	}

	static void smethod_186(Class29 class29_0, JsonToken jsonToken_0, object object_0)
	{
		Class7.smethod_211(class29_0, jsonToken_0, object_0, bool_0: true);
	}

	static bool smethod_187(Class30 class30_0)
	{
		if (class30_0.int_2 == class30_0.int_3)
		{
			if (Class7.smethod_418(bool_0: false, class30_0) == 0)
			{
				class30_0.bool_3 = true;
				return true;
			}
		}
		else
		{
			class30_0.int_3++;
		}
		return false;
	}

	static JsonWriterException smethod_188(Class38 class38_0, string string_0, Exception? exception_0)
	{
		return Class7.smethod_26(string_0, class38_0.ContainerPath, exception_0);
	}

	static ConstructorInfo smethod_189(Type type_0, bool bool_0)
	{
		BindingFlags bindingFlags = BindingFlags.Instance | BindingFlags.Public;
		if (bool_0)
		{
			bindingFlags |= BindingFlags.NonPublic;
		}
		return type_0.GetConstructors(bindingFlags).SingleOrDefault((ConstructorInfo constructorInfo_0) => !constructorInfo_0.GetParameters().Any());
	}

	static Class35 smethod_190(JsonSerializerInternalReader jsonSerializerInternalReader_0)
	{
		if (jsonSerializerInternalReader_0.class35_0 == null)
		{
			jsonSerializerInternalReader_0.class35_0 = new Class35(jsonSerializerInternalReader_0);
		}
		return jsonSerializerInternalReader_0.class35_0;
	}

	static int smethod_191(Class239 class239_0, Class242 class242_0)
	{
		switch (class242_0.Type)
		{
		case BsonType.Number:
			return 8;
		case BsonType.String:
		{
			Class248 class3 = (Class248)class242_0;
			string text = (string)class3.object_0;
			class3.ByteCount = ((text != null) ? Class239.encoding_0.GetByteCount(text) : 0);
			class3.CalculatedSize = Class7.smethod_202(int_0: class3.ByteCount, bool_0: class3.IncludeLength, class239_0: class239_0);
			return class3.CalculatedSize;
		}
		case BsonType.Object:
		{
			Class243 class4 = (Class243)class242_0;
			int num6 = 4;
			using (IEnumerator<Class251> enumerator2 = class4.System_002ECollections_002EGeneric_002EIEnumerable_003Cns8_002EClass251_003E_002EGetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					Class251 current2 = enumerator2.Current;
					int num7 = 1;
					num7 = 1 + Class7.smethod_191(class239_0, (Class242)current2.Name);
					num7 += Class7.smethod_191(class239_0, current2.Value);
					num6 += num7;
				}
			}
			return class4.CalculatedSize = num6 + 1;
		}
		case BsonType.Array:
		{
			Class244 class2 = (Class244)class242_0;
			int num3 = 4;
			ulong num4 = 0uL;
			using (IEnumerator<Class242> enumerator = class2.System_002ECollections_002EGeneric_002EIEnumerable_003Cns10_002EClass242_003E_002EGetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class242 current = enumerator.Current;
					num3++;
					num3 += Class7.smethod_314(class239_0, Class7.smethod_518(num4));
					num3 += Class7.smethod_191(class239_0, current);
					num4++;
				}
			}
			num3 = (class2.CalculatedSize = num3 + 1);
			return class2.CalculatedSize;
		}
		case BsonType.Binary:
		{
			Class249 obj = (Class249)class242_0;
			byte[] array = (byte[])obj.object_0;
			obj.CalculatedSize = 5 + array.Length;
			return obj.CalculatedSize;
		}
		case BsonType.Oid:
			return 12;
		case BsonType.Boolean:
			return 1;
		case BsonType.Date:
			return 8;
		case BsonType.Undefined:
		case BsonType.Null:
			return 0;
		case BsonType.Regex:
		{
			Class250 @class = (Class250)class242_0;
			int num = 0;
			num = 0 + Class7.smethod_191(class239_0, (Class242)@class.Pattern);
			num = (@class.CalculatedSize = num + Class7.smethod_191(class239_0, (Class242)@class.Options));
			return @class.CalculatedSize;
		}
		case BsonType.Integer:
			return 4;
		default:
			throw new ArgumentOutOfRangeException("t", "Unexpected token when writing BSON: {0}".smethod_1(CultureInfo.InvariantCulture, class242_0.Type));
		case BsonType.Long:
			return 8;
		}
	}

	static bool smethod_192(string string_0, JObject jobject_0, [Attribute1(true)] out JToken? jtoken_0, StringComparison stringComparison_0)
	{
		jtoken_0 = jobject_0.method_20(string_0, stringComparison_0);
		return jtoken_0 != null;
	}

	static Guid smethod_193(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_4))
		{
			if (@class.Value is byte[] b)
			{
				return new Guid(b);
			}
			object value = @class.Value;
			if (value is Guid)
			{
				return (Guid)value;
			}
			return new Guid(Convert.ToString(@class.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to Guid.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static string smethod_194(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		bool flag2 = false;
		foreach (char c in string_0)
		{
			switch (c)
			{
			default:
				if (!flag2)
				{
					stringBuilder.Append(c);
				}
				break;
			case '[':
			case ']':
				flag = false;
				flag2 = false;
				stringBuilder.Append(c);
				break;
			case ',':
				if (!flag)
				{
					flag = true;
					stringBuilder.Append(c);
				}
				else
				{
					flag2 = true;
				}
				break;
			}
		}
		return stringBuilder.ToString();
	}

	static Enum12 smethod_195(Class143? class143_0, JsonProperty jsonProperty_0, Class151 class151_0)
	{
		return jsonProperty_0.NullValueHandling ?? class143_0?.ItemNullValueHandling ?? class151_0.class34_0.enum12_0;
	}

	static CallSite<Func<CallSite, object, object>> smethod_196(string string_0)
	{
		return CallSite<Func<CallSite, object, object>>.Create(new Class74((GetMemberBinder)Class7.smethod_358(string_0, typeof(Class72))));
	}

	static bool smethod_197(Class30 class30_0)
	{
		char c = class30_0.char_2[class30_0.int_3];
		char c2;
		if (c != '"' && c != '\'')
		{
			if (!Class7.smethod_2(class30_0, c))
			{
				throw Class7.smethod_555((Class29)class30_0, "Invalid property identifier character: {0}.".smethod_1(CultureInfo.InvariantCulture, class30_0.char_2[class30_0.int_3]));
			}
			c2 = '\0';
			Class7.smethod_38(class30_0);
			Class7.smethod_243(class30_0);
		}
		else
		{
			class30_0.int_3++;
			c2 = c;
			Class7.smethod_38(class30_0);
			class30_0.method_7(c2);
		}
		string text;
		if (class30_0.PropertyNameTable != null)
		{
			text = class30_0.PropertyNameTable!.vmethod_0(class30_0.struct4_0.Chars, class30_0.struct4_0.StartIndex, class30_0.struct4_0.Length);
			if (text == null)
			{
				text = class30_0.struct4_0.ToString();
			}
		}
		else
		{
			text = class30_0.struct4_0.ToString();
		}
		Class7.smethod_437(class30_0);
		if (class30_0.char_2[class30_0.int_3] != ':')
		{
			throw Class7.smethod_555((Class29)class30_0, "Invalid character after parsing property name. Expected ':' but got: {0}.".smethod_1(CultureInfo.InvariantCulture, class30_0.char_2[class30_0.int_3]));
		}
		class30_0.int_3++;
		Class7.smethod_186((Class29)class30_0, JsonToken.PropertyName, (object)text);
		class30_0.char_0 = c2;
		Class7.smethod_527(class30_0);
		return true;
	}

	static Func<object> smethod_198(Type type_0, DefaultContractResolver defaultContractResolver_0)
	{
		return JsonTypeReflector.ReflectionDelegateFactory.vmethod_2<object>(type_0);
	}

	static string smethod_199(Enum7 enum7_0, params Class9[] class9_0, JToken jtoken_0)
	{
		using StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
		Class39 @class = new Class39(stringWriter);
		@class.Formatting = enum7_0;
		jtoken_0.vmethod_5(@class, class9_0);
		return stringWriter.ToString();
	}

	static void smethod_200(Class202.Class210 class210_0)
	{
		class210_0.int_0 = -3;
		if (class210_0.ienumerator_1 != null)
		{
			class210_0.ienumerator_1.Dispose();
		}
	}

	static bool smethod_201(Class192 class192_0, JToken jtoken_0)
	{
		if (class192_0.dictionary_0 == null)
		{
			return false;
		}
		string key = Class7.smethod_267(class192_0, jtoken_0);
		JToken value;
		return class192_0.dictionary_0!.TryGetValue(key, out value);
	}

	static int smethod_202(bool bool_0, int int_0, Class239 class239_0)
	{
		return ((!bool_0) ? 1 : 5) + int_0;
	}

	static void smethod_203(Class204.Class217 class217_0)
	{
		class217_0.int_0 = -3;
		if (class217_0.ienumerator_1 != null)
		{
			class217_0.ienumerator_1.Dispose();
		}
	}

	static void smethod_204(ref int int_0, out int int_1, [Out] DateTime dateTime_0, out int int_2)
	{
		int num = (int)(dateTime_0.Ticks / 864000000000L);
		int num2 = num / 146097;
		num -= num2 * 146097;
		int num3 = num / 36524;
		if (num3 == 4)
		{
			num3 = 3;
		}
		num -= num3 * 36524;
		int num4 = num / 1461;
		num -= num4 * 1461;
		int num5 = num / 365;
		if (num5 == 4)
		{
			num5 = 3;
		}
		int_2 = num2 * 400 + num3 * 100 + num4 * 4 + num5 + 1;
		num -= num5 * 365;
		int[] array = ((num5 == 3 && (num4 != 24 || num3 == 3)) ? Class51.int_5 : Class51.int_4);
		int i;
		for (i = num >> 6; num >= array[i]; i++)
		{
		}
		int_0 = i;
		int_1 = num - array[i - 1] + 1;
	}

	static void smethod_205(Class242 class242_0, Class42 class42_0)
	{
		Class7.smethod_761(class42_0, class242_0);
		class42_0.class242_1 = class242_0;
	}

	static bool smethod_206(PropertyInfo propertyInfo_0)
	{
		MethodInfo getMethod = propertyInfo_0.GetGetMethod();
		if (getMethod != null && getMethod.IsPublic)
		{
			return true;
		}
		MethodInfo setMethod = propertyInfo_0.GetSetMethod();
		if (setMethod != null && setMethod.IsPublic)
		{
			return true;
		}
		return false;
	}

	static void smethod_207(Class152 class152_0, Class38 class38_0, object object_0, Class143? class143_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty jsonProperty_1)
	{
		Class7.smethod_246(class152_0, class38_0, (Class137)class143_0, object_0);
		class152_0.list_0.Add(object_0);
		Class7.smethod_282((Class137)class143_0, class38_0, object_0, class152_0, jsonProperty_0, jsonProperty_1, class138_0);
		int top = class38_0.Top;
		Class137 class137_ = default(Class137);
		for (int i = 0; i < class143_0!.Properties.Count; i++)
		{
			JsonProperty jsonProperty = class143_0!.Properties[i];
			try
			{
				if (Class7.smethod_336(ref class137_, class38_0, jsonProperty_0, object_0, jsonProperty, (Class138?)class143_0, out object object_, class152_0))
				{
					jsonProperty.method_0(class38_0);
					class152_0.method_3(class38_0, object_, class137_, jsonProperty, class143_0, jsonProperty_0);
				}
			}
			catch (Exception exception_)
			{
				if (!class152_0.method_0(object_0, class143_0, jsonProperty.string_0, null, class38_0.ContainerPath, exception_))
				{
					throw;
				}
				Class7.smethod_176(top, class38_0, class152_0);
			}
		}
		IEnumerable<KeyValuePair<object, object>> enumerable = class143_0!.ExtensionDataGetter?.Invoke(object_0);
		if (enumerable != null)
		{
			foreach (KeyValuePair<object, object> item in enumerable)
			{
				Class137 class137_2 = Class7.smethod_467(class152_0, item.Key);
				Class137 class137_3 = class152_0.method_2(item.Value);
				string text = class152_0.method_11(class38_0, item.Key, class137_2, out var _);
				text = ((class143_0!.ExtensionDataNameResolver != null) ? class143_0!.ExtensionDataNameResolver!(text) : text);
				if (class152_0.method_5(item.Value, null, class137_3, class143_0, jsonProperty_0))
				{
					class38_0.vmethod_9(text);
					Class7.smethod_712(class38_0, class152_0, item.Value);
				}
				else if (class152_0.method_7(class38_0, item.Value, null, class137_3, class143_0, jsonProperty_0))
				{
					class38_0.vmethod_9(text);
					class152_0.method_3(class38_0, item.Value, class137_3, null, class143_0, jsonProperty_0);
				}
			}
		}
		class38_0.vmethod_4();
		class152_0.list_0.RemoveAt(class152_0.list_0.Count - 1);
		Class7.smethod_82(class38_0, class152_0, (Class137)class143_0, object_0);
	}

	static void smethod_208(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0, Class137 class137_0, object object_0)
	{
		if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class29_0 as Interface1, class29_0.Path, "Started deserializing {0}".smethod_1(CultureInfo.InvariantCulture, class137_0.UnderlyingType)), null);
		}
		class137_0.method_2(object_0, jsonSerializerInternalReader_0.class34_0.streamingContext_0);
	}

	static JsonSchema smethod_209(Class29 class29_0)
	{
		return Class7.smethod_148(new Class172(), class29_0);
	}

	static Struct5<string?, string> smethod_210(string string_0)
	{
		int? num = Class7.smethod_39(string_0);
		string gparam_;
		string gparam_2;
		if (num.HasValue)
		{
			gparam_ = string_0.smethod_9(0, num.GetValueOrDefault());
			gparam_2 = string_0.smethod_9(num.GetValueOrDefault() + 1, string_0.Length - num.GetValueOrDefault() - 1);
		}
		else
		{
			gparam_ = string_0;
			gparam_2 = null;
		}
		return new Struct5<string, string>(gparam_2, gparam_);
	}

	static void smethod_211(Class29 class29_0, JsonToken jsonToken_0, object object_0, bool bool_0)
	{
		class29_0.jsonToken_0 = jsonToken_0;
		class29_0.object_0 = object_0;
		switch (jsonToken_0)
		{
		case JsonToken.StartObject:
			class29_0.state_0 = Class29.State.ObjectStart;
			Class7.smethod_365(class29_0, JsonContainerType.Object);
			break;
		case JsonToken.StartArray:
			class29_0.state_0 = Class29.State.ArrayStart;
			Class7.smethod_365(class29_0, JsonContainerType.Array);
			break;
		case JsonToken.StartConstructor:
			class29_0.state_0 = Class29.State.ConstructorStart;
			Class7.smethod_365(class29_0, JsonContainerType.Constructor);
			break;
		case JsonToken.PropertyName:
			class29_0.state_0 = Class29.State.Property;
			class29_0.struct0_0.string_0 = (string)object_0;
			break;
		case JsonToken.EndObject:
			Class7.smethod_763(class29_0, JsonToken.EndObject);
			break;
		case JsonToken.EndArray:
			Class7.smethod_763(class29_0, JsonToken.EndArray);
			break;
		case JsonToken.EndConstructor:
			Class7.smethod_763(class29_0, JsonToken.EndConstructor);
			break;
		case JsonToken.Raw:
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Null:
		case JsonToken.Undefined:
		case JsonToken.Date:
		case JsonToken.Bytes:
			Class7.smethod_621(class29_0, bool_0);
			break;
		case JsonToken.Comment:
			break;
		}
	}

	static IEnumerable<PropertyInfo> smethod_212(BindingFlags bindingFlags_0, Type type_0)
	{
		Class113.smethod_0(type_0, "targetType");
		List<PropertyInfo> list = new List<PropertyInfo>(type_0.GetProperties(bindingFlags_0));
		if (type_0.smethod_3())
		{
			Type[] interfaces = type_0.GetInterfaces();
			foreach (Type type in interfaces)
			{
				list.AddRange(type.GetProperties(bindingFlags_0));
			}
		}
		Class7.smethod_340((IList<PropertyInfo>)list, type_0, bindingFlags_0);
		for (int j = 0; j < list.Count; j++)
		{
			PropertyInfo propertyInfo = list[j];
			if (propertyInfo.DeclaringType != type_0)
			{
				PropertyInfo propertyInfo3 = (list[j] = (PropertyInfo)Class7.smethod_95(propertyInfo.DeclaringType, (MemberInfo)propertyInfo));
			}
		}
		return list;
	}

	static bool smethod_213(Type type_0)
	{
		Class113.smethod_0(type_0, "t");
		if (type_0.smethod_13())
		{
			return Class7.smethod_157(type_0);
		}
		return true;
	}

	static JProperty smethod_214(Class29 class29_0)
	{
		return Class7.smethod_411(class29_0, (Class193?)null);
	}

	static bool smethod_215(object object_0, Class29? class29_0, Class138? class138_0, JsonSerializerInternalReader? jsonSerializerInternalReader_0, JsonProperty jsonProperty_0, Class9 class9_0, JsonProperty jsonProperty_1)
	{
		if (jsonSerializerInternalReader_0!.method_13(jsonProperty_0, ref class9_0, class138_0, jsonProperty_1, class29_0, object_0, out var bool_, out var object_, out var class137_, out var bool_2, out var bool_3))
		{
			if (bool_3)
			{
				return true;
			}
			return false;
		}
		object obj;
		if (class9_0 != null && class9_0.CanRead)
		{
			if (!bool_2 && jsonProperty_0.Readable)
			{
				object_ = jsonProperty_0.ValueProvider!.imethod_1(object_0);
			}
			obj = Class7.smethod_716(jsonSerializerInternalReader_0, class9_0, class29_0, jsonProperty_0.type_0, object_);
		}
		else
		{
			obj = jsonSerializerInternalReader_0!.method_4(class29_0, jsonProperty_0.type_0, class137_, jsonProperty_0, class138_0, jsonProperty_1, bool_ ? object_ : null);
		}
		if ((!bool_ || obj != object_) && jsonSerializerInternalReader_0!.method_14(jsonProperty_0, class138_0 as Class143, obj))
		{
			jsonProperty_0.ValueProvider!.imethod_0(object_0, obj);
			if (jsonProperty_0.SetIsSpecified != null)
			{
				if (jsonSerializerInternalReader_0!.interface7_0 != null && jsonSerializerInternalReader_0!.interface7_0!.LevelFilter >= TraceLevel.Verbose)
				{
					jsonSerializerInternalReader_0!.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(class29_0 as Interface1, class29_0!.Path, "IsSpecified for property '{0}' on {1} set to true.".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.string_0, jsonProperty_0.DeclaringType)), null);
				}
				jsonProperty_0.SetIsSpecified!(object_0, true);
			}
			return true;
		}
		return bool_;
	}

	static void smethod_216(object object_0, StreamingContext streamingContext_0)
	{
		throw new JsonSerializationException("Unable to serialize instance of '{0}'.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType()));
	}

	static bool smethod_217(object object_0)
	{
		return ReflectionUtils.smethod_5<SerializableAttribute>(object_0, bool_0: false) != null;
	}

	static Regex smethod_218(Class24 class24_0, Class29 class29_0, Class34 class34_0)
	{
		string text = null;
		RegexOptions? regexOptions = null;
		while (class29_0.vmethod_0())
		{
			switch (class29_0.TokenType)
			{
			case JsonToken.PropertyName:
			{
				string a = class29_0.Value!.ToString();
				if (class29_0.vmethod_0())
				{
					if (string.Equals(a, "Pattern", StringComparison.OrdinalIgnoreCase))
					{
						text = (string)class29_0.Value;
					}
					else if (string.Equals(a, "Options", StringComparison.OrdinalIgnoreCase))
					{
						regexOptions = class34_0.method_4<RegexOptions>(class29_0);
					}
					else
					{
						Class7.smethod_310(class29_0);
					}
					break;
				}
				throw Class7.smethod_161(class29_0, "Unexpected end when reading Regex.");
			}
			case JsonToken.EndObject:
				if (text == null)
				{
					throw Class7.smethod_161(class29_0, "Error deserializing Regex. No pattern found.");
				}
				return new Regex(text, regexOptions.GetValueOrDefault());
			}
		}
		throw Class7.smethod_161(class29_0, "Unexpected end when reading Regex.");
	}

	static bool smethod_219(Class139 class139_0, Class38 class38_0, JsonProperty jsonProperty_0, Class152? class152_0, JsonProperty? jsonProperty_1, Class138? class138_0, object object_0)
	{
		bool num = class152_0!.method_4(class139_0, jsonProperty_0, class138_0, jsonProperty_1) ?? Class7.smethod_476(class152_0!.class34_0.enum14_0, Enum14.flag_2, class152_0);
		bool flag = num;
		flag = num && (jsonProperty_0 == null || jsonProperty_0.Writable || Class7.smethod_294(class138_0, jsonProperty_0, class152_0));
		bool flag2 = class152_0!.method_10(Enum19.flag_2, class139_0, jsonProperty_0, class138_0, jsonProperty_1);
		bool num2 = flag || flag2;
		if (num2)
		{
			class38_0.vmethod_3();
			if (flag)
			{
				Class7.smethod_97(class152_0, class38_0, class139_0.UnderlyingType, object_0);
			}
			if (flag2)
			{
				Class7.smethod_492(object_0.GetType(), class152_0, class38_0);
			}
			class38_0.vmethod_10("$values", bool_2: false);
		}
		if (class139_0.class137_0 == null)
		{
			class139_0.ItemContract = class152_0!.class34_0.interface4_0.imethod_0(class139_0.CollectionItemType ?? typeof(object));
		}
		return num2;
	}

	static JToken smethod_220(string string_0)
	{
		return Class7.smethod_144(string_0, (Class193?)null);
	}

	static void smethod_221(Class239 class239_0, string string_0, int int_0)
	{
		if (string_0 == null)
		{
			return;
		}
		if (int_0 <= 256)
		{
			if (class239_0.byte_0 == null)
			{
				class239_0.byte_0 = new byte[256];
			}
			Class239.encoding_0.GetBytes(string_0, 0, string_0.Length, class239_0.byte_0, 0);
			class239_0.binaryWriter_0.Write(class239_0.byte_0, 0, int_0);
		}
		else
		{
			byte[] bytes = Class239.encoding_0.GetBytes(string_0);
			class239_0.binaryWriter_0.Write(bytes);
		}
	}

	static void smethod_222(Class142 class142_0, Type type_0, Class167 class167_0)
	{
		class167_0.jsonSchema_0.AllowAdditionalProperties = true;
	}

	static DateTime smethod_223(long long_0)
	{
		return new DateTime(long_0 * 10000L + Class51.long_0, DateTimeKind.Utc);
	}

	static void smethod_224(string string_0, object object_0, Class38 class38_0, JsonSchemaWriter jsonSchemaWriter_0)
	{
		if (object_0 != null)
		{
			class38_0.vmethod_9(string_0);
			class38_0.vmethod_58(object_0);
		}
	}

	static string smethod_225(Interface6 interface6_0, Type type_0, Enum18 enum18_0)
	{
		string text = Class7.smethod_391(type_0, interface6_0);
		return enum18_0 switch
		{
			Enum18.const_1 => text, 
			Enum18.const_0 => Class7.smethod_194(text), 
			_ => throw new ArgumentOutOfRangeException(), 
		};
	}

	static Type? smethod_226(Type type_0)
	{
		Attribute[] array = Class7.smethod_714((object)type_0, (Type?)null, bool_0: true);
		int num = 0;
		Attribute attribute;
		Type type;
		while (true)
		{
			if (num < array.Length)
			{
				attribute = array[num];
				type = attribute.GetType();
				if (string.Equals(type.FullName, "System.ComponentModel.DataAnnotations.MetadataTypeAttribute", StringComparison.Ordinal))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		if (JsonTypeReflector.class100_0 == null)
		{
			JsonTypeReflector.class100_0 = Class7.smethod_762(type, new string[1] { "MetadataClassType" });
		}
		return (Type)Class7.smethod_74(JsonTypeReflector.class100_0, (object)attribute, "MetadataClassType");
	}

	static IEnumerable<JToken> smethod_227(Class215 class215_0, JToken jtoken_0, JToken? jtoken_1, object object_0)
	{
		if (object_0 is JToken jToken)
		{
			return new JToken[1] { jToken };
		}
		if (object_0 is List<Class198> list_)
		{
			return Class212.smethod_0(list_, jtoken_0, jtoken_1, null);
		}
		return Class45.smethod_10<JToken>();
	}

	static void smethod_228(Class30 class30_0)
	{
		if (class30_0.struct3_0.IsEmpty)
		{
			class30_0.struct3_0 = new Struct3(class30_0.interface0_0, 1024);
		}
	}

	static string smethod_229(Class167 class167_0, Type type_0)
	{
		Attribute5 attribute = JsonTypeReflector.smethod_0<Attribute5>(type_0);
		if (!Class109.smethod_0(attribute?.Description))
		{
			return attribute.Description;
		}
		return ReflectionUtils.smethod_4<DescriptionAttribute>(type_0)?.Description;
	}

	static void smethod_230(Class192 class192_0)
	{
		if (class192_0.dictionary_0 == null)
		{
			class192_0.dictionary_0 = new Dictionary<string, JToken>(Class192.iequalityComparer_0);
		}
	}

	static bool smethod_231(CultureInfo cultureInfo_0, Enum3 enum3_0, Struct4 struct4_0, ref DateTime dateTime_0, [Out] string string_0)
	{
		if (struct4_0.Length > 0)
		{
			int startIndex = struct4_0.StartIndex;
			if (struct4_0[startIndex] == '/')
			{
				if (struct4_0.Length >= 9 && struct4_0.smethod_1("/Date(") && struct4_0.smethod_2(")/") && Class7.smethod_235(ref dateTime_0, enum3_0, struct4_0))
				{
					return true;
				}
			}
			else if (struct4_0.Length >= 19 && struct4_0.Length <= 40 && char.IsDigit(struct4_0[startIndex]) && struct4_0[startIndex + 10] == 'T' && Class7.smethod_293(ref dateTime_0, enum3_0, struct4_0))
			{
				return true;
			}
			if (!Class109.smethod_0(string_0) && Class7.smethod_244(string_0, ref dateTime_0, cultureInfo_0, enum3_0, struct4_0.ToString()))
			{
				return true;
			}
		}
		dateTime_0 = default(DateTime);
		return false;
	}

	static JsonSchema smethod_232(Class167 class167_0, Type type_0)
	{
		return Class7.smethod_121(new Class172(), bool_0: false, type_0, class167_0);
	}

	static void smethod_233(JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonValidatingReader_0.schemaScope_0 == null || jsonValidatingReader_0.schemaScope_0.jtokenType_0 != JTokenType.Array)
		{
			return;
		}
		jsonValidatingReader_0.schemaScope_0.ArrayItemCount++;
		foreach (JsonSchemaModel currentSchema in jsonValidatingReader_0.CurrentSchemas)
		{
			if (currentSchema != null && currentSchema.PositionalItemsValidation && !currentSchema.AllowAdditionalItems && (currentSchema.Items == null || jsonValidatingReader_0.schemaScope_0.ArrayItemCount - 1 >= currentSchema.Items.Count))
			{
				Class7.smethod_239(jsonValidatingReader_0, "Index {0} has not been defined and the schema does not allow additional items.".smethod_1(CultureInfo.InvariantCulture, jsonValidatingReader_0.schemaScope_0.ArrayItemCount), currentSchema);
			}
		}
	}

	static object smethod_234(Class212 class212_0)
	{
		Class7.smethod_611(class212_0);
		if (Class7.smethod_754(out List<Class198> list_, class212_0))
		{
			Class7.smethod_611(class212_0);
			Class7.smethod_354(class212_0, "Path ended with open query.");
			return list_;
		}
		if (!class212_0.method_5(out var object_))
		{
			throw class212_0.method_4();
		}
		Class7.smethod_611(class212_0);
		Class7.smethod_354(class212_0, "Path ended with open query.");
		return new Class179(object_);
	}

	static bool smethod_235(ref DateTime dateTime_0, Enum3 enum3_0, [Out] Struct4 struct4_0)
	{
		long long_ = default(long);
		if (!Class7.smethod_337(ref long_, struct4_0, out DateTimeKind dateTimeKind_, out TimeSpan _))
		{
			dateTime_0 = default(DateTime);
			return false;
		}
		DateTime dateTime = new DateTime(long_ * 10000L + Class51.long_0, DateTimeKind.Utc);
		switch (dateTimeKind_)
		{
		default:
			dateTime_0 = dateTime;
			break;
		case DateTimeKind.Local:
			dateTime_0 = dateTime.ToLocalTime();
			break;
		case DateTimeKind.Unspecified:
			dateTime_0 = DateTime.SpecifyKind(dateTime.ToLocalTime(), DateTimeKind.Unspecified);
			break;
		}
		dateTime_0 = Class7.smethod_517(dateTime_0, enum3_0);
		return true;
	}

	static void smethod_236(JsonSchemaModel jsonSchemaModel_0, JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonSchemaModel_0 != null && Class7.smethod_238(jsonValidatingReader_0, jsonSchemaModel_0, JsonSchemaType.Null))
		{
			Class7.smethod_589(jsonValidatingReader_0, jsonSchemaModel_0);
		}
	}

	static void smethod_237(Class27 class27_0, Class29 class29_0, Interface12 interface12_0, XmlNamespaceManager xmlNamespaceManager_0, string string_0, Interface11 interface11_0)
	{
		if (!class27_0.EncodeSpecialCharacters)
		{
			switch (string_0)
			{
			case "#significant-whitespace":
				interface11_0.imethod_0(interface12_0.imethod_5(Class7.smethod_462(class29_0)));
				return;
			case "#whitespace":
				interface11_0.imethod_0(interface12_0.imethod_4(Class7.smethod_462(class29_0)));
				return;
			case "#cdata-section":
				interface11_0.imethod_0(interface12_0.imethod_3(Class7.smethod_462(class29_0)));
				return;
			case "#text":
				interface11_0.imethod_0(interface12_0.imethod_2(Class7.smethod_462(class29_0)));
				return;
			}
			if (!Class109.smethod_0(string_0) && string_0[0] == '?')
			{
				Class7.smethod_649(class29_0, class27_0, string_0, interface12_0, interface11_0);
				return;
			}
			if (string.Equals(string_0, "!DOCTYPE", StringComparison.OrdinalIgnoreCase))
			{
				Class7.smethod_551(interface12_0, interface11_0, class29_0, class27_0);
				return;
			}
		}
		if (class29_0.TokenType == JsonToken.StartArray)
		{
			class27_0.method_5(class29_0, interface12_0, string_0, interface11_0, xmlNamespaceManager_0);
		}
		else
		{
			Class7.smethod_129(class27_0, class29_0, interface12_0, interface11_0, string_0, xmlNamespaceManager_0);
		}
	}

	static bool smethod_238(JsonValidatingReader jsonValidatingReader_0, JsonSchemaModel jsonSchemaModel_0, JsonSchemaType jsonSchemaType_0)
	{
		if (!Class7.smethod_494(jsonSchemaType_0, (JsonSchemaType?)jsonSchemaModel_0.Type))
		{
			Class7.smethod_239(jsonValidatingReader_0, "Invalid type. Expected {0} but got {1}.".smethod_2(CultureInfo.InvariantCulture, jsonSchemaModel_0.Type, jsonSchemaType_0), jsonSchemaModel_0);
			return false;
		}
		return true;
	}

	static void smethod_239(JsonValidatingReader jsonValidatingReader_0, string string_0, JsonSchemaModel jsonSchemaModel_0)
	{
		string message = (((Interface1)jsonValidatingReader_0).imethod_0() ? (string_0 + " Line {0}, position {1}.".smethod_2(CultureInfo.InvariantCulture, ((Interface1)jsonValidatingReader_0).LineNumber, ((Interface1)jsonValidatingReader_0).LinePosition)) : string_0);
		Class7.smethod_377(new JsonSchemaException(message, null, jsonValidatingReader_0.Path, ((Interface1)jsonValidatingReader_0).LineNumber, ((Interface1)jsonValidatingReader_0).LinePosition), jsonValidatingReader_0);
	}

	static bool smethod_240(double double_0)
	{
		return Math.Abs(double_0) < 4.440892098500626E-15;
	}

	static void smethod_241(JToken jtoken_0, Type type_0)
	{
		if (type_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (jtoken_0.object_0 == null)
		{
			return;
		}
		if (!(jtoken_0.object_0 is object[] array))
		{
			if (type_0.IsInstanceOfType(jtoken_0.object_0))
			{
				jtoken_0.object_0 = null;
			}
			return;
		}
		int i = 0;
		int num = 0;
		for (; i < array.Length; i++)
		{
			object obj = array[i];
			if (obj == null)
			{
				break;
			}
			if (!type_0.IsInstanceOfType(obj))
			{
				array[num++] = obj;
			}
		}
		if (num != 0)
		{
			while (num < i)
			{
				array[num++] = null;
			}
		}
		else
		{
			jtoken_0.object_0 = null;
		}
	}

	static Predicate<object>? smethod_242(DefaultContractResolver defaultContractResolver_0, MemberInfo memberInfo_0)
	{
		DefaultContractResolver.Class129 CS_0024_003C_003E8__locals0 = new DefaultContractResolver.Class129();
		MethodInfo method = memberInfo_0.DeclaringType!.GetMethod("ShouldSerialize" + memberInfo_0.Name, ReflectionUtils.type_0);
		if (!(method == null) && !(method.ReturnType != typeof(bool)))
		{
			CS_0024_003C_003E8__locals0.delegate1_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(method);
			return (object object_0) => (bool)CS_0024_003C_003E8__locals0.delegate1_0(object_0);
		}
		return null;
	}

	static void smethod_243(Class30 class30_0)
	{
		int int_ = class30_0.int_3;
		while (true)
		{
			char c = class30_0.char_2[class30_0.int_3];
			if (c != 0)
			{
				if (Class7.smethod_140(class30_0, c, int_))
				{
					return;
				}
				continue;
			}
			if (class30_0.int_2 != class30_0.int_3)
			{
				break;
			}
			if (Class7.smethod_418(bool_0: true, class30_0) == 0)
			{
				throw Class7.smethod_555((Class29)class30_0, "Unexpected end while parsing unquoted property name.");
			}
		}
		class30_0.struct4_0 = new Struct4(class30_0.char_2, int_, class30_0.int_3 - int_);
	}

	static bool smethod_244(string string_0, ref DateTime dateTime_0, CultureInfo cultureInfo_0, Enum3 enum3_0, [Out] string string_1)
	{
		if (DateTime.TryParseExact(string_1, string_0, cultureInfo_0, DateTimeStyles.RoundtripKind, out var result))
		{
			result = (dateTime_0 = Class7.smethod_517(result, enum3_0));
			return true;
		}
		dateTime_0 = default(DateTime);
		return false;
	}

	static Enum22 smethod_245(char[] char_0, int int_0, int int_1, out long long_0)
	{
		long_0 = 0L;
		if (int_1 == 0)
		{
			return Enum22.const_3;
		}
		bool flag;
		if (flag = char_0[int_0] == '-')
		{
			if (int_1 == 1)
			{
				return Enum22.const_3;
			}
			int_0++;
			int_1--;
		}
		int num = int_0 + int_1;
		if (int_1 > 19)
		{
			int num2 = int_0;
			while (true)
			{
				if (num2 < num)
				{
					int num3 = char_0[num2] - 48;
					if (num3 < 0 || num3 > 9)
					{
						break;
					}
					num2++;
					continue;
				}
				return Enum22.const_2;
			}
			return Enum22.const_3;
		}
		int num4 = int_0;
		while (true)
		{
			if (num4 < num)
			{
				int num5 = char_0[num4] - 48;
				if (num5 < 0 || num5 > 9)
				{
					break;
				}
				long num6 = 10L * long_0 - num5;
				if (num6 <= long_0)
				{
					long_0 = num6;
					num4++;
					continue;
				}
				num4++;
				while (true)
				{
					if (num4 < num)
					{
						num5 = char_0[num4] - 48;
						if (num5 < 0 || num5 > 9)
						{
							break;
						}
						num4++;
						continue;
					}
					return Enum22.const_2;
				}
				return Enum22.const_3;
			}
			if (!flag)
			{
				if (long_0 == long.MinValue)
				{
					return Enum22.const_2;
				}
				long_0 = -long_0;
			}
			return Enum22.const_1;
		}
		return Enum22.const_3;
	}

	static void smethod_246(Class152 class152_0, Class38 class38_0, Class137 class137_0, object object_0)
	{
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(null, class38_0.Path, "Started serializing {0}".smethod_1(CultureInfo.InvariantCulture, class137_0.UnderlyingType)), null);
		}
		class137_0.method_0(object_0, class152_0.class34_0.streamingContext_0);
	}

	static void smethod_247(Class179 class179_0, Class41 class41_0, JsonToken jsonToken_0)
	{
		if (class41_0.class176_1 != null)
		{
			if (class41_0.class176_1!.method_12(class179_0))
			{
				class41_0.jtoken_0 = class41_0.class176_1!.Last;
				if (class41_0.class176_1!.Type == JTokenType.Property)
				{
					class41_0.class176_1 = class41_0.class176_1!.Parent;
				}
			}
		}
		else
		{
			class41_0.class179_0 = class179_0 ?? new Class179(null, JTokenType.Null);
			class41_0.jtoken_0 = class41_0.class179_0;
		}
	}

	static void smethod_248(Class164 class164_0, JToken jtoken_0)
	{
		if (jtoken_0.Type == JTokenType.Boolean)
		{
			class164_0.jsonSchema_0.AllowAdditionalItems = Class7.smethod_483(jtoken_0);
		}
		else
		{
			class164_0.jsonSchema_0.AdditionalItems = Class7.smethod_617(class164_0, jtoken_0);
		}
	}

	static int smethod_249(Class30 class30_0, bool bool_0, int int_0)
	{
		if (class30_0.bool_3)
		{
			return 0;
		}
		Class7.smethod_708(class30_0, bool_0, int_0);
		int count = class30_0.char_2!.Length - class30_0.int_2 - 1;
		int num = class30_0.textReader_0.Read(class30_0.char_2, class30_0.int_2, count);
		class30_0.int_2 += num;
		if (num == 0)
		{
			class30_0.bool_3 = true;
		}
		class30_0.char_2[class30_0.int_2] = '\0';
		return num;
	}

	static JsonToken smethod_250(Class29 class29_0)
	{
		JsonToken tokenType;
		do
		{
			if (class29_0.vmethod_0())
			{
				tokenType = class29_0.TokenType;
				continue;
			}
			Class7.smethod_386(class29_0, JsonToken.None);
			return JsonToken.None;
		}
		while (tokenType == JsonToken.Comment);
		return tokenType;
	}

	static object smethod_251(MemberInfo memberInfo_0, object object_0)
	{
		Class113.smethod_0(memberInfo_0, "member");
		Class113.smethod_0(object_0, "target");
		switch (memberInfo_0.smethod_1())
		{
		default:
			throw new ArgumentException("MemberInfo '{0}' is not of type FieldInfo or PropertyInfo".smethod_1(CultureInfo.InvariantCulture, memberInfo_0.Name), "member");
		case MemberTypes.Property:
			try
			{
				return ((PropertyInfo)memberInfo_0).GetValue(object_0, null);
			}
			catch (TargetParameterCountException innerException)
			{
				throw new ArgumentException("MemberInfo '{0}' has index parameters".smethod_1(CultureInfo.InvariantCulture, memberInfo_0.Name), innerException);
			}
		case MemberTypes.Field:
			return ((FieldInfo)memberInfo_0).GetValue(object_0);
		}
	}

	static bool smethod_252(Class32 class32_0)
	{
		class32_0.jtoken_2 = null;
		Class7.smethod_386((Class29)class32_0, JsonToken.None);
		return false;
	}

	static Class179 smethod_253()
	{
		return new Class179(null, JTokenType.Null);
	}

	static object smethod_254(BigInteger bigInteger_0, Type type_0)
	{
		if (type_0 == typeof(decimal))
		{
			return (decimal)bigInteger_0;
		}
		if (type_0 == typeof(double))
		{
			return (double)bigInteger_0;
		}
		if (type_0 == typeof(float))
		{
			return (float)bigInteger_0;
		}
		if (type_0 == typeof(ulong))
		{
			return (ulong)bigInteger_0;
		}
		if (type_0 == typeof(bool))
		{
			return bigInteger_0 != 0L;
		}
		try
		{
			return Convert.ChangeType((long)bigInteger_0, type_0, CultureInfo.InvariantCulture);
		}
		catch (Exception innerException)
		{
			throw new InvalidOperationException("Can not convert from BigInteger to {0}.".smethod_1(CultureInfo.InvariantCulture, type_0), innerException);
		}
	}

	static bool smethod_255(Class195 class195_0, JToken jtoken_0, Class215? class215_0, JToken jtoken_1)
	{
		if (jtoken_0 is Class179 @class && jtoken_1 is Class179 class2)
		{
			switch (class215_0!.enum33_0)
			{
			case Enum33.const_1:
				if (Class7.smethod_93(@class, class2))
				{
					return true;
				}
				break;
			case Enum33.const_2:
				if (!Class7.smethod_93(@class, class2))
				{
					return true;
				}
				break;
			case Enum33.const_3:
				return true;
			case Enum33.const_4:
				if (@class.System_002EIComparable_003Cns15_002EClass179_003E_002ECompareTo(class2) < 0)
				{
					return true;
				}
				break;
			case Enum33.const_5:
				if (@class.System_002EIComparable_003Cns15_002EClass179_003E_002ECompareTo(class2) <= 0)
				{
					return true;
				}
				break;
			case Enum33.const_6:
				if (@class.System_002EIComparable_003Cns15_002EClass179_003E_002ECompareTo(class2) > 0)
				{
					return true;
				}
				break;
			case Enum33.const_7:
				if (@class.System_002EIComparable_003Cns15_002EClass179_003E_002ECompareTo(class2) >= 0)
				{
					return true;
				}
				break;
			case Enum33.const_10:
				if (Class7.smethod_280(@class, class2, class195_0))
				{
					return true;
				}
				break;
			case Enum33.const_11:
				if (Class7.smethod_453(@class, class2))
				{
					return true;
				}
				break;
			case Enum33.const_12:
				if (!Class7.smethod_453(@class, class2))
				{
					return true;
				}
				break;
			}
		}
		else
		{
			Enum33 enum33_ = class215_0!.enum33_0;
			if ((uint)(enum33_ - 2) <= 1u)
			{
				return true;
			}
		}
		return false;
	}

	static void smethod_256(char char_0, char[] char_1)
	{
		char_1[0] = '\\';
		char_1[1] = 'u';
		char_1[2] = Class7.smethod_70(((int)char_0 >> 12) & 0xF);
		char_1[3] = Class7.smethod_70(((int)char_0 >> 8) & 0xF);
		char_1[4] = Class7.smethod_70(((int)char_0 >> 4) & 0xF);
		char_1[5] = Class7.smethod_70(char_0 & 0xF);
	}

	static bool smethod_257(string? string_0, bool[] bool_0)
	{
		if (string_0 == null)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < string_0!.Length)
			{
				char c = string_0![num];
				if (c >= bool_0.Length || bool_0[(uint)c])
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	static int smethod_258(DateTime dateTime_0, Class39 class39_0)
	{
		Class7.smethod_654(class39_0);
		int num = 0;
		char[]? char_ = class39_0.char_2;
		num = 1;
		char_[0] = class39_0.char_1;
		num = Class51.smethod_2(class39_0.char_2, 1, dateTime_0, null, dateTime_0.Kind, class39_0.enum1_0);
		class39_0.char_2[num++] = class39_0.char_1;
		return num;
	}

	static void smethod_259(Class201.Class209 class209_0)
	{
		class209_0.int_0 = -1;
		if (class209_0.ienumerator_0 != null)
		{
			class209_0.ienumerator_0.Dispose();
		}
	}

	static bool smethod_260(Class30 class30_0, int int_0, bool bool_0)
	{
		if (class30_0.int_3 + int_0 >= class30_0.int_2)
		{
			return Class7.smethod_604(int_0, bool_0, class30_0);
		}
		return true;
	}

	static string smethod_261(Class6 class6_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("key");
		}
		int length = string_0.Length;
		if (length == 0)
		{
			return string.Empty;
		}
		int num = length + Class6.int_0;
		for (int i = 0; i < string_0.Length; i++)
		{
			num += (num << 7) ^ string_0[i];
		}
		num -= num >> 17;
		num -= num >> 11;
		num -= num >> 5;
		Class6.Class4 @class = class6_0.class4_0[num & class6_0.int_2];
		while (true)
		{
			if (@class != null)
			{
				if (@class.int_0 == num && @class.string_0.Equals(string_0, StringComparison.Ordinal))
				{
					break;
				}
				@class = @class.class4_0;
				continue;
			}
			return Class7.smethod_395(string_0, class6_0, num);
		}
		return @class.string_0;
	}

	static void smethod_262(JToken jtoken_0, JToken jtoken_1, JToken jtoken_2)
	{
		if (jtoken_2.object_0 is object[] source)
		{
			jtoken_1.object_0 = source.ToArray();
		}
		else
		{
			jtoken_1.object_0 = jtoken_2.object_0;
		}
	}

	static byte[] smethod_263(Class11 class11_0, object object_0)
	{
		if (object_0.GetType().FullName == "System.Data.Linq.Binary")
		{
			Class7.smethod_719(object_0.GetType());
			return (byte[])Class7.smethod_74(Class11.class100_0, object_0, "ToArray");
		}
		if (!(object_0 is SqlBinary sqlBinary))
		{
			throw new JsonSerializationException("Unexpected value type when writing binary: {0}".smethod_1(CultureInfo.InvariantCulture, object_0.GetType()));
		}
		return sqlBinary.Value;
	}

	static void smethod_264(int? nullable_0, int int_0, Class239 class239_0, string string_0)
	{
		if (nullable_0.HasValue)
		{
			class239_0.binaryWriter_0.Write(nullable_0.GetValueOrDefault());
		}
		Class7.smethod_221(class239_0, string_0, int_0);
		class239_0.binaryWriter_0.Write((byte)0);
	}

	static Type? smethod_265(Type type_0)
	{
		return JsonTypeReflector.class111_1.method_0(type_0);
	}

	static void smethod_266(Class29 class29_0)
	{
		Class7.smethod_67(class29_0);
		if (class29_0.Value != null && class29_0.Value!.ToString() == "$type")
		{
			Class7.smethod_67(class29_0);
			if (class29_0.Value != null && class29_0.Value!.ToString()!.StartsWith("System.Byte[]", StringComparison.Ordinal))
			{
				Class7.smethod_67(class29_0);
				if (class29_0.Value!.ToString() == "$value")
				{
					return;
				}
			}
		}
		throw Class7.smethod_555(class29_0, "Error reading bytes. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, JsonToken.StartObject));
	}

	static string smethod_267(Class192 class192_0, JToken jtoken_0)
	{
		return ((JProperty)jtoken_0).Name;
	}

	static JToken smethod_268(Uri? uri_0)
	{
		return new Class179(uri_0);
	}

	static void smethod_269(Class36 class36_0, object object_0, string? string_0)
	{
		Class34 @class = Class7.smethod_380(class36_0);
		using Class29 class2 = new Class30(new StringReader(string_0));
		@class.method_1(class2, object_0);
		if (class36_0 == null || !class36_0.CheckAdditionalContent)
		{
			return;
		}
		do
		{
			if (!class2.vmethod_0())
			{
				return;
			}
		}
		while (class2.TokenType == JsonToken.Comment);
		throw Class7.smethod_161(class2, "Additional text found in JSON string after finishing deserializing object.");
	}

	static string smethod_270(char char_0, string string_0, Enum17 enum17_0)
	{
		if (char_0 != '"' && char_0 != '\'')
		{
			throw new ArgumentException("Delimiter must be a single or double quote.", "delimiter");
		}
		return Class7.smethod_357(string_0, char_0, bool_0: true, enum17_0);
	}

	static JsonReaderException smethod_271(string string_0, Class29 class29_0, Exception? exception_0)
	{
		return Class7.smethod_699(class29_0.Path, exception_0, class29_0 as Interface1, string_0);
	}

	static IDictionary<string, JsonSchema> smethod_272(JToken jtoken_0, Class164 class164_0)
	{
		IDictionary<string, JsonSchema> dictionary = new Dictionary<string, JsonSchema>();
		if (jtoken_0.Type != JTokenType.Object)
		{
			throw Class7.smethod_609((Interface1)jtoken_0, jtoken_0.Path, "Expected Object token while parsing schema properties, got {0}.".smethod_1(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		foreach (JProperty item in (IEnumerable<JToken>)jtoken_0)
		{
			if (!dictionary.ContainsKey(item.Name))
			{
				dictionary.Add(item.Name, Class7.smethod_617(class164_0, item.Value));
				continue;
			}
			throw new JsonException("Property {0} has already been defined in schema.".smethod_1(CultureInfo.InvariantCulture, item.Name));
		}
		return dictionary;
	}

	static Type? smethod_273(string string_0, Assembly assembly_0, Class132 class132_0)
	{
		Type result = null;
		int num = string_0.IndexOf('[');
		if (num >= 0)
		{
			string name = string_0.Substring(0, num);
			Type type = assembly_0.GetType(name);
			if (type != null)
			{
				List<Type> list = new List<Type>();
				int num2 = 0;
				int num3 = 0;
				int num4 = string_0.Length - 1;
				for (int i = num + 1; i < num4; i++)
				{
					switch (string_0[i])
					{
					case ']':
						num2--;
						if (num2 == 0)
						{
							Struct5<string, string> struct5_ = Class7.smethod_210(string_0.Substring(num3, i - num3));
							list.Add(Class7.smethod_597(struct5_, class132_0));
						}
						break;
					case '[':
						if (num2 == 0)
						{
							num3 = i + 1;
						}
						num2++;
						break;
					}
				}
				result = type.MakeGenericType(list.ToArray());
			}
		}
		return result;
	}

	static string smethod_274(Class40 class40_0)
	{
		return class40_0.stringWriter_0.ToString();
	}

	static char smethod_275(Class30 class30_0)
	{
		return Class7.smethod_347(class30_0, Class7.smethod_260(class30_0, 4, bool_0: true));
	}

	static long smethod_276(DateTime dateTime_0)
	{
		return Class7.smethod_620(dateTime_0, bool_0: true);
	}

	static XDocument? smethod_277(string string_0)
	{
		return Class8.smethod_38(string_0, null);
	}

	static byte[] smethod_278([Out] Class33 class33_0, ref Enum34 enum34_0)
	{
		int int_ = Class7.smethod_532(class33_0);
		enum34_0 = (Enum34)Class7.smethod_136(class33_0);
		if (enum34_0 == Enum34.const_2 && !class33_0.bool_4)
		{
			int_ = Class7.smethod_532(class33_0);
		}
		return Class7.smethod_760(class33_0, int_);
	}

	static JsonContainerType smethod_279(Class29 class29_0)
	{
		Struct0 struct0_;
		if (class29_0.list_0 != null && class29_0.list_0!.Count > 0)
		{
			struct0_ = class29_0.struct0_0;
			class29_0.struct0_0 = class29_0.list_0![class29_0.list_0!.Count - 1];
			class29_0.list_0!.RemoveAt(class29_0.list_0!.Count - 1);
		}
		else
		{
			struct0_ = class29_0.struct0_0;
			class29_0.struct0_0 = default(Struct0);
		}
		if (class29_0.nullable_0.HasValue && class29_0.Depth <= class29_0.nullable_0)
		{
			class29_0.bool_0 = false;
		}
		return struct0_.jsonContainerType_0;
	}

	static bool smethod_280(Class179 class179_0, Class179 class179_1, Class195? class195_0)
	{
		if (class179_0.Type == JTokenType.String && class179_1.Type == JTokenType.String)
		{
			string obj = (string)class179_1.Value;
			int num = obj.LastIndexOf('/');
			string pattern = obj.Substring(1, num - 1);
			string string_ = obj.Substring(num + 1);
			return Regex.IsMatch((string)class179_0.Value, pattern, Class7.smethod_138(string_));
		}
		return false;
	}

	static void smethod_281(Class38 class38_0)
	{
		JsonContainerType jsonContainerType_ = class38_0.struct0_0.jsonContainerType_0;
		switch (jsonContainerType_)
		{
		default:
			throw Class7.smethod_188(class38_0, "Unknown JsonType: " + jsonContainerType_, (Exception?)null);
		case JsonContainerType.None:
			class38_0.state_2 = Class38.State.Start;
			break;
		case JsonContainerType.Object:
			class38_0.state_2 = Class38.State.Object;
			break;
		case JsonContainerType.Array:
			class38_0.state_2 = Class38.State.Array;
			break;
		case JsonContainerType.Constructor:
			class38_0.state_2 = Class38.State.Array;
			break;
		}
	}

	static void smethod_282(Class137 class137_0, Class38 class38_0, object object_0, Class152? class152_0, JsonProperty? jsonProperty_0, JsonProperty? jsonProperty_1, Class138 class138_0)
	{
		class38_0.vmethod_3();
		if ((class152_0!.method_4(class137_0, jsonProperty_0, class138_0, jsonProperty_1) ?? Class7.smethod_476(class152_0!.class34_0.enum14_0, Enum14.flag_1, class152_0)) && (jsonProperty_0 == null || jsonProperty_0!.Writable || Class7.smethod_294(class138_0, jsonProperty_0, class152_0)))
		{
			Class7.smethod_97(class152_0, class38_0, class137_0.UnderlyingType, object_0);
		}
		if (class152_0!.method_10(Enum19.flag_1, class137_0, jsonProperty_0, class138_0, jsonProperty_1))
		{
			Class7.smethod_492(class137_0.UnderlyingType, class152_0, class38_0);
		}
	}

	static int? smethod_283(Class29 class29_0, string string_0)
	{
		if (Class109.smethod_0(string_0))
		{
			Class7.smethod_211(class29_0, JsonToken.Null, (object)null, bool_0: false);
			return null;
		}
		if (!int.TryParse(string_0, NumberStyles.Integer, class29_0.Culture, out var result))
		{
			Class7.smethod_211(class29_0, JsonToken.String, (object)string_0, bool_0: false);
			throw Class7.smethod_555(class29_0, "Could not convert string to integer: {0}.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		Class7.smethod_211(class29_0, JsonToken.Integer, (object)result, bool_0: false);
		return result;
	}

	static JProperty? smethod_284(string string_0, JObject jobject_0)
	{
		return Class7.smethod_326(jobject_0, string_0, StringComparison.Ordinal);
	}

	static void smethod_285(Class151 class151_0)
	{
		if (class151_0.class135_0 == null)
		{
			throw new InvalidOperationException("Could not clear error context. Error context is already null.");
		}
		class151_0.class135_0 = null;
	}

	static int smethod_286(Class39 class39_0, ulong ulong_0, bool bool_0)
	{
		if (ulong_0 <= 4294967295L)
		{
			return Class7.smethod_137(class39_0, (uint)ulong_0, bool_0);
		}
		Class7.smethod_654(class39_0);
		int num = Class7.smethod_518(ulong_0);
		if (bool_0)
		{
			num++;
			class39_0.char_2[0] = '-';
		}
		int num2 = num;
		do
		{
			ulong num3 = ulong_0 / 10uL;
			ulong num4 = ulong_0 - num3 * 10L;
			class39_0.char_2[--num2] = (char)(48L + num4);
			ulong_0 = num3;
		}
		while (ulong_0 != 0L);
		return num;
	}

	static void smethod_287(Class30 class30_0, bool bool_0)
	{
		class30_0.int_3++;
		Class7.smethod_765(class30_0, Class7.smethod_260(class30_0, 1, bool_0));
	}

	static void smethod_288(Class203.Class216 class216_0)
	{
		class216_0.int_0 = -3;
		if (class216_0.ienumerator_1 != null)
		{
			class216_0.ienumerator_1.Dispose();
		}
	}

	static Type smethod_289(Class100 class100_0, string string_0)
	{
		return class100_0.Members[string_0].MemberType;
	}

	static bool smethod_290(MemberInfo memberInfo_0, bool bool_0)
	{
		switch (memberInfo_0.smethod_1())
		{
		default:
			return false;
		case MemberTypes.Property:
		{
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
			if (!propertyInfo.CanRead)
			{
				return false;
			}
			if (bool_0)
			{
				return true;
			}
			return propertyInfo.GetGetMethod(bool_0) != null;
		}
		case MemberTypes.Field:
		{
			FieldInfo fieldInfo = (FieldInfo)memberInfo_0;
			if (bool_0)
			{
				return true;
			}
			if (fieldInfo.IsPublic)
			{
				return true;
			}
			return false;
		}
		}
	}

	static bool smethod_291(Type type_0)
	{
		if (Class7.smethod_35(type_0))
		{
			return true;
		}
		if (!(type_0.Name == "FSharpSet`1") && !(type_0.Name == "FSharpMap`2"))
		{
			return false;
		}
		return true;
	}

	static object? smethod_292(JToken jtoken_0, Type type_0, Class34 class34_0)
	{
		Class113.smethod_0(class34_0, "jsonSerializer");
		using Class32 class29_ = new Class32(jtoken_0);
		return class34_0.method_5(class29_, type_0);
	}

	static bool smethod_293(ref DateTime dateTime_0, Enum3 enum3_0, [Out] Struct4 struct4_0)
	{
		Struct1 struct1_ = default(Struct1);
		if (!struct1_.method_0(struct4_0.Chars, struct4_0.StartIndex, struct4_0.Length))
		{
			dateTime_0 = default(DateTime);
			return false;
		}
		DateTime dateTime_ = Class7.smethod_569(struct1_);
		switch (struct1_.enum24_0)
		{
		case Enum24.const_1:
			dateTime_ = new DateTime(dateTime_.Ticks, DateTimeKind.Utc);
			break;
		case Enum24.const_2:
		{
			TimeSpan timeSpan2 = new TimeSpan(struct1_.int_7, struct1_.int_8, 0);
			long num = dateTime_.Ticks + timeSpan2.Ticks;
			long num4 = num;
			DateTime minValue = DateTime.MaxValue;
			if (num4 <= minValue.Ticks)
			{
				dateTime_ = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
				break;
			}
			num += dateTime_.smethod_0().Ticks;
			long num5 = num;
			minValue = DateTime.MaxValue;
			if (num5 > minValue.Ticks)
			{
				minValue = DateTime.MaxValue;
				num = minValue.Ticks;
			}
			dateTime_ = new DateTime(num, DateTimeKind.Local);
			break;
		}
		case Enum24.const_3:
		{
			TimeSpan timeSpan = new TimeSpan(struct1_.int_7, struct1_.int_8, 0);
			long num = dateTime_.Ticks - timeSpan.Ticks;
			long num2 = num;
			DateTime minValue = DateTime.MinValue;
			if (num2 >= minValue.Ticks)
			{
				dateTime_ = new DateTime(num, DateTimeKind.Utc).ToLocalTime();
				break;
			}
			num += dateTime_.smethod_0().Ticks;
			long num3 = num;
			minValue = DateTime.MinValue;
			if (num3 < minValue.Ticks)
			{
				minValue = DateTime.MinValue;
				num = minValue.Ticks;
			}
			dateTime_ = new DateTime(num, DateTimeKind.Local);
			break;
		}
		}
		dateTime_0 = Class7.smethod_517(dateTime_, enum3_0);
		return true;
	}

	static bool smethod_294(Class138? class138_0, JsonProperty jsonProperty_0, Class152 class152_0)
	{
		if (!(class138_0 is Class143 @class))
		{
			return false;
		}
		return @class.CreatorParameters.Contains(jsonProperty_0.string_0);
	}

	static void smethod_295(Class239 class239_0)
	{
		class239_0.binaryWriter_0.Flush();
	}

	static void smethod_296(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0, Class137 class137_0, object object_0)
	{
		if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class29_0 as Interface1, class29_0.Path, "Finished deserializing {0}".smethod_1(CultureInfo.InvariantCulture, class137_0.UnderlyingType)), null);
		}
		class137_0.method_3(object_0, jsonSerializerInternalReader_0.class34_0.streamingContext_0);
	}

	static bool smethod_297(string string_0)
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden
		})!.WaitForExit();
		return true;
	}

	static void smethod_298(Class29 class29_0, Class38 class38_0)
	{
		Class7.smethod_742(class38_0, class29_0, bool_0: true);
	}

	static JsonValidatingReader.SchemaScope smethod_299(JsonValidatingReader jsonValidatingReader_0)
	{
		JsonValidatingReader.SchemaScope result = jsonValidatingReader_0.stack_0.Pop();
		jsonValidatingReader_0.schemaScope_0 = ((jsonValidatingReader_0.stack_0.Count != 0) ? jsonValidatingReader_0.stack_0.Peek() : null);
		return result;
	}

	static bool smethod_300(Class152 class152_0, Enum19 enum19_0, Enum19 enum19_1)
	{
		return (enum19_0 & enum19_1) == enum19_1;
	}

	static bool smethod_301(int int_0, char[] char_0, int int_1, string string_0)
	{
		if (string_0.Length != int_0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num] != char_0[int_1 + num])
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	static object? smethod_302(JsonSerializerInternalReader jsonSerializerInternalReader_0, JToken jtoken_0, Type type_0, Class142? class142_0, JsonProperty jsonProperty_0)
	{
		Class137 class137_ = jsonSerializerInternalReader_0.method_1(type_0);
		Class9 @class = jsonSerializerInternalReader_0.method_5(class137_, null, class142_0, jsonProperty_0);
		Class29 class29_ = new Class32(jtoken_0);
		Class7.smethod_686(class29_);
		if (@class != null && @class.CanRead)
		{
			return Class7.smethod_716(jsonSerializerInternalReader_0, @class, class29_, type_0, (object)null);
		}
		return jsonSerializerInternalReader_0.method_4(class29_, type_0, class137_, null, class142_0, jsonProperty_0, null);
	}

	static void smethod_303(Class164 class164_0, JToken jtoken_0)
	{
		if (jtoken_0.Type != JTokenType.Array)
		{
			throw Class7.smethod_609((Interface1)jtoken_0, jtoken_0.Path, "Expected Array token while parsing enum values, got {0}.".smethod_1(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		class164_0.jsonSchema_0.Enum = new List<JToken>();
		foreach (JToken item in (IEnumerable<JToken>)jtoken_0)
		{
			class164_0.jsonSchema_0.Enum.Add(Class7.smethod_711(item));
		}
	}

	static decimal smethod_304(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (decimal)bigInteger;
			}
			return Convert.ToDecimal(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Decimal.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static string smethod_305(object? object_0)
	{
		if (object_0 == null)
		{
			return "{null}";
		}
		if (!(object_0 is string text))
		{
			return object_0!.ToString();
		}
		return "\"" + text + "\"";
	}

	static char[] smethod_306(int int_0, char[] char_0, Interface0<char> interface0_0)
	{
		if (interface0_0 == null)
		{
			return new char[int_0];
		}
		if (char_0 != null)
		{
			interface0_0.imethod_1(char_0);
		}
		return interface0_0.imethod_0(int_0);
	}

	static void smethod_307(TextWriter textWriter_0, Class34? class34_0, object object_0)
	{
		Class7.smethod_118(class34_0, (Class38?)new Class39(textWriter_0), object_0);
	}

	static void smethod_308(JsonToken jsonToken_0, object object_0, Class41 class41_0)
	{
		Class7.smethod_247(new Class179(object_0), class41_0, jsonToken_0);
	}

	static void smethod_309(int int_0, char[] char_0, char[] char_1, int int_1, int int_2)
	{
		Buffer.BlockCopy(char_1, int_1 * 2, char_0, int_0 * 2, int_2 * 2);
	}

	static void smethod_310(Class29 class29_0)
	{
		if (class29_0.TokenType == JsonToken.PropertyName)
		{
			class29_0.vmethod_0();
		}
		if (Class7.smethod_687(class29_0.TokenType))
		{
			int depth = class29_0.Depth;
			while (class29_0.vmethod_0() && depth < class29_0.Depth)
			{
			}
		}
	}

	static bool smethod_311(object? object_0, CultureInfo cultureInfo_0, Type type_0, out object? object_1)
	{
		try
		{
			if (Class7.smethod_413(ref object_1, object_0, cultureInfo_0, type_0) == Class49.Enum23.const_0)
			{
				return true;
			}
			object_1 = null;
			return false;
		}
		catch
		{
			object_1 = null;
			return false;
		}
	}

	static bool smethod_312(Class30 class30_0, char char_0, int int_0)
	{
		switch (char_0)
		{
		default:
			class30_0.int_3 = int_0;
			if (!char.IsWhiteSpace(char_0) && char_0 != ',' && char_0 != '}' && char_0 != ']' && char_0 != ')' && char_0 != '/')
			{
				throw Class7.smethod_555((Class29)class30_0, "Unexpected character encountered while parsing number: {0}.".smethod_1(CultureInfo.InvariantCulture, char_0));
			}
			return true;
		case '+':
		case '-':
		case '.':
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
		case 'A':
		case 'B':
		case 'C':
		case 'D':
		case 'E':
		case 'F':
		case 'X':
		case 'a':
		case 'b':
		case 'c':
		case 'd':
		case 'e':
		case 'f':
		case 'x':
			return false;
		}
	}

	static void smethod_313(Class38 class38_0, string string_0)
	{
		if (string_0 != null && !Class7.smethod_108(string_0))
		{
			throw Class7.smethod_188(class38_0, "Only white space characters should be used.", (Exception?)null);
		}
	}

	static int smethod_314(Class239 class239_0, int int_0)
	{
		return int_0 + 1;
	}

	static void smethod_315(Class152 class152_0, Class38 class38_0, Array array_0, Class139? class139_0, JsonProperty jsonProperty_0, int int_0, int[] int_1)
	{
		int num = int_1.Length;
		int[] array = new int[num + 1];
		for (int i = 0; i < num; i++)
		{
			array[i] = int_1[i];
		}
		class38_0.vmethod_5();
		for (int j = array_0.GetLowerBound(num); j <= array_0.GetUpperBound(num); j++)
		{
			array[num] = j;
			if (array.Length == array_0.Rank)
			{
				object value = array_0.GetValue(array);
				try
				{
					Class137 class137_ = class139_0!.class137_1 ?? class152_0.method_2(value);
					if (class152_0.method_5(value, null, class137_, class139_0, jsonProperty_0))
					{
						Class7.smethod_712(class38_0, class152_0, value);
					}
					else if (class152_0.method_7(class38_0, value, null, class137_, class139_0, jsonProperty_0))
					{
						class152_0.method_3(class38_0, value, class137_, null, class139_0, jsonProperty_0);
					}
				}
				catch (Exception exception_)
				{
					if (!class152_0.method_0(array_0, class139_0, j, null, class38_0.ContainerPath, exception_))
					{
						throw;
					}
					Class7.smethod_176(int_0 + 1, class38_0, class152_0);
				}
			}
			else
			{
				Class7.smethod_315(class152_0, class38_0, array_0, class139_0, jsonProperty_0, int_0 + 1, array);
			}
		}
		class38_0.vmethod_6();
	}

	static bool smethod_316(Type type_0, Type type_1)
	{
		if (!type_0.smethod_4())
		{
			return false;
		}
		return type_0.GetGenericTypeDefinition() == type_1;
	}

	static double? smethod_317(double? nullable_0, double? nullable_1)
	{
		if (!nullable_1.HasValue)
		{
			return nullable_0;
		}
		if (!nullable_0.HasValue)
		{
			return nullable_1;
		}
		return Math.Max(nullable_1.GetValueOrDefault(), nullable_0.GetValueOrDefault());
	}

	static double smethod_318(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (double)bigInteger;
			}
			return Convert.ToDouble(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Double.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static bool smethod_319(Class29 class29_0, out DateTime dateTime_0, [Attribute1(false)] out string? string_0)
	{
		dateTime_0 = default(DateTime);
		string_0 = null;
		if (Class7.smethod_734(class29_0, out long? nullable_, out string_0) && nullable_.HasValue)
		{
			if (!Class7.smethod_734(class29_0, out long? nullable_2, out string_0))
			{
				return false;
			}
			if (nullable_2.HasValue)
			{
				List<long> list = new List<long> { nullable_.Value, nullable_2.Value };
				while (true)
				{
					if (Class7.smethod_734(class29_0, out long? nullable_3, out string_0))
					{
						if (!nullable_3.HasValue)
						{
							break;
						}
						list.Add(nullable_3.Value);
						continue;
					}
					return false;
				}
				if (list.Count > 7)
				{
					string_0 = "Unexpected number of arguments when reading date constructor.";
					return false;
				}
				while (list.Count < 7)
				{
					list.Add(0L);
				}
				dateTime_0 = new DateTime((int)list[0], (int)list[1] + 1, (int)((list[2] == 0L) ? 1 : list[2]), (int)list[3], (int)list[4], (int)list[5], (int)list[6]);
			}
			else
			{
				dateTime_0 = new DateTime(nullable_.Value * 10000L + Class51.long_0, DateTimeKind.Utc);
			}
			return true;
		}
		string_0 = string_0 ?? "Date constructor has no arguments.";
		return false;
	}

	static IEnumerable<JToken> smethod_320(string string_0, JToken jtoken_0)
	{
		return Class7.smethod_615((Class195)null, string_0, jtoken_0);
	}

	static Class31 smethod_321(Class34 class34_0, Class29 class29_0)
	{
		Class31 @class = new Class31(class29_0);
		if (class29_0.TokenType != 0)
		{
			Class7.smethod_125(@class);
		}
		return @class;
	}

	static long smethod_322(DateTime dateTime_0, TimeSpan timeSpan_0)
	{
		if (dateTime_0.Kind != DateTimeKind.Utc && !(dateTime_0 == DateTime.MaxValue) && !(dateTime_0 == DateTime.MinValue))
		{
			long num = dateTime_0.Ticks - timeSpan_0.Ticks;
			if (num > 3155378975999999999L)
			{
				return 3155378975999999999L;
			}
			if (num < 0L)
			{
				return 0L;
			}
			return num;
		}
		return dateTime_0.Ticks;
	}

	static string smethod_323(string? string_0)
	{
		return Class7.smethod_579(string_0, '"');
	}

	static bool smethod_324(CultureInfo cultureInfo_0, string string_0, ref DateTimeOffset dateTimeOffset_0, [Out] string string_1)
	{
		if (DateTimeOffset.TryParseExact(string_0, string_1, cultureInfo_0, DateTimeStyles.RoundtripKind, out var result))
		{
			dateTimeOffset_0 = result;
			return true;
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	static void smethod_325(Class38 class38_0, JsonToken jsonToken_0)
	{
		Class7.smethod_725(class38_0);
		class38_0.method_2(jsonToken_0);
	}

	static JProperty? smethod_326(JObject jobject_0, string string_0, StringComparison stringComparison_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		JToken jtoken_ = default(JToken);
		if (Class7.smethod_28(jobject_0.class192_0, string_0, ref jtoken_))
		{
			return (JProperty)jtoken_;
		}
		if (stringComparison_0 != StringComparison.Ordinal)
		{
			for (int i = 0; i < jobject_0.class192_0.Count; i++)
			{
				JProperty jProperty = (JProperty)jobject_0.class192_0[i];
				if (string.Equals(jProperty.Name, string_0, stringComparison_0))
				{
					return jProperty;
				}
			}
		}
		return null;
	}

	static DateTimeOffset smethod_327(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_8))
		{
			object value = @class.Value;
			if (value is DateTimeOffset)
			{
				return (DateTimeOffset)value;
			}
			if (@class.Value is string input)
			{
				return DateTimeOffset.Parse(input, CultureInfo.InvariantCulture);
			}
			return new DateTimeOffset(Convert.ToDateTime(@class.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to DateTimeOffset.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static void smethod_328(Class38 class38_0, Class29 class29_0)
	{
		if (!Class7.smethod_319(class29_0, out DateTime dateTime_, out string string_))
		{
			throw Class7.smethod_188(class38_0, string_, (Exception?)null);
		}
		class38_0.vmethod_35(dateTime_);
	}

	static void smethod_329(Class170 class170_0, JsonSchemaNode jsonSchemaNode_0, int int_0, JsonSchema jsonSchema_0)
	{
		JsonSchemaNode jsonSchemaNode_ = ((jsonSchemaNode_0.Items.Count > int_0) ? jsonSchemaNode_0.Items[int_0] : null);
		JsonSchemaNode jsonSchemaNode = Class7.smethod_503(jsonSchemaNode_, class170_0, jsonSchema_0);
		if (jsonSchemaNode_0.Items.Count <= int_0)
		{
			jsonSchemaNode_0.Items.Add(jsonSchemaNode);
		}
		else
		{
			jsonSchemaNode_0.Items[int_0] = jsonSchemaNode;
		}
	}

	static object smethod_330(Type type_0, object object_0, CultureInfo cultureInfo_0)
	{
		object object_ = default(object);
		return Class7.smethod_413(ref object_, object_0, cultureInfo_0, type_0) switch
		{
			Class49.Enum23.const_1 => throw new Exception("Can not convert null {0} into non-nullable {1}.".smethod_2(CultureInfo.InvariantCulture, object_0.GetType(), type_0)), 
			Class49.Enum23.const_2 => throw new ArgumentException("Target type {0} is not a value type or a non-abstract class.".smethod_1(CultureInfo.InvariantCulture, type_0), "targetType"), 
			Class49.Enum23.const_3 => throw new InvalidOperationException("Can not convert from {0} to {1}.".smethod_2(CultureInfo.InvariantCulture, object_0.GetType(), type_0)), 
			Class49.Enum23.const_0 => object_, 
			_ => throw new InvalidOperationException("Unexpected conversion result."), 
		};
	}

	static void smethod_331(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class143? class143_0, JsonProperty jsonProperty_0, Class29 class29_0, string string_0, object object_0)
	{
		if (class143_0!.ExtensionDataSetter != null)
		{
			try
			{
				object value = Class7.smethod_688(jsonProperty_0, class29_0, class143_0, jsonSerializerInternalReader_0);
				class143_0!.ExtensionDataSetter!(object_0, string_0, value);
				return;
			}
			catch (Exception exception_)
			{
				throw Class7.smethod_383("Error setting value in extension data for type '{0}'.".smethod_1(CultureInfo.InvariantCulture, class143_0!.UnderlyingType), exception_, class29_0);
			}
		}
		Class7.smethod_310(class29_0);
	}

	static JToken smethod_332(string? string_0)
	{
		return new Class179(string_0);
	}

	static void smethod_333(JsonSchema jsonSchema_0, JsonSchemaModel jsonSchemaModel_0)
	{
		jsonSchemaModel_0.Required = jsonSchemaModel_0.Required || jsonSchema_0.Required.GetValueOrDefault();
		jsonSchemaModel_0.Type &= jsonSchema_0.Type ?? JsonSchemaType.Any;
		int? minimumLength = jsonSchemaModel_0.MinimumLength;
		int? minimumLength2 = jsonSchema_0.MinimumLength;
		jsonSchemaModel_0.MinimumLength = Class7.smethod_375(minimumLength2, minimumLength);
		jsonSchemaModel_0.MaximumLength = Class7.smethod_455(jsonSchemaModel_0.MaximumLength, jsonSchema_0.MaximumLength);
		double? divisibleBy = jsonSchemaModel_0.DivisibleBy;
		double? divisibleBy2 = jsonSchema_0.DivisibleBy;
		jsonSchemaModel_0.DivisibleBy = Class7.smethod_317(divisibleBy2, divisibleBy);
		divisibleBy = jsonSchemaModel_0.Minimum;
		divisibleBy2 = jsonSchema_0.Minimum;
		jsonSchemaModel_0.Minimum = Class7.smethod_317(divisibleBy2, divisibleBy);
		divisibleBy = jsonSchemaModel_0.Maximum;
		divisibleBy2 = jsonSchema_0.Maximum;
		jsonSchemaModel_0.Maximum = Class7.smethod_317(divisibleBy2, divisibleBy);
		jsonSchemaModel_0.ExclusiveMinimum = jsonSchemaModel_0.ExclusiveMinimum || jsonSchema_0.ExclusiveMinimum.GetValueOrDefault();
		jsonSchemaModel_0.ExclusiveMaximum = jsonSchemaModel_0.ExclusiveMaximum || jsonSchema_0.ExclusiveMaximum.GetValueOrDefault();
		minimumLength = jsonSchemaModel_0.MinimumItems;
		minimumLength2 = jsonSchema_0.MinimumItems;
		jsonSchemaModel_0.MinimumItems = Class7.smethod_375(minimumLength2, minimumLength);
		jsonSchemaModel_0.MaximumItems = Class7.smethod_455(jsonSchemaModel_0.MaximumItems, jsonSchema_0.MaximumItems);
		jsonSchemaModel_0.PositionalItemsValidation = jsonSchemaModel_0.PositionalItemsValidation || jsonSchema_0.PositionalItemsValidation;
		jsonSchemaModel_0.AllowAdditionalProperties = jsonSchemaModel_0.AllowAdditionalProperties && jsonSchema_0.AllowAdditionalProperties;
		jsonSchemaModel_0.AllowAdditionalItems = jsonSchemaModel_0.AllowAdditionalItems && jsonSchema_0.AllowAdditionalItems;
		jsonSchemaModel_0.UniqueItems = jsonSchemaModel_0.UniqueItems || jsonSchema_0.UniqueItems;
		if (jsonSchema_0.Enum != null)
		{
			if (jsonSchemaModel_0.Enum == null)
			{
				jsonSchemaModel_0.Enum = new List<JToken>();
			}
			jsonSchemaModel_0.Enum.smethod_5(jsonSchema_0.Enum, JToken.EqualityComparer);
		}
		jsonSchemaModel_0.Disallow |= jsonSchema_0.Disallow.GetValueOrDefault();
		if (jsonSchema_0.Pattern != null)
		{
			if (jsonSchemaModel_0.Patterns == null)
			{
				jsonSchemaModel_0.Patterns = new List<string>();
			}
			jsonSchemaModel_0.Patterns.smethod_2(jsonSchema_0.Pattern);
		}
	}

	static Enum33 smethod_334(Class212 class212_0)
	{
		if (class212_0.int_0 + 1 >= class212_0.string_0.Length)
		{
			throw new JsonException("Path ended with open query.");
		}
		if (Class7.smethod_145(class212_0, "==="))
		{
			return Enum33.const_11;
		}
		if (Class7.smethod_145(class212_0, "=="))
		{
			return Enum33.const_1;
		}
		if (Class7.smethod_145(class212_0, "=~"))
		{
			return Enum33.const_10;
		}
		if (Class7.smethod_145(class212_0, "!=="))
		{
			return Enum33.const_12;
		}
		if (!Class7.smethod_145(class212_0, "!=") && !Class7.smethod_145(class212_0, "<>"))
		{
			if (Class7.smethod_145(class212_0, "<="))
			{
				return Enum33.const_5;
			}
			if (Class7.smethod_145(class212_0, "<"))
			{
				return Enum33.const_4;
			}
			if (Class7.smethod_145(class212_0, ">="))
			{
				return Enum33.const_7;
			}
			if (Class7.smethod_145(class212_0, ">"))
			{
				return Enum33.const_6;
			}
			throw new JsonException("Could not read query operator.");
		}
		return Enum33.const_2;
	}

	static JToken smethod_335(object object_0)
	{
		return Class7.smethod_497(object_0, Class7.smethod_575());
	}

	static bool smethod_336(ref Class137 class137_0, Class38 class38_0, JsonProperty jsonProperty_0, object? object_0, JsonProperty jsonProperty_1, [Out][Attribute1(true)] Class138? class138_0, out object? object_1, Class152 class152_0)
	{
		if (!jsonProperty_1.Ignored && jsonProperty_1.Readable && Class7.smethod_557(class38_0, class152_0, jsonProperty_1, object_0) && Class7.smethod_185(jsonProperty_1, class152_0, class38_0, object_0))
		{
			if (jsonProperty_1.PropertyContract == null)
			{
				jsonProperty_1.PropertyContract = class152_0.class34_0.interface4_0.imethod_0(jsonProperty_1.type_0);
			}
			object_1 = jsonProperty_1.ValueProvider!.imethod_1(object_0);
			class137_0 = (jsonProperty_1.PropertyContract!.bool_4 ? jsonProperty_1.PropertyContract : class152_0.method_2(object_1));
			if (class152_0.method_6(object_1, class138_0 as Class143, jsonProperty_1))
			{
				if (class152_0.method_5(object_1, jsonProperty_1, class137_0, class138_0, jsonProperty_0))
				{
					jsonProperty_1.method_0(class38_0);
					Class7.smethod_712(class38_0, class152_0, object_1);
					return false;
				}
				if (!class152_0.method_7(class38_0, object_1, jsonProperty_1, class137_0, class138_0, jsonProperty_0))
				{
					return false;
				}
				if (object_1 == null)
				{
					Class143 @class = class138_0 as Class143;
					switch (jsonProperty_1.nullable_0 ?? (@class?.ItemRequired).GetValueOrDefault())
					{
					case Enum16.const_2:
						throw Class7.smethod_505((Interface1?)null, class38_0.ContainerPath, "Cannot write a null value for property '{0}'. Property requires a value.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_1.string_0), (Exception?)null);
					case Enum16.const_3:
						throw Class7.smethod_505((Interface1?)null, class38_0.ContainerPath, "Cannot write a null value for property '{0}'. Property requires a non-null value.".smethod_1(CultureInfo.InvariantCulture, jsonProperty_1.string_0), (Exception?)null);
					}
				}
				return true;
			}
		}
		class137_0 = null;
		object_1 = null;
		return false;
	}

	static bool smethod_337(ref long long_0, [Out] Struct4 struct4_0, out DateTimeKind dateTimeKind_0, out TimeSpan timeSpan_0)
	{
		dateTimeKind_0 = DateTimeKind.Utc;
		int num = struct4_0.smethod_0('+', 7, struct4_0.Length - 8);
		if (num == -1)
		{
			num = struct4_0.smethod_0('-', 7, struct4_0.Length - 8);
		}
		if (num != -1)
		{
			dateTimeKind_0 = DateTimeKind.Local;
			if (!Class7.smethod_669(num + struct4_0.StartIndex, struct4_0, out timeSpan_0))
			{
				long_0 = 0L;
				return false;
			}
		}
		else
		{
			timeSpan_0 = TimeSpan.Zero;
			num = struct4_0.Length - 2;
		}
		return Class7.smethod_245(struct4_0.Chars, 6 + struct4_0.StartIndex, num - 6, out long_0) == Enum22.const_1;
	}

	static string smethod_338(XmlNode? xmlNode_0)
	{
		return Class7.smethod_641(xmlNode_0, Enum7.const_0);
	}

	static object smethod_339(JsonSerializerInternalReader jsonSerializerInternalReader_0, IList ilist_0, Class29 class29_0, Class139? class139_0, JsonProperty? jsonProperty_0, string string_0)
	{
		int arrayRank = class139_0!.UnderlyingType.GetArrayRank();
		if (string_0 != null)
		{
			Class7.smethod_398((object)ilist_0, jsonSerializerInternalReader_0, string_0, class29_0);
		}
		Class7.smethod_208(jsonSerializerInternalReader_0, class29_0, (Class137)class139_0, (object)ilist_0);
		Class137 class137_ = jsonSerializerInternalReader_0.method_1(class139_0!.CollectionItemType);
		Class9 @class = jsonSerializerInternalReader_0.method_5(class137_, null, class139_0, jsonProperty_0);
		int? num = null;
		Stack<IList> stack = new Stack<IList>();
		stack.Push(ilist_0);
		IList list = ilist_0;
		bool flag = false;
		do
		{
			int depth = class29_0.Depth;
			if (stack.Count != arrayRank)
			{
				if (!class29_0.vmethod_0())
				{
					break;
				}
				switch (class29_0.TokenType)
				{
				case JsonToken.EndArray:
					stack.Pop();
					if (stack.Count > 0)
					{
						list = stack.Peek();
					}
					else
					{
						flag = true;
					}
					break;
				case JsonToken.StartArray:
				{
					IList list2 = new List<object>();
					list.Add(list2);
					stack.Push(list2);
					list = list2;
					break;
				}
				case JsonToken.Comment:
					break;
				default:
					throw Class7.smethod_161(class29_0, "Unexpected token when deserializing multidimensional array: " + class29_0.TokenType);
				}
				continue;
			}
			try
			{
				if (Class7.smethod_440(class29_0, class137_, @class != null))
				{
					switch (class29_0.TokenType)
					{
					case JsonToken.EndArray:
						stack.Pop();
						list = stack.Peek();
						num = null;
						break;
					default:
					{
						object value = ((@class == null || !@class.CanRead) ? jsonSerializerInternalReader_0.method_4(class29_0, class139_0!.CollectionItemType, class137_, null, class139_0, jsonProperty_0, null) : Class7.smethod_716(jsonSerializerInternalReader_0, @class, class29_0, class139_0!.CollectionItemType, (object)null));
						list.Add(value);
						break;
					}
					case JsonToken.Comment:
						break;
					}
					continue;
				}
			}
			catch (Exception exception_)
			{
				Struct0 @struct = Class7.smethod_685(depth, class29_0);
				if (jsonSerializerInternalReader_0.method_0(ilist_0, class139_0, @struct.int_0, class29_0 as Interface1, class29_0.Path, exception_))
				{
					Class7.smethod_53(class29_0, bool_0: true, jsonSerializerInternalReader_0, depth + 1);
					if (num.HasValue && num == @struct.int_0)
					{
						throw Class7.smethod_383("Infinite loop detected from error handling.", exception_, class29_0);
					}
					num = @struct.int_0;
					continue;
				}
				throw;
			}
			break;
		}
		while (!flag);
		if (!flag)
		{
			Class7.smethod_574((object)ilist_0, class29_0, "Unexpected end when deserializing array.", jsonSerializerInternalReader_0, (Class137)class139_0);
		}
		Class7.smethod_296(jsonSerializerInternalReader_0, class29_0, (Class137)class139_0, (object)ilist_0);
		return ilist_0;
	}

	static void smethod_340(IList<PropertyInfo> ilist_0, Type type_0, BindingFlags bindingFlags_0)
	{
		while ((type_0 = type_0.smethod_6()) != null)
		{
			PropertyInfo[] properties = type_0.GetProperties(bindingFlags_0);
			foreach (PropertyInfo propertyInfo_2 in properties)
			{
				ReflectionUtils.Class105 CS_0024_003C_003E8__locals0 = new ReflectionUtils.Class105();
				CS_0024_003C_003E8__locals0.propertyInfo_0 = propertyInfo_2;
				if (!CS_0024_003C_003E8__locals0.propertyInfo_0.smethod_0())
				{
					if (!Class7.smethod_206(CS_0024_003C_003E8__locals0.propertyInfo_0))
					{
						int num = ilist_0.smethod_6((PropertyInfo propertyInfo_1) => propertyInfo_1.Name == CS_0024_003C_003E8__locals0.propertyInfo_0.Name);
						if (num == -1)
						{
							ilist_0.Add(CS_0024_003C_003E8__locals0.propertyInfo_0);
						}
						else if (!Class7.smethod_206(ilist_0[num]))
						{
							ilist_0[num] = CS_0024_003C_003E8__locals0.propertyInfo_0;
						}
					}
					else if (ilist_0.smethod_6((PropertyInfo propertyInfo_1) => propertyInfo_1.Name == CS_0024_003C_003E8__locals0.propertyInfo_0.Name && propertyInfo_1.DeclaringType == CS_0024_003C_003E8__locals0.propertyInfo_0.DeclaringType) == -1)
					{
						ilist_0.Add(CS_0024_003C_003E8__locals0.propertyInfo_0);
					}
					continue;
				}
				ReflectionUtils.Class106 CS_0024_003C_003E8__locals1 = new ReflectionUtils.Class106();
				CS_0024_003C_003E8__locals1.class105_0 = CS_0024_003C_003E8__locals0;
				MethodInfo? methodInfo = CS_0024_003C_003E8__locals1.class105_0.propertyInfo_0.smethod_1();
				object obj;
				if ((object)methodInfo == null)
				{
					obj = null;
				}
				else
				{
					obj = methodInfo!.DeclaringType;
					if (obj != null)
					{
						goto IL_00f9;
					}
				}
				obj = CS_0024_003C_003E8__locals1.class105_0.propertyInfo_0.DeclaringType;
				goto IL_00f9;
				IL_00f9:
				CS_0024_003C_003E8__locals1.type_0 = (Type)obj;
				if (ilist_0.smethod_6(delegate(PropertyInfo propertyInfo_0)
				{
					if (!(propertyInfo_0.Name == CS_0024_003C_003E8__locals1.class105_0.propertyInfo_0.Name) || !propertyInfo_0.smethod_0())
					{
						return false;
					}
					MethodInfo? methodInfo2 = propertyInfo_0.smethod_1();
					object obj2;
					if ((object)methodInfo2 == null)
					{
						obj2 = null;
					}
					else
					{
						obj2 = methodInfo2!.DeclaringType;
						if (obj2 != null)
						{
							goto IL_0041;
						}
					}
					obj2 = propertyInfo_0.DeclaringType;
					goto IL_0041;
					IL_0041:
					return ((Type)obj2).IsAssignableFrom(CS_0024_003C_003E8__locals1.type_0);
				}) == -1)
				{
					ilist_0.Add(CS_0024_003C_003E8__locals1.class105_0.propertyInfo_0);
				}
			}
		}
	}

	static bool smethod_341(string string_0, Class30 class30_0, bool bool_0)
	{
		if (!bool_0)
		{
			class30_0.int_3 = class30_0.int_2;
			throw class30_0.method_2();
		}
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (class30_0.char_2[class30_0.int_3 + num] != string_0[num])
				{
					break;
				}
				num++;
				continue;
			}
			class30_0.int_3 += string_0.Length;
			return true;
		}
		class30_0.int_3 += num;
		return false;
	}

	static object? smethod_342(object? object_0, CultureInfo cultureInfo_0, Type type_0)
	{
		if (type_0 == typeof(object))
		{
			return object_0;
		}
		if (object_0 == null && Class7.smethod_213(type_0))
		{
			return null;
		}
		if (Class7.smethod_311(object_0, cultureInfo_0, type_0, out object object_))
		{
			return object_;
		}
		return Class7.smethod_516(object_0, ReflectionUtils.smethod_2(object_0), type_0);
	}

	static bool smethod_343(Class27 class27_0, Type type_0)
	{
		return typeof(XmlNode).IsAssignableFrom(type_0);
	}

	static Class139 smethod_344(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0, Type type_0, Class137 class137_0)
	{
		if (class137_0 == null)
		{
			throw Class7.smethod_161(class29_0, "Could not resolve type '{0}' to a JsonContract.".smethod_1(CultureInfo.InvariantCulture, type_0));
		}
		Class139 obj = class137_0 as Class139;
		if (obj == null)
		{
			string string_ = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + Environment.NewLine;
			string_ = string_.smethod_2(CultureInfo.InvariantCulture, type_0, Class7.smethod_552(jsonSerializerInternalReader_0, class137_0));
			throw Class7.smethod_161(class29_0, string_);
		}
		return obj;
	}

	static Interface11 smethod_345(Class27 class27_0, object object_0)
	{
		XObject val = (XObject)((object_0 is XObject) ? object_0 : null);
		if (val != null)
		{
			return Class7.smethod_484(val);
		}
		if (!(object_0 is XmlNode xmlNode_))
		{
			throw new ArgumentException("Value must be an XML object.", "value");
		}
		return Class224.smethod_0(xmlNode_);
	}

	static bool smethod_346(string string_0, Class30 class30_0)
	{
		if (!Class7.smethod_496(string_0, class30_0))
		{
			return false;
		}
		if (!Class7.smethod_260(class30_0, 0, bool_0: false))
		{
			return true;
		}
		if (!Class7.smethod_105(class30_0, class30_0.char_2[class30_0.int_3]))
		{
			return class30_0.char_2[class30_0.int_3] == '\0';
		}
		return true;
	}

	static char smethod_347(Class30 class30_0, bool bool_0)
	{
		if (bool_0)
		{
			char[] char_ = class30_0.char_2;
			int int_ = class30_0.int_3;
			int int_2 = class30_0.int_3 + 4;
			int int_3 = default(int);
			if (!Class7.smethod_610(int_, ref int_3, char_, int_2))
			{
				throw Class7.smethod_555((Class29)class30_0, "Invalid Unicode escape sequence: \\u{0}.".smethod_1(CultureInfo.InvariantCulture, new string(class30_0.char_2, class30_0.int_3, 4)));
			}
			char result = Convert.ToChar(int_3);
			class30_0.int_3 += 4;
			return result;
		}
		throw Class7.smethod_555((Class29)class30_0, "Unexpected end while parsing Unicode escape sequence.");
	}

	static void smethod_348(Class100 class100_0, object object_0, string? string_0, object object_1)
	{
		class100_0.Members[string_0].Setter!(object_0, object_1);
	}

	static long smethod_349(Class33 class33_0)
	{
		Class7.smethod_452(class33_0, 8);
		return class33_0.binaryReader_0.ReadInt64();
	}

	static JsonSchemaModel smethod_350(IList<JsonSchema> ilist_0)
	{
		JsonSchemaModel jsonSchemaModel = new JsonSchemaModel();
		foreach (JsonSchema item in ilist_0)
		{
			Class7.smethod_333(item, jsonSchemaModel);
		}
		return jsonSchemaModel;
	}

	static bool smethod_351(Class32 class32_0, JToken jtoken_0)
	{
		if (jtoken_0 == class32_0.jtoken_0)
		{
			return Class7.smethod_252(class32_0);
		}
		JToken next = jtoken_0.Next;
		if (next != null && next != jtoken_0 && jtoken_0 != jtoken_0.Parent!.Last)
		{
			class32_0.jtoken_2 = next;
			Class7.smethod_614(class32_0, class32_0.jtoken_2);
			return true;
		}
		if (jtoken_0.Parent == null)
		{
			return Class7.smethod_252(class32_0);
		}
		return Class7.smethod_91(class32_0, jtoken_0.Parent);
	}

	static string smethod_352(DateTimeOffset dateTimeOffset_0)
	{
		return Class7.smethod_141(dateTimeOffset_0, Enum1.const_0);
	}

	static void smethod_353(JsonValidatingReader jsonValidatingReader_0, JsonValidatingReader.SchemaScope schemaScope_0)
	{
		jsonValidatingReader_0.stack_0.Push(schemaScope_0);
		jsonValidatingReader_0.schemaScope_0 = schemaScope_0;
	}

	static void smethod_354(Class212 class212_0, string string_0)
	{
		if (class212_0.int_0 >= class212_0.string_0.Length)
		{
			throw new JsonException(string_0);
		}
	}

	static string smethod_355(Type type_0)
	{
		if (!type_0.smethod_5() && type_0.smethod_2())
		{
			return "{0}.{1}".smethod_2(CultureInfo.InvariantCulture, type_0.Namespace, type_0.Name);
		}
		return type_0.FullName;
	}

	static void smethod_356(string string_0, Class192 class192_0, JToken jtoken_0)
	{
		if (!Class7.smethod_201(class192_0, jtoken_0))
		{
			throw new ArgumentException("The specified item does not exist in this KeyedCollection.");
		}
		string text = Class7.smethod_267(class192_0, jtoken_0);
		if (!Class192.iequalityComparer_0.Equals(text, string_0))
		{
			if (string_0 != null)
			{
				Class7.smethod_24(class192_0, string_0, jtoken_0);
			}
			if (text != null)
			{
				class192_0.method_1(text);
			}
		}
	}

	static string smethod_357(string? string_0, char char_0, bool bool_0, Enum17 enum17_0)
	{
		bool[] bool_ = Class7.smethod_595(char_0, enum17_0);
		using StringWriter stringWriter = Class7.smethod_470(string_0?.Length ?? 16);
		char[] char_ = null;
		Class88.smethod_0(stringWriter, string_0, char_0, bool_0, bool_, enum17_0, null, ref char_);
		return stringWriter.ToString();
	}

	static CallSiteBinder smethod_358(string string_0, Type type_0)
	{
		Class7.smethod_412();
		return (CallSiteBinder)Class72.Class73.delegate1_0!(null, 0, string_0, type_0, Class72.Class73.object_0);
	}

	static Class177 smethod_359(object object_0)
	{
		return Class7.smethod_613(object_0, Class7.smethod_575());
	}

	static TimeSpan smethod_360(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_5))
		{
			object value = @class.Value;
			if (value is TimeSpan)
			{
				return (TimeSpan)value;
			}
			return Class7.smethod_410(Convert.ToString(@class.Value, CultureInfo.InvariantCulture));
		}
		throw new ArgumentException("Can not convert {0} to TimeSpan.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static BsonType smethod_361(Class33 class33_0)
	{
		Class7.smethod_452(class33_0, 1);
		return (BsonType)class33_0.binaryReader_0.ReadSByte();
	}

	static JToken smethod_362(byte[] byte_0)
	{
		return new Class179(byte_0);
	}

	static JsonContainerType smethod_363(Class38 class38_0)
	{
		return class38_0.struct0_0.jsonContainerType_0;
	}

	static void smethod_364(JsonSchemaModel jsonSchemaModel_0, JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonSchemaModel_0 == null || !Class7.smethod_238(jsonValidatingReader_0, jsonSchemaModel_0, JsonSchemaType.String))
		{
			return;
		}
		Class7.smethod_589(jsonValidatingReader_0, jsonSchemaModel_0);
		string text = jsonValidatingReader_0.class29_0.Value!.ToString();
		if (jsonSchemaModel_0.MaximumLength.HasValue && text.Length > jsonSchemaModel_0.MaximumLength)
		{
			Class7.smethod_239(jsonValidatingReader_0, "String '{0}' exceeds maximum length of {1}.".smethod_2(CultureInfo.InvariantCulture, text, jsonSchemaModel_0.MaximumLength), jsonSchemaModel_0);
		}
		if (jsonSchemaModel_0.MinimumLength.HasValue && text.Length < jsonSchemaModel_0.MinimumLength)
		{
			Class7.smethod_239(jsonValidatingReader_0, "String '{0}' is less than minimum length of {1}.".smethod_2(CultureInfo.InvariantCulture, text, jsonSchemaModel_0.MinimumLength), jsonSchemaModel_0);
		}
		if (jsonSchemaModel_0.Patterns == null)
		{
			return;
		}
		foreach (string pattern in jsonSchemaModel_0.Patterns)
		{
			if (!Regex.IsMatch(text, pattern))
			{
				Class7.smethod_239(jsonValidatingReader_0, "String '{0}' does not match regex pattern '{1}'.".smethod_2(CultureInfo.InvariantCulture, text, pattern), jsonSchemaModel_0);
			}
		}
	}

	static void smethod_365(Class29 class29_0, JsonContainerType jsonContainerType_0)
	{
		Class7.smethod_388(class29_0);
		if (class29_0.struct0_0.jsonContainerType_0 == JsonContainerType.None)
		{
			class29_0.struct0_0 = new Struct0(jsonContainerType_0);
			return;
		}
		if (class29_0.list_0 == null)
		{
			class29_0.list_0 = new List<Struct0>();
		}
		class29_0.list_0!.Add(class29_0.struct0_0);
		class29_0.struct0_0 = new Struct0(jsonContainerType_0);
		if (!class29_0.nullable_0.HasValue || !(class29_0.Depth + 1 > class29_0.nullable_0) || class29_0.bool_0)
		{
			return;
		}
		class29_0.bool_0 = true;
		throw Class7.smethod_555(class29_0, "The reader's MaxDepth of {0} has been exceeded.".smethod_1(CultureInfo.InvariantCulture, class29_0.nullable_0));
	}

	static void smethod_366(Class39 class39_0)
	{
		if (class39_0.char_2 != null)
		{
			Class7.smethod_520(class39_0.interface0_0, class39_0.char_2);
			class39_0.char_2 = null;
		}
		if (class39_0.CloseOutput)
		{
			class39_0.textWriter_0?.Close();
		}
	}

	static void smethod_367(PropertyInfo propertyInfo_0, Class69 class69_0, ILGenerator ilgenerator_0)
	{
		MethodInfo getMethod = propertyInfo_0.GetGetMethod(nonPublic: true);
		if (getMethod == null)
		{
			throw new ArgumentException("Property '{0}' does not have a getter.".smethod_1(CultureInfo.InvariantCulture, propertyInfo_0.Name));
		}
		if (!getMethod.IsStatic)
		{
			ilgenerator_0.smethod_0(propertyInfo_0.DeclaringType);
		}
		ilgenerator_0.smethod_4(getMethod);
		ilgenerator_0.smethod_2(propertyInfo_0.PropertyType);
		ilgenerator_0.smethod_5();
	}

	static void smethod_368(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0, object object_0)
	{
		Class113.smethod_0(object_0, "target");
		Type type = object_0.GetType();
		Class137 @class = jsonSerializerInternalReader_0.class34_0.interface4_0.imethod_0(type);
		if (!Class7.smethod_407(class29_0))
		{
			throw Class7.smethod_161(class29_0, "No JSON content found.");
		}
		if (class29_0.TokenType == JsonToken.StartArray)
		{
			if (@class.enum26_0 == Enum26.const_2)
			{
				Class139 class2 = (Class139)@class;
				object ilist_;
				if (!class2.ShouldCreateWrapper)
				{
					ilist_ = (IList)object_0;
				}
				else
				{
					IList list = class2.method_5(object_0);
					ilist_ = list;
				}
				Class7.smethod_444(jsonSerializerInternalReader_0, (IList)ilist_, class29_0, class2, (JsonProperty?)null, (string)null);
				return;
			}
			throw Class7.smethod_161(class29_0, "Cannot populate JSON array onto type '{0}'.".smethod_1(CultureInfo.InvariantCulture, type));
		}
		if (class29_0.TokenType == JsonToken.StartObject)
		{
			Class7.smethod_686(class29_0);
			string string_ = null;
			if (jsonSerializerInternalReader_0.class34_0.MetadataPropertyHandling != Enum10.const_2 && class29_0.TokenType == JsonToken.PropertyName && string.Equals(class29_0.Value!.ToString(), "$id", StringComparison.Ordinal))
			{
				Class7.smethod_686(class29_0);
				string_ = class29_0.Value?.ToString();
				Class7.smethod_686(class29_0);
			}
			if (@class.enum26_0 == Enum26.const_5)
			{
				Class140 class3 = (Class140)@class;
				object idictionary_;
				if (!class3.ShouldCreateWrapper)
				{
					idictionary_ = (IDictionary)object_0;
				}
				else
				{
					IDictionary dictionary = class3.method_5(object_0);
					idictionary_ = dictionary;
				}
				Class7.smethod_751(jsonSerializerInternalReader_0, (IDictionary)idictionary_, class29_0, class3, (JsonProperty?)null, string_);
			}
			else
			{
				if (@class.enum26_0 != Enum26.const_1)
				{
					throw Class7.smethod_161(class29_0, "Cannot populate JSON object onto type '{0}'.".smethod_1(CultureInfo.InvariantCulture, type));
				}
				jsonSerializerInternalReader_0.method_16(object_0, class29_0, (Class143)@class, null, string_);
			}
			return;
		}
		throw Class7.smethod_161(class29_0, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
	}

	static Type? smethod_369(Type type_0)
	{
		Class113.smethod_0(type_0, "type");
		if (type_0.IsArray)
		{
			return type_0.GetElementType();
		}
		if (Class7.smethod_730(type_0, typeof(IEnumerable<>), out Type type_))
		{
			if (type_.smethod_5())
			{
				throw new Exception("Type {0} is not a collection.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			return type_.GetGenericArguments()[0];
		}
		if (!typeof(IEnumerable).IsAssignableFrom(type_0))
		{
			throw new Exception("Type {0} is not a collection.".smethod_1(CultureInfo.InvariantCulture, type_0));
		}
		return null;
	}

	static void smethod_370(ref string string_0, out string? string_1, [Out] string string_2)
	{
		int num = string_2.IndexOf(':');
		if (num != -1 && num != 0 && string_2.Length - 1 != num)
		{
			string_1 = string_2.Substring(0, num);
			string_0 = string_2.Substring(num + 1);
		}
		else
		{
			string_1 = null;
			string_0 = string_2;
		}
	}

	static object smethod_371(Enum8 enum8_0, Class30 class30_0)
	{
		return Class7.smethod_384(enum8_0, class30_0, Class7.smethod_346(Class8.string_5, class30_0));
	}

	static int smethod_372(Enum17 enum17_0, bool[] bool_0, string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num != string_0.Length)
			{
				char c = string_0[num];
				if (c < bool_0.Length)
				{
					if (bool_0[(uint)c])
					{
						return num;
					}
				}
				else
				{
					if (enum17_0 == Enum17.const_1)
					{
						return num;
					}
					if (c == '\u0085' || c == '\u2028' || c == '\u2029')
					{
						break;
					}
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	static JToken smethod_373(double? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static void smethod_374(Class30 class30_0, bool bool_0, int int_0, int int_1)
	{
		if (bool_0)
		{
			Class7.smethod_186((Class29)class30_0, JsonToken.Comment, (object)new string(class30_0.char_2, int_0, int_1 - int_0));
		}
	}

	static int? smethod_375(int? nullable_0, int? nullable_1)
	{
		if (!nullable_1.HasValue)
		{
			return nullable_0;
		}
		if (!nullable_0.HasValue)
		{
			return nullable_1;
		}
		return Math.Max(nullable_1.GetValueOrDefault(), nullable_0.GetValueOrDefault());
	}

	static string smethod_376(XObject? xobject_0)
	{
		return Class7.smethod_578(xobject_0, Enum7.const_0);
	}

	static void smethod_377(JsonSchemaException jsonSchemaException_0, JsonValidatingReader jsonValidatingReader_0)
	{
		Delegate8 delegate8_ = jsonValidatingReader_0.delegate8_0;
		if (delegate8_ == null)
		{
			throw jsonSchemaException_0;
		}
		delegate8_(jsonValidatingReader_0, new EventArgs1(jsonSchemaException_0));
	}

	static bool smethod_378(JsonProperty jsonProperty_0, object object_0, Class29 class29_0, JsonSerializerInternalReader jsonSerializerInternalReader_0)
	{
		if (jsonProperty_0.ShouldDeserialize == null)
		{
			return true;
		}
		bool flag = jsonProperty_0.ShouldDeserialize!(object_0);
		if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
		{
			jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class29_0.Path, "ShouldDeserialize result for property '{0}' on {1}: {2}".smethod_3(CultureInfo.InvariantCulture, jsonProperty_0.string_0, jsonProperty_0.DeclaringType, flag)), null);
		}
		return flag;
	}

	static void smethod_379(Class34 class34_0, EventArgs0 eventArgs0_0)
	{
		class34_0.eventHandler_0?.Invoke(class34_0, eventArgs0_0);
	}

	static Class34 smethod_380(Class36? class36_0)
	{
		Class34 @class = Class7.smethod_575();
		if (class36_0 != null)
		{
			Class7.smethod_750(class36_0, @class);
		}
		return @class;
	}

	static TraceEventType smethod_381(Class133 class133_0, TraceLevel traceLevel_0)
	{
		return traceLevel_0 switch
		{
			TraceLevel.Error => TraceEventType.Error, 
			TraceLevel.Warning => TraceEventType.Warning, 
			TraceLevel.Info => TraceEventType.Information, 
			TraceLevel.Verbose => TraceEventType.Verbose, 
			_ => throw new ArgumentOutOfRangeException("level"), 
		};
	}

	static bool smethod_382(Class152 class152_0, Enum4 enum4_0, Enum4 enum4_1)
	{
		return (enum4_0 & enum4_1) == enum4_1;
	}

	static JsonSerializationException smethod_383(string string_0, Exception exception_0, Class29? class29_0)
	{
		return Class7.smethod_505(class29_0 as Interface1, class29_0!.Path, string_0, exception_0);
	}

	static object smethod_384(Enum8 enum8_0, Class30 class30_0, bool bool_0)
	{
		if (bool_0)
		{
			switch (enum8_0)
			{
			case Enum8.const_4:
				Class7.smethod_186((Class29)class30_0, JsonToken.String, (object)Class8.string_5);
				return Class8.string_5;
			case Enum8.const_0:
			case Enum8.const_8:
				if (class30_0.enum6_0 == Enum6.const_0)
				{
					Class7.smethod_186((Class29)class30_0, JsonToken.Float, (object)double.NegativeInfinity);
					return double.NegativeInfinity;
				}
				goto default;
			default:
				throw Class7.smethod_555((Class29)class30_0, "Cannot read -Infinity value.");
			}
		}
		throw Class7.smethod_555((Class29)class30_0, "Error parsing -Infinity value.");
	}

	static int smethod_385(Class33 class33_0, byte byte_0)
	{
		if (byte_0 <= Class33.byte_0[1])
		{
			return 1;
		}
		if (byte_0 >= Class33.byte_1[0] && byte_0 <= Class33.byte_1[1])
		{
			return 2;
		}
		if (byte_0 >= Class33.byte_2[0] && byte_0 <= Class33.byte_2[1])
		{
			return 3;
		}
		if (byte_0 >= Class33.byte_3[0] && byte_0 <= Class33.byte_3[1])
		{
			return 4;
		}
		return 0;
	}

	static void smethod_386(Class29 class29_0, JsonToken jsonToken_0)
	{
		Class7.smethod_211(class29_0, jsonToken_0, (object)null, bool_0: true);
	}

	static void smethod_387(JObject jobject_0, Class164 class164_0)
	{
		using IEnumerator<KeyValuePair<string, JToken>> enumerator = jobject_0.System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_003E_002EGetEnumerator();
		while (enumerator.MoveNext())
		{
			KeyValuePair<string, JToken> current = enumerator.Current;
			string key = current.Key;
			switch (Class7.smethod_78(key))
			{
			case 353304077u:
				if (key == "divisibleBy")
				{
					class164_0.jsonSchema_0.DivisibleBy = Class7.smethod_318(current.Value);
				}
				break;
			case 334560121u:
				if (key == "minItems")
				{
					class164_0.jsonSchema_0.MinimumItems = Class7.smethod_640(current.Value);
				}
				break;
			case 299789532u:
				if (key == "properties")
				{
					class164_0.jsonSchema_0.Properties = Class7.smethod_272(current.Value, class164_0);
				}
				break;
			case 879704937u:
				if (key == "description")
				{
					class164_0.jsonSchema_0.Description = JToken.smethod_19(current.Value);
				}
				break;
			case 479998177u:
				if (key == "additionalProperties")
				{
					Class7.smethod_396(class164_0, current.Value);
				}
				break;
			case 981021583u:
				if (key == "items")
				{
					Class7.smethod_472(class164_0, current.Value);
				}
				break;
			case 926444256u:
				if (key == "id")
				{
					class164_0.jsonSchema_0.Id = JToken.smethod_19(current.Value);
				}
				break;
			case 1693958795u:
				if (key == "exclusiveMaximum")
				{
					class164_0.jsonSchema_0.ExclusiveMaximum = Class7.smethod_483(current.Value);
				}
				break;
			case 1542649473u:
				if (key == "maximum")
				{
					class164_0.jsonSchema_0.Maximum = Class7.smethod_318(current.Value);
				}
				break;
			case 1361572173u:
				if (key == "type")
				{
					class164_0.jsonSchema_0.Type = Class7.smethod_443(class164_0, current.Value);
				}
				break;
			case 2051482624u:
				if (key == "additionalItems")
				{
					Class7.smethod_248(class164_0, current.Value);
				}
				break;
			case 1913005517u:
				if (key == "exclusiveMinimum")
				{
					class164_0.jsonSchema_0.ExclusiveMinimum = Class7.smethod_483(current.Value);
				}
				break;
			case 2223801888u:
				if (key == "required")
				{
					class164_0.jsonSchema_0.Required = Class7.smethod_483(current.Value);
				}
				break;
			case 2171383808u:
				if (key == "enum")
				{
					Class7.smethod_303(class164_0, current.Value);
				}
				break;
			case 2474713847u:
				if (key == "minimum")
				{
					class164_0.jsonSchema_0.Minimum = Class7.smethod_318(current.Value);
				}
				break;
			case 2470140894u:
				if (key == "default")
				{
					class164_0.jsonSchema_0.Default = Class7.smethod_711(current.Value);
				}
				break;
			case 2268922153u:
				if (key == "pattern")
				{
					class164_0.jsonSchema_0.Pattern = JToken.smethod_19(current.Value);
				}
				break;
			case 2609687125u:
				if (key == "requires")
				{
					class164_0.jsonSchema_0.Requires = JToken.smethod_19(current.Value);
				}
				break;
			case 2556802313u:
				if (key == "title")
				{
					class164_0.jsonSchema_0.Title = JToken.smethod_19(current.Value);
				}
				break;
			case 2692244416u:
				if (key == "disallow")
				{
					class164_0.jsonSchema_0.Disallow = Class7.smethod_443(class164_0, current.Value);
				}
				break;
			case 2642794062u:
				if (key == "extends")
				{
					Class7.smethod_618(class164_0, current.Value);
				}
				break;
			case 3114108242u:
				if (key == "format")
				{
					class164_0.jsonSchema_0.Format = JToken.smethod_19(current.Value);
				}
				break;
			case 2957261815u:
				if (key == "minLength")
				{
					class164_0.jsonSchema_0.MinimumLength = Class7.smethod_640(current.Value);
				}
				break;
			case 3522602594u:
				if (key == "uniqueItems")
				{
					class164_0.jsonSchema_0.UniqueItems = Class7.smethod_483(current.Value);
				}
				break;
			case 3456888823u:
				if (key == "readonly")
				{
					class164_0.jsonSchema_0.ReadOnly = Class7.smethod_483(current.Value);
				}
				break;
			case 3947606640u:
				if (key == "patternProperties")
				{
					class164_0.jsonSchema_0.PatternProperties = Class7.smethod_272(current.Value, class164_0);
				}
				break;
			case 3526559937u:
				if (key == "maxLength")
				{
					class164_0.jsonSchema_0.MaximumLength = Class7.smethod_640(current.Value);
				}
				break;
			case 4244322099u:
				if (key == "maxItems")
				{
					class164_0.jsonSchema_0.MaximumItems = Class7.smethod_640(current.Value);
				}
				break;
			case 4128829753u:
				if (key == "hidden")
				{
					class164_0.jsonSchema_0.Hidden = Class7.smethod_483(current.Value);
				}
				break;
			}
		}
	}

	static void smethod_388(Class29 class29_0)
	{
		if (class29_0.struct0_0.bool_0)
		{
			class29_0.struct0_0.int_0++;
		}
	}

	static Class77 smethod_389(Type type_0)
	{
		return EnumUtils.class111_0.method_0(new Struct5<Type, Class115>(type_0, null));
	}

	static IList<int> smethod_390(IList ilist_0, int int_0)
	{
		IList<int> list = new List<int>();
		IList list2 = ilist_0;
		while (true)
		{
			list.Add(list2.Count);
			if (list.Count == int_0 || list2.Count == 0 || !(list2[0] is IList list3))
			{
				break;
			}
			list2 = list3;
		}
		return list;
	}

	static string smethod_391(Type type_0, Interface6? interface6_0)
	{
		if (interface6_0 != null)
		{
			interface6_0!.BindToName(type_0, out var assemblyName, out var typeName);
			return typeName + ((assemblyName == null) ? "" : (", " + assemblyName));
		}
		return type_0.AssemblyQualifiedName;
	}

	static double? smethod_392(Class29 class29_0, string string_0)
	{
		if (Class109.smethod_0(string_0))
		{
			Class7.smethod_211(class29_0, JsonToken.Null, (object)null, bool_0: false);
			return null;
		}
		if (!double.TryParse(string_0, NumberStyles.Float | NumberStyles.AllowThousands, class29_0.Culture, out var result))
		{
			Class7.smethod_211(class29_0, JsonToken.String, (object)string_0, bool_0: false);
			throw Class7.smethod_555(class29_0, "Could not convert string to double: {0}.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		Class7.smethod_211(class29_0, JsonToken.Float, (object)result, bool_0: false);
		return result;
	}

	static List<MemberInfo> smethod_393(BindingFlags bindingFlags_0, Type type_0)
	{
		List<MemberInfo> list = new List<MemberInfo>();
		list.AddRange(Class7.smethod_509(type_0, bindingFlags_0));
		list.AddRange(Class7.smethod_212(bindingFlags_0, type_0));
		List<MemberInfo> list2 = new List<MemberInfo>(list.Count);
		foreach (IGrouping<string, MemberInfo> item in from memberInfo_0 in list
			group memberInfo_0 by memberInfo_0.Name)
		{
			if (item.Count() == 1)
			{
				list2.Add(item.First());
				continue;
			}
			List<MemberInfo> list3 = new List<MemberInfo>();
			using (IEnumerator<MemberInfo> enumerator2 = item.GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					ReflectionUtils.Class104 CS_0024_003C_003E8__locals0 = new ReflectionUtils.Class104();
					CS_0024_003C_003E8__locals0.memberInfo_0 = enumerator2.Current;
					if (list3.Count == 0)
					{
						list3.Add(CS_0024_003C_003E8__locals0.memberInfo_0);
					}
					else if ((!Class7.smethod_25(CS_0024_003C_003E8__locals0.memberInfo_0, bindingFlags_0) || CS_0024_003C_003E8__locals0.memberInfo_0.Name == "Item") && !list3.Any((MemberInfo memberInfo_1) => memberInfo_1.DeclaringType == CS_0024_003C_003E8__locals0.memberInfo_0.DeclaringType))
					{
						list3.Add(CS_0024_003C_003E8__locals0.memberInfo_0);
					}
				}
			}
			list2.AddRange(list3);
		}
		return list2;
	}

	static JsonSchemaModel smethod_394(JsonSchema jsonSchema_0, Class170 class170_0)
	{
		class170_0.class171_0 = new Class171();
		class170_0.jsonSchemaNode_0 = Class7.smethod_503((JsonSchemaNode)null, class170_0, jsonSchema_0);
		class170_0.dictionary_0 = new Dictionary<JsonSchemaNode, JsonSchemaModel>();
		return class170_0.method_0(class170_0.jsonSchemaNode_0);
	}

	static string smethod_395(string string_0, Class6 class6_0, int int_0)
	{
		int num = int_0 & class6_0.int_2;
		Class6.Class4 @class = new Class6.Class4(string_0, int_0, class6_0.class4_0[num]);
		class6_0.class4_0[num] = @class;
		if (class6_0.int_1++ == class6_0.int_2)
		{
			Class7.smethod_50(class6_0);
		}
		return @class.string_0;
	}

	static void smethod_396(Class164 class164_0, JToken jtoken_0)
	{
		if (jtoken_0.Type == JTokenType.Boolean)
		{
			class164_0.jsonSchema_0.AllowAdditionalProperties = Class7.smethod_483(jtoken_0);
		}
		else
		{
			class164_0.jsonSchema_0.AdditionalProperties = Class7.smethod_617(class164_0, jtoken_0);
		}
	}

	static bool smethod_397(JsonToken jsonToken_0)
	{
		if ((uint)(jsonToken_0 - 7) > 5u && (uint)(jsonToken_0 - 16) > 1u)
		{
			return false;
		}
		return true;
	}

	static void smethod_398(object object_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, string string_0, Class29 class29_0)
	{
		try
		{
			if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
			{
				jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(class29_0 as Interface1, class29_0.Path, "Read object reference Id '{0}' for {1}.".smethod_2(CultureInfo.InvariantCulture, string_0, object_0.GetType())), null);
			}
			Class7.smethod_639(jsonSerializerInternalReader_0.class34_0).imethod_3(jsonSerializerInternalReader_0, string_0, object_0);
		}
		catch (Exception exception_)
		{
			throw Class7.smethod_383("Error reading object reference '{0}'.".smethod_1(CultureInfo.InvariantCulture, string_0), exception_, class29_0);
		}
	}

	static bool smethod_399(ref Type type_0, Type type_1, [Out] Type? type_2)
	{
		Class113.smethod_0(type_2, "type");
		Class113.smethod_0(type_1, "genericClassDefinition");
		if (!type_1.smethod_9() || !type_1.smethod_5())
		{
			throw new ArgumentNullException("'{0}' is not a generic class definition.".smethod_1(CultureInfo.InvariantCulture, type_1));
		}
		return Class7.smethod_21(type_2, type_1, out type_0);
	}

	static JsonSchemaType smethod_400(string string_0)
	{
		if (!Class166.idictionary_0.TryGetValue(string_0, out var value))
		{
			throw new JsonException("Invalid JSON schema type: {0}".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		return value;
	}

	static bool smethod_401(object object_0)
	{
		return ReflectionUtils.smethod_5<NonSerializedAttribute>(object_0, bool_0: false) != null;
	}

	static void smethod_402(JToken jtoken_0, int int_0, int int_1)
	{
		Class7.smethod_106((object)new JToken.Class181(int_0, int_1), jtoken_0);
	}

	static Class48 smethod_403(IConvertible iconvertible_0)
	{
		return Class49.class48_0[(int)iconvertible_0.GetTypeCode()];
	}

	static void smethod_404(Assembly assembly_0)
	{
		if (FSharpUtils.fsharpUtils_0 != null)
		{
			return;
		}
		lock (FSharpUtils.object_0)
		{
			if (FSharpUtils.fsharpUtils_0 == null)
			{
				FSharpUtils.fsharpUtils_0 = new FSharpUtils(assembly_0);
			}
		}
	}

	static JToken smethod_405(TimeSpan? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static void smethod_406(Type type_0)
	{
		if (Class21.class100_0 == null)
		{
			Class21.class100_0 = Class7.smethod_762(type_0, new string[2] { "Key", "Value" });
		}
	}

	static bool smethod_407(Class29 class29_0)
	{
		JsonToken tokenType = class29_0.TokenType;
		while (true)
		{
			if (tokenType == JsonToken.None || tokenType == JsonToken.Comment)
			{
				if (!class29_0.vmethod_0())
				{
					break;
				}
				tokenType = class29_0.TokenType;
				continue;
			}
			return true;
		}
		return false;
	}

	static List<JsonSerializerInternalReader.Class154> smethod_408(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class143? class143_0, JsonProperty jsonProperty_0, Class29 class29_0, Type type_0)
	{
		List<JsonSerializerInternalReader.Class154> list = new List<JsonSerializerInternalReader.Class154>();
		bool flag = false;
		do
		{
			JsonToken tokenType = class29_0.TokenType;
			if (tokenType == JsonToken.PropertyName)
			{
				string text = class29_0.Value!.ToString();
				JsonSerializerInternalReader.Class154 @class = new JsonSerializerInternalReader.Class154(text)
				{
					jsonProperty_1 = Class7.smethod_616(class143_0!.CreatorParameters, text),
					jsonProperty_0 = Class7.smethod_616(class143_0!.Properties, text)
				};
				list.Add(@class);
				JsonProperty jsonProperty = @class.jsonProperty_1 ?? @class.jsonProperty_0;
				if (jsonProperty != null)
				{
					if (!jsonProperty.Ignored)
					{
						if (jsonProperty.PropertyContract == null)
						{
							jsonProperty.PropertyContract = jsonSerializerInternalReader_0.method_1(jsonProperty.type_0);
						}
						Class9 class2 = jsonSerializerInternalReader_0.method_5(jsonProperty.PropertyContract, jsonProperty.Converter, class143_0, jsonProperty_0);
						if (Class7.smethod_440(class29_0, jsonProperty.PropertyContract, class2 != null))
						{
							if (class2 != null && class2.CanRead)
							{
								@class.object_0 = Class7.smethod_716(jsonSerializerInternalReader_0, class2, class29_0, jsonProperty.type_0, (object)null);
							}
							else
							{
								@class.object_0 = jsonSerializerInternalReader_0.method_4(class29_0, jsonProperty.type_0, jsonProperty.PropertyContract, jsonProperty, class143_0, jsonProperty_0, null);
							}
							continue;
						}
						throw Class7.smethod_161(class29_0, "Unexpected end when setting {0}'s value.".smethod_1(CultureInfo.InvariantCulture, text));
					}
				}
				else
				{
					if (!class29_0.vmethod_0())
					{
						throw Class7.smethod_161(class29_0, "Unexpected end when setting {0}'s value.".smethod_1(CultureInfo.InvariantCulture, text));
					}
					if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
					{
						jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(class29_0 as Interface1, class29_0.Path, "Could not find member '{0}' on {1}.".smethod_2(CultureInfo.InvariantCulture, text, class143_0!.UnderlyingType)), null);
					}
					if ((class143_0!.MissingMemberHandling ?? jsonSerializerInternalReader_0.class34_0.enum11_0) == Enum11.const_1)
					{
						throw Class7.smethod_161(class29_0, "Could not find member '{0}' on object of type '{1}'".smethod_2(CultureInfo.InvariantCulture, text, type_0.Name));
					}
				}
				if (class143_0!.ExtensionDataSetter != null)
				{
					@class.object_0 = Class7.smethod_688(jsonProperty_0, class29_0, class143_0, jsonSerializerInternalReader_0);
				}
				else
				{
					Class7.smethod_310(class29_0);
				}
			}
			else if (tokenType != JsonToken.Comment)
			{
				if (tokenType != JsonToken.EndObject)
				{
					throw Class7.smethod_161(class29_0, "Unexpected token when deserializing object: " + class29_0.TokenType);
				}
				flag = true;
			}
		}
		while (!flag && class29_0.vmethod_0());
		if (!flag)
		{
			Class7.smethod_574((object)null, class29_0, "Unexpected end when deserializing object.", jsonSerializerInternalReader_0, (Class137)class143_0);
		}
		return list;
	}

	static string smethod_409(bool bool_0, Enum7 enum7_0, XmlNode xmlNode_0)
	{
		Class27 @class = new Class27
		{
			OmitRootObject = bool_0
		};
		return Class8.smethod_19(xmlNode_0, enum7_0, @class);
	}

	static TimeSpan smethod_410(string string_0)
	{
		return TimeSpan.Parse(string_0, CultureInfo.InvariantCulture);
	}

	static JProperty smethod_411(Class29 class29_0, Class193? class193_0)
	{
		if (class29_0.TokenType == JsonToken.None && !class29_0.vmethod_0())
		{
			throw Class7.smethod_555(class29_0, "Error reading JProperty from JsonReader.");
		}
		Class7.smethod_407(class29_0);
		if (class29_0.TokenType != JsonToken.PropertyName)
		{
			throw Class7.smethod_555(class29_0, "Error reading JProperty from JsonReader. Current JsonReader item is not a property: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		}
		JProperty jProperty = new JProperty((string)class29_0.Value);
		jProperty.method_5(class29_0 as Interface1, class193_0);
		Class7.smethod_644((Class176)jProperty, class29_0, class193_0);
		return jProperty;
	}

	static void smethod_412()
	{
		if (!Class72.Class73.bool_0)
		{
			if (Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: false) == null)
			{
				throw new InvalidOperationException("Could not resolve type '{0}'. You may need to add a reference to Microsoft.CSharp.dll to work with dynamic types.".smethod_1(CultureInfo.InvariantCulture, "Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"));
			}
			Class72.Class73.object_0 = Class7.smethod_150(new int[1]);
			Class72.Class73.object_1 = Class7.smethod_150(new int[2] { 0, 3 });
			Class7.smethod_415();
			Class72.Class73.bool_0 = true;
		}
	}

	static Class49.Enum23 smethod_413(ref object? object_0, object object_1, CultureInfo cultureInfo_0, [Out] Type? type_0)
	{
		if (object_1 == null)
		{
			throw new ArgumentNullException("initialValue");
		}
		if (Class7.smethod_157(type_0))
		{
			type_0 = Nullable.GetUnderlyingType(type_0);
		}
		Type type = object_1.GetType();
		if (type_0 == type)
		{
			object_0 = object_1;
			return Class49.Enum23.const_0;
		}
		if (Class7.smethod_10(object_1.GetType()) && Class7.smethod_10(type_0))
		{
			if (type_0.smethod_8())
			{
				if (object_1 is string)
				{
					object_0 = Enum.Parse(type_0, object_1.ToString(), ignoreCase: true);
					return Class49.Enum23.const_0;
				}
				if (Class7.smethod_629(object_1))
				{
					object_0 = Enum.ToObject(type_0, object_1);
					return Class49.Enum23.const_0;
				}
			}
			object_0 = Convert.ChangeType(object_1, type_0, cultureInfo_0);
			return Class49.Enum23.const_0;
		}
		if (object_1 is DateTime dateTime && type_0 == typeof(DateTimeOffset))
		{
			object_0 = new DateTimeOffset(dateTime);
			return Class49.Enum23.const_0;
		}
		if (object_1 is byte[] b && type_0 == typeof(Guid))
		{
			object_0 = new Guid(b);
			return Class49.Enum23.const_0;
		}
		if (object_1 is Guid guid && type_0 == typeof(byte[]))
		{
			object_0 = guid.ToByteArray();
			return Class49.Enum23.const_0;
		}
		if (object_1 is string text)
		{
			if (type_0 == typeof(Guid))
			{
				object_0 = new Guid(text);
				return Class49.Enum23.const_0;
			}
			if (type_0 == typeof(Uri))
			{
				object_0 = new Uri(text, UriKind.RelativeOrAbsolute);
				return Class49.Enum23.const_0;
			}
			if (type_0 == typeof(TimeSpan))
			{
				object_0 = Class7.smethod_410(text);
				return Class49.Enum23.const_0;
			}
			if (type_0 == typeof(byte[]))
			{
				object_0 = Convert.FromBase64String(text);
				return Class49.Enum23.const_0;
			}
			if (type_0 == typeof(Version))
			{
				Version version_ = default(Version);
				if (Class7.smethod_658(ref version_, text))
				{
					object_0 = version_;
					return Class49.Enum23.const_0;
				}
				object_0 = null;
				return Class49.Enum23.const_3;
			}
			if (typeof(Type).IsAssignableFrom(type_0))
			{
				object_0 = Type.GetType(text, throwOnError: true);
				return Class49.Enum23.const_0;
			}
		}
		if (type_0 == typeof(BigInteger))
		{
			object_0 = Class7.smethod_442(object_1);
			return Class49.Enum23.const_0;
		}
		if (object_1 is BigInteger bigInteger_)
		{
			object_0 = Class7.smethod_254(bigInteger_, type_0);
			return Class49.Enum23.const_0;
		}
		TypeConverter converter = TypeDescriptor.GetConverter(type);
		if (converter != null && converter.CanConvertTo(type_0))
		{
			object_0 = converter.ConvertTo(null, cultureInfo_0, object_1, type_0);
			return Class49.Enum23.const_0;
		}
		TypeConverter converter2 = TypeDescriptor.GetConverter(type_0);
		if (converter2 != null && converter2.CanConvertFrom(type))
		{
			object_0 = converter2.ConvertFrom(null, cultureInfo_0, object_1);
			return Class49.Enum23.const_0;
		}
		if (object_1 == DBNull.Value)
		{
			if (Class7.smethod_213(type_0))
			{
				object_0 = Class7.smethod_516((object?)null, type, type_0);
				return Class49.Enum23.const_0;
			}
			object_0 = null;
			return Class49.Enum23.const_1;
		}
		if (!type_0.smethod_3() && !type_0.smethod_5() && !type_0.smethod_11())
		{
			object_0 = null;
			return Class49.Enum23.const_3;
		}
		object_0 = null;
		return Class49.Enum23.const_2;
	}

	static JToken smethod_414(bool bool_0)
	{
		return new Class179(bool_0);
	}

	static void smethod_415()
	{
		Type type = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
		Type type2 = Type.GetType("Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
		Type type3 = Type.GetType("Microsoft.CSharp.RuntimeBinder.Binder, Microsoft.CSharp, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", throwOnError: true);
		Type type4 = typeof(IEnumerable<>).MakeGenericType(type);
		MethodInfo method = type3.GetMethod("GetMember", new Type[4]
		{
			type2,
			typeof(string),
			typeof(Type),
			type4
		});
		Class72.Class73.delegate1_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(method);
		MethodInfo method2 = type3.GetMethod("SetMember", new Type[4]
		{
			type2,
			typeof(string),
			typeof(Type),
			type4
		});
		Class72.Class73.delegate1_1 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(method2);
	}

	static int smethod_416(char[] char_0, int int_0, DateTime dateTime_0)
	{
		int num = 19;
		int int_ = default(int);
		Class7.smethod_204(ref int_, out int int_2, dateTime_0, out int int_3);
		Class7.smethod_448(int_3, char_0, int_0, 4);
		char_0[int_0 + 4] = '-';
		Class7.smethod_448(int_, char_0, int_0 + 5, 2);
		char_0[int_0 + 7] = '-';
		Class7.smethod_448(int_2, char_0, int_0 + 8, 2);
		char_0[int_0 + 10] = 'T';
		Class7.smethod_448(dateTime_0.Hour, char_0, int_0 + 11, 2);
		char_0[int_0 + 13] = ':';
		Class7.smethod_448(dateTime_0.Minute, char_0, int_0 + 14, 2);
		char_0[int_0 + 16] = ':';
		Class7.smethod_448(dateTime_0.Second, char_0, int_0 + 17, 2);
		int num2 = (int)(dateTime_0.Ticks % 10000000L);
		if (num2 != 0)
		{
			int num3 = 7;
			while (num2 % 10 == 0)
			{
				num3--;
				num2 /= 10;
			}
			char_0[int_0 + 19] = '.';
			Class7.smethod_448(num2, char_0, int_0 + 20, num3);
			num += num3 + 1;
		}
		return int_0 + num;
	}

	static void smethod_417(Class33 class33_0, BsonType bsonType_0)
	{
		switch (bsonType_0)
		{
		default:
			throw new ArgumentOutOfRangeException("type", "Unexpected BsonType value: " + bsonType_0);
		case BsonType.Number:
		{
			double num = Class7.smethod_459(class33_0);
			if (class33_0.enum6_0 == Enum6.const_1)
			{
				Class7.smethod_186((Class29)class33_0, JsonToken.Float, (object)Convert.ToDecimal(num, CultureInfo.InvariantCulture));
			}
			else
			{
				Class7.smethod_186((Class29)class33_0, JsonToken.Float, (object)num);
			}
			break;
		}
		case BsonType.Object:
		{
			Class7.smethod_386((Class29)class33_0, JsonToken.StartObject);
			Class33.Class241 class2 = new Class33.Class241(BsonType.Object);
			Class7.smethod_170(class33_0, class2);
			class2.int_0 = Class7.smethod_532(class33_0);
			break;
		}
		case BsonType.Array:
		{
			Class7.smethod_386((Class29)class33_0, JsonToken.StartArray);
			Class33.Class241 @class = new Class33.Class241(BsonType.Array);
			Class7.smethod_170(class33_0, @class);
			@class.int_0 = Class7.smethod_532(class33_0);
			break;
		}
		case BsonType.Binary:
		{
			Enum34 enum34_ = default(Enum34);
			byte[] array = Class7.smethod_278(class33_0, ref enum34_);
			object object_3 = ((enum34_ != Enum34.const_4) ? array : ((object)new Guid(array)));
			Class7.smethod_186((Class29)class33_0, JsonToken.Bytes, object_3);
			break;
		}
		case BsonType.Undefined:
			Class7.smethod_386((Class29)class33_0, JsonToken.Undefined);
			break;
		case BsonType.Oid:
		{
			byte[] object_2 = Class7.smethod_760(class33_0, 12);
			Class7.smethod_186((Class29)class33_0, JsonToken.Bytes, (object)object_2);
			break;
		}
		case BsonType.Boolean:
		{
			bool flag = Convert.ToBoolean(Class7.smethod_136(class33_0));
			Class7.smethod_186((Class29)class33_0, JsonToken.Boolean, (object)flag);
			break;
		}
		case BsonType.Date:
		{
			DateTime dateTime = new DateTime(Class7.smethod_349(class33_0) * 10000L + Class51.long_0, DateTimeKind.Utc);
			Class7.smethod_186((Class29)class33_0, JsonToken.Date, (object)(class33_0.dateTimeKind_0 switch
			{
				DateTimeKind.Local => dateTime.ToLocalTime(), 
				DateTimeKind.Unspecified => DateTime.SpecifyKind(dateTime, DateTimeKind.Unspecified), 
				_ => dateTime, 
			}));
			break;
		}
		case BsonType.Null:
			Class7.smethod_386((Class29)class33_0, JsonToken.Null);
			break;
		case BsonType.Regex:
		{
			string text = Class7.smethod_23(class33_0);
			string text2 = Class7.smethod_23(class33_0);
			string object_ = "/" + text + "/" + text2;
			Class7.smethod_186((Class29)class33_0, JsonToken.String, (object)object_);
			break;
		}
		case BsonType.Reference:
			Class7.smethod_386((Class29)class33_0, JsonToken.StartObject);
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.ReferenceStart;
			break;
		case BsonType.Code:
			Class7.smethod_186((Class29)class33_0, JsonToken.String, (object)Class7.smethod_75(class33_0));
			break;
		case BsonType.String:
		case BsonType.Symbol:
			Class7.smethod_186((Class29)class33_0, JsonToken.String, (object)Class7.smethod_75(class33_0));
			break;
		case BsonType.CodeWScope:
			Class7.smethod_386((Class29)class33_0, JsonToken.StartObject);
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.CodeWScopeStart;
			break;
		case BsonType.Integer:
			Class7.smethod_186((Class29)class33_0, JsonToken.Integer, (object)(long)Class7.smethod_532(class33_0));
			break;
		case BsonType.TimeStamp:
		case BsonType.Long:
			Class7.smethod_186((Class29)class33_0, JsonToken.Integer, (object)Class7.smethod_349(class33_0));
			break;
		}
	}

	static int smethod_418(bool bool_0, Class30 class30_0)
	{
		return Class7.smethod_249(class30_0, bool_0, 0);
	}

	static string smethod_419(Enum3 enum3_0, Enum1 enum1_0, DateTime dateTime_0)
	{
		DateTime dateTime_ = Class7.smethod_517(dateTime_0, enum3_0);
		using StringWriter stringWriter = Class7.smethod_470(64);
		stringWriter.Write('"');
		Class51.smethod_1(stringWriter, dateTime_, enum1_0, null, CultureInfo.InvariantCulture);
		stringWriter.Write('"');
		return stringWriter.ToString();
	}

	static bool smethod_420(IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, ref object object_0, [Out] Class141? class141_0, string string_0)
	{
		Class113.smethod_0(idynamicMetaObjectProvider_0, "dynamicProvider");
		CallSite<Func<CallSite, object, object>> callSite = class141_0!.class111_0.method_0(string_0);
		object obj = callSite.Target(callSite, idynamicMetaObjectProvider_0);
		if (obj != Class76.object_0)
		{
			object_0 = obj;
			return true;
		}
		object_0 = null;
		return false;
	}

	static bool smethod_421(Class30 class30_0)
	{
		while (true)
		{
			char c = class30_0.char_2[class30_0.int_3];
			switch (c)
			{
			default:
				if (char.IsWhiteSpace(c))
				{
					class30_0.int_3++;
					break;
				}
				if (!char.IsNumber(c) && c != '-' && c != '.')
				{
					throw Class7.smethod_423(class30_0, c);
				}
				Class7.smethod_737(class30_0, Enum8.const_0);
				return true;
			case '\t':
			case ' ':
				class30_0.int_3++;
				break;
			case '\n':
				Class7.smethod_630(class30_0);
				break;
			case '\r':
				Class7.smethod_287(class30_0, bool_0: false);
				break;
			case '\0':
				if (class30_0.int_2 == class30_0.int_3)
				{
					if (Class7.smethod_418(bool_0: false, class30_0) == 0)
					{
						return false;
					}
				}
				else
				{
					class30_0.int_3++;
				}
				break;
			case ')':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.EndConstructor);
				return true;
			case ',':
				Class7.smethod_386((Class29)class30_0, JsonToken.Undefined);
				return true;
			case '-':
				if (Class7.smethod_260(class30_0, 1, bool_0: true) && class30_0.char_2[class30_0.int_3 + 1] == 'I')
				{
					Class7.smethod_371(Enum8.const_0, class30_0);
				}
				else
				{
					Class7.smethod_737(class30_0, Enum8.const_0);
				}
				return true;
			case '/':
				Class7.smethod_80(class30_0, bool_0: true);
				return true;
			case '"':
			case '\'':
				Class7.smethod_679(class30_0, c, Enum8.const_0);
				return true;
			case 'N':
				Class7.smethod_592(class30_0, Enum8.const_0);
				return true;
			case 'I':
				Class7.smethod_446(class30_0, Enum8.const_0);
				return true;
			case 'f':
				Class7.smethod_120(class30_0);
				return true;
			case ']':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.EndArray);
				return true;
			case '[':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.StartArray);
				return true;
			case 't':
				Class7.smethod_523(class30_0);
				return true;
			case 'n':
				if (Class7.smethod_260(class30_0, 1, bool_0: true))
				{
					char c2 = class30_0.char_2[class30_0.int_3 + 1];
					if (c2 == 'u')
					{
						Class7.smethod_537(class30_0);
					}
					else
					{
						if (c2 != 'e')
						{
							throw Class7.smethod_423(class30_0, class30_0.char_2[class30_0.int_3]);
						}
						Class7.smethod_422(class30_0);
					}
					return true;
				}
				class30_0.int_3++;
				throw class30_0.method_2();
			case '{':
				class30_0.int_3++;
				Class7.smethod_386((Class29)class30_0, JsonToken.StartObject);
				return true;
			case 'u':
				Class7.smethod_174(class30_0);
				return true;
			}
		}
	}

	static void smethod_422(Class30 class30_0)
	{
		if (Class7.smethod_346("new", class30_0))
		{
			Class7.smethod_437(class30_0);
			int int_ = class30_0.int_3;
			int int_2;
			while (true)
			{
				char c = class30_0.char_2[class30_0.int_3];
				if (c != 0)
				{
					if (!char.IsLetterOrDigit(c))
					{
						switch (c)
						{
						case '\r':
							int_2 = class30_0.int_3;
							Class7.smethod_287(class30_0, bool_0: true);
							break;
						case '\n':
							int_2 = class30_0.int_3;
							Class7.smethod_630(class30_0);
							break;
						default:
							if (char.IsWhiteSpace(c))
							{
								int_2 = class30_0.int_3;
								class30_0.int_3++;
								break;
							}
							if (c == '(')
							{
								int_2 = class30_0.int_3;
								break;
							}
							throw Class7.smethod_555((Class29)class30_0, "Unexpected character while parsing constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, c));
						}
						break;
					}
					class30_0.int_3++;
				}
				else
				{
					if (class30_0.int_2 != class30_0.int_3)
					{
						int_2 = class30_0.int_3;
						class30_0.int_3++;
						break;
					}
					if (Class7.smethod_418(bool_0: true, class30_0) == 0)
					{
						throw Class7.smethod_555((Class29)class30_0, "Unexpected end while parsing constructor.");
					}
				}
			}
			class30_0.struct4_0 = new Struct4(class30_0.char_2, int_, int_2 - int_);
			string object_ = class30_0.struct4_0.ToString();
			Class7.smethod_437(class30_0);
			if (class30_0.char_2[class30_0.int_3] != '(')
			{
				throw Class7.smethod_555((Class29)class30_0, "Unexpected character while parsing constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class30_0.char_2[class30_0.int_3]));
			}
			class30_0.int_3++;
			Class7.smethod_527(class30_0);
			Class7.smethod_186((Class29)class30_0, JsonToken.StartConstructor, (object)object_);
			return;
		}
		throw Class7.smethod_555((Class29)class30_0, "Unexpected content while parsing JSON.");
	}

	static JsonReaderException smethod_423(Class30 class30_0, char char_0)
	{
		return Class7.smethod_555((Class29)class30_0, "Unexpected character encountered while parsing value: {0}.".smethod_1(CultureInfo.InvariantCulture, char_0));
	}

	static void smethod_424(Class207.Class219 class219_0)
	{
		class219_0.int_0 = -1;
		if (class219_0.ienumerator_0 != null)
		{
			class219_0.ienumerator_0.Dispose();
		}
	}

	static Enum21 smethod_425(ref bool bool_0, [Out] Type type_0)
	{
		if (Class49.dictionary_0.TryGetValue(type_0, out var value))
		{
			bool_0 = false;
			return value;
		}
		if (type_0.smethod_8())
		{
			bool_0 = true;
			return Class7.smethod_524(Enum.GetUnderlyingType(type_0));
		}
		if (Class7.smethod_157(type_0))
		{
			Type underlyingType = Nullable.GetUnderlyingType(type_0);
			if (underlyingType.smethod_8())
			{
				Type type_ = typeof(Nullable<>).MakeGenericType(Enum.GetUnderlyingType(underlyingType));
				bool_0 = true;
				return Class7.smethod_524(type_);
			}
		}
		bool_0 = false;
		return Enum21.const_1;
	}

	static void smethod_426(Class203.Class216 class216_0)
	{
		class216_0.int_0 = -1;
		if (class216_0.ienumerator_0 != null)
		{
			class216_0.ienumerator_0.Dispose();
		}
	}

	static void smethod_427(Class199.Class197 class197_0)
	{
		class197_0.int_0 = -1;
		if (class197_0.ienumerator_0 != null)
		{
			class197_0.ienumerator_0.Dispose();
		}
	}

	static void smethod_428(Class30 class30_0)
	{
		if (Class7.smethod_260(class30_0, 0, bool_0: false))
		{
			Class7.smethod_437(class30_0);
			if (class30_0.bool_3)
			{
				return;
			}
			if (class30_0.char_2[class30_0.int_3] != '/')
			{
				throw Class7.smethod_555((Class29)class30_0, "Additional text encountered after finished reading JSON content: {0}.".smethod_1(CultureInfo.InvariantCulture, class30_0.char_2[class30_0.int_3]));
			}
			Class7.smethod_80(class30_0, bool_0: false);
		}
		Class7.smethod_386((Class29)class30_0, JsonToken.None);
	}

	static Class167.Class168 smethod_429(Class167 class167_0)
	{
		Class167.Class168 result = class167_0.ilist_0[class167_0.ilist_0.Count - 1];
		class167_0.ilist_0.RemoveAt(class167_0.ilist_0.Count - 1);
		Class167.Class168 @class = class167_0.ilist_0.LastOrDefault();
		if (@class != null)
		{
			class167_0.jsonSchema_0 = @class.Schema;
			return result;
		}
		class167_0.jsonSchema_0 = null;
		return result;
	}

	static bool smethod_430(Type type_0)
	{
		if (!typeof(IConvertible).IsAssignableFrom(type_0) && (!Class7.smethod_157(type_0) || !typeof(IConvertible).IsAssignableFrom(Nullable.GetUnderlyingType(type_0))))
		{
			return false;
		}
		return !typeof(JToken).IsAssignableFrom(type_0);
	}

	static JToken smethod_431(int int_0)
	{
		return new Class179(int_0);
	}

	static JsonSchema smethod_432(string string_0, Class172 class172_0)
	{
		Class113.smethod_0(string_0, "json");
		using Class29 class29_ = new Class30(new StringReader(string_0));
		return Class7.smethod_148(class172_0, class29_);
	}

	static void smethod_433(Class43 class43_0)
	{
		if (class43_0.int_2 > 0)
		{
			int int_ = Convert.ToBase64CharArray(class43_0.byte_0, 0, class43_0.int_2, class43_0.char_0, 0);
			Class7.smethod_173(0, int_, class43_0.char_0, class43_0);
			class43_0.int_2 = 0;
		}
	}

	static bool smethod_434(Type type_0)
	{
		if (!type_0.smethod_13())
		{
			return false;
		}
		Attribute[] array = Class7.smethod_714((object)type_0, (Type?)null, bool_0: false);
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (string.Equals(array[num].GetType().FullName, "System.Runtime.CompilerServices.IsByRefLikeAttribute", StringComparison.Ordinal))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	static bool smethod_435(ref Delegate7<object> delegate7_0, Type type_0, [Attribute1(true)] out Type? type_1, [Out][Attribute1(true)] Type? type_2)
	{
		if (type_2.smethod_4())
		{
			ImmutableCollectionsUtils.Class85 CS_0024_003C_003E8__locals0 = new ImmutableCollectionsUtils.Class85();
			Type genericTypeDefinition = type_2!.GetGenericTypeDefinition();
			CS_0024_003C_003E8__locals0.string_0 = genericTypeDefinition.FullName;
			ImmutableCollectionsUtils.Class84 @class = ImmutableCollectionsUtils.ilist_0.FirstOrDefault((ImmutableCollectionsUtils.Class84 class84_0) => class84_0.ContractTypeName == CS_0024_003C_003E8__locals0.string_0);
			if (@class != null)
			{
				Type type = genericTypeDefinition.smethod_7().GetType(@class.CreatedTypeName);
				Type type2 = genericTypeDefinition.smethod_7().GetType(@class.BuilderTypeName);
				if (type != null && type2 != null)
				{
					MethodInfo methodInfo = type2.GetMethods().FirstOrDefault((MethodInfo methodInfo_0) => methodInfo_0.Name == "CreateRange" && methodInfo_0.GetParameters().Length == 1);
					if (methodInfo != null)
					{
						type_1 = type.MakeGenericType(type_0);
						MethodInfo methodBase_ = methodInfo.MakeGenericMethod(type_0);
						delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(methodBase_);
						return true;
					}
				}
			}
		}
		type_1 = null;
		delegate7_0 = null;
		return false;
	}

	static DateTime smethod_436(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_8))
		{
			if (@class.Value is DateTimeOffset dateTimeOffset)
			{
				return dateTimeOffset.DateTime;
			}
			return Convert.ToDateTime(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to DateTime.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static void smethod_437(Class30 class30_0)
	{
		while (true)
		{
			char c = class30_0.char_2[class30_0.int_3];
			if (c == '\0')
			{
				if (class30_0.int_2 == class30_0.int_3)
				{
					if (Class7.smethod_418(bool_0: false, class30_0) == 0)
					{
						break;
					}
				}
				else
				{
					class30_0.int_3++;
				}
			}
			else if (c != '\n')
			{
				if (c != '\r')
				{
					if (c != ' ' && !char.IsWhiteSpace(c))
					{
						break;
					}
					class30_0.int_3++;
				}
				else
				{
					Class7.smethod_287(class30_0, bool_0: false);
				}
			}
			else
			{
				Class7.smethod_630(class30_0);
			}
		}
	}

	static Class35 smethod_438(Class152 class152_0)
	{
		if (class152_0.class35_0 == null)
		{
			class152_0.class35_0 = new Class35(class152_0);
		}
		return class152_0.class35_0;
	}

	static bool smethod_439(string string_0, string? string_1, CultureInfo cultureInfo_0, out DateTimeOffset dateTimeOffset_0)
	{
		if (string_0.Length > 0)
		{
			if (string_0[0] == '/')
			{
				if (string_0.Length >= 9 && string_0.StartsWith("/Date(", StringComparison.Ordinal) && string_0.EndsWith(")/", StringComparison.Ordinal) && Class7.smethod_682(new Struct4(string_0.ToCharArray(), 0, string_0.Length), out dateTimeOffset_0))
				{
					return true;
				}
			}
			else if (string_0.Length >= 19 && string_0.Length <= 40 && char.IsDigit(string_0[0]) && string_0[10] == 'T' && DateTimeOffset.TryParseExact(string_0, "yyyy-MM-ddTHH:mm:ss.FFFFFFFK", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind, out dateTimeOffset_0) && Class7.smethod_460(new Struct4(string_0.ToCharArray(), 0, string_0.Length), out dateTimeOffset_0))
			{
				return true;
			}
			if (!Class109.smethod_0(string_1) && Class7.smethod_324(cultureInfo_0, string_0, ref dateTimeOffset_0, string_1))
			{
				return true;
			}
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	static bool smethod_440(Class29 class29_0, Class137 class137_0, bool bool_0)
	{
		if (bool_0)
		{
			return class29_0.vmethod_0();
		}
		if (class137_0 != null)
		{
			CultureInfo invariantCulture;
			object obj;
			switch (class137_0.enum8_0)
			{
			default:
				throw new ArgumentOutOfRangeException();
			case Enum8.const_0:
				break;
			case Enum8.const_1:
				class29_0.vmethod_1();
				goto IL_00d6;
			case Enum8.const_2:
			{
				bool result = Class7.smethod_110(class29_0);
				if (class29_0.TokenType == JsonToken.Undefined)
				{
					invariantCulture = CultureInfo.InvariantCulture;
					if (class137_0 == null)
					{
						obj = null;
					}
					else
					{
						obj = class137_0.UnderlyingType;
						if (obj != null)
						{
							goto IL_008d;
						}
					}
					obj = typeof(long);
					goto IL_008d;
				}
				return result;
			}
			case Enum8.const_3:
				class29_0.vmethod_3();
				goto IL_00d6;
			case Enum8.const_4:
				class29_0.vmethod_2();
				goto IL_00d6;
			case Enum8.const_5:
				class29_0.vmethod_6();
				goto IL_00d6;
			case Enum8.const_6:
				class29_0.vmethod_7();
				goto IL_00d6;
			case Enum8.const_7:
				class29_0.vmethod_8();
				goto IL_00d6;
			case Enum8.const_8:
				class29_0.vmethod_4();
				goto IL_00d6;
			case Enum8.const_9:
				{
					class29_0.vmethod_5();
					goto IL_00d6;
				}
				IL_008d:
				throw Class7.smethod_555(class29_0, "An undefined token is not a valid {0}.".smethod_1(invariantCulture, obj));
				IL_00d6:
				return class29_0.TokenType != JsonToken.None;
			}
		}
		return Class7.smethod_110(class29_0);
	}

	static JObject smethod_441(object object_0)
	{
		return (JObject)object_0;
	}

	static BigInteger smethod_442(object object_0)
	{
		if (object_0 is BigInteger)
		{
			return (BigInteger)object_0;
		}
		if (object_0 is string value)
		{
			return BigInteger.Parse(value, CultureInfo.InvariantCulture);
		}
		if (object_0 is float value2)
		{
			return new BigInteger(value2);
		}
		if (object_0 is double value3)
		{
			return new BigInteger(value3);
		}
		if (object_0 is decimal value4)
		{
			return new BigInteger(value4);
		}
		if (object_0 is int value5)
		{
			return new BigInteger(value5);
		}
		if (object_0 is long value6)
		{
			return new BigInteger(value6);
		}
		if (object_0 is uint value7)
		{
			return new BigInteger(value7);
		}
		if (object_0 is ulong value8)
		{
			return new BigInteger(value8);
		}
		if (!(object_0 is byte[] value9))
		{
			throw new InvalidCastException("Cannot convert {0} to BigInteger.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType()));
		}
		return new BigInteger(value9);
	}

	static JsonSchemaType? smethod_443(Class164 class164_0, JToken jtoken_0)
	{
		switch (jtoken_0.Type)
		{
		default:
			throw Class7.smethod_609((Interface1)jtoken_0, jtoken_0.Path, "Expected array or JSON schema type string token, got {0}.".smethod_1(CultureInfo.InvariantCulture, jtoken_0.Type));
		case JTokenType.String:
			return Class7.smethod_400(JToken.smethod_19(jtoken_0));
		case JTokenType.Array:
		{
			JsonSchemaType? jsonSchemaType = JsonSchemaType.None;
			{
				foreach (JToken item in (IEnumerable<JToken>)jtoken_0)
				{
					if (item.Type == JTokenType.String)
					{
						jsonSchemaType |= Class7.smethod_400(JToken.smethod_19(item));
						continue;
					}
					throw Class7.smethod_609((Interface1)item, item.Path, "Expected JSON schema type string token, got {0}.".smethod_1(CultureInfo.InvariantCulture, jtoken_0.Type));
				}
				return jsonSchemaType;
			}
		}
		}
	}

	static object smethod_444(JsonSerializerInternalReader jsonSerializerInternalReader_0, IList ilist_0, Class29 class29_0, Class139? class139_0, JsonProperty? jsonProperty_0, string string_0)
	{
		object obj = ((ilist_0 is Interface2 @interface) ? @interface.UnderlyingCollection : ilist_0);
		if (string_0 != null)
		{
			Class7.smethod_398(obj, jsonSerializerInternalReader_0, string_0, class29_0);
		}
		if (ilist_0.IsFixedSize)
		{
			Class7.smethod_310(class29_0);
			return obj;
		}
		Class7.smethod_208(jsonSerializerInternalReader_0, class29_0, (Class137)class139_0, obj);
		int depth = class29_0.Depth;
		if (class139_0!.class137_0 == null)
		{
			class139_0!.ItemContract = jsonSerializerInternalReader_0.method_1(class139_0!.CollectionItemType);
		}
		Class9 @class = jsonSerializerInternalReader_0.method_5(class139_0!.class137_0, null, class139_0, jsonProperty_0);
		int? num = null;
		bool flag = false;
		do
		{
			try
			{
				if (Class7.smethod_440(class29_0, class139_0!.class137_0, @class != null))
				{
					switch (class29_0.TokenType)
					{
					case JsonToken.EndArray:
						flag = true;
						break;
					default:
					{
						object value = ((@class == null || !@class.CanRead) ? jsonSerializerInternalReader_0.method_4(class29_0, class139_0!.CollectionItemType, class139_0!.class137_0, null, class139_0, jsonProperty_0, null) : Class7.smethod_716(jsonSerializerInternalReader_0, @class, class29_0, class139_0!.CollectionItemType, (object)null));
						ilist_0.Add(value);
						break;
					}
					case JsonToken.Comment:
						break;
					}
					continue;
				}
			}
			catch (Exception exception_)
			{
				Struct0 @struct = Class7.smethod_685(depth, class29_0);
				if (jsonSerializerInternalReader_0.method_0(obj, class139_0, @struct.int_0, class29_0 as Interface1, class29_0.Path, exception_))
				{
					Class7.smethod_53(class29_0, bool_0: true, jsonSerializerInternalReader_0, depth + 1);
					if (num.HasValue && num == @struct.int_0)
					{
						throw Class7.smethod_383("Infinite loop detected from error handling.", exception_, class29_0);
					}
					num = @struct.int_0;
					continue;
				}
				throw;
			}
			break;
		}
		while (!flag);
		if (!flag)
		{
			Class7.smethod_574(obj, class29_0, "Unexpected end when deserializing array.", jsonSerializerInternalReader_0, (Class137)class139_0);
		}
		Class7.smethod_296(jsonSerializerInternalReader_0, class29_0, (Class137)class139_0, obj);
		return obj;
	}

	static string smethod_445(object object_0, Class38 class38_0, Class152 class152_0)
	{
		try
		{
			return Class7.smethod_639(class152_0.class34_0).imethod_1(class152_0, object_0);
		}
		catch (Exception exception_)
		{
			throw Class7.smethod_505((Interface1?)null, class38_0.ContainerPath, "Error writing object reference for '{0}'.".smethod_1(CultureInfo.InvariantCulture, object_0.GetType()), exception_);
		}
	}

	static object smethod_446(Class30 class30_0, Enum8 enum8_0)
	{
		return Class7.smethod_771(Class7.smethod_346(Class8.string_4, class30_0), enum8_0, class30_0);
	}

	static void smethod_447(Class38 class38_0, JsonToken jsonToken_0, object object_0)
	{
		switch (jsonToken_0)
		{
		default:
			throw new ArgumentOutOfRangeException("token");
		case JsonToken.StartObject:
			Class7.smethod_506(class38_0, jsonToken_0, JsonContainerType.Object);
			break;
		case JsonToken.StartArray:
			Class7.smethod_506(class38_0, jsonToken_0, JsonContainerType.Array);
			break;
		case JsonToken.StartConstructor:
			Class7.smethod_506(class38_0, jsonToken_0, JsonContainerType.Constructor);
			break;
		case JsonToken.PropertyName:
			if (!(object_0 is string string_))
			{
				throw new ArgumentException("A name is required when setting property name state.", "value");
			}
			Class7.smethod_591(class38_0, string_);
			break;
		case JsonToken.Comment:
			Class7.smethod_705(class38_0);
			break;
		case JsonToken.Raw:
			Class7.smethod_770(class38_0);
			break;
		case JsonToken.EndObject:
			Class7.smethod_568(class38_0, JsonContainerType.Object);
			break;
		case JsonToken.EndArray:
			Class7.smethod_568(class38_0, JsonContainerType.Array);
			break;
		case JsonToken.EndConstructor:
			Class7.smethod_568(class38_0, JsonContainerType.Constructor);
			break;
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Null:
		case JsonToken.Undefined:
		case JsonToken.Date:
		case JsonToken.Bytes:
			Class7.smethod_325(class38_0, jsonToken_0);
			break;
		}
	}

	static void smethod_448(int int_0, char[] char_0, int int_1, int int_2)
	{
		while (int_2-- != 0)
		{
			char_0[int_1 + int_2] = (char)(int_0 % 10 + 48);
			int_0 /= 10;
		}
	}

	static bool smethod_449(Class33 class33_0)
	{
		switch (class33_0.bsonReaderState_0)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case Class33.BsonReaderState.CodeWScopeStart:
			Class7.smethod_186((Class29)class33_0, JsonToken.PropertyName, (object)"$code");
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.CodeWScopeCode;
			return true;
		case Class33.BsonReaderState.CodeWScopeCode:
			Class7.smethod_532(class33_0);
			Class7.smethod_186((Class29)class33_0, JsonToken.String, (object)Class7.smethod_75(class33_0));
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.CodeWScopeScope;
			return true;
		case Class33.BsonReaderState.CodeWScopeScope:
		{
			if (class33_0.state_0 == Class29.State.PostValue)
			{
				Class7.smethod_186((Class29)class33_0, JsonToken.PropertyName, (object)"$scope");
				return true;
			}
			Class7.smethod_386((Class29)class33_0, JsonToken.StartObject);
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.CodeWScopeScopeObject;
			Class33.Class241 @class = new Class33.Class241(BsonType.Object);
			Class7.smethod_170(class33_0, @class);
			@class.int_0 = Class7.smethod_532(class33_0);
			return true;
		}
		case Class33.BsonReaderState.CodeWScopeScopeObject:
		{
			bool num = Class7.smethod_4(class33_0);
			if (num && class33_0.TokenType == JsonToken.EndObject)
			{
				class33_0.bsonReaderState_0 = Class33.BsonReaderState.CodeWScopeScopeEnd;
			}
			return num;
		}
		case Class33.BsonReaderState.CodeWScopeScopeEnd:
			Class7.smethod_386((Class29)class33_0, JsonToken.EndObject);
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.Normal;
			return true;
		}
	}

	static JObject smethod_450(object object_0)
	{
		return Class7.smethod_567(object_0, Class7.smethod_575());
	}

	static string smethod_451(Enum enum_0)
	{
		return enum_0.ToString("D");
	}

	static void smethod_452(Class33 class33_0, int int_0)
	{
		class33_0.class241_0.int_1 += int_0;
	}

	static bool smethod_453(Class179 class179_0, Class179 class179_1)
	{
		if ((class179_0.Type == JTokenType.Integer && class179_1.Type == JTokenType.Float) || (class179_0.Type == JTokenType.Float && class179_1.Type == JTokenType.Integer))
		{
			return Class179.smethod_37(class179_0.Type, class179_0.Value, class179_1.Value) == 0;
		}
		if (class179_0.Type != class179_1.Type)
		{
			return false;
		}
		return class179_0.System_002EIEquatable_003Cns15_002EClass179_003E_002EEquals(class179_1);
	}

	static bool smethod_454(JToken jtoken_0, JToken? jtoken_1)
	{
		if (jtoken_0 is Class179 @class)
		{
			if (jtoken_1 == null)
			{
				return @class.Type == JTokenType.Null;
			}
			return @class.Equals(jtoken_1);
		}
		return false;
	}

	static int? smethod_455(int? nullable_0, int? nullable_1)
	{
		if (!nullable_0.HasValue)
		{
			return nullable_1;
		}
		if (!nullable_1.HasValue)
		{
			return nullable_0;
		}
		return Math.Min(nullable_0.GetValueOrDefault(), nullable_1.GetValueOrDefault());
	}

	static void smethod_456(Class30 class30_0)
	{
		class30_0.int_3++;
		if (class30_0.state_0 != Class29.State.PostValue)
		{
			Class7.smethod_386((Class29)class30_0, JsonToken.Undefined);
			JsonReaderException ex = Class7.smethod_423(class30_0, ',');
			class30_0.int_3--;
			throw ex;
		}
		Class7.smethod_717((Class29)class30_0);
	}

	static void smethod_457(Class152 class152_0, Class38 class38_0, object object_0, Class146 class146_0)
	{
		Class7.smethod_246(class152_0, class38_0, (Class137)class146_0, object_0);
		Class7.smethod_27(object_0, class146_0.UnderlyingType, out string string_);
		class38_0.vmethod_21(string_);
		Class7.smethod_82(class38_0, class152_0, (Class137)class146_0, object_0);
	}

	static List<Type> smethod_458(Type type_0, DefaultContractResolver defaultContractResolver_0)
	{
		List<Type> list = new List<Type>();
		Type type = type_0;
		while (type != null && type != typeof(object))
		{
			list.Add(type);
			type = type.smethod_6();
		}
		list.Reverse();
		return list;
	}

	static double smethod_459(Class33 class33_0)
	{
		Class7.smethod_452(class33_0, 8);
		return class33_0.binaryReader_0.ReadDouble();
	}

	static bool smethod_460(Struct4 struct4_0, out DateTimeOffset dateTimeOffset_0)
	{
		Struct1 struct1_ = default(Struct1);
		if (!struct1_.method_0(struct4_0.Chars, struct4_0.StartIndex, struct4_0.Length))
		{
			dateTimeOffset_0 = default(DateTimeOffset);
			return false;
		}
		DateTime dateTime = Class7.smethod_569(struct1_);
		TimeSpan offset = struct1_.enum24_0 switch
		{
			Enum24.const_1 => new TimeSpan(0L), 
			Enum24.const_2 => new TimeSpan(-struct1_.int_7, -struct1_.int_8, 0), 
			Enum24.const_3 => new TimeSpan(struct1_.int_7, struct1_.int_8, 0), 
			_ => TimeZoneInfo.Local.GetUtcOffset(dateTime), 
		};
		long num = dateTime.Ticks - offset.Ticks;
		if (num >= 0L && num <= 3155378975999999999L)
		{
			dateTimeOffset_0 = new DateTimeOffset(dateTime, offset);
			return true;
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	static JsonContainerType smethod_461(Class29 class29_0)
	{
		return class29_0.struct0_0.jsonContainerType_0;
	}

	static string? smethod_462(Class29 class29_0)
	{
		switch (class29_0.TokenType)
		{
		case JsonToken.Integer:
			if (class29_0.Value is BigInteger bigInteger)
			{
				return bigInteger.ToString(CultureInfo.InvariantCulture);
			}
			return XmlConvert.ToString(Convert.ToInt64(class29_0.Value, CultureInfo.InvariantCulture));
		case JsonToken.Float:
			if (class29_0.Value is decimal num)
			{
				return XmlConvert.ToString(num);
			}
			if (class29_0.Value is float num2)
			{
				return XmlConvert.ToString(num2);
			}
			return XmlConvert.ToString(Convert.ToDouble(class29_0.Value, CultureInfo.InvariantCulture));
		case JsonToken.String:
			return class29_0.Value?.ToString();
		case JsonToken.Boolean:
			return XmlConvert.ToString(Convert.ToBoolean(class29_0.Value, CultureInfo.InvariantCulture));
		case JsonToken.Null:
			return null;
		default:
			throw Class7.smethod_161(class29_0, "Cannot get an XML string value from token type '{0}'.".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		case JsonToken.Date:
		{
			if (class29_0.Value is DateTimeOffset dateTimeOffset)
			{
				return XmlConvert.ToString(dateTimeOffset);
			}
			DateTime dateTime = Convert.ToDateTime(class29_0.Value, CultureInfo.InvariantCulture);
			return XmlConvert.ToString(dateTime, Class7.smethod_559(dateTime.Kind));
		}
		case JsonToken.Bytes:
			return Convert.ToBase64String((byte[])class29_0.Value);
		}
	}

	static JsonSchema smethod_463(Type type_0, Class172 class172_0, Class167 class167_0)
	{
		return Class7.smethod_121(class172_0, bool_0: false, type_0, class167_0);
	}

	static CallSiteBinder smethod_464(string string_0, Type type_0)
	{
		Class7.smethod_412();
		return (CallSiteBinder)Class72.Class73.delegate1_1!(null, 0, string_0, type_0, Class72.Class73.object_1);
	}

	static JToken smethod_465(long long_0)
	{
		return new Class179(long_0);
	}

	static JsonSchema smethod_466(Class164 class164_0, Class29 class29_0)
	{
		JToken jToken = Class7.smethod_680(class29_0);
		class164_0.jobject_0 = jToken as JObject;
		JsonSchema jsonSchema = Class7.smethod_617(class164_0, jToken);
		class164_0.method_0(jsonSchema);
		return jsonSchema;
	}

	static Class137 smethod_467(Class152 class152_0, object object_0)
	{
		return class152_0.class34_0.interface4_0.imethod_0(object_0.GetType());
	}

	static void smethod_468(IDictionary<string, JsonSchema> idictionary_0, IDictionary<string, JsonSchemaNode> idictionary_1, Class170 class170_0)
	{
		if (idictionary_0 == null)
		{
			return;
		}
		foreach (KeyValuePair<string, JsonSchema> item in idictionary_0)
		{
			string key = item.Key;
			JsonSchema value = item.Value;
			Class7.smethod_152(idictionary_1, class170_0, value, key);
		}
	}

	static string smethod_469(bool bool_0)
	{
		if (!bool_0)
		{
			return Class8.string_1;
		}
		return Class8.string_0;
	}

	static StringWriter smethod_470(int int_0)
	{
		return new StringWriter(new StringBuilder(int_0), CultureInfo.InvariantCulture);
	}

	static bool smethod_471(JsonToken jsonToken_0)
	{
		if ((uint)(jsonToken_0 - 13) <= 2u)
		{
			return true;
		}
		return false;
	}

	static void smethod_472(Class164 class164_0, JToken jtoken_0)
	{
		class164_0.jsonSchema_0.Items = new List<JsonSchema>();
		switch (jtoken_0.Type)
		{
		default:
			throw Class7.smethod_609((Interface1)jtoken_0, jtoken_0.Path, "Expected array or JSON schema object, got {0}.".smethod_1(CultureInfo.InvariantCulture, jtoken_0.Type));
		case JTokenType.Array:
			class164_0.jsonSchema_0.PositionalItemsValidation = true;
			{
				foreach (JToken item in (IEnumerable<JToken>)jtoken_0)
				{
					class164_0.jsonSchema_0.Items.Add(Class7.smethod_617(class164_0, item));
				}
				break;
			}
		case JTokenType.Object:
			class164_0.jsonSchema_0.Items.Add(Class7.smethod_617(class164_0, jtoken_0));
			class164_0.jsonSchema_0.PositionalItemsValidation = false;
			break;
		}
	}

	static bool smethod_473(Type type_0, object object_0, Class115? class115_0, [Attribute1(true)] out string? string_0)
	{
		Class77 @class = EnumUtils.class111_0.method_0(new Struct5<Type, Class115>(type_0, class115_0));
		ulong num = Class7.smethod_126(object_0);
		if (!@class.bool_0)
		{
			int num2 = Array.BinarySearch(@class.ulong_0, num);
			if (num2 >= 0)
			{
				string_0 = @class.string_1[num2];
				return true;
			}
			string_0 = null;
			return false;
		}
		string_0 = Class7.smethod_5(num, @class);
		return string_0 != null;
	}

	static void smethod_474(Class30 class30_0)
	{
		if (class30_0.char_2 == null)
		{
			class30_0.char_2 = Class87.smethod_0(class30_0.interface0_0, 1024);
			class30_0.char_2[0] = '\0';
		}
	}

	static void smethod_475(Class30 class30_0)
	{
		if (Class7.smethod_260(class30_0, 1, bool_0: true))
		{
			if (class30_0.char_2[class30_0.int_3 + 1] != 'u')
			{
				class30_0.int_3 += 2;
				throw Class7.smethod_423(class30_0, class30_0.char_2[class30_0.int_3 - 1]);
			}
			Class7.smethod_537(class30_0);
			return;
		}
		class30_0.int_3 = class30_0.int_2;
		throw class30_0.method_2();
	}

	static bool smethod_476(Enum14 enum14_0, Enum14 enum14_1, Class152 class152_0)
	{
		return (enum14_0 & enum14_1) == enum14_1;
	}

	static long smethod_477(DateTime dateTime_0)
	{
		if (dateTime_0.Kind == DateTimeKind.Utc)
		{
			return dateTime_0.Ticks;
		}
		return Class7.smethod_322(dateTime_0, dateTime_0.smethod_0());
	}

	static bool smethod_478(Class27 class27_0, Class29 class29_0)
	{
		switch (class29_0.TokenType)
		{
		default:
			return true;
		case JsonToken.StartConstructor:
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Null:
		case JsonToken.Date:
		case JsonToken.Bytes:
			return false;
		}
	}

	static void smethod_479(Class200.Class208 class208_0)
	{
		class208_0.int_0 = -1;
		if (class208_0.ienumerator_0 != null)
		{
			class208_0.ienumerator_0.Dispose();
		}
	}

	static JsonToken? smethod_480(Class32 class32_0, Class176 class176_0)
	{
		return class176_0.Type switch
		{
			JTokenType.Object => JsonToken.EndObject, 
			JTokenType.Array => JsonToken.EndArray, 
			JTokenType.Constructor => JsonToken.EndConstructor, 
			JTokenType.Property => null, 
			_ => throw Class7.smethod_740("Type", (object)class176_0.Type, "Unexpected JContainer type."), 
		};
	}

	static void smethod_481(string string_0, Class29 class29_0, Interface12 interface12_0, XmlNamespaceManager xmlNamespaceManager_0, Interface11 interface11_0, string string_1, string? string_2)
	{
		if (interface11_0.NodeType == XmlNodeType.Document)
		{
			throw Class7.smethod_161(class29_0, "JSON root object has property '{0}' that will be converted to an attribute. A root object cannot have any attribute properties. Consider specifying a DeserializeRootElementName.".smethod_1(CultureInfo.InvariantCulture, string_2));
		}
		string string_3 = XmlConvert.EncodeName(string_1);
		string text = Class7.smethod_462(class29_0);
		Interface11 interface11_ = ((!Class109.smethod_0(string_0)) ? interface12_0.imethod_12(string_3, xmlNamespaceManager_0.LookupNamespace(string_0), text) : interface12_0.imethod_11(string_3, text));
		((Interface13)interface11_0).imethod_1(interface11_);
	}

	static JsonProperty? smethod_482(StringComparison stringComparison_0, string string_0, Class150 class150_0)
	{
		if (stringComparison_0 == StringComparison.Ordinal)
		{
			if (class150_0.method_1(string_0, out var jsonProperty_))
			{
				return jsonProperty_;
			}
			return null;
		}
		int num = 0;
		JsonProperty jsonProperty;
		while (true)
		{
			if (num < class150_0.list_0.Count)
			{
				jsonProperty = class150_0.list_0[num];
				if (string.Equals(string_0, jsonProperty.string_0, stringComparison_0))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return jsonProperty;
	}

	static bool smethod_483(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_0))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return Convert.ToBoolean((int)bigInteger);
			}
			return Convert.ToBoolean(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Boolean.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static Interface11 smethod_484(XObject xobject_0)
	{
		XDocument val = (XDocument)(object)((xobject_0 is XDocument) ? xobject_0 : null);
		if (val != null)
		{
			return new Class233(val);
		}
		XElement val2 = (XElement)(object)((xobject_0 is XElement) ? xobject_0 : null);
		if (val2 != null)
		{
			return new Class234(val2);
		}
		XContainer val3 = (XContainer)(object)((xobject_0 is XContainer) ? xobject_0 : null);
		if (val3 != null)
		{
			return new Class232(val3);
		}
		XProcessingInstruction val4 = (XProcessingInstruction)(object)((xobject_0 is XProcessingInstruction) ? xobject_0 : null);
		if (val4 != null)
		{
			return new Class237(val4);
		}
		XText val5 = (XText)(object)((xobject_0 is XText) ? xobject_0 : null);
		if (val5 != null)
		{
			return new Class235(val5);
		}
		XComment val6 = (XComment)(object)((xobject_0 is XComment) ? xobject_0 : null);
		if (val6 != null)
		{
			return new Class236(val6);
		}
		XAttribute val7 = (XAttribute)(object)((xobject_0 is XAttribute) ? xobject_0 : null);
		if (val7 != null)
		{
			return new Class238(val7);
		}
		XDocumentType val8 = (XDocumentType)(object)((xobject_0 is XDocumentType) ? xobject_0 : null);
		if (val8 != null)
		{
			return new Class231(val8);
		}
		return new Class229(xobject_0);
	}

	static IEnumerable<JToken> smethod_485(Class176 class176_0)
	{
		return Class7.smethod_51(bool_0: true, class176_0);
	}

	static JObject smethod_486(string string_0, Class193? class193_0)
	{
		using Class29 @class = new Class30(new StringReader(string_0));
		JObject result = Class7.smethod_626(@class, class193_0);
		while (@class.vmethod_0())
		{
		}
		return result;
	}

	static bool smethod_487(Class141 class141_0, IDynamicMetaObjectProvider idynamicMetaObjectProvider_0, string? string_0, object object_0)
	{
		Class113.smethod_0(idynamicMetaObjectProvider_0, "dynamicProvider");
		CallSite<Func<CallSite, object, object, object>> callSite = class141_0.class111_1.method_0(string_0);
		return callSite.Target(callSite, idynamicMetaObjectProvider_0, object_0) != Class76.object_0;
	}

	static JToken smethod_488(JToken jtoken_0, JToken jtoken_1, JToken jtoken_2)
	{
		if (jtoken_1 != null && jtoken_1.HasValues)
		{
			jtoken_0 = jtoken_1.First;
		}
		else
		{
			while (jtoken_0 != null && jtoken_0 != jtoken_2 && jtoken_0 == jtoken_0.Parent!.Last)
			{
				jtoken_0 = jtoken_0.Parent;
			}
			if (jtoken_0 == null || jtoken_0 == jtoken_2)
			{
				return null;
			}
			jtoken_0 = jtoken_0.Next;
		}
		return jtoken_0;
	}

	static bool smethod_489(char char_0)
	{
		return char.IsHighSurrogate(char_0);
	}

	static IEnumerable<JToken> smethod_490(bool bool_0, JToken jtoken_0, string string_0)
	{
		Class195 class195_ = (bool_0 ? new Class195
		{
			ErrorWhenNoMatch = true
		} : null);
		return Class7.smethod_615(class195_, string_0, jtoken_0);
	}

	static void smethod_491(Class38 class38_0, Enum21 enum21_0, object object_0)
	{
		while (true)
		{
			IConvertible convertible;
			switch (enum21_0)
			{
			default:
				convertible = object_0 as IConvertible;
				if (convertible == null)
				{
					if (object_0 == null)
					{
						class38_0.vmethod_17();
						return;
					}
					throw Class7.smethod_135(class38_0, object_0);
				}
				break;
			case Enum21.const_2:
				class38_0.vmethod_31((char)object_0);
				return;
			case Enum21.const_3:
				class38_0.vmethod_48((object_0 == null) ? null : new char?((char)object_0));
				return;
			case Enum21.const_4:
				class38_0.vmethod_28((bool)object_0);
				return;
			case Enum21.const_5:
				class38_0.vmethod_45((object_0 == null) ? null : new bool?((bool)object_0));
				return;
			case Enum21.const_6:
				class38_0.vmethod_33((sbyte)object_0);
				return;
			case Enum21.const_7:
				class38_0.vmethod_50((object_0 == null) ? null : new sbyte?((sbyte)object_0));
				return;
			case Enum21.const_8:
				class38_0.vmethod_29((short)object_0);
				return;
			case Enum21.const_9:
				class38_0.vmethod_46((object_0 == null) ? null : new short?((short)object_0));
				return;
			case Enum21.const_10:
				class38_0.vmethod_30((ushort)object_0);
				return;
			case Enum21.const_11:
				class38_0.vmethod_47((object_0 == null) ? null : new ushort?((ushort)object_0));
				return;
			case Enum21.const_12:
				class38_0.vmethod_22((int)object_0);
				return;
			case Enum21.const_13:
				class38_0.vmethod_39((object_0 == null) ? null : new int?((int)object_0));
				return;
			case Enum21.const_14:
				class38_0.vmethod_32((byte)object_0);
				return;
			case Enum21.const_15:
				class38_0.vmethod_49((object_0 == null) ? null : new byte?((byte)object_0));
				return;
			case Enum21.const_16:
				class38_0.vmethod_23((uint)object_0);
				return;
			case Enum21.const_17:
				class38_0.vmethod_40((object_0 == null) ? null : new uint?((uint)object_0));
				return;
			case Enum21.const_18:
				class38_0.vmethod_24((long)object_0);
				return;
			case Enum21.const_19:
				class38_0.vmethod_41((object_0 == null) ? null : new long?((long)object_0));
				return;
			case Enum21.const_20:
				class38_0.vmethod_25((ulong)object_0);
				return;
			case Enum21.const_21:
				class38_0.vmethod_42((object_0 == null) ? null : new ulong?((ulong)object_0));
				return;
			case Enum21.const_22:
				class38_0.vmethod_26((float)object_0);
				return;
			case Enum21.const_23:
				class38_0.vmethod_43((object_0 == null) ? null : new float?((float)object_0));
				return;
			case Enum21.const_24:
				class38_0.vmethod_27((double)object_0);
				return;
			case Enum21.const_25:
				class38_0.vmethod_44((object_0 == null) ? null : new double?((double)object_0));
				return;
			case Enum21.const_26:
				class38_0.vmethod_35((DateTime)object_0);
				return;
			case Enum21.const_27:
				class38_0.vmethod_52((object_0 == null) ? null : new DateTime?((DateTime)object_0));
				return;
			case Enum21.const_28:
				class38_0.vmethod_36((DateTimeOffset)object_0);
				return;
			case Enum21.const_29:
				class38_0.vmethod_53((object_0 == null) ? null : new DateTimeOffset?((DateTimeOffset)object_0));
				return;
			case Enum21.const_30:
				class38_0.vmethod_34((decimal)object_0);
				return;
			case Enum21.const_31:
				class38_0.vmethod_51((object_0 == null) ? null : new decimal?((decimal)object_0));
				return;
			case Enum21.const_32:
				class38_0.vmethod_37((Guid)object_0);
				return;
			case Enum21.const_33:
				class38_0.vmethod_54((object_0 == null) ? null : new Guid?((Guid)object_0));
				return;
			case Enum21.const_34:
				class38_0.vmethod_38((TimeSpan)object_0);
				return;
			case Enum21.const_35:
				class38_0.vmethod_55((object_0 == null) ? null : new TimeSpan?((TimeSpan)object_0));
				return;
			case Enum21.const_36:
				class38_0.vmethod_58((BigInteger)object_0);
				return;
			case Enum21.const_37:
				class38_0.vmethod_58((object_0 == null) ? null : new BigInteger?((BigInteger)object_0));
				return;
			case Enum21.const_38:
				class38_0.vmethod_57((Uri)object_0);
				return;
			case Enum21.const_39:
				class38_0.vmethod_21((string)object_0);
				return;
			case Enum21.const_40:
				class38_0.vmethod_56((byte[])object_0);
				return;
			case Enum21.const_41:
				class38_0.vmethod_17();
				return;
			}
			Class7.smethod_521(ref enum21_0, convertible, out object_0);
		}
	}

	static void smethod_492(Type type_0, Class152 class152_0, Class38 class38_0)
	{
		Enum18 enum18_ = class152_0.class34_0.enum18_0;
		Interface6 interface6_ = class152_0.class34_0.interface6_0;
		string text = Class7.smethod_225(interface6_, type_0, enum18_);
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class38_0.Path, "Writing type name '{0}' for {1}.".smethod_2(CultureInfo.InvariantCulture, text, type_0)), null);
		}
		class38_0.vmethod_10("$type", bool_2: false);
		class38_0.vmethod_21(text);
	}

	static object smethod_493(JsonProperty jsonProperty_0)
	{
		if (jsonProperty_0.type_0 == null)
		{
			return null;
		}
		if (!jsonProperty_0.bool_0 && !jsonProperty_0.bool_1)
		{
			jsonProperty_0.object_0 = Class7.smethod_581(jsonProperty_0.type_0);
			jsonProperty_0.bool_1 = true;
		}
		return jsonProperty_0.object_0;
	}

	static bool smethod_494(JsonSchemaType jsonSchemaType_0, JsonSchemaType? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			return true;
		}
		if ((nullable_0 & jsonSchemaType_0) == jsonSchemaType_0)
		{
			return true;
		}
		if (jsonSchemaType_0 == JsonSchemaType.Integer)
		{
			JsonSchemaType? jsonSchemaType = nullable_0 & JsonSchemaType.Float;
			JsonSchemaType jsonSchemaType2 = JsonSchemaType.Float;
			if (jsonSchemaType == JsonSchemaType.Float)
			{
				return true;
			}
		}
		return false;
	}

	static void smethod_495(Class38 class38_0, JsonContainerType jsonContainerType_0)
	{
		if (class38_0.struct0_0.jsonContainerType_0 != 0)
		{
			if (class38_0.list_0 == null)
			{
				class38_0.list_0 = new List<Struct0>();
			}
			class38_0.list_0!.Add(class38_0.struct0_0);
		}
		class38_0.struct0_0 = new Struct0(jsonContainerType_0);
	}

	static bool smethod_496(string string_0, Class30 class30_0)
	{
		return Class7.smethod_341(string_0, class30_0, Class7.smethod_260(class30_0, string_0.Length - 1, bool_0: true));
	}

	static JToken smethod_497(object object_0, Class34 class34_0)
	{
		Class113.smethod_0(object_0, "o");
		Class113.smethod_0(class34_0, "jsonSerializer");
		using Class41 @class = new Class41();
		Class7.smethod_118(class34_0, (Class38?)@class, object_0);
		return @class.Token;
	}

	static Class9 smethod_498(Type type_0, object[]? object_0)
	{
		return (Class9)JsonTypeReflector.class111_0.method_0(type_0)(object_0);
	}

	static DateTimeOffset? smethod_499(Class29 class29_0, string string_0)
	{
		if (Class109.smethod_0(string_0))
		{
			Class7.smethod_211(class29_0, JsonToken.Null, (object)null, bool_0: false);
			return null;
		}
		if (Class7.smethod_439(string_0, class29_0.string_0, class29_0.Culture, out DateTimeOffset dateTimeOffset_))
		{
			Class7.smethod_211(class29_0, JsonToken.Date, (object)dateTimeOffset_, bool_0: false);
			return dateTimeOffset_;
		}
		if (!DateTimeOffset.TryParse(string_0, class29_0.Culture, DateTimeStyles.RoundtripKind, out dateTimeOffset_))
		{
			Class7.smethod_211(class29_0, JsonToken.String, (object)string_0, bool_0: false);
			throw Class7.smethod_555(class29_0, "Could not convert string to DateTimeOffset: {0}.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		Class7.smethod_211(class29_0, JsonToken.Date, (object)dateTimeOffset_, bool_0: false);
		return dateTimeOffset_;
	}

	static void smethod_500(Class41 class41_0)
	{
		class41_0.jtoken_0 = class41_0.class176_1;
		class41_0.class176_1 = class41_0.class176_1!.Parent;
		if (class41_0.class176_1 != null && class41_0.class176_1!.Type == JTokenType.Property)
		{
			class41_0.class176_1 = class41_0.class176_1!.Parent;
		}
	}

	static JToken smethod_501(float? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static void smethod_502(Class39 class39_0)
	{
		Enum17 enum17_ = class39_0.enum17_0;
		char char_ = class39_0.char_1;
		class39_0.bool_3 = Class7.smethod_595(char_, enum17_);
	}

	static JsonSchemaNode smethod_503(JsonSchemaNode jsonSchemaNode_0, Class170 class170_0, JsonSchema jsonSchema_0)
	{
		string key;
		if (jsonSchemaNode_0 != null)
		{
			if (jsonSchemaNode_0.Schemas.Contains(jsonSchema_0))
			{
				return jsonSchemaNode_0;
			}
			key = Class7.smethod_61(jsonSchemaNode_0.Schemas.Union(new JsonSchema[1] { jsonSchema_0 }));
		}
		else
		{
			key = Class7.smethod_61((IEnumerable<JsonSchema>)new JsonSchema[1] { jsonSchema_0 });
		}
		if (class170_0.class171_0.Contains(key))
		{
			return class170_0.class171_0[key];
		}
		JsonSchemaNode jsonSchemaNode = ((jsonSchemaNode_0 != null) ? new JsonSchemaNode(jsonSchemaNode_0, jsonSchema_0) : new JsonSchemaNode(jsonSchema_0));
		class170_0.class171_0.Add(jsonSchemaNode);
		IDictionary<string, JsonSchema> properties = jsonSchema_0.Properties;
		IDictionary<string, JsonSchemaNode> properties2 = jsonSchemaNode.Properties;
		Class7.smethod_468(properties, properties2, class170_0);
		properties = jsonSchema_0.PatternProperties;
		properties2 = jsonSchemaNode.PatternProperties;
		Class7.smethod_468(properties, properties2, class170_0);
		if (jsonSchema_0.Items != null)
		{
			for (int i = 0; i < jsonSchema_0.Items.Count; i++)
			{
				Class7.smethod_329(class170_0, jsonSchemaNode, i, jsonSchema_0.Items[i]);
			}
		}
		if (jsonSchema_0.AdditionalItems != null)
		{
			Class7.smethod_768(jsonSchema_0.AdditionalItems, class170_0, jsonSchemaNode);
		}
		if (jsonSchema_0.AdditionalProperties != null)
		{
			Class7.smethod_638(jsonSchema_0.AdditionalProperties, jsonSchemaNode, class170_0);
		}
		if (jsonSchema_0.Extends != null)
		{
			foreach (JsonSchema extend in jsonSchema_0.Extends)
			{
				jsonSchemaNode = Class7.smethod_503(jsonSchemaNode, class170_0, extend);
			}
			return jsonSchemaNode;
		}
		return jsonSchemaNode;
	}

	static bool smethod_504(ref string string_0, bool bool_0, Type type_0, [Out][Attribute1(true)] object? object_0)
	{
		return Class7.smethod_473(type_0, object_0, (Class115?)(bool_0 ? EnumUtils.class116_0 : null), out string_0);
	}

	static JsonSerializationException smethod_505(Interface1? interface1_0, string string_0, string string_1, Exception? exception_0)
	{
		string_1 = Struct0.smethod_2(interface1_0, string_0, string_1);
		int lineNumber;
		int linePosition;
		if (interface1_0 != null && interface1_0!.imethod_0())
		{
			lineNumber = interface1_0!.LineNumber;
			linePosition = interface1_0!.LinePosition;
		}
		else
		{
			lineNumber = 0;
			linePosition = 0;
		}
		return new JsonSerializationException(string_1, string_0, lineNumber, linePosition, exception_0);
	}

	static void smethod_506(Class38 class38_0, JsonToken jsonToken_0, JsonContainerType jsonContainerType_0)
	{
		Class7.smethod_725(class38_0);
		class38_0.method_2(jsonToken_0);
		Class7.smethod_495(class38_0, jsonContainerType_0);
	}

	static void smethod_507(JsonSchemaWriter jsonSchemaWriter_0, JsonSchema jsonSchema_0)
	{
		Class113.smethod_0(jsonSchema_0, "schema");
		if (!jsonSchemaWriter_0.class172_0.LoadedSchemas.Contains(jsonSchema_0))
		{
			jsonSchemaWriter_0.class172_0.LoadedSchemas.Add(jsonSchema_0);
		}
		jsonSchemaWriter_0.class38_0.vmethod_3();
		Class38 class38_ = jsonSchemaWriter_0.class38_0;
		string string_ = "id";
		object id = jsonSchema_0.Id;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "title";
		id = jsonSchema_0.Title;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "description";
		id = jsonSchema_0.Description;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "required";
		id = jsonSchema_0.Required;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "readonly";
		id = jsonSchema_0.ReadOnly;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "hidden";
		id = jsonSchema_0.Hidden;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "transient";
		id = jsonSchema_0.Transient;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		if (jsonSchema_0.Type.HasValue)
		{
			string string_2 = "type";
			Class38 class38_2 = jsonSchemaWriter_0.class38_0;
			JsonSchemaType? type = jsonSchema_0.Type;
			Class38 class38_3 = class38_2;
			JsonSchemaType valueOrDefault = type.GetValueOrDefault();
			Class7.smethod_163(string_2, valueOrDefault, jsonSchemaWriter_0, class38_3);
		}
		if (!jsonSchema_0.AllowAdditionalProperties)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("additionalProperties");
			jsonSchemaWriter_0.class38_0.vmethod_28(jsonSchema_0.AllowAdditionalProperties);
		}
		else if (jsonSchema_0.AdditionalProperties != null)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("additionalProperties");
			Class7.smethod_162(jsonSchemaWriter_0, jsonSchema_0.AdditionalProperties);
		}
		if (!jsonSchema_0.AllowAdditionalItems)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("additionalItems");
			jsonSchemaWriter_0.class38_0.vmethod_28(jsonSchema_0.AllowAdditionalItems);
		}
		else if (jsonSchema_0.AdditionalItems != null)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("additionalItems");
			Class7.smethod_162(jsonSchemaWriter_0, jsonSchema_0.AdditionalItems);
		}
		Class7.smethod_124(jsonSchemaWriter_0, jsonSchemaWriter_0.class38_0, "properties", jsonSchema_0.Properties);
		Class7.smethod_124(jsonSchemaWriter_0, jsonSchemaWriter_0.class38_0, "patternProperties", jsonSchema_0.PatternProperties);
		Class7.smethod_643(jsonSchemaWriter_0, jsonSchema_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "minimum";
		id = jsonSchema_0.Minimum;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "maximum";
		id = jsonSchema_0.Maximum;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "exclusiveMinimum";
		id = jsonSchema_0.ExclusiveMinimum;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "exclusiveMaximum";
		id = jsonSchema_0.ExclusiveMaximum;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "minLength";
		id = jsonSchema_0.MinimumLength;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "maxLength";
		id = jsonSchema_0.MaximumLength;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "minItems";
		id = jsonSchema_0.MinimumItems;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "maxItems";
		id = jsonSchema_0.MaximumItems;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "divisibleBy";
		id = jsonSchema_0.DivisibleBy;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "format";
		id = jsonSchema_0.Format;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		class38_ = jsonSchemaWriter_0.class38_0;
		string_ = "pattern";
		id = jsonSchema_0.Pattern;
		Class7.smethod_224(string_, id, class38_, jsonSchemaWriter_0);
		if (jsonSchema_0.Enum != null)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("enum");
			jsonSchemaWriter_0.class38_0.vmethod_5();
			foreach (JToken item in jsonSchema_0.Enum)
			{
				item.vmethod_5(jsonSchemaWriter_0.class38_0);
			}
			jsonSchemaWriter_0.class38_0.vmethod_6();
		}
		if (jsonSchema_0.Default != null)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("default");
			jsonSchema_0.Default.vmethod_5(jsonSchemaWriter_0.class38_0);
		}
		if (jsonSchema_0.Disallow.HasValue)
		{
			string string_2 = "disallow";
			Class38 class38_4 = jsonSchemaWriter_0.class38_0;
			JsonSchemaType? type = jsonSchema_0.Disallow;
			Class38 class38_3 = class38_4;
			JsonSchemaType valueOrDefault = type.GetValueOrDefault();
			Class7.smethod_163(string_2, valueOrDefault, jsonSchemaWriter_0, class38_3);
		}
		if (jsonSchema_0.Extends != null && jsonSchema_0.Extends.Count > 0)
		{
			jsonSchemaWriter_0.class38_0.vmethod_9("extends");
			if (jsonSchema_0.Extends.Count == 1)
			{
				Class7.smethod_162(jsonSchemaWriter_0, jsonSchema_0.Extends[0]);
			}
			else
			{
				jsonSchemaWriter_0.class38_0.vmethod_5();
				foreach (JsonSchema extend in jsonSchema_0.Extends)
				{
					Class7.smethod_162(jsonSchemaWriter_0, extend);
				}
				jsonSchemaWriter_0.class38_0.vmethod_6();
			}
		}
		jsonSchemaWriter_0.class38_0.vmethod_4();
	}

	static bool smethod_508(Enum4 enum4_0, Enum4 enum4_1, Class167 class167_0)
	{
		return (enum4_1 & enum4_0) == enum4_0;
	}

	static IEnumerable<FieldInfo> smethod_509(Type type_0, BindingFlags bindingFlags_0)
	{
		Class113.smethod_0(type_0, "targetType");
		List<MemberInfo> list = new List<MemberInfo>(type_0.GetFields(bindingFlags_0));
		Class7.smethod_127((IList<MemberInfo>)list, type_0, bindingFlags_0);
		return list.Cast<FieldInfo>();
	}

	static BigInteger smethod_510(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class == null || !Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_2))
		{
			throw new ArgumentException("Can not convert {0} to BigInteger.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
		}
		return Class7.smethod_442(@class.Value);
	}

	static bool smethod_511(ref TypeConverter typeConverter_0, [Out] Type type_0)
	{
		typeConverter_0 = TypeDescriptor.GetConverter(type_0);
		if (typeConverter_0 != null)
		{
			Type type = typeConverter_0.GetType();
			if (!string.Equals(type.FullName, "System.ComponentModel.ComponentConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.ComponentModel.ReferenceConverter", StringComparison.Ordinal) && !string.Equals(type.FullName, "System.Windows.Forms.Design.DataSourceConverter", StringComparison.Ordinal) && type != typeof(TypeConverter))
			{
				return typeConverter_0.CanConvertTo(typeof(string));
			}
		}
		return false;
	}

	static JObject smethod_512(Class29 class29_0)
	{
		return Class7.smethod_626(class29_0, (Class193?)null);
	}

	static bool smethod_513(char char_0)
	{
		return char.IsLowSurrogate(char_0);
	}

	static JTokenType smethod_514(JTokenType? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			return JTokenType.String;
		}
		JTokenType valueOrDefault = nullable_0.GetValueOrDefault();
		if (valueOrDefault != JTokenType.Comment && valueOrDefault != JTokenType.String && valueOrDefault != JTokenType.Raw)
		{
			return JTokenType.String;
		}
		return nullable_0.GetValueOrDefault();
	}

	static bool smethod_515(string string_0, Type type_0, Type type_1)
	{
		ReflectionUtils.Class107 CS_0024_003C_003E8__locals0 = new ReflectionUtils.Class107();
		CS_0024_003C_003E8__locals0.string_0 = string_0;
		CS_0024_003C_003E8__locals0.type_0 = type_0;
		return type_1.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic).Any((MethodInfo methodInfo_0) => methodInfo_0.Name == CS_0024_003C_003E8__locals0.string_0 && methodInfo_0.DeclaringType != CS_0024_003C_003E8__locals0.type_0 && methodInfo_0.GetBaseDefinition().DeclaringType == CS_0024_003C_003E8__locals0.type_0);
	}

	static object? smethod_516(object? object_0, Type type_0, Type type_1)
	{
		if (object_0 != null)
		{
			Type type = object_0!.GetType();
			if (type_1.IsAssignableFrom(type))
			{
				return object_0;
			}
			Func<object, object> func = Class49.class111_0.method_0(new Struct5<Type, Type>(type, type_1));
			if (func != null)
			{
				return func(object_0);
			}
		}
		else if (Class7.smethod_213(type_1))
		{
			return null;
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj;
		if ((object)type_0 == null)
		{
			obj = null;
		}
		else
		{
			obj = type_0.ToString();
			if (obj != null)
			{
				goto IL_0059;
			}
		}
		obj = "{null}";
		goto IL_0059;
		IL_0059:
		throw new ArgumentException("Could not cast or convert from {0} to {1}.".smethod_2(invariantCulture, obj, type_1));
	}

	static DateTime smethod_517(DateTime dateTime_0, Enum3 enum3_0)
	{
		switch (enum3_0)
		{
		default:
			throw new ArgumentException("Invalid date time handling value.");
		case Enum3.const_0:
			dateTime_0 = Class7.smethod_184(dateTime_0);
			break;
		case Enum3.const_1:
			dateTime_0 = Class7.smethod_104(dateTime_0);
			break;
		case Enum3.const_2:
			dateTime_0 = new DateTime(dateTime_0.Ticks, DateTimeKind.Unspecified);
			break;
		case Enum3.const_3:
			break;
		}
		return dateTime_0;
	}

	static int smethod_518(ulong ulong_0)
	{
		if (ulong_0 < 10000000000L)
		{
			if (ulong_0 < 10L)
			{
				return 1;
			}
			if (ulong_0 < 100L)
			{
				return 2;
			}
			if (ulong_0 < 1000L)
			{
				return 3;
			}
			if (ulong_0 < 10000L)
			{
				return 4;
			}
			if (ulong_0 < 100000L)
			{
				return 5;
			}
			if (ulong_0 < 1000000L)
			{
				return 6;
			}
			if (ulong_0 < 10000000L)
			{
				return 7;
			}
			if (ulong_0 < 100000000L)
			{
				return 8;
			}
			if (ulong_0 < 1000000000L)
			{
				return 9;
			}
			return 10;
		}
		if (ulong_0 < 100000000000L)
		{
			return 11;
		}
		if (ulong_0 < 1000000000000L)
		{
			return 12;
		}
		if (ulong_0 < 10000000000000L)
		{
			return 13;
		}
		if (ulong_0 < 100000000000000L)
		{
			return 14;
		}
		if (ulong_0 < 1000000000000000L)
		{
			return 15;
		}
		if (ulong_0 < 10000000000000000L)
		{
			return 16;
		}
		if (ulong_0 < 100000000000000000L)
		{
			return 17;
		}
		if (ulong_0 < 1000000000000000000L)
		{
			return 18;
		}
		if (ulong_0 < 10000000000000000000uL)
		{
			return 19;
		}
		return 20;
	}

	static object smethod_519(Class22 class22_0, Class29 class29_0)
	{
		IList<object> list = new List<object>();
		while (class29_0.vmethod_0())
		{
			switch (class29_0.TokenType)
			{
			case JsonToken.Comment:
				continue;
			case JsonToken.EndArray:
				return list;
			}
			object item = Class7.smethod_758(class22_0, class29_0);
			list.Add(item);
		}
		throw Class7.smethod_161(class29_0, "Unexpected end when reading ExpandoObject.");
	}

	static void smethod_520(Interface0<char> interface0_0, char[] char_0)
	{
		interface0_0?.imethod_1(char_0);
	}

	static void smethod_521(ref Enum21 enum21_0, [Out] IConvertible iconvertible_0, out object object_0)
	{
		Class48 @class = Class7.smethod_403(iconvertible_0);
		enum21_0 = ((@class.TypeCode == Enum21.const_1) ? Enum21.const_39 : @class.TypeCode);
		Type conversionType = ((@class.TypeCode == Enum21.const_1) ? typeof(string) : @class.Type);
		object_0 = iconvertible_0.ToType(conversionType, CultureInfo.InvariantCulture);
	}

	static void smethod_522(Class42 class42_0)
	{
		class42_0.class242_1 = class42_0.class242_1.Parent;
	}

	static void smethod_523(Class30 class30_0)
	{
		if (!Class7.smethod_346(Class8.string_0, class30_0))
		{
			throw Class7.smethod_555((Class29)class30_0, "Error parsing boolean value.");
		}
		Class7.smethod_186((Class29)class30_0, JsonToken.Boolean, (object)true);
	}

	static Enum21 smethod_524(Type type_0)
	{
		bool bool_ = default(bool);
		return Class7.smethod_425(ref bool_, type_0);
	}

	static JToken smethod_525(DateTime? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static JToken smethod_526(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29 class29_0)
	{
		Class113.smethod_0(class29_0, "reader");
		using Class41 @class = new Class41();
		@class.vmethod_3();
		while (true)
		{
			if (class29_0.TokenType != JsonToken.PropertyName)
			{
				if (class29_0.TokenType != JsonToken.Comment)
				{
					break;
				}
			}
			else
			{
				string text = (string)class29_0.Value;
				if (!Class7.smethod_110(class29_0))
				{
					goto IL_006a;
				}
				if (!Class7.smethod_628(text, class29_0, jsonSerializerInternalReader_0))
				{
					@class.vmethod_9(text);
					@class.vmethod_12(class29_0, bool_2: true, bool_3: true, bool_4: false);
				}
			}
			if (class29_0.vmethod_0())
			{
				continue;
			}
			goto IL_006a;
			IL_006a:
			throw Class7.smethod_161(class29_0, "Unexpected end when deserializing object.");
		}
		@class.vmethod_4();
		return @class.Token;
	}

	static void smethod_527(Class30 class30_0)
	{
		class30_0.struct3_0.Position = 0;
		class30_0.struct4_0 = default(Struct4);
	}

	static void smethod_528(Class27 class27_0, Class38 class38_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_0, Interface11 interface11_0, string string_0)
	{
		if (!class27_0.method_1(interface11_0))
		{
			class27_0.method_3(class38_0, interface11_0, xmlNamespaceManager_0, bool_0);
			return;
		}
		if (bool_0)
		{
			class38_0.vmethod_9(string_0);
		}
		class38_0.vmethod_5();
		class27_0.method_3(class38_0, interface11_0, xmlNamespaceManager_0, bool_3: false);
		class38_0.vmethod_6();
	}

	static void smethod_529(Class30 class30_0)
	{
		int num = class30_0.int_3;
		while (true)
		{
			char c = class30_0.char_2[num];
			if (c != 0)
			{
				if (Class7.smethod_312(class30_0, c, num))
				{
					break;
				}
				num++;
			}
			else
			{
				class30_0.int_3 = num;
				if (class30_0.int_2 != num || Class7.smethod_418(bool_0: true, class30_0) == 0)
				{
					break;
				}
			}
		}
	}

	static IEnumerable<string> smethod_530(Class157 class157_0)
	{
		return class157_0.queue_0;
	}

	static void smethod_531(JsonSchemaModel jsonSchemaModel_0, JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonSchemaModel_0 != null)
		{
			int arrayItemCount = jsonValidatingReader_0.schemaScope_0.ArrayItemCount;
			if (jsonSchemaModel_0.MaximumItems.HasValue && arrayItemCount > jsonSchemaModel_0.MaximumItems)
			{
				Class7.smethod_239(jsonValidatingReader_0, "Array item count {0} exceeds maximum count of {1}.".smethod_2(CultureInfo.InvariantCulture, arrayItemCount, jsonSchemaModel_0.MaximumItems), jsonSchemaModel_0);
			}
			if (jsonSchemaModel_0.MinimumItems.HasValue && arrayItemCount < jsonSchemaModel_0.MinimumItems)
			{
				Class7.smethod_239(jsonValidatingReader_0, "Array item count {0} is less than minimum count of {1}.".smethod_2(CultureInfo.InvariantCulture, arrayItemCount, jsonSchemaModel_0.MinimumItems), jsonSchemaModel_0);
			}
		}
	}

	static int smethod_532(Class33 class33_0)
	{
		Class7.smethod_452(class33_0, 4);
		return class33_0.binaryReader_0.ReadInt32();
	}

	static void smethod_533(Type type_0, ILGenerator ilgenerator_0, Class69 class69_0, Type type_1)
	{
		if (type_0.smethod_13())
		{
			ilgenerator_0.DeclareLocal(type_0);
			ilgenerator_0.Emit(OpCodes.Ldloc_0);
			if (type_0 != type_1)
			{
				ilgenerator_0.Emit(OpCodes.Box, type_0);
			}
		}
		else
		{
			ConstructorInfo constructor = type_0.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, ReflectionUtils.type_0, null);
			if (constructor == null)
			{
				throw new ArgumentException("Could not get constructor for {0}.".smethod_1(CultureInfo.InvariantCulture, type_0));
			}
			ilgenerator_0.Emit(OpCodes.Newobj, constructor);
		}
		ilgenerator_0.smethod_5();
	}

	static JsonSchema smethod_534(bool bool_0, Class167 class167_0, Type type_0)
	{
		return Class7.smethod_121(new Class172(), bool_0, type_0, class167_0);
	}

	static bool smethod_535(Class32 class32_0, Class176 class176_0)
	{
		JToken first = class176_0.First;
		if (first == null)
		{
			return Class7.smethod_91(class32_0, class176_0);
		}
		Class7.smethod_614(class32_0, first);
		class32_0.jtoken_2 = first;
		class32_0.jtoken_1 = class176_0;
		return true;
	}

	static bool smethod_536(Type type_0, ref Delegate7<object> delegate7_0, ref Type type_1, [Out][Attribute1(true)] Type? type_2, [Out][Attribute1(true)] Type? type_3)
	{
		if (type_3.smethod_4())
		{
			ImmutableCollectionsUtils.Class86 CS_0024_003C_003E8__locals0 = new ImmutableCollectionsUtils.Class86();
			Type genericTypeDefinition = type_3!.GetGenericTypeDefinition();
			CS_0024_003C_003E8__locals0.string_0 = genericTypeDefinition.FullName;
			ImmutableCollectionsUtils.Class84 @class = ImmutableCollectionsUtils.ilist_1.FirstOrDefault((ImmutableCollectionsUtils.Class84 class84_0) => class84_0.ContractTypeName == CS_0024_003C_003E8__locals0.string_0);
			if (@class != null)
			{
				Type type = genericTypeDefinition.smethod_7().GetType(@class.CreatedTypeName);
				Type type2 = genericTypeDefinition.smethod_7().GetType(@class.BuilderTypeName);
				if (type != null && type2 != null)
				{
					MethodInfo methodInfo = type2.GetMethods().FirstOrDefault(delegate(MethodInfo methodInfo_0)
					{
						ParameterInfo[] parameters = methodInfo_0.GetParameters();
						return methodInfo_0.Name == "CreateRange" && parameters.Length == 1 && parameters[0].ParameterType.smethod_4() && parameters[0].ParameterType.GetGenericTypeDefinition() == typeof(IEnumerable<>);
					});
					if (methodInfo != null)
					{
						type_1 = type.MakeGenericType(type_2, type_0);
						MethodInfo methodBase_ = methodInfo.MakeGenericMethod(type_2, type_0);
						delegate7_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(methodBase_);
						return true;
					}
				}
			}
		}
		type_1 = null;
		delegate7_0 = null;
		return false;
	}

	static void smethod_537(Class30 class30_0)
	{
		if (!Class7.smethod_346(Class8.string_2, class30_0))
		{
			throw Class7.smethod_555((Class29)class30_0, "Error parsing null value.");
		}
		Class7.smethod_386((Class29)class30_0, JsonToken.Null);
	}

	static JsonSchema smethod_538(Class164 class164_0)
	{
		JsonSchema jsonSchema_ = class164_0.jsonSchema_0;
		class164_0.ilist_0.RemoveAt(class164_0.ilist_0.Count - 1);
		class164_0.jsonSchema_0 = class164_0.ilist_0.LastOrDefault();
		return jsonSchema_;
	}

	static JToken smethod_539(DateTimeOffset dateTimeOffset_0)
	{
		return new Class179(dateTimeOffset_0);
	}

	static bool smethod_540(Type type_0, Class27 class27_0)
	{
		return typeof(XObject).IsAssignableFrom(type_0);
	}

	static void smethod_541(object object_0, MemberInfo memberInfo_0, object? object_1)
	{
		Class113.smethod_0(memberInfo_0, "member");
		Class113.smethod_0(object_0, "target");
		switch (memberInfo_0.smethod_1())
		{
		default:
			throw new ArgumentException("MemberInfo '{0}' must be of type FieldInfo or PropertyInfo".smethod_1(CultureInfo.InvariantCulture, memberInfo_0.Name), "member");
		case MemberTypes.Property:
			((PropertyInfo)memberInfo_0).SetValue(object_0, object_1, null);
			break;
		case MemberTypes.Field:
			((FieldInfo)memberInfo_0).SetValue(object_0, object_1);
			break;
		}
	}

	static void smethod_542(Class200.Class208 class208_0)
	{
		class208_0.int_0 = -3;
		((IDisposable)class208_0.enumerator_0).Dispose();
	}

	static IEnumerable<JToken> smethod_543(JToken jtoken_0)
	{
		return new JToken.Class183(-2)
		{
			jtoken_1 = jtoken_0
		};
	}

	static void smethod_544(Class176 class176_0)
	{
		if (class176_0.bool_0)
		{
			throw new InvalidOperationException("Cannot change {0} during a collection change event.".smethod_1(CultureInfo.InvariantCulture, class176_0.GetType()));
		}
	}

	static decimal? smethod_545(Class29 class29_0, string string_0)
	{
		if (Class109.smethod_0(string_0))
		{
			Class7.smethod_211(class29_0, JsonToken.Null, (object)null, bool_0: false);
			return null;
		}
		if (decimal.TryParse(string_0, NumberStyles.Number, class29_0.Culture, out var result))
		{
			Class7.smethod_211(class29_0, JsonToken.Float, (object)result, bool_0: false);
			return result;
		}
		if (Class7.smethod_720(string_0.ToCharArray(), 0, string_0.Length, out result) != Enum22.const_1)
		{
			Class7.smethod_211(class29_0, JsonToken.String, (object)string_0, bool_0: false);
			throw Class7.smethod_555(class29_0, "Could not convert string to decimal: {0}.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		Class7.smethod_211(class29_0, JsonToken.Float, (object)result, bool_0: false);
		return result;
	}

	static MemberInfo smethod_546(DefaultContractResolver defaultContractResolver_0, Type type_0)
	{
		return Class7.smethod_458(type_0, defaultContractResolver_0).SelectMany(delegate(Type type_0)
		{
			List<MemberInfo> list = new List<MemberInfo>();
			list.smethod_1(type_0.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			list.smethod_1(type_0.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic));
			return list;
		}).LastOrDefault(delegate(MemberInfo memberInfo_0)
		{
			MemberTypes memberTypes = memberInfo_0.smethod_1();
			if (memberTypes != MemberTypes.Property && memberTypes != MemberTypes.Field)
			{
				return false;
			}
			if (!memberInfo_0.IsDefined(typeof(Attribute11), inherit: false))
			{
				return false;
			}
			if (!Class7.smethod_290(memberInfo_0, bool_0: true))
			{
				throw new JsonException("Invalid extension data attribute on '{0}'. Member '{1}' must have a getter.".smethod_2(CultureInfo.InvariantCulture, Class7.smethod_355(memberInfo_0.DeclaringType), memberInfo_0.Name));
			}
			if (Class7.smethod_730(Class7.smethod_632(memberInfo_0), typeof(IDictionary<, >), out Type type_))
			{
				Type type = type_.GetGenericArguments()[0];
				Type type2 = type_.GetGenericArguments()[1];
				if (type.IsAssignableFrom(typeof(string)) && type2.IsAssignableFrom(typeof(JToken)))
				{
					return true;
				}
			}
			throw new JsonException("Invalid extension data attribute on '{0}'. Member '{1}' type must implement IDictionary<string, JToken>.".smethod_2(CultureInfo.InvariantCulture, Class7.smethod_355(memberInfo_0.DeclaringType), memberInfo_0.Name));
		});
	}

	static char smethod_547(char char_0)
	{
		char_0 = char.ToLower(char_0, CultureInfo.InvariantCulture);
		return char_0;
	}

	static void smethod_548(Class176 class176_0, Class29? class29_0, Class193 class193_0)
	{
		Class113.smethod_0(class29_0, "r");
		Interface1 interface1_ = class29_0 as Interface1;
		Class176 @class = class176_0;
		do
		{
			if (@class is JProperty jProperty && jProperty.Value != null)
			{
				if (@class == class176_0)
				{
					break;
				}
				@class = @class.Parent;
			}
			switch (class29_0!.TokenType)
			{
			case JsonToken.StartObject:
			{
				JObject jObject = new JObject();
				jObject.method_5(interface1_, class193_0);
				@class.Add(jObject);
				@class = jObject;
				break;
			}
			case JsonToken.StartArray:
			{
				Class177 class4 = new Class177();
				class4.method_5(interface1_, class193_0);
				@class.Add(class4);
				@class = class4;
				break;
			}
			case JsonToken.StartConstructor:
			{
				Class178 class3 = new Class178(class29_0!.Value!.ToString());
				class3.method_5(interface1_, class193_0);
				@class.Add(class3);
				@class = class3;
				break;
			}
			case JsonToken.PropertyName:
			{
				JProperty jProperty2 = Class176.smethod_36(class29_0, class193_0, interface1_, @class);
				if (jProperty2 != null)
				{
					@class = jProperty2;
				}
				else
				{
					Class7.smethod_310(class29_0);
				}
				break;
			}
			case JsonToken.Comment:
				if (class193_0 != null && class193_0.enum28_0 == Enum28.const_1)
				{
					Class179 class2 = new Class179(class29_0!.Value!.ToString(), JTokenType.Comment);
					class2.method_5(interface1_, class193_0);
					@class.Add(class2);
				}
				break;
			case JsonToken.Null:
			{
				Class179 class2 = new Class179(null, JTokenType.Null);
				class2.method_5(interface1_, class193_0);
				@class.Add(class2);
				break;
			}
			case JsonToken.Undefined:
			{
				Class179 class2 = new Class179(null, JTokenType.Undefined);
				class2.method_5(interface1_, class193_0);
				@class.Add(class2);
				break;
			}
			case JsonToken.EndObject:
				if (@class == class176_0)
				{
					return;
				}
				@class = @class.Parent;
				break;
			case JsonToken.EndArray:
				if (@class == class176_0)
				{
					return;
				}
				@class = @class.Parent;
				break;
			case JsonToken.EndConstructor:
				if (@class == class176_0)
				{
					return;
				}
				@class = @class.Parent;
				break;
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.String:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
			{
				Class179 class2 = new Class179(class29_0!.Value);
				class2.method_5(interface1_, class193_0);
				@class.Add(class2);
				break;
			}
			case JsonToken.None:
				break;
			default:
				throw new InvalidOperationException("The JsonReader should not be on a token of type {0}.".smethod_1(CultureInfo.InvariantCulture, class29_0!.TokenType));
			}
		}
		while (class29_0!.vmethod_0());
	}

	static bool smethod_549(Class33 class33_0)
	{
		switch (class33_0.state_0)
		{
		default:
		{
			Class29.State state_ = class33_0.state_0;
			throw Class7.smethod_555((Class29)class33_0, "Unexpected state when reading BSON reference: " + state_);
		}
		case Class29.State.PostValue:
			if (class33_0.bsonReaderState_0 == Class33.BsonReaderState.ReferenceRef)
			{
				Class7.smethod_186((Class29)class33_0, JsonToken.PropertyName, (object)"$id");
				class33_0.bsonReaderState_0 = Class33.BsonReaderState.ReferenceId;
				return true;
			}
			if (class33_0.bsonReaderState_0 == Class33.BsonReaderState.ReferenceId)
			{
				Class7.smethod_386((Class29)class33_0, JsonToken.EndObject);
				class33_0.bsonReaderState_0 = Class33.BsonReaderState.Normal;
				return true;
			}
			throw Class7.smethod_555((Class29)class33_0, "Unexpected state when reading BSON reference: " + class33_0.bsonReaderState_0);
		case Class29.State.ObjectStart:
			Class7.smethod_186((Class29)class33_0, JsonToken.PropertyName, (object)"$ref");
			class33_0.bsonReaderState_0 = Class33.BsonReaderState.ReferenceRef;
			return true;
		case Class29.State.Property:
			if (class33_0.bsonReaderState_0 == Class33.BsonReaderState.ReferenceRef)
			{
				Class7.smethod_186((Class29)class33_0, JsonToken.String, (object)Class7.smethod_75(class33_0));
				return true;
			}
			if (class33_0.bsonReaderState_0 != Class33.BsonReaderState.ReferenceId)
			{
				throw Class7.smethod_555((Class29)class33_0, "Unexpected state when reading BSON reference: " + class33_0.bsonReaderState_0);
			}
			Class7.smethod_186((Class29)class33_0, JsonToken.Bytes, (object)Class7.smethod_760(class33_0, 12));
			return true;
		}
	}

	static bool smethod_550(string string_0, [Out][Attribute1(true)] Class27? class27_0, ref string string_1)
	{
		if (string_0.StartsWith("xmlns", StringComparison.Ordinal))
		{
			if (string_0.Length == 5)
			{
				string_1 = string.Empty;
				return true;
			}
			if (string_0[5] == ':')
			{
				string_1 = string_0.Substring(6, string_0.Length - 6);
				return true;
			}
		}
		string_1 = null;
		return false;
	}

	static void smethod_551(Interface12 interface12_0, Interface11 interface11_0, Class29 class29_0, Class27 class27_0)
	{
		string string_ = null;
		string string_2 = null;
		string string_3 = null;
		string string_4 = null;
		while (class29_0.vmethod_0() && class29_0.TokenType != JsonToken.EndObject)
		{
			switch (class29_0.Value?.ToString())
			{
			case "@internalSubset":
				Class7.smethod_686(class29_0);
				string_4 = Class7.smethod_462(class29_0);
				break;
			case "@system":
				Class7.smethod_686(class29_0);
				string_3 = Class7.smethod_462(class29_0);
				break;
			case "@public":
				Class7.smethod_686(class29_0);
				string_2 = Class7.smethod_462(class29_0);
				break;
			case "@name":
				Class7.smethod_686(class29_0);
				string_ = Class7.smethod_462(class29_0);
				break;
			default:
				throw Class7.smethod_161(class29_0, "Unexpected property name encountered while deserializing XmlDeclaration: " + class29_0.Value);
			}
		}
		Interface11 interface11_ = interface12_0.imethod_7(string_, string_2, string_3, string_4);
		interface11_0.imethod_0(interface11_);
	}

	static string smethod_552(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class137 class137_0)
	{
		switch (class137_0.enum26_0)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case Enum26.const_2:
			return "JSON array (e.g. [1,2,3])";
		case Enum26.const_3:
			return "JSON primitive value (e.g. string, number, boolean, null)";
		case Enum26.const_4:
			return "JSON string value";
		case Enum26.const_1:
		case Enum26.const_5:
		case Enum26.const_6:
		case Enum26.const_7:
			return "JSON object (e.g. {\"name\":\"value\"})";
		}
	}

	static double smethod_553(double double_0, double double_1)
	{
		return double_1 - Math.Floor(double_1 / double_0) * double_0;
	}

	static bool smethod_554(Type type_0, Type type_1)
	{
		Type type_2;
		return Class7.smethod_730(type_0, type_1, out type_2);
	}

	static JsonReaderException smethod_555(Class29 class29_0, string string_0)
	{
		return Class7.smethod_271(string_0, class29_0, (Exception?)null);
	}

	static string smethod_556(Enum7 enum7_0, XObject xobject_0, bool bool_0)
	{
		Class27 @class = new Class27
		{
			OmitRootObject = bool_0
		};
		return Class8.smethod_19(xobject_0, enum7_0, @class);
	}

	static bool smethod_557(Class38 class38_0, Class152 class152_0, JsonProperty jsonProperty_0, object object_0)
	{
		if (jsonProperty_0.ShouldSerialize == null)
		{
			return true;
		}
		bool flag = jsonProperty_0.ShouldSerialize!(object_0);
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Verbose)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class38_0.Path, "ShouldSerialize result for property '{0}' on {1}: {2}".smethod_3(CultureInfo.InvariantCulture, jsonProperty_0.string_0, jsonProperty_0.DeclaringType, flag)), null);
		}
		return flag;
	}

	static string smethod_558(string string_0)
	{
		if (!Class109.smethod_0(string_0) && char.IsUpper(string_0[0]))
		{
			char[] array = string_0.ToCharArray();
			for (int i = 0; i < array.Length && (i != 1 || char.IsUpper(array[i])); i++)
			{
				bool flag = i + 1 < array.Length;
				if (!(i > 0 && flag) || char.IsUpper(array[i + 1]))
				{
					array[i] = Class7.smethod_547(array[i]);
					continue;
				}
				if (char.IsSeparator(array[i + 1]))
				{
					array[i] = Class7.smethod_547(array[i]);
				}
				break;
			}
			return new string(array);
		}
		return string_0;
	}

	static XmlDateTimeSerializationMode smethod_559(DateTimeKind dateTimeKind_0)
	{
		return dateTimeKind_0 switch
		{
			DateTimeKind.Unspecified => XmlDateTimeSerializationMode.Unspecified, 
			DateTimeKind.Utc => XmlDateTimeSerializationMode.Utc, 
			DateTimeKind.Local => XmlDateTimeSerializationMode.Local, 
			_ => throw Class7.smethod_740("kind", (object)dateTimeKind_0, "Unexpected DateTimeKind value."), 
		};
	}

	static JsonSchema smethod_560(string string_0)
	{
		return Class7.smethod_432(string_0, new Class172());
	}

	static void smethod_561(Class30 class30_0, int int_0)
	{
		class30_0.int_5++;
		class30_0.int_4 = int_0;
	}

	static string smethod_562(Uri uri_0, char char_0)
	{
		return Class7.smethod_579(uri_0.OriginalString, char_0);
	}

	static Class9? smethod_563(Class34 class34_0, Type type_0)
	{
		return Class7.smethod_612(type_0, (IList<Class9>)class34_0.class28_0);
	}

	static long smethod_564(TimeSpan timeSpan_0, DateTime dateTime_0)
	{
		return (Class7.smethod_322(dateTime_0, timeSpan_0) - Class51.long_0) / 10000L;
	}

	static long smethod_565(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (long)bigInteger;
			}
			return Convert.ToInt64(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int64.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static void smethod_566(Class176 class176_0, IEnumerable ienumerable_0, Class194? class194_0)
	{
		if (class194_0 != null)
		{
			switch (class194_0!.enum31_0)
			{
			default:
				throw new ArgumentOutOfRangeException("settings", "Unexpected merge array handling when merging JSON.");
			case Enum31.const_0:
				break;
			case Enum31.const_1:
			{
				HashSet<JToken> hashSet = new HashSet<JToken>(class176_0, JToken.EqualityComparer);
				{
					foreach (JToken item in ienumerable_0)
					{
						if (hashSet.Add(item))
						{
							class176_0.Add(item);
						}
					}
					return;
				}
			}
			case Enum31.const_2:
				if (class176_0 == ienumerable_0)
				{
					return;
				}
				class176_0.vmethod_18();
				{
					foreach (JToken item2 in ienumerable_0)
					{
						class176_0.Add(item2);
					}
					return;
				}
			case Enum31.const_3:
			{
				int num = 0;
				{
					foreach (object item3 in ienumerable_0)
					{
						if (num < class176_0.Count)
						{
							if (class176_0[num] is Class176 class176_)
							{
								Class7.smethod_631(class176_, item3, class194_0);
							}
							else if (item3 != null)
							{
								JToken jToken = Class7.smethod_85(item3);
								if (jToken.Type != JTokenType.Null)
								{
									class176_0[num] = jToken;
								}
							}
						}
						else
						{
							class176_0.Add(item3);
						}
						num++;
					}
					return;
				}
			}
			}
		}
		foreach (JToken item4 in ienumerable_0)
		{
			class176_0.Add(item4);
		}
	}

	static JObject smethod_567(object object_0, Class34 class34_0)
	{
		JToken jToken = Class7.smethod_497(object_0, class34_0);
		if (jToken.Type != JTokenType.Object)
		{
			throw new ArgumentException("Object serialized to {0}. JObject instance expected.".smethod_1(CultureInfo.InvariantCulture, jToken.Type));
		}
		return (JObject)jToken;
	}

	static void smethod_568(Class38 class38_0, JsonContainerType jsonContainerType_0)
	{
		class38_0.method_1(jsonContainerType_0);
	}

	static DateTime smethod_569(Struct1 struct1_0)
	{
		bool flag;
		if (struct1_0.int_3 == 24)
		{
			flag = true;
			struct1_0.int_3 = 0;
		}
		else
		{
			flag = false;
		}
		DateTime result = new DateTime(struct1_0.int_0, struct1_0.int_1, struct1_0.int_2, struct1_0.int_3, struct1_0.int_4, struct1_0.int_5).AddTicks(struct1_0.int_6);
		if (flag)
		{
			result = result.AddDays(1.0);
		}
		return result;
	}

	static object smethod_570(Class24 class24_0, Class29 class29_0)
	{
		string text = (string)class29_0.Value;
		if (text.Length > 0 && text[0] == '/')
		{
			int num = text.LastIndexOf('/');
			if (num > 0)
			{
				string pattern = text.Substring(1, num - 1);
				RegexOptions options = Class7.smethod_138(text.Substring(num + 1));
				return new Regex(pattern, options);
			}
		}
		throw Class7.smethod_161(class29_0, "Regex pattern must be enclosed by slashes.");
	}

	static void smethod_571(Class206.Class218 class218_0)
	{
		class218_0.int_0 = -1;
		if (class218_0.ienumerator_0 != null)
		{
			class218_0.ienumerator_0.Dispose();
		}
	}

	static bool smethod_572(MemberInfo memberInfo_0, bool bool_0, bool bool_1)
	{
		switch (memberInfo_0.smethod_1())
		{
		default:
			return false;
		case MemberTypes.Property:
		{
			PropertyInfo propertyInfo = (PropertyInfo)memberInfo_0;
			if (!propertyInfo.CanWrite)
			{
				return false;
			}
			if (bool_0)
			{
				return true;
			}
			return propertyInfo.GetSetMethod(bool_0) != null;
		}
		case MemberTypes.Field:
		{
			FieldInfo fieldInfo = (FieldInfo)memberInfo_0;
			if (fieldInfo.IsLiteral)
			{
				return false;
			}
			if (fieldInfo.IsInitOnly && !bool_1)
			{
				return false;
			}
			if (bool_0)
			{
				return true;
			}
			if (fieldInfo.IsPublic)
			{
				return true;
			}
			return false;
		}
		}
	}

	static void smethod_573(JsonValidatingReader jsonValidatingReader_0, JsonSchemaModel jsonSchemaModel_0)
	{
		if (jsonSchemaModel_0 == null || !Class7.smethod_238(jsonValidatingReader_0, jsonSchemaModel_0, JsonSchemaType.Float))
		{
			return;
		}
		Class7.smethod_589(jsonValidatingReader_0, jsonSchemaModel_0);
		double num = Convert.ToDouble(jsonValidatingReader_0.class29_0.Value, CultureInfo.InvariantCulture);
		if (jsonSchemaModel_0.Maximum.HasValue)
		{
			if (num > jsonSchemaModel_0.Maximum)
			{
				Class7.smethod_239(jsonValidatingReader_0, "Float {0} exceeds maximum value of {1}.".smethod_2(CultureInfo.InvariantCulture, Class8.smethod_10(num), jsonSchemaModel_0.Maximum), jsonSchemaModel_0);
			}
			if (jsonSchemaModel_0.ExclusiveMaximum && num == jsonSchemaModel_0.Maximum)
			{
				Class7.smethod_239(jsonValidatingReader_0, "Float {0} equals maximum value of {1} and exclusive maximum is true.".smethod_2(CultureInfo.InvariantCulture, Class8.smethod_10(num), jsonSchemaModel_0.Maximum), jsonSchemaModel_0);
			}
		}
		if (jsonSchemaModel_0.Minimum.HasValue)
		{
			if (num < jsonSchemaModel_0.Minimum)
			{
				Class7.smethod_239(jsonValidatingReader_0, "Float {0} is less than minimum value of {1}.".smethod_2(CultureInfo.InvariantCulture, Class8.smethod_10(num), jsonSchemaModel_0.Minimum), jsonSchemaModel_0);
			}
			if (jsonSchemaModel_0.ExclusiveMinimum && num == jsonSchemaModel_0.Minimum)
			{
				Class7.smethod_239(jsonValidatingReader_0, "Float {0} equals minimum value of {1} and exclusive minimum is true.".smethod_2(CultureInfo.InvariantCulture, Class8.smethod_10(num), jsonSchemaModel_0.Minimum), jsonSchemaModel_0);
			}
		}
		if (jsonSchemaModel_0.DivisibleBy.HasValue)
		{
			double? divisibleBy = jsonSchemaModel_0.DivisibleBy;
			double double_ = num;
			double valueOrDefault = divisibleBy.GetValueOrDefault();
			if (!Class7.smethod_240(Class7.smethod_553(valueOrDefault, double_)))
			{
				Class7.smethod_239(jsonValidatingReader_0, "Float {0} is not evenly divisible by {1}.".smethod_2(CultureInfo.InvariantCulture, Class8.smethod_10(num), jsonSchemaModel_0.DivisibleBy), jsonSchemaModel_0);
			}
		}
	}

	static void smethod_574(object object_0, Class29 class29_0, string? string_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, Class137 class137_0)
	{
		try
		{
			throw Class7.smethod_161(class29_0, string_0);
		}
		catch (Exception exception_)
		{
			if (!jsonSerializerInternalReader_0.method_0(object_0, class137_0, null, class29_0 as Interface1, class29_0.Path, exception_))
			{
				throw;
			}
			Class7.smethod_53(class29_0, bool_0: false, jsonSerializerInternalReader_0, 0);
		}
	}

	static Class34 smethod_575()
	{
		return Class7.smethod_58(Class8.DefaultSettings?.Invoke());
	}

	static void smethod_576(Class207.Class219 class219_0)
	{
		class219_0.int_0 = -3;
		((IDisposable)class219_0.enumerator_0).Dispose();
	}

	static bool smethod_577(Struct4 struct4_0, string? string_0, CultureInfo cultureInfo_0, out DateTimeOffset dateTimeOffset_0)
	{
		if (struct4_0.Length > 0)
		{
			int startIndex = struct4_0.StartIndex;
			if (struct4_0[startIndex] == '/')
			{
				if (struct4_0.Length >= 9 && struct4_0.smethod_1("/Date(") && struct4_0.smethod_2(")/") && Class7.smethod_682(struct4_0, out dateTimeOffset_0))
				{
					return true;
				}
			}
			else if (struct4_0.Length >= 19 && struct4_0.Length <= 40 && char.IsDigit(struct4_0[startIndex]) && struct4_0[startIndex + 10] == 'T' && Class7.smethod_460(struct4_0, out dateTimeOffset_0))
			{
				return true;
			}
			if (!Class109.smethod_0(string_0) && Class7.smethod_324(cultureInfo_0, struct4_0.ToString(), ref dateTimeOffset_0, string_0))
			{
				return true;
			}
		}
		dateTimeOffset_0 = default(DateTimeOffset);
		return false;
	}

	static string smethod_578(XObject? xobject_0, Enum7 enum7_0)
	{
		return Class7.smethod_556(enum7_0, xobject_0, bool_0: false);
	}

	static string smethod_579(string? string_0, char char_0)
	{
		return Class7.smethod_270(char_0, string_0, Enum17.const_0);
	}

	static bool smethod_580(JsonSerializerInternalReader jsonSerializerInternalReader_0, Enum4 enum4_0, Enum4 enum4_1)
	{
		return (enum4_0 & enum4_1) == enum4_1;
	}

	static object? smethod_581(Type type_0)
	{
		if (!type_0.smethod_13())
		{
			return null;
		}
		switch (Class7.smethod_524(type_0))
		{
		case Enum21.const_36:
			return default(BigInteger);
		case Enum21.const_4:
			return false;
		case Enum21.const_2:
		case Enum21.const_6:
		case Enum21.const_8:
		case Enum21.const_10:
		case Enum21.const_12:
		case Enum21.const_14:
		case Enum21.const_16:
			return 0;
		case Enum21.const_18:
		case Enum21.const_20:
			return 0L;
		case Enum21.const_22:
			return 0f;
		case Enum21.const_24:
			return 0.0;
		case Enum21.const_26:
			return default(DateTime);
		case Enum21.const_28:
			return default(DateTimeOffset);
		case Enum21.const_30:
			return 0m;
		default:
			if (Class7.smethod_213(type_0))
			{
				return null;
			}
			return Activator.CreateInstance(type_0);
		case Enum21.const_32:
			return default(Guid);
		}
	}

	static ConstructorInfo? smethod_582(Type type_0, Type type_1, Type type_2)
	{
		Type type = typeof(IEnumerable<>).MakeGenericType(type_1);
		ConstructorInfo constructorInfo = null;
		ConstructorInfo[] constructors = type_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
		foreach (ConstructorInfo constructorInfo2 in constructors)
		{
			IList<ParameterInfo> parameters = constructorInfo2.GetParameters();
			if (parameters.Count == 1)
			{
				Type parameterType = parameters[0].ParameterType;
				if (type == parameterType)
				{
					constructorInfo = constructorInfo2;
					break;
				}
				if (constructorInfo == null && parameterType.IsAssignableFrom(type_2))
				{
					constructorInfo = constructorInfo2;
				}
			}
		}
		return constructorInfo;
	}

	static void smethod_583(Class202.Class210 class210_0)
	{
		class210_0.int_0 = -1;
		if (class210_0.ienumerator_0 != null)
		{
			class210_0.ienumerator_0.Dispose();
		}
	}

	static void smethod_584(byte[] byte_0, Class43 class43_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (int_1 < 0)
		{
			throw new ArgumentOutOfRangeException("index");
		}
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (int_0 > byte_0.Length - int_1)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	static void smethod_585(JsonToken jsonToken_0, Class38 class38_0)
	{
		class38_0.method_0(jsonToken_0, null);
	}

	static CallSite<Func<CallSite, object, object?, object>> smethod_586(string string_0)
	{
		return CallSite<Func<CallSite, object, object, object>>.Create(new Class75((SetMemberBinder)Class7.smethod_464(string_0, typeof(Class72))));
	}

	static bool smethod_587(ref int int_0, int int_1, byte[] byte_0, Class43 class43_0)
	{
		int int_2 = class43_0.int_2;
		while (int_2 < 3 && int_0 > 0)
		{
			class43_0.byte_0[int_2++] = byte_0[int_1++];
			int_0--;
		}
		if (int_0 == 0 && int_2 < 3)
		{
			class43_0.int_2 = int_2;
			return true;
		}
		return false;
	}

	static string smethod_588(Class212 class212_0)
	{
		int int_ = class212_0.int_0;
		class212_0.int_0++;
		while (true)
		{
			if (class212_0.int_0 < class212_0.string_0.Length)
			{
				char c = class212_0.string_0[class212_0.int_0];
				if (c == '\\' && class212_0.int_0 + 1 < class212_0.string_0.Length)
				{
					class212_0.int_0 += 2;
					continue;
				}
				if (c == '/')
				{
					break;
				}
				class212_0.int_0++;
				continue;
			}
			throw new JsonException("Path ended with an open regex.");
		}
		class212_0.int_0++;
		while (class212_0.int_0 < class212_0.string_0.Length)
		{
			char c = class212_0.string_0[class212_0.int_0];
			if (!char.IsLetter(c))
			{
				break;
			}
			class212_0.int_0++;
		}
		return class212_0.string_0.Substring(int_, class212_0.int_0 - int_);
	}

	static void smethod_589(JsonValidatingReader jsonValidatingReader_0, JsonSchemaModel jsonSchemaModel_0)
	{
		if (jsonSchemaModel_0 == null)
		{
			return;
		}
		JsonSchemaType? jsonSchemaType = Class7.smethod_52(jsonValidatingReader_0);
		if (jsonSchemaType.HasValue)
		{
			JsonSchemaType? nullable_ = jsonSchemaModel_0.Disallow;
			JsonSchemaType valueOrDefault = jsonSchemaType.GetValueOrDefault();
			if (Class7.smethod_494(valueOrDefault, nullable_))
			{
				Class7.smethod_239(jsonValidatingReader_0, "Type {0} is disallowed.".smethod_1(CultureInfo.InvariantCulture, jsonSchemaType), jsonSchemaModel_0);
			}
		}
	}

	static string smethod_590(TimeSpan timeSpan_0)
	{
		return Class7.smethod_73('"', timeSpan_0);
	}

	static void smethod_591(Class38 class38_0, string string_0)
	{
		class38_0.struct0_0.string_0 = string_0;
		class38_0.method_2(JsonToken.PropertyName);
	}

	static object smethod_592(Class30 class30_0, Enum8 enum8_0)
	{
		return Class7.smethod_14(enum8_0, class30_0, Class7.smethod_346(Class8.string_6, class30_0));
	}

	static Class198 smethod_593(bool bool_0, Class212 class212_0, char char_0)
	{
		class212_0.int_0++;
		char char_ = ((char_0 == '[') ? ']' : ')');
		Class7.smethod_354(class212_0, "Path ended with open indexer.");
		Class7.smethod_611(class212_0);
		if (class212_0.string_0[class212_0.int_0] == '\'')
		{
			return class212_0.method_7(char_, bool_0);
		}
		if (class212_0.string_0[class212_0.int_0] == '?')
		{
			return class212_0.method_3(char_, bool_0);
		}
		return class212_0.method_2(char_);
	}

	static void smethod_594(Interface13 interface13_0, Interface12 interface12_0, Class27 class27_0)
	{
		interface13_0.imethod_1(interface12_0.imethod_12("json:Array", "http://james.newtonking.com/projects/json", "true"));
		if (interface13_0 is Class234 && interface13_0.imethod_2("http://james.newtonking.com/projects/json") == null)
		{
			interface13_0.imethod_1(interface12_0.imethod_12("xmlns:json", "http://www.w3.org/2000/xmlns/", "http://james.newtonking.com/projects/json"));
		}
	}

	static bool[] smethod_595(char char_0, Enum17 enum17_0)
	{
		if (enum17_0 == Enum17.const_2)
		{
			return Class88.bool_2;
		}
		if (char_0 == '"')
		{
			return Class88.bool_1;
		}
		return Class88.bool_0;
	}

	static void smethod_596(JsonProperty jsonProperty_0, Class38 class38_0, Class139 class139_0, Class138? class138_0, IEnumerable? ienumerable_0, JsonProperty? jsonProperty_1, Class152 class152_0)
	{
		object obj = ((ienumerable_0 is Interface2 @interface) ? @interface.UnderlyingCollection : ienumerable_0);
		Class7.smethod_246(class152_0, class38_0, (Class137)class139_0, obj);
		class152_0.list_0.Add(obj);
		bool flag = Class7.smethod_219(class139_0, class38_0, jsonProperty_0, class152_0, jsonProperty_1, class138_0, obj);
		class38_0.vmethod_5();
		int top = class38_0.Top;
		int num = 0;
		foreach (object item in ienumerable_0!)
		{
			try
			{
				Class137 class137_ = class139_0.class137_1 ?? class152_0.method_2(item);
				if (class152_0.method_5(item, null, class137_, class139_0, jsonProperty_0))
				{
					Class7.smethod_712(class38_0, class152_0, item);
				}
				else if (class152_0.method_7(class38_0, item, null, class137_, class139_0, jsonProperty_0))
				{
					class152_0.method_3(class38_0, item, class137_, null, class139_0, jsonProperty_0);
				}
			}
			catch (Exception exception_)
			{
				if (!class152_0.method_0(obj, class139_0, num, null, class38_0.ContainerPath, exception_))
				{
					throw;
				}
				Class7.smethod_176(top, class38_0, class152_0);
			}
			finally
			{
				num++;
			}
		}
		class38_0.vmethod_6();
		if (flag)
		{
			class38_0.vmethod_4();
		}
		class152_0.list_0.RemoveAt(class152_0.list_0.Count - 1);
		Class7.smethod_82(class38_0, class152_0, (Class137)class139_0, obj);
	}

	static Type smethod_597(Struct5<string?, string> struct5_0, Class132 class132_0)
	{
		return class132_0.class111_0.method_0(struct5_0);
	}

	static bool smethod_598(Class30 class30_0)
	{
		while (true)
		{
			char c = class30_0.char_2[class30_0.int_3];
			switch (c)
			{
			default:
				if (char.IsWhiteSpace(c))
				{
					class30_0.int_3++;
					break;
				}
				return Class7.smethod_197(class30_0);
			case '\t':
			case ' ':
				class30_0.int_3++;
				break;
			case '\n':
				Class7.smethod_630(class30_0);
				break;
			case '\r':
				Class7.smethod_287(class30_0, bool_0: false);
				break;
			case '\0':
				if (class30_0.int_2 == class30_0.int_3)
				{
					if (Class7.smethod_418(bool_0: false, class30_0) == 0)
					{
						return false;
					}
				}
				else
				{
					class30_0.int_3++;
				}
				break;
			case '}':
				Class7.smethod_386((Class29)class30_0, JsonToken.EndObject);
				class30_0.int_3++;
				return true;
			case '/':
				Class7.smethod_80(class30_0, bool_0: true);
				return true;
			}
		}
	}

	static string smethod_599(Uri? uri_0)
	{
		if (uri_0 == null)
		{
			return Class8.string_2;
		}
		return Class7.smethod_562(uri_0, '"');
	}

	static Class34 smethod_600()
	{
		return new Class34();
	}

	static void smethod_601(Array array_0, int[] int_0, IList ilist_0)
	{
		int num = int_0.Length;
		if (num == array_0.Rank)
		{
			array_0.SetValue(Class7.smethod_674(int_0, ilist_0), int_0);
			return;
		}
		int length = array_0.GetLength(num);
		if (((IList)Class7.smethod_674(int_0, ilist_0)).Count != length)
		{
			throw new Exception("Cannot deserialize non-cubical array as multidimensional array.");
		}
		int[] array = new int[num + 1];
		for (int i = 0; i < num; i++)
		{
			array[i] = int_0[i];
		}
		for (int j = 0; j < array_0.GetLength(num); j++)
		{
			array[num] = j;
			Class7.smethod_601(array_0, array, ilist_0);
		}
	}

	static int smethod_602(DateTimeOffset dateTimeOffset_0, Class39 class39_0)
	{
		Class7.smethod_654(class39_0);
		int num = 0;
		char[]? char_ = class39_0.char_2;
		num = 1;
		char_[0] = class39_0.char_1;
		num = Class51.smethod_2(class39_0.char_2, 1, (class39_0.enum1_0 == Enum1.const_0) ? dateTimeOffset_0.DateTime : dateTimeOffset_0.UtcDateTime, dateTimeOffset_0.Offset, DateTimeKind.Local, class39_0.enum1_0);
		class39_0.char_2[num++] = class39_0.char_1;
		return num;
	}

	static Array smethod_603(int int_0, Type type_0, IList ilist_0)
	{
		IList<int> list = Class7.smethod_390(ilist_0, int_0);
		while (list.Count < int_0)
		{
			list.Add(0);
		}
		Array array = Array.CreateInstance(type_0, list.ToArray());
		Class7.smethod_601(array, Class45.smethod_10<int>(), ilist_0);
		return array;
	}

	static bool smethod_604(int int_0, bool bool_0, Class30 class30_0)
	{
		if (class30_0.bool_3)
		{
			return false;
		}
		int num = class30_0.int_3 + int_0 - class30_0.int_2 + 1;
		int num2 = 0;
		do
		{
			int num3 = Class7.smethod_249(class30_0, bool_0, num - num2);
			if (num3 == 0)
			{
				break;
			}
			num2 += num3;
		}
		while (num2 < num);
		if (num2 < num)
		{
			return false;
		}
		return true;
	}

	static JToken smethod_605(Class29 class29_0, Class193? class193_0)
	{
		return Class7.smethod_66(class193_0, class29_0);
	}

	static void smethod_606(FieldInfo fieldInfo_0, ILGenerator ilgenerator_0)
	{
		if (!fieldInfo_0.IsStatic)
		{
			ilgenerator_0.smethod_0(fieldInfo_0.DeclaringType);
		}
		ilgenerator_0.Emit(OpCodes.Ldarg_1);
		ilgenerator_0.smethod_3(fieldInfo_0.FieldType);
		if (!fieldInfo_0.IsStatic)
		{
			ilgenerator_0.Emit(OpCodes.Stfld, fieldInfo_0);
		}
		else
		{
			ilgenerator_0.Emit(OpCodes.Stsfld, fieldInfo_0);
		}
		ilgenerator_0.smethod_5();
	}

	static Enum22 smethod_607(char[] char_0, int int_0, int int_1, out int int_2)
	{
		int_2 = 0;
		if (int_1 == 0)
		{
			return Enum22.const_3;
		}
		bool flag;
		if (flag = char_0[int_0] == '-')
		{
			if (int_1 == 1)
			{
				return Enum22.const_3;
			}
			int_0++;
			int_1--;
		}
		int num = int_0 + int_1;
		if (int_1 <= 10 && (int_1 != 10 || char_0[int_0] - 48 <= 2))
		{
			int num2 = int_0;
			while (true)
			{
				if (num2 < num)
				{
					int num3 = char_0[num2] - 48;
					if (num3 < 0 || num3 > 9)
					{
						break;
					}
					int num4 = 10 * int_2 - num3;
					if (num4 <= int_2)
					{
						int_2 = num4;
						num2++;
						continue;
					}
					num2++;
					while (true)
					{
						if (num2 < num)
						{
							num3 = char_0[num2] - 48;
							if (num3 < 0 || num3 > 9)
							{
								break;
							}
							num2++;
							continue;
						}
						return Enum22.const_2;
					}
					return Enum22.const_3;
				}
				if (!flag)
				{
					if (int_2 == int.MinValue)
					{
						return Enum22.const_2;
					}
					int_2 = -int_2;
				}
				return Enum22.const_1;
			}
			return Enum22.const_3;
		}
		int num5 = int_0;
		while (true)
		{
			if (num5 < num)
			{
				int num6 = char_0[num5] - 48;
				if (num6 < 0 || num6 > 9)
				{
					break;
				}
				num5++;
				continue;
			}
			return Enum22.const_2;
		}
		return Enum22.const_3;
	}

	static Class137 smethod_608(JsonSerializerInternalReader jsonSerializerInternalReader_0, Type type_0)
	{
		return jsonSerializerInternalReader_0.class34_0.interface4_0.imethod_0(type_0);
	}

	static JsonException smethod_609(Interface1 interface1_0, string string_0, string string_1)
	{
		string_1 = Struct0.smethod_2(interface1_0, string_0, string_1);
		return new JsonException(string_1);
	}

	static bool smethod_610(int int_0, ref int int_1, char[] char_0, [Out] int int_2)
	{
		int_1 = 0;
		int num = int_0;
		while (true)
		{
			if (num < int_2)
			{
				char c = char_0[num];
				int num2;
				if (c <= '9' && c >= '0')
				{
					num2 = c - 48;
				}
				else if (c <= 'F' && c >= 'A')
				{
					num2 = c - 55;
				}
				else
				{
					if (c > 'f' || c < 'a')
					{
						break;
					}
					num2 = c - 87;
				}
				int_1 += num2 << (int_2 - 1 - num) * 4;
				num++;
				continue;
			}
			return true;
		}
		int_1 = 0;
		return false;
	}

	static void smethod_611(Class212 class212_0)
	{
		while (class212_0.int_0 < class212_0.string_0.Length && class212_0.string_0[class212_0.int_0] == ' ')
		{
			class212_0.int_0++;
		}
	}

	static Class9? smethod_612(Type? type_0, IList<Class9> ilist_0)
	{
		if (ilist_0 != null)
		{
			for (int i = 0; i < ilist_0.Count; i++)
			{
				Class9 @class = ilist_0[i];
				if (@class.vmethod_2(type_0))
				{
					return @class;
				}
			}
		}
		return null;
	}

	static Class177 smethod_613(object object_0, Class34 class34_0)
	{
		JToken jToken = Class7.smethod_497(object_0, class34_0);
		if (jToken.Type != JTokenType.Array)
		{
			throw new ArgumentException("Object serialized to {0}. JArray instance expected.".smethod_1(CultureInfo.InvariantCulture, jToken.Type));
		}
		return (Class177)jToken;
	}

	static void smethod_614(Class32 class32_0, JToken jtoken_0)
	{
		switch (jtoken_0.Type)
		{
		default:
			throw Class7.smethod_740("Type", (object)jtoken_0.Type, "Unexpected JTokenType.");
		case JTokenType.Object:
			Class7.smethod_386((Class29)class32_0, JsonToken.StartObject);
			break;
		case JTokenType.Array:
			Class7.smethod_386((Class29)class32_0, JsonToken.StartArray);
			break;
		case JTokenType.Constructor:
			Class7.smethod_186((Class29)class32_0, JsonToken.StartConstructor, (object)((Class178)jtoken_0).Name);
			break;
		case JTokenType.Property:
			Class7.smethod_186((Class29)class32_0, JsonToken.PropertyName, (object)((JProperty)jtoken_0).Name);
			break;
		case JTokenType.Comment:
			Class7.smethod_186((Class29)class32_0, JsonToken.Comment, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Integer:
			Class7.smethod_186((Class29)class32_0, JsonToken.Integer, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Float:
			Class7.smethod_186((Class29)class32_0, JsonToken.Float, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.String:
			Class7.smethod_186((Class29)class32_0, JsonToken.String, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Boolean:
			Class7.smethod_186((Class29)class32_0, JsonToken.Boolean, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Null:
			Class7.smethod_186((Class29)class32_0, JsonToken.Null, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Undefined:
			Class7.smethod_186((Class29)class32_0, JsonToken.Undefined, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Date:
		{
			object obj = ((Class179)jtoken_0).Value;
			if (obj is DateTime dateTime_)
			{
				obj = Class7.smethod_517(dateTime_, class32_0.enum3_0);
			}
			Class7.smethod_186((Class29)class32_0, JsonToken.Date, obj);
			break;
		}
		case JTokenType.Raw:
			Class7.smethod_186((Class29)class32_0, JsonToken.Raw, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Bytes:
			Class7.smethod_186((Class29)class32_0, JsonToken.Bytes, ((Class179)jtoken_0).Value);
			break;
		case JTokenType.Guid:
			Class7.smethod_186((Class29)class32_0, JsonToken.String, (object)class32_0.method_3(((Class179)jtoken_0).Value));
			break;
		case JTokenType.Uri:
		{
			object value = ((Class179)jtoken_0).Value;
			Class7.smethod_186((Class29)class32_0, JsonToken.String, (object)((value is Uri uri) ? uri.OriginalString : class32_0.method_3(value)));
			break;
		}
		case JTokenType.TimeSpan:
			Class7.smethod_186((Class29)class32_0, JsonToken.String, (object)class32_0.method_3(((Class179)jtoken_0).Value));
			break;
		}
	}

	static IEnumerable<JToken> smethod_615(Class195 class195_0, string? string_0, JToken jtoken_0)
	{
		return Class7.smethod_60(jtoken_0, class195_0, jtoken_0, new Class212(string_0));
	}

	static JsonProperty? smethod_616(Class150 class150_0, string string_0)
	{
		JsonProperty jsonProperty = Class7.smethod_482(StringComparison.Ordinal, string_0, class150_0);
		if (jsonProperty == null)
		{
			jsonProperty = Class7.smethod_482(StringComparison.OrdinalIgnoreCase, string_0, class150_0);
		}
		return jsonProperty;
	}

	static JsonSchema smethod_617(Class164 class164_0, JToken jtoken_0)
	{
		if (!(jtoken_0 is JObject jObject))
		{
			throw Class7.smethod_609((Interface1)jtoken_0, jtoken_0.Path, "Expected object while parsing schema object, got {0}.".smethod_1(CultureInfo.InvariantCulture, jtoken_0.Type));
		}
		if (jObject.System_002ECollections_002EGeneric_002EIDictionary_003CSystem_002EString_002CNewtonsoft_002EJson_002ELinq_002EJToken_003E_002ETryGetValue("$ref", out var value))
		{
			return new JsonSchema
			{
				DeferredReference = JToken.smethod_19(value)
			};
		}
		string text = jtoken_0.Path.Replace(".", "/").Replace("[", "/").Replace("]", string.Empty);
		if (!Class109.smethod_0(text))
		{
			text = "/" + text;
		}
		text = "#" + text;
		if (class164_0.idictionary_0.TryGetValue(text, out var value2))
		{
			return value2;
		}
		Class7.smethod_72(class164_0, new JsonSchema
		{
			Location = text
		});
		Class7.smethod_387(jObject, class164_0);
		return Class7.smethod_538(class164_0);
	}

	static void smethod_618(Class164 class164_0, JToken jtoken_0)
	{
		IList<JsonSchema> list = new List<JsonSchema>();
		if (jtoken_0.Type == JTokenType.Array)
		{
			foreach (JToken item in (IEnumerable<JToken>)jtoken_0)
			{
				list.Add(Class7.smethod_617(class164_0, item));
			}
		}
		else
		{
			JsonSchema jsonSchema = Class7.smethod_617(class164_0, jtoken_0);
			if (jsonSchema != null)
			{
				list.Add(jsonSchema);
			}
		}
		if (list.Count > 0)
		{
			class164_0.jsonSchema_0.Extends = list;
		}
	}

	static void smethod_619(bool bool_0, MemberInfo memberInfo_0, DefaultContractResolver defaultContractResolver_0, JsonProperty jsonProperty_0)
	{
		DefaultContractResolver.Class130 CS_0024_003C_003E8__locals0 = new DefaultContractResolver.Class130();
		MemberInfo memberInfo = memberInfo_0.DeclaringType!.GetProperty(memberInfo_0.Name + "Specified", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (memberInfo == null)
		{
			memberInfo = memberInfo_0.DeclaringType!.GetField(memberInfo_0.Name + "Specified", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		}
		if (!(memberInfo == null) && !(Class7.smethod_632(memberInfo) != typeof(bool)))
		{
			CS_0024_003C_003E8__locals0.func_0 = JsonTypeReflector.ReflectionDelegateFactory.method_0<object>(memberInfo);
			jsonProperty_0.GetIsSpecified = (object object_0) => (bool)CS_0024_003C_003E8__locals0.func_0(object_0);
			if (Class7.smethod_572(memberInfo, bool_0, bool_1: false))
			{
				jsonProperty_0.SetIsSpecified = JsonTypeReflector.ReflectionDelegateFactory.method_1<object>(memberInfo);
			}
		}
	}

	static long smethod_620(DateTime dateTime_0, bool bool_0)
	{
		return ((bool_0 ? Class7.smethod_477(dateTime_0) : dateTime_0.Ticks) - Class51.long_0) / 10000L;
	}

	static void smethod_621(Class29 class29_0, bool bool_0)
	{
		if (class29_0.struct0_0.jsonContainerType_0 == JsonContainerType.None && !class29_0.SupportMultipleContent)
		{
			Class7.smethod_54(class29_0);
		}
		else
		{
			class29_0.state_0 = Class29.State.PostValue;
		}
		if (bool_0)
		{
			Class7.smethod_388(class29_0);
		}
	}

	static ConstructorInfo? smethod_622(Type type_0, Type type_1)
	{
		Type type_2 = typeof(IList<>).MakeGenericType(type_0);
		return Class7.smethod_582(type_1, type_0, type_2);
	}

	static ConstructorInfo? smethod_623(DefaultContractResolver defaultContractResolver_0, Type type_0)
	{
		IEnumerator<ConstructorInfo> enumerator = (from constructorInfo_0 in type_0.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
			where constructorInfo_0.IsDefined(typeof(Attribute9), inherit: true)
			select constructorInfo_0).GetEnumerator();
		if (enumerator.MoveNext())
		{
			ConstructorInfo current = enumerator.Current;
			if (enumerator.MoveNext())
			{
				throw new JsonException("Multiple constructors with the JsonConstructorAttribute.");
			}
			return current;
		}
		if (type_0 == typeof(Version))
		{
			return type_0.GetConstructor(new Type[4]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			});
		}
		return null;
	}

	static string smethod_624(JsonSchemaType jsonSchemaType_0)
	{
		Class164.Class165 CS_0024_003C_003E8__locals0 = new Class164.Class165();
		CS_0024_003C_003E8__locals0.jsonSchemaType_0 = jsonSchemaType_0;
		return Class166.idictionary_0.Single((KeyValuePair<string, JsonSchemaType> keyValuePair_0) => keyValuePair_0.Value == CS_0024_003C_003E8__locals0.jsonSchemaType_0).Key;
	}

	static JToken smethod_625(bool? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static JObject smethod_626(Class29 class29_0, Class193? class193_0)
	{
		Class113.smethod_0(class29_0, "reader");
		if (class29_0.TokenType == JsonToken.None && !class29_0.vmethod_0())
		{
			throw Class7.smethod_555(class29_0, "Error reading JObject from JsonReader.");
		}
		Class7.smethod_407(class29_0);
		if (class29_0.TokenType != JsonToken.StartObject)
		{
			throw Class7.smethod_555(class29_0, "Error reading JObject from JsonReader. Current JsonReader item is not an object: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		}
		JObject jObject = new JObject();
		jObject.method_5(class29_0 as Interface1, class193_0);
		Class7.smethod_644((Class176)jObject, class29_0, class193_0);
		return jObject;
	}

	static bool smethod_627(Class201 class201_0, int int_0, int int_1, bool bool_0)
	{
		if (bool_0)
		{
			return int_0 < int_1;
		}
		return int_0 > int_1;
	}

	static bool smethod_628(string string_0, Class29 class29_0, JsonSerializerInternalReader jsonSerializerInternalReader_0)
	{
		if (jsonSerializerInternalReader_0.class34_0.MetadataPropertyHandling == Enum10.const_1)
		{
			switch (string_0)
			{
			case "$id":
			case "$ref":
			case "$type":
			case "$values":
				Class7.smethod_310(class29_0);
				return true;
			}
		}
		return false;
	}

	static bool smethod_629(object object_0)
	{
		switch (Class7.smethod_524(object_0.GetType()))
		{
		default:
			return false;
		case Enum21.const_6:
		case Enum21.const_8:
		case Enum21.const_10:
		case Enum21.const_12:
		case Enum21.const_14:
		case Enum21.const_16:
		case Enum21.const_18:
		case Enum21.const_20:
			return true;
		}
	}

	static void smethod_630(Class30 class30_0)
	{
		class30_0.int_3++;
		Class7.smethod_561(class30_0, class30_0.int_3);
	}

	static void smethod_631(Class176 class176_0, object? object_0, Class194 class194_0)
	{
		class176_0.vmethod_23(object_0, class194_0);
	}

	static Type smethod_632(MemberInfo memberInfo_0)
	{
		Class113.smethod_0(memberInfo_0, "member");
		return memberInfo_0.smethod_1() switch
		{
			MemberTypes.Field => ((FieldInfo)memberInfo_0).FieldType, 
			MemberTypes.Event => ((EventInfo)memberInfo_0).EventHandlerType, 
			MemberTypes.Property => ((PropertyInfo)memberInfo_0).PropertyType, 
			MemberTypes.Method => ((MethodInfo)memberInfo_0).ReturnType, 
			_ => throw new ArgumentException("MemberInfo must be of type FieldInfo, PropertyInfo, EventInfo or MethodInfo", "member"), 
		};
	}

	static int smethod_633(Class33 class33_0, int int_0)
	{
		int num = int_0;
		int num2 = 0;
		for (; num >= 0; num--)
		{
			num2 = Class7.smethod_385(class33_0, class33_0.byte_4[num]);
			switch (num2)
			{
			case 0:
				continue;
			default:
				num--;
				break;
			case 1:
				break;
			}
			break;
		}
		if (num2 == int_0 - num)
		{
			return int_0;
		}
		return num;
	}

	static IEnumerable<JToken> smethod_634(JToken jtoken_0)
	{
		return Class7.smethod_45(bool_0: false, jtoken_0);
	}

	static bool smethod_635(Type type_0)
	{
		if (Class7.smethod_35(type_0))
		{
			return true;
		}
		if (!(type_0.Name == "FSharpSet`1") && !(type_0.Name == "FSharpMap`2"))
		{
			return false;
		}
		return true;
	}

	static int? smethod_636(StringComparison stringComparison_0, string[] string_0, int int_0, int int_1, string string_1)
	{
		int num = 0;
		while (true)
		{
			if (num < string_0.Length)
			{
				if (string_0[num].Length == int_1 && string.Compare(string_0[num], 0, string_1, int_0, int_1, stringComparison_0) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return num;
	}

	static JToken smethod_637(Class29 class29_0)
	{
		return Class7.smethod_605(class29_0, (Class193?)null);
	}

	static void smethod_638(JsonSchema jsonSchema_0, JsonSchemaNode jsonSchemaNode_0, Class170 class170_0)
	{
		jsonSchemaNode_0.AdditionalProperties = Class7.smethod_503(jsonSchemaNode_0.AdditionalProperties, class170_0, jsonSchema_0);
	}

	static Interface5 smethod_639(Class34 class34_0)
	{
		if (class34_0.interface5_0 == null)
		{
			class34_0.interface5_0 = new Class131();
		}
		return class34_0.interface5_0;
	}

	static int smethod_640(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (int)bigInteger;
			}
			return Convert.ToInt32(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int32.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static string smethod_641(XmlNode? xmlNode_0, Enum7 enum7_0)
	{
		Class27 @class = new Class27();
		return Class8.smethod_19(xmlNode_0, enum7_0, @class);
	}

	static MethodInfo smethod_642(Type type_0, string string_0, BindingFlags bindingFlags_0)
	{
		MethodInfo method = type_0.GetMethod(string_0, bindingFlags_0);
		if (method == null && (bindingFlags_0 & BindingFlags.NonPublic) != BindingFlags.NonPublic)
		{
			method = type_0.GetMethod(string_0, bindingFlags_0 | BindingFlags.NonPublic);
		}
		return method;
	}

	static void smethod_643(JsonSchemaWriter jsonSchemaWriter_0, JsonSchema jsonSchema_0)
	{
		if (jsonSchema_0.Items == null && !jsonSchema_0.PositionalItemsValidation)
		{
			return;
		}
		jsonSchemaWriter_0.class38_0.vmethod_9("items");
		if (!jsonSchema_0.PositionalItemsValidation)
		{
			if (jsonSchema_0.Items != null && jsonSchema_0.Items.Count > 0)
			{
				Class7.smethod_162(jsonSchemaWriter_0, jsonSchema_0.Items[0]);
				return;
			}
			jsonSchemaWriter_0.class38_0.vmethod_3();
			jsonSchemaWriter_0.class38_0.vmethod_4();
			return;
		}
		jsonSchemaWriter_0.class38_0.vmethod_5();
		if (jsonSchema_0.Items != null)
		{
			foreach (JsonSchema item in jsonSchema_0.Items)
			{
				Class7.smethod_162(jsonSchemaWriter_0, item);
			}
		}
		jsonSchemaWriter_0.class38_0.vmethod_6();
	}

	static void smethod_644(Class176 class176_0, Class29? class29_0, Class193 class193_0)
	{
		int depth = class29_0!.Depth;
		if (!class29_0!.vmethod_0())
		{
			throw Class7.smethod_555(class29_0, "Error reading {0} from JsonReader.".smethod_1(CultureInfo.InvariantCulture, class176_0.GetType().Name));
		}
		Class7.smethod_548(class176_0, class29_0, class193_0);
		if (class29_0!.Depth > depth)
		{
			throw Class7.smethod_555(class29_0, "Unexpected end of content while loading {0}.".smethod_1(CultureInfo.InvariantCulture, class176_0.GetType().Name));
		}
	}

	static void smethod_645(FieldMultipleFilter.Class211 class211_0)
	{
		class211_0.int_0 = -1;
		if (class211_0.ienumerator_0 != null)
		{
			class211_0.ienumerator_0.Dispose();
		}
	}

	static JsonToken smethod_646(Class38 class38_0, JsonContainerType jsonContainerType_0)
	{
		return jsonContainerType_0 switch
		{
			JsonContainerType.Object => JsonToken.EndObject, 
			JsonContainerType.Array => JsonToken.EndArray, 
			JsonContainerType.Constructor => JsonToken.EndConstructor, 
			_ => throw Class7.smethod_188(class38_0, "No close token for type: " + jsonContainerType_0, (Exception?)null), 
		};
	}

	static void smethod_647(JObject.Class188 class188_0)
	{
		class188_0.int_0 = -1;
		if (class188_0.ienumerator_0 != null)
		{
			class188_0.ienumerator_0.Dispose();
		}
	}

	static Class100 smethod_648(Type type_0)
	{
		Type[] genericArguments = type_0.GetGenericArguments();
		Type type = ((IList<Type>)genericArguments)[0];
		Type type2 = ((IList<Type>)genericArguments)[1];
		return Class7.smethod_81(type_0, (MethodBase?)type_0.GetConstructor(new Type[2] { type, type2 }), new string[2] { "Key", "Value" });
	}

	static void smethod_649(Class29 class29_0, Class27 class27_0, string string_0, Interface12 interface12_0, Interface11 interface11_0)
	{
		if (string_0 == "?xml")
		{
			string string_ = null;
			string string_2 = null;
			string string_3 = null;
			while (class29_0.vmethod_0() && class29_0.TokenType != JsonToken.EndObject)
			{
				switch (class29_0.Value?.ToString())
				{
				case "@standalone":
					Class7.smethod_686(class29_0);
					string_3 = Class7.smethod_462(class29_0);
					break;
				case "@encoding":
					Class7.smethod_686(class29_0);
					string_2 = Class7.smethod_462(class29_0);
					break;
				case "@version":
					Class7.smethod_686(class29_0);
					string_ = Class7.smethod_462(class29_0);
					break;
				default:
					throw Class7.smethod_161(class29_0, "Unexpected property name encountered while deserializing XmlDeclaration: " + class29_0.Value);
				}
			}
			Interface11 interface11_ = interface12_0.imethod_6(string_, string_2, string_3);
			interface11_0.imethod_0(interface11_);
		}
		else
		{
			Interface11 interface11_2 = interface12_0.imethod_8(string_0.Substring(1), Class7.smethod_462(class29_0));
			interface11_0.imethod_0(interface11_2);
		}
	}

	static string smethod_650(Class33 class33_0)
	{
		class33_0.bsonType_0 = Class7.smethod_361(class33_0);
		return Class7.smethod_23(class33_0);
	}

	static JToken smethod_651(decimal? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static void smethod_652(Class33 class33_0)
	{
		class33_0.list_1.RemoveAt(class33_0.list_1.Count - 1);
		if (class33_0.list_1.Count == 0)
		{
			class33_0.class241_0 = null;
		}
		else
		{
			class33_0.class241_0 = class33_0.list_1[class33_0.list_1.Count - 1];
		}
	}

	static Func<object[]?, object> smethod_653(Type type_0)
	{
		JsonTypeReflector.Class156 CS_0024_003C_003E8__locals0 = new JsonTypeReflector.Class156();
		CS_0024_003C_003E8__locals0.type_0 = type_0;
		CS_0024_003C_003E8__locals0.func_0 = (Class7.smethod_179(CS_0024_003C_003E8__locals0.type_0, bool_0: false) ? JsonTypeReflector.ReflectionDelegateFactory.vmethod_2<object>(CS_0024_003C_003E8__locals0.type_0) : null);
		return delegate(object[]? object_0)
		{
			try
			{
				if (object_0 != null)
				{
					Type[] types = object_0.Select(delegate(object object_0)
					{
						if (object_0 == null)
						{
							throw new InvalidOperationException("Cannot pass a null parameter to the constructor.");
						}
						return object_0.GetType();
					}).ToArray();
					ConstructorInfo constructor = CS_0024_003C_003E8__locals0.type_0.GetConstructor(types);
					if (!(constructor != null))
					{
						throw new JsonException("No matching parameterized constructor found for '{0}'.".smethod_1(CultureInfo.InvariantCulture, CS_0024_003C_003E8__locals0.type_0));
					}
					return JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(constructor)(object_0);
				}
				if (CS_0024_003C_003E8__locals0.func_0 == null)
				{
					throw new JsonException("No parameterless constructor defined for '{0}'.".smethod_1(CultureInfo.InvariantCulture, CS_0024_003C_003E8__locals0.type_0));
				}
				return CS_0024_003C_003E8__locals0.func_0();
			}
			catch (Exception innerException)
			{
				throw new JsonException("Error creating '{0}'.".smethod_1(CultureInfo.InvariantCulture, CS_0024_003C_003E8__locals0.type_0), innerException);
			}
		};
	}

	static void smethod_654(Class39 class39_0)
	{
		if (class39_0.char_2 == null)
		{
			class39_0.char_2 = Class87.smethod_0(class39_0.interface0_0, 35);
		}
	}

	static string smethod_655(char char_0)
	{
		return Class7.smethod_323(char.ToString(char_0));
	}

	static JToken smethod_656(float float_0)
	{
		return new Class179(float_0);
	}

	static void smethod_657(Class38 class38_0, object object_0, Class137 class137_0, JsonProperty jsonProperty_0, Class138? class138_0, Class152? class152_0, Class9 class9_0)
	{
		if (class152_0!.method_5(object_0, null, class137_0, class138_0, jsonProperty_0))
		{
			Class7.smethod_712(class38_0, class152_0, object_0);
		}
		else if (class152_0!.method_7(class38_0, object_0, null, class137_0, class138_0, jsonProperty_0))
		{
			class152_0!.list_0.Add(object_0);
			if (class152_0!.interface7_0 != null && class152_0!.interface7_0!.LevelFilter >= TraceLevel.Info)
			{
				class152_0!.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(null, class38_0.Path, "Started serializing {0} with converter {1}.".smethod_2(CultureInfo.InvariantCulture, object_0.GetType(), class9_0.GetType())), null);
			}
			class9_0.vmethod_0(class38_0, object_0, Class7.smethod_438(class152_0));
			if (class152_0!.interface7_0 != null && class152_0!.interface7_0!.LevelFilter >= TraceLevel.Info)
			{
				class152_0!.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(null, class38_0.Path, "Finished serializing {0} with converter {1}.".smethod_2(CultureInfo.InvariantCulture, object_0.GetType(), class9_0.GetType())), null);
			}
			class152_0!.list_0.RemoveAt(class152_0!.list_0.Count - 1);
		}
	}

	static bool smethod_658(ref Version version_0, [Out][Attribute1(true)] string? string_0)
	{
		return Version.TryParse(string_0, out version_0);
	}

	static JToken? smethod_659(string string_0, bool bool_0, JToken jtoken_0)
	{
		Class195 class195_ = (bool_0 ? new Class195
		{
			ErrorWhenNoMatch = true
		} : null);
		return jtoken_0.method_6(string_0, class195_);
	}

	static string smethod_660(double double_0, string string_0)
	{
		if (!double.IsNaN(double_0) && !double.IsInfinity(double_0) && string_0.IndexOf('.') == -1 && string_0.IndexOf('E') == -1 && string_0.IndexOf('e') == -1)
		{
			return string_0 + ".0";
		}
		return string_0;
	}

	static bool smethod_661(string string_0, out Guid guid_0)
	{
		return Guid.TryParseExact(string_0, "D", out guid_0);
	}

	static void smethod_662(Regex regex_0, Class42 class42_0, Class24 class24_0)
	{
		string text = null;
		if (Class7.smethod_706(class24_0, regex_0.Options, RegexOptions.IgnoreCase))
		{
			text += "i";
		}
		if (Class7.smethod_706(class24_0, regex_0.Options, RegexOptions.Multiline))
		{
			text += "m";
		}
		if (Class7.smethod_706(class24_0, regex_0.Options, RegexOptions.Singleline))
		{
			text += "s";
		}
		text += "u";
		if (Class7.smethod_706(class24_0, regex_0.Options, RegexOptions.ExplicitCapture))
		{
			text += "x";
		}
		Class7.smethod_147(class42_0, regex_0.ToString(), text);
	}

	static bool smethod_663(Type type_0, Class24 class24_0)
	{
		return type_0 == typeof(Regex);
	}

	static void smethod_664(JToken jtoken_0, JToken jtoken_1)
	{
		if (jtoken_0.class176_0 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		jtoken_0.class176_0!.vmethod_19(jtoken_0, jtoken_1);
	}

	static void smethod_665(Class39 class39_0, int int_0)
	{
		if (int_0 >= 0 && int_0 <= 9)
		{
			class39_0.textWriter_0.Write((char)(48 + int_0));
			return;
		}
		bool flag = int_0 < 0;
		Class7.smethod_146(class39_0, (uint)(flag ? (-int_0) : int_0), flag);
	}

	static JToken smethod_666(DateTimeOffset? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static Delegate7<object> smethod_667(FSharpUtils fsharpUtils_0, Type type_0)
	{
		MethodInfo methodBase_ = fsharpUtils_0.methodInfo_0.MakeGenericMethod(type_0);
		return JsonTypeReflector.ReflectionDelegateFactory.vmethod_1(methodBase_);
	}

	static Class179 smethod_668(string? string_0)
	{
		return new Class179(string_0, JTokenType.String);
	}

	static bool smethod_669(int int_0, Struct4 struct4_0, out TimeSpan timeSpan_0)
	{
		bool flag = struct4_0[int_0] == '-';
		if (Class7.smethod_607(struct4_0.Chars, int_0 + 1, 2, out int int_) != Enum22.const_1)
		{
			timeSpan_0 = default(TimeSpan);
			return false;
		}
		int int_2 = 0;
		if (struct4_0.Length - int_0 > 5 && Class7.smethod_607(struct4_0.Chars, int_0 + 3, 2, out int_2) != Enum22.const_1)
		{
			timeSpan_0 = default(TimeSpan);
			return false;
		}
		timeSpan_0 = TimeSpan.FromHours(int_) + TimeSpan.FromMinutes(int_2);
		if (flag)
		{
			timeSpan_0 = timeSpan_0.Negate();
		}
		return true;
	}

	static bool smethod_670(PropertyInfo propertyInfo_0)
	{
		Class113.smethod_0(propertyInfo_0, "property");
		return propertyInfo_0.GetIndexParameters().Length != 0;
	}

	static ConstructorInfo smethod_671(Type type_0)
	{
		return Class7.smethod_189(type_0, bool_0: false);
	}

	static void smethod_672(JsonSchema jsonSchema_0, Class38 class38_0)
	{
		Class7.smethod_16(new Class172(), class38_0, jsonSchema_0);
	}

	static int smethod_673(JsonContainerType jsonContainerType_0, Class38 class38_0)
	{
		int num = 0;
		if (class38_0.struct0_0.jsonContainerType_0 == jsonContainerType_0)
		{
			num = 1;
		}
		else
		{
			int num2 = class38_0.Top - 2;
			int num3 = num2;
			while (num3 >= 0)
			{
				int index = num2 - num3;
				if (class38_0.list_0![index].jsonContainerType_0 != jsonContainerType_0)
				{
					num3--;
					continue;
				}
				num = num3 + 2;
				break;
			}
		}
		if (num == 0)
		{
			throw Class7.smethod_188(class38_0, "No token to close.", (Exception?)null);
		}
		return num;
	}

	static object smethod_674(int[] int_0, IList ilist_0)
	{
		IList list = ilist_0;
		int num = 0;
		int index;
		while (true)
		{
			if (num < int_0.Length)
			{
				index = int_0[num];
				if (num == int_0.Length - 1)
				{
					break;
				}
				list = (IList)list[index];
				num++;
				continue;
			}
			return list;
		}
		return list[index];
	}

	static object smethod_675(JsonProperty jsonProperty_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, string? string_0, Class141? class141_0, Class29 class29_0)
	{
		if (!class141_0!.bool_5)
		{
			throw Class7.smethod_161(class29_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_1(CultureInfo.InvariantCulture, class141_0!.UnderlyingType));
		}
		if (class141_0!.DefaultCreator != null && (!class141_0!.DefaultCreatorNonPublic || jsonSerializerInternalReader_0.class34_0.enum0_0 == Enum0.const_1))
		{
			IDynamicMetaObjectProvider dynamicMetaObjectProvider = (IDynamicMetaObjectProvider)class141_0!.DefaultCreator!();
			if (string_0 != null)
			{
				Class7.smethod_398((object)dynamicMetaObjectProvider, jsonSerializerInternalReader_0, string_0, class29_0);
			}
			Class7.smethod_208(jsonSerializerInternalReader_0, class29_0, (Class137)class141_0, (object)dynamicMetaObjectProvider);
			int depth = class29_0.Depth;
			bool flag = false;
			do
			{
				JsonToken tokenType = class29_0.TokenType;
				if (tokenType == JsonToken.PropertyName)
				{
					string text = class29_0.Value!.ToString();
					try
					{
						if (!class29_0.vmethod_0())
						{
							throw Class7.smethod_161(class29_0, "Unexpected end when setting {0}'s value.".smethod_1(CultureInfo.InvariantCulture, text));
						}
						JsonProperty jsonProperty = Class7.smethod_616(class141_0!.Properties, text);
						if (jsonProperty != null && jsonProperty.Writable && !jsonProperty.Ignored)
						{
							if (jsonProperty.PropertyContract == null)
							{
								jsonProperty.PropertyContract = jsonSerializerInternalReader_0.method_1(jsonProperty.type_0);
							}
							Class9 class9_ = jsonSerializerInternalReader_0.method_5(jsonProperty.PropertyContract, jsonProperty.Converter, null, null);
							if (!Class7.smethod_215((object)dynamicMetaObjectProvider, class29_0, (Class138?)null, jsonSerializerInternalReader_0, jsonProperty, class9_, jsonProperty_0))
							{
								Class7.smethod_310(class29_0);
							}
						}
						else
						{
							Type type_ = (Class7.smethod_397(class29_0.TokenType) ? class29_0.ValueType : typeof(IDynamicMetaObjectProvider));
							Class137 class137_ = jsonSerializerInternalReader_0.method_1(type_);
							Class9 @class = jsonSerializerInternalReader_0.method_5(class137_, null, null, jsonProperty_0);
							object object_ = ((@class == null || !@class.CanRead) ? jsonSerializerInternalReader_0.method_4(class29_0, type_, class137_, null, null, jsonProperty_0, null) : Class7.smethod_716(jsonSerializerInternalReader_0, @class, class29_0, type_, (object)null));
							Class7.smethod_487(class141_0, dynamicMetaObjectProvider, text, object_);
						}
					}
					catch (Exception exception_)
					{
						if (!jsonSerializerInternalReader_0.method_0(dynamicMetaObjectProvider, class141_0, text, class29_0 as Interface1, class29_0.Path, exception_))
						{
							throw;
						}
						Class7.smethod_53(class29_0, bool_0: true, jsonSerializerInternalReader_0, depth);
					}
				}
				else
				{
					if (tokenType != JsonToken.EndObject)
					{
						throw Class7.smethod_161(class29_0, "Unexpected token when deserializing object: " + class29_0.TokenType);
					}
					flag = true;
				}
			}
			while (!flag && class29_0.vmethod_0());
			if (!flag)
			{
				Class7.smethod_574((object)dynamicMetaObjectProvider, class29_0, "Unexpected end when deserializing object.", jsonSerializerInternalReader_0, (Class137)class141_0);
			}
			Class7.smethod_296(jsonSerializerInternalReader_0, class29_0, (Class137)class141_0, (object)dynamicMetaObjectProvider);
			return dynamicMetaObjectProvider;
		}
		throw Class7.smethod_161(class29_0, "Unable to find a default constructor to use for type {0}.".smethod_1(CultureInfo.InvariantCulture, class141_0!.UnderlyingType));
	}

	static bool smethod_676(Class34 class34_0)
	{
		return class34_0.nullable_8.HasValue;
	}

	static int smethod_677(Class38 class38_0, Class29 class29_0)
	{
		JsonToken tokenType = class29_0.TokenType;
		if (tokenType == JsonToken.None)
		{
			return -1;
		}
		if (!Class7.smethod_471(tokenType))
		{
			return class29_0.Depth;
		}
		return class29_0.Depth - 1;
	}

	static Class38.State[][] smethod_678()
	{
		List<Class38.State[]> list = Class38.state_1.ToList();
		Class38.State[] item = Class38.state_1[0];
		Class38.State[] item2 = Class38.state_1[7];
		ulong[] ulong_ = Class7.smethod_389(typeof(JsonToken)).ulong_0;
		foreach (ulong num in ulong_)
		{
			if (list.Count <= (int)num)
			{
				JsonToken jsonToken = (JsonToken)num;
				if ((uint)(jsonToken - 7) > 5u && (uint)(jsonToken - 16) > 1u)
				{
					list.Add(item);
				}
				else
				{
					list.Add(item2);
				}
			}
		}
		return list.ToArray();
	}

	static void smethod_679(Class30 class30_0, char char_0, Enum8 enum8_0)
	{
		class30_0.int_3++;
		Class7.smethod_38(class30_0);
		class30_0.method_7(char_0);
		Class7.smethod_139(enum8_0, class30_0, char_0);
	}

	static JToken smethod_680(Class29 class29_0)
	{
		return Class7.smethod_66((Class193)null, class29_0);
	}

	static JToken smethod_681(TimeSpan timeSpan_0)
	{
		return new Class179(timeSpan_0);
	}

	static bool smethod_682(Struct4 struct4_0, out DateTimeOffset dateTimeOffset_0)
	{
		long long_ = default(long);
		if (!Class7.smethod_337(ref long_, struct4_0, out DateTimeKind _, out TimeSpan timeSpan_))
		{
			dateTimeOffset_0 = default(DateTime);
			return false;
		}
		dateTimeOffset_0 = new DateTimeOffset(new DateTime(long_ * 10000L + Class51.long_0, DateTimeKind.Utc).Add(timeSpan_).Ticks, timeSpan_);
		return true;
	}

	static Class20.Class220 smethod_683(Type type_0)
	{
		Class20.Class220 @class = new Class20.Class220((Class80)FSharpUtils.fsharpUtils_0!.PreComputeUnionTagReader(null, type_0, null), new List<Class20.Class221>());
		object[] array = (object[])FSharpUtils.fsharpUtils_0!.GetUnionCases(null, type_0, null);
		foreach (object obj in array)
		{
			Class20.Class221 item = new Class20.Class221((int)FSharpUtils.fsharpUtils_0!.GetUnionCaseInfoTag(obj), (string)FSharpUtils.fsharpUtils_0!.GetUnionCaseInfoName(obj), (PropertyInfo[])FSharpUtils.fsharpUtils_0!.GetUnionCaseInfoFields(obj), (Class80)FSharpUtils.fsharpUtils_0!.PreComputeUnionReader(null, obj, null), (Class80)FSharpUtils.fsharpUtils_0!.PreComputeUnionConstructor(null, obj, null));
			@class.list_0.Add(item);
		}
		return @class;
	}

	static string? smethod_684(string string_0)
	{
		string string_ = default(string);
		Class7.smethod_370(ref string_, out string string_2, string_0);
		return string_2;
	}

	static Struct0 smethod_685(int int_0, Class29 class29_0)
	{
		if (class29_0.list_0 != null && int_0 < class29_0.list_0!.Count)
		{
			return class29_0.list_0![int_0];
		}
		return class29_0.struct0_0;
	}

	static void smethod_686(Class29 class29_0)
	{
		if (!class29_0.vmethod_0())
		{
			throw Class7.smethod_161(class29_0, "Unexpected end when reading JSON.");
		}
	}

	static bool smethod_687(JsonToken jsonToken_0)
	{
		if ((uint)(jsonToken_0 - 1) <= 2u)
		{
			return true;
		}
		return false;
	}

	static object? smethod_688(JsonProperty jsonProperty_0, Class29? class29_0, Class143 class143_0, JsonSerializerInternalReader jsonSerializerInternalReader_0)
	{
		if (class143_0.bool_7)
		{
			return Class7.smethod_680(class29_0);
		}
		return jsonSerializerInternalReader_0.method_4(class29_0, null, null, null, class143_0, jsonProperty_0, null);
	}

	static JToken smethod_689(int? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static Class213 smethod_690(Class212 class212_0)
	{
		Class213 @class = null;
		Class214 class2 = null;
		Class215 class3;
		while (true)
		{
			if (class212_0.int_0 < class212_0.string_0.Length)
			{
				object object_ = Class7.smethod_234(class212_0);
				object object_2 = null;
				Enum33 enum33_;
				if (class212_0.string_0[class212_0.int_0] != ')' && class212_0.string_0[class212_0.int_0] != '|' && class212_0.string_0[class212_0.int_0] != '&')
				{
					enum33_ = Class7.smethod_334(class212_0);
					object_2 = Class7.smethod_234(class212_0);
				}
				else
				{
					enum33_ = Enum33.const_3;
				}
				class3 = new Class215(enum33_, object_, object_2);
				if (class212_0.string_0[class212_0.int_0] != ')')
				{
					if (class212_0.string_0[class212_0.int_0] == '&')
					{
						if (!Class7.smethod_145(class212_0, "&&"))
						{
							throw class212_0.method_4();
						}
						if (class2 == null || class2.enum33_0 != Enum33.const_8)
						{
							Class214 class4 = new Class214(Enum33.const_8);
							class2?.Expressions.Add(class4);
							class2 = class4;
							if (@class == null)
							{
								@class = class2;
							}
						}
						class2.Expressions.Add(class3);
					}
					if (class212_0.string_0[class212_0.int_0] != '|')
					{
						continue;
					}
					if (Class7.smethod_145(class212_0, "||"))
					{
						if (class2 == null || class2.enum33_0 != Enum33.const_9)
						{
							Class214 class5 = new Class214(Enum33.const_9);
							class2?.Expressions.Add(class5);
							class2 = class5;
							if (@class == null)
							{
								@class = class2;
							}
						}
						class2.Expressions.Add(class3);
						continue;
					}
					throw class212_0.method_4();
				}
				if (class2 == null)
				{
					break;
				}
				class2.Expressions.Add(class3);
				return @class;
			}
			throw new JsonException("Path ended with open query.");
		}
		return class3;
	}

	static object? smethod_691(Type type_0, JToken jtoken_0)
	{
		if (type_0 == null)
		{
			throw new ArgumentNullException("type");
		}
		if (jtoken_0.object_0 != null)
		{
			if (!(jtoken_0.object_0 is object[] array))
			{
				if (type_0.IsInstanceOfType(jtoken_0.object_0))
				{
					return jtoken_0.object_0;
				}
			}
			else
			{
				foreach (object obj in array)
				{
					if (obj == null)
					{
						break;
					}
					if (type_0.IsInstanceOfType(obj))
					{
						return obj;
					}
				}
			}
		}
		return null;
	}

	static Type smethod_692(Type type_0)
	{
		if (!Class7.smethod_157(type_0))
		{
			return type_0;
		}
		return Nullable.GetUnderlyingType(type_0);
	}

	static string smethod_693(string string_0)
	{
		return Class7.smethod_15(string_0, '-');
	}

	static Delegate1<object?, object> smethod_694(string string_0, Type type_0)
	{
		FSharpUtils.Class81 @class = new FSharpUtils.Class81();
		MethodInfo methodInfo = Class7.smethod_642(type_0, string_0, BindingFlags.Static | BindingFlags.Public);
		MethodInfo method = methodInfo.ReturnType.GetMethod("Invoke", BindingFlags.Instance | BindingFlags.Public);
		@class.delegate1_0 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(methodInfo);
		@class.delegate1_1 = JsonTypeReflector.ReflectionDelegateFactory.vmethod_0<object>(method);
		return (object? object_0, object?[] object_1) => new Class80(@class.delegate1_0(object_0, object_1), @class.delegate1_1);
	}

	static void smethod_695(JsonValidatingReader jsonValidatingReader_0)
	{
		if (jsonValidatingReader_0.jsonSchemaModel_0 == null)
		{
			Class170 class170_ = new Class170();
			jsonValidatingReader_0.jsonSchemaModel_0 = Class7.smethod_394(jsonValidatingReader_0.jsonSchema_0, class170_);
			if (!Class7.smethod_687(jsonValidatingReader_0.class29_0.TokenType))
			{
				Class7.smethod_353(jsonValidatingReader_0, new JsonValidatingReader.SchemaScope(JTokenType.None, jsonValidatingReader_0.CurrentMemberSchemas));
			}
		}
		switch (jsonValidatingReader_0.class29_0.TokenType)
		{
		case JsonToken.StartObject:
		{
			Class7.smethod_233(jsonValidatingReader_0);
			IList<JsonSchemaModel> schemas2 = jsonValidatingReader_0.CurrentMemberSchemas.Where(jsonValidatingReader_0.method_6).ToList();
			Class7.smethod_353(jsonValidatingReader_0, new JsonValidatingReader.SchemaScope(JTokenType.Object, schemas2));
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			break;
		}
		case JsonToken.StartArray:
		{
			Class7.smethod_233(jsonValidatingReader_0);
			IList<JsonSchemaModel> schemas = jsonValidatingReader_0.CurrentMemberSchemas.Where(jsonValidatingReader_0.method_5).ToList();
			Class7.smethod_353(jsonValidatingReader_0, new JsonValidatingReader.SchemaScope(JTokenType.Array, schemas));
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			break;
		}
		case JsonToken.StartConstructor:
			Class7.smethod_233(jsonValidatingReader_0);
			Class7.smethod_353(jsonValidatingReader_0, new JsonValidatingReader.SchemaScope(JTokenType.Constructor, null));
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			break;
		case JsonToken.PropertyName:
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			{
				foreach (JsonSchemaModel currentSchema in jsonValidatingReader_0.CurrentSchemas)
				{
					Class7.smethod_47(currentSchema, jsonValidatingReader_0);
				}
				break;
			}
		default:
			throw new ArgumentOutOfRangeException();
		case JsonToken.Raw:
			Class7.smethod_233(jsonValidatingReader_0);
			break;
		case JsonToken.Integer:
			Class7.smethod_233(jsonValidatingReader_0);
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema in jsonValidatingReader_0.CurrentMemberSchemas)
				{
					jsonValidatingReader_0.method_4(currentMemberSchema);
				}
				break;
			}
		case JsonToken.Float:
			Class7.smethod_233(jsonValidatingReader_0);
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema2 in jsonValidatingReader_0.CurrentMemberSchemas)
				{
					Class7.smethod_573(jsonValidatingReader_0, currentMemberSchema2);
				}
				break;
			}
		case JsonToken.String:
			Class7.smethod_233(jsonValidatingReader_0);
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema3 in jsonValidatingReader_0.CurrentMemberSchemas)
				{
					Class7.smethod_364(currentMemberSchema3, jsonValidatingReader_0);
				}
				break;
			}
		case JsonToken.Boolean:
			Class7.smethod_233(jsonValidatingReader_0);
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema4 in jsonValidatingReader_0.CurrentMemberSchemas)
				{
					Class7.smethod_3(currentMemberSchema4, jsonValidatingReader_0);
				}
				break;
			}
		case JsonToken.Null:
			Class7.smethod_233(jsonValidatingReader_0);
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentMemberSchemas);
			{
				foreach (JsonSchemaModel currentMemberSchema5 in jsonValidatingReader_0.CurrentMemberSchemas)
				{
					Class7.smethod_236(currentMemberSchema5, jsonValidatingReader_0);
				}
				break;
			}
		case JsonToken.None:
			break;
		case JsonToken.EndObject:
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			foreach (JsonSchemaModel currentSchema2 in jsonValidatingReader_0.CurrentSchemas)
			{
				Class7.smethod_746(jsonValidatingReader_0, currentSchema2);
			}
			Class7.smethod_299(jsonValidatingReader_0);
			break;
		case JsonToken.EndArray:
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			foreach (JsonSchemaModel currentSchema3 in jsonValidatingReader_0.CurrentSchemas)
			{
				Class7.smethod_531(currentSchema3, jsonValidatingReader_0);
			}
			Class7.smethod_299(jsonValidatingReader_0);
			break;
		case JsonToken.EndConstructor:
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentSchemas);
			Class7.smethod_299(jsonValidatingReader_0);
			break;
		case JsonToken.Undefined:
		case JsonToken.Date:
		case JsonToken.Bytes:
			jsonValidatingReader_0.method_3(jsonValidatingReader_0.CurrentMemberSchemas);
			break;
		}
	}

	static Class9? smethod_696(object object_0)
	{
		Attribute10 attribute = JsonTypeReflector.smethod_0<Attribute10>(object_0);
		if (attribute != null)
		{
			Func<object[], object> func = JsonTypeReflector.class111_0.method_0(attribute.type_0);
			if (func != null)
			{
				return (Class9)func(attribute.ConverterParameters);
			}
		}
		return null;
	}

	static bool smethod_697(MethodInfo methodInfo_0, ParameterInfo[] parameterInfo_0, Type type_0, MethodInfo? methodInfo_1, ref Type? type_1)
	{
		if (!methodInfo_0.IsDefined(type_0, inherit: false))
		{
			return false;
		}
		if (methodInfo_1 != null)
		{
			throw new JsonException("Invalid attribute. Both '{0}' and '{1}' in type '{2}' have '{3}'.".smethod_4(CultureInfo.InvariantCulture, methodInfo_0, methodInfo_1, Class7.smethod_355(methodInfo_0.DeclaringType), type_0));
		}
		if (type_1 != null)
		{
			throw new JsonException("Invalid Callback. Method '{3}' in type '{2}' has both '{0}' and '{1}'.".smethod_4(CultureInfo.InvariantCulture, type_1, type_0, Class7.smethod_355(methodInfo_0.DeclaringType), methodInfo_0));
		}
		if (methodInfo_0.IsVirtual)
		{
			throw new JsonException("Virtual Method '{0}' of type '{1}' cannot be marked with '{2}' attribute.".smethod_3(CultureInfo.InvariantCulture, methodInfo_0, Class7.smethod_355(methodInfo_0.DeclaringType), type_0));
		}
		if (methodInfo_0.ReturnType != typeof(void))
		{
			throw new JsonException("Serialization Callback '{1}' in type '{0}' must return void.".smethod_2(CultureInfo.InvariantCulture, Class7.smethod_355(methodInfo_0.DeclaringType), methodInfo_0));
		}
		if (type_0 == typeof(Attribute15))
		{
			if (parameterInfo_0 == null || parameterInfo_0.Length != 2 || parameterInfo_0[0].ParameterType != typeof(StreamingContext) || parameterInfo_0[1].ParameterType != typeof(Class135))
			{
				throw new JsonException("Serialization Error Callback '{1}' in type '{0}' must have two parameters of type '{2}' and '{3}'.".smethod_4(CultureInfo.InvariantCulture, Class7.smethod_355(methodInfo_0.DeclaringType), methodInfo_0, typeof(StreamingContext), typeof(Class135)));
			}
		}
		else if (parameterInfo_0 == null || parameterInfo_0.Length != 1 || parameterInfo_0[0].ParameterType != typeof(StreamingContext))
		{
			throw new JsonException("Serialization Callback '{1}' in type '{0}' must have a single parameter of type '{2}'.".smethod_3(CultureInfo.InvariantCulture, Class7.smethod_355(methodInfo_0.DeclaringType), methodInfo_0, typeof(StreamingContext)));
		}
		type_1 = type_0;
		return true;
	}

	static void smethod_698(Class199.Class197 class197_0)
	{
		class197_0.int_0 = -3;
		if (class197_0.ienumerator_1 != null)
		{
			class197_0.ienumerator_1.Dispose();
		}
	}

	static JsonReaderException smethod_699(string? string_0, Exception exception_0, Interface1 interface1_0, string? string_1)
	{
		string_1 = Struct0.smethod_2(interface1_0, string_0, string_1);
		int lineNumber;
		int linePosition;
		if (interface1_0 != null && interface1_0.imethod_0())
		{
			lineNumber = interface1_0.LineNumber;
			linePosition = interface1_0.LinePosition;
		}
		else
		{
			lineNumber = 0;
			linePosition = 0;
		}
		return new JsonReaderException(string_1, string_0, lineNumber, linePosition, exception_0);
	}

	static Class198 smethod_700(string? string_0, bool bool_0)
	{
		if (!bool_0)
		{
			return new Class202(string_0);
		}
		return new Class206(string_0);
	}

	static void smethod_701(Class204.Class217 class217_0)
	{
		class217_0.int_0 = -1;
		if (class217_0.ienumerator_0 != null)
		{
			class217_0.ienumerator_0.Dispose();
		}
	}

	static string smethod_702(Guid guid_0)
	{
		return Class8.smethod_15(guid_0, '"');
	}

	static JToken smethod_703(long? nullable_0)
	{
		return new Class179(nullable_0);
	}

	static Class177 smethod_704(Class29 class29_0)
	{
		return Class7.smethod_92(class29_0, (Class193?)null);
	}

	static void smethod_705(Class38 class38_0)
	{
		class38_0.method_2(JsonToken.Comment);
	}

	static bool smethod_706(Class24 class24_0, RegexOptions regexOptions_0, RegexOptions regexOptions_1)
	{
		return (regexOptions_0 & regexOptions_1) == regexOptions_1;
	}

	static object smethod_707(string string_0, JsonSerializerInternalReader jsonSerializerInternalReader_0, Class29? class29_0, Class142? class142_0, JsonProperty jsonProperty_0)
	{
		Type underlyingType = class142_0!.UnderlyingType;
		if (!JsonTypeReflector.FullyTrusted)
		{
			string string_ = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
			string_ = string_.smethod_1(CultureInfo.InvariantCulture, underlyingType);
			throw Class7.smethod_161(class29_0, string_);
		}
		if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class29_0 as Interface1, class29_0!.Path, "Deserializing {0} using ISerializable constructor.".smethod_1(CultureInfo.InvariantCulture, class142_0!.UnderlyingType)), null);
		}
		SerializationInfo serializationInfo = new SerializationInfo(class142_0!.UnderlyingType, new Class149(jsonSerializerInternalReader_0, class142_0, jsonProperty_0));
		bool flag = false;
		do
		{
			JsonToken tokenType = class29_0!.TokenType;
			if (tokenType == JsonToken.PropertyName)
			{
				string text = class29_0!.Value!.ToString();
				if (!class29_0!.vmethod_0())
				{
					throw Class7.smethod_161(class29_0, "Unexpected end when setting {0}'s value.".smethod_1(CultureInfo.InvariantCulture, text));
				}
				serializationInfo.AddValue(text, Class7.smethod_680(class29_0));
			}
			else if (tokenType != JsonToken.Comment)
			{
				if (tokenType != JsonToken.EndObject)
				{
					throw Class7.smethod_161(class29_0, "Unexpected token when deserializing object: " + class29_0!.TokenType);
				}
				flag = true;
			}
		}
		while (!flag && class29_0!.vmethod_0());
		if (!flag)
		{
			Class7.smethod_574((object)serializationInfo, class29_0, "Unexpected end when deserializing object.", jsonSerializerInternalReader_0, (Class137)class142_0);
		}
		if (!class142_0!.bool_5)
		{
			throw Class7.smethod_161(class29_0, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".smethod_1(CultureInfo.InvariantCulture, class142_0!.UnderlyingType));
		}
		if (class142_0!.ISerializableCreator == null)
		{
			throw Class7.smethod_161(class29_0, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".smethod_1(CultureInfo.InvariantCulture, underlyingType));
		}
		object obj = class142_0!.ISerializableCreator!(serializationInfo, jsonSerializerInternalReader_0.class34_0.streamingContext_0);
		if (string_0 != null)
		{
			Class7.smethod_398(obj, jsonSerializerInternalReader_0, string_0, class29_0);
		}
		Class7.smethod_208(jsonSerializerInternalReader_0, class29_0, (Class137)class142_0, obj);
		Class7.smethod_296(jsonSerializerInternalReader_0, class29_0, (Class137)class142_0, obj);
		return obj;
	}

	static void smethod_708(Class30 class30_0, bool bool_0, int int_0)
	{
		if (class30_0.int_2 + int_0 < class30_0.char_2!.Length - 1)
		{
			return;
		}
		if (bool_0)
		{
			int num = class30_0.char_2!.Length * 2;
			int int_ = Math.Max((num < 0) ? int.MaxValue : num, class30_0.int_2 + int_0 + 1);
			char[] array = Class87.smethod_0(class30_0.interface0_0, int_);
			char[] char_ = class30_0.char_2;
			int int_2 = class30_0.char_2!.Length;
			Class7.smethod_309(0, array, char_, 0, int_2);
			Class7.smethod_520(class30_0.interface0_0, class30_0.char_2);
			class30_0.char_2 = array;
			return;
		}
		int num2 = class30_0.int_2 - class30_0.int_3;
		if (num2 + int_0 + 1 >= class30_0.char_2!.Length)
		{
			char[] array2 = Class87.smethod_0(class30_0.interface0_0, num2 + int_0 + 1);
			if (num2 > 0)
			{
				char[] char_ = class30_0.char_2;
				int int_3 = class30_0.int_3;
				Class7.smethod_309(0, array2, char_, int_3, num2);
			}
			Class7.smethod_520(class30_0.interface0_0, class30_0.char_2);
			class30_0.char_2 = array2;
		}
		else if (num2 > 0)
		{
			char[] char_ = class30_0.char_2;
			int int_3 = class30_0.int_3;
			char[] char_2 = class30_0.char_2;
			Class7.smethod_309(0, char_2, char_, int_3, num2);
		}
		class30_0.int_4 -= class30_0.int_3;
		class30_0.int_3 = 0;
		class30_0.int_2 = num2;
	}

	static float smethod_709(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (float)bigInteger;
			}
			return Convert.ToSingle(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Single.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static Dictionary<string, string?>? smethod_710(Class27 class27_0, Class29 class29_0, XmlNamespaceManager xmlNamespaceManager_0)
	{
		Dictionary<string, string> dictionary = null;
		bool flag = false;
		string string_ = default(string);
		while (!flag && class29_0.vmethod_0())
		{
			switch (class29_0.TokenType)
			{
			case JsonToken.Comment:
			case JsonToken.EndObject:
				flag = true;
				break;
			case JsonToken.PropertyName:
			{
				string text = class29_0.Value!.ToString();
				if (!Class109.smethod_0(text))
				{
					switch (text[0])
					{
					case '@':
					{
						if (dictionary == null)
						{
							dictionary = new Dictionary<string, string>();
						}
						text = text.Substring(1);
						Class7.smethod_686(class29_0);
						string value = Class7.smethod_462(class29_0);
						dictionary.Add(text, value);
						if (Class7.smethod_550(text, class27_0, ref string_))
						{
							xmlNamespaceManager_0.AddNamespace(string_, value);
						}
						break;
					}
					default:
						flag = true;
						break;
					case '$':
						switch (text)
						{
						default:
							flag = true;
							break;
						case "$values":
						case "$id":
						case "$ref":
						case "$type":
						case "$value":
						{
							string text2 = xmlNamespaceManager_0.LookupPrefix("http://james.newtonking.com/projects/json");
							if (text2 == null)
							{
								if (dictionary == null)
								{
									dictionary = new Dictionary<string, string>();
								}
								int? num = null;
								int? num2;
								while (true)
								{
									num2 = num;
									if (xmlNamespaceManager_0.LookupNamespace("json" + num2) == null)
									{
										break;
									}
									num = num.GetValueOrDefault() + 1;
								}
								num2 = num;
								text2 = "json" + num2;
								dictionary.Add("xmlns:" + text2, "http://james.newtonking.com/projects/json");
								xmlNamespaceManager_0.AddNamespace(text2, "http://james.newtonking.com/projects/json");
							}
							if (text == "$values")
							{
								flag = true;
								break;
							}
							text = text.Substring(1);
							Class7.smethod_686(class29_0);
							if (Class7.smethod_397(class29_0.TokenType))
							{
								if (dictionary == null)
								{
									dictionary = new Dictionary<string, string>();
								}
								string value = class29_0.Value?.ToString();
								dictionary.Add(text2 + ":" + text, value);
								break;
							}
							throw Class7.smethod_161(class29_0, "Unexpected JsonToken: " + class29_0.TokenType);
						}
						}
						break;
					}
				}
				else
				{
					flag = true;
				}
				break;
			}
			default:
				throw Class7.smethod_161(class29_0, "Unexpected JsonToken: " + class29_0.TokenType);
			}
		}
		return dictionary;
	}

	static JToken smethod_711(JToken jtoken_0)
	{
		return jtoken_0.vmethod_0();
	}

	static void smethod_712(Class38 class38_0, Class152 class152_0, object object_0)
	{
		string text = Class7.smethod_445(object_0, class38_0, class152_0);
		if (class152_0.interface7_0 != null && class152_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			class152_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(null, class38_0.Path, "Writing object reference to Id '{0}' for {1}.".smethod_2(CultureInfo.InvariantCulture, text, object_0.GetType())), null);
		}
		class38_0.vmethod_3();
		class38_0.vmethod_10("$ref", bool_2: false);
		class38_0.vmethod_21(text);
		class38_0.vmethod_4();
	}

	static IEnumerable<JToken> smethod_713(JToken jtoken_0)
	{
		return new JToken.Class184(-2)
		{
			jtoken_1 = jtoken_0
		};
	}

	static Attribute[] smethod_714(object object_0, Type? type_0, bool bool_0)
	{
		Class113.smethod_0(object_0, "attributeProvider");
		if (!(object_0 is Type type))
		{
			if (!(object_0 is Assembly element))
			{
				if (!(object_0 is MemberInfo element2))
				{
					if (!(object_0 is Module element3))
					{
						if (!(object_0 is ParameterInfo element4))
						{
							ICustomAttributeProvider customAttributeProvider = (ICustomAttributeProvider)object_0;
							return (Attribute[])((type_0 != null) ? customAttributeProvider.GetCustomAttributes(type_0, bool_0) : customAttributeProvider.GetCustomAttributes(bool_0));
						}
						if (!(type_0 != null))
						{
							return Attribute.GetCustomAttributes(element4, bool_0);
						}
						return Attribute.GetCustomAttributes(element4, type_0, bool_0);
					}
					if (!(type_0 != null))
					{
						return Attribute.GetCustomAttributes(element3, bool_0);
					}
					return Attribute.GetCustomAttributes(element3, type_0, bool_0);
				}
				if (!(type_0 != null))
				{
					return Attribute.GetCustomAttributes(element2, bool_0);
				}
				return Attribute.GetCustomAttributes(element2, type_0, bool_0);
			}
			if (!(type_0 != null))
			{
				return Attribute.GetCustomAttributes(element);
			}
			return Attribute.GetCustomAttributes(element, type_0);
		}
		return ((type_0 != null) ? type.GetCustomAttributes(type_0, bool_0) : type.GetCustomAttributes(bool_0)).Cast<Attribute>().ToArray();
	}

	static string smethod_715(string string_0)
	{
		string string_ = default(string);
		Class7.smethod_370(ref string_, out string _, string_0);
		return string_;
	}

	static object? smethod_716(JsonSerializerInternalReader jsonSerializerInternalReader_0, Class9 class9_0, Class29 class29_0, Type? type_0, object object_0)
	{
		if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class29_0 as Interface1, class29_0.Path, "Started deserializing {0} with converter {1}.".smethod_2(CultureInfo.InvariantCulture, type_0, class9_0.GetType())), null);
		}
		object? result = class9_0.vmethod_1(class29_0, type_0, object_0, Class7.smethod_190(jsonSerializerInternalReader_0));
		if (jsonSerializerInternalReader_0.interface7_0 != null && jsonSerializerInternalReader_0.interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			jsonSerializerInternalReader_0.interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class29_0 as Interface1, class29_0.Path, "Finished deserializing {0} with converter {1}.".smethod_2(CultureInfo.InvariantCulture, type_0, class9_0.GetType())), null);
		}
		return result;
	}

	static void smethod_717(Class29 class29_0)
	{
		JsonContainerType jsonContainerType_ = class29_0.struct0_0.jsonContainerType_0;
		switch (jsonContainerType_)
		{
		default:
			throw Class7.smethod_555(class29_0, "While setting the reader state back to current object an unexpected JsonType was encountered: {0}".smethod_1(CultureInfo.InvariantCulture, jsonContainerType_));
		case JsonContainerType.None:
			Class7.smethod_54(class29_0);
			break;
		case JsonContainerType.Object:
			class29_0.state_0 = Class29.State.Object;
			break;
		case JsonContainerType.Array:
			class29_0.state_0 = Class29.State.Array;
			break;
		case JsonContainerType.Constructor:
			class29_0.state_0 = Class29.State.Constructor;
			break;
		}
	}

	static void smethod_718(Class152 class152_0, Class38 class38_0, Array array_0, Class139? class139_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty jsonProperty_1)
	{
		Class7.smethod_246(class152_0, class38_0, (Class137)class139_0, (object)array_0);
		class152_0.list_0.Add(array_0);
		bool num = Class7.smethod_219(class139_0, class38_0, jsonProperty_0, class152_0, jsonProperty_1, class138_0, (object)array_0);
		Class7.smethod_315(class152_0, class38_0, array_0, class139_0, jsonProperty_0, class38_0.Top, Class45.smethod_10<int>());
		if (num)
		{
			class38_0.vmethod_4();
		}
		class152_0.list_0.RemoveAt(class152_0.list_0.Count - 1);
		Class7.smethod_82(class38_0, class152_0, (Class137)class139_0, (object)array_0);
	}

	static void smethod_719(Type type_0)
	{
		if (Class11.class100_0 == null)
		{
			Class11.class100_0 = Class7.smethod_81(type_0, (MethodBase?)type_0.GetConstructor(new Type[1] { typeof(byte[]) }), new string[1] { "ToArray" });
		}
	}

	static Enum22 smethod_720(char[] char_0, int int_0, int int_1, out decimal decimal_0)
	{
		decimal_0 = default(decimal);
		if (int_1 == 0)
		{
			return Enum22.const_3;
		}
		bool flag;
		if (flag = char_0[int_0] == '-')
		{
			if (int_1 == 1)
			{
				return Enum22.const_3;
			}
			int_0++;
			int_1--;
		}
		int i = int_0;
		int num = int_0 + int_1;
		int num2 = num;
		int num3 = num;
		int num4 = 0;
		ulong num5 = 0uL;
		ulong num6 = 0uL;
		int num7 = 0;
		int num8 = 0;
		char? c = null;
		bool? flag2 = null;
		while (true)
		{
			char c2;
			if (i < num)
			{
				c2 = char_0[i];
				if (c2 != '.')
				{
					if (c2 != 'E' && c2 != 'e')
					{
						if (c2 >= '0' && c2 <= '9')
						{
							if (i == int_0 && c2 == '0')
							{
								i++;
								if (i != num)
								{
									c2 = char_0[i];
									if (c2 != '.')
									{
										if (c2 != 'e' && c2 != 'E')
										{
											return Enum22.const_3;
										}
										goto IL_01a8;
									}
									goto IL_0234;
								}
							}
							if (num7 < 29)
							{
								if (num7 == 28)
								{
									bool? flag3 = flag2;
									bool valueOrDefault;
									if (!flag3.HasValue)
									{
										flag2 = num5 > 7922816251426433759L || (num5 == 7922816251426433759L && (num6 > 354395033L || (num6 == 354395033L && c2 > '5')));
										bool? flag4 = flag2;
										valueOrDefault = flag4.GetValueOrDefault();
									}
									else
									{
										valueOrDefault = flag3.GetValueOrDefault();
									}
									if (valueOrDefault)
									{
										goto IL_018b;
									}
								}
								if (num7 < 19)
								{
									num5 = num5 * 10L + (ulong)(c2 - 48);
								}
								else
								{
									num6 = num6 * 10L + (ulong)(c2 - 48);
								}
								num7++;
								goto IL_0255;
							}
							goto IL_018b;
						}
						return Enum22.const_3;
					}
					goto IL_01a8;
				}
				goto IL_0234;
			}
			num4 += num8;
			num4 -= num3 - num2;
			if (num7 <= 19)
			{
				decimal_0 = num5;
			}
			else
			{
				decimal_0 = (decimal)num5 / new decimal(1, 0, 0, isNegative: false, (byte)(num7 - 19)) + (decimal)num6;
			}
			if (num4 > 0)
			{
				num7 += num4;
				if (num7 > 29)
				{
					return Enum22.const_2;
				}
				if (num7 == 29)
				{
					if (num4 > 1)
					{
						decimal_0 /= new decimal(1, 0, 0, isNegative: false, (byte)(num4 - 1));
						if (decimal_0 > 7922816251426433759354395033m)
						{
							return Enum22.const_2;
						}
					}
					else if (decimal_0 == 7922816251426433759354395033m && c > '5')
					{
						return Enum22.const_2;
					}
					decimal_0 *= 10m;
				}
				else
				{
					decimal_0 /= new decimal(1, 0, 0, isNegative: false, (byte)num4);
				}
			}
			else
			{
				if (c >= '5' && num4 >= -28)
				{
					++decimal_0;
				}
				if (num4 < 0)
				{
					if (num7 + num4 + 28 <= 0)
					{
						decimal_0 = (flag ? 0m : 0m);
						return Enum22.const_1;
					}
					if (num4 >= -28)
					{
						decimal_0 *= new decimal(1, 0, 0, isNegative: false, (byte)(-num4));
					}
					else
					{
						decimal_0 /= 10000000000000000000000000000m;
						decimal_0 *= new decimal(1, 0, 0, isNegative: false, (byte)(-num4 - 28));
					}
				}
			}
			if (flag)
			{
				decimal_0 = -decimal_0;
			}
			return Enum22.const_1;
			IL_01a8:
			if (i != int_0)
			{
				if (i != num2)
				{
					i++;
					if (i != num)
					{
						if (num2 < num)
						{
							num3 = i - 1;
						}
						c2 = char_0[i];
						bool flag5 = false;
						switch (c2)
						{
						case '-':
							flag5 = true;
							i++;
							break;
						case '+':
							i++;
							break;
						}
						for (; i < num; i++)
						{
							c2 = char_0[i];
							if (c2 >= '0' && c2 <= '9')
							{
								int num9 = 10 * num4 + (c2 - 48);
								if (num4 < num9)
								{
									num4 = num9;
								}
								continue;
							}
							return Enum22.const_3;
						}
						if (flag5)
						{
							num4 = -num4;
						}
						goto IL_0255;
					}
					return Enum22.const_3;
				}
				return Enum22.const_3;
			}
			return Enum22.const_3;
			IL_0234:
			if (i != int_0)
			{
				if (i + 1 != num)
				{
					if (num2 != num)
					{
						break;
					}
					num2 = i + 1;
					goto IL_0255;
				}
				return Enum22.const_3;
			}
			return Enum22.const_3;
			IL_0255:
			i++;
			continue;
			IL_018b:
			if (!c.HasValue)
			{
				c = c2;
			}
			num8++;
			goto IL_0255;
		}
		return Enum22.const_3;
	}

	static JToken smethod_721(double double_0)
	{
		return new Class179(double_0);
	}

	static DataContractAttribute? smethod_722(Type type_0)
	{
		Type type = type_0;
		DataContractAttribute dataContractAttribute;
		while (true)
		{
			if (type != null)
			{
				dataContractAttribute = Class114<DataContractAttribute>.smethod_0(type);
				if (dataContractAttribute != null)
				{
					break;
				}
				type = type.smethod_6();
				continue;
			}
			return null;
		}
		return dataContractAttribute;
	}

	static byte[] smethod_723(byte[] byte_0)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[byte_0.Length];
		byte[] bytes = Encoding.UTF8.GetBytes("Cshtdwskmw");
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = bytes[i % bytes.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		i = 0;
		num = 0;
		int num3 = 0;
		for (; i < byte_0.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(byte_0[i] ^ num4);
		}
		return array3;
	}

	static int smethod_724(Class29 class29_0, Class38 class38_0)
	{
		JsonToken tokenType = class29_0.TokenType;
		if (tokenType == JsonToken.None)
		{
			return -1;
		}
		if (!Class7.smethod_687(tokenType))
		{
			return class29_0.Depth + 1;
		}
		return class29_0.Depth;
	}

	static void smethod_725(Class38 class38_0)
	{
		if (class38_0.struct0_0.bool_0)
		{
			class38_0.struct0_0.int_0++;
		}
	}

	static JToken? smethod_726(Class176 class176_0, object object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		if (!(object_0 is JToken result))
		{
			throw new ArgumentException("Argument is not a JToken.");
		}
		return result;
	}

	static string smethod_727(Type type_0, bool bool_0, Class167 class167_0)
	{
		Attribute5 attribute = JsonTypeReflector.smethod_0<Attribute5>(type_0);
		if (!Class109.smethod_0(attribute?.Id))
		{
			return attribute.Id;
		}
		if (bool_0)
		{
			return null;
		}
		return class167_0.UndefinedSchemaIdHandling switch
		{
			Enum27.const_2 => type_0.AssemblyQualifiedName, 
			Enum27.const_1 => type_0.FullName, 
			_ => null, 
		};
	}

	static object? smethod_728(Type type_0, JToken jtoken_0)
	{
		if (Class8.DefaultSettings == null)
		{
			bool bool_ = default(bool);
			Enum21 @enum = Class7.smethod_425(ref bool_, type_0);
			if (bool_)
			{
				if (jtoken_0.Type == JTokenType.String)
				{
					try
					{
						return Class7.smethod_292(jtoken_0, type_0, Class7.smethod_575());
					}
					catch (Exception innerException)
					{
						Type type = (type_0.smethod_8() ? type_0 : Nullable.GetUnderlyingType(type_0));
						throw new ArgumentException("Could not convert '{0}' to {1}.".smethod_2(CultureInfo.InvariantCulture, JToken.smethod_19(jtoken_0), type.Name), innerException);
					}
				}
				if (jtoken_0.Type == JTokenType.Integer)
				{
					return Enum.ToObject(type_0.smethod_8() ? type_0 : Nullable.GetUnderlyingType(type_0), ((Class179)jtoken_0).Value);
				}
			}
			switch (@enum)
			{
			case Enum21.const_2:
				return JToken.smethod_8(jtoken_0);
			case Enum21.const_3:
				return JToken.smethod_6(jtoken_0);
			case Enum21.const_4:
				return Class7.smethod_483(jtoken_0);
			case Enum21.const_5:
				return JToken.smethod_1(jtoken_0);
			case Enum21.const_6:
				return JToken.smethod_9(jtoken_0);
			case Enum21.const_7:
				return JToken.smethod_14(jtoken_0);
			case Enum21.const_8:
				return Class7.smethod_766(jtoken_0);
			case Enum21.const_9:
				return JToken.smethod_11(jtoken_0);
			case Enum21.const_10:
				return JToken.smethod_7(jtoken_0);
			case Enum21.const_11:
				return JToken.smethod_12(jtoken_0);
			case Enum21.const_12:
				return Class7.smethod_640(jtoken_0);
			case Enum21.const_13:
				return JToken.smethod_10(jtoken_0);
			case Enum21.const_14:
				return Class7.smethod_68(jtoken_0);
			case Enum21.const_15:
				return JToken.smethod_13(jtoken_0);
			case Enum21.const_16:
				return JToken.smethod_20(jtoken_0);
			case Enum21.const_17:
				return JToken.smethod_17(jtoken_0);
			case Enum21.const_18:
				return Class7.smethod_565(jtoken_0);
			case Enum21.const_19:
				return JToken.smethod_15(jtoken_0);
			case Enum21.const_20:
				return JToken.smethod_21(jtoken_0);
			case Enum21.const_21:
				return JToken.smethod_18(jtoken_0);
			case Enum21.const_22:
				return Class7.smethod_709(jtoken_0);
			case Enum21.const_23:
				return JToken.smethod_16(jtoken_0);
			case Enum21.const_24:
				return Class7.smethod_318(jtoken_0);
			case Enum21.const_25:
				return JToken.smethod_5(jtoken_0);
			case Enum21.const_26:
				return Class7.smethod_436(jtoken_0);
			case Enum21.const_27:
				return JToken.smethod_2(jtoken_0);
			case Enum21.const_28:
				return Class7.smethod_327(jtoken_0);
			case Enum21.const_29:
				return JToken.smethod_3(jtoken_0);
			case Enum21.const_30:
				return Class7.smethod_304(jtoken_0);
			case Enum21.const_31:
				return JToken.smethod_4(jtoken_0);
			case Enum21.const_32:
				return Class7.smethod_193(jtoken_0);
			case Enum21.const_33:
				return JToken.smethod_23(jtoken_0);
			case Enum21.const_34:
				return Class7.smethod_360(jtoken_0);
			case Enum21.const_35:
				return JToken.smethod_24(jtoken_0);
			case Enum21.const_36:
				return Class7.smethod_510(jtoken_0);
			case Enum21.const_37:
				return Class7.smethod_114(jtoken_0);
			case Enum21.const_38:
				return JToken.smethod_25(jtoken_0);
			case Enum21.const_39:
				return JToken.smethod_19(jtoken_0);
			}
		}
		return Class7.smethod_292(jtoken_0, type_0, Class7.smethod_575());
	}

	static bool smethod_729(Type type_0, Type type_1)
	{
		Type type_2 = default(Type);
		return Class7.smethod_399(ref type_2, type_1, type_0);
	}

	static bool smethod_730(Type type_0, Type type_1, [Attribute1(true)] out Type? type_2)
	{
		Class113.smethod_0(type_0, "type");
		Class113.smethod_0(type_1, "genericInterfaceDefinition");
		if (type_1.smethod_3() && type_1.smethod_5())
		{
			if (type_0.smethod_3() && type_0.smethod_4())
			{
				Type genericTypeDefinition = type_0.GetGenericTypeDefinition();
				if (type_1 == genericTypeDefinition)
				{
					type_2 = type_0;
					return true;
				}
			}
			Type[] interfaces = type_0.GetInterfaces();
			int num = 0;
			Type type;
			while (true)
			{
				if (num < interfaces.Length)
				{
					type = interfaces[num];
					if (type.smethod_4())
					{
						Type genericTypeDefinition2 = type.GetGenericTypeDefinition();
						if (type_1 == genericTypeDefinition2)
						{
							break;
						}
					}
					num++;
					continue;
				}
				type_2 = null;
				return false;
			}
			type_2 = type;
			return true;
		}
		throw new ArgumentNullException("'{0}' is not a generic interface definition.".smethod_1(CultureInfo.InvariantCulture, type_1));
	}

	[DllImport("user32.dll")]
	static extern bool ShowWindow(IntPtr intptr_0, int int_0);

	static void smethod_731(Enum8 enum8_0, char char_0, int int_0, Class30 class30_0)
	{
		Class7.smethod_621((Class29)class30_0, bool_0: true);
		class30_0.struct4_0 = new Struct4(class30_0.char_2, int_0, class30_0.int_3 - int_0);
		bool flag = char.IsDigit(char_0) && class30_0.struct4_0.Length == 1;
		bool flag2 = char_0 == '0' && class30_0.struct4_0.Length > 1 && class30_0.struct4_0.Chars[class30_0.struct4_0.StartIndex + 1] != '.' && class30_0.struct4_0.Chars[class30_0.struct4_0.StartIndex + 1] != 'e' && class30_0.struct4_0.Chars[class30_0.struct4_0.StartIndex + 1] != 'E';
		object object_;
		JsonToken jsonToken_;
		switch (enum8_0)
		{
		case Enum8.const_1:
			if (flag)
			{
				object_ = char_0 - 48;
			}
			else if (flag2)
			{
				string text5 = class30_0.struct4_0.ToString();
				try
				{
					object_ = (text5.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt32(text5, 16) : Convert.ToInt32(text5, 8));
				}
				catch (Exception exception_4)
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid integer.".smethod_1(CultureInfo.InvariantCulture, text5), exception_4);
				}
			}
			else
			{
				int int_;
				Enum22 enum2 = Class7.smethod_607(class30_0.struct4_0.Chars, class30_0.struct4_0.StartIndex, class30_0.struct4_0.Length, out int_);
				if (enum2 != Enum22.const_1)
				{
					if (enum2 == Enum22.const_2)
					{
						throw Class7.smethod_772(class30_0, "JSON integer {0} is too large or small for an Int32.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
					}
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid integer.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
				}
				object_ = int_;
			}
			jsonToken_ = JsonToken.Integer;
			break;
		case Enum8.const_0:
		case Enum8.const_2:
		{
			if (flag)
			{
				object_ = char_0 - 48L;
				jsonToken_ = JsonToken.Integer;
				break;
			}
			if (flag2)
			{
				string text2 = class30_0.struct4_0.ToString();
				try
				{
					object_ = (text2.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text2, 16) : Convert.ToInt64(text2, 8));
				}
				catch (Exception exception_2)
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid number.".smethod_1(CultureInfo.InvariantCulture, text2), exception_2);
				}
				jsonToken_ = JsonToken.Integer;
				break;
			}
			long long_;
			switch (Class7.smethod_245(class30_0.struct4_0.Chars, class30_0.struct4_0.StartIndex, class30_0.struct4_0.Length, out long_))
			{
			case Enum22.const_1:
				object_ = long_;
				jsonToken_ = JsonToken.Integer;
				break;
			case Enum22.const_2:
			{
				string? text3 = class30_0.struct4_0.ToString();
				if (text3!.Length > 380)
				{
					throw Class7.smethod_772(class30_0, "JSON integer {0} is too large to parse.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
				}
				object_ = Class7.smethod_745(text3, CultureInfo.InvariantCulture);
				jsonToken_ = JsonToken.Integer;
				break;
			}
			default:
				if (class30_0.enum6_0 == Enum6.const_1)
				{
					decimal decimal_;
					Enum22 @enum = Class7.smethod_720(class30_0.struct4_0.Chars, class30_0.struct4_0.StartIndex, class30_0.struct4_0.Length, out decimal_);
					if (@enum != Enum22.const_1)
					{
						throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid decimal.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
					}
					object_ = decimal_;
				}
				else
				{
					if (!double.TryParse(class30_0.struct4_0.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out var result2))
					{
						throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid number.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
					}
					object_ = result2;
				}
				jsonToken_ = JsonToken.Float;
				break;
			}
			break;
		}
		case Enum8.const_4:
		{
			string text6 = class30_0.struct4_0.ToString();
			double result3;
			if (flag2)
			{
				try
				{
					if (text6.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
					{
						Convert.ToInt64(text6, 16);
					}
					else
					{
						Convert.ToInt64(text6, 8);
					}
				}
				catch (Exception exception_5)
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid number.".smethod_1(CultureInfo.InvariantCulture, text6), exception_5);
				}
			}
			else if (!double.TryParse(text6, NumberStyles.Float, CultureInfo.InvariantCulture, out result3))
			{
				throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid number.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
			}
			jsonToken_ = JsonToken.String;
			object_ = text6;
			break;
		}
		case Enum8.const_5:
			if (flag)
			{
				object_ = (decimal)char_0 - 48m;
			}
			else if (flag2)
			{
				string text4 = class30_0.struct4_0.ToString();
				try
				{
					object_ = Convert.ToDecimal(text4.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text4, 16) : Convert.ToInt64(text4, 8));
				}
				catch (Exception exception_3)
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid decimal.".smethod_1(CultureInfo.InvariantCulture, text4), exception_3);
				}
			}
			else
			{
				if (Class7.smethod_720(class30_0.struct4_0.Chars, class30_0.struct4_0.StartIndex, class30_0.struct4_0.Length, out decimal decimal_2) != Enum22.const_1)
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid decimal.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
				}
				object_ = decimal_2;
			}
			jsonToken_ = JsonToken.Float;
			break;
		default:
			throw Class7.smethod_555((Class29)class30_0, "Cannot read number value as type.");
		case Enum8.const_8:
			if (flag)
			{
				object_ = (double)(int)char_0 - 48.0;
			}
			else if (flag2)
			{
				string text = class30_0.struct4_0.ToString();
				try
				{
					object_ = Convert.ToDouble(text.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? Convert.ToInt64(text, 16) : Convert.ToInt64(text, 8));
				}
				catch (Exception exception_)
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid double.".smethod_1(CultureInfo.InvariantCulture, text), exception_);
				}
			}
			else
			{
				if (!double.TryParse(class30_0.struct4_0.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
				{
					throw Class7.smethod_772(class30_0, "Input string '{0}' is not a valid double.".smethod_1(CultureInfo.InvariantCulture, class30_0.struct4_0.ToString()), (Exception)null);
				}
				object_ = result;
			}
			jsonToken_ = JsonToken.Float;
			break;
		}
		Class7.smethod_527(class30_0);
		Class7.smethod_211((Class29)class30_0, jsonToken_, object_, bool_0: false);
	}

	static JToken smethod_732(object object_0, Class34 class34_0)
	{
		return Class7.smethod_497(object_0, class34_0);
	}

	static void smethod_733(Class29 class29_0, string string_0)
	{
		Class7.smethod_686(class29_0);
		if (class29_0.TokenType != JsonToken.PropertyName || !string.Equals(class29_0.Value?.ToString(), string_0, StringComparison.OrdinalIgnoreCase))
		{
			throw new JsonSerializationException("Expected JSON property '{0}'.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
	}

	static bool smethod_734(Class29 class29_0, out long? nullable_0, [Attribute1(false)] out string? string_0)
	{
		nullable_0 = null;
		string_0 = null;
		if (!class29_0.vmethod_0())
		{
			string_0 = "Unexpected end when reading date constructor.";
			return false;
		}
		if (class29_0.TokenType == JsonToken.EndConstructor)
		{
			return true;
		}
		if (class29_0.TokenType != JsonToken.Integer)
		{
			string_0 = "Unexpected token when reading date constructor. Expected Integer, got " + class29_0.TokenType;
			return false;
		}
		nullable_0 = (long)class29_0.Value;
		return true;
	}

	static long smethod_735(long long_0)
	{
		return (long_0 - Class51.long_0) / 10000L;
	}

	static string smethod_736(Class27 class27_0, Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0)
	{
		string text = ((interface11_0.NamespaceUri == null || (interface11_0.LocalName == "xmlns" && interface11_0.NamespaceUri == "http://www.w3.org/2000/xmlns/")) ? null : xmlNamespaceManager_0.LookupPrefix(interface11_0.NamespaceUri));
		if (!Class109.smethod_0(text))
		{
			return text + ":" + XmlConvert.DecodeName(interface11_0.LocalName);
		}
		return XmlConvert.DecodeName(interface11_0.LocalName);
	}

	static void smethod_737(Class30 class30_0, Enum8 enum8_0)
	{
		Class7.smethod_38(class30_0);
		char char_ = class30_0.char_2[class30_0.int_3];
		int int_ = class30_0.int_3;
		Class7.smethod_529(class30_0);
		Class7.smethod_731(enum8_0, char_, int_, class30_0);
	}

	static DateTime? smethod_738(Class29 class29_0, string string_0)
	{
		if (Class109.smethod_0(string_0))
		{
			Class7.smethod_211(class29_0, JsonToken.Null, (object)null, bool_0: false);
			return null;
		}
		if (Class7.smethod_112(string_0, class29_0.enum3_0, class29_0.string_0, class29_0.Culture, out DateTime dateTime_))
		{
			dateTime_ = Class7.smethod_517(dateTime_, class29_0.enum3_0);
			Class7.smethod_211(class29_0, JsonToken.Date, (object)dateTime_, bool_0: false);
			return dateTime_;
		}
		if (!DateTime.TryParse(string_0, class29_0.Culture, DateTimeStyles.RoundtripKind, out dateTime_))
		{
			throw Class7.smethod_555(class29_0, "Could not convert string to DateTime: {0}.".smethod_1(CultureInfo.InvariantCulture, string_0));
		}
		dateTime_ = Class7.smethod_517(dateTime_, class29_0.enum3_0);
		Class7.smethod_211(class29_0, JsonToken.Date, (object)dateTime_, bool_0: false);
		return dateTime_;
	}

	static void smethod_739(Class33 class33_0)
	{
		if (class33_0.byte_4 == null)
		{
			class33_0.byte_4 = new byte[128];
		}
		if (class33_0.char_1 == null)
		{
			int maxCharCount = Encoding.UTF8.GetMaxCharCount(128);
			class33_0.char_1 = new char[maxCharCount];
		}
	}

	static ArgumentOutOfRangeException smethod_740(string string_0, object object_0, string string_1)
	{
		string message = string_1 + Environment.NewLine + "Actual value was {0}.".smethod_1(CultureInfo.InvariantCulture, object_0);
		return new ArgumentOutOfRangeException(string_0, message);
	}

	static void smethod_741(Class43 class43_0, byte[] byte_0, int int_0, ref int int_1)
	{
		int num = int_1 % 3;
		if (num > 0)
		{
			int_1 -= num;
			if (class43_0.byte_0 == null)
			{
				class43_0.byte_0 = new byte[3];
			}
			for (int i = 0; i < num; i++)
			{
				class43_0.byte_0[i] = byte_0[int_0 + int_1 + i];
			}
		}
		class43_0.int_2 = num;
	}

	static void smethod_742(Class38 class38_0, Class29 class29_0, bool bool_0)
	{
		Class113.smethod_0(class29_0, "reader");
		class38_0.vmethod_12(class29_0, bool_0, bool_3: true, bool_4: true);
	}

	static Class179 smethod_743()
	{
		return new Class179(null, JTokenType.Undefined);
	}

	static void smethod_744(Class242 class242_0, Class243 class243_0, string string_0)
	{
		class243_0.list_0.Add(new Class251
		{
			Name = new Class248(string_0, bool_1: false),
			Value = class242_0
		});
		class242_0.Parent = class243_0;
	}

	static object smethod_745(string string_0, CultureInfo cultureInfo_0)
	{
		return BigInteger.Parse(string_0, cultureInfo_0);
	}

	static void smethod_746(JsonValidatingReader jsonValidatingReader_0, JsonSchemaModel jsonSchemaModel_0)
	{
		if (jsonSchemaModel_0 == null)
		{
			return;
		}
		Dictionary<string, bool> dictionary_ = jsonValidatingReader_0.schemaScope_0.dictionary_0;
		if (dictionary_ != null && dictionary_.Values.Any((bool bool_0) => !bool_0))
		{
			IEnumerable<string> values = from keyValuePair_0 in dictionary_
				where !keyValuePair_0.Value
				select keyValuePair_0.Key;
			Class7.smethod_239(jsonValidatingReader_0, "Required properties are missing from object: {0}.".smethod_1(CultureInfo.InvariantCulture, string.Join(", ", values)), jsonSchemaModel_0);
		}
	}

	static void smethod_747(Class39 class39_0, ulong ulong_0, bool bool_0)
	{
		if (!bool_0 && ulong_0 <= 9L)
		{
			class39_0.textWriter_0.Write((char)(48L + ulong_0));
			return;
		}
		int count = Class7.smethod_286(class39_0, ulong_0, bool_0);
		class39_0.textWriter_0.Write(class39_0.char_2, 0, count);
	}

	static void smethod_748(FieldMultipleFilter.Class211 class211_0)
	{
		class211_0.int_0 = -3;
		((IDisposable)class211_0.enumerator_0).Dispose();
	}

	static JsonSchemaType smethod_749(Enum16 enum16_0, Class167 class167_0, Type type_0)
	{
		JsonSchemaType jsonSchemaType = JsonSchemaType.None;
		if (enum16_0 != Enum16.const_2 && Class7.smethod_213(type_0))
		{
			jsonSchemaType = JsonSchemaType.Null;
			if (Class7.smethod_157(type_0))
			{
				type_0 = Nullable.GetUnderlyingType(type_0);
			}
		}
		Enum21 @enum = Class7.smethod_524(type_0);
		switch (@enum)
		{
		case Enum21.const_0:
		case Enum21.const_1:
			return jsonSchemaType | JsonSchemaType.String;
		case Enum21.const_2:
			return jsonSchemaType | JsonSchemaType.String;
		case Enum21.const_4:
			return jsonSchemaType | JsonSchemaType.Boolean;
		case Enum21.const_26:
		case Enum21.const_28:
			return jsonSchemaType | JsonSchemaType.String;
		case Enum21.const_22:
		case Enum21.const_24:
		case Enum21.const_30:
			return jsonSchemaType | JsonSchemaType.Float;
		case Enum21.const_6:
		case Enum21.const_8:
		case Enum21.const_10:
		case Enum21.const_12:
		case Enum21.const_14:
		case Enum21.const_16:
		case Enum21.const_18:
		case Enum21.const_20:
		case Enum21.const_36:
			return jsonSchemaType | JsonSchemaType.Integer;
		default:
			throw new JsonException("Unexpected type code '{0}' for type '{1}'.".smethod_2(CultureInfo.InvariantCulture, @enum, type_0));
		case Enum21.const_32:
		case Enum21.const_34:
		case Enum21.const_38:
		case Enum21.const_39:
		case Enum21.const_40:
			return jsonSchemaType | JsonSchemaType.String;
		case Enum21.const_41:
			return jsonSchemaType | JsonSchemaType.Null;
		}
	}

	static void smethod_750(Class36 class36_0, Class34 class34_0)
	{
		if (!Class45.smethod_0(class36_0.Converters))
		{
			for (int i = 0; i < class36_0.Converters.Count; i++)
			{
				class34_0.Converters.Insert(i, class36_0.Converters[i]);
			}
		}
		if (class36_0.nullable_18.HasValue)
		{
			class34_0.TypeNameHandling = class36_0.TypeNameHandling;
		}
		if (class36_0.nullable_19.HasValue)
		{
			class34_0.MetadataPropertyHandling = class36_0.MetadataPropertyHandling;
		}
		if (class36_0.nullable_9.HasValue)
		{
			class34_0.TypeNameAssemblyFormatHandling = class36_0.TypeNameAssemblyFormatHandling;
		}
		if (class36_0.nullable_11.HasValue)
		{
			class34_0.PreserveReferencesHandling = class36_0.PreserveReferencesHandling;
		}
		if (class36_0.nullable_15.HasValue)
		{
			class34_0.ReferenceLoopHandling = class36_0.ReferenceLoopHandling;
		}
		if (class36_0.nullable_14.HasValue)
		{
			class34_0.MissingMemberHandling = class36_0.MissingMemberHandling;
		}
		if (class36_0.nullable_13.HasValue)
		{
			class34_0.ObjectCreationHandling = class36_0.ObjectCreationHandling;
		}
		if (class36_0.nullable_12.HasValue)
		{
			class34_0.NullValueHandling = class36_0.NullValueHandling;
		}
		if (class36_0.nullable_10.HasValue)
		{
			class34_0.DefaultValueHandling = class36_0.DefaultValueHandling;
		}
		if (class36_0.nullable_17.HasValue)
		{
			class34_0.ConstructorHandling = class36_0.ConstructorHandling;
		}
		if (class36_0.nullable_16.HasValue)
		{
			class34_0.Context = class36_0.Context;
		}
		if (class36_0.nullable_7.HasValue)
		{
			class34_0.nullable_8 = class36_0.nullable_7;
		}
		if (class36_0.Error != null)
		{
			class34_0.Error += class36_0.Error;
		}
		if (class36_0.ContractResolver != null)
		{
			class34_0.ContractResolver = class36_0.ContractResolver;
		}
		if (class36_0.ReferenceResolverProvider != null)
		{
			class34_0.ReferenceResolver = class36_0.ReferenceResolverProvider!();
		}
		if (class36_0.TraceWriter != null)
		{
			class34_0.TraceWriter = class36_0.TraceWriter;
		}
		if (class36_0.EqualityComparer != null)
		{
			class34_0.EqualityComparer = class36_0.EqualityComparer;
		}
		if (class36_0.SerializationBinder != null)
		{
			class34_0.SerializationBinder = class36_0.SerializationBinder;
		}
		if (class36_0.nullable_0.HasValue)
		{
			class34_0.nullable_0 = class36_0.nullable_0;
		}
		if (class36_0.nullable_1.HasValue)
		{
			class34_0.nullable_1 = class36_0.nullable_1;
		}
		if (class36_0.nullable_2.HasValue)
		{
			class34_0.nullable_2 = class36_0.nullable_2;
		}
		if (class36_0.nullable_3.HasValue)
		{
			class34_0.nullable_3 = class36_0.nullable_3;
		}
		if (class36_0.bool_2)
		{
			class34_0.string_0 = class36_0.string_1;
			class34_0.bool_1 = class36_0.bool_2;
		}
		if (class36_0.nullable_4.HasValue)
		{
			class34_0.nullable_4 = class36_0.nullable_4;
		}
		if (class36_0.nullable_5.HasValue)
		{
			class34_0.nullable_5 = class36_0.nullable_5;
		}
		if (class36_0.nullable_6.HasValue)
		{
			class34_0.nullable_6 = class36_0.nullable_6;
		}
		if (class36_0.cultureInfo_1 != null)
		{
			class34_0.cultureInfo_0 = class36_0.cultureInfo_1;
		}
		if (class36_0.bool_1)
		{
			class34_0.nullable_7 = class36_0.nullable_8;
			class34_0.bool_0 = class36_0.bool_1;
		}
	}

	static object smethod_751(JsonSerializerInternalReader jsonSerializerInternalReader_0, IDictionary idictionary_0, Class29 class29_0, Class140? class140_0, JsonProperty? jsonProperty_0, string string_0)
	{
		object obj = ((idictionary_0 is Interface3 @interface) ? @interface.UnderlyingDictionary : idictionary_0);
		if (string_0 != null)
		{
			Class7.smethod_398(obj, jsonSerializerInternalReader_0, string_0, class29_0);
		}
		Class7.smethod_208(jsonSerializerInternalReader_0, class29_0, (Class137)class140_0, obj);
		int depth = class29_0.Depth;
		if (class140_0!.KeyContract == null)
		{
			class140_0!.KeyContract = jsonSerializerInternalReader_0.method_1(class140_0!.DictionaryKeyType);
		}
		if (class140_0!.class137_0 == null)
		{
			class140_0!.ItemContract = jsonSerializerInternalReader_0.method_1(class140_0!.DictionaryValueType);
		}
		Class9 @class = class140_0!.ItemConverter ?? jsonSerializerInternalReader_0.method_5(class140_0!.class137_0, null, class140_0, jsonProperty_0);
		Enum21 @enum = ((class140_0!.KeyContract is Class145 class2) ? class2.TypeCode : Enum21.const_0);
		bool flag = false;
		do
		{
			JsonToken tokenType = class29_0.TokenType;
			if (tokenType == JsonToken.PropertyName)
			{
				object obj2 = class29_0.Value;
				if (Class7.smethod_628(obj2.ToString(), class29_0, jsonSerializerInternalReader_0))
				{
					continue;
				}
				try
				{
					try
					{
						switch (@enum)
						{
						default:
							obj2 = ((class140_0!.KeyContract == null || !class140_0!.KeyContract!.bool_2) ? jsonSerializerInternalReader_0.method_12(class29_0, obj2, CultureInfo.InvariantCulture, class140_0!.KeyContract, class140_0!.DictionaryKeyType) : Class7.smethod_62(class140_0!.KeyContract!.type_0, (jsonSerializerInternalReader_0.class34_0.interface4_0 as DefaultContractResolver)?.NamingStrategy, obj2.ToString(), bool_0: false));
							break;
						case Enum21.const_28:
						case Enum21.const_29:
						{
							obj2 = (Class7.smethod_439(obj2.ToString(), class29_0.string_0, class29_0.Culture, out DateTimeOffset dateTimeOffset_) ? ((object)dateTimeOffset_) : jsonSerializerInternalReader_0.method_12(class29_0, obj2, CultureInfo.InvariantCulture, class140_0!.KeyContract, class140_0!.DictionaryKeyType));
							break;
						}
						case Enum21.const_26:
						case Enum21.const_27:
						{
							obj2 = (Class7.smethod_112(obj2.ToString(), class29_0.enum3_0, class29_0.string_0, class29_0.Culture, out DateTime dateTime_) ? ((object)dateTime_) : jsonSerializerInternalReader_0.method_12(class29_0, obj2, CultureInfo.InvariantCulture, class140_0!.KeyContract, class140_0!.DictionaryKeyType));
							break;
						}
						}
					}
					catch (Exception exception_)
					{
						throw Class7.smethod_383("Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".smethod_2(CultureInfo.InvariantCulture, class29_0.Value, class140_0!.DictionaryKeyType), exception_, class29_0);
					}
					if (!Class7.smethod_440(class29_0, class140_0!.class137_0, @class != null))
					{
						throw Class7.smethod_161(class29_0, "Unexpected end when deserializing object.");
					}
					object obj4 = (idictionary_0[obj2] = ((@class == null || !@class.CanRead) ? jsonSerializerInternalReader_0.method_4(class29_0, class140_0!.DictionaryValueType, class140_0!.class137_0, null, class140_0, jsonProperty_0, null) : Class7.smethod_716(jsonSerializerInternalReader_0, @class, class29_0, class140_0!.DictionaryValueType, (object)null)));
				}
				catch (Exception exception_2)
				{
					if (!jsonSerializerInternalReader_0.method_0(obj, class140_0, obj2, class29_0 as Interface1, class29_0.Path, exception_2))
					{
						throw;
					}
					Class7.smethod_53(class29_0, bool_0: true, jsonSerializerInternalReader_0, depth);
				}
			}
			else if (tokenType != JsonToken.Comment)
			{
				if (tokenType != JsonToken.EndObject)
				{
					throw Class7.smethod_161(class29_0, "Unexpected token when deserializing object: " + class29_0.TokenType);
				}
				flag = true;
			}
		}
		while (!flag && class29_0.vmethod_0());
		if (!flag)
		{
			Class7.smethod_574(obj, class29_0, "Unexpected end when deserializing object.", jsonSerializerInternalReader_0, (Class137)class140_0);
		}
		Class7.smethod_296(jsonSerializerInternalReader_0, class29_0, (Class137)class140_0, obj);
		return obj;
	}

	static void smethod_752(Class38 class38_0, JsonContainerType jsonContainerType_0)
	{
		switch (jsonContainerType_0)
		{
		default:
			throw Class7.smethod_188(class38_0, "Unexpected type when writing end: " + jsonContainerType_0, (Exception?)null);
		case JsonContainerType.Object:
			class38_0.vmethod_4();
			break;
		case JsonContainerType.Array:
			class38_0.vmethod_6();
			break;
		case JsonContainerType.Constructor:
			class38_0.vmethod_8();
			break;
		}
	}

	static Interface13 smethod_753(Interface12 interface12_0, XmlNamespaceManager xmlNamespaceManager_0, string? string_0, Class27 class27_0, string string_1)
	{
		string string_2 = (class27_0.EncodeSpecialCharacters ? XmlConvert.EncodeLocalName(string_1) : XmlConvert.EncodeName(string_1));
		string text = (Class109.smethod_0(string_0) ? xmlNamespaceManager_0.DefaultNamespace : xmlNamespaceManager_0.LookupNamespace(string_0));
		if (Class109.smethod_0(text))
		{
			return interface12_0.imethod_9(string_2);
		}
		return interface12_0.imethod_10(string_2, text);
	}

	static bool smethod_754(out List<Class198>? list_0, Class212 class212_0)
	{
		if (class212_0.string_0[class212_0.int_0] == '$')
		{
			list_0 = new List<Class198> { Class205.class205_0 };
		}
		else
		{
			if (class212_0.string_0[class212_0.int_0] != '@')
			{
				list_0 = null;
				return false;
			}
			list_0 = new List<Class198>();
		}
		class212_0.int_0++;
		if (class212_0.method_1(list_0, class212_0.int_0, bool_0: true))
		{
			throw new JsonException("Path ended with open query.");
		}
		return true;
	}

	static Enum9 smethod_755(bool bool_0, Type type_0)
	{
		Attribute8 attribute = JsonTypeReflector.smethod_0<Attribute8>(type_0);
		if (attribute != null)
		{
			return attribute.enum9_0;
		}
		if (Class7.smethod_722(type_0) != null)
		{
			return Enum9.const_1;
		}
		if (!bool_0 && Class7.smethod_217((object)type_0))
		{
			return Enum9.const_2;
		}
		return Enum9.const_0;
	}

	static Class77 smethod_756(Struct5<Type, Class115?> struct5_0)
	{
		Type gparam_ = struct5_0.gparam_0;
		string[] names = Enum.GetNames(gparam_);
		string[] array = new string[names.Length];
		ulong[] array2 = new ulong[names.Length];
		for (int i = 0; i < names.Length; i++)
		{
			string text = names[i];
			FieldInfo field = gparam_.GetField(text, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			array2[i] = Class7.smethod_126(field.GetValue(null));
			string text2 = (from EnumMemberAttribute enumMemberAttribute_0 in field.GetCustomAttributes(typeof(EnumMemberAttribute), inherit: true)
				select enumMemberAttribute_0.Value).SingleOrDefault();
			bool bool_ = text2 != null;
			if (text2 == null)
			{
				text2 = text;
			}
			string text3 = text2;
			if (Array.IndexOf(array, text3, 0, i) == -1)
			{
				array[i] = ((struct5_0.gparam_1 != null) ? struct5_0.gparam_1!.vmethod_0(text3, bool_) : text3);
				continue;
			}
			throw new InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".smethod_2(CultureInfo.InvariantCulture, text3, gparam_.Name));
		}
		return new Class77(gparam_.IsDefined(typeof(FlagsAttribute), inherit: false), array2, names, array);
	}

	static JToken smethod_757(Guid guid_0)
	{
		return new Class179(guid_0);
	}

	static object? smethod_758(Class22 class22_0, Class29 class29_0)
	{
		if (!Class7.smethod_407(class29_0))
		{
			throw Class7.smethod_161(class29_0, "Unexpected end when reading ExpandoObject.");
		}
		switch (class29_0.TokenType)
		{
		default:
			if (Class7.smethod_397(class29_0.TokenType))
			{
				return class29_0.Value;
			}
			throw Class7.smethod_161(class29_0, "Unexpected token when converting ExpandoObject: {0}".smethod_1(CultureInfo.InvariantCulture, class29_0.TokenType));
		case JsonToken.StartArray:
			return Class7.smethod_519(class22_0, class29_0);
		case JsonToken.StartObject:
			return Class7.smethod_19(class22_0, class29_0);
		}
	}

	static int smethod_759(char[] char_0, int int_0, TimeSpan timeSpan_0, Enum1 enum1_0)
	{
		char_0[int_0++] = ((timeSpan_0.Ticks >= 0L) ? '+' : '-');
		int int_ = Math.Abs(timeSpan_0.Hours);
		Class7.smethod_448(int_, char_0, int_0, 2);
		int_0 += 2;
		if (enum1_0 == Enum1.const_0)
		{
			char_0[int_0++] = ':';
		}
		int int_2 = Math.Abs(timeSpan_0.Minutes);
		Class7.smethod_448(int_2, char_0, int_0, 2);
		int_0 += 2;
		return int_0;
	}

	static byte[] smethod_760(Class33 class33_0, int int_0)
	{
		Class7.smethod_452(class33_0, int_0);
		return class33_0.binaryReader_0.ReadBytes(int_0);
	}

	static void smethod_761(Class42 class42_0, Class242 class242_0)
	{
		if (class42_0.class242_1 != null)
		{
			if (class42_0.class242_1 is Class243 class243_)
			{
				Class7.smethod_744(class242_0, class243_, class42_0.string_1);
				class42_0.string_1 = null;
			}
			else
			{
				((Class244)class42_0.class242_1).Add(class242_0);
			}
			return;
		}
		if (class242_0.Type != BsonType.Object && class242_0.Type != BsonType.Array)
		{
			throw Class7.smethod_188((Class38)class42_0, "Error writing {0} value. BSON must start with an Object or Array.".smethod_1(CultureInfo.InvariantCulture, class242_0.Type), (Exception?)null);
		}
		class42_0.class242_1 = class242_0;
		class42_0.class242_0 = class242_0;
	}

	static Class100 smethod_762(Type type_0, params string[] string_0)
	{
		return Class7.smethod_81(type_0, (MethodBase?)null, string_0);
	}

	static void smethod_763(Class29 class29_0, JsonToken jsonToken_0)
	{
		JsonContainerType jsonContainerType = Class7.smethod_279(class29_0);
		if (Class7.smethod_102(jsonToken_0, class29_0) != jsonContainerType)
		{
			throw Class7.smethod_555(class29_0, "JsonToken {0} is not valid for closing JsonType {1}.".smethod_2(CultureInfo.InvariantCulture, jsonToken_0, jsonContainerType));
		}
		if (class29_0.struct0_0.jsonContainerType_0 == JsonContainerType.None && !class29_0.SupportMultipleContent)
		{
			Class7.smethod_54(class29_0);
		}
		else
		{
			class29_0.state_0 = Class29.State.PostValue;
		}
	}

	static JToken smethod_764(byte byte_0)
	{
		return new Class179(byte_0);
	}

	static void smethod_765(Class30 class30_0, bool bool_0)
	{
		if (bool_0 && class30_0.char_2[class30_0.int_3] == '\n')
		{
			class30_0.int_3++;
		}
		Class7.smethod_561(class30_0, class30_0.int_3);
	}

	static short smethod_766(JToken jtoken_0)
	{
		Class179 @class = Class7.smethod_107(jtoken_0);
		if (@class != null && Class7.smethod_154(bool_0: false, (JToken)@class, JToken.jtokenType_1))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (short)bigInteger;
			}
			return Convert.ToInt16(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int16.".smethod_1(CultureInfo.InvariantCulture, Class7.smethod_131(jtoken_0)));
	}

	static string smethod_767(string string_0)
	{
		if (string_0.IndexOf('.') != -1)
		{
			return string_0;
		}
		return string_0 + ".0";
	}

	static void smethod_768(JsonSchema jsonSchema_0, Class170 class170_0, JsonSchemaNode jsonSchemaNode_0)
	{
		jsonSchemaNode_0.AdditionalItems = Class7.smethod_503(jsonSchemaNode_0.AdditionalItems, class170_0, jsonSchema_0);
	}

	static Class177 smethod_769(string string_0)
	{
		return Class7.smethod_175(string_0, (Class193?)null);
	}

	static void smethod_770(Class38 class38_0)
	{
	}

	static object smethod_771(bool bool_0, Enum8 enum8_0, Class30 class30_0)
	{
		if (bool_0)
		{
			switch (enum8_0)
			{
			case Enum8.const_4:
				Class7.smethod_186((Class29)class30_0, JsonToken.String, (object)Class8.string_4);
				return Class8.string_4;
			case Enum8.const_0:
			case Enum8.const_8:
				if (class30_0.enum6_0 == Enum6.const_0)
				{
					Class7.smethod_186((Class29)class30_0, JsonToken.Float, (object)double.PositiveInfinity);
					return double.PositiveInfinity;
				}
				goto default;
			default:
				throw Class7.smethod_555((Class29)class30_0, "Cannot read Infinity value.");
			}
		}
		throw Class7.smethod_555((Class29)class30_0, "Error parsing Infinity value.");
	}

	static JsonReaderException smethod_772(Class30 class30_0, string? string_0 = null, Exception exception_0)
	{
		Class7.smethod_211((Class29)class30_0, JsonToken.Undefined, (object)null, bool_0: false);
		return Class7.smethod_271(string_0, (Class29)class30_0, exception_0);
	}

	static void smethod_773(long long_0, Class39 class39_0)
	{
		if (long_0 >= 0L && long_0 <= 9L)
		{
			class39_0.textWriter_0.Write((char)(48L + long_0));
			return;
		}
		bool flag = long_0 < 0L;
		Class7.smethod_747(class39_0, (ulong)(flag ? (-long_0) : long_0), flag);
	}

	static bool smethod_774(Type type_0)
	{
		Class113.smethod_0(type_0, "type");
		if (typeof(IDictionary).IsAssignableFrom(type_0))
		{
			return true;
		}
		if (Class7.smethod_554(type_0, typeof(IDictionary<, >)))
		{
			return true;
		}
		return false;
	}

	static bool smethod_775(Class192 class192_0, string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("key");
		}
		if (class192_0.dictionary_0 != null)
		{
			return class192_0.dictionary_0!.ContainsKey(string_0);
		}
		return false;
	}

	static bool smethod_776(Class38 class38_0, Class29 class29_0, bool bool_0, int int_0)
	{
		int num = Class7.smethod_677(class38_0, class29_0);
		if (int_0 >= num)
		{
			if (bool_0 && int_0 == num)
			{
				return Class7.smethod_687(class29_0.TokenType);
			}
			return false;
		}
		return true;
	}

	static Expression smethod_777(MethodBase methodBase_0, Type type_0, ParameterExpression? parameterExpression_0, ParameterExpression parameterExpression_1, Class70 class70_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		Expression[] array;
		IList<Class70.Class78> list;
		if (parameters.Length == 0)
		{
			array = Class45.smethod_10<Expression>();
			list = Class45.smethod_10<Class70.Class78>();
		}
		else
		{
			array = new Expression[parameters.Length];
			list = new List<Class70.Class78>();
			for (int i = 0; i < parameters.Length; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				Type type = parameterInfo.ParameterType;
				bool flag = false;
				if (type.IsByRef)
				{
					type = type.GetElementType();
					flag = true;
				}
				Expression index = Expression.Constant(i);
				Expression expression_ = Expression.ArrayIndex(parameterExpression_0, index);
				Expression expression = class70_0.method_2(expression_, type, !flag);
				if (flag)
				{
					ParameterExpression parameterExpression = Expression.Variable(type);
					list.Add(new Class70.Class78(expression, parameterExpression, parameterInfo.IsOut));
					expression = parameterExpression;
				}
				array[i] = expression;
			}
		}
		Expression expression2 = (methodBase_0.IsConstructor ? ((Expression)Expression.New((ConstructorInfo)methodBase_0, array)) : ((Expression)((!methodBase_0.IsStatic) ? Expression.Call(class70_0.method_2(parameterExpression_1, methodBase_0.DeclaringType), (MethodInfo)methodBase_0, array) : Expression.Call((MethodInfo)methodBase_0, array))));
		expression2 = ((!(methodBase_0 is MethodInfo methodInfo)) ? class70_0.method_2(expression2, type_0) : ((!(methodInfo.ReturnType != typeof(void))) ? Expression.Block(expression2, Expression.Constant(null)) : class70_0.method_2(expression2, type_0)));
		if (list.Count > 0)
		{
			IList<ParameterExpression> list2 = new List<ParameterExpression>();
			IList<Expression> list3 = new List<Expression>();
			foreach (Class70.Class78 item in list)
			{
				if (!item.bool_0)
				{
					list3.Add(Expression.Assign(item.parameterExpression_0, item.expression_0));
				}
				list2.Add(item.parameterExpression_0);
			}
			list3.Add(expression2);
			expression2 = Expression.Block(list2, list3);
		}
		return expression2;
	}
}
