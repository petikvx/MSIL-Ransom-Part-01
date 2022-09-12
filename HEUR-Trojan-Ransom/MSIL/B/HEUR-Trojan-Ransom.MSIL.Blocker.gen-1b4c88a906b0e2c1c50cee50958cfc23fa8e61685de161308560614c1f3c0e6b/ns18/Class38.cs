using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns1;
using ns10;
using ns12;
using ns14;
using ns16;
using ns3;
using ns8;
using ns9;

namespace ns18;

internal abstract class Class38 : IDisposable
{
	internal enum State
	{
		Start,
		Property,
		ObjectStart,
		Object,
		ArrayStart,
		Array,
		ConstructorStart,
		Constructor,
		Closed,
		Error
	}

	private static readonly State[][] state_0;

	internal static readonly State[][] state_1;

	internal List<Struct0>? list_0;

	internal Struct0 struct0_0;

	internal State state_2;

	internal Enum7 enum7_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	internal Enum1 enum1_0;

	internal Enum3 enum3_0;

	internal Enum17 enum17_0;

	internal Enum5 enum5_0;

	private string? string_0;

	internal CultureInfo? cultureInfo_0;

	public bool CloseOutput
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool AutoCompleteOnClose
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

	protected internal int Top
	{
		get
		{
			int num = list_0?.Count ?? 0;
			if (struct0_0.jsonContainerType_0 != 0)
			{
				num++;
			}
			return num;
		}
	}

	public Enum20 WriteState
	{
		get
		{
			switch (state_2)
			{
			default:
				throw Class7.smethod_188(this, "Invalid state: " + state_2, (Exception?)null);
			case State.Start:
				return Enum20.const_6;
			case State.Property:
				return Enum20.const_5;
			case State.ObjectStart:
			case State.Object:
				return Enum20.const_2;
			case State.ArrayStart:
			case State.Array:
				return Enum20.const_3;
			case State.ConstructorStart:
			case State.Constructor:
				return Enum20.const_4;
			case State.Closed:
				return Enum20.const_1;
			case State.Error:
				return Enum20.const_0;
			}
		}
	}

	internal string ContainerPath
	{
		get
		{
			if (struct0_0.jsonContainerType_0 != 0 && list_0 != null)
			{
				return Struct0.smethod_1(list_0, null);
			}
			return string.Empty;
		}
	}

	public string Path
	{
		get
		{
			if (struct0_0.jsonContainerType_0 == JsonContainerType.None)
			{
				return string.Empty;
			}
			Struct0? nullable_ = ((state_2 != State.ArrayStart && state_2 != State.ConstructorStart && state_2 != State.ObjectStart) ? new Struct0?(struct0_0) : null);
			return Struct0.smethod_1(list_0, nullable_);
		}
	}

