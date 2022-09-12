using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;
using ns0;
using ns1;
using ns12;
using ns13;
using ns15;
using ns19;
using ns2;
using ns3;
using ns5;
using ns8;
using ns9;

namespace Newtonsoft.Json.Linq;

public abstract class JToken : IEnumerable<JToken>, Interface10<JToken>, Interface1, IEnumerable, IDynamicMetaObjectProvider, ICloneable
{
	internal class Class181
	{
		internal readonly int int_0;

		internal readonly int int_1;

		public Class181(int int_2, int int_3)
		{
			int_0 = int_2;
			int_1 = int_3;
		}
	}

	private static Class196? class196_0;

	internal Class176? class176_0;

	private JToken? jtoken_0;

	private JToken? jtoken_1;

	internal object? object_0;

	internal static readonly JTokenType[] jtokenType_0 = new JTokenType[6]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean
	};

	internal static readonly JTokenType[] jtokenType_1 = new JTokenType[6]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean
	};

	internal static readonly JTokenType[] jtokenType_2 = new JTokenType[7]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean,
		JTokenType.Bytes
	};

	private static readonly JTokenType[] jtokenType_3 = new JTokenType[11]
	{
		JTokenType.Date,
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Boolean,
		JTokenType.Bytes,
		JTokenType.Guid,
		JTokenType.TimeSpan,
		JTokenType.Uri
	};

	internal static readonly JTokenType[] jtokenType_4 = new JTokenType[5]
	{
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Guid,
		JTokenType.Bytes
	};

	internal static readonly JTokenType[] jtokenType_5 = new JTokenType[4]
	{
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.TimeSpan
	};

	private static readonly JTokenType[] jtokenType_6 = new JTokenType[4]
	{
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Uri
	};

	private static readonly JTokenType[] jtokenType_7 = new JTokenType[5]
	{
		JTokenType.Integer,
		JTokenType.Float,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw
	};

	internal static readonly JTokenType[] jtokenType_8 = new JTokenType[4]
	{
		JTokenType.Date,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw
	};

	private static readonly JTokenType[] jtokenType_9 = new JTokenType[5]
	{
		JTokenType.Bytes,
		JTokenType.String,
		JTokenType.Comment,
		JTokenType.Raw,
		JTokenType.Integer
	};

	public static Class196 EqualityComparer
	{
		get
		{
			if (class196_0 == null)
			{
				class196_0 = new Class196();
			}
			return class196_0;
		}
	}

	public Class176? Parent
	{
		[DebuggerStepThrough]
		get
		{
			return class176_0;
		}
		internal set
		{
			class176_0 = value;
		}
	}

	public JToken Root
	{
		get
		{
			Class176 parent = Parent;
			if (parent == null)
			{
				return this;
			}
			while (parent.Parent != null)
			{
				parent = parent.Parent;
			}
			return parent;
		}
	}

	public abstract JTokenType Type { get; }

	public abstract bool HasValues { get; }

	public JToken? Next
	{
		get
		{
			return jtoken_1;
		}
		internal set
		{
			jtoken_1 = value;
		}
	}

	public JToken? Previous
	{
		get
		{
			return jtoken_0;
		}
		internal set
		{
			jtoken_0 = value;
		}
	}

	public string Path
	{
		get
		{
			if (Parent == null)
			{
				return string.Empty;
			}
			List<Struct0> list = new List<Struct0>();
			JToken jToken = null;
			for (JToken jToken2 = this; jToken2 != null; jToken2 = jToken2.Parent)
			{
				switch (jToken2.Type)
				{
				case JTokenType.Property:
				{
					JProperty jProperty = (JProperty)jToken2;
					list.Add(new Struct0(JsonContainerType.Object)
					{
						string_0 = jProperty.Name
					});
					break;
				}
				case JTokenType.Array:
				case JTokenType.Constructor:
					if (jToken != null)
					{
						int int_ = ((IList<JToken>)jToken2).IndexOf(jToken);
						list.Add(new Struct0(JsonContainerType.Array)
						{
							int_0 = int_
						});
					}
					break;
				}
				jToken = jToken2;
			}
			list.smethod_9();
			return Struct0.smethod_1(list, null);
		}
	}

	public virtual JToken? this[object object_1]
	{
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".smethod_1(CultureInfo.InvariantCulture, GetType()));
		}
		set
		{
			throw new InvalidOperationException("Cannot set child value on {0}.".smethod_1(CultureInfo.InvariantCulture, GetType()));
		}
	}

	public virtual JToken? First
	{
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".smethod_1(CultureInfo.InvariantCulture, GetType()));
		}
	}

	public virtual JToken? Last
	{
		get
		{
			throw new InvalidOperationException("Cannot access child value on {0}.".smethod_1(CultureInfo.InvariantCulture, GetType()));
		}
	}

	Interface10<JToken> Interface10<JToken>.this[object object_1] => this[object_1];

	int Interface1.LineNumber => method_7<Class181>()?.int_0 ?? 0;

	int Interface1.LinePosition => method_7<Class181>()?.int_1 ?? 0;

	internal abstract JToken vmethod_0();

	internal abstract bool vmethod_1(JToken jtoken_2);

	public static bool smethod_0(JToken? jtoken_2, JToken? jtoken_3)
	{
		if (jtoken_2 != jtoken_3)
		{
			if (jtoken_2 != null && jtoken_3 != null)
			{
				return jtoken_2!.vmethod_1(jtoken_3);
			}
			return false;
		}
		return true;
	}

	internal JToken()
	{
	}

	public void method_0(object? object_1)
	{
		if (class176_0 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		int num = class176_0!.vmethod_12(this);
		class176_0!.method_15(num + 1, object_1, bool_1: false);
	}

	public void method_1(object? object_1)
	{
		if (class176_0 == null)
		{
			throw new InvalidOperationException("The parent is missing.");
		}
		int int_ = class176_0!.vmethod_12(this);
		class176_0!.method_15(int_, object_1, bool_1: false);
	}

	public virtual T? vmethod_2<T>(object object_1)
	{
		JToken jToken = this[object_1];
		if (jToken != null)
		{
			return jToken.smethod_15<JToken, T>();
		}
		return default(T);
	}

	public virtual Struct6<JToken> vmethod_3()
	{
		return Struct6<JToken>.struct6_0;
	}

	public Struct6<T> method_2<T>() where T : JToken
	{
		return new Struct6<T>(vmethod_3().OfType<T>());
	}

	public virtual IEnumerable<T?> vmethod_4<T>()
	{
		throw new InvalidOperationException("Cannot access child value on {0}.".smethod_1(CultureInfo.InvariantCulture, GetType()));
	}

	public abstract void vmethod_5(Class37 class37_0, params Class8[] class8_0);

	public override string ToString()
	{
		return Class131.smethod_568(Enum7.const_1, new Class8[0], this);
	}

	[SpecialName]
	public static bool? smethod_1(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_0, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return Convert.ToBoolean((int)bigInteger);
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToBoolean(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Boolean.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static DateTime? smethod_2(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_8, bool_0: true, (JToken)@class))
		{
			if (@class.Value is DateTimeOffset dateTimeOffset)
			{
				return dateTimeOffset.DateTime;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToDateTime(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to DateTime.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static DateTimeOffset? smethod_3(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_8, bool_0: true, (JToken)@class))
		{
			if (@class.Value == null)
			{
				return null;
			}
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
		throw new ArgumentException("Can not convert {0} to DateTimeOffset.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static decimal? smethod_4(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (decimal)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToDecimal(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Decimal.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static double? smethod_5(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (double)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToDouble(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Double.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static char? smethod_6(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_7, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (char)(ushort)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToChar(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Char.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static ushort smethod_7(JToken jtoken_2)
	{
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: false, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (ushort)bigInteger;
			}
			return Convert.ToUInt16(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt16.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static char smethod_8(JToken jtoken_2)
	{
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_7, bool_0: false, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (char)(ushort)bigInteger;
			}
			return Convert.ToChar(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Char.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static sbyte smethod_9(JToken jtoken_2)
	{
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: false, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (sbyte)bigInteger;
			}
			return Convert.ToSByte(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to SByte.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static int? smethod_10(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (int)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToInt32(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int32.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static short? smethod_11(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (short)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToInt16(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int16.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static ushort? smethod_12(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (ushort)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToUInt16(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt16.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static byte? smethod_13(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (byte)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToByte(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Byte.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static sbyte? smethod_14(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (sbyte)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToSByte(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to SByte.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static long? smethod_15(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (long)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToInt64(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Int64.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static float? smethod_16(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (float)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToSingle(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to Single.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static uint? smethod_17(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (uint)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToUInt32(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt32.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static ulong? smethod_18(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: true, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (ulong)bigInteger;
			}
			if (@class.Value == null)
			{
				return null;
			}
			return Convert.ToUInt64(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt64.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static string? smethod_19(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_3, bool_0: true, (JToken)@class))
		{
			if (@class.Value == null)
			{
				return null;
			}
			if (@class.Value is byte[] inArray)
			{
				return Convert.ToBase64String(inArray);
			}
			if (@class.Value is BigInteger bigInteger)
			{
				return bigInteger.ToString(CultureInfo.InvariantCulture);
			}
			return Convert.ToString(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to String.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static uint smethod_20(JToken jtoken_2)
	{
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: false, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (uint)bigInteger;
			}
			return Convert.ToUInt32(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt32.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static ulong smethod_21(JToken jtoken_2)
	{
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_1, bool_0: false, (JToken)@class))
		{
			if (@class.Value is BigInteger bigInteger)
			{
				return (ulong)bigInteger;
			}
			return Convert.ToUInt64(@class.Value, CultureInfo.InvariantCulture);
		}
		throw new ArgumentException("Can not convert {0} to UInt64.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static byte[]? smethod_22(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_9, bool_0: false, (JToken)@class))
		{
			if (@class.Value is string)
			{
				return Convert.FromBase64String(Convert.ToString(@class.Value, CultureInfo.InvariantCulture));
			}
			if (@class.Value is BigInteger bigInteger)
			{
				return bigInteger.ToByteArray();
			}
			if (!(@class.Value is byte[] result))
			{
				throw new ArgumentException("Can not convert {0} to byte array.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
			}
			return result;
		}
		throw new ArgumentException("Can not convert {0} to byte array.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static Guid? smethod_23(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_4, bool_0: true, (JToken)@class))
		{
			if (@class.Value == null)
			{
				return null;
			}
			if (@class.Value is byte[] b)
			{
				return new Guid(b);
			}
			return (!(@class.Value is Guid guid)) ? new Guid(Convert.ToString(@class.Value, CultureInfo.InvariantCulture)) : guid;
		}
		throw new ArgumentException("Can not convert {0} to Guid.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static TimeSpan? smethod_24(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_5, bool_0: true, (JToken)@class))
		{
			if (@class.Value == null)
			{
				return null;
			}
			return (!(@class.Value is TimeSpan timeSpan)) ? Class131.smethod_351(Convert.ToString(@class.Value, CultureInfo.InvariantCulture)) : timeSpan;
		}
		throw new ArgumentException("Can not convert {0} to TimeSpan.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	public static Uri? smethod_25(JToken? jtoken_2)
	{
		if (jtoken_2 == null)
		{
			return null;
		}
		Class179 @class = Class131.smethod_232(jtoken_2);
		if (@class != null && Class131.smethod_357(jtokenType_6, bool_0: true, (JToken)@class))
		{
			if (@class.Value == null)
			{
				return null;
			}
			if (!(@class.Value is Uri result))
			{
				return new Uri(Convert.ToString(@class.Value, CultureInfo.InvariantCulture));
			}
			return result;
		}
		throw new ArgumentException("Can not convert {0} to Uri.".smethod_1(CultureInfo.InvariantCulture, Class131.smethod_620(jtoken_2)));
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_26(sbyte sbyte_0)
	{
		return new Class179(sbyte_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_27(sbyte? nullable_0)
	{
		return new Class179(nullable_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_28(short short_0)
	{
		return new Class179(short_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_29(ushort ushort_0)
	{
		return new Class179(ushort_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_30(short? nullable_0)
	{
		return new Class179(nullable_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_31(ushort? nullable_0)
	{
		return new Class179(nullable_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_32(uint? nullable_0)
	{
		return new Class179(nullable_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_33(ulong? nullable_0)
	{
		return new Class179(nullable_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_34(uint uint_0)
	{
		return new Class179(uint_0);
	}

	[SpecialName]
	[CLSCompliant(false)]
	public static JToken smethod_35(ulong ulong_0)
	{
		return new Class179(ulong_0);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<JToken>)this).GetEnumerator();
	}

	IEnumerator<JToken> IEnumerable<JToken>.GetEnumerator()
	{
		return vmethod_3().System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator();
	}

	internal abstract int vmethod_6();

	public T? method_3<T>()
	{
		return (T)Class131.smethod_757(this, typeof(T));
	}

	public T? method_4<T>(Class33 class33_0)
	{
		return (T)Class131.smethod_416(this, typeof(T), class33_0);
	}

	internal void method_5(Interface1? interface1_0, Class193? class193_0)
	{
		if ((class193_0 == null || class193_0!.enum30_0 == Enum30.const_1) && interface1_0 != null && interface1_0!.imethod_0())
		{
			Class131.smethod_626(this, interface1_0!.LineNumber, interface1_0!.LinePosition);
		}
	}

	bool Interface1.imethod_0()
	{
		return method_7<Class181>() != null;
	}

	public JToken? method_6(string string_0, Class195? class195_0)
	{
		Class212 class212_ = new Class212(string_0);
		JToken jToken = null;
		foreach (JToken item in Class131.smethod_425(this, this, class195_0, class212_))
		{
			if (jToken == null)
			{
				jToken = item;
				continue;
			}
			throw new JsonException("Path returned multiple tokens.");
		}
		return jToken;
	}

	protected virtual DynamicMetaObject vmethod_7(Expression expression_0)
	{
		return new DynamicProxyMetaObject<JToken>(expression_0, this, new Class51<JToken>());
	}

	DynamicMetaObject IDynamicMetaObjectProvider.GetMetaObject(Expression parameter)
	{
		return vmethod_7(parameter);
	}

	object ICloneable.Clone()
	{
		return Class131.smethod_60(this);
	}

	public T? method_7<T>() where T : class
	{
		if (object_0 != null)
		{
			if (!(object_0 is object[] array))
			{
				return object_0 as T;
			}
			foreach (object obj in array)
			{
				if (obj == null)
				{
					break;
				}
				if (obj is T result)
				{
					return result;
				}
			}
		}
		return null;
	}

	public IEnumerable<T> method_8<T>() where T : class
	{
		//yield-return decompiler failed: Method not found
		return new Class185<T>(-2)
		{
			jtoken_0 = this
		};
	}

	public void method_9<T>() where T : class
	{
		if (object_0 == null)
		{
			return;
		}
		if (!(object_0 is object[] array))
		{
			if (object_0 is T)
			{
				object_0 = null;
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
			if (!(obj is T))
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
			object_0 = null;
		}
	}
}
