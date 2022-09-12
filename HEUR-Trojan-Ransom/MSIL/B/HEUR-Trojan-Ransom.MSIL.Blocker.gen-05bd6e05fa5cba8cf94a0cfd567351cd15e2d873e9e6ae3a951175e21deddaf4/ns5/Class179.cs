using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;
using ns10;
using ns17;
using ns18;
using ns19;
using ns2;
using ns7;

namespace ns5;

internal class Class179 : JToken, IConvertible, IEquatable<Class179>, IComparable<Class179>, IFormattable, IComparable
{
	private class Class53 : Class52<Class179>
	{
		public override bool vmethod_2(Class179 class179_0, ConvertBinder convertBinder_0, [Attribute1(true)] out object? object_0)
		{
			if (!(convertBinder_0.Type == typeof(Class179)) && !(convertBinder_0.Type == typeof(JToken)))
			{
				object value = class179_0.Value;
				if (value == null)
				{
					object_0 = null;
					return Class4.smethod_753(convertBinder_0.Type);
				}
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				Type type = convertBinder_0.Type;
				object_0 = Class4.smethod_722(type, value, invariantCulture);
				return true;
			}
			object_0 = class179_0;
			return true;
		}

		public override bool vmethod_1(Class179 class179_0, BinaryOperationBinder binaryOperationBinder_0, object object_0, [Attribute1(true)] out object? object_1)
		{
			object object_2 = ((object_0 is Class179 @class) ? @class.Value : object_0);
			switch (binaryOperationBinder_0.Operation)
			{
			case ExpressionType.Equal:
				object_1 = smethod_37(class179_0.Type, class179_0.Value, object_2) == 0;
				return true;
			case ExpressionType.GreaterThan:
				object_1 = smethod_37(class179_0.Type, class179_0.Value, object_2) > 0;
				return true;
			case ExpressionType.GreaterThanOrEqual:
				object_1 = smethod_37(class179_0.Type, class179_0.Value, object_2) >= 0;
				return true;
			case ExpressionType.LessThan:
				object_1 = smethod_37(class179_0.Type, class179_0.Value, object_2) < 0;
				return true;
			case ExpressionType.LessThanOrEqual:
				object_1 = smethod_37(class179_0.Type, class179_0.Value, object_2) <= 0;
				return true;
			case ExpressionType.NotEqual:
				object_1 = smethod_37(class179_0.Type, class179_0.Value, object_2) != 0;
				return true;
			case ExpressionType.Add:
			case ExpressionType.Divide:
			case ExpressionType.Multiply:
			case ExpressionType.Subtract:
			case ExpressionType.AddAssign:
			case ExpressionType.DivideAssign:
			case ExpressionType.MultiplyAssign:
			case ExpressionType.SubtractAssign:
				if (smethod_39(binaryOperationBinder_0.Operation, class179_0.Value, object_2, out object_1))
				{
					object_1 = new Class179(object_1);
					return true;
				}
				break;
			}
			object_1 = null;
			return false;
		}
	}

	internal JTokenType jtokenType_10;

	internal object? object_1;

	public override bool HasValues => false;

	public override JTokenType Type => jtokenType_10;

	public object? Value
	{
		get
		{
			return object_1;
		}
		set
		{
			Type obj = object_1?.GetType();
			Type type = value?.GetType();
			if (obj != type)
			{
				jtokenType_10 = smethod_40(jtokenType_10, value);
			}
			object_1 = value;
		}
	}

	internal Class179(object? object_2, JTokenType jtokenType_11)
	{
		object_1 = object_2;
		jtokenType_10 = jtokenType_11;
	}

	public Class179(Class179 class179_0)
		: this(class179_0.Value, class179_0.Type)
	{
		Class4.smethod_564((JToken)this, (JToken)this, (JToken)class179_0);
	}

	public Class179(long long_0)
		: this(long_0, JTokenType.Integer)
	{
	}

	public Class179(decimal decimal_0)
		: this(decimal_0, JTokenType.Float)
	{
	}

