using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using ns0;
using ns1;
using ns10;
using ns12;
using ns13;
using ns14;
using ns15;
using ns17;
using ns18;
using ns19;
using ns3;
using ns4;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace Newtonsoft.Json.Serialization;

internal class JsonSerializerInternalReader : Class151
{
	internal enum PropertyPresence
	{
		None,
		Null,
		Value
	}

	internal class Class154
	{
		public readonly string string_0;

		public JsonProperty? jsonProperty_0;

		public JsonProperty? jsonProperty_1;

		public PropertyPresence? nullable_0;

		public object? object_0;

		public bool bool_0;

		public Class154(string string_1)
		{
			string_0 = string_1;
		}
	}

	[CompilerGenerated]
	private sealed class Class155
	{
		public JsonProperty jsonProperty_0;

		internal bool method_0(Class154 class154_0)
		{
			return class154_0.jsonProperty_0 != jsonProperty_0;
		}
	}

	public JsonSerializerInternalReader(Class33 serializer)
		: base(serializer)
	{
	}

	internal Class137? method_1(Type? type_0)
	{
		if (type_0 == null)
		{
			return null;
		}
		return Class131.smethod_601(this, type_0);
	}

	public object? method_2(Class28 class28_0, Type? type_0, bool bool_0)
	{
		if (class28_0 == null)
		{
			throw new ArgumentNullException("reader");
		}
		Class137 @class = method_1(type_0);
		try
		{
			Class8 class2 = method_5(@class, null, null, null);
			if (class28_0.TokenType == JsonToken.None && !Class131.smethod_607(class28_0, @class, class2 != null))
			{
				if (@class != null && !@class.bool_0)
				{
					throw Class131.smethod_38(class28_0, "No JSON content found and type '{0}' is not nullable.".smethod_1(CultureInfo.InvariantCulture, @class.UnderlyingType));
				}
				return null;
			}
			object result = ((class2 == null || !class2.CanRead) ? method_4(class28_0, type_0, @class, null, null, null, null) : Class131.smethod_701(this, class2, class28_0, type_0, (object)null));
			if (bool_0)
			{
				while (class28_0.vmethod_0())
				{
					if (class28_0.TokenType != JsonToken.Comment)
					{
						throw Class131.smethod_38(class28_0, "Additional text found in JSON string after finishing deserializing object.");
					}
				}
			}
			return result;
		}
		catch (Exception exception_)
		{
			if (!method_0(null, @class, null, class28_0 as Interface1, class28_0.Path, exception_))
			{
				Class131.smethod_52((Class151)this);
				throw;
			}
			Class131.smethod_295(0, bool_0: false, this, class28_0);
			return null;
		}
	}

	private JToken? method_3(Class28 class28_0, Class137? class137_0)
	{
		Class112.smethod_0(class28_0, "reader");
		if (class137_0 != null)
		{
			if (class137_0!.UnderlyingType == typeof(Class180))
			{
				return Class131.smethod_688(class28_0);
			}
			if (class28_0.TokenType == JsonToken.Null && !(class137_0!.UnderlyingType == typeof(Class179)) && !(class137_0!.UnderlyingType == typeof(JToken)))
			{
				return null;
			}
		}
		JToken token;
		using (Class40 @class = new Class40())
		{
			Class131.smethod_157((Class37)@class, class28_0);
			token = @class.Token;
		}
		if (class137_0 != null && token != null && !class137_0!.UnderlyingType.IsAssignableFrom(token.GetType()))
		{
			throw Class131.smethod_38(class28_0, "Deserialized JSON type '{0}' is not compatible with expected type '{1}'.".smethod_2(CultureInfo.InvariantCulture, token.GetType().FullName, class137_0!.UnderlyingType.FullName));
		}
		return token;
	}

	internal object? method_4(Class28 class28_0, Type? type_0, Class137? class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1, object? object_0)
	{
		if (class137_0 != null && class137_0!.enum26_0 == Enum26.const_8)
		{
			return method_3(class28_0, class137_0);
		}
		do
		{
			switch (class28_0.TokenType)
			{
			case JsonToken.Comment:
				break;
			case JsonToken.StartObject:
				return method_6(class28_0, type_0, class137_0, jsonProperty_0, class138_0, jsonProperty_1, object_0);
			case JsonToken.StartArray:
				return method_10(class28_0, type_0, class137_0, jsonProperty_0, object_0, null);
			case JsonToken.StartConstructor:
			{
				string object_ = class28_0.Value!.ToString();
				return method_12(class28_0, object_, CultureInfo.InvariantCulture, class137_0, type_0);
			}
			case JsonToken.Raw:
				return new Class180((string)class28_0.Value);
			case JsonToken.String:
			{
				string text = (string)class28_0.Value;
				if (type_0 == typeof(byte[]))
				{
					return Convert.FromBase64String(text);
				}
				if (smethod_0(type_0, class137_0, text))
				{
					return null;
				}
				return method_12(class28_0, text, CultureInfo.InvariantCulture, class137_0, type_0);
			}
			case JsonToken.Null:
			case JsonToken.Undefined:
				if (type_0 == typeof(DBNull))
				{
					return DBNull.Value;
				}
				return method_12(class28_0, class28_0.Value, CultureInfo.InvariantCulture, class137_0, type_0);
			default:
				throw Class131.smethod_38(class28_0, "Unexpected token while deserializing object: " + class28_0.TokenType);
			case JsonToken.Integer:
			case JsonToken.Float:
			case JsonToken.Boolean:
			case JsonToken.Date:
			case JsonToken.Bytes:
				return method_12(class28_0, class28_0.Value, CultureInfo.InvariantCulture, class137_0, type_0);
			}
		}
		while (class28_0.vmethod_0());
		throw Class131.smethod_38(class28_0, "Unexpected end when deserializing object.");
	}