	public Enum7 Formatting
	{
		get
		{
			return enum7_0;
		}
		set
		{
			if (value < Enum7.const_0 || value > Enum7.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum7_0 = value;
		}
	}

	public Enum1 DateFormatHandling
	{
		get
		{
			return enum1_0;
		}
		set
		{
			if (value < Enum1.const_0 || value > Enum1.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum1_0 = value;
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

	public Enum17 StringEscapeHandling
	{
		get
		{
			return enum17_0;
		}
		set
		{
			if (value < Enum17.const_0 || value > Enum17.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum17_0 = value;
			vmethod_0();
		}
	}

	public Enum5 FloatFormatHandling
	{
		get
		{
			return enum5_0;
		}
		set
		{
			if (value < Enum5.const_0 || value > Enum5.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum5_0 = value;
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

	static Class38()
	{
		state_1 = new State[8][]
		{
			new State[10]
			{
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.ObjectStart,
				State.ObjectStart,
				State.Error,
				State.Error,
				State.ObjectStart,
				State.ObjectStart,
				State.ObjectStart,
				State.ObjectStart,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.ArrayStart,
				State.ArrayStart,
				State.Error,
				State.Error,
				State.ArrayStart,
				State.ArrayStart,
				State.ArrayStart,
				State.ArrayStart,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.ConstructorStart,
				State.ConstructorStart,
				State.Error,
				State.Error,
				State.ConstructorStart,
				State.ConstructorStart,
				State.ConstructorStart,
				State.ConstructorStart,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.Property,
				State.Error,
				State.Property,
				State.Property,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.Start,
				State.Property,
				State.ObjectStart,
				State.Object,
				State.ArrayStart,
				State.Array,
				State.Constructor,
				State.Constructor,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.Start,
				State.Property,
				State.ObjectStart,
				State.Object,
				State.ArrayStart,
				State.Array,
				State.Constructor,
				State.Constructor,
				State.Error,
				State.Error
			},
			new State[10]
			{
				State.Start,
				State.Object,
				State.Error,
				State.Error,
				State.Array,
				State.Array,
				State.Constructor,
				State.Constructor,
				State.Error,
				State.Error
			}
		};
		state_0 = Class7.smethod_678();
	}

	internal virtual void vmethod_0()
	{
	}

	protected Class38()
	{
		state_2 = State.Start;
		enum7_0 = Enum7.const_0;
		enum3_0 = Enum3.const_3;
		CloseOutput = true;
		AutoCompleteOnClose = true;
	}

	public abstract void vmethod_1();

	public virtual void vmethod_2()
	{
		if (AutoCompleteOnClose)
		{
			Class7.smethod_71(this);
		}
	}

	public virtual void vmethod_3()
	{
		Class7.smethod_506(this, JsonToken.StartObject, JsonContainerType.Object);
	}

	public virtual void vmethod_4()
	{
		Class7.smethod_568(this, JsonContainerType.Object);
	}

	public virtual void vmethod_5()
	{
		Class7.smethod_506(this, JsonToken.StartArray, JsonContainerType.Array);
	}

	public virtual void vmethod_6()
	{
		Class7.smethod_568(this, JsonContainerType.Array);
	}

	public virtual void vmethod_7(string string_1)
	{
		Class7.smethod_506(this, JsonToken.StartConstructor, JsonContainerType.Constructor);
	}

	public virtual void vmethod_8()
	{
		Class7.smethod_568(this, JsonContainerType.Constructor);
	}

	public virtual void vmethod_9(string string_1)
	{
		Class7.smethod_591(this, string_1);
	}

	public virtual void vmethod_10(string string_1, bool bool_2)
	{
		vmethod_9(string_1);
	}

	public virtual void vmethod_11()
	{
		Class7.smethod_752(this, struct0_0.jsonContainerType_0);
	}

	public void method_0(JsonToken jsonToken_0, object? object_0)
	{
		switch (jsonToken_0)
		{
		default:
			throw Class7.smethod_740("token", (object)jsonToken_0, "Unexpected token type.");
		case JsonToken.None:
			break;
		case JsonToken.StartObject:
			vmethod_3();
			break;
		case JsonToken.StartArray:
			vmethod_5();
			break;
		case JsonToken.StartConstructor:
			Class113.smethod_0(object_0, "value");
			vmethod_7(object_0!.ToString());
			break;
		case JsonToken.PropertyName:
			Class113.smethod_0(object_0, "value");
			vmethod_9(object_0!.ToString());
			break;
		case JsonToken.Comment:
			vmethod_59(object_0?.ToString());
			break;
		case JsonToken.Raw:
			vmethod_20(object_0?.ToString());
			break;
		case JsonToken.Integer:
			Class113.smethod_0(object_0, "value");
			if (object_0 is BigInteger bigInteger)
			{
				vmethod_58(bigInteger);
			}
			else
			{
				vmethod_24(Convert.ToInt64(object_0, CultureInfo.InvariantCulture));
			}
			break;
		case JsonToken.Float:
			Class113.smethod_0(object_0, "value");
			if (object_0 is decimal decimal_)
			{
				vmethod_34(decimal_);
			}
			else if (object_0 is double double_)
			{
				vmethod_27(double_);
			}
			else if (object_0 is float float_)
			{
				vmethod_26(float_);
			}
			else
			{
				vmethod_27(Convert.ToDouble(object_0, CultureInfo.InvariantCulture));
			}
			break;
		case JsonToken.String:
			vmethod_21(object_0?.ToString());
			break;
		case JsonToken.Boolean:
			Class113.smethod_0(object_0, "value");
			vmethod_28(Convert.ToBoolean(object_0, CultureInfo.InvariantCulture));
			break;
		case JsonToken.Null:
			vmethod_17();
			break;
		case JsonToken.Undefined:
			vmethod_18();
			break;
		case JsonToken.EndObject:
			vmethod_4();
			break;
		case JsonToken.EndArray:
			vmethod_6();
			break;
		case JsonToken.EndConstructor:
			vmethod_8();
			break;
		case JsonToken.Date:
			Class113.smethod_0(object_0, "value");
			if (object_0 is DateTimeOffset dateTimeOffset_)
			{
				vmethod_36(dateTimeOffset_);
			}
			else
			{
				vmethod_35(Convert.ToDateTime(object_0, CultureInfo.InvariantCulture));
			}
			break;
		case JsonToken.Bytes:
			Class113.smethod_0(object_0, "value");
			if (object_0 is Guid guid_)
			{
				vmethod_37(guid_);
			}
			else
			{
				vmethod_56((byte[])object_0);
			}
			break;
		}
	}

	internal virtual void vmethod_12(Class29 class29_0, bool bool_2, bool bool_3, bool bool_4)
	{
		int num = Class7.smethod_724(class29_0, this);
		do
		{
			if (!bool_3 || class29_0.TokenType != JsonToken.StartConstructor || !string.Equals(class29_0.Value?.ToString(), "Date", StringComparison.Ordinal))
			{
				if (bool_4 || class29_0.TokenType != JsonToken.Comment)
				{
					method_0(class29_0.TokenType, class29_0.Value);
				}
			}
			else
			{
				Class7.smethod_328(this, class29_0);
			}
		}
		while (num - 1 < class29_0.Depth - (Class7.smethod_471(class29_0.TokenType) ? 1 : 0) && bool_2 && class29_0.vmethod_0());
		if (Class7.smethod_776(this, class29_0, bool_2, num))
		{
			throw Class7.smethod_188(this, "Unexpected end when reading token.", (Exception?)null);
		}
	}

	internal void method_1(JsonContainerType jsonContainerType_0)
	{
		int num = Class7.smethod_673(jsonContainerType_0, this);
		for (int i = 0; i < num; i++)
		{
			JsonToken jsonToken_ = Class7.smethod_646(this, Class7.smethod_34(this));
			if (state_2 == State.Property)
			{
				vmethod_17();
			}
			if (enum7_0 == Enum7.const_1 && state_2 != State.ObjectStart && state_2 != State.ArrayStart)
			{
				vmethod_14();
			}
			vmethod_13(jsonToken_);
			Class7.smethod_281(this);
		}
	}

	protected virtual void vmethod_13(JsonToken jsonToken_0)
	{
	}

	protected virtual void vmethod_14()
	{
	}

	protected virtual void vmethod_15()
	{
	}

	protected virtual void vmethod_16()
	{
	}

	internal void method_2(JsonToken jsonToken_0)
	{
		State state = state_0[(int)jsonToken_0][(int)state_2];
		if (state == State.Error)
		{
			throw Class7.smethod_188(this, "Token {0} in state {1} would result in an invalid JSON object.".smethod_2(CultureInfo.InvariantCulture, jsonToken_0.ToString(), state_2.ToString()), (Exception?)null);
		}
		if ((state_2 == State.Object || state_2 == State.Array || state_2 == State.Constructor) && jsonToken_0 != JsonToken.Comment)
		{
			vmethod_15();
		}
		if (enum7_0 == Enum7.const_1)
		{
			if (state_2 == State.Property)
			{
				vmethod_16();
			}
			if (state_2 == State.Array || state_2 == State.ArrayStart || state_2 == State.Constructor || state_2 == State.ConstructorStart || (jsonToken_0 == JsonToken.PropertyName && state_2 != 0))
			{
				vmethod_14();
			}
		}
		state_2 = state;
	}

	public virtual void vmethod_17()
	{
		Class7.smethod_325(this, JsonToken.Null);
	}

	public virtual void vmethod_18()
	{
		Class7.smethod_325(this, JsonToken.Undefined);
	}

	public virtual void vmethod_19(string? string_1)
	{
		Class7.smethod_770(this);
	}

	public virtual void vmethod_20(string? string_1)
	{
		Class7.smethod_725(this);
		method_2(JsonToken.Undefined);
		vmethod_19(string_1);
	}

	public virtual void vmethod_21(string? string_1)
	{
		Class7.smethod_325(this, JsonToken.String);
	}

	public virtual void vmethod_22(int int_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	[CLSCompliant(false)]
	public virtual void vmethod_23(uint uint_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	public virtual void vmethod_24(long long_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	[CLSCompliant(false)]
	public virtual void vmethod_25(ulong ulong_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	public virtual void vmethod_26(float float_0)
	{
		Class7.smethod_325(this, JsonToken.Float);
	}

	public virtual void vmethod_27(double double_0)
	{
		Class7.smethod_325(this, JsonToken.Float);
	}

	public virtual void vmethod_28(bool bool_2)
	{
		Class7.smethod_325(this, JsonToken.Boolean);
	}

	public virtual void vmethod_29(short short_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	[CLSCompliant(false)]
	public virtual void vmethod_30(ushort ushort_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	public virtual void vmethod_31(char char_0)
	{
		Class7.smethod_325(this, JsonToken.String);
	}

	public virtual void vmethod_32(byte byte_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	[CLSCompliant(false)]
	public virtual void vmethod_33(sbyte sbyte_0)
	{
		Class7.smethod_325(this, JsonToken.Integer);
	}

	public virtual void vmethod_34(decimal decimal_0)
	{
		Class7.smethod_325(this, JsonToken.Float);
	}

	public virtual void vmethod_35(DateTime dateTime_0)
	{
		Class7.smethod_325(this, JsonToken.Date);
	}

	public virtual void vmethod_36(DateTimeOffset dateTimeOffset_0)
	{
		Class7.smethod_325(this, JsonToken.Date);
	}

	public virtual void vmethod_37(Guid guid_0)
	{
		Class7.smethod_325(this, JsonToken.String);
	}

	public virtual void vmethod_38(TimeSpan timeSpan_0)
	{
		Class7.smethod_325(this, JsonToken.String);
	}

	public virtual void vmethod_39(int? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_22(nullable_0.GetValueOrDefault());
		}
	}

	[CLSCompliant(false)]
	public virtual void vmethod_40(uint? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_23(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_41(long? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_24(nullable_0.GetValueOrDefault());
		}
	}

	[CLSCompliant(false)]
	public virtual void vmethod_42(ulong? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_25(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_43(float? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_26(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_44(double? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_27(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_45(bool? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_28(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_46(short? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_29(nullable_0.GetValueOrDefault());
		}
	}

	[CLSCompliant(false)]
	public virtual void vmethod_47(ushort? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_30(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_48(char? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_31(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_49(byte? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_32(nullable_0.GetValueOrDefault());
		}
	}

	[CLSCompliant(false)]
	public virtual void vmethod_50(sbyte? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_33(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_51(decimal? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_34(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_52(DateTime? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_35(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_53(DateTimeOffset? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_36(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_54(Guid? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_37(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_55(TimeSpan? nullable_0)
	{
		if (!nullable_0.HasValue)
		{
			vmethod_17();
		}
		else
		{
			vmethod_38(nullable_0.GetValueOrDefault());
		}
	}

	public virtual void vmethod_56(byte[]? byte_0)
	{
		if (byte_0 == null)
		{
			vmethod_17();
		}
		else
		{
			Class7.smethod_325(this, JsonToken.Bytes);
		}
	}

	public virtual void vmethod_57(Uri? uri_0)
	{
		if (uri_0 == null)
		{
			vmethod_17();
		}
		else
		{
			Class7.smethod_325(this, JsonToken.String);
		}
	}

	public virtual void vmethod_58(object? object_0)
	{
		if (object_0 == null)
		{
			vmethod_17();
			return;
		}
		if (object_0 is BigInteger)
		{
			throw Class7.smethod_135(this, object_0);
		}
		Class7.smethod_491(this, Class7.smethod_524(object_0!.GetType()), object_0);
	}

	public virtual void vmethod_59(string? string_1)
	{
		Class7.smethod_705(this);
	}

	public virtual void vmethod_60(string string_1)
	{
		Class7.smethod_313(this, string_1);
	}

	void IDisposable.Dispose()
	{
		vmethod_61(bool_2: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void vmethod_61(bool bool_2)
	{
		if (state_2 != State.Closed && bool_2)
		{
			vmethod_2();
		}
	}
}