	public Class179(char char_0)
		: this(char_0, JTokenType.String)
	{
	}

	[CLSCompliant(false)]
	public Class179(ulong ulong_0)
		: this(ulong_0, JTokenType.Integer)
	{
	}

	public Class179(double double_0)
		: this(double_0, JTokenType.Float)
	{
	}

	public Class179(float float_0)
		: this(float_0, JTokenType.Float)
	{
	}

	public Class179(DateTime dateTime_0)
		: this(dateTime_0, JTokenType.Date)
	{
	}

	public Class179(DateTimeOffset dateTimeOffset_0)
		: this(dateTimeOffset_0, JTokenType.Date)
	{
	}

	public Class179(bool bool_0)
		: this(bool_0, JTokenType.Boolean)
	{
	}

	public Class179(string? string_0)
		: this(string_0, JTokenType.String)
	{
	}

	public Class179(Guid guid_0)
		: this(guid_0, JTokenType.Guid)
	{
	}

	public Class179(Uri? uri_0)
		: this(uri_0, (uri_0 != null) ? JTokenType.Uri : JTokenType.Null)
	{
	}

	public Class179(TimeSpan timeSpan_0)
		: this(timeSpan_0, JTokenType.TimeSpan)
	{
	}

	public Class179(object? object_2)
		: this(object_2, smethod_40(null, object_2))
	{
	}

	internal override bool vmethod_1(JToken jtoken_2)
	{
		if (!(jtoken_2 is Class179 @class))
		{
			return false;
		}
		if (@class == this)
		{
			return true;
		}
		return Class4.smethod_677(this, @class);
	}

	private static int smethod_36(BigInteger bigInteger_0, object object_2)
	{
		int num = bigInteger_0.CompareTo(Class4.smethod_522(object_2));
		if (num != 0)
		{
			return num;
		}
		if (object_2 is decimal num2)
		{
			return 0m.CompareTo(Math.Abs(num2 - Math.Truncate(num2)));
		}
		if (!(object_2 is double) && !(object_2 is float))
		{
			return num;
		}
		double num3 = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
		return 0.0.CompareTo(Math.Abs(num3 - Math.Truncate(num3)));
	}