	internal static bool smethod_0(Type? type_0, Class137? class137_0, string string_0)
	{
		if (Class108.smethod_0(string_0) && type_0 != null && type_0 != typeof(string) && type_0 != typeof(object) && class137_0 != null)
		{
			return class137_0!.bool_0;
		}
		return false;
	}

	internal Class8? method_5(Class137? class137_0, Class8? class8_0, Class138? class138_0, JsonProperty? jsonProperty_0)
	{
		Class8 result = null;
		if (class8_0 != null)
		{
			result = class8_0;
		}
		else if (jsonProperty_0?.ItemConverter != null)
		{
			result = jsonProperty_0!.ItemConverter;
		}
		else if (class138_0?.ItemConverter != null)
		{
			result = class138_0!.ItemConverter;
		}
		else if (class137_0 != null)
		{
			if (class137_0!.Converter != null)
			{
				result = class137_0!.Converter;
			}
			else
			{
				Class8 @class = Class131.smethod_1(class33_0, class137_0!.UnderlyingType);
				if (@class != null)
				{
					result = @class;
				}
				else if (class137_0!.InternalConverter != null)
				{
					result = class137_0!.InternalConverter;
				}
			}
		}
		return result;
	}

	private object? method_6(Class28 class28_0, Type? type_0, Class137? class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1, object? object_0)
	{
		Type type_ = type_0;
		string string_;
		if (class33_0.MetadataPropertyHandling == Enum10.const_2)
		{
			Class131.smethod_167(class28_0);
			string_ = null;
		}
		else if (class33_0.MetadataPropertyHandling == Enum10.const_1)
		{
			Class31 @class = class28_0 as Class31;
			if (@class == null)
			{
				@class = new Class31(Class131.smethod_742(class28_0));
				@class.Culture = class28_0.Culture;
				@class.string_0 = class28_0.string_0;
				@class.DateParseHandling = class28_0.enum2_0;
				@class.DateTimeZoneHandling = class28_0.enum3_0;
				@class.FloatParseHandling = class28_0.enum6_0;
				@class.SupportMultipleContent = class28_0.SupportMultipleContent;
				Class131.smethod_167((Class28)@class);
				class28_0 = @class;
			}
			if (method_7(@class, ref type_, ref class137_0, jsonProperty_0, class138_0, jsonProperty_1, object_0, out var object_, out string_))
			{
				return object_;
			}
		}
		else
		{
			Class131.smethod_167(class28_0);
			if (method_8(class28_0, ref type_, ref class137_0, jsonProperty_0, class138_0, jsonProperty_1, object_0, out var object_2, out string_))
			{
				return object_2;
			}
		}
		if (method_11(class137_0))
		{
			return Class131.smethod_259(class28_0, this);
		}
		switch (class137_0!.enum26_0)
		{
		case Enum26.const_1:
		{
			bool bool_2 = false;
			Class143 class143_ = (Class143)class137_0;
			object obj = ((object_0 == null || (!(type_ == type_0) && !type_.IsAssignableFrom(object_0!.GetType()))) ? Class131.smethod_184(this, class28_0, class143_, jsonProperty_0, jsonProperty_1, string_, ref bool_2) : object_0);
			if (bool_2)
			{
				return obj;
			}
			return method_16(obj, class28_0, class143_, jsonProperty_0, string_);
		}
		case Enum26.const_3:
		{
			Class145 class137_ = (Class145)class137_0;
			if (class33_0.MetadataPropertyHandling != Enum10.const_2 && class28_0.TokenType == JsonToken.PropertyName && string.Equals(class28_0.Value!.ToString(), "$value", StringComparison.Ordinal))
			{
				Class131.smethod_167(class28_0);
				if (class28_0.TokenType == JsonToken.StartObject)
				{
					throw Class131.smethod_38(class28_0, "Unexpected token when deserializing primitive value: " + class28_0.TokenType);
				}
				object? result = method_4(class28_0, type_, class137_, jsonProperty_0, null, null, object_0);
				Class131.smethod_167(class28_0);
				return result;
			}
			goto default;
		}
		default:
		{
			string string_2 = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + Environment.NewLine;
			string_2 = string_2.smethod_2(CultureInfo.InvariantCulture, type_, Class131.smethod_275(class137_0, this));
			throw Class131.smethod_38(class28_0, string_2);
		}
		case Enum26.const_5:
		{
			Class140 class2 = (Class140)class137_0;
			if (object_0 == null)
			{
				bool bool_ = default(bool);
				IDictionary dictionary = Class131.smethod_355(class28_0, class2, this, ref bool_);
				if (bool_)
				{
					if (string_ != null)
					{
						throw Class131.smethod_38(class28_0, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
					}
					if (class137_0!.OnSerializingCallbacks.Count > 0)
					{
						throw Class131.smethod_38(class28_0, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
					}
					if (class137_0!.OnErrorCallbacks.Count > 0)
					{
						throw Class131.smethod_38(class28_0, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
					}
					if (!class2.HasParameterizedCreatorInternal)
					{
						throw Class131.smethod_38(class28_0, "Cannot deserialize readonly or fixed size dictionary: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
					}
				}
				Class131.smethod_110(this, dictionary, class28_0, class2, jsonProperty_0, string_);
				if (bool_)
				{
					return (class2.delegate7_1 ?? class2.ParameterizedCreator)!(dictionary);
				}
				if (dictionary is Interface3 @interface)
				{
					return @interface.UnderlyingDictionary;
				}
				return dictionary;
			}
			object idictionary_;
			if (!class2.ShouldCreateWrapper && object_0 is IDictionary)
			{
				idictionary_ = (IDictionary)object_0;
			}
			else
			{
				IDictionary dictionary2 = class2.method_5(object_0);
				idictionary_ = dictionary2;
			}
			return Class131.smethod_110(this, (IDictionary)idictionary_, class28_0, class2, jsonProperty_0, string_);
		}
		case Enum26.const_6:
		{
			Class141 class141_ = (Class141)class137_0;
			return Class131.smethod_622(string_, class141_, this, class28_0, jsonProperty_0);
		}
		case Enum26.const_7:
		{
			Class142 class142_ = (Class142)class137_0;
			return Class131.smethod_341(class142_, class28_0, string_, this, jsonProperty_0);
		}
		}
	}

	private bool method_7(Class31 class31_0, ref Type? type_0, ref Class137? class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1, object? object_0, out object? object_1, out string? string_0)
	{
		string_0 = null;
		object_1 = null;
		if (class31_0.TokenType == JsonToken.StartObject)
		{
			JObject jObject = (JObject)class31_0.CurrentToken;
			JProperty jProperty = Class131.smethod_517(jObject, "$ref", StringComparison.Ordinal);
			if (jProperty != null)
			{
				JToken value = jProperty.Value;
				if (value.Type != JTokenType.String && value.Type != JTokenType.Null)
				{
					throw Class131.smethod_634((Interface1?)value, value.Path, "JSON reference {0} property must have a string or null value.".smethod_1(CultureInfo.InvariantCulture, "$ref"), (Exception?)null);
				}
				string text = JToken.smethod_19(jProperty);
				if (text != null)
				{
					JToken jToken = jProperty.Next ?? jProperty.Previous;
					if (jToken != null)
					{
						throw Class131.smethod_634((Interface1?)jToken, jToken.Path, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".smethod_1(CultureInfo.InvariantCulture, "$ref"), (Exception?)null);
					}
					object_1 = Class131.smethod_641(class33_0).imethod_0(this, text);
					if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Info)
					{
						interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class31_0, class31_0.Path, "Resolved object reference '{0}' to {1}.".smethod_2(CultureInfo.InvariantCulture, text, object_1!.GetType())), null);
					}
					Class131.smethod_482((Class28)class31_0);
					return true;
				}
			}
			JToken jToken2 = jObject["$type"];
			if (jToken2 != null)
			{
				string string_ = JToken.smethod_19(jToken2);
				Class28 class28_ = new Class31(jToken2);
				Class131.smethod_167(class28_);
				method_9(class28_, ref type_0, ref class137_0, jsonProperty_0, class138_0, jsonProperty_1, string_);
				if (jObject["$value"] != null)
				{
					while (true)
					{
						Class131.smethod_167((Class28)class31_0);
						if (class31_0.TokenType != JsonToken.PropertyName || !((string)class31_0.Value == "$value"))
						{
							Class131.smethod_167((Class28)class31_0);
							Class131.smethod_482((Class28)class31_0);
							continue;
						}
						break;
					}
					return false;
				}
			}
			JToken jToken3 = jObject["$id"];
			if (jToken3 != null)
			{
				string_0 = JToken.smethod_19(jToken3);
			}
			JToken jToken4 = jObject["$values"];
			if (jToken4 != null)
			{
				Class28 class28_2 = new Class31(jToken4);
				Class131.smethod_167(class28_2);
				object_1 = method_10(class28_2, type_0, class137_0, jsonProperty_0, object_0, string_0);
				Class131.smethod_482((Class28)class31_0);
				return true;
			}
		}
		Class131.smethod_167((Class28)class31_0);
		return false;
	}

	private bool method_8(Class28 class28_0, ref Type? type_0, ref Class137? class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1, object? object_0, out object? object_1, out string? string_0)
	{
		string_0 = null;
		object_1 = null;
		if (class28_0.TokenType == JsonToken.PropertyName)
		{
			string text = class28_0.Value!.ToString();
			if (text.Length > 0 && text[0] == '$')
			{
				bool flag;
				do
				{
					text = class28_0.Value!.ToString();
					if (!string.Equals(text, "$ref", StringComparison.Ordinal))
					{
						if (string.Equals(text, "$type", StringComparison.Ordinal))
						{
							Class131.smethod_167(class28_0);
							string string_ = class28_0.Value!.ToString();
							method_9(class28_0, ref type_0, ref class137_0, jsonProperty_0, class138_0, jsonProperty_1, string_);
							Class131.smethod_167(class28_0);
							flag = true;
							continue;
						}
						if (string.Equals(text, "$id", StringComparison.Ordinal))
						{
							Class131.smethod_167(class28_0);
							string_0 = class28_0.Value?.ToString();
							Class131.smethod_167(class28_0);
							flag = true;
							continue;
						}
						if (!string.Equals(text, "$values", StringComparison.Ordinal))
						{
							flag = false;
							continue;
						}
						Class131.smethod_167(class28_0);
						object obj = method_10(class28_0, type_0, class137_0, jsonProperty_0, object_0, string_0);
						Class131.smethod_167(class28_0);
						object_1 = obj;
						return true;
					}
					Class131.smethod_167(class28_0);
					if (class28_0.TokenType == JsonToken.String || class28_0.TokenType == JsonToken.Null)
					{
						string text2 = class28_0.Value?.ToString();
						Class131.smethod_167(class28_0);
						if (text2 == null)
						{
							flag = true;
							continue;
						}
						if (class28_0.TokenType == JsonToken.PropertyName)
						{
							throw Class131.smethod_38(class28_0, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".smethod_1(CultureInfo.InvariantCulture, "$ref"));
						}
						object_1 = Class131.smethod_641(class33_0).imethod_0(this, text2);
						if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Info)
						{
							interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class28_0 as Interface1, class28_0.Path, "Resolved object reference '{0}' to {1}.".smethod_2(CultureInfo.InvariantCulture, text2, object_1!.GetType())), null);
						}
						return true;
					}
					throw Class131.smethod_38(class28_0, "JSON reference {0} property must have a string or null value.".smethod_1(CultureInfo.InvariantCulture, "$ref"));
				}
				while (flag && class28_0.TokenType == JsonToken.PropertyName);
			}
		}
		return false;
	}

