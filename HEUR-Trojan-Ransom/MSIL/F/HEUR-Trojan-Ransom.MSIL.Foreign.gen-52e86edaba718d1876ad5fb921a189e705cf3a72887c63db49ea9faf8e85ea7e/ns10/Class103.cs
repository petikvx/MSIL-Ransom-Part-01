using System;
using System.Collections.Generic;
using Google.Protobuf;
using MySqlX.Protocol.X;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Expr;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns20;

namespace ns10;

internal sealed class Class103
{
	[NonSerialized]
	internal static GetString getString_0;

	public static Expr smethod_0()
	{
		return smethod_7(smethod_8());
	}

	public static Expr smethod_1(double double_0)
	{
		return smethod_7(smethod_9(double_0));
	}

	public static Expr smethod_2(long long_0)
	{
		return smethod_7(smethod_10(long_0));
	}

	public static Expr smethod_3(ulong ulong_0)
	{
		return smethod_7(smethod_11(ulong_0));
	}

	public static Expr smethod_4(string string_0)
	{
		return smethod_7(smethod_12(string_0));
	}

	public static Expr smethod_5(byte[] byte_0)
	{
		return smethod_7(smethod_13(byte_0));
	}

	public static Expr smethod_6(bool bool_0)
	{
		return smethod_7(smethod_14(bool_0));
	}

	public static Expr smethod_7(Scalar scalar_0)
	{
		return new Expr
		{
			Type = Expr.Types.Type.Literal,
			Literal = scalar_0
		};
	}

	public static Scalar smethod_8()
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VNull
		};
	}

	public static Scalar smethod_9(double double_0)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VDouble,
			VDouble = double_0
		};
	}

	public static Scalar smethod_10(long long_0)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VSint,
			VSignedInt = long_0
		};
	}

	public static Scalar smethod_11(ulong ulong_0)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VUint,
			VUnsignedInt = ulong_0
		};
	}

	public static Scalar smethod_12(string string_0)
	{
		Scalar.Types.String vString = new Scalar.Types.String
		{
			Value = ByteString.CopyFromUtf8(string_0)
		};
		return new Scalar
		{
			Type = Scalar.Types.Type.VString,
			VString = vString
		};
	}

	public static Scalar smethod_13(byte[] byte_0)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VOctets,
			VOctets = new Scalar.Types.Octets
			{
				Value = ByteString.CopyFrom(byte_0)
			}
		};
	}

	public static Scalar smethod_14(bool bool_0)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VBool,
			VBool = bool_0
		};
	}

	public static Any smethod_15(string string_0)
	{
		Scalar.Types.String @string = new Scalar.Types.String();
		@string.Value = ByteString.CopyFromUtf8(string_0);
		Scalar scalar = new Scalar();
		scalar.Type = Scalar.Types.Type.VString;
		scalar.VString = @string;
		return new Any
		{
			Type = Any.Class31.Enum14.const_1,
			Scalar = scalar
		};
	}

	public static Mysqlx.Datatypes.Object.Types.ObjectField smethod_16(string string_0, object object_0, bool bool_0)
	{
		return new Mysqlx.Datatypes.Object.Types.ObjectField
		{
			Key = string_0,
			Value = (bool_0 ? smethod_19(object_0) : smethod_20(object_0))
		};
	}

	public static Any smethod_17(Any.Class31.Enum14 enum14_0)
	{
		return new Any
		{
			Type = enum14_0,
			Obj = new Mysqlx.Datatypes.Object()
		};
	}

	public static Any smethod_18(bool bool_0)
	{
		return new Any
		{
			Type = Any.Class31.Enum14.const_1,
			Scalar = smethod_14(bool_0)
		};
	}

	public static Any smethod_19(object object_0)
	{
		return new Any
		{
			Type = Any.Class31.Enum14.const_1,
			Scalar = smethod_22(object_0)
		};
	}

	public static Any smethod_20(object object_0)
	{
		return new Any
		{
			Type = Any.Class31.Enum14.const_1,
			Scalar = smethod_22(object_0, bool_0: false)
		};
	}

	public static Collection smethod_21(string string_0, string string_1)
	{
		return new Collection
		{
			Schema = string_0,
			Name = string_1
		};
	}

	public static Scalar smethod_22(object object_0, bool bool_0 = true)
	{
		return smethod_23(object_0, bool_0: false, bool_0).Literal;
	}

	public static Expr smethod_23(object object_0, bool bool_0, bool bool_1 = true)
	{
		if (object_0 == null)
		{
			return smethod_0();
		}
		if (object_0 is Dictionary<string, object>)
		{
			object_0 = new Class43(object_0).ToString();
		}
		if (object_0 is bool)
		{
			return smethod_6(Convert.ToBoolean(object_0));
		}
		if (!(object_0 is byte) && !(object_0 is short) && !(object_0 is int) && !(object_0 is long))
		{
			if (!(object_0 is ushort) && !(object_0 is uint) && !(object_0 is ulong))
			{
				if (!(object_0 is float) && !(object_0 is double))
				{
					if (object_0 is string)
					{
						try
						{
							string text = (string)object_0;
							if (!bool_1)
							{
								return smethod_4((string)object_0);
							}
							Expr expr = new ExprParser(text).method_31();
							if (expr.Identifier != null)
							{
								return smethod_4(text);
							}
							return expr;
						}
						catch
						{
							return smethod_4((string)object_0);
						}
					}
					if (object_0 is Class43)
					{
						return smethod_4(object_0.ToString());
					}
					throw new NotSupportedException(string.Concat(getString_0(107404648), object_0.GetType(), getString_0(107404659)));
				}
				return smethod_1(Convert.ToDouble(object_0));
			}
			return smethod_3(Convert.ToUInt64(object_0));
		}
		return smethod_2(Convert.ToInt64(object_0));
	}

	public static string smethod_24(string[] string_0)
	{
		if (string_0 == null)
		{
			return string.Empty;
		}
		return string.Join(getString_0(107408906), string_0);
	}

	static Class103()
	{
		Strings.CreateGetStringDelegate(typeof(Class103));
	}
}
