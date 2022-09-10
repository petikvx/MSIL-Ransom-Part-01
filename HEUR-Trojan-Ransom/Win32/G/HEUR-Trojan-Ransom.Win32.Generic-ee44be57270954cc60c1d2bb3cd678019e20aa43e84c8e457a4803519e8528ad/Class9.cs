using System.IO;

internal class Class9
{
	public static GInterface0 smethod_0(ref MemoryStream memoryStream_0)
	{
		GClass24 gClass = new GClass24();
		gClass.method_0(ref memoryStream_0);
		GEnum2 gEnum2_ = gClass.GEnum2_0;
		GInterface0 gInterface = default(GInterface0);
		int num;
		switch (gEnum2_)
		{
		case GEnum2.ATMA:
			gInterface = new GClass13(gClass);
			num = 839259836;
			goto IL_00b5;
		case GEnum2.AAAA:
			goto IL_0182;
		default:
			goto IL_01b6;
		case GEnum2.SRV:
			goto IL_01d2;
		case GEnum2.TXT:
			goto IL_01e3;
		case GEnum2.LOC:
			goto IL_01f4;
		case GEnum2.RP:
			goto IL_0217;
		case GEnum2.MINFO:
			goto IL_023a;
		case GEnum2.ISDN:
			goto IL_024b;
		case GEnum2.PTR:
			goto IL_025c;
		case GEnum2.MR:
			goto IL_026d;
		case GEnum2.A:
			goto IL_027e;
		case GEnum2.AFSDB:
			goto IL_028f;
		case GEnum2.X25:
			goto IL_02a0;
		case GEnum2.NS:
			goto IL_02b1;
		case GEnum2.RT:
			goto IL_02e6;
		case GEnum2.SOA:
			goto IL_0309;
		case GEnum2.MX:
			goto IL_034f;
		case GEnum2.HINFO:
			goto IL_0372;
		case GEnum2.CNAME:
			goto IL_03c1;
		case GEnum2.MG:
			goto IL_03d2;
		case GEnum2.WKS:
			goto IL_03e3;
		case GEnum2.MB:
			goto IL_044e;
		case GEnum2.MD:
		case GEnum2.MF:
		case GEnum2.NULL:
		case GEnum2.NSAP:
		case GEnum2.NSAP_PTR:
		case GEnum2.SIG:
		case GEnum2.KEY:
		case GEnum2.PX:
		case GEnum2.GPOS:
		case GEnum2.NXT:
		case GEnum2.EID:
		case GEnum2.NIMLOC:
			goto IL_0483;
			IL_00b5:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2E5867Bu) % 46u)
				{
				case 29u:
					break;
				case 45u:
					goto IL_0182;
				case 44u:
					num = ((int)num2 * -1974076326) ^ -1533298850;
					continue;
				case 43u:
					gInterface = new GClass23(gClass);
					num = 1782194954;
					continue;
				case 42u:
					goto IL_01b6;
				case 41u:
					num = ((int)num2 * -235284950) ^ 0x32EBBE84;
					continue;
				case 40u:
					goto IL_01d2;
				case 39u:
					goto IL_01e3;
				case 38u:
					goto IL_01f4;
				case 37u:
					num = ((int)num2 * -392044799) ^ -1758802487;
					continue;
				case 36u:
					goto IL_0217;
				case 35u:
					num = ((int)num2 * -390785930) ^ -920459382;
					continue;
				case 33u:
					goto IL_023a;
				case 32u:
					goto IL_024b;
				case 31u:
					goto IL_025c;
				case 30u:
					goto IL_026d;
				case 28u:
					goto IL_027e;
				case 27u:
					goto IL_028f;
				case 26u:
					goto IL_02a0;
				case 25u:
					goto IL_02b1;
				case 24u:
					num = ((int)num2 * -1852052014) ^ 0x530F7D26;
					continue;
				case 23u:
					num = ((int)num2 * -1121540375) ^ 0x3D298911;
					continue;
				case 22u:
					goto IL_02e6;
				case 21u:
					num = ((int)num2 * -1181999745) ^ -1132250635;
					continue;
				case 20u:
					goto IL_0309;
				case 19u:
					gInterface.imethod_0(ref memoryStream_0);
					num = 878672299;
					continue;
				case 18u:
					num = ((int)num2 * -208678584) ^ 0x15547A3E;
					continue;
				case 17u:
					num = ((int)num2 * -251625934) ^ -1472882932;
					continue;
				case 16u:
					goto IL_034f;
				case 15u:
					num = (int)((num2 * 1559039065) ^ 0x2E3773BF);
					continue;
				case 14u:
					goto IL_0372;
				case 13u:
					num = (int)(num2 * 1545978674) ^ -312891460;
					continue;
				case 12u:
				{
					int num3;
					int num4;
					if (gEnum2_ != GEnum2.TSIG)
					{
						num3 = 1731172946;
						num4 = 1731172946;
					}
					else
					{
						num3 = 710879722;
						num4 = 710879722;
					}
					num = num3 ^ (int)(num2 * 366912794);
					continue;
				}
				case 10u:
					goto IL_03c1;
				case 9u:
					goto IL_03d2;
				case 8u:
					goto IL_03e3;
				case 7u:
					num = ((int)num2 * -65433837) ^ -579841577;
					continue;
				case 6u:
					num = (int)((num2 * 1777656625) ^ 0x7D0497E4);
					continue;
				case 5u:
					num = (int)(num2 * 255531741) ^ -440338095;
					continue;
				case 4u:
					num = (int)((num2 * 1232603749) ^ 0x595C98F0);
					continue;
				case 3u:
					num = ((int)num2 * -388696932) ^ -1579528966;
					continue;
				case 2u:
					goto IL_044e;
				case 1u:
					num = (int)((num2 * 204106748) ^ 0x349FD96A);
					continue;
				case 0u:
					num = ((int)num2 * -626333252) ^ -479301554;
					continue;
				case 11u:
					goto IL_0483;
				default:
					return gInterface;
				}
				break;
			}
			goto case GEnum2.ATMA;
			IL_0483:
			gInterface = new Class8(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_044e:
			gInterface = new GClass10(gClass);
			num = 1123890174;
			goto IL_00b5;
			IL_03e3:
			gInterface = new GClass14(gClass);
			num = 810353874;
			goto IL_00b5;
			IL_03d2:
			gInterface = new GClass21(gClass);
			num = 1954320024;
			goto IL_00b5;
			IL_03c1:
			gInterface = new GClass22(gClass);
			num = 1273795185;
			goto IL_00b5;
			IL_0372:
			gInterface = new GClass11(gClass);
			num = 1568314752;
			goto IL_00b5;
			IL_034f:
			gInterface = new GClass20(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_0309:
			gInterface = new GClass18(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_02e6:
			gInterface = new GClass1(gClass);
			num = 1067268284;
			goto IL_00b5;
			IL_02b1:
			gInterface = new GClass2(gClass);
			num = 1375128669;
			goto IL_00b5;
			IL_02a0:
			gInterface = new GClass6(gClass);
			num = 1915720975;
			goto IL_00b5;
			IL_028f:
			gInterface = new GClass8(gClass);
			num = 1242875275;
			goto IL_00b5;
			IL_027e:
			gInterface = new GClass7(gClass);
			num = 846257116;
			goto IL_00b5;
			IL_026d:
			gInterface = new GClass5(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_025c:
			gInterface = new GClass9(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_024b:
			gInterface = new GClass16(gClass);
			num = 1707171170;
			goto IL_00b5;
			IL_023a:
			gInterface = new GClass15(gClass);
			num = 1558565933;
			goto IL_00b5;
			IL_0217:
			gInterface = new GClass19(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_01f4:
			gInterface = new GClass12(gClass);
			num = 1175266318;
			goto IL_00b5;
			IL_01e3:
			gInterface = new GClass17(gClass);
			num = 520260666;
			goto IL_00b5;
			IL_01d2:
			gInterface = new GClass4(gClass);
			num = 819308339;
			goto IL_00b5;
			IL_01b6:
			num = 1086073069;
			goto IL_00b5;
			IL_0182:
			gInterface = new GClass3(gClass);
			num = 1973156112;
			goto IL_00b5;
		}
	}
}
