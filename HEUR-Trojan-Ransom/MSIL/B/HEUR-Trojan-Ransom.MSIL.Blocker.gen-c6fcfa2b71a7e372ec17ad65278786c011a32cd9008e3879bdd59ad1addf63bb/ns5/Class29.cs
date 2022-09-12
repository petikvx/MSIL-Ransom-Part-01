using System;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using ns11;
using ns12;
using ns13;
using ns14;
using ns3;
using ns6;
using ns7;
using ns8;

namespace ns5;

internal class Class29 : Class28, Interface1
{
	private const char char_1 = '\ufffd';

	private const int int_0 = 380;

	private const int int_1 = 1073741823;

	internal readonly TextReader textReader_0;

	internal char[]? char_2;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal int int_5;

	internal bool bool_3;

	internal Struct3 struct3_0;

	internal Struct4 struct4_0;

	internal Interface0<char>? interface0_0;

	[CompilerGenerated]
	private Class5? class5_0;

	public Class5? PropertyNameTable
	{
		[CompilerGenerated]
		get
		{
			return class5_0;
		}
		[CompilerGenerated]
		set
		{
			class5_0 = value;
		}
	}

	public Interface0<char>? ArrayPool
	{
		get
		{
			return interface0_0;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			interface0_0 = value;
		}
	}

	public int LineNumber
	{
		get
		{
			if (state_0 == State.Start && LinePosition == 0 && TokenType != JsonToken.Comment)
			{
				return 0;
			}
			return int_5;
		}
	}

	public int LinePosition => int_3 - int_4;

	public Class29(TextReader textReader_1)
	{
		if (textReader_1 == null)
		{
			throw new ArgumentNullException("reader");
		}
		textReader_0 = textReader_1;
		int_5 = 1;
	}

	public override bool vmethod_0()
	{
		Class131.smethod_574(this);
		do
		{
			switch (state_0)
			{
			case State.PostValue:
				break;
			case State.ObjectStart:
			case State.Object:
				return Class131.smethod_570(this);
			case State.Start:
			case State.Property:
			case State.ArrayStart:
			case State.Array:
			case State.ConstructorStart:
			case State.Constructor:
				return Class131.smethod_657(this);
			default:
				throw Class131.smethod_303((Class28)this, "Unexpected state: {0}.".smethod_1(CultureInfo.InvariantCulture, state_0));
			case State.Finished:
				if (Class131.smethod_777(this, 0, bool_0: false))
				{
					Class131.smethod_595(this);
					if (bool_3)
					{
						Class131.smethod_668((Class28)this, JsonToken.None);
						return false;
					}
					if (char_2[int_3] == '/')
					{
						Class131.smethod_109(this, bool_0: true);
						return true;
					}
					throw Class131.smethod_303((Class28)this, "Additional text encountered after finished reading JSON content: {0}.".smethod_1(CultureInfo.InvariantCulture, char_2[int_3]));
				}
				Class131.smethod_668((Class28)this, JsonToken.None);
				return false;
			}
		}
		while (!Class131.smethod_158(this, bool_0: false));
		return true;
	}

	public override int? vmethod_1()
	{
		return (int?)method_5(Enum8.const_1);
	}

	public override DateTime? vmethod_7()
	{
		return (DateTime?)method_3(Enum8.const_6);
	}

	public override string? vmethod_2()
	{
		return (string)method_3(Enum8.const_4);
	}

	public override byte[]? vmethod_3()
	{
		Class131.smethod_574(this);
		bool flag = false;
		switch (state_0)
		{
		case State.PostValue:
			if (Class131.smethod_158(this, bool_0: true))
			{
				return null;
			}
			goto case State.Start;
		case State.Start:
		case State.Property:
		case State.ArrayStart:
		case State.Array:
		case State.ConstructorStart:
		case State.Constructor:
			while (true)
			{
				char c = char_2[int_3];
				switch (c)
				{
				case '/':
					Class131.smethod_109(this, bool_0: false);
					break;
				case ',':
					Class131.smethod_592(this);
					break;
				default:
					int_3++;
					if (!char.IsWhiteSpace(c))
					{
						throw Class131.smethod_645(this, c);
					}
					break;
				case '{':
					int_3++;
					Class131.smethod_668((Class28)this, JsonToken.StartObject);
					Class131.smethod_533((Class28)this);
					flag = true;
					break;
				case '\n':
					Class131.smethod_771(this);
					break;
				case '\r':
					Class131.smethod_550(this, bool_0: false);
					break;
				case '\0':
					if (Class131.smethod_746(this))
					{
						Class131.smethod_344((Class28)this, JsonToken.None, (object)null, bool_0: false);
						return null;
					}
					break;
				case '\t':
				case ' ':
					int_3++;
					break;
				case '"':
				case '\'':
				{
					Class131.smethod_481(this, c, Enum8.const_3);
					byte[] result = (byte[])Value;
					if (flag)
					{
						Class131.smethod_269((Class28)this);
						if (TokenType != JsonToken.EndObject)
						{
							throw Class131.smethod_303((Class28)this, "Error reading bytes. Unexpected token: {0}.".smethod_1(CultureInfo.InvariantCulture, TokenType));
						}
						Class131.smethod_344((Class28)this, JsonToken.Bytes, (object)result, bool_0: false);
					}
					return result;
				}
				case '[':
					int_3++;
					Class131.smethod_668((Class28)this, JsonToken.StartArray);
					return method_0();
				case 'n':
					Class131.smethod_394(this);
					return null;
				case ']':
					int_3++;
					if (state_0 != State.Array && state_0 != State.ArrayStart && state_0 != State.PostValue)
					{
						throw Class131.smethod_645(this, c);
					}
					Class131.smethod_668((Class28)this, JsonToken.EndArray);
					return null;
				}
			}
		default:
			throw Class131.smethod_303((Class28)this, "Unexpected state: {0}.".smethod_1(CultureInfo.InvariantCulture, state_0));
		case State.Finished:
			Class131.smethod_233(this);
			return null;
		}
	}

