using System.IO;
using System.Security.AccessControl;
using System.Text;

public class GClass39 : GClass37
{
	private readonly string string_3;

	public GClass38 GClass38_0
	{
		get
		{
			string text = default(string);
			GClass38 result = default(GClass38);
			while (true)
			{
				int num = -653702118;
				while (true)
				{
					uint num2;
					object obj;
					switch ((num2 = (uint)num ^ 0xE146669Fu) % 6u)
					{
					case 3u:
						obj = new GClass38(text);
						goto IL_0009;
					case 2u:
						num = (int)((num2 * 178601173) ^ 0x7D884004);
						continue;
					case 1u:
						text = String_2;
						num = (int)((num2 * 1961403666) ^ 0x45D038F1);
						continue;
					case 0u:
						if (text != null)
						{
							num = ((int)num2 * -2059662644) ^ -467720796;
							continue;
						}
						obj = null;
						goto IL_0009;
					case 4u:
						break;
					default:
						{
							return result;
						}
						IL_0009:
						result = (GClass38)obj;
						num = -1175315609;
						continue;
					}
					break;
				}
			}
		}
	}

	public new string String_2 => GClass41.smethod_14(string_1);

	public override bool GClass37_002E_206C_206A_206B_206C_200D_206C_202E_202C_200F_206A_200E_202D_206D_200F_206A_200B_206C_206B_206F_206C_206A_200D_206A_206E_202E_202D_206B_200D_206D_200F_200E_202C_202D_206B_206F_202E_206D_200C_200B_202C_202E
	{
		get
		{
			if (genum14_0 == GEnum14.Uninitialized)
			{
				goto IL_0037;
			}
			goto IL_009c;
			IL_009c:
			int num;
			if (genum14_0 != GEnum14.Initialized)
			{
				num = 0;
				goto IL_008d;
			}
			int num2 = -1785192169;
			goto IL_004b;
			IL_0037:
			num2 = -730877297;
			goto IL_004b;
			IL_0078:
			num = (((gclass40_0.fileAttributes_0 & FileAttributes.Directory) != FileAttributes.Directory) ? 1 : 0);
			goto IL_008d;
			IL_008d:
			bool result = (byte)num != 0;
			num2 = -1299115784;
			goto IL_004b;
			IL_004b:
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xAB10964Cu) % 7u)
				{
				case 6u:
					method_0();
					num2 = (int)((num3 * 1587516339) ^ 0x2048CAEA);
					continue;
				case 5u:
					num2 = ((int)num3 * -1821211822) ^ 0x59187764;
					continue;
				case 4u:
					break;
				case 3u:
					num2 = ((int)num3 * -743783283) ^ 0x43E1F57D;
					continue;
				case 2u:
					goto IL_0078;
				case 0u:
					goto IL_009c;
				default:
					return result;
				}
				break;
			}
			goto IL_0037;
		}
	}

	public long Int64_0
	{
		get
		{
			long result = default(long);
			while (true)
			{
				int num = 1003793431;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x4CC523A5u) % 3u)
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
					result = method_2();
					num = ((int)num2 * -1130825790) ^ 0x37AB165E;
				}
			}
		}
	}

	public override string GClass37_002E_200F_206C_206C_200C_200E_200B_202D_202D_202E_206C_200C_200D_200F_206D_206D_202C_206F_200B_200B_206A_200F_202B_200B_206B_202A_202A_202A_206E_202C_206E_202C_202D_200D_206D_202E_200E_206F_202B_206B_206C_202E
	{
		get
		{
			string result = default(string);
			while (true)
			{
				int num = -85524558;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xFB7AB663u) % 4u)
					{
					case 2u:
						num = ((int)num2 * -992090605) ^ 0x4A98B77D;
						continue;
					case 1u:
						result = string_3;
						num = (int)((num2 * 756543467) ^ 0x71C1A3A2);
						continue;
					case 3u:
						break;
					default:
						return result;
					}
					break;
				}
			}
		}
	}

	public bool Boolean_0
	{
		get
		{
			bool result = default(bool);
			while (true)
			{
				int num = -1836358361;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAB15A3CAu) % 3u)
					{
					case 2u:
						goto IL_0003;
					case 0u:
						break;
					default:
						return result;
					}
					break;
					IL_0003:
					result = (base.FileAttributes_0 & FileAttributes.ReadOnly) != 0;
					num = (int)((num2 * 1360351919) ^ 0x17740417);
				}
			}
		}
		set
		{
			while (true)
			{
				int num = 1618006910;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x2FC6371Bu) % 6u)
					{
					case 5u:
					{
						int num3;
						int num4;
						if (!value)
						{
							num3 = -1698105642;
							num4 = -1698105642;
						}
						else
						{
							num3 = -1748449621;
							num4 = -1748449621;
						}
						num = num3 ^ (int)(num2 * 1267122209);
						continue;
					}
					case 3u:
						base.FileAttributes_0 |= FileAttributes.ReadOnly;
						num = ((int)num2 * -824220322) ^ 0x586FC850;
						continue;
					case 2u:
						num = (int)((num2 * 99224477) ^ 0x5A9637EA);
						continue;
					case 0u:
						base.FileAttributes_0 &= ~FileAttributes.ReadOnly;
						num = 285080359;
						continue;
					default:
						return;
					case 4u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public GClass39(string string_4)
	{
		while (true)
		{
			int num = -1966869858;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC4BE1BF4u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -786508105) ^ -1009355669;
					continue;
				case 2u:
					num = ((int)num2 * -2131157059) ^ -1916905857;
					continue;
				case 0u:
					string_0 = string_4;
					string_1 = GClass41.smethod_13(string_4);
					string_3 = GClass41.smethod_12(string_4);
					base.String_1 = method_1(string_4);
					num = (int)((num2 * 850248999) ^ 0x170416C7);
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

	private string method_1(string string_4)
	{
		return string_4;
	}

	private long method_2()
	{
		long result = default(long);
		bool flag = default(bool);
		while (true)
		{
			int num = 1450637924;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BAF0109u) % 12u)
				{
				case 11u:
					num = (int)((num2 * 800475173) ^ 0x124B5A0D);
					continue;
				case 10u:
					num = ((int)num2 * -1454340835) ^ -1349446615;
					continue;
				case 9u:
					GClass33.smethod_13(int_0, string_1);
					num = (int)((num2 * 428496523) ^ 0x106CABE9);
					continue;
				case 7u:
					result = ((long)gclass40_0.int_0 << 32) | (gclass40_0.int_1 & 0xFFFFFFFFL);
					num = 425071743;
					continue;
				case 6u:
				{
					int num5;
					if (genum14_0 != GEnum14.Error)
					{
						num = 452473514;
						num5 = 452473514;
					}
					else
					{
						num = 1781623064;
						num5 = 1781623064;
					}
					continue;
				}
				case 5u:
					flag = genum14_0 == GEnum14.Uninitialized;
					num = ((int)num2 * -689967055) ^ -410518469;
					continue;
				case 4u:
					method_0();
					num = (int)(num2 * 873372361) ^ -1204106989;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!flag)
					{
						num3 = 407999217;
						num4 = 407999217;
					}
					else
					{
						num3 = 907920306;
						num4 = 907920306;
					}
					num = num3 ^ (int)(num2 * 1918380474);
					continue;
				}
				case 2u:
					num = ((int)num2 * -492981798) ^ 0x6FBA64F9;
					continue;
				case 1u:
					num = (int)((num2 * 32191868) ^ 0x490EA1A9);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public StreamWriter method_3()
	{
		StreamWriter result = GClass36.smethod_61(string_1, bool_0: true);
		while (true)
		{
			int num = -1517135723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC7641BE9u) % 3u)
				{
				case 1u:
					goto IL_000f;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_000f:
				num = ((int)num2 * -35389638) ^ -1660862366;
			}
		}
	}

	public GClass39 method_4(string string_4)
	{
		GClass39 result = default(GClass39);
		while (true)
		{
			int num = -2111077036;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD2985A47u) % 4u)
				{
				case 3u:
					result = method_5(string_4, bool_0: false);
					num = (int)(num2 * 345593627) ^ -1528642885;
					continue;
				case 1u:
					num = ((int)num2 * -769708348) ^ 0xAD9E131;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public GClass39 method_5(string string_4, bool bool_0)
	{
		GClass39 result = default(GClass39);
		while (true)
		{
			int num = -377989237;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC8DE60F5u) % 6u)
				{
				case 5u:
					num = (int)(num2 * 592820458) ^ -565986759;
					continue;
				case 4u:
					result = new GClass39(string_4);
					num = ((int)num2 * -1969427892) ^ 0x282EBE1C;
					continue;
				case 2u:
					GClass36.smethod_5(string_1, string_4, bool_0);
					num = ((int)num2 * -1126345799) ^ 0x4C37C2CA;
					continue;
				case 1u:
					num = ((int)num2 * -191015841) ^ -1487485346;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public FileStream method_6()
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = 2137917126;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x100DDF7Fu) % 4u)
				{
				case 2u:
					num = ((int)num2 * -2100554687) ^ 0x5C797576;
					continue;
				case 1u:
					result = GClass36.smethod_6(string_1);
					num = (int)((num2 * 1788305454) ^ 0x1BC634EF);
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public StreamWriter method_7()
	{
		StreamWriter result = GClass36.smethod_61(string_1, bool_0: false);
		while (true)
		{
			int num = 1318691367;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5633B4CEu) % 3u)
				{
				case 2u:
					goto IL_000f;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_000f:
				num = ((int)num2 * -650005629) ^ -1273547111;
			}
		}
	}

	public override void GClass37_002E_200E_206A_206A_206C_206A_206A_206E_206B_200F_200F_202B_200D_206A_206F_200E_200B_206D_200C_206D_206B_200B_202C_202C_206C_206E_206A_206C_206C_202B_206A_202B_206E_200B_202D_202E_206D_206A_202B_200F_200F_202E()
	{
		GClass36.smethod_10(string_1);
		while (true)
		{
			int num = -170471764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8FEEF1AAu) % 3u)
				{
				case 1u:
					goto IL_000d;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_000d:
				num = ((int)num2 * -509038952) ^ -1587909597;
			}
		}
	}

	public void method_8(string string_4)
	{
		GClass36.smethod_52(string_1, string_4);
	}

	public FileStream method_9(FileMode fileMode_0)
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = -96624142;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBB893899u) % 4u)
				{
				case 3u:
					result = method_11(fileMode_0, FileAccess.ReadWrite, FileShare.None);
					num = ((int)num2 * -750539450) ^ -36258925;
					continue;
				case 0u:
					num = ((int)num2 * -205864533) ^ -1591581940;
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

	public FileStream method_10(FileMode fileMode_0, FileAccess fileAccess_0)
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = 1876072439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x26B045E0u) % 4u)
				{
				case 3u:
					result = method_11(fileMode_0, fileAccess_0, FileShare.None);
					num = (int)((num2 * 1329691424) ^ 0x4D749FD8);
					continue;
				case 0u:
					num = (int)((num2 * 1954776196) ^ 0x22846EA9);
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

	public FileStream method_11(FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0)
	{
		FileStream result = GClass36.smethod_17(string_1, fileMode_0, fileAccess_0, fileShare_0, 4096, FileOptions.SequentialScan);
		while (true)
		{
			int num = -685565974;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDD8C01ADu) % 3u)
				{
				case 2u:
					goto IL_001b;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_001b:
				num = (int)((num2 * 1217183394) ^ 0x59305596);
			}
		}
	}

	public FileStream method_12()
	{
		FileStream result = default(FileStream);
		while (true)
		{
			int num = 1614687512;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CADC31Bu) % 4u)
				{
				case 3u:
					result = GClass36.smethod_17(string_1, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.None);
					num = ((int)num2 * -2017590777) ^ 0x7C763E37;
					continue;
				case 1u:
					num = ((int)num2 * -1350524405) ^ -43822158;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public StreamReader method_13()
	{
		StreamReader result = default(StreamReader);
		while (true)
		{
			int num = 1758151844;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6EEFE17Du) % 3u)
				{
				case 1u:
					goto IL_0003;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0003:
				result = GClass36.smethod_64(string_1, Encoding.UTF8, bool_0: true, 1024);
				num = ((int)num2 * -987373014) ^ 0x16678944;
			}
		}
	}

	public FileStream method_14()
	{
		FileStream result = GClass36.smethod_16(string_1, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
		while (true)
		{
			int num = 1271455039;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3D51DDF3u) % 3u)
				{
				case 1u:
					goto IL_0011;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0011:
				num = (int)((num2 * 1187359899) ^ 0x79416BB4);
			}
		}
	}

	string object.ToString()
	{
		string result = base.String_1;
		while (true)
		{
			int num = 44087628;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x583D713Cu) % 3u)
				{
				case 1u:
					goto IL_0009;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0009:
				num = ((int)num2 * -1946002399) ^ 0x1AED4D2D;
			}
		}
	}

	public void method_15()
	{
		while (true)
		{
			int num = -1030905534;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC6115087u) % 3u)
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
				GClass36.smethod_12(string_1);
				num = ((int)num2 * -1473736896) ^ 0x37089233;
			}
		}
	}

	public void method_16()
	{
		GClass36.smethod_11(string_1);
	}

	public GClass39 method_17(string string_4, string string_5)
	{
		GClass39 result = default(GClass39);
		while (true)
		{
			int num = 1322755595;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x187BAF9Fu) % 3u)
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
				result = method_18(string_4, string_5, bool_0: false);
				num = (int)((num2 * 884483194) ^ 0x1505ADCF);
			}
		}
	}

	public GClass39 method_18(string string_4, string string_5, bool bool_0)
	{
		GClass39 result = default(GClass39);
		while (true)
		{
			int num = 315726724;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x128F1A60u) % 5u)
				{
				case 4u:
					result = new GClass39(string_4);
					num = ((int)num2 * -1843179226) ^ -137043993;
					continue;
				case 1u:
					GClass36.smethod_54(string_1, string_4, string_5, bool_0);
					num = ((int)num2 * -595943662) ^ -1943526747;
					continue;
				case 0u:
					num = ((int)num2 * -185554974) ^ -1758881763;
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

	public FileSecurity method_19()
	{
		FileSecurity result = default(FileSecurity);
		while (true)
		{
			int num = -2132671378;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E1171B9u) % 4u)
				{
				case 3u:
					result = GClass36.smethod_57(string_1);
					num = ((int)num2 * -1767553644) ^ -482555279;
					continue;
				case 0u:
					num = (int)((num2 * 280015819) ^ 0x5BC68B30);
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

	public FileSecurity method_20(AccessControlSections accessControlSections_0)
	{
		FileSecurity result = default(FileSecurity);
		while (true)
		{
			int num = 1798213545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7096FB5Bu) % 4u)
				{
				case 2u:
					result = GClass36.smethod_58(string_1, accessControlSections_0);
					num = (int)(num2 * 526267680) ^ -615950894;
					continue;
				case 1u:
					num = (int)(num2 * 1910842193) ^ -1421611579;
					continue;
				case 0u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public void method_21(FileSecurity fileSecurity_0)
	{
		while (true)
		{
			int num = -615700153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x88D3FCB0u) % 3u)
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
				GClass36.smethod_55(string_1, fileSecurity_0);
				num = (int)((num2 * 124567321) ^ 0x9821B31);
			}
		}
	}
}
