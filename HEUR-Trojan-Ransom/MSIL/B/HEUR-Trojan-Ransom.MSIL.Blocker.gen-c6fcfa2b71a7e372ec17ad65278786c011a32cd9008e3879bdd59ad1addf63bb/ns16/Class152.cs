using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using ns0;
using ns1;
using ns12;
using ns13;
using ns14;
using ns15;
using ns17;
using ns18;
using ns19;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns16;

internal class Class152 : Class151
{
	private Type? type_0;

	private int int_0;

	internal readonly List<object> list_0 = new List<object>();

	public Class152(Class33 class33_1)
		: base(class33_1)
	{
	}

	public void method_1(Class37 class37_0, object? object_0, Type? type_1)
	{
		if (class37_0 == null)
		{
			throw new ArgumentNullException("jsonWriter");
		}
		type_0 = type_1;
		int_0 = list_0.Count + 1;
		Class137 class137_ = method_2(object_0);
		try
		{
			if (method_5(object_0, null, class137_, null, null))
			{
				Class131.smethod_711(object_0, this, class37_0);
			}
			else
			{
				method_3(class37_0, object_0, class137_, null, null, null);
			}
		}
		catch (Exception exception_)
		{
			if (!method_0(null, class137_, null, null, class37_0.Path, exception_))
			{
				Class131.smethod_52((Class151)this);
				throw;
			}
			Class131.smethod_686(0, this, class37_0);
		}
		finally
		{
			type_0 = null;
		}
	}

	internal Class137? method_2(object? object_0)
	{
		if (object_0 == null)
		{
			return null;
		}
		return Class131.smethod_43(this, object_0);
	}

	internal void method_3(Class37 class37_0, object? object_0, Class137? class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		object obj;
		if (jsonProperty_0 == null)
		{
			obj = null;
		}
		else
		{
			obj = jsonProperty_0!.Converter;
			if (obj != null)
			{
				goto IL_0065;
			}
		}
		if (jsonProperty_1 == null)
		{
			obj = null;
		}
		else
		{
			obj = jsonProperty_1!.ItemConverter;
			if (obj != null)
			{
				goto IL_0065;
			}
		}
		if (class138_0 == null)
		{
			obj = null;
		}
		else
		{
			obj = class138_0!.ItemConverter;
			if (obj != null)
			{
				goto IL_0065;
			}
		}
		obj = class137_0!.Converter ?? Class131.smethod_1(class33_0, class137_0!.UnderlyingType) ?? class137_0!.InternalConverter;
		goto IL_0065;
		IL_0065:
		Class8 @class = (Class8)obj;
		if (@class != null && @class.CanWrite)
		{
			Class131.smethod_401(object_0, jsonProperty_1, this, class138_0, @class, class37_0, class137_0);
			return;
		}
		switch (class137_0!.enum26_0)
		{
		case Enum26.const_1:
			Class131.smethod_302(this, class37_0, object_0, (Class143)class137_0, jsonProperty_0, class138_0, jsonProperty_1);
			break;
		case Enum26.const_2:
		{
			Class139 class3 = (Class139)class137_0;
			if (!class3.IsMultidimensionalArray)
			{
				Class131.smethod_224((IEnumerable)object_0, jsonProperty_1, class3, class138_0, jsonProperty_0, class37_0, this);
			}
			else
			{
				Class131.smethod_430(this, class37_0, (Array)object_0, class3, jsonProperty_0, class138_0, jsonProperty_1);
			}
			break;
		}
		case Enum26.const_3:
			Class131.smethod_644(this, class37_0, object_0, (Class145)class137_0, jsonProperty_0, class138_0, jsonProperty_1);
			break;
		case Enum26.const_4:
			Class131.smethod_164(this, class37_0, object_0, (Class146)class137_0);
			break;
		case Enum26.const_5:
		{
			Class140 class2 = (Class140)class137_0;
			IDictionary idictionary_;
			if (!(object_0 is IDictionary dictionary))
			{
				IDictionary dictionary2 = class2.method_5(object_0);
				idictionary_ = dictionary2;
			}
			else
			{
				idictionary_ = dictionary;
			}
			Class131.smethod_608(this, class37_0, idictionary_, class2, jsonProperty_0, class138_0, jsonProperty_1);
			break;
		}
		case Enum26.const_6:
			Class131.smethod_520(this, class37_0, (IDynamicMetaObjectProvider)object_0, (Class141)class137_0, jsonProperty_0, class138_0, jsonProperty_1);
			break;
		case Enum26.const_7:
			method_8(class37_0, (ISerializable)object_0, (Class142)class137_0, jsonProperty_0, class138_0, jsonProperty_1);
			break;
		case Enum26.const_8:
			((JToken)object_0).vmethod_5(class37_0, class33_0.Converters.ToArray());
			break;
		}
	}

