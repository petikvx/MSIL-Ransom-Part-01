using System.IO;

namespace SimpleJSON;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			return m_Data;
		}
		set
		{
			while (true)
			{
				int num = -1818778483;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xECF2ED7Du) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 2u:
						break;
					case 0u:
						return;
					}
					break;
					IL_0003:
					m_Data = value;
					num = (int)(num2 * 1990956070) ^ -1774947140;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		m_Data = aData;
	}

	public JSONData(float aData)
	{
		AsFloat = aData;
	}

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = 1618362196;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x42951F03u) % 4u)
				{
				case 3u:
					num = (int)(num2 * 32431941) ^ -1597874660;
					continue;
				case 0u:
					AsBool = aData;
					num = (int)(num2 * 1462823702) ^ -571503178;
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

	public JSONData(int aData)
	{
		while (true)
		{
			int num = 147015985;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A8D7FA2u) % 5u)
				{
				case 2u:
					num = (int)((num2 * 534468116) ^ 0x607818D4);
					continue;
				case 1u:
					num = ((int)num2 * -427001780) ^ 0x4627CB85;
					continue;
				case 0u:
					AsInt = aData;
					num = (int)((num2 * 1941653231) ^ 0x1B3AC04D);
					continue;
				default:
					return;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = -1539472553;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF4A85F2Au) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = ((int)num2 * -116957036) ^ -85589630;
					continue;
				case 0u:
					num = (int)(num2 * 429151503) ^ -894178603;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		return JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		while (true)
		{
			int num = -1768987395;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C3690F7u) % 34u)
				{
				case 33u:
					num = (int)((num2 * 1952816477) ^ 0x14E097F8);
					continue;
				case 32u:
					num = (int)(num2 * 1550533969) ^ -240393566;
					continue;
				case 31u:
					jSONData.AsFloat = AsFloat;
					num = -1376738292;
					continue;
				case 30u:
					num = (int)((num2 * 324922234) ^ 0x5E813E75);
					continue;
				case 29u:
					num = ((int)num2 * -1639969745) ^ 0xF2A64D0;
					continue;
				case 28u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -1512479687) ^ 0x43D6CC4;
					continue;
				case 27u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -131591319) ^ -2015641784;
					continue;
				case 26u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -181273014) ^ -1760583570;
					continue;
				case 25u:
					num = ((int)num2 * -1245574638) ^ 0x5C1FC7F5;
					continue;
				case 24u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -2015509540) ^ 0x4D3852BE;
					continue;
				case 23u:
					num = (int)(num2 * 2141766795) ^ -1573627737;
					continue;
				case 22u:
					num = ((int)num2 * -2127371144) ^ -1509089775;
					continue;
				case 21u:
				{
					int num9;
					int num10;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num9 = -1370979185;
						num10 = -1370979185;
					}
					else
					{
						num9 = -2037060791;
						num10 = -2037060791;
					}
					num = num9 ^ (int)(num2 * 1058201088);
					continue;
				}
				case 20u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)(num2 * 722236049) ^ -1318566756;
					continue;
				case 19u:
					JSONData.smethod_37(aWriter, m_Data);
					num = ((int)num2 * -1359709593) ^ -1759130237;
					continue;
				case 17u:
					num = (int)(num2 * 83914363) ^ -910767012;
					continue;
				case 16u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 162374596) ^ -760330229;
					continue;
				case 15u:
				{
					int num7;
					int num8;
					if (!flag)
					{
						num7 = 1891724096;
						num8 = 1891724096;
					}
					else
					{
						num7 = 2081762834;
						num8 = 2081762834;
					}
					num = num7 ^ ((int)num2 * -1180244447);
					continue;
				}
				case 14u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1047437590) ^ 0x7D7AAD24;
					continue;
				case 13u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = ((int)num2 * -965294951) ^ -969631390;
					continue;
				case 12u:
					jSONData.AsBool = AsBool;
					num = -1111872616;
					continue;
				case 11u:
					num = (int)(num2 * 1919256400) ^ -601601485;
					continue;
				case 10u:
					num = ((int)num2 * -1318584553) ^ -643819943;
					continue;
				case 8u:
				{
					int num5;
					int num6;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num5 = 818574988;
						num6 = 818574988;
					}
					else
					{
						num5 = 1179486973;
						num6 = 1179486973;
					}
					num = num5 ^ (int)(num2 * 1340737738);
					continue;
				}
				case 7u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 877317837;
						num4 = 877317837;
					}
					else
					{
						num3 = 1244293386;
						num4 = 1244293386;
					}
					num = num3 ^ ((int)num2 * -41888413);
					continue;
				}
				case 6u:
					jSONData = new JSONData("");
					num = ((int)num2 * -579788557) ^ 0x44C3F7BA;
					continue;
				case 5u:
					jSONData.AsInt = AsInt;
					num = ((int)num2 * -144374274) ^ 0x2AB6117D;
					continue;
				case 4u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = ((int)num2 * -970080978) ^ 0x2F892440;
					continue;
				case 3u:
					num = ((int)num2 * -867791809) ^ 0x21F1C9B8;
					continue;
				case 2u:
					jSONData.AsDouble = AsDouble;
					num = -131951180;
					continue;
				case 1u:
					num = ((int)num2 * -616980616) ^ -284135747;
					continue;
				case 0u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = -154089778;
					continue;
				default:
					return;
				case 9u:
					break;
				case 18u:
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
