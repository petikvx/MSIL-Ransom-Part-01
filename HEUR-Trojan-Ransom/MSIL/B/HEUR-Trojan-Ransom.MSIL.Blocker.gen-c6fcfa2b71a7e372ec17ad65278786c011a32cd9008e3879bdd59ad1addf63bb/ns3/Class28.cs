using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns1;
using ns10;
using ns13;
using ns5;
using ns7;

namespace ns3;

internal abstract class Class28 : IDisposable
{
	protected internal enum State
	{
		Start,
		Complete,
		Property,
		ObjectStart,
		Object,
		ArrayStart,
		Array,
		Closed,
		PostValue,
		ConstructorStart,
		Constructor,
		Error,
		Finished
	}

	internal JsonToken jsonToken_0;

	internal object? object_0;

	internal char char_0;

	internal State state_0;

	internal Struct0 struct0_0;

	private CultureInfo? cultureInfo_0;

	internal Enum3 enum3_0;

	internal int? nullable_0;

	internal bool bool_0;

	internal Enum2 enum2_0;

	internal Enum6 enum6_0;

	internal string? string_0;

	internal List<Struct0>? list_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	protected internal State CurrentState => state_0;

	public bool CloseInput
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool SupportMultipleContent
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public virtual char QuoteChar
	{
		get
		{
			return char_0;
		}
		protected internal set
		{
			char_0 = value;
		}
	}