	private object? method_3(Enum8 enum8_0)
	{
		Class131.smethod_574(this);
		switch (state_0)
		{
		case State.PostValue:
			if (Class131.smethod_158(this, bool_0: true))
			{
				return null;
			}
			goto case State.Start;
		case State.Start:
		case State.Property:
		case State.ArrayStart:
		case State.Array:
		case State.ConstructorStart:
		case State.Constructor:
			while (true)
			{
				char c = char_2[int_3];
				switch (c)
				{
				default:
					int_3++;
					if (!char.IsWhiteSpace(c))
					{
						throw Class131.smethod_645(this, c);
					}
					break;
				case '\n':
					Class131.smethod_771(this);
					break;
				case '\r':
					Class131.smethod_550(this, bool_0: false);
					break;
				case '\0':
					if (Class131.smethod_746(this))
					{
						Class131.smethod_344((Class28)this, JsonToken.None, (object)null, bool_0: false);
						return null;
					}
					break;
				case '\t':
				case ' ':
					int_3++;
					break;
				case ',':
					Class131.smethod_592(this);
					break;
				case '/':
					Class131.smethod_109(this, bool_0: false);
					break;
				case 'I':
					return Class131.smethod_555(this, enum8_0);
				case '"':
				case '\'':
					Class131.smethod_481(this, c, enum8_0);
					return method_4(enum8_0);
				case '-':
					if (Class131.smethod_777(this, 1, bool_0: true) && char_2[int_3 + 1] == 'I')
					{
						return Class131.smethod_414(this, enum8_0);
					}
					Class131.smethod_325(this, enum8_0);
					return Value;
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
					if (enum8_0 != Enum8.const_4)
					{
						int_3++;
						throw Class131.smethod_645(this, c);
					}
					Class131.smethod_325(this, Enum8.const_4);
					return Value;
				case ']':
					int_3++;
					if (state_0 != State.Array && state_0 != State.ArrayStart && state_0 != State.PostValue)
					{
						throw Class131.smethod_645(this, c);
					}
					Class131.smethod_668((Class28)this, JsonToken.EndArray);
					return null;
				case 'N':
					return Class131.smethod_494(this, enum8_0);
				case 'n':
					Class131.smethod_394(this);
					return null;
				case 'f':
				case 't':
				{
					if (enum8_0 != Enum8.const_4)
					{
						int_3++;
						throw Class131.smethod_645(this, c);
					}
					string result = ((c == 't') ? Class7.string_0 : Class7.string_1);
					if (!Class131.smethod_502(result, this))
					{
						throw Class131.smethod_645(this, char_2[int_3]);
					}
					Class131.smethod_654((Class28)this, JsonToken.String, (object)result);
					return result;
				}
				}
			}
		default:
			throw Class131.smethod_303((Class28)this, "Unexpected state: {0}.".smethod_1(CultureInfo.InvariantCulture, state_0));
		case State.Finished:
			Class131.smethod_233(this);
			return null;
		}
	}

	private object? method_4(Enum8 enum8_0)
	{
		switch (enum8_0)
		{
		case Enum8.const_3:
		case Enum8.const_4:
			return Value;
		default:
			throw new ArgumentOutOfRangeException("readType");
		case Enum8.const_6:
			if (Value is DateTime dateTime)
			{
				return dateTime;
			}
			return Class131.smethod_103((Class28)this, (string)Value);
		case Enum8.const_7:
			if (Value is DateTimeOffset dateTimeOffset)
			{
				return dateTimeOffset;
			}
			return Class131.smethod_457((Class28)this, (string)Value);
		}
	}