	internal bool? method_4(Class137 class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1)
	{
		bool? result = null;
		if (jsonProperty_0 != null)
		{
			result = jsonProperty_0!.IsReference;
		}
		if (!result.HasValue && jsonProperty_1 != null)
		{
			result = jsonProperty_1!.ItemIsReference;
		}
		if (!result.HasValue && class138_0 != null)
		{
			result = class138_0!.ItemIsReference;
		}
		if (!result.HasValue)
		{
			result = class137_0.IsReference;
		}
		return result;
	}

	internal bool method_5(object? object_0, JsonProperty? jsonProperty_0, Class137? class137_0, Class138? class138_0, JsonProperty? jsonProperty_1)
	{
		if (object_0 == null)
		{
			return false;
		}
		if (class137_0!.enum26_0 != Enum26.const_3 && class137_0!.enum26_0 != Enum26.const_4)
		{
			bool? flag = method_4(class137_0, jsonProperty_0, class138_0, jsonProperty_1);
			if (!flag.HasValue)
			{
				flag = ((class137_0!.enum26_0 != Enum26.const_2) ? new bool?(Class131.smethod_680(class33_0.enum14_0, this, Enum14.flag_1)) : new bool?(Class131.smethod_680(class33_0.enum14_0, this, Enum14.flag_2)));
			}
			if (!flag.GetValueOrDefault())
			{
				return false;
			}
			return Class131.smethod_641(class33_0).imethod_2(this, object_0);
		}
		return false;
	}

	internal bool method_6(object? object_0, Class143? class143_0, JsonProperty jsonProperty_0)
	{
		if (object_0 == null && Class131.smethod_234(jsonProperty_0, (Class151)this, class143_0) == Enum12.const_1)
		{
			return false;
		}
		if (Class131.smethod_659(this, jsonProperty_0.DefaultValueHandling.GetValueOrDefault(class33_0.enum4_0), Enum4.flag_1) && Class97.smethod_1(object_0, Class131.smethod_309(jsonProperty_0)))
		{
			return false;
		}
		return true;
	}

