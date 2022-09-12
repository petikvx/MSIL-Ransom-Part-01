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
				int num = 751439604;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2B02851Fu) % 3u)
					{
					case 2u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 1u:
						return;
					}
					break;
					IL_0003:
					m_Data = value;
					num = (int)((num2 * 757034779) ^ 0x15B1D59B);
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = 1841728087;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1A20A285u) % 3u)
				{
				case 2u:
					goto IL_0008;
				case 0u:
					break;
				default:
					m_Data = aData;
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -2012268192) ^ 0x1D7D221;
			}
		}
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 1553104818;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E27E224u) % 5u)
				{
				case 2u:
					num = ((int)num2 * -1344187622) ^ -672444161;
					continue;
				case 1u:
					num = ((int)num2 * -1528246860) ^ -1716757742;
					continue;
				case 0u:
					AsFloat = aData;
					num = (int)(num2 * 177888936) ^ -608326654;
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

	public JSONData(double aData)
	{
		while (true)
		{
			int num = -668712923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6BA0643u) % 5u)
				{
				case 4u:
					AsDouble = aData;
					num = ((int)num2 * -776239406) ^ 0x5A347E9;
					continue;
				case 2u:
					num = ((int)num2 * -1462978123) ^ 0x568B5EE2;
					continue;
				case 0u:
					num = ((int)num2 * -1500403432) ^ 0x69BD05A9;
					continue;
				default:
					return;
				case 3u:
					break;
				case 1u:
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
			int num = 1487008793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3577C63u) % 4u)
				{
				case 2u:
					num = (int)((num2 * 452334131) ^ 0x5C8A5E20);
					continue;
				case 1u:
					AsBool = aData;
					num = (int)(num2 * 134665743) ^ -306779065;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
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
			int num = -2007001834;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFF9297A9u) % 6u)
				{
				case 5u:
					num = ((int)num2 * -866871725) ^ -1140919318;
					continue;
				case 2u:
					AsInt = aData;
					num = (int)((num2 * 429633659) ^ 0x50B7373B);
					continue;
				case 1u:
					num = ((int)num2 * -886005594) ^ 0x3D43A360;
					continue;
				case 0u:
					num = (int)((num2 * 83366557) ^ 0x191D424E);
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
			int num = -1695619444;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x993EC43Cu) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = (int)(num2 * 484830605) ^ -1974095234;
			}
		}
	}

	public override string ToString(string aPrefix)
	{
		string result = default(string);
		while (true)
		{
			int num = -52043820;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96A2FF1Au) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
				num = ((int)num2 * -71021414) ^ -720019432;
			}
		}
	}

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = default(JSONData);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 41661381;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31B8BCB1u) % 31u)
				{
				case 30u:
					num = ((int)num2 * -697370500) ^ -448362705;
					continue;
				case 29u:
					jSONData.AsDouble = AsDouble;
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = 242523798;
					continue;
				case 28u:
					JSONData.smethod_36(aWriter, AsBool);
					num = (int)((num2 * 1671189981) ^ 0x75644659);
					continue;
				case 27u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 2146227324;
					continue;
				case 26u:
					jSONData.AsFloat = AsFloat;
					num = 392204759;
					continue;
				case 25u:
					num = ((int)num2 * -1570899356) ^ 0x3FE10C77;
					continue;
				case 24u:
					JSONData.smethod_32(aWriter, (byte)6);
					num = (int)(num2 * 1056479670) ^ -1644816449;
					continue;
				case 23u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = (int)(num2 * 1046677719) ^ -180472372;
					continue;
				case 22u:
				{
					int num5;
					int num6;
					if (!flag)
					{
						num5 = 1284708326;
						num6 = 1284708326;
					}
					else
					{
						num5 = 2113625419;
						num6 = 2113625419;
					}
					num = num5 ^ ((int)num2 * -265952392);
					continue;
				}
				case 21u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)((num2 * 1527022989) ^ 0x3FE5AB81);
					continue;
				case 20u:
					flag3 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = ((int)num2 * -459709972) ^ -89878322;
					continue;
				case 18u:
				{
					int num9;
					int num10;
					if (!flag2)
					{
						num9 = 1627290225;
						num10 = 1627290225;
					}
					else
					{
						num9 = 1879255576;
						num10 = 1879255576;
					}
					num = num9 ^ (int)(num2 * 962605637);
					continue;
				}
				case 17u:
				{
					int num7;
					int num8;
					if (!flag3)
					{
						num7 = -237812196;
						num8 = -237812196;
					}
					else
					{
						num7 = -1285758329;
						num8 = -1285758329;
					}
					num = num7 ^ ((int)num2 * -763525467);
					continue;
				}
				case 16u:
					jSONData = new JSONData("");
					num = (int)(num2 * 1870953644) ^ -1520877953;
					continue;
				case 14u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 1644850887) ^ -746379430;
					continue;
				case 13u:
					num = (int)(num2 * 1100174657) ^ -1720020558;
					continue;
				case 12u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = (int)(num2 * 1359385610) ^ -880675764;
					continue;
				case 11u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 1215182541) ^ -1557693897;
					continue;
				case 10u:
					num = (int)((num2 * 1332337443) ^ 0x4F2A7BEF);
					continue;
				case 9u:
					num = ((int)num2 * -1769436123) ^ 0x7A6C7A04;
					continue;
				case 8u:
					jSONData.AsInt = AsInt;
					num = (int)(num2 * 440083356) ^ -1224733564;
					continue;
				case 7u:
					num = ((int)num2 * -1382921645) ^ -868434398;
					continue;
				case 6u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = ((int)num2 * -762039088) ^ 0xEFA50B;
					continue;
				case 5u:
					jSONData.AsBool = AsBool;
					num = 929994226;
					continue;
				case 4u:
					num = ((int)num2 * -1229191192) ^ -1419874788;
					continue;
				case 3u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)((num2 * 857139193) ^ 0x68B7C8C7);
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num3 = 1198587815;
						num4 = 1198587815;
					}
					else
					{
						num3 = 1059697616;
						num4 = 1059697616;
					}
					num = num3 ^ ((int)num2 * -1666808699);
					continue;
				}
				case 1u:
					num = (int)(num2 * 224105474) ^ -1541793483;
					continue;
				case 0u:
					JSONData.smethod_33(aWriter, AsInt);
					num = ((int)num2 * -1405810812) ^ -899035617;
					continue;
				default:
					return;
				case 19u:
					break;
				case 15u:
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