	private void method_9(Class28 class28_0, ref Type? type_0, ref Class137? class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1, string string_0)
	{
		if ((jsonProperty_0?.TypeNameHandling ?? class138_0?.ItemTypeNameHandling ?? jsonProperty_1?.ItemTypeNameHandling ?? class33_0.enum19_0) != 0)
		{
			Struct5<string, string> @struct = Class131.smethod_697(string_0);
			Type type;
			try
			{
				type = class33_0.interface6_0.BindToType(@struct.gparam_0, @struct.gparam_1);
			}
			catch (Exception exception_)
			{
				throw Class131.smethod_200("Error resolving type specified in JSON '{0}'.".smethod_1(CultureInfo.InvariantCulture, string_0), exception_, class28_0);
			}
			if (type == null)
			{
				throw Class131.smethod_38(class28_0, "Type specified in JSON '{0}' was not resolved.".smethod_1(CultureInfo.InvariantCulture, string_0));
			}
			if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Verbose)
			{
				interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(class28_0 as Interface1, class28_0.Path, "Resolved type '{0}' to {1}.".smethod_2(CultureInfo.InvariantCulture, string_0, type)), null);
			}
			if (type_0 != null && type_0 != typeof(IDynamicMetaObjectProvider) && !type_0!.IsAssignableFrom(type))
			{
				throw Class131.smethod_38(class28_0, "Type specified in JSON '{0}' is not compatible with '{1}'.".smethod_2(CultureInfo.InvariantCulture, type.AssemblyQualifiedName, type_0!.AssemblyQualifiedName));
			}
			type_0 = type;
			class137_0 = Class131.smethod_601(this, type);
		}
	}

	private object? method_10(Class28 class28_0, Type? type_0, Class137? class137_0, JsonProperty? jsonProperty_0, object? object_0, string? string_0)
	{
		if (method_11(class137_0))
		{
			return method_3(class28_0, class137_0);
		}
		Class139 @class = Class131.smethod_2(this, class28_0, type_0, class137_0);
		if (object_0 == null)
		{
			bool bool_;
			IList list = Class131.smethod_194(class28_0, this, out bool_, @class);
			if (bool_)
			{
				if (string_0 != null)
				{
					throw Class131.smethod_38(class28_0, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
				}
				if (class137_0!.OnSerializingCallbacks.Count > 0)
				{
					throw Class131.smethod_38(class28_0, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
				}
				if (class137_0!.OnErrorCallbacks.Count > 0)
				{
					throw Class131.smethod_38(class28_0, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
				}
				if (!@class.HasParameterizedCreatorInternal && !@class.IsArray)
				{
					throw Class131.smethod_38(class28_0, "Cannot deserialize readonly or fixed size list: {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.UnderlyingType));
				}
			}
			if (!@class.IsMultidimensionalArray)
			{
				Class131.smethod_178(this, list, class28_0, @class, jsonProperty_0, string_0);
			}
			else
			{
				Class131.smethod_437(this, list, class28_0, @class, jsonProperty_0, string_0);
			}
			if (bool_)
			{
				if (@class.IsMultidimensionalArray)
				{
					Type collectionItemType = @class.CollectionItemType;
					int arrayRank = class137_0!.type_1.GetArrayRank();
					list = Class131.smethod_202(collectionItemType, list, arrayRank);
				}
				else
				{
					if (!@class.IsArray)
					{
						return (@class.delegate7_2 ?? @class.ParameterizedCreator)!(list);
					}
					Array array = Array.CreateInstance(@class.CollectionItemType, list.Count);
					list.CopyTo(array, 0);
					list = array;
				}
			}
			else if (list is Interface2 @interface)
			{
				return @interface.UnderlyingCollection;
			}
			return list;
		}
		if (!@class.CanDeserialize)
		{
			throw Class131.smethod_38(class28_0, "Cannot populate list type {0}.".smethod_1(CultureInfo.InvariantCulture, class137_0!.type_1));
		}
		IList ilist_;
		if (!@class.ShouldCreateWrapper && object_0 is IList list2)
		{
			ilist_ = list2;
		}
		else
		{
			IList list3 = @class.method_5(object_0);
			ilist_ = list3;
		}
		return Class131.smethod_178(this, ilist_, class28_0, @class, jsonProperty_0, string_0);
	}

	private bool method_11(Class137? class137_0)
	{
		if (class137_0 != null && !(class137_0!.UnderlyingType == typeof(object)) && class137_0!.enum26_0 != Enum26.const_8)
		{
			return class137_0!.UnderlyingType == typeof(IDynamicMetaObjectProvider);
		}
		return true;
	}

	internal object? method_12(Class28 class28_0, object? object_0, CultureInfo cultureInfo_0, Class137? class137_0, Type? type_0)
	{
		if (type_0 == null)
		{
			return object_0;
		}
		if (ReflectionUtils.smethod_2(object_0) != type_0)
		{
			if (object_0 == null && class137_0!.bool_0)
			{
				return null;
			}
			try
			{
				if (class137_0!.bool_1)
				{
					Class145 @class = (Class145)class137_0;
					DateTime dateTime_;
					if (class137_0!.bool_2)
					{
						if (object_0 is string string_)
						{
							return Class131.smethod_352(class137_0!.type_0, (Class114?)null, string_, bool_0: false);
						}
						if (Class131.smethod_474((object)@class.TypeCode))
						{
							return Enum.ToObject(class137_0!.type_0, object_0);
						}
					}
					else if (class137_0!.type_0 == typeof(DateTime) && object_0 is string string_2 && Class131.smethod_278(string_2, class28_0.enum3_0, class28_0.string_0, class28_0.Culture, out dateTime_))
					{
						return Class131.smethod_17(dateTime_, class28_0.enum3_0);
					}
					if (!(object_0 is BigInteger bigInteger_))
					{
						return Convert.ChangeType(object_0, class137_0!.type_0, cultureInfo_0);
					}
					return Class131.smethod_613(class137_0!.type_0, bigInteger_);
				}
				return Class131.smethod_661(object_0, cultureInfo_0, class137_0!.type_0);
			}
			catch (Exception exception_)
			{
				throw Class131.smethod_200("Error converting value {0} to type '{1}'.".smethod_2(CultureInfo.InvariantCulture, Class131.smethod_575(object_0), type_0), exception_, class28_0);
			}
		}
		return object_0;
	}

	internal bool method_13(JsonProperty jsonProperty_0, ref Class8? class8_0, Class138? class138_0, JsonProperty? jsonProperty_1, Class28 class28_0, object object_0, out bool bool_0, out object? object_1, out Class137? class137_0, out bool bool_1, out bool bool_2)
	{
		object_1 = null;
		bool_0 = false;
		class137_0 = null;
		bool_1 = false;
		bool_2 = false;
		if (jsonProperty_0.Ignored)
		{
			return true;
		}
		JsonToken tokenType = class28_0.TokenType;
		if (jsonProperty_0.PropertyContract == null)
		{
			jsonProperty_0.PropertyContract = method_1(jsonProperty_0.type_0);
		}
		if (jsonProperty_0.ObjectCreationHandling.GetValueOrDefault(class33_0.enum13_0) != Enum13.const_2 && (tokenType == JsonToken.StartArray || tokenType == JsonToken.StartObject || class8_0 != null) && jsonProperty_0.Readable)
		{
			object_1 = jsonProperty_0.ValueProvider!.imethod_1(object_0);
			bool_1 = true;
			if (object_1 != null)
			{
				class137_0 = Class131.smethod_601(this, object_1!.GetType());
				bool_0 = !class137_0!.bool_3 && !class137_0!.UnderlyingType.smethod_13();
			}
		}
		if (!jsonProperty_0.Writable && !bool_0)
		{
			if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Info)
			{
				interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class28_0 as Interface1, class28_0.Path, "Unable to deserialize value to non-writable property '{0}' on {1}.".smethod_2(CultureInfo.InvariantCulture, jsonProperty_0.string_0, jsonProperty_0.DeclaringType)), null);
			}
			return true;
		}
		if (tokenType == JsonToken.Null && Class131.smethod_234(jsonProperty_0, (Class151)this, class138_0 as Class143) == Enum12.const_1)
		{
			bool_2 = true;
			return true;
		}
		if (Class131.smethod_637(this, jsonProperty_0.DefaultValueHandling.GetValueOrDefault(class33_0.enum4_0), Enum4.flag_1) && !Class131.smethod_637(this, jsonProperty_0.DefaultValueHandling.GetValueOrDefault(class33_0.enum4_0), Enum4.flag_2) && Class131.smethod_524(tokenType) && Class97.smethod_1(class28_0.Value, Class131.smethod_309(jsonProperty_0)))
		{
			bool_2 = true;
			return true;
		}
		if (object_1 == null)
		{
			class137_0 = jsonProperty_0.PropertyContract;
		}
		else
		{
			class137_0 = Class131.smethod_601(this, object_1!.GetType());
			if (class137_0 != jsonProperty_0.PropertyContract)
			{
				class8_0 = method_5(class137_0, jsonProperty_0.Converter, class138_0, jsonProperty_1);
			}
		}
		return false;
	}

	internal bool method_14(JsonProperty jsonProperty_0, Class143? class143_0, object? object_0)
	{
		if (object_0 == null && Class131.smethod_234(jsonProperty_0, (Class151)this, class143_0) == Enum12.const_1)
		{
			return false;
		}
		if (Class131.smethod_637(this, jsonProperty_0.DefaultValueHandling.GetValueOrDefault(class33_0.enum4_0), Enum4.flag_1) && !Class131.smethod_637(this, jsonProperty_0.DefaultValueHandling.GetValueOrDefault(class33_0.enum4_0), Enum4.flag_2) && Class97.smethod_1(object_0, Class131.smethod_309(jsonProperty_0)))
		{
			return false;
		}
		if (!jsonProperty_0.Writable)
		{
			return false;
		}
		return true;
	}

	internal object method_15(Class28 class28_0, Class143 class143_0, JsonProperty? jsonProperty_0, Delegate7<object> delegate7_0, string? string_0)
	{
		Class112.smethod_0(delegate7_0, "creator");
		bool flag = class143_0.HasRequiredOrDefaultValueProperties || Class131.smethod_637(this, class33_0.enum4_0, Enum4.flag_2);
		Type underlyingType = class143_0.UnderlyingType;
		if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Info)
		{
			string object_ = string.Join(", ", class143_0.CreatorParameters.Select((JsonProperty jsonProperty_0) => jsonProperty_0.string_0));
			interface7_0!.imethod_0(TraceLevel.Info, Struct0.smethod_2(class28_0 as Interface1, class28_0.Path, "Deserializing {0} using creator with parameters: {1}.".smethod_2(CultureInfo.InvariantCulture, class143_0.UnderlyingType, object_)), null);
		}
		List<Class154> list = Class131.smethod_534(this, class143_0, jsonProperty_0, class28_0, underlyingType);
		if (flag)
		{
			foreach (JsonProperty jsonProperty_ in class143_0.Properties)
			{
				if (!jsonProperty_.Ignored && list.All((Class154 class154_0) => class154_0.jsonProperty_0 != jsonProperty_))
				{
					list.Add(new Class154(jsonProperty_.string_0)
					{
						jsonProperty_0 = jsonProperty_,
						nullable_0 = PropertyPresence.None
					});
				}
			}
		}
		object[] array = new object[class143_0.CreatorParameters.Count];
		foreach (Class154 item in list)
		{
			if (flag && item.jsonProperty_0 != null && !item.nullable_0.HasValue)
			{
				object object_2 = item.object_0;
				PropertyPresence value = ((object_2 == null) ? PropertyPresence.Null : ((!(object_2 is string string_)) ? PropertyPresence.Value : (smethod_0(item.jsonProperty_0!.type_0, item.jsonProperty_0!.PropertyContract, string_) ? PropertyPresence.Null : PropertyPresence.Value)));
				item.nullable_0 = value;
			}
			JsonProperty jsonProperty = item.jsonProperty_1;
			if (jsonProperty == null && item.jsonProperty_0 != null)
			{
				jsonProperty = class143_0.CreatorParameters.smethod_6((JsonProperty jsonProperty_0) => jsonProperty_0.string_0, item.jsonProperty_0!.UnderlyingName);
			}
			if (jsonProperty == null || jsonProperty.Ignored)
			{
				continue;
			}
			if (flag)
			{
				PropertyPresence? nullable_ = item.nullable_0;
				if (((nullable_.GetValueOrDefault() == PropertyPresence.None) & nullable_.HasValue) || item.nullable_0 == PropertyPresence.Null)
				{
					if (jsonProperty.PropertyContract == null)
					{
						jsonProperty.PropertyContract = method_1(jsonProperty.type_0);
					}
					if (Class131.smethod_637(this, jsonProperty.DefaultValueHandling.GetValueOrDefault(class33_0.enum4_0), Enum4.flag_2))
					{
						item.object_0 = method_12(class28_0, Class131.smethod_309(jsonProperty), CultureInfo.InvariantCulture, jsonProperty.PropertyContract, jsonProperty.type_0);
					}
				}
			}
			int num = class143_0.CreatorParameters.IndexOf(jsonProperty);
			array[num] = item.object_0;
			item.bool_0 = true;
		}
		object obj = delegate7_0(array);
		if (string_0 != null)
		{
			Class131.smethod_395(obj, class28_0, string_0, this);
		}
		Class131.smethod_206(this, class28_0, (Class137)class143_0, obj);
		foreach (Class154 item2 in list)
		{
			if (item2.bool_0 || item2.jsonProperty_0 == null || item2.jsonProperty_0!.Ignored)
			{
				continue;
			}
			PropertyPresence? nullable_ = item2.nullable_0;
			if ((nullable_.GetValueOrDefault() == PropertyPresence.None) & nullable_.HasValue)
			{
				continue;
			}
			JsonProperty jsonProperty_2 = item2.jsonProperty_0;
			object object_3 = item2.object_0;
			if (method_14(jsonProperty_2, class143_0, object_3))
			{
				jsonProperty_2.ValueProvider!.imethod_0(obj, object_3);
				item2.bool_0 = true;
			}
			else
			{
				if (jsonProperty_2.Writable || object_3 == null)
				{
					continue;
				}
				Class137 @class = class33_0.interface4_0.imethod_0(jsonProperty_2.type_0);
				if (@class.enum26_0 == Enum26.const_2)
				{
					Class139 class2 = (Class139)@class;
					if (class2.CanDeserialize && !class2.bool_3)
					{
						object obj2 = jsonProperty_2.ValueProvider!.imethod_1(obj);
						if (obj2 != null)
						{
							class2 = (Class139)Class131.smethod_601(this, obj2.GetType());
							object obj3;
							if (!class2.ShouldCreateWrapper)
							{
								obj3 = (IList)obj2;
							}
							else
							{
								IList list2 = class2.method_5(obj2);
								obj3 = list2;
							}
							IList list3 = (IList)obj3;
							if (!list3.IsFixedSize)
							{
								object obj4;
								if (!class2.ShouldCreateWrapper)
								{
									obj4 = (IList)object_3;
								}
								else
								{
									IList list2 = class2.method_5(object_3);
									obj4 = list2;
								}
								foreach (object item3 in (IEnumerable)obj4)
								{
									list3.Add(item3);
								}
							}
						}
					}
				}
				else if (@class.enum26_0 == Enum26.const_5)
				{
					Class140 class3 = (Class140)@class;
					if (!class3.bool_3)
					{
						object obj5 = jsonProperty_2.ValueProvider!.imethod_1(obj);
						if (obj5 != null)
						{
							object obj6;
							if (!class3.ShouldCreateWrapper)
							{
								obj6 = (IDictionary)obj5;
							}
							else
							{
								IDictionary dictionary = class3.method_5(obj5);
								obj6 = dictionary;
							}
							IDictionary dictionary2 = (IDictionary)obj6;
							object obj7;
							if (!class3.ShouldCreateWrapper)
							{
								obj7 = (IDictionary)object_3;
							}
							else
							{
								IDictionary dictionary = class3.method_5(object_3);
								obj7 = dictionary;
							}
							foreach (DictionaryEntry item4 in (IDictionary)obj7)
							{
								dictionary2[item4.Key] = item4.Value;
							}
						}
					}
				}
				item2.bool_0 = true;
			}
		}
		if (class143_0.ExtensionDataSetter != null)
		{
			foreach (Class154 item5 in list)
			{
				if (!item5.bool_0)
				{
					PropertyPresence? nullable_ = item5.nullable_0;
					if (!((nullable_.GetValueOrDefault() == PropertyPresence.None) & nullable_.HasValue))
					{
						class143_0.ExtensionDataSetter!(obj, item5.string_0, item5.object_0);
					}
				}
			}
		}
		if (flag)
		{
			foreach (Class154 item6 in list)
			{
				if (item6.jsonProperty_0 != null)
				{
					int depth = class28_0.Depth;
					JsonProperty jsonProperty_3 = item6.jsonProperty_0;
					PropertyPresence valueOrDefault = item6.nullable_0.GetValueOrDefault();
					bool bool_ = !item6.bool_0;
					Class131.smethod_360(obj, class143_0, depth, class28_0, bool_, jsonProperty_3, valueOrDefault, this);
				}
			}
		}
		Class131.smethod_518(this, class28_0, (Class137)class143_0, obj);
		return obj;
	}

	internal object method_16(object object_0, Class28 class28_0, Class143 class143_0, JsonProperty? jsonProperty_0, string? string_0)
	{
		Class131.smethod_206(this, class28_0, (Class137)class143_0, object_0);
		Dictionary<JsonProperty, PropertyPresence> dictionary = ((class143_0.HasRequiredOrDefaultValueProperties || Class131.smethod_637(this, class33_0.enum4_0, Enum4.flag_2)) ? class143_0.Properties.ToDictionary((JsonProperty jsonProperty_0) => jsonProperty_0, (JsonProperty jsonProperty_0) => PropertyPresence.None) : null);
		if (string_0 != null)
		{
			Class131.smethod_395(object_0, class28_0, string_0, this);
		}
		int depth = class28_0.Depth;
		bool flag = false;
		do
		{
			JsonToken tokenType = class28_0.TokenType;
			if (tokenType == JsonToken.PropertyName)
			{
				string text = class28_0.Value!.ToString();
				if (Class131.smethod_548(text, this, class28_0))
				{
					continue;
				}
				try
				{
					JsonProperty jsonProperty = Class131.smethod_251(class143_0.Properties, text);
					if (jsonProperty == null)
					{
						if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Verbose)
						{
							interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(class28_0 as Interface1, class28_0.Path, "Could not find member '{0}' on {1}".smethod_2(CultureInfo.InvariantCulture, text, class143_0.UnderlyingType)), null);
						}
						if ((class143_0.MissingMemberHandling ?? class33_0.enum11_0) == Enum11.const_1)
						{
							throw Class131.smethod_38(class28_0, "Could not find member '{0}' on object of type '{1}'".smethod_2(CultureInfo.InvariantCulture, text, class143_0.UnderlyingType.Name));
						}
						if (class28_0.vmethod_0())
						{
							Class131.smethod_694(this, class143_0, jsonProperty_0, class28_0, text, object_0);
						}
					}
					else if (!jsonProperty.Ignored && Class131.smethod_444(jsonProperty, object_0, class28_0, this))
					{
						if (jsonProperty.PropertyContract == null)
						{
							jsonProperty.PropertyContract = method_1(jsonProperty.type_0);
						}
						Class8 @class = method_5(jsonProperty.PropertyContract, jsonProperty.Converter, class143_0, jsonProperty_0);
						if (!Class131.smethod_607(class28_0, jsonProperty.PropertyContract, @class != null))
						{
							throw Class131.smethod_38(class28_0, "Unexpected end when setting {0}'s value.".smethod_1(CultureInfo.InvariantCulture, text));
						}
						Class131.smethod_338(this, class28_0, jsonProperty, dictionary);
						if (!Class131.smethod_6(jsonProperty_0, object_0, jsonProperty, class28_0, (Class138)class143_0, this, @class))
						{
							Class131.smethod_694(this, class143_0, jsonProperty_0, class28_0, text, object_0);
						}
					}
					else if (class28_0.vmethod_0())
					{
						Class131.smethod_338(this, class28_0, jsonProperty, dictionary);
						Class131.smethod_694(this, class143_0, jsonProperty_0, class28_0, text, object_0);
					}
				}
				catch (Exception exception_)
				{
					if (!method_0(object_0, class143_0, text, class28_0 as Interface1, class28_0.Path, exception_))
					{
						throw;
					}
					Class131.smethod_295(depth, bool_0: true, this, class28_0);
				}
			}
			else if (tokenType != JsonToken.Comment)
			{
				if (tokenType != JsonToken.EndObject)
				{
					throw Class131.smethod_38(class28_0, "Unexpected token when deserializing object: " + class28_0.TokenType);
				}
				flag = true;
			}
		}
		while (!flag && class28_0.vmethod_0());
		if (!flag)
		{
			Class131.smethod_584("Unexpected end when deserializing object.", (Class137)class143_0, class28_0, object_0, this);
		}
		if (dictionary != null)
		{
			foreach (KeyValuePair<JsonProperty, PropertyPresence> item in dictionary)
			{
				JsonProperty key = item.Key;
				PropertyPresence value = item.Value;
				Class131.smethod_360(object_0, class143_0, depth, class28_0, bool_0: true, key, value, this);
			}
		}
		Class131.smethod_518(this, class28_0, (Class137)class143_0, object_0);
		return object_0;
	}
}