	public override bool? vmethod_5()
	{
		Class131.smethod_574(this);
		switch (state_0)
		{
		case State.PostValue:
			if (Class131.smethod_158(this, bool_0: true))
			{
				return null;
			}
			goto case State.Start;
		case State.Start:
		case State.Property:
		case State.ArrayStart:
		case State.Array:
		case State.ConstructorStart:
		case State.Constructor:
			while (true)
			{
				char c = char_2[int_3];
				switch (c)
				{
				default:
					int_3++;
					if (!char.IsWhiteSpace(c))
					{
						throw Class131.smethod_645(this, c);
					}
					break;
				case ',':
					Class131.smethod_592(this);
					break;
				case '/':
					Class131.smethod_109(this, bool_0: false);
					break;
				case '\t':
				case ' ':
					int_3++;
					break;
				case '\n':
					Class131.smethod_771(this);
					break;
				case '\r':
					Class131.smethod_550(this, bool_0: false);
					break;
				case '\0':
					if (Class131.smethod_746(this))
					{
						Class131.smethod_344((Class28)this, JsonToken.None, (object)null, bool_0: false);
						return null;
					}
					break;
				case '"':
				case '\'':
					Class131.smethod_481(this, c, Enum8.const_0);
					return Class131.smethod_741((Class28)this, struct4_0.ToString());
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
				{
					Class131.smethod_325(this, Enum8.const_0);
					bool flag2 = ((!(Value is BigInteger bigInteger)) ? Convert.ToBoolean(Value, CultureInfo.InvariantCulture) : (bigInteger != 0L));
					Class131.smethod_344((Class28)this, JsonToken.Boolean, (object)flag2, bool_0: false);
					return flag2;
				}
				case ']':
					int_3++;
					if (state_0 != State.Array && state_0 != State.ArrayStart && state_0 != State.PostValue)
					{
						throw Class131.smethod_645(this, c);
					}
					Class131.smethod_668((Class28)this, JsonToken.EndArray);
					return null;
				case 'f':
				case 't':
				{
					bool flag;
					string text = ((flag = c == 't') ? Class7.string_0 : Class7.string_1);
					if (!Class131.smethod_502(text, this))
					{
						throw Class131.smethod_645(this, char_2[int_3]);
					}
					Class131.smethod_654((Class28)this, JsonToken.Boolean, (object)flag);
					return flag;
				}
				case 'n':
					Class131.smethod_394(this);
					return null;
				}
			}
		default:
			throw Class131.smethod_303((Class28)this, "Unexpected state: {0}.".smethod_1(CultureInfo.InvariantCulture, state_0));
		case State.Finished:
			Class131.smethod_233(this);
			return null;
		}
	}

	private object? method_5(Enum8 enum8_0)
	{
		Class131.smethod_574(this);
		switch (state_0)
		{
		case State.PostValue:
			if (Class131.smethod_158(this, bool_0: true))
			{
				return null;
			}
			goto case State.Start;
		case State.Start:
		case State.Property:
		case State.ArrayStart:
		case State.Array:
		case State.ConstructorStart:
		case State.Constructor:
			while (true)
			{
				char c = char_2[int_3];
				switch (c)
				{
				default:
					int_3++;
					if (!char.IsWhiteSpace(c))
					{
						throw Class131.smethod_645(this, c);
					}
					break;
				case ',':
					Class131.smethod_592(this);
					break;
				case '/':
					Class131.smethod_109(this, bool_0: false);
					break;
				case '\t':
				case ' ':
					int_3++;
					break;
				case '\n':
					Class131.smethod_771(this);
					break;
				case '\r':
					Class131.smethod_550(this, bool_0: false);
					break;
				case '\0':
					if (Class131.smethod_746(this))
					{
						Class131.smethod_344((Class28)this, JsonToken.None, (object)null, bool_0: false);
						return null;
					}
					break;
				case '"':
				case '\'':
					Class131.smethod_481(this, c, enum8_0);
					return method_6(enum8_0);
				case '-':
					if (Class131.smethod_777(this, 1, bool_0: true) && char_2[int_3 + 1] == 'I')
					{
						return Class131.smethod_414(this, enum8_0);
					}
					Class131.smethod_325(this, enum8_0);
					return Value;
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
					Class131.smethod_325(this, enum8_0);
					return Value;
				case 'N':
					return Class131.smethod_494(this, enum8_0);
				case 'I':
					return Class131.smethod_555(this, enum8_0);
				case 'n':
					Class131.smethod_394(this);
					return null;
				case ']':
					int_3++;
					if (state_0 != State.Array && state_0 != State.ArrayStart && state_0 != State.PostValue)
					{
						throw Class131.smethod_645(this, c);
					}
					Class131.smethod_668((Class28)this, JsonToken.EndArray);
					return null;
				}
			}
		default:
			throw Class131.smethod_303((Class28)this, "Unexpected state: {0}.".smethod_1(CultureInfo.InvariantCulture, state_0));
		case State.Finished:
			Class131.smethod_233(this);
			return null;
		}
	}