	internal static int smethod_37(JTokenType jtokenType_11, object? object_2, object? object_3)
	{
		if (object_2 == object_3)
		{
			return 0;
		}
		if (object_3 == null)
		{
			return 1;
		}
		if (object_2 == null)
		{
			return -1;
		}
		switch (jtokenType_11)
		{
		case JTokenType.Integer:
			if (object_2 is BigInteger bigInteger_3)
			{
				return smethod_36(bigInteger_3, object_3);
			}
			if (object_3 is BigInteger bigInteger_4)
			{
				return -smethod_36(bigInteger_4, object_2);
			}
			if (!(object_2 is ulong) && !(object_3 is ulong) && !(object_2 is decimal) && !(object_3 is decimal))
			{
				if (!(object_2 is float) && !(object_3 is float) && !(object_2 is double) && !(object_3 is double))
				{
					return Convert.ToInt64(object_2, CultureInfo.InvariantCulture).CompareTo(Convert.ToInt64(object_3, CultureInfo.InvariantCulture));
				}
				return smethod_38(object_2, object_3);
			}
			return Convert.ToDecimal(object_2, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(object_3, CultureInfo.InvariantCulture));
		case JTokenType.Float:
			if (object_2 is BigInteger bigInteger_)
			{
				return smethod_36(bigInteger_, object_3);
			}
			if (object_3 is BigInteger bigInteger_2)
			{
				return -smethod_36(bigInteger_2, object_2);
			}
			if (!(object_2 is ulong) && !(object_3 is ulong) && !(object_2 is decimal) && !(object_3 is decimal))
			{
				return smethod_38(object_2, object_3);
			}
			return Convert.ToDecimal(object_2, CultureInfo.InvariantCulture).CompareTo(Convert.ToDecimal(object_3, CultureInfo.InvariantCulture));
		case JTokenType.Boolean:
		{
			bool flag = Convert.ToBoolean(object_2, CultureInfo.InvariantCulture);
			bool value2 = Convert.ToBoolean(object_3, CultureInfo.InvariantCulture);
			return flag.CompareTo(value2);
		}
		default:
			throw Class4.smethod_3("valueType", (object)jtokenType_11, "Unexpected value type: {0}".smethod_1(CultureInfo.InvariantCulture, jtokenType_11));
		case JTokenType.Date:
		{
			if (object_2 is DateTime dateTime)
			{
				DateTime value3 = ((!(object_3 is DateTimeOffset dateTimeOffset)) ? Convert.ToDateTime(object_3, CultureInfo.InvariantCulture) : dateTimeOffset.DateTime);
				return dateTime.CompareTo(value3);
			}
			DateTimeOffset dateTimeOffset2 = (DateTimeOffset)object_2;
			DateTimeOffset other = ((!(object_3 is DateTimeOffset)) ? new DateTimeOffset(Convert.ToDateTime(object_3, CultureInfo.InvariantCulture)) : ((DateTimeOffset)object_3));
			return dateTimeOffset2.CompareTo(other);
		}
		case JTokenType.Comment:
		case JTokenType.String:
		case JTokenType.Raw:
		{
			string? strA = Convert.ToString(object_2, CultureInfo.InvariantCulture);
			string strB = Convert.ToString(object_3, CultureInfo.InvariantCulture);
			return string.CompareOrdinal(strA, strB);
		}
		case JTokenType.Bytes:
			if (!(object_3 is byte[] byte_))
			{
				throw new ArgumentException("Object must be of type byte[].");
			}
			return Class98.smethod_2(object_2 as byte[], byte_);
		case JTokenType.Guid:
		{
			if (!(object_3 is Guid))
			{
				throw new ArgumentException("Object must be of type Guid.");
			}
			Guid guid = (Guid)object_2;
			Guid value4 = (Guid)object_3;
			return guid.CompareTo(value4);
		}
		case JTokenType.Uri:
		{
			Uri uri = object_3 as Uri;
			if (uri == null)
			{
				throw new ArgumentException("Object must be of type Uri.");
			}
			Uri uri2 = (Uri)object_2;
			return Comparer<string>.Default.Compare(uri2.ToString(), uri.ToString());
		}
		case JTokenType.TimeSpan:
		{
			if (!(object_3 is TimeSpan))
			{
				throw new ArgumentException("Object must be of type TimeSpan.");
			}
			TimeSpan timeSpan = (TimeSpan)object_2;
			TimeSpan value = (TimeSpan)object_3;
			return timeSpan.CompareTo(value);
		}
		}
	}

	private static int smethod_38(object object_2, object object_3)
	{
		double double_ = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
		double num = Convert.ToDouble(object_3, CultureInfo.InvariantCulture);
		if (Class4.smethod_641(double_, num))
		{
			return 0;
		}
		return double_.CompareTo(num);
	}

