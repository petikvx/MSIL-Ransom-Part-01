using System;
using System.Collections.Generic;
using System.Reflection;
using Google.Protobuf;
using MySqlX.XDevAPI;
using Mysqlx.Crud;
using Mysqlx.Datatypes;
using Mysqlx.Expr;

namespace MySqlX.Protocol.X;

internal class ExprUtil
{
	public static Expr BuildLiteralNullScalar()
	{
		return BuildLiteralExpr(NullScalar());
	}

	public static Expr BuildLiteralScalar(double d)
	{
		return BuildLiteralExpr(ScalarOf(d));
	}

	public static Expr BuildLiteralScalar(long l)
	{
		return BuildLiteralExpr(ScalarOf(l));
	}

	public static Expr BuildLiteralScalar(ulong l)
	{
		return BuildLiteralExpr(ScalarOf(l));
	}

	public static Expr BuildLiteralScalar(string str)
	{
		return BuildLiteralExpr(ScalarOf(str));
	}

	public static Expr BuildLiteralScalar(byte[] bytes)
	{
		return BuildLiteralExpr(ScalarOf(bytes));
	}

	public static Expr BuildLiteralScalar(bool b)
	{
		return BuildLiteralExpr(ScalarOf(b));
	}

	public static Expr BuildLiteralExpr(Scalar scalar)
	{
		return new Expr
		{
			Type = Expr.Types.Type.Literal,
			Literal = scalar
		};
	}

	public static Scalar NullScalar()
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VNull
		};
	}

	public static Scalar ScalarOf(double d)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VDouble,
			VDouble = d
		};
	}

	public static Scalar ScalarOf(long l)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VSint,
			VSignedInt = l
		};
	}

	public static Scalar ScalarOf(ulong ul)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VUint,
			VUnsignedInt = ul
		};
	}

	public static Scalar ScalarOf(string str)
	{
		Scalar.Types.String vString = new Scalar.Types.String
		{
			Value = ByteString.CopyFromUtf8(str)
		};
		return new Scalar
		{
			Type = Scalar.Types.Type.VString,
			VString = vString
		};
	}

	public static Scalar ScalarOf(byte[] bytes)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VOctets,
			VOctets = new Scalar.Types.Octets
			{
				Value = ByteString.CopyFrom(bytes)
			}
		};
	}

	public static Scalar ScalarOf(bool b)
	{
		return new Scalar
		{
			Type = Scalar.Types.Type.VBool,
			VBool = b
		};
	}

	public static Any BuildAny(string str)
	{
		Scalar.Types.String @string = new Scalar.Types.String();
		@string.Value = ByteString.CopyFromUtf8(str);
		Scalar scalar = new Scalar();
		scalar.Type = Scalar.Types.Type.VString;
		scalar.VString = @string;
		return new Any
		{
			Type = Any.Types.Type.Scalar,
			Scalar = scalar
		};
	}

	public static Mysqlx.Datatypes.Object.Types.ObjectField BuildObject(string key, object value, bool evaluateStringExpression)
	{
		return new Mysqlx.Datatypes.Object.Types.ObjectField
		{
			Key = key,
			Value = (evaluateStringExpression ? BuildAny(value) : BuildAnyWithoutEvaluationExpression(value))
		};
	}

	public static Any BuildEmptyAny(Any.Types.Type type)
	{
		return new Any
		{
			Type = type,
			Obj = new Mysqlx.Datatypes.Object()
		};
	}

	public static Any BuildAny(bool b)
	{
		return new Any
		{
			Type = Any.Types.Type.Scalar,
			Scalar = ScalarOf(b)
		};
	}

	public static Any BuildAny(object value)
	{
		return new Any
		{
			Type = Any.Types.Type.Scalar,
			Scalar = ArgObjectToScalar(value)
		};
	}

	public static Any BuildAnyWithoutEvaluationExpression(object value)
	{
		return new Any
		{
			Type = Any.Types.Type.Scalar,
			Scalar = ArgObjectToScalar(value, evaluateStringExpression: false)
		};
	}

	public static Mysqlx.Crud.Collection BuildCollection(string schemaName, string collectionName)
	{
		return new Mysqlx.Crud.Collection
		{
			Schema = schemaName,
			Name = collectionName
		};
	}

	public static Scalar ArgObjectToScalar(object value, bool evaluateStringExpression = true)
	{
		return ArgObjectToExpr(value, allowRelationalColumns: false, evaluateStringExpression).Literal;
	}

	public static Expr ArgObjectToExpr(object value, bool allowRelationalColumns, bool evaluateStringExpresssion = true)
	{
		if (value == null)
		{
			return BuildLiteralNullScalar();
		}
		if (value is Dictionary<string, object>)
		{
			value = new DbDoc(value).ToString();
		}
		if (value is MySqlExpression)
		{
			value = (value as MySqlExpression).value;
		}
		if (value is bool)
		{
			return BuildLiteralScalar(Convert.ToBoolean(value));
		}
		if (!(value is byte) && !(value is short) && !(value is int) && !(value is long))
		{
			if (!(value is ushort) && !(value is uint) && !(value is ulong))
			{
				if (!(value is float) && !(value is double))
				{
					if (value is string)
					{
						try
						{
							string text = (string)value;
							if (!evaluateStringExpresssion)
							{
								return BuildLiteralScalar((string)value);
							}
							Expr expr = new ExprParser(text).Parse();
							if (expr.Identifier != null)
							{
								return BuildLiteralScalar(text);
							}
							return expr;
						}
						catch
						{
							return BuildLiteralScalar((string)value);
						}
					}
					if (value is DbDoc)
					{
						return BuildLiteralScalar(value.ToString());
					}
					throw new NotSupportedException("Value of type " + value.GetType()?.ToString() + " is not currently supported.");
				}
				return BuildLiteralScalar(Convert.ToDouble(value));
			}
			return BuildLiteralScalar(Convert.ToUInt64(value));
		}
		return BuildLiteralScalar(Convert.ToInt64(value));
	}

	public static string JoinString(string[] values)
	{
		if (values == null)
		{
			return string.Empty;
		}
		return string.Join(", ", values);
	}

	public static Dictionary<string, object> ParseAnonymousObject(object value)
	{
		if (value == null)
		{
			return null;
		}
		Type type = value.GetType();
		if (type.Name.Contains("Anonymous"))
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			PropertyInfo[] properties = type.GetProperties();
			foreach (PropertyInfo propertyInfo in properties)
			{
				dictionary.Add(propertyInfo.Name, propertyInfo.GetValue(value, null));
			}
			return dictionary;
		}
		return null;
	}
}