	private object? method_6(Enum8 enum8_0)
	{
		return enum8_0 switch
		{
			Enum8.const_8 => Class131.smethod_459((Class28)this, struct4_0.ToString()), 
			Enum8.const_5 => Class131.smethod_335((Class28)this, struct4_0.ToString()), 
			Enum8.const_1 => Class131.smethod_364((Class28)this, struct4_0.ToString()), 
			_ => throw new ArgumentOutOfRangeException("readType"), 
		};
	}

	public override DateTimeOffset? vmethod_8()
	{
		return (DateTimeOffset?)method_3(Enum8.const_7);
	}

	public override decimal? vmethod_6()
	{
		return (decimal?)method_5(Enum8.const_5);
	}

	public override double? vmethod_4()
	{
		return (double?)method_5(Enum8.const_8);
	}

	internal void method_7(char char_3)
	{
		int num = int_3;
		int num2 = int_3;
		int num3 = int_3;
		struct3_0.Position = 0;
		while (true)
		{
			switch (char_2[num++])
			{
			case '\\':
				int_3 = num;
				if (Class131.smethod_777(this, 0, bool_0: true))
				{
					int num4 = num - 1;
					char c = char_2[num];
					num++;
					char c2;
					switch (c)
					{
					case '\\':
						c2 = '\\';
						goto IL_01f3;
					case '"':
					case '\'':
					case '/':
						c2 = c;
						goto IL_01f3;
					case 'f':
						c2 = '\f';
						goto IL_01f3;
					case 'b':
						c2 = '\b';
						goto IL_01f3;
					case 'r':
						c2 = '\r';
						goto IL_01f3;
					case 't':
						c2 = '\t';
						goto IL_01f3;
					case 'u':
						int_3 = num;
						c2 = Class131.smethod_583(this);
						if (Class131.smethod_354(c2))
						{
							c2 = '\ufffd';
						}
						else if (Class131.smethod_141(c2))
						{
							bool flag;
							do
							{
								flag = false;
								if (!Class131.smethod_777(this, 2, bool_0: true) || char_2[int_3] != '\\' || char_2[int_3 + 1] != 'u')
								{
									c2 = '\ufffd';
									continue;
								}
								char c3 = c2;
								int_3 += 2;
								c2 = Class131.smethod_583(this);
								if (!Class131.smethod_354(c2))
								{
									if (Class131.smethod_141(c2))
									{
										c3 = '\ufffd';
										flag = true;
									}
									else
									{
										c3 = '\ufffd';
									}
								}
								Class131.smethod_44(this);
								Class131.smethod_669(c3, this, num3, num4);
								num3 = int_3;
							}
							while (flag);
						}
						num = int_3;
						goto IL_01f3;
					case 'n':
						c2 = '\n';
						goto IL_01f3;
					default:
						{
							int_3 = num;
							throw Class131.smethod_303((Class28)this, "Bad JSON escape sequence: {0}.".smethod_1(CultureInfo.InvariantCulture, "\\" + c));
						}
						IL_01f3:
						Class131.smethod_44(this);
						Class131.smethod_669(c2, this, num3, num4);
						num3 = num;
						break;
					}
					break;
				}
				throw Class131.smethod_303((Class28)this, "Unterminated string. Expected delimiter: {0}.".smethod_1(CultureInfo.InvariantCulture, char_3));
			case '"':
			case '\'':
				if (char_2[num - 1] == char_3)
				{
					Class131.smethod_373(num - 1, num2, num3, this);
					return;
				}
				break;
			case '\r':
				int_3 = num - 1;
				Class131.smethod_550(this, bool_0: true);
				num = int_3;
				break;
			case '\n':
				int_3 = num - 1;
				Class131.smethod_771(this);
				num = int_3;
				break;
			case '\0':
				if (int_2 == num - 1)
				{
					num--;
					if (Class131.smethod_391(bool_0: true, this) == 0)
					{
						int_3 = num;
						throw Class131.smethod_303((Class28)this, "Unterminated string. Expected delimiter: {0}.".smethod_1(CultureInfo.InvariantCulture, char_3));
					}
				}
				break;
			}
		}
	}

	public override void vmethod_10()
	{
		base.vmethod_10();
		if (char_2 != null)
		{
			Class131.smethod_653(interface0_0, char_2);
			char_2 = null;
		}
		if (base.CloseInput)
		{
			textReader_0?.Close();
		}
		struct3_0.method_2(interface0_0);
	}

	public bool imethod_0()
	{
		return true;
	}
}
