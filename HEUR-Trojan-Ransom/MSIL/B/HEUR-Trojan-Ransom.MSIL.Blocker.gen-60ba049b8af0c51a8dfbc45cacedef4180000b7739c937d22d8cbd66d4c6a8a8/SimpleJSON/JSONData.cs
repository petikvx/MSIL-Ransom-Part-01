using System.IO;

namespace SimpleJSON;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			string data = default(string);
			while (true)
			{
				int num = -1490857905;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xEC01BAACu) % 4u)
					{
					case 3u:
						data = m_Data;
						num = ((int)num2 * -2145432522) ^ -696892269;
						continue;
					case 1u:
						num = (int)(num2 * 293556250) ^ -2069384836;
						continue;
					case 0u:
						break;
					default:
						return data;
					}
					break;
				}
			}
		}
		set
		{
			m_Data = value;
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 1629042432;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x447BF6F3u) % 4u)
				{
				case 3u:
					num = ((int)num2 * -1491178250) ^ -2032355347;
					continue;
				case 0u:
					m_Data = aData;
					num = ((int)num2 * -500961090) ^ -785689082;
					continue;
				default:
					return;
				case 2u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = -259259598;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCB9BE126u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 2u:
					return;
				}
				break;
				IL_0008:
				AsFloat = aData;
				num = (int)((num2 * 1373323286) ^ 0x1C4850BC);
			}
		}
	}

	public JSONData(double aData)
	{
		while (true)
		{
			int num = -671315344;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFEE3BCC9u) % 4u)
				{
				case 3u:
					AsDouble = aData;
					num = ((int)num2 * -180842043) ^ 0x615229BE;
					continue;
				case 1u:
					num = ((int)num2 * -1353925717) ^ 0xFAD62E9;
					continue;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 2092689608;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C01EF1u) % 5u)
				{
				case 4u:
					AsBool = aData;
					num = ((int)num2 * -1640496205) ^ -1265928121;
					continue;
				case 2u:
					num = (int)(num2 * 1732598769) ^ -1407917601;
					continue;
				case 1u:
					num = (int)((num2 * 400832488) ^ 0x3C897C10);
					continue;
				default:
					return;
				case 3u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public JSONData(int aData)
	{
		AsInt = aData;
	}

	public override string ToString()
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override string ToString(string aPrefix)
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num = 272532788;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x661230B7u) % 37u)
				{
				case 36u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1906355864) ^ -190371725;
					continue;
				case 35u:
					jSONData.AsDouble = AsDouble;
					num = 807179053;
					continue;
				case 34u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -365423106) ^ 0x5670241C;
					continue;
				case 33u:
					num = (int)(num2 * 1532696844) ^ -1018646042;
					continue;
				case 32u:
					num = ((int)num2 * -428523227) ^ 0x4CBA52B8;
					continue;
				case 31u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -696934204) ^ -872441384;
					continue;
				case 30u:
					num = (int)((num2 * 436223873) ^ 0x234623DC);
					continue;
				case 29u:
				{
					int num5;
					int num6;
					if (!flag2)
					{
						num5 = -953473250;
						num6 = -953473250;
					}
					else
					{
						num5 = -1662652772;
						num6 = -1662652772;
					}
					num = num5 ^ ((int)num2 * -1811900733);
					continue;
				}
				case 28u:
					num = ((int)num2 * -1739710290) ^ -23078887;
					continue;
				case 27u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 373891623;
					continue;
				case 26u:
				{
					int num9;
					int num10;
					if (!flag)
					{
						num9 = -1848118608;
						num10 = -1848118608;
					}
					else
					{
						num9 = -1509369071;
						num10 = -1509369071;
					}
					num = num9 ^ ((int)num2 * -1235190666);
					continue;
				}
				case 25u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = 2096984431;
						num8 = 2096984431;
					}
					else
					{
						num7 = 1968379328;
						num8 = 1968379328;
					}
					num = num7 ^ (int)(num2 * 1098876155);
					continue;
				}
				case 24u:
					num = (int)(num2 * 1331527586) ^ -260102031;
					continue;
				case 23u:
					num = (int)(num2 * 134898726) ^ -1109934808;
					continue;
				case 22u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1302270903) ^ 0x569D0015;
					continue;
				case 20u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 621567796) ^ 0x4C457731);
					continue;
				case 19u:
				{
					int num3;
					int num4;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = -1320499088;
						num4 = -1320499088;
					}
					else
					{
						num3 = -1011869463;
						num4 = -1011869463;
					}
					num = num3 ^ ((int)num2 * -2034719883);
					continue;
				}
				case 18u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -1580328637) ^ 0x2E0F73A0;
					continue;
				case 17u:
					jSONData = new JSONData("");
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -1778113824) ^ -1451176911;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = ((int)num2 * -1317378864) ^ -1768043451;
					continue;
				case 15u:
					jSONData.AsBool = AsBool;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 618797134;
					continue;
				case 14u:
					num = ((int)num2 * -374228246) ^ -1841545494;
					continue;
				case 13u:
					num = (int)((num2 * 807028257) ^ 0x48980FD0);
					continue;
				case 11u:
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1275061199) ^ 0x34109227;
					continue;
				case 10u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)(num2 * 736302502) ^ -1434883801;
					continue;
				case 9u:
					num = ((int)num2 * -1170893056) ^ -345702768;
					continue;
				case 8u:
					num = (int)(num2 * 991271685) ^ -1514043383;
					continue;
				case 7u:
					num = ((int)num2 * -877982074) ^ 0x42C17494;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -330041041) ^ 0x151555DF;
					continue;
				case 5u:
					num = ((int)num2 * -165023943) ^ 0xA940814;
					continue;
				case 4u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1159894616) ^ -1011550168;
					continue;
				case 3u:
					jSONData.AsFloat = AsFloat;
					num = 87279469;
					continue;
				case 2u:
					num = (int)(num2 * 1856308307) ^ -2140156938;
					continue;
				case 1u:
					num = ((int)num2 * -285566660) ^ -1413064965;
					continue;
				case 0u:
					num = (int)((num2 * 1214936285) ^ 0x4435619E);
					continue;
				default:
					return;
				case 12u:
					break;
				case 21u:
					return;
				}
				break;
			}
		}
	}

	static string smethod_30(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static bool smethod_31(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static void smethod_32(BinaryWriter binaryWriter_0, byte byte_0)
	{
		binaryWriter_0.Write(byte_0);
	}

	static void smethod_33(BinaryWriter binaryWriter_0, int int_0)
	{
		binaryWriter_0.Write(int_0);
	}

	static void smethod_34(BinaryWriter binaryWriter_0, float float_0)
	{
		binaryWriter_0.Write(float_0);
	}

	static void smethod_35(BinaryWriter binaryWriter_0, double double_0)
	{
		binaryWriter_0.Write(double_0);
	}

	static void smethod_36(BinaryWriter binaryWriter_0, bool bool_0)
	{
		binaryWriter_0.Write(bool_0);
	}

	static void smethod_37(BinaryWriter binaryWriter_0, string string_0)
	{
		binaryWriter_0.Write(string_0);
	}
}