	private static bool smethod_39(ExpressionType expressionType_0, object? object_2, object? object_3, out object? object_4)
	{
		if ((!(object_2 is string) && !(object_3 is string)) || (expressionType_0 != 0 && expressionType_0 != ExpressionType.AddAssign))
		{
			if (!(object_2 is BigInteger) && !(object_3 is BigInteger))
			{
				if (!(object_2 is ulong) && !(object_3 is ulong) && !(object_2 is decimal) && !(object_3 is decimal))
				{
					if (!(object_2 is float) && !(object_3 is float) && !(object_2 is double) && !(object_3 is double))
					{
						if (object_2 is int || object_2 is uint || object_2 is long || object_2 is short || object_2 is ushort || object_2 is sbyte || object_2 is byte || object_3 is int || object_3 is uint || object_3 is long || object_3 is short || object_3 is ushort || object_3 is sbyte || object_3 is byte)
						{
							if (object_2 == null || object_3 == null)
							{
								object_4 = null;
								return true;
							}
							long num = Convert.ToInt64(object_2, CultureInfo.InvariantCulture);
							long num2 = Convert.ToInt64(object_3, CultureInfo.InvariantCulture);
							switch (expressionType_0)
							{
							case ExpressionType.Divide:
							case ExpressionType.DivideAssign:
								object_4 = num / num2;
								return true;
							case ExpressionType.Add:
							case ExpressionType.AddAssign:
								object_4 = num + num2;
								return true;
							case ExpressionType.Subtract:
							case ExpressionType.SubtractAssign:
								object_4 = num - num2;
								return true;
							case ExpressionType.Multiply:
							case ExpressionType.MultiplyAssign:
								object_4 = num * num2;
								return true;
							}
						}
					}
					else
					{
						if (object_2 == null || object_3 == null)
						{
							object_4 = null;
							return true;
						}
						double num3 = Convert.ToDouble(object_2, CultureInfo.InvariantCulture);
						double num4 = Convert.ToDouble(object_3, CultureInfo.InvariantCulture);
						switch (expressionType_0)
						{
						case ExpressionType.Divide:
						case ExpressionType.DivideAssign:
							object_4 = num3 / num4;
							return true;
						case ExpressionType.Add:
						case ExpressionType.AddAssign:
							object_4 = num3 + num4;
							return true;
						case ExpressionType.Subtract:
						case ExpressionType.SubtractAssign:
							object_4 = num3 - num4;
							return true;
						case ExpressionType.Multiply:
						case ExpressionType.MultiplyAssign:
							object_4 = num3 * num4;
							return true;
						}
					}
				}
				else
				{
					if (object_2 == null || object_3 == null)
					{
						object_4 = null;
						return true;
					}
					decimal num5 = Convert.ToDecimal(object_2, CultureInfo.InvariantCulture);
					decimal num6 = Convert.ToDecimal(object_3, CultureInfo.InvariantCulture);
					switch (expressionType_0)
					{
					case ExpressionType.Divide:
					case ExpressionType.DivideAssign:
						object_4 = num5 / num6;
						return true;
					case ExpressionType.Add:
					case ExpressionType.AddAssign:
						object_4 = num5 + num6;
						return true;
					case ExpressionType.Subtract:
					case ExpressionType.SubtractAssign:
						object_4 = num5 - num6;
						return true;
					case ExpressionType.Multiply:
					case ExpressionType.MultiplyAssign:
						object_4 = num5 * num6;
						return true;
					}
				}
			}
			else
			{
				if (object_2 == null || object_3 == null)
				{
					object_4 = null;
					return true;
				}
				BigInteger bigInteger = Class4.smethod_522(object_2);
				BigInteger bigInteger2 = Class4.smethod_522(object_3);
				switch (expressionType_0)
				{
				case ExpressionType.Divide:
				case ExpressionType.DivideAssign:
					object_4 = bigInteger / bigInteger2;
					return true;
				case ExpressionType.Add:
				case ExpressionType.AddAssign:
					object_4 = bigInteger + bigInteger2;
					return true;
				case ExpressionType.Subtract:
				case ExpressionType.SubtractAssign:
					object_4 = bigInteger - bigInteger2;
					return true;
				case ExpressionType.Multiply:
				case ExpressionType.MultiplyAssign:
					object_4 = bigInteger * bigInteger2;
					return true;
				}
			}
			object_4 = null;
			return false;
		}
		object_4 = object_2?.ToString() + object_3;
		return true;
	}

	internal override JToken vmethod_0()
	{
		return new Class179(this);
	}

