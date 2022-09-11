using System;
using System.Globalization;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;
using ns26;

namespace ns11;

internal sealed class Class123
{
	[NonSerialized]
	internal static GetString getString_0;

	public static bool smethod_0(string string_0)
	{
		string text = string_0.ToLower(CultureInfo.InvariantCulture);
		uint num = Class192.smethod_0(text);
		if (num <= 2515107422u)
		{
			if (num <= 1761125480)
			{
				if (num != 520654156)
				{
					if (num != 750634308)
					{
						if (num != 1761125480 || !(text == getString_0(107359472)))
						{
							goto IL_025e;
						}
					}
					else if (!(text == getString_0(107359957)))
					{
						goto IL_025e;
					}
				}
				else if (!(text == getString_0(107406399)))
				{
					goto IL_025e;
				}
			}
			else if (num <= 2322048458u)
			{
				if (num != 2174562837u)
				{
					if (num != 2322048458u || !(text == getString_0(107359931)))
					{
						goto IL_025e;
					}
				}
				else if (!(text == getString_0(107359886)))
				{
					goto IL_025e;
				}
			}
			else if (num != 2371953175u)
			{
				if (num != 2515107422u || !(text == getString_0(107359477)))
				{
					goto IL_025e;
				}
			}
			else if (!(text == getString_0(107359912)))
			{
				goto IL_025e;
			}
		}
		else if (num <= 3019201529u)
		{
			if (num != 2699759368u)
			{
				if (num != 2797886853u)
				{
					if (num != 3019201529u || !(text == getString_0(107359934)))
					{
						goto IL_025e;
					}
				}
				else if (!(text == getString_0(107359872)))
				{
					goto IL_025e;
				}
			}
			else if (!(text == getString_0(107359881)))
			{
				goto IL_025e;
			}
		}
		else if (num <= 3260643795u)
		{
			if (num != 3218261061u)
			{
				if (num != 3260643795u || !(text == getString_0(107359939)))
				{
					goto IL_025e;
				}
			}
			else if (!(text == getString_0(107406364)))
			{
				goto IL_025e;
			}
		}
		else if (num != 3604983901u)
		{
			if (num != 3687697785u || !(text == getString_0(107359895)))
			{
				goto IL_025e;
			}
		}
		else if (!(text == getString_0(107359922)))
		{
			goto IL_025e;
		}
		return true;
		IL_025e:
		return false;
	}

	public static bool smethod_1(string string_0)
	{
		string text = string_0.ToLower(CultureInfo.InvariantCulture);
		uint num = Class192.smethod_0(text);
		if (num <= 2171383808u)
		{
			if (num <= 1539863742)
			{
				if (num != 233322405)
				{
					if (num == 1539863742 && text == getString_0(107359799))
					{
						goto IL_01a3;
					}
				}
				else if (text == getString_0(107359825))
				{
					goto IL_01a3;
				}
			}
			else if (num != 2071828372)
			{
				if (num != 2164872348u)
				{
					if (num == 2171383808u && text == getString_0(107359754))
					{
						goto IL_01a3;
					}
				}
				else if (text == getString_0(107359806))
				{
					goto IL_01a3;
				}
			}
			else if (text == getString_0(107359819))
			{
				goto IL_01a3;
			}
		}
		else if (num <= 3185987134u)
		{
			if (num != 2823553821u)
			{
				if (num == 3185987134u && text == getString_0(107359860))
				{
					goto IL_01a3;
				}
			}
			else if (text == getString_0(107406352))
			{
				goto IL_01a3;
			}
		}
		else if (num != 3324446467u)
		{
			if (num != 3761451113u)
			{
				if (num == 4163743794u && text == getString_0(107359841))
				{
					goto IL_01a3;
				}
			}
			else if (text == getString_0(107359776))
			{
				goto IL_01a3;
			}
		}
		else if (text == getString_0(107359745))
		{
			goto IL_01a3;
		}
		return false;
		IL_01a3:
		return true;
	}

	public static bool smethod_2(string string_0)
	{
		string text = Class135.smethod_1(string_0);
		if (!(text == getString_0(107359472)) && !(text == getString_0(107406399)) && !(text == getString_0(107359939)) && !(text == getString_0(107359922)))
		{
			return false;
		}
		return true;
	}