	public Enum3 DateTimeZoneHandling
	{
		get
		{
			return enum3_0;
		}
		set
		{
			if (value < Enum3.const_0 || value > Enum3.const_3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum3_0 = value;
		}
	}

	public Enum2 DateParseHandling
	{
		get
		{
			return enum2_0;
		}
		set
		{
			if (value < Enum2.const_0 || value > Enum2.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum2_0 = value;
		}
	}

	public Enum6 FloatParseHandling
	{
		get
		{
			return enum6_0;
		}
		set
		{
			if (value < Enum6.const_0 || value > Enum6.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum6_0 = value;
		}
	}

	public string? DateFormatString
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public int? MaxDepth
	{
		get
		{
			return nullable_0;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Value must be positive.", "value");
			}
			nullable_0 = value;
		}
	}

	public virtual JsonToken TokenType => jsonToken_0;

	public virtual object? Value => object_0;

	public virtual Type? ValueType => object_0?.GetType();

	public virtual int Depth
	{
		get
		{
			int num = list_0?.Count ?? 0;
			if (!Class131.smethod_396(TokenType) && struct0_0.jsonContainerType_0 != 0)
			{
				return num + 1;
			}
			return num;
		}
	}

	public virtual string Path
	{
		get
		{
			if (struct0_0.jsonContainerType_0 == JsonContainerType.None)
			{
				return string.Empty;
			}
			Struct0? @struct = ((state_0 != State.ArrayStart && state_0 != State.ConstructorStart && state_0 != State.ObjectStart) ? new Struct0?(struct0_0) : null);
			return Struct0.smethod_1(list_0, @struct);
		}
	}

	public CultureInfo Culture
	{
		get
		{
			return cultureInfo_0 ?? CultureInfo.InvariantCulture;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	protected Class28()
	{
		state_0 = State.Start;
		enum3_0 = Enum3.const_3;
		enum2_0 = Enum2.const_1;
		enum6_0 = Enum6.const_0;
		nullable_0 = 64;
		CloseInput = true;
	}

	public abstract bool vmethod_0();

	public virtual int? vmethod_1()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.Integer:
		case JsonToken.Float:
		{
			object value = Value;
			if (value is int)
			{
				return (int)value;
			}
			int num;
			if (value is BigInteger bigInteger)
			{
				num = (int)bigInteger;
			}
			else
			{
				try
				{
					num = Convert.ToInt32(value, CultureInfo.InvariantCulture);
				}
				catch (Exception exception_)
				{
					throw Class131.smethod_597(exception_, "Could not convert to integer: {0}.".smethod_1(CultureInfo.InvariantCulture, value), this);
				}
			}
			Class131.smethod_344(this, JsonToken.Integer, (object)num, bool_0: false);
			return num;
		}
		case JsonToken.String:
		{
			string text = (string)Value;
			return Class131.smethod_364(this, text);
		}
		default:
			throw Class131.smethod_303(this, "Error reading integer. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	public virtual string? vmethod_2()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.String:
			return (string)Value;
		default:
			if (Class131.smethod_524(jsonToken))
			{
				object value = Value;
				if (value != null)
				{
					string result = ((!(value is IFormattable formattable)) ? ((value is Uri uri) ? uri.OriginalString : value.ToString()) : formattable.ToString(null, Culture));
					Class131.smethod_344(this, JsonToken.String, (object)result, bool_0: false);
					return result;
				}
			}
			throw Class131.smethod_303(this, "Error reading string. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	public virtual byte[]? vmethod_3()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.String:
		{
			string text = (string)Value;
			Guid guid_;
			byte[] result2 = ((text.Length == 0) ? Class44.smethod_10<byte>() : ((!Class131.smethod_461(text, out guid_)) ? Convert.FromBase64String(text) : guid_.ToByteArray()));
			Class131.smethod_344(this, JsonToken.Bytes, (object)result2, bool_0: false);
			return result2;
		}
		case JsonToken.StartObject:
		{
			Class131.smethod_533(this);
			byte[] result3 = vmethod_3();
			Class131.smethod_269(this);
			if (TokenType != JsonToken.EndObject)
			{
				throw Class131.smethod_303(this, "Error reading bytes. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, TokenType));
			}
			Class131.smethod_344(this, JsonToken.Bytes, (object)result3, bool_0: false);
			return result3;
		}
		case JsonToken.StartArray:
			return method_0();
		default:
			throw Class131.smethod_303(this, "Error reading bytes. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.Bytes:
			if (Value is Guid guid)
			{
				byte[] result = guid.ToByteArray();
				Class131.smethod_344(this, JsonToken.Bytes, (object)result, bool_0: false);
				return result;
			}
			return (byte[])Value;
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	internal byte[] method_0()
	{
		List<byte> list = new List<byte>();
		do
		{
			if (!vmethod_0())
			{
				Class131.smethod_668(this, JsonToken.None);
			}
		}
		while (!method_1(list));
		byte[] result = list.ToArray();
		Class131.smethod_344(this, JsonToken.Bytes, (object)result, bool_0: false);
		return result;
	}

	private bool method_1(List<byte> list_1)
	{
		switch (TokenType)
		{
		case JsonToken.Comment:
			return false;
		case JsonToken.None:
			throw Class131.smethod_303(this, "Unexpected end when reading bytes.");
		default:
			throw Class131.smethod_303(this, "Unexpected token when reading bytes: {0}.".smethod_1(CultureInfo.InvariantCulture, TokenType));
		case JsonToken.EndArray:
			return true;
		case JsonToken.Integer:
			list_1.Add(Convert.ToByte(Value, CultureInfo.InvariantCulture));
			return false;
		}
	}

	public virtual double? vmethod_4()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.Integer:
		case JsonToken.Float:
		{
			object value = Value;
			if (value is double)
			{
				return (double)value;
			}
			double num = ((!(value is BigInteger bigInteger)) ? Convert.ToDouble(value, CultureInfo.InvariantCulture) : ((double)bigInteger));
			Class131.smethod_344(this, JsonToken.Float, (object)num, bool_0: false);
			return num;
		}
		case JsonToken.String:
			return Class131.smethod_459(this, (string)Value);
		default:
			throw Class131.smethod_303(this, "Error reading double. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	public virtual bool? vmethod_5()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.Integer:
		case JsonToken.Float:
		{
			bool flag = ((!(Value is BigInteger bigInteger)) ? Convert.ToBoolean(Value, CultureInfo.InvariantCulture) : (bigInteger != 0L));
			Class131.smethod_344(this, JsonToken.Boolean, (object)flag, bool_0: false);
			return flag;
		}
		case JsonToken.String:
			return Class131.smethod_741(this, (string)Value);
		case JsonToken.Boolean:
			return (bool)Value;
		default:
			throw Class131.smethod_303(this, "Error reading boolean. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	public virtual decimal? vmethod_6()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.Integer:
		case JsonToken.Float:
		{
			object value = Value;
			if (value is decimal)
			{
				return (decimal)value;
			}
			decimal num;
			if (value is BigInteger bigInteger)
			{
				num = (decimal)bigInteger;
			}
			else
			{
				try
				{
					num = Convert.ToDecimal(value, CultureInfo.InvariantCulture);
				}
				catch (Exception exception_)
				{
					throw Class131.smethod_597(exception_, "Could not convert to decimal: {0}.".smethod_1(CultureInfo.InvariantCulture, value), this);
				}
			}
			Class131.smethod_344(this, JsonToken.Float, (object)num, bool_0: false);
			return num;
		}
		case JsonToken.String:
			return Class131.smethod_335(this, (string)Value);
		default:
			throw Class131.smethod_303(this, "Error reading decimal. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	public virtual DateTime? vmethod_7()
	{
		switch (Class131.smethod_266(this))
		{
		case JsonToken.String:
			return Class131.smethod_103(this, (string)Value);
		default:
			throw Class131.smethod_303(this, "Error reading date. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, TokenType));
		case JsonToken.Date:
			if (Value is DateTimeOffset dateTimeOffset)
			{
				Class131.smethod_344(this, JsonToken.Date, (object)dateTimeOffset.DateTime, bool_0: false);
			}
			return (DateTime)Value;
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	public virtual DateTimeOffset? vmethod_8()
	{
		JsonToken jsonToken = Class131.smethod_266(this);
		switch (jsonToken)
		{
		case JsonToken.String:
		{
			string text = (string)Value;
			return Class131.smethod_457(this, text);
		}
		default:
			throw Class131.smethod_303(this, "Error reading date. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, jsonToken));
		case JsonToken.Date:
			if (Value is DateTime dateTime)
			{
				Class131.smethod_344(this, JsonToken.Date, (object)new DateTimeOffset(dateTime), bool_0: false);
			}
			return (DateTimeOffset)Value;
		case JsonToken.None:
		case JsonToken.Null:
		case JsonToken.EndArray:
			return null;
		}
	}

	internal JsonReaderException method_2()
	{
		return Class131.smethod_303(this, "Unexpected end when reading JSON.");
	}

	void IDisposable.Dispose()
	{
		vmethod_9(bool_3: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_9(bool bool_3)
	{
		if (state_0 != State.Closed && bool_3)
		{
			vmethod_10();
		}
	}

	public virtual void vmethod_10()
	{
		state_0 = State.Closed;
		jsonToken_0 = JsonToken.None;
		object_0 = null;
	}
}
