using System.IO;

namespace SimpleJSON;

public class JSONData : JSONNode
{
	private string m_Data;

	public override string Value
	{
		get
		{
			string data = m_Data;
			while (true)
			{
				int num = -557701618;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF4F1E41Cu) % 3u)
					{
					case 2u:
						goto IL_0009;
					case 0u:
						break;
					default:
						return data;
					}
					break;
					IL_0009:
					num = ((int)num2 * -1065496241) ^ 0xCB639F;
				}
			}
		}
		set
		{
			while (true)
			{
				int num = -532052979;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDA41F919u) % 3u)
					{
					case 1u:
						goto IL_0003;
					default:
						return;
					case 0u:
						break;
					case 2u:
						return;
					}
					break;
					IL_0003:
					m_Data = value;
					num = ((int)num2 * -1094286350) ^ 0x188D0DC3;
				}
			}
		}
	}

	public JSONData(string aData)
	{
		while (true)
		{
			int num = -487342247;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE56F2FADu) % 3u)
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
				num = (int)(num2 * 297630451) ^ -2073501641;
			}
		}
	}

	public JSONData(float aData)
	{
		while (true)
		{
			int num = 1515324803;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x328849EDu) % 5u)
				{
				case 3u:
					num = ((int)num2 * -1109613574) ^ 0x7AA1DC90;
					continue;
				case 2u:
					num = ((int)num2 * -598655914) ^ 0x3D6584CE;
					continue;
				case 1u:
					AsFloat = aData;
					num = (int)((num2 * 921418915) ^ 0x607B4956);
					continue;
				default:
					return;
				case 4u:
					break;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public JSONData(double aData)
	{
		AsDouble = aData;
	}

	public JSONData(bool aData)
	{
		while (true)
		{
			int num = -2103454213;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBFBFA90Du) % 6u)
				{
				case 5u:
					num = ((int)num2 * -1755108623) ^ 0xB696E6E;
					continue;
				case 4u:
					num = ((int)num2 * -1038415777) ^ -1604721850;
					continue;
				case 1u:
					num = (int)(num2 * 1304456120) ^ -1581621218;
					continue;
				case 0u:
					AsBool = aData;
					num = ((int)num2 * -1268180080) ^ -1687887604;
					continue;
				default:
					return;
				case 2u:
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
		AsInt = aData;
	}

	public override string ToString()
	{
		string result = default(string);
		while (true)
		{
			int num = 1853613355;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7E78BADAu) % 4u)
				{
				case 1u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 29017165) ^ 0x422B2CF7);
					continue;
				case 0u:
					num = ((int)num2 * -2069452858) ^ -553874559;
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
		string result = default(string);
		while (true)
		{
			int num = -823493667;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA36EDECEu) % 4u)
				{
				case 3u:
					result = JSONData.smethod_30("\"", JSONNode.Escape(m_Data), "\"");
					num = (int)((num2 * 524404745) ^ 0x14C3C131);
					continue;
				case 0u:
					num = ((int)num2 * -1843556880) ^ -1326519777;
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

	public override void Serialize(BinaryWriter aWriter)
	{
		JSONData jSONData = new JSONData("");
		jSONData.AsInt = AsInt;
		bool flag = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			int num = 224186651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x698C332Fu) % 29u)
				{
				case 28u:
					JSONData.smethod_34(aWriter, AsFloat);
					num = ((int)num2 * -1340650601) ^ 0x63E184A9;
					continue;
				case 27u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = 1744090912;
						num5 = 1744090912;
					}
					else
					{
						num4 = 1304758268;
						num5 = 1304758268;
					}
					num = num4 ^ ((int)num2 * -327652182);
					continue;
				}
				case 26u:
					num = (int)((num2 * 1449746882) ^ 0x7BE45098);
					continue;
				case 25u:
					jSONData.AsFloat = AsFloat;
					num = 1067558113;
					continue;
				case 24u:
					num = (int)((num2 * 168726779) ^ 0x516B9DC5);
					continue;
				case 23u:
				{
					int num8;
					int num9;
					if (JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num8 = 594858935;
						num9 = 594858935;
					}
					else
					{
						num8 = 1514246923;
						num9 = 1514246923;
					}
					num = num8 ^ ((int)num2 * -546720143);
					continue;
				}
				case 22u:
					JSONData.smethod_32(aWriter, (byte)3);
					num = 1251697566;
					continue;
				case 21u:
					JSONData.smethod_32(aWriter, (byte)6);
					JSONData.smethod_36(aWriter, AsBool);
					num = ((int)num2 * -1057265472) ^ -1774355818;
					continue;
				case 20u:
					num = ((int)num2 * -136818028) ^ -1384109528;
					continue;
				case 19u:
					JSONData.smethod_32(aWriter, (byte)4);
					num = (int)(num2 * 1228322050) ^ -1085269234;
					continue;
				case 18u:
					JSONData.smethod_32(aWriter, (byte)7);
					num = (int)((num2 * 1582379978) ^ 0x7DAAFA6E);
					continue;
				case 17u:
				{
					int num6;
					int num7;
					if (!flag2)
					{
						num6 = -2126119974;
						num7 = -2126119974;
					}
					else
					{
						num6 = -335864272;
						num7 = -335864272;
					}
					num = num6 ^ ((int)num2 * -208178180);
					continue;
				}
				case 16u:
					JSONData.smethod_32(aWriter, (byte)5);
					num = (int)(num2 * 1196510162) ^ -57796155;
					continue;
				case 15u:
					num = (int)(num2 * 1069637846) ^ -1828453725;
					continue;
				case 14u:
					num = (int)(num2 * 594986674) ^ -265063041;
					continue;
				case 13u:
					JSONData.smethod_35(aWriter, AsDouble);
					num = ((int)num2 * -1223815797) ^ -1273814640;
					continue;
				case 12u:
					jSONData.AsBool = AsBool;
					num = 962006800;
					continue;
				case 11u:
					num = ((int)num2 * -2113606499) ^ 0x648E76B3;
					continue;
				case 9u:
					JSONData.smethod_33(aWriter, AsInt);
					num = (int)((num2 * 1435002914) ^ 0x692DCE9C);
					continue;
				case 8u:
					JSONData.smethod_37(aWriter, m_Data);
					num = (int)(num2 * 432821389) ^ -1672282260;
					continue;
				case 7u:
					num = (int)((num2 * 32183666) ^ 0x2AC54847);
					continue;
				case 6u:
					num = ((int)num2 * -580211122) ^ 0x786344CA;
					continue;
				case 5u:
					num = ((int)num2 * -474933249) ^ -1093116589;
					continue;
				case 3u:
					flag2 = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)((num2 * 271149152) ^ 0x1F184C6F);
					continue;
				case 2u:
				{
					jSONData.AsDouble = AsDouble;
					int num3;
					if (!JSONData.smethod_31(jSONData.m_Data, m_Data))
					{
						num = 1806856868;
						num3 = 1806856868;
					}
					else
					{
						num = 1404828348;
						num3 = 1404828348;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1844349481) ^ 0x22E56FBA;
					continue;
				case 0u:
					flag = JSONData.smethod_31(jSONData.m_Data, m_Data);
					num = (int)(num2 * 589994053) ^ -939020248;
					continue;
				default:
					return;
				case 10u:
					break;
				case 4u:
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