	internal bool method_7(Class37 class37_0, object? object_0, JsonProperty? jsonProperty_0, Class137? class137_0, Class138? class138_0, JsonProperty? jsonProperty_1)
	{
		if (object_0 == null)
		{
			return true;
		}
		if (class137_0!.enum26_0 != Enum26.const_3 && class137_0!.enum26_0 != Enum26.const_4)
		{
			Enum15? @enum = null;
			if (jsonProperty_0 != null)
			{
				@enum = jsonProperty_0!.ReferenceLoopHandling;
			}
			if (!@enum.HasValue && jsonProperty_1 != null)
			{
				@enum = jsonProperty_1!.ItemReferenceLoopHandling;
			}
			if (!@enum.HasValue && class138_0 != null)
			{
				@enum = class138_0!.ItemReferenceLoopHandling;
			}
			if ((class33_0.iequalityComparer_0 != null) ? list_0.smethod_7(object_0, class33_0.iequalityComparer_0) : list_0.Contains(object_0))
			{
				string text = "Self referencing loop detected";
				if (jsonProperty_0 != null)
				{
					text += " for property '{0}'".smethod_1(CultureInfo.InvariantCulture, jsonProperty_0!.string_0);
				}
				text += " with type '{0}'.".smethod_1(CultureInfo.InvariantCulture, object_0!.GetType());
				switch (@enum.GetValueOrDefault(class33_0.enum15_0))
				{
				case Enum15.const_0:
					throw Class131.smethod_634((Interface1?)null, class37_0.ContainerPath, text, (Exception?)null);
				case Enum15.const_1:
					if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Verbose)
					{
						interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class37_0.Path, text + ". Skipping serializing self referenced value."), null);
					}
					return false;
				case Enum15.const_2:
					if (interface7_0 != null && interface7_0!.LevelFilter >= TraceLevel.Verbose)
					{
						interface7_0!.imethod_0(TraceLevel.Verbose, Struct0.smethod_2(null, class37_0.Path, text + ". Serializing self referenced value."), null);
					}
					return true;
				}
			}
			return true;
		}
		return true;
	}

	[SecuritySafeCritical]
	private void method_8(Class37 class37_0, ISerializable iserializable_0, Class142 class142_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1)
	{
		if (!JsonTypeReflector.FullyTrusted)
		{
			string string_ = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + Environment.NewLine;
			string_ = string_.smethod_1(CultureInfo.InvariantCulture, iserializable_0.GetType());
			throw Class131.smethod_634((Interface1?)null, class37_0.ContainerPath, string_, (Exception?)null);
		}
		Class131.smethod_617(this, class37_0, (Class137)class142_0, (object)iserializable_0);
		list_0.Add(iserializable_0);
		Class131.smethod_187(class138_0, jsonProperty_0, class37_0, this, (Class137?)class142_0, (object?)iserializable_0, jsonProperty_1);
		SerializationInfo serializationInfo = new SerializationInfo(class142_0.UnderlyingType, new FormatterConverter());
		iserializable_0.GetObjectData(serializationInfo, class33_0.streamingContext_0);
		SerializationInfoEnumerator enumerator = serializationInfo.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SerializationEntry current = enumerator.Current;
			Class137 class137_ = method_2(current.Value);
			if (method_5(current.Value, null, class137_, class142_0, jsonProperty_0))
			{
				class37_0.vmethod_9(current.Name);
				Class131.smethod_711(current.Value, this, class37_0);
			}
			else if (method_7(class37_0, current.Value, null, class137_, class142_0, jsonProperty_0))
			{
				class37_0.vmethod_9(current.Name);
				method_3(class37_0, current.Value, class137_, null, class142_0, jsonProperty_0);
			}
		}
		class37_0.vmethod_4();
		list_0.RemoveAt(list_0.Count - 1);
		Class131.smethod_3(class37_0, (Class137)class142_0, this, (object)iserializable_0);
	}

	internal bool method_9(object? object_0)
	{
		if (class33_0.enum12_0 == Enum12.const_1 && object_0 == null)
		{
			return false;
		}
		if (Class131.smethod_659(this, class33_0.enum4_0, Enum4.flag_1) && (object_0 == null || Class97.smethod_1(object_0, Class131.smethod_67(object_0!.GetType()))))
		{
			return false;
		}
		return true;
	}

	internal bool method_10(Enum19 enum19_0, Class137 class137_0, JsonProperty? jsonProperty_0, Class138? class138_0, JsonProperty? jsonProperty_1)
	{
		Enum19 enum19_ = jsonProperty_0?.TypeNameHandling ?? jsonProperty_1?.ItemTypeNameHandling ?? class138_0?.ItemTypeNameHandling ?? class33_0.enum19_0;
		if (Class131.smethod_125(this, enum19_, enum19_0))
		{
			return true;
		}
		if (Class131.smethod_125(this, enum19_, Enum19.flag_4))
		{
			if (jsonProperty_0 != null)
			{
				if (class137_0.type_0 != jsonProperty_0!.PropertyContract!.type_1)
				{
					return true;
				}
			}
			else if (class138_0 != null)
			{
				if (class138_0!.class137_0 == null || class137_0.type_0 != class138_0!.class137_0!.type_1)
				{
					return true;
				}
			}
			else if (type_0 != null && list_0.Count == int_0)
			{
				Class137 @class = class33_0.interface4_0.imethod_0(type_0);
				if (class137_0.type_0 != @class.type_1)
				{
					return true;
				}
			}
		}
		return false;
	}

	internal string method_11(Class37 class37_0, object object_0, Class137 class137_0, out bool bool_0)
	{
		if (class137_0.enum26_0 == Enum26.const_3)
		{
			Class145 @class = (Class145)class137_0;
			switch (@class.TypeCode)
			{
			default:
			{
				bool_0 = true;
				if (@class.bool_2 && Class131.smethod_108(@class.type_0, object_0, (Class114?)null, out string string_))
				{
					return string_;
				}
				return Convert.ToString(object_0, CultureInfo.InvariantCulture);
			}
			case Enum21.const_22:
			case Enum21.const_23:
			{
				float num2 = (float)object_0;
				bool_0 = false;
				return num2.ToString("R", CultureInfo.InvariantCulture);
			}
			case Enum21.const_24:
			case Enum21.const_25:
			{
				double num = (double)object_0;
				bool_0 = false;
				return num.ToString("R", CultureInfo.InvariantCulture);
			}
			case Enum21.const_26:
			case Enum21.const_27:
			{
				DateTime dateTime_ = Class131.smethod_17((DateTime)object_0, class37_0.enum3_0);
				bool_0 = false;
				StringWriter stringWriter2 = new StringWriter(CultureInfo.InvariantCulture);
				Class50.smethod_1(stringWriter2, dateTime_, class37_0.enum1_0, class37_0.DateFormatString, class37_0.Culture);
				return stringWriter2.ToString();
			}
			case Enum21.const_28:
			case Enum21.const_29:
			{
				bool_0 = false;
				StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
				Class50.smethod_3(stringWriter, (DateTimeOffset)object_0, class37_0.enum1_0, class37_0.DateFormatString, class37_0.Culture);
				return stringWriter.ToString();
			}
			}
		}
		if (Class131.smethod_90(object_0, object_0.GetType(), out string string_2))
		{
			bool_0 = true;
			return string_2;
		}
		bool_0 = true;
		return object_0.ToString();
	}
}