	public static MySqlDbType smethod_3(string string_0, bool bool_0, bool bool_1, Class139 class139_0)
	{
		string text = Class135.smethod_0(string_0);
		uint num = Class192.smethod_0(text);
		if (num <= 2163098750u)
		{
			if (num <= 1224835811)
			{
				if (num <= 713592192)
				{
					switch (num)
					{
					case 249928074u:
						if (text == getString_0(107408457))
						{
							if (!bool_0)
							{
								return MySqlDbType.Int64;
							}
							return MySqlDbType.UInt64;
						}
						break;
					case 147199461u:
						if (text == getString_0(107359081))
						{
							return MySqlDbType.MediumText;
						}
						break;
					case 713592192u:
						if (text == getString_0(107359178))
						{
							return MySqlDbType.Enum;
						}
						break;
					case 582941476u:
						if (text == getString_0(107407623))
						{
							return MySqlDbType.Time;
						}
						break;
					}
				}
				else if (num <= 1053076803)
				{
					switch (num)
					{
					case 1053076803u:
						if (text == getString_0(107407614))
						{
							return MySqlDbType.Timestamp;
						}
						break;
					case 1043610937u:
						if (text == getString_0(107359142))
						{
							return MySqlDbType.UInt64;
						}
						break;
					}
				}
				else if (num != 1192164083)
				{
					if (num != 1219467820)
					{
						if (num == 1224835811 && text == getString_0(107359727))
						{
							return MySqlDbType.Set;
						}
					}
					else if (text == getString_0(107408421))
					{
						goto IL_04e7;
					}
				}
				else if (text == getString_0(107359718))
				{
					goto IL_04e7;
				}
			}
			else if (num <= 1592469244)
			{
				if (num <= 1299628970)
				{
					switch (num)
					{
					case 1299628970u:
						if (text == getString_0(107359133))
						{
							return MySqlDbType.Blob;
						}
						break;
					case 1298786580u:
						if (text == getString_0(107359111))
						{
							return MySqlDbType.LongText;
						}
						break;
					}
				}
				else if (num != 1580860057)
				{
					if (num == 1592469244 && text == getString_0(107359038))
					{
						return MySqlDbType.Binary;
					}
				}
				else if (text == getString_0(107359713))
				{
					goto IL_04e7;
				}
			}
			else
			{
				switch (num)
				{
				case 1644413244u:
					if (text == getString_0(107359156))
					{
						return MySqlDbType.LongBlob;
					}
					break;
				case 1603809012u:
					if (text == getString_0(107359096))
					{
						return MySqlDbType.TinyBlob;
					}
					break;
				case 2163098750u:
					if (text == getString_0(107407588))
					{
						return MySqlDbType.Text;
					}
					break;
				case 2021473490u:
					if (text == getString_0(107359763))
					{
						return MySqlDbType.VarChar;
					}
					break;
				case 1880965479u:
					if (text == getString_0(107359061))
					{
						return MySqlDbType.VarBinary;
					}
					break;
				}
			}
		}
		else if (num <= 2778687069u)
		{
			if (num <= 2316881829u)
			{
				if (num <= 2282454687u)
				{
					if (num != 2267114325u)
					{
						if (num == 2282454687u && text == getString_0(107359187))
						{
							goto IL_0566;
						}
					}
					else if (text == getString_0(107408528))
					{
						if (!bool_0)
						{
							return MySqlDbType.Int16;
						}
						return MySqlDbType.UInt16;
					}
				}
				else
				{
					switch (num)
					{
					case 2316881829u:
						if (text == getString_0(107408471))
						{
							return MySqlDbType.Float;
						}
						break;
					case 2299337380u:
						if (text == getString_0(107408509))
						{
							if (!bool_0)
							{
								return MySqlDbType.Byte;
							}
							return MySqlDbType.UByte;
						}
						break;
					}
				}
			}
			else if (num <= 2472002000u)
			{
				if (num != 2367501349u)
				{
					if (num == 2472002000u && text == getString_0(107407633))
					{
						return MySqlDbType.DateTime;
					}
				}
				else if (text == getString_0(107408502))
				{
					goto IL_05fa;
				}
			}
			else if (num != 2553320456u)
			{
				switch (num)
				{
				case 2778687069u:
					if (text == getString_0(107359740))
					{
						return MySqlDbType.String;
					}
					break;
				case 2585027932u:
					if (text == getString_0(107359736))
					{
						return MySqlDbType.Year;
					}
					break;
				}
			}
			else if (text == getString_0(107408440))
			{
				goto IL_04e7;
			}
		}
		else if (num <= 3495763831u)
		{
			if (num <= 3221746841u)
			{
				if (num != 2991499325u)
				{
					if (num == 3221746841u && text == getString_0(107407664))
					{
						return MySqlDbType.Date;
					}
				}
				else if (text == getString_0(107359164))
				{
					goto IL_0566;
				}
			}
			else
			{
				switch (num)
				{
				case 3495763831u:
					if (text == getString_0(107408483))
					{
						if (!bool_0)
						{
							return MySqlDbType.Int24;
						}
						return MySqlDbType.UInt24;
					}
					break;
				case 3405379420u:
					if (text == getString_0(107359051))
					{
						return MySqlDbType.TinyText;
					}
					break;
				}
			}
		}
		else if (num <= 3636696446u)
		{
			if (num != 3560013981u)
			{
				if (num == 3636696446u && text == getString_0(107408514))
				{
					goto IL_05fa;
				}
			}
			else if (text == getString_0(107408448))
			{
				if (!bool_1)
				{
					return MySqlDbType.Double;
				}
				return MySqlDbType.Float;
			}
		}
		else
		{
			switch (num)
			{
			case 3850499664u:
				if (text == getString_0(107359169))
				{
					return MySqlDbType.Bit;
				}
				break;
			case 3751281736u:
				if (text == getString_0(107408462))
				{
					return MySqlDbType.Double;
				}
				break;
			case 3691676285u:
				if (text == getString_0(107359130))
				{
					return MySqlDbType.MediumBlob;
				}
				break;
			}
		}
		throw new MySqlException(getString_0(107359016));
		IL_04e7:
		if (class139_0.class143_0.Version.method_0(5, 0, 3))
		{
			return MySqlDbType.NewDecimal;
		}
		return MySqlDbType.Decimal;
		IL_05fa:
		if (!bool_0)
		{
			return MySqlDbType.Int32;
		}
		return MySqlDbType.UInt32;
		IL_0566:
		return MySqlDbType.Byte;
	}

	static Class123()
	{
		Strings.CreateGetStringDelegate(typeof(Class123));
	}
}