	private static JTokenType smethod_40(JTokenType? nullable_0, object? object_2)
	{
		if (object_2 == null)
		{
			return JTokenType.Null;
		}
		if (object_2 == DBNull.Value)
		{
			return JTokenType.Null;
		}
		if (object_2 is string)
		{
			return Class4.smethod_621(nullable_0);
		}
		if (!(object_2 is long) && !(object_2 is int) && !(object_2 is short) && !(object_2 is sbyte) && !(object_2 is ulong) && !(object_2 is uint) && !(object_2 is ushort) && !(object_2 is byte))
		{
			if (object_2 is Enum)
			{
				return JTokenType.Integer;
			}
			if (object_2 is BigInteger)
			{
				return JTokenType.Integer;
			}
			if (!(object_2 is double) && !(object_2 is float) && !(object_2 is decimal))
			{
				if (object_2 is DateTime)
				{
					return JTokenType.Date;
				}
				if (object_2 is DateTimeOffset)
				{
					return JTokenType.Date;
				}
				if (object_2 is byte[])
				{
					return JTokenType.Bytes;
				}
				if (object_2 is bool)
				{
					return JTokenType.Boolean;
				}
				if (object_2 is Guid)
				{
					return JTokenType.Guid;
				}
				if (object_2 is Uri)
				{
					return JTokenType.Uri;
				}
				if (object_2 is TimeSpan)
				{
					return JTokenType.TimeSpan;
				}
				throw new ArgumentException("Could not determine JSON object type for type {0}.".smethod_1(CultureInfo.InvariantCulture, object_2!.GetType()));
			}
			return JTokenType.Float;
		}
		return JTokenType.Integer;
	}

	public override void vmethod_5(Class38 class38_0, params Class9[] class9_0)
	{
		if (class9_0 != null && class9_0.Length != 0 && object_1 != null)
		{
			Class9 @class = Class4.smethod_573((IList<Class9>?)class9_0, object_1!.GetType());
			if (@class != null && @class.CanWrite)
			{
				@class.vmethod_0(class38_0, object_1, Class4.smethod_563());
				return;
			}
		}
		switch (jtokenType_10)
		{
		default:
			throw Class4.smethod_3("Type", (object)jtokenType_10, "Unexpected token type.");
		case JTokenType.Comment:
			class38_0.vmethod_59(object_1?.ToString());
			break;
		case JTokenType.Integer:
			if (object_1 is int int_)
			{
				class38_0.vmethod_22(int_);
			}
			else if (object_1 is long long_)
			{
				class38_0.vmethod_24(long_);
			}
			else if (object_1 is ulong ulong_)
			{
				class38_0.vmethod_25(ulong_);
			}
			else if (object_1 is BigInteger bigInteger)
			{
				class38_0.vmethod_58(bigInteger);
			}
			else
			{
				class38_0.vmethod_24(Convert.ToInt64(object_1, CultureInfo.InvariantCulture));
			}
			break;
		case JTokenType.Float:
			if (object_1 is decimal decimal_)
			{
				class38_0.vmethod_34(decimal_);
			}
			else if (object_1 is double double_)
			{
				class38_0.vmethod_27(double_);
			}
			else if (object_1 is float float_)
			{
				class38_0.vmethod_26(float_);
			}
			else
			{
				class38_0.vmethod_27(Convert.ToDouble(object_1, CultureInfo.InvariantCulture));
			}
			break;
		case JTokenType.String:
			class38_0.vmethod_21(object_1?.ToString());
			break;
		case JTokenType.Boolean:
			class38_0.vmethod_28(Convert.ToBoolean(object_1, CultureInfo.InvariantCulture));
			break;
		case JTokenType.Null:
			class38_0.vmethod_17();
			break;
		case JTokenType.Undefined:
			class38_0.vmethod_18();
			break;
		case JTokenType.Date:
			if (object_1 is DateTimeOffset dateTimeOffset_)
			{
				class38_0.vmethod_36(dateTimeOffset_);
			}
			else
			{
				class38_0.vmethod_35(Convert.ToDateTime(object_1, CultureInfo.InvariantCulture));
			}
			break;
		case JTokenType.Raw:
			class38_0.vmethod_20(object_1?.ToString());
			break;
		case JTokenType.Bytes:
			class38_0.vmethod_56((byte[])object_1);
			break;
		case JTokenType.Guid:
			class38_0.vmethod_54((object_1 != null) ? ((Guid?)object_1) : null);
			break;
		case JTokenType.Uri:
			class38_0.vmethod_57((Uri)object_1);
			break;
		case JTokenType.TimeSpan:
			class38_0.vmethod_55((object_1 != null) ? ((TimeSpan?)object_1) : null);
			break;
		}
	}

	internal override int vmethod_6()
	{
		int num = ((object_1 != null) ? object_1!.GetHashCode() : 0);
		int num2 = (int)jtokenType_10;
		return num2.GetHashCode() ^ num;
	}

	bool IEquatable<Class179>.Equals(Class179? other)
	{
		if (other == null)
		{
			return false;
		}
		return Class4.smethod_677(this, other);
	}

	public override bool Equals(object obj)
	{
		if (obj is Class179 other)
		{
			return System_002EIEquatable_003Cns5_002EClass179_003E_002EEquals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (object_1 == null)
		{
			return 0;
		}
		return object_1!.GetHashCode();
	}

	public override string ToString()
	{
		if (object_1 == null)
		{
			return string.Empty;
		}
		return object_1!.ToString();
	}

	public string method_10(string string_0)
	{
		return System_002EIFormattable_002EToString(string_0, CultureInfo.CurrentCulture);
	}

	string IConvertible.ToString(IFormatProvider provider)
	{
		return System_002EIFormattable_002EToString(null, provider);
	}

	string IFormattable.ToString(string? format, IFormatProvider formatProvider)
	{
		if (object_1 == null)
		{
			return string.Empty;
		}
		if (object_1 is IFormattable formattable)
		{
			return formattable.ToString(format, formatProvider);
		}
		return object_1!.ToString();
	}

	protected override DynamicMetaObject vmethod_7(Expression expression_0)
	{
		return new DynamicProxyMetaObject<Class179>(expression_0, this, new Class53());
	}

	int IComparable.CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		object object_;
		JTokenType jtokenType_;
		if (obj is Class179 @class)
		{
			object_ = @class.Value;
			jtokenType_ = ((jtokenType_10 != JTokenType.String || jtokenType_10 == @class.jtokenType_10) ? jtokenType_10 : @class.jtokenType_10);
		}
		else
		{
			object_ = obj;
			jtokenType_ = jtokenType_10;
		}
		return smethod_37(jtokenType_, object_1, object_);
	}

	int IComparable<Class179>.CompareTo(Class179 other)
	{
		if (other == null)
		{
			return 1;
		}
		return smethod_37((jtokenType_10 != JTokenType.String || jtokenType_10 == other.jtokenType_10) ? jtokenType_10 : other.jtokenType_10, object_1, other.object_1);
	}

	TypeCode IConvertible.GetTypeCode()
	{
		if (object_1 == null)
		{
			return TypeCode.Empty;
		}
		if (object_1 is IConvertible convertible)
		{
			return convertible.GetTypeCode();
		}
		return TypeCode.Object;
	}

	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Class4.smethod_120((JToken)this);
	}

	char IConvertible.ToChar(IFormatProvider provider)
	{
		return JToken.smethod_8(this);
	}

	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return JToken.smethod_9(this);
	}

	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return Class4.smethod_51((JToken)this);
	}

	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return Class4.smethod_7((JToken)this);
	}

	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return JToken.smethod_7(this);
	}

	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return Class4.smethod_233((JToken)this);
	}

	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return JToken.smethod_20(this);
	}

	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return Class4.smethod_227((JToken)this);
	}

	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return JToken.smethod_21(this);
	}

	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return Class4.smethod_756((JToken)this);
	}

	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return Class4.smethod_591((JToken)this);
	}

	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return Class4.smethod_460((JToken)this);
	}

	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		return Class4.smethod_601((JToken)this);
	}

	object? IConvertible.ToType(Type conversionType, IFormatProvider provider)
	{
		return Class4.smethod_80((JToken)this, conversionType);
	}
}
