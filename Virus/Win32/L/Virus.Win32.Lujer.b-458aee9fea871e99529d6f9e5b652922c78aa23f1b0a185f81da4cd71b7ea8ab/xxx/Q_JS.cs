using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace xxx;

[StandardModule]
internal sealed class Q_JS
{
	private const int huangse = 36;

	private const int hongse = 46;

	public static int W;

	private static int hongsei;

	private static double[,] SRF = new double[2, 2];

	private static double[,] SQ = new double[2, 2];

	private static double[,] DRF = new double[2, 2];

	private static double[,] DQ = new double[2, 2];

	private static object SRFMAX;

	private static object SRFMIN;

	private static long SRFROW;

	private static long SQROW;

	private static int DRFUBOUND;

	public static string strtempch;

	private static long pzrows;

	private static string[] pzlist;

	private static long pznum;

	private static long pzcol;

	private static string[] rflist;

	private static long rfnum;

	private static long rfcol;

	private static string[] comblist;

	private static long combnum;

	private static long combcol;

	private static int jLZ;

	private static int jRF;

	private static int jCOMB;

	private static int jQ;

	private static int jPZ;

	private static int jLF;

	private static int jCOMBF;

	private static int jFIXXT;

	private static int jZBXT;

	private static string[] ALZ;

	private static string[] ACOMB;

	private static string[] ARF;

	private static string[] ADestination_Q;

	private static string[] APZ;

	private static int ACOUNT;

	private static string[] ALF;

	private static string[] ACOMBF;

	private static string[] AFIXXT;

	private static string[] AZBXT;

	private static long[] combrowi;

	public static string strjxch;

	public static string strjxen;

	private static string[] lzlist;

	private static long lzcol;

	private static Worksheet cursh;

	private static Worksheet shALL;

	private static Worksheet shALLTemp;

	private static Worksheet newsh;

	private static string curbc;

	private static string curbcname;

	private static string[] curlzlist;

	private static string[] curcomblist;

	private static long curcombcol;

	private static long curcombnum;

	private static float PctDone;

	private static string jsshname;

	private static bool blfind;

	private static bool bt3Destination;

	public static bool SheetExists(object sname)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		object objectValue = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 126:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_002b;
						case 4:
							goto IL_003d;
						case 6:
							goto IL_0044;
						case 7:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 8:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0044:
					num = 6;
					break;
					IL_003d:
					num = 4;
					flag = true;
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					objectValue = RuntimeHelpers.GetObjectValue(Mod1.excelapp.ActiveWorkbook.Sheets[RuntimeHelpers.GetObjectValue(sname)]);
					goto IL_002b;
					IL_002b:
					num = 3;
					if (Operators.ConditionalCompareObjectNotEqual(objectValue, (object)0, false))
					{
						goto IL_003d;
					}
					goto IL_0044;
					end_IL_0000_2:
					break;
				}
				num = 7;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 126;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool mainjs(object lb, int chazhiflag, Workbook curwb)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		bool flag = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		object[] array = default(object[]);
		string[] array2 = default(string[]);
		string name = default(string);
		int num6 = default(int);
		Excel.Range range = default(Excel.Range);
		int num7 = default(int);
		int num8 = default(int);
		string[] array3 = default(string[]);
		int num9 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		int num12 = default(int);
		object objectValue = default(object);
		object obj = default(object);
		int num13 = default(int);
		int num14 = default(int);
		int num15 = default(int);
		int num16 = default(int);
		object objectValue2 = default(object);
		int num17 = default(int);
		int num18 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						num = 1;
						flag = true;
						goto IL_0006;
					case 3273:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0006;
							case 3:
								goto IL_000f;
							case 4:
								goto IL_002c;
							case 5:
								goto IL_0039;
							case 6:
								goto IL_0048;
							case 7:
								goto IL_007c;
							case 8:
							case 10:
								goto IL_0091;
							case 11:
								goto IL_00a4;
							case 12:
								goto IL_00b1;
							case 13:
								goto IL_00c1;
							case 14:
								goto IL_00ce;
							case 15:
								goto IL_00dd;
							case 16:
								goto IL_00ec;
							case 17:
								goto IL_00fb;
							case 18:
								goto IL_010a;
							case 19:
								goto IL_0163;
							case 20:
								goto IL_016f;
							case 21:
								goto IL_01b7;
							case 22:
								goto IL_01e9;
							case 23:
								goto IL_01fd;
							case 24:
								goto IL_0245;
							case 25:
								goto IL_025d;
							case 26:
								goto IL_026d;
							case 27:
								goto IL_0279;
							case 28:
								goto IL_0286;
							case 29:
								goto IL_0293;
							case 30:
								goto IL_02a0;
							case 31:
								goto IL_02ad;
							case 32:
								goto IL_02ba;
							case 33:
								goto IL_02c7;
							case 34:
								goto IL_02d4;
							case 35:
								goto IL_02e1;
							case 40:
							case 41:
								goto IL_02ea;
							case 36:
								goto IL_02f9;
							case 37:
								goto IL_0309;
							case 38:
								goto IL_0340;
							case 42:
								goto IL_034c;
							case 43:
								goto IL_0364;
							case 44:
								goto IL_036d;
							case 45:
								goto IL_0395;
							case 48:
								goto IL_03a1;
							case 49:
								goto IL_03a5;
							case 47:
							case 50:
							case 51:
								goto IL_03de;
							case 52:
								goto IL_03e6;
							case 53:
							case 54:
								goto IL_03f6;
							case 55:
								goto IL_040b;
							case 56:
							case 57:
								goto IL_0412;
							case 58:
								goto IL_0445;
							case 59:
								goto IL_0455;
							case 60:
								goto IL_0552;
							case 61:
								goto IL_0565;
							case 62:
								goto IL_059f;
							case 63:
								goto IL_05af;
							case 64:
							case 65:
								goto IL_05ee;
							case 66:
								goto IL_05f5;
							case 67:
								goto IL_0600;
							case 68:
								goto IL_0606;
							case 69:
								goto IL_061c;
							case 70:
								goto IL_0658;
							case 71:
								goto IL_0668;
							case 72:
							case 73:
								goto IL_06a4;
							case 74:
								goto IL_06b4;
							case 75:
							case 76:
								goto IL_06c0;
							case 77:
								goto IL_06ea;
							case 78:
								goto IL_06f4;
							case 79:
								goto IL_0776;
							case 80:
								goto IL_0782;
							case 84:
							case 85:
								goto IL_0790;
							case 86:
								goto IL_0812;
							case 87:
								goto IL_081e;
							case 92:
							case 93:
								goto IL_082c;
							case 94:
								goto IL_08ae;
							case 95:
								goto IL_08ba;
							case 96:
								goto IL_08c8;
							case 100:
							case 101:
								goto IL_08d6;
							case 102:
								goto IL_08e3;
							case 103:
								goto IL_0965;
							case 104:
								goto IL_0971;
							case 105:
								goto IL_0983;
							case 107:
								goto IL_098e;
							case 108:
								goto IL_0992;
							case 111:
								goto IL_099d;
							case 112:
								goto IL_09a5;
							case 113:
							case 114:
								goto IL_09ab;
							case 115:
								goto IL_09b7;
							case 116:
								goto IL_09c3;
							case 118:
								goto IL_09cd;
							case 119:
								goto IL_09d1;
							case 120:
								goto IL_09dd;
							case 117:
							case 121:
							case 122:
								goto IL_09e9;
							case 106:
							case 109:
							case 110:
								goto IL_09f8;
							case 81:
								goto IL_0a07;
							case 82:
								goto IL_0a2f;
							case 88:
								goto IL_0a3b;
							case 89:
								goto IL_0a63;
							case 90:
								goto IL_0a8b;
							case 97:
								goto IL_0a97;
							case 98:
								goto end_IL_0000_2;
							default:
								goto end_IL_0000;
							case 39:
							case 46:
							case 83:
							case 91:
							case 99:
							case 123:
								goto end_IL_0000_3;
							}
							goto default;
						}
						IL_00b1:
						num = 12;
						num5++;
						goto IL_00bb;
						IL_00a4:
						num = 11;
						array[num5] = array2[num5];
						goto IL_00b1;
						IL_0006:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_000f;
						IL_000f:
						num = 3;
						shALL = (Worksheet)curwb.Worksheets["ALL"];
						goto IL_002c;
						IL_002c:
						num = 4;
						shALL.Activate();
						goto IL_0039;
						IL_0039:
						num = 5;
						name = shALL.Name;
						goto IL_0048;
						IL_0048:
						num = 6;
						array2 = Strings.Split(Conversions.ToString(((_Worksheet)shALL).get_Range((object)"A1", (object)Missing.Value).get_Value((object)Missing.Value)), ",", -1, (CompareMethod)0);
						goto IL_007c;
						IL_007c:
						num = 7;
						array = new object[Information.UBound((Array)array2, 1) + 6 + 1];
						goto IL_0091;
						IL_0091:
						num = 10;
						num6 = Information.UBound((Array)array2, 1);
						num5 = 0;
						goto IL_00bb;
						IL_00bb:
						if (num5 <= num6)
						{
							goto IL_00a4;
						}
						goto IL_00c1;
						IL_00c1:
						num = 13;
						array[num5] = "Destination_Q";
						goto IL_00ce;
						IL_00ce:
						num = 14;
						array[num5 + 1] = "Source_RF";
						goto IL_00dd;
						IL_00dd:
						num = 15;
						array[num5 + 2] = "Source_Q";
						goto IL_00ec;
						IL_00ec:
						num = 16;
						array[num5 + 3] = "Destination_RF";
						goto IL_00fb;
						IL_00fb:
						num = 17;
						array[num5 + 4] = "delt_X";
						goto IL_010a;
						IL_010a:
						num = 18;
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Columns[2, Missing.Value]), RuntimeHelpers.GetObjectValue(shALL.Columns[1 + Information.UBound((Array)array2, 1) + 2, Missing.Value]));
						goto IL_0163;
						IL_0163:
						num = 19;
						range.Select();
						goto IL_016f;
						IL_016f:
						num = 20;
						NewLateBinding.LateCall(Mod1.excelapp.Selection, (Type)null, "Insert", new object[1] { XlDirection.xlToRight }, new string[1] { "Shift" }, (Type[])null, (bool[])null, true);
						goto IL_01b7;
						IL_01b7:
						num = 21;
						NewLateBinding.LateSetComplex(Mod1.excelapp.Selection, (Type)null, "ColumnWidth", new object[1] { 15 }, (string[])null, (Type[])null, false, true);
						goto IL_01e9;
						IL_01e9:
						num = 22;
						num7 = Information.UBound((Array)array, 1) - 1;
						num8 = 1;
						goto IL_0267;
						IL_0267:
						if (num8 <= num7)
						{
							goto IL_01fd;
						}
						goto IL_026d;
						IL_026d:
						num = 26;
						array3 = new string[8];
						goto IL_0279;
						IL_0279:
						num = 27;
						array3[0] = "LZ";
						goto IL_0286;
						IL_0286:
						num = 28;
						array3[1] = "RF";
						goto IL_0293;
						IL_0293:
						num = 29;
						array3[2] = "COMB";
						goto IL_02a0;
						IL_02a0:
						num = 30;
						array3[3] = "Destination_Q";
						goto IL_02ad;
						IL_02ad:
						num = 31;
						array3[4] = "Source_RF";
						goto IL_02ba;
						IL_02ba:
						num = 32;
						array3[5] = "Source_Q";
						goto IL_02c7;
						IL_02c7:
						num = 33;
						array3[6] = "Destination_RF";
						goto IL_02d4;
						IL_02d4:
						num = 34;
						array3[7] = "delt_X";
						goto IL_02e1;
						IL_02e1:
						num = 35;
						num9 = 0;
						goto IL_02f9;
						IL_02f9:
						num = 36;
						if (RangeNameExists(array3[num9]))
						{
							goto IL_02ea;
						}
						goto IL_0309;
						IL_0309:
						num = 37;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "当前活动工作簿中定义单元格名称 " + array3[num9] + "失败!" }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0340;
						IL_0340:
						num = 38;
						flag = false;
						goto end_IL_0000_3;
						IL_02ea:
						num = 41;
						num9++;
						if (num9 <= 7)
						{
							goto IL_02f9;
						}
						goto IL_034c;
						IL_034c:
						num = 42;
						num10 = Conversions.ToInteger(cha1split1(Conversions.ToString(array[0])));
						goto IL_0364;
						IL_0364:
						num = 43;
						if (num10 < 1)
						{
							goto IL_036d;
						}
						goto IL_03a1;
						IL_036d:
						num = 44;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "当前提供的解析格式错误." }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0395;
						IL_0395:
						num = 45;
						flag = false;
						goto end_IL_0000_3;
						IL_03a1:
						num = 48;
						goto IL_03a5;
						IL_03a5:
						num = 49;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "当前处理了 " + Conversions.ToString(num10) + " 行数据!" }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_03de;
						IL_03de:
						num = 51;
						if (chazhiflag == 0)
						{
							goto IL_03e6;
						}
						goto IL_03f6;
						IL_03e6:
						num = 52;
						chazhiflag = Conversions.ToInteger("1");
						goto IL_03f6;
						IL_03f6:
						num = 54;
						if (unchecked(chazhiflag != 1 && chazhiflag != 2))
						{
							goto IL_040b;
						}
						goto IL_0412;
						IL_040b:
						num = 55;
						chazhiflag = 1;
						goto IL_0412;
						IL_0412:
						num = 57;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "当前进行的插值次数为：" + Conversions.ToString(chazhiflag) }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0445;
						IL_0445:
						num = 58;
						num11 = num10;
						num12 = 2;
						goto IL_055c;
						IL_055c:
						if (num12 <= num11)
						{
							goto IL_0455;
						}
						goto IL_0565;
						IL_0565:
						num = 61;
						objectValue = RuntimeHelpers.GetObjectValue(((_Worksheet)shALL).get_Range((object)"Destination_RF", (object)Missing.Value).get_Offset((object)1, (object)0).get_Value((object)Missing.Value));
						goto IL_059f;
						IL_059f:
						num = 62;
						if (RangeNameExists("combf"))
						{
							goto IL_05af;
						}
						goto IL_05ee;
						IL_05af:
						num = 63;
						obj = Conversions.ToInteger(((_Worksheet)shALL).get_Range((object)"combf", (object)Missing.Value).get_Offset((object)1, (object)0).get_Value((object)Missing.Value));
						goto IL_05ee;
						IL_05ee:
						num = 65;
						num13 = 2;
						goto IL_05f5;
						IL_05f5:
						num = 66;
						hongsei = 46;
						goto IL_0600;
						IL_0600:
						num = 67;
						num14 = 0;
						goto IL_0606;
						IL_0606:
						num = 68;
						num15 = num10 + 1;
						num16 = 3;
						goto IL_0613;
						IL_0613:
						if (num16 > num15)
						{
							goto end_IL_0000_3;
						}
						goto IL_061c;
						IL_061c:
						num = 69;
						objectValue2 = RuntimeHelpers.GetObjectValue(((_Worksheet)shALL).get_Range((object)"Destination_RF", (object)Missing.Value).get_Offset((object)(num16 - 1), (object)0).get_Value((object)Missing.Value));
						goto IL_0658;
						IL_0658:
						num = 70;
						if (RangeNameExists("combf"))
						{
							goto IL_0668;
						}
						goto IL_06a4;
						IL_0668:
						num = 71;
						num17 = Conversions.ToInteger(((_Worksheet)shALL).get_Range((object)"combf", (object)Missing.Value).get_Offset((object)(num16 - 1), (object)0).get_Value((object)Missing.Value));
						goto IL_06a4;
						IL_06a4:
						num = 73;
						if (!RangeNameExists("combf"))
						{
							goto IL_06b4;
						}
						goto IL_06c0;
						IL_06b4:
						num = 74;
						num17 = Conversions.ToInteger(obj);
						goto IL_06c0;
						IL_06c0:
						num = 76;
						if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectLessEqual(objectValue2, objectValue, false), Operators.CompareObjectNotEqual((object)num17, obj, false))))
						{
							goto IL_06ea;
						}
						goto IL_09cd;
						IL_06ea:
						num = 77;
						num18 = num16 - 1;
						goto IL_06f4;
						IL_06f4:
						num = 78;
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num13, ((_Worksheet)shALL).get_Range((object)"Source_RF", (object)Missing.Value).Column]), RuntimeHelpers.GetObjectValue(shALL.Cells[num18, ((_Worksheet)shALL).get_Range((object)"Source_RF", (object)Missing.Value).Column]));
						goto IL_0776;
						IL_0776:
						num = 79;
						range.Select();
						goto IL_0782;
						IL_0782:
						num = 80;
						if (bt1_SourceRF())
						{
							goto IL_0790;
						}
						goto IL_0a07;
						IL_0790:
						num = 85;
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num13, ((_Worksheet)shALL).get_Range((object)"Source_Q", (object)Missing.Value).Column]), RuntimeHelpers.GetObjectValue(shALL.Cells[num18, ((_Worksheet)shALL).get_Range((object)"Source_Q", (object)Missing.Value).Column]));
						goto IL_0812;
						IL_0812:
						num = 86;
						range.Select();
						goto IL_081e;
						IL_081e:
						num = 87;
						if (bt2_SourceQ())
						{
							goto IL_082c;
						}
						goto IL_0a3b;
						IL_082c:
						num = 93;
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num13, ((_Worksheet)shALL).get_Range((object)"Destination_RF", (object)Missing.Value).Column]), RuntimeHelpers.GetObjectValue(shALL.Cells[num18, ((_Worksheet)shALL).get_Range((object)"Destination_RF", (object)Missing.Value).Column]));
						goto IL_08ae;
						IL_08ae:
						num = 94;
						range.Select();
						goto IL_08ba;
						IL_08ba:
						num = 95;
						bt3Destination = bt3_DestinationRF();
						goto IL_08c8;
						IL_08c8:
						num = 96;
						if (bt3Destination)
						{
							goto IL_08d6;
						}
						goto IL_0a97;
						IL_08d6:
						num = 101;
						hongsei = 46 + num14;
						goto IL_08e3;
						IL_08e3:
						num = 102;
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num13, ((_Worksheet)shALL).get_Range((object)"Destination_Q", (object)Missing.Value).Column]), RuntimeHelpers.GetObjectValue(shALL.Cells[num18, ((_Worksheet)shALL).get_Range((object)"Destination_Q", (object)Missing.Value).Column]));
						goto IL_0965;
						IL_0965:
						num = 103;
						range.Select();
						goto IL_0971;
						IL_0971:
						num = 104;
						if ((double)chazhiflag == Conversions.ToDouble("2"))
						{
							goto IL_0983;
						}
						goto IL_098e;
						IL_0983:
						num = 105;
						bt4_DestinationQ2();
						goto IL_09f8;
						IL_098e:
						num = 107;
						goto IL_0992;
						IL_0992:
						num = 108;
						bt4_DestinationQ();
						goto IL_09f8;
						IL_09f8:
						num = 110;
						num14++;
						goto IL_099d;
						IL_099d:
						num = 111;
						if (num14 > 2)
						{
							goto IL_09a5;
						}
						goto IL_09ab;
						IL_09a5:
						num = 112;
						num14 = 0;
						goto IL_09ab;
						IL_09ab:
						num = 114;
						objectValue = RuntimeHelpers.GetObjectValue(objectValue2);
						goto IL_09b7;
						IL_09b7:
						num = 115;
						obj = num17;
						goto IL_09c3;
						IL_09c3:
						num = 116;
						num13 = num16;
						goto IL_09e9;
						IL_0a97:
						num = 97;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "只能选择1列为目标幅度,请重新选择.. ." }, (string[])null, (Type[])null, (bool[])null, true);
						break;
						IL_0a3b:
						num = 88;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "当前源吊重列与源幅度列行数不一致,请重新选择.. ." }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0a63;
						IL_0a63:
						num = 89;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "或者 只能选择1列为源幅度,请重新选择.. ." }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0a8b;
						IL_0a8b:
						num = 90;
						flag = false;
						goto end_IL_0000_3;
						IL_0a07:
						num = 81;
						NewLateBinding.LateCall(lb, (Type)null, "AddItem", new object[1] { "只能选择1列为源幅度,请重新选择.. ." }, (string[])null, (Type[])null, (bool[])null, true);
						goto IL_0a2f;
						IL_0a2f:
						num = 82;
						flag = false;
						goto end_IL_0000_3;
						IL_09cd:
						num = 118;
						goto IL_09d1;
						IL_09d1:
						num = 119;
						objectValue = RuntimeHelpers.GetObjectValue(objectValue2);
						goto IL_09dd;
						IL_09dd:
						num = 120;
						obj = num17;
						goto IL_09e9;
						IL_09e9:
						num = 122;
						num16++;
						goto IL_0613;
						IL_0455:
						num = 59;
						NewLateBinding.LateSetComplex(shALL.Cells[num12, ((_Worksheet)shALL).get_Range((object)"Source_RF", (object)Missing.Value).Column], (Type)null, "Value", new object[1] { Operators.AddObject(NewLateBinding.LateGet(shALL.Cells[num12, ((_Worksheet)shALL).get_Range((object)"Destination_RF", (object)Missing.Value).Column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), Operators.MultiplyObject(NewLateBinding.LateGet(shALL.Cells[num12, ((_Worksheet)shALL).get_Range((object)"delt_X", (object)Missing.Value).Column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0.001)) }, (string[])null, (Type[])null, false, true);
						goto IL_0552;
						IL_0552:
						num = 60;
						num12++;
						goto IL_055c;
						IL_01fd:
						num = 23;
						NewLateBinding.LateSetComplex(shALL.Cells[1, 1 + num8], (Type)null, "Value", new object[1] { RuntimeHelpers.GetObjectValue(array[num8]) }, (string[])null, (Type[])null, false, true);
						goto IL_0245;
						IL_0245:
						num = 24;
						NameDef(Conversions.ToString(array[num8]), name, 1 + num8);
						goto IL_025d;
						IL_025d:
						num = 25;
						num8++;
						goto IL_0267;
						end_IL_0000_2:
						break;
					}
					num = 98;
					flag = false;
					break;
				}
				end_IL_0000:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0000_dispatch = 3273;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static bool RangeNameExists(object nname)
	{
		bool result = false;
		checked
		{
			int num = Mod1.excelapp.ActiveWorkbook.Names.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Name name = (Name)Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(i);
				string text = Strings.UCase(name.Name);
				Type typeFromHandle = typeof(Strings);
				object[] array = new object[1] { RuntimeHelpers.GetObjectValue(nname) };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					nname = RuntimeHelpers.GetObjectValue(array[0]);
				}
				if (Operators.ConditionalCompareObjectEqual((object)text, obj, false))
				{
					result = true;
					break;
				}
			}
			return result;
		}
	}

	public static void NameDef(string nm, string shname, int ncol)
	{
		checked
		{
			if (RangeNameExists(nm))
			{
				IEnumerator enumerator = default(IEnumerator);
				int num = default(int);
				try
				{
					enumerator = Mod1.excelapp.ActiveWorkbook.Names.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Name name = (Name)enumerator.Current;
						num++;
						if (Operators.CompareString(Strings.UCase(nm), Strings.UCase(name.Name), false) == 0)
						{
							return;
						}
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				NewLateBinding.LateCall(Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(num - 1), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			Mod1.excelapp.ActiveWorkbook.Names.Add(nm, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, "=" + shname + "!R" + Conversions.ToString(1) + "C" + Conversions.ToString(ncol), Missing.Value);
		}
	}

	public static bool xnFormat_zball(object lb, Workbook curwb)
	{
		bool result = true;
		cursh = (Worksheet)curwb.Worksheets["ALL"];
		cursh.Activate();
		checked
		{
			if (!check_zball())
			{
				result = false;
			}
			else
			{
				pzSearch();
				int num = 0;
				long num2 = pznum;
				for (long num3 = 0L; num3 <= num2; num3++)
				{
					object obj = curwb.Worksheets[jsshname];
					NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoFilter", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null);
					object[] array = new object[2] { pzcol, null };
					string[] array2 = pzlist;
					int num4 = (int)num3;
					array[1] = array2[num4];
					object[] array3 = array;
					object[] array4 = array3;
					string[] obj3 = new string[2] { "Field", "Criteria1" };
					bool[] array5 = new bool[2] { true, true };
					NewLateBinding.LateCall(obj2, (Type)null, "AutoFilter", array4, obj3, (Type[])null, array5, true);
					if (array5[0])
					{
						pzcol = (long)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(long));
					}
					if (array5[1])
					{
						array2[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(string));
					}
					obj = null;
					shALL = (Worksheet)curwb.Worksheets[jsshname];
					shALLTemp = (Worksheet)curwb.Worksheets["ALLTEMP"];
					shALLTemp.Cells.Delete(Missing.Value);
					shALL.Cells.Copy(((_Worksheet)shALLTemp).get_Range((object)"A1", (object)Missing.Value));
					jLZ = ((_Worksheet)shALL).get_Range((object)"LZ", (object)Missing.Value).Column;
					jRF = ((_Worksheet)shALL).get_Range((object)"RF", (object)Missing.Value).Column;
					jCOMB = ((_Worksheet)shALL).get_Range((object)"COMB", (object)Missing.Value).Column;
					jQ = ((_Worksheet)shALL).get_Range((object)"Destination_Q", (object)Missing.Value).Column;
					jPZ = ((_Worksheet)shALL).get_Range((object)"PZ", (object)Missing.Value).Column;
					ACOUNT = ((_Worksheet)shALLTemp).get_Range((object)"A1", (object)Missing.Value).CurrentRegion.Rows.Count;
					ALZ = new string[ACOUNT + 1];
					ACOMB = new string[ACOUNT + 1];
					ARF = new string[ACOUNT + 1];
					ADestination_Q = new string[ACOUNT + 1];
					APZ = new string[ACOUNT + 1];
					int aCOUNT = ACOUNT;
					for (int i = 2; i <= aCOUNT; i++)
					{
						ALZ[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jLZ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						ARF[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jRF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						ACOMB[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jCOMB], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						ADestination_Q[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jQ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						APZ[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jPZ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
					rfSearch(pzlist[(int)num3]);
					combSearch(pzlist[(int)num3], "COMB");
					lzSearch("LZ", pzlist[(int)num3]);
					string text = pzlist[(int)num3];
					if (SheetExists(text))
					{
						NewLateBinding.LateCall(Mod1.excelapp.Sheets[text], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						Mod1.excelapp.DisplayAlerts = true;
					}
					newsh = (Worksheet)curwb.Worksheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					newsh.Name = text;
					long num5 = rfnum;
					for (long num6 = 0L; num6 <= num5; num6++)
					{
						NewLateBinding.LateSetComplex(newsh.Cells[num6 + 2L, 1], (Type)null, "Value", new object[1] { rflist[(int)num6] }, (string[])null, (Type[])null, false, true);
					}
					long num7 = combnum;
					for (long num8 = 0L; num8 <= num7; num8++)
					{
						NewLateBinding.LateSetComplex(newsh.Cells[1, num8 + 2L], (Type)null, "Value", new object[1] { lzlist[(int)num8] }, (string[])null, (Type[])null, false, true);
						NewLateBinding.LateSetComplex(newsh.Cells[rfnum + 3L, num8 + 2L], (Type)null, "Value", new object[1] { comblist[(int)num8] }, (string[])null, (Type[])null, false, true);
					}
					newsh.Activate();
					Excel.Range currentRegion = ((_Worksheet)newsh).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
					currentRegion.get_Offset((object)1, (object)1).get_Resize((object)(currentRegion.Rows.Count - 2), (object)(currentRegion.Columns.Count - 1)).Select();
					NewLateBinding.LateSetComplex(Mod1.excelapp.Selection, (Type)null, "NumberFormatLocal", new object[1] { "0.0_ " }, (string[])null, (Type[])null, false, true);
					xnSearch_zball(pzlist[(int)num3], ref curwb);
					cursh.Activate();
					num++;
					PctDone = (float)((double)num / (double)(pznum + 1L));
				}
			}
			return result;
		}
	}

	public static object cha1split1(string ch)
	{
		long num = 1L;
		long num2 = 1L;
		if (Strings.Len(ch) != 1)
		{
			return 0;
		}
		long num3 = num;
		checked
		{
			while (true)
			{
				num3++;
				if (num3 == 65536L)
				{
					break;
				}
				string text = Conversions.ToString(NewLateBinding.LateGet(shALL.Cells[num3, num2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				if (Operators.CompareString(text, "", false) == 0)
				{
					break;
				}
				string[] array = Strings.Split(text, ch, -1, (CompareMethod)0);
				long num4 = num2 + 1L;
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					NewLateBinding.LateSetComplex(shALL.Cells[num3, num4], (Type)null, "Value", new object[1] { text2 }, (string[])null, (Type[])null, false, true);
					num4++;
				}
			}
			return num3 - num;
		}
	}

	public static bool bt1_SourceRF()
	{
		bool result = true;
		Excel.Range range = (Excel.Range)Mod1.excelapp.Selection;
		long num = Mod1.excelapp.ActiveCell.Column;
		long num2 = range.Columns.Count;
		checked
		{
			if (num2 != 1L)
			{
				result = false;
			}
			else
			{
				long num3 = Mod1.excelapp.ActiveCell.Row;
				long num4 = range.Rows.Count;
				if (num4 == shALL.Cells.Rows.Count)
				{
					num3 = 1L;
					num4 = Conversions.ToLong(NewLateBinding.LateGet(NewLateBinding.LateGet(shALL.Cells[shALL.Cells.Rows.Count, num], (Type)null, "End", new object[1] { XlDirection.xlUp }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
					range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[1L, num]), RuntimeHelpers.GetObjectValue(shALL.Cells[num4, num2 + num - 1L]));
				}
				else
				{
					range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num3, num]), RuntimeHelpers.GetObjectValue(shALL.Cells[num3 + num4 - 1L, num2 + num - 1L]));
				}
				range.Interior.ColorIndex = 36;
				SRF = new double[range.Rows.Count + 1, 2];
				int count = range.Rows.Count;
				for (int i = 1; i <= count; i++)
				{
					SRF[i, 1] = Convert.ToDouble(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(range.Cells[i, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null)));
				}
				SRFMAX = Mod1.excelapp.WorksheetFunction.Max(range, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				SRFMIN = Mod1.excelapp.WorksheetFunction.Min(range, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				SRFROW = num4;
			}
			return result;
		}
	}

	public static bool bt2_SourceQ()
	{
		bool result = true;
		Excel.Range range = (Excel.Range)Mod1.excelapp.Selection;
		long num = Mod1.excelapp.ActiveCell.Column;
		long num2 = range.Columns.Count;
		checked
		{
			if (num2 != 1L)
			{
				result = false;
			}
			else
			{
				long num3 = Mod1.excelapp.ActiveCell.Row;
				long num4 = (SQROW = range.Rows.Count);
				if (SRFROW != SQROW)
				{
					result = false;
				}
				else
				{
					if (num4 == shALL.Cells.Rows.Count)
					{
						num3 = 1L;
						num4 = Conversions.ToLong(NewLateBinding.LateGet(NewLateBinding.LateGet(shALL.Cells[shALL.Cells.Rows.Count, num], (Type)null, "End", new object[1] { XlDirection.xlUp }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[1L, num]), RuntimeHelpers.GetObjectValue(shALL.Cells[num4, num2 + num - 1L]));
					}
					else
					{
						range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num3, num]), RuntimeHelpers.GetObjectValue(shALL.Cells[num3 + num4 - 1L, num2 + num - 1L]));
					}
					range.Interior.ColorIndex = 36;
					SQ = new double[range.Rows.Count + 1, 2];
					int count = range.Rows.Count;
					for (int i = 1; i <= count; i++)
					{
						SQ[i, 1] = Conversions.ToDouble(NewLateBinding.LateGet(range.Cells[i, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					}
				}
			}
			return result;
		}
	}

	public static bool bt3_DestinationRF()
	{
		bool result = true;
		Excel.Range range = (Excel.Range)Mod1.excelapp.Selection;
		long num = Mod1.excelapp.ActiveCell.Column;
		long num2 = range.Columns.Count;
		checked
		{
			if (num2 != 1L)
			{
				bt3Destination = false;
			}
			else
			{
				long num3 = Mod1.excelapp.ActiveCell.Row;
				long num4 = range.Rows.Count;
				if (num4 == shALL.Cells.Rows.Count)
				{
					num3 = 1L;
					num4 = Conversions.ToLong(NewLateBinding.LateGet(NewLateBinding.LateGet(shALL.Cells[shALL.Cells.Rows.Count, num], (Type)null, "End", new object[1] { XlDirection.xlUp }, (string[])null, (Type[])null, (bool[])null), (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
					range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[1L, num]), RuntimeHelpers.GetObjectValue(shALL.Cells[num4, num2 + num - 1L]));
				}
				else
				{
					range = ((_Worksheet)shALL).get_Range(RuntimeHelpers.GetObjectValue(shALL.Cells[num3, num]), RuntimeHelpers.GetObjectValue(shALL.Cells[num3 + num4 - 1L, num2 + num - 1L]));
				}
				range.Interior.ColorIndex = 36;
				DRF = new double[range.Rows.Count + 1, 2];
				int count = range.Rows.Count;
				for (int i = 1; i <= count; i++)
				{
					DRF[i, 1] = Conversions.ToDouble(NewLateBinding.LateGet(range.Cells[i, 1], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
				DRFUBOUND = range.Rows.Count;
			}
			return result;
		}
	}

	public static void bt4_DestinationQ2()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		long num6 = default(long);
		long num7 = default(long);
		int dRFUBOUND = default(int);
		int num8 = default(int);
		object obj = default(object);
		object obj2 = default(object);
		long sRFROW = default(long);
		long num9 = default(long);
		int dRFUBOUND2 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 2075:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_001c;
							case 4:
								goto IL_0030;
							case 5:
								goto IL_0044;
							case 6:
							case 8:
								goto IL_0059;
							case 9:
								goto IL_006f;
							case 10:
								goto IL_0087;
							case 12:
							case 13:
								goto IL_008f;
							case 14:
								goto IL_00a5;
							case 16:
								goto IL_0132;
							case 17:
								goto IL_0148;
							case 19:
							case 20:
								goto IL_021b;
							case 21:
								goto IL_023a;
							case 24:
							case 25:
								goto IL_0249;
							case 26:
								goto IL_025a;
							case 31:
								goto IL_0280;
							case 32:
								goto IL_0284;
							case 29:
							case 30:
							case 36:
							case 40:
							case 41:
							case 42:
							case 43:
								goto IL_02a8;
							case 22:
								goto IL_02bf;
							case 27:
								goto IL_0380;
							case 33:
								goto IL_0441;
							case 34:
								goto IL_0498;
							case 37:
								goto IL_0559;
							case 38:
								goto IL_055d;
							case 11:
							case 15:
							case 18:
							case 23:
							case 28:
							case 35:
							case 39:
							case 44:
							case 45:
								goto IL_0619;
							case 46:
								goto IL_0628;
							case 47:
								goto IL_063b;
							case 48:
								goto IL_06a0;
							case 49:
								goto IL_0729;
							default:
								goto end_IL_0000;
							case 50:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0729:
						num = 49;
						num5++;
						goto IL_0733;
						IL_06a0:
						num = 48;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(shALL.Cells[num6, num7], (Type)null, "Offset", new object[2]
						{
							num5 - 1,
							0
						}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Interior", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { hongsei }, (string[])null, (Type[])null, false, true);
						goto IL_0729;
						IL_0009:
						num = 2;
						_ = (Excel.Range)Mod1.excelapp.Selection;
						goto IL_001c;
						IL_001c:
						num = 3;
						num7 = Mod1.excelapp.ActiveCell.Column;
						goto IL_0030;
						IL_0030:
						num = 4;
						num6 = Mod1.excelapp.ActiveCell.Row;
						goto IL_0044;
						IL_0044:
						num = 5;
						DQ = new double[DRFUBOUND + 1, 2];
						goto IL_0059;
						IL_0059:
						num = 8;
						dRFUBOUND = DRFUBOUND;
						num8 = 1;
						goto IL_0066;
						IL_0066:
						if (num8 <= dRFUBOUND)
						{
							goto IL_006f;
						}
						goto IL_0628;
						IL_006f:
						num = 9;
						obj = DRF[num8, 1];
						goto IL_0087;
						IL_0087:
						num = 10;
						obj2 = obj;
						goto IL_008f;
						IL_008f:
						num = 13;
						if (Operators.ConditionalCompareObjectLess(obj2, SRFMIN, false))
						{
							goto IL_00a5;
						}
						goto IL_0132;
						IL_00a5:
						num = 14;
						DQ[num8, 1] = Conversions.ToDouble(DQJS2(SRF[1, 1], SRF[2, 1], SRF[3, 1], SQ[1, 1], SQ[2, 1], SQ[3, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0619;
						IL_0132:
						num = 16;
						if (Operators.ConditionalCompareObjectGreater(obj2, SRFMAX, false))
						{
							goto IL_0148;
						}
						goto IL_021b;
						IL_0148:
						num = 17;
						DQ[num8, 1] = Conversions.ToDouble(DQJS2(SRF[(int)(SRFROW - 2L), 1], SRF[(int)(SRFROW - 1L), 1], SRF[(int)SRFROW, 1], SQ[(int)(SRFROW - 2L), 1], SQ[(int)(SRFROW - 1L), 1], SQ[(int)SRFROW, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0619;
						IL_021b:
						num = 20;
						sRFROW = SRFROW;
						num9 = 1L;
						goto IL_0231;
						IL_0231:
						if (num9 <= sRFROW)
						{
							goto IL_023a;
						}
						goto IL_0619;
						IL_023a:
						num = 21;
						if (num9 != SRFROW)
						{
							goto IL_0249;
						}
						goto IL_02bf;
						IL_02bf:
						num = 22;
						DQ[num8, 1] = Conversions.ToDouble(DQJS2(SRF[(int)(num9 - 2L), 1], SRF[(int)(num9 - 1L), 1], SRF[(int)num9, 1], SQ[(int)(num9 - 2L), 1], SQ[(int)(num9 - 1L), 1], SQ[(int)num9, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0619;
						IL_0249:
						num = 25;
						if (num9 == 1L)
						{
							goto IL_025a;
						}
						goto IL_0280;
						IL_025a:
						num = 26;
						if (!Operators.ConditionalCompareObjectGreaterEqual((object)SRF[(int)num9, 1], obj, false))
						{
							goto IL_02a8;
						}
						goto IL_0380;
						IL_0380:
						num = 27;
						DQ[num8, 1] = Conversions.ToDouble(DQJS2(SRF[(int)num9, 1], SRF[(int)(num9 + 1L), 1], SRF[(int)(num9 + 2L), 1], SQ[(int)num9, 1], SQ[(int)(num9 + 1L), 1], SQ[(int)(num9 + 2L), 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0619;
						IL_0280:
						num = 31;
						goto IL_0284;
						IL_0284:
						num = 32;
						if (!Operators.ConditionalCompareObjectGreaterEqual((object)SRF[(int)num9, 1], obj, false))
						{
							goto IL_02a8;
						}
						goto IL_0441;
						IL_02a8:
						num = 43;
						num9++;
						goto IL_0231;
						IL_0441:
						num = 33;
						if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject((object)SRF[(int)(num9 - 1L), 1], obj), Operators.SubtractObject((object)SRF[(int)(num9 + 2L), 1], obj), false))
						{
							goto IL_0498;
						}
						goto IL_0559;
						IL_0498:
						num = 34;
						DQ[num8, 1] = Conversions.ToDouble(DQJS2(SRF[(int)(num9 - 1L), 1], SRF[(int)num9, 1], SRF[(int)(num9 + 1L), 1], SQ[(int)(num9 - 1L), 1], SQ[(int)num9, 1], SQ[(int)(num9 + 1L), 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0619;
						IL_0559:
						num = 37;
						goto IL_055d;
						IL_055d:
						num = 38;
						DQ[num8, 1] = Conversions.ToDouble(DQJS2(SRF[(int)num9, 1], SRF[(int)(num9 + 1L), 1], SRF[(int)(num9 + 2L), 1], SQ[(int)num9, 1], SQ[(int)(num9 + 1L), 1], SQ[(int)(num9 + 2L), 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0619;
						IL_0619:
						num = 45;
						num8++;
						goto IL_0066;
						IL_0628:
						num = 46;
						dRFUBOUND2 = DRFUBOUND;
						num5 = 0;
						goto IL_0733;
						IL_0733:
						if (num5 > dRFUBOUND2)
						{
							goto end_IL_0000_2;
						}
						goto IL_063b;
						IL_063b:
						num = 47;
						NewLateBinding.LateSetComplex(shALL.Cells[num6, num7], (Type)null, "Offset", new object[3]
						{
							num5 - 1,
							0,
							DQ[num5, 1]
						}, (string[])null, (Type[])null, false, true);
						goto IL_06a0;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 2075;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static object DQJS2(object XX1, object XX2, object XX3, object YY1, object YY2, object YY3, object XX)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (Conversions.ToBoolean(Operators.OrObject(Operators.OrObject(Operators.CompareObjectLess(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(XX1, XX2) }, (string[])null, (Type[])null, (bool[])null), (object)1E-06, false), Operators.CompareObjectLess(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(XX1, XX3) }, (string[])null, (Type[])null, (bool[])null), (object)1E-06, false)), Operators.CompareObjectLess(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(XX2, XX3) }, (string[])null, (Type[])null, (bool[])null), (object)1E-06, false))))
		{
			Interaction.MsgBox((object)"请检查源幅度，可能出现相同的值", (MsgBoxStyle)0, (object)"提示");
			object result = default(object);
			return result;
		}
		double num = Conversions.ToDouble(XX1);
		double num2 = Conversions.ToDouble(XX2);
		double num3 = Conversions.ToDouble(XX3);
		double num4 = Conversions.ToDouble(YY1);
		double num5 = Conversions.ToDouble(YY2);
		double num6 = Conversions.ToDouble(YY3);
		double num7 = Conversions.ToDouble(XX);
		double num8 = (num7 - num2) * (num7 - num3) / (num - num2) / (num - num3) * num4;
		double num9 = (num7 - num) * (num7 - num3) / (num2 - num) / (num2 - num3) * num5;
		double num10 = (num7 - num) * (num7 - num2) / (num3 - num) / (num3 - num2) * num6;
		return num8 + num9 + num10;
	}

	public static bool check_zball()
	{
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[9] { "LZ", "RF", "COMB", "Destination_Q", "Source_RF", "Source_Q", "Destination_RF", "delt_X", "PZ" };
		int num = 0;
		checked
		{
			do
			{
				if (RangeNameExists(array[num]))
				{
					num++;
					continue;
				}
				Interaction.MsgBox((object)("当前活动工作簿中没有定义有效的单元格名称 " + array[num] + " 需要先执行菜单栏中RF_QEnhance/Q_JS."), (MsgBoxStyle)0, (object)"提示");
				return false;
			}
			while (num <= 8);
			IEnumerator enumerator = default(IEnumerator);
			int num2 = default(int);
			try
			{
				enumerator = Mod1.excelapp.ActiveWorkbook.Names.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Name name = (Name)enumerator.Current;
					num2++;
					string text = name.Name.ToUpper();
					if (Operators.CompareString(text, "COMB".ToUpper(), false) == 0)
					{
						break;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (num2 != 0)
			{
				num2--;
			}
			string text2 = Conversions.ToString(NewLateBinding.LateGet(Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(num2), (Type)null, "RefersTo", new object[0], (string[])null, (Type[])null, (bool[])null));
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = Mod1.excelapp.ActiveWorkbook.Names.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Name name2 = (Name)enumerator2.Current;
					num2++;
					string text = name2.Name.ToUpper();
					if (Operators.CompareString(text, "Destination_Q".ToUpper(), false) == 0)
					{
						break;
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			if (num2 != 0)
			{
				num2--;
			}
			string text3 = Conversions.ToString(NewLateBinding.LateGet(Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(num2), (Type)null, "RefersTo", new object[0], (string[])null, (Type[])null, (bool[])null));
			string[] array2 = Strings.Split(text2, "!", -1, (CompareMethod)0);
			string[] array3 = Strings.Split(text3, "!", -1, (CompareMethod)0);
			if (Operators.CompareString(array2[0], array3[0], false) != 0)
			{
				Interaction.MsgBox((object)("当前活动工作簿中没有定义有效的单元格名称 " + array[num] + " 需要在【基本计算数据表】中执行菜单栏的RF_QEnhance3/Q_JS."), (MsgBoxStyle)0, (object)"提示");
				return false;
			}
			jsshname = Strings.Right(array2[0], Strings.Len(array2[0]) - 1);
			string text4 = Strings.UCase(jsshname);
			Type typeFromHandle = typeof(Strings);
			object[] array4 = new object[1];
			object activeSheet = Mod1.excelapp.ActiveSheet;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(activeSheet, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array5 = array4;
			bool[] array6 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array5, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				NewLateBinding.LateSetComplex(activeSheet, (Type)null, "Name", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (Operators.ConditionalCompareObjectNotEqual((object)text4, obj, false))
			{
				Interaction.MsgBox((object)("当前活动工作表单元格名称定义的工作表，需要激活含有单元格名称定义的数据表：" + jsshname), (MsgBoxStyle)0, (object)"提示");
				return false;
			}
			return true;
		}
	}

	public static void rfSearch(string pz)
	{
		checked
		{
			rflist = new string[ACOUNT + 1];
			int num = -1;
			int aCOUNT = ACOUNT;
			for (int i = 2; i <= aCOUNT; i++)
			{
				bool flag = false;
				if (num > -1)
				{
					int num2 = num;
					for (int j = 0; j <= num2; j++)
					{
						if (Operators.CompareString(ARF[i], rflist[j], false) == 0)
						{
							flag = true;
						}
					}
				}
				if (!flag & (Operators.CompareString(pz, APZ[i], false) == 0))
				{
					num++;
					rflist[num] = ARF[i];
				}
			}
			rfnum = num;
			rflist = (string[])Utils.CopyArray((Array)rflist, (Array)new string[(int)rfnum + 1]);
			BubbleSort(rflist);
		}
	}

	public static void bt4_DestinationQ()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		long num6 = default(long);
		long num7 = default(long);
		int dRFUBOUND = default(int);
		int num8 = default(int);
		object obj = default(object);
		object obj2 = default(object);
		long sRFROW = default(long);
		long num9 = default(long);
		int dRFUBOUND2 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0009;
					case 1265:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0009;
							case 3:
								goto IL_001c;
							case 4:
								goto IL_0030;
							case 5:
								goto IL_0044;
							case 6:
							case 8:
								goto IL_0059;
							case 9:
								goto IL_006f;
							case 10:
								goto IL_0087;
							case 12:
							case 13:
								goto IL_008f;
							case 14:
								goto IL_00a2;
							case 16:
								goto IL_010d;
							case 17:
								goto IL_0123;
							case 19:
							case 20:
								goto IL_01b6;
							case 21:
								goto IL_01d5;
							case 28:
							case 29:
								goto IL_01e4;
							case 24:
							case 25:
								goto IL_01f8;
							case 22:
								goto IL_021e;
							case 26:
								goto IL_02a5;
							case 11:
							case 15:
							case 18:
							case 23:
							case 27:
							case 30:
							case 31:
								goto IL_0327;
							case 32:
								goto IL_0336;
							case 33:
								goto IL_0349;
							case 34:
								goto IL_03ae;
							case 35:
								goto IL_0437;
							default:
								goto end_IL_0000;
							case 36:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_0437:
						num = 35;
						num5++;
						goto IL_0441;
						IL_03ae:
						num = 34;
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(shALL.Cells[num6, num7], (Type)null, "Offset", new object[2]
						{
							num5 - 1,
							0
						}, (string[])null, (Type[])null, (bool[])null), (Type)null, "Interior", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { hongsei }, (string[])null, (Type[])null, false, true);
						goto IL_0437;
						IL_0009:
						num = 2;
						_ = (Excel.Range)Mod1.excelapp.Selection;
						goto IL_001c;
						IL_001c:
						num = 3;
						num7 = Mod1.excelapp.ActiveCell.Column;
						goto IL_0030;
						IL_0030:
						num = 4;
						num6 = Mod1.excelapp.ActiveCell.Row;
						goto IL_0044;
						IL_0044:
						num = 5;
						DQ = new double[DRFUBOUND + 1, 2];
						goto IL_0059;
						IL_0059:
						num = 8;
						dRFUBOUND = DRFUBOUND;
						num8 = 1;
						goto IL_0066;
						IL_0066:
						if (num8 <= dRFUBOUND)
						{
							goto IL_006f;
						}
						goto IL_0336;
						IL_006f:
						num = 9;
						obj = DRF[num8, 1];
						goto IL_0087;
						IL_0087:
						num = 10;
						obj2 = obj;
						goto IL_008f;
						IL_008f:
						num = 13;
						if (Operators.ConditionalCompareObjectLess(obj2, SRFMIN, false))
						{
							goto IL_00a2;
						}
						goto IL_010d;
						IL_00a2:
						num = 14;
						DQ[num8, 1] = Conversions.ToDouble(DQJS(SRF[1, 1], SRF[2, 1], SQ[1, 1], SQ[2, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0327;
						IL_010d:
						num = 16;
						if (Operators.ConditionalCompareObjectGreater(obj2, SRFMAX, false))
						{
							goto IL_0123;
						}
						goto IL_01b6;
						IL_0123:
						num = 17;
						DQ[num8, 1] = Conversions.ToDouble(DQJS(SRF[(int)(SRFROW - 1L), 1], SRF[(int)SRFROW, 1], SQ[(int)(SRFROW - 1L), 1], SQ[(int)SRFROW, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0327;
						IL_01b6:
						num = 20;
						sRFROW = SRFROW;
						num9 = 1L;
						goto IL_01cc;
						IL_01cc:
						if (num9 <= sRFROW)
						{
							goto IL_01d5;
						}
						goto IL_0327;
						IL_01d5:
						num = 21;
						if (num9 != SRFROW)
						{
							goto IL_01f8;
						}
						goto IL_021e;
						IL_021e:
						num = 22;
						DQ[num8, 1] = Conversions.ToDouble(DQJS(SRF[(int)(num9 - 1L), 1], SRF[(int)num9, 1], SQ[(int)(num9 - 1L), 1], SQ[(int)num9, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0327;
						IL_01f8:
						num = 25;
						if (!Operators.ConditionalCompareObjectGreater((object)SRF[(int)num9, 1], obj, false))
						{
							goto IL_01e4;
						}
						goto IL_02a5;
						IL_02a5:
						num = 26;
						DQ[num8, 1] = Conversions.ToDouble(DQJS(SRF[(int)(num9 - 1L), 1], SRF[(int)num9, 1], SQ[(int)(num9 - 1L), 1], SQ[(int)num9, 1], RuntimeHelpers.GetObjectValue(obj)));
						goto IL_0327;
						IL_01e4:
						num = 29;
						num9++;
						goto IL_01cc;
						IL_0327:
						num = 31;
						num8++;
						goto IL_0066;
						IL_0336:
						num = 32;
						dRFUBOUND2 = DRFUBOUND;
						num5 = 1;
						goto IL_0441;
						IL_0441:
						if (num5 > dRFUBOUND2)
						{
							goto end_IL_0000_2;
						}
						goto IL_0349;
						IL_0349:
						num = 33;
						NewLateBinding.LateSetComplex(shALL.Cells[num6, num7], (Type)null, "Offset", new object[3]
						{
							num5 - 1,
							0,
							DQ[num5, 1]
						}, (string[])null, (Type[])null, false, true);
						goto IL_03ae;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj3) when (obj3 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj3);
				try0000_dispatch = 1265;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static object DQJS(object XX1, object XX2, object YY1, object YY2, object XX)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet((object)null, typeof(Math), "Abs", new object[1] { Operators.SubtractObject(XX1, XX2) }, (string[])null, (Type[])null, (bool[])null), (object)1E-06, false))
		{
			Interaction.MsgBox((object)"请检查源幅度，可能出现相同的值", (MsgBoxStyle)0, (object)"提示");
			object result = default(object);
			return result;
		}
		double num = Conversions.ToDouble(Operators.DivideObject(Operators.SubtractObject(YY1, YY2), Operators.SubtractObject(XX1, XX2)));
		return Operators.AddObject(Operators.MultiplyObject((object)num, Operators.SubtractObject(XX, XX1)), YY1);
	}

	public static void combSearch(string pz, string comb)
	{
		checked
		{
			comblist = new string[ACOUNT + 1];
			combrowi = new long[ACOUNT + 1];
			int num;
			if (Operators.CompareString(comb, "COMB", false) == 0)
			{
				num = -1;
				int aCOUNT = ACOUNT;
				for (int i = 2; i <= aCOUNT; i++)
				{
					bool flag = false;
					if (num > -1)
					{
						int num2 = num;
						for (int j = 0; j <= num2; j++)
						{
							if (Operators.CompareString(ACOMB[i], comblist[j], false) == 0)
							{
								flag = true;
							}
						}
					}
					if (!flag & (Operators.CompareString(pz, APZ[i], false) == 0))
					{
						num++;
						comblist[num] = ACOMB[i];
						combrowi[num] = i;
					}
				}
				combnum = num;
				comblist = (string[])Utils.CopyArray((Array)comblist, (Array)new string[(int)combnum + 1]);
				combrowi = (long[])Utils.CopyArray((Array)combrowi, (Array)new long[(int)combnum + 1]);
				BubbleSortComb(comblist);
				return;
			}
			num = -1;
			int aCOUNT2 = ACOUNT;
			for (int k = 2; k <= aCOUNT2; k++)
			{
				bool flag = false;
				if (num > -1)
				{
					int num3 = num;
					for (int l = 0; l <= num3; l++)
					{
						if (Operators.CompareString(ACOMBF[k], comblist[l], false) == 0)
						{
							flag = true;
						}
					}
				}
				if (!flag & (Operators.CompareString(pz, APZ[k], false) == 0))
				{
					num++;
					comblist[num] = ACOMBF[k];
					combrowi[num] = k;
				}
			}
			combnum = num;
			comblist = (string[])Utils.CopyArray((Array)comblist, (Array)new string[(int)combnum + 1]);
			combrowi = (long[])Utils.CopyArray((Array)combrowi, (Array)new long[(int)combnum + 1]);
			BubbleSortComb(comblist);
		}
	}

	public static void BubbleSortComb(string[] list)
	{
		long num = Information.LBound((Array)list, 1);
		long num2 = Information.UBound((Array)list, 1);
		checked
		{
			long num3 = num2 - 1L;
			for (long num4 = num; num4 <= num3; num4++)
			{
				long num5 = num4 + 1L;
				long num6 = num2;
				for (long num7 = num5; num7 <= num6; num7++)
				{
					if (sumPosition(list[(int)num4]) >= sumPosition(list[(int)num7]))
					{
						object obj = list[(int)num7];
						list[(int)num7] = list[(int)num4];
						list[(int)num4] = Conversions.ToString(obj);
					}
				}
			}
		}
	}

	public static int sumPosition(string curStr)
	{
		long num = Strings.Len(curStr);
		checked
		{
			long[] array = new long[(int)num + 1];
			long num2 = num;
			long num4 = default(long);
			for (long num3 = 1L; num3 <= num2; num3++)
			{
				array[(int)num3] = Conversions.ToInteger(Strings.Mid(curStr, (int)num3, 1));
				num4 += array[(int)num3];
			}
			return (int)num4;
		}
	}

	public static void lzSearch(string lz, string pz)
	{
		checked
		{
			lzlist = new string[(int)combnum + 1];
			if (Operators.CompareString(lz.ToUpper(), "LZ", false) == 0)
			{
				long num = combnum;
				for (long num2 = 0L; num2 <= num; num2++)
				{
					lzlist[(int)num2] = ALZ[(int)combrowi[(int)num2]];
				}
				BubbleSort(lzlist);
			}
			else
			{
				long num3 = combnum;
				for (long num4 = 0L; num4 <= num3; num4++)
				{
					lzlist[(int)num4] = ALF[(int)combrowi[(int)num4]];
				}
				BubbleSort(lzlist);
			}
		}
	}

	public static void BubbleSort(string[] list)
	{
		long num = Information.LBound((Array)list, 1);
		long num2 = Information.UBound((Array)list, 1);
		checked
		{
			long num3 = num2 - 1L;
			for (long num4 = num; num4 <= num3; num4++)
			{
				long num5 = num4 + 1L;
				long num6 = num2;
				for (long num7 = num5; num7 <= num6; num7++)
				{
					if (Conversions.ToSingle(list[(int)num4]) > Conversions.ToSingle(list[(int)num7]))
					{
						object obj = list[(int)num7];
						list[(int)num7] = list[(int)num4];
						list[(int)num4] = Conversions.ToString(obj);
					}
				}
			}
		}
	}

	public static void xnSearch_zball(string pz, ref Workbook wb)
	{
		int num = 1;
		int num2 = 1;
		Conversions.ToString(NewLateBinding.LateGet(Mod1.excelapp.ActiveSheet, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
		Excel.Range currentRegion = ((_Worksheet)newsh).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
		int count = currentRegion.Rows.Count;
		Application.DoEvents();
		int num3 = 0;
		Conversions.ToInteger(NewLateBinding.LateGet(Mod1.excelapp.Selection, (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)Mod1.excelapp.Selection).GetEnumerator();
				float num10 = default(float);
				int num11 = default(int);
				while (enumerator.MoveNext())
				{
					Excel.Range range = (Excel.Range)enumerator.Current;
					blfind = false;
					num3++;
					float num4 = Conversions.ToSingle(NewLateBinding.LateGet(newsh.Cells[num, range.Column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					float num5 = Conversions.ToSingle(NewLateBinding.LateGet(newsh.Cells[range.Row, num2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					float num6 = Conversions.ToSingle(NewLateBinding.LateGet(newsh.Cells[count, range.Column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (!((Operators.CompareString(num4.ToString(), "", false) != 0) & (Operators.CompareString(num5.ToString(), "", false) != 0) & (Operators.CompareString(num6.ToString(), "", false) != 0)))
					{
						continue;
					}
					int aCOUNT = ACOUNT;
					for (int i = 2; i <= aCOUNT; i++)
					{
						float num7 = Conversions.ToSingle(ALZ[i]);
						float num8 = Conversions.ToSingle(ARF[i]);
						float num9 = Conversions.ToSingle(ACOMB[i]);
						if ((double)Math.Abs(num6 - num9) < 1E-06 && (((double)Math.Abs(num5 - num8) < 1E-06) & ((double)Math.Abs(num4 - num7) < 1E-06)))
						{
							num10 = Conversions.ToSingle(ADestination_Q[i]);
							blfind = true;
							break;
						}
					}
					if (blfind)
					{
						NewLateBinding.LateSetComplex(range.Cells[num11 + 1, 1], (Type)null, "Value", new object[1] { num10 }, (string[])null, (Type[])null, false, true);
					}
					num10 = 0f;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}

	public static bool xnFormat_bffball(object lb, string yxflag, Workbook curwb)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		cursh = (Worksheet)curwb.Worksheets["ALL"];
		cursh.Activate();
		checked
		{
			if (!check_bffball())
			{
				result = false;
			}
			else
			{
				if (Operators.CompareString(Strings.Trim(yxflag), "", false) == 0)
				{
					yxflag = "LZ";
				}
				curbcname = Strings.UCase(yxflag);
				if ((Operators.CompareString(curbcname, "LZ", false) == 0) | (Operators.CompareString(curbcname, "LF", false) == 0))
				{
					if (!RangeNameExists(curbcname))
					{
						Interaction.MsgBox((object)("指定的臂长列所在单元格名称:" + curbcname + "不存在,当前格式无效,退出!"), (MsgBoxStyle)0, (object)"提示");
						result = false;
					}
					else
					{
						pzSearch();
						int num = 0;
						long num2 = pznum;
						string text = default(string);
						IEnumerator enumerator = default(IEnumerator);
						int num7 = default(int);
						for (long num3 = 0L; num3 <= num2; num3++)
						{
							object obj = curwb.Worksheets[jsshname];
							NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoFilter", new object[0], (string[])null, (Type[])null, (bool[])null, true);
							object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null);
							object[] array = new object[2] { pzcol, null };
							object[] array2 = array;
							string[] array3 = pzlist;
							string[] array4 = array3;
							int num4 = (int)num3;
							array2[1] = array4[num4];
							object[] array5 = array;
							object[] array6 = array5;
							string[] obj3 = new string[2] { "Field", "Criteria1" };
							bool[] array7 = new bool[2] { true, true };
							NewLateBinding.LateCall(obj2, (Type)null, "AutoFilter", array6, obj3, (Type[])null, array7, true);
							if (array7[0])
							{
								pzcol = (long)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(long));
							}
							if (array7[1])
							{
								array3[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(string));
							}
							obj = null;
							shALL = (Worksheet)curwb.Worksheets[jsshname];
							shALLTemp = (Worksheet)curwb.Worksheets["ALLTEMP"];
							shALLTemp.Cells.Delete(Missing.Value);
							shALL.Cells.Copy(((_Worksheet)shALLTemp).get_Range((object)"A1", (object)Missing.Value));
							jLZ = ((_Worksheet)shALL).get_Range((object)"LZ", (object)Missing.Value).Column;
							jRF = ((_Worksheet)shALL).get_Range((object)"RF", (object)Missing.Value).Column;
							jCOMB = ((_Worksheet)shALL).get_Range((object)"COMB", (object)Missing.Value).Column;
							jQ = ((_Worksheet)shALL).get_Range((object)"Destination_Q", (object)Missing.Value).Column;
							jPZ = ((_Worksheet)shALL).get_Range((object)"PZ", (object)Missing.Value).Column;
							jLF = ((_Worksheet)shALL).get_Range((object)"LF", (object)Missing.Value).Column;
							jCOMBF = ((_Worksheet)shALL).get_Range((object)"COMBF", (object)Missing.Value).Column;
							ACOUNT = ((_Worksheet)shALLTemp).get_Range((object)"A1", (object)Missing.Value).CurrentRegion.Rows.Count;
							ALZ = new string[ACOUNT + 1];
							ACOMB = new string[ACOUNT + 1];
							ARF = new string[ACOUNT + 1];
							ADestination_Q = new string[ACOUNT + 1];
							APZ = new string[ACOUNT + 1];
							ALF = new string[ACOUNT + 1];
							ACOMBF = new string[ACOUNT + 1];
							int aCOUNT = ACOUNT;
							for (int i = 2; i <= aCOUNT; i++)
							{
								ALZ[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jLZ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								ARF[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jRF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								ACOMB[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jCOMB], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								ADestination_Q[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jQ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								APZ[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jPZ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								ALF[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jLF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								ACOMBF[i] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[i, jCOMBF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
							}
							rfSearch(pzlist[(int)num3]);
							if (Operators.CompareString(Strings.UCase(yxflag), "LZ", false) == 0)
							{
								combSearch(pzlist[(int)num3], "COMB");
								lzSearch("LZ", pzlist[(int)num3]);
							}
							else
							{
								combSearch(pzlist[(int)num3], "COMBF");
								lzSearch("LF", pzlist[(int)num3]);
							}
							curlzlist = new string[(int)combnum + 1];
							curcomblist = new string[(int)combnum + 1];
							curlzlist = lzlist;
							curcomblist = comblist;
							curcombcol = combcol;
							curcombnum = combnum;
							long num5 = curcombnum;
							for (long num6 = 0L; num6 <= num5; num6++)
							{
								curbc = curlzlist[(int)num6];
								object obj4 = curwb.Worksheets[jsshname];
								NewLateBinding.LateCall(NewLateBinding.LateGet(obj4, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "AutoFilter", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null);
								array = new object[2] { pzcol, null };
								object[] array8 = array;
								string[] array9 = pzlist;
								string[] array10 = array9;
								num4 = (int)num3;
								array8[1] = array10[num4];
								object[] array11 = array;
								object[] array12 = array11;
								string[] obj6 = new string[2] { "Field", "Criteria1" };
								array7 = new bool[2] { true, true };
								NewLateBinding.LateCall(obj5, (Type)null, "AutoFilter", array12, obj6, (Type[])null, array7, true);
								if (array7[0])
								{
									pzcol = (long)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(long));
								}
								if (array7[1])
								{
									array9[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[1]), typeof(string));
								}
								object obj7 = NewLateBinding.LateGet(obj4, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null);
								object[] array13 = new object[2];
								object obj8 = obj4;
								array11 = new object[1] { curbcname };
								object[] array14 = array11;
								array9 = null;
								string[] array15 = array9;
								array7 = new bool[1] { true };
								object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "Range", array14, array15, (Type[])null, array7);
								bool[] array16 = array7;
								num4 = 0;
								if (array16[0])
								{
									text = (curbcname = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(string)));
								}
								array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj9, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null));
								array13[1] = curbc;
								object[] array17 = array13;
								string[] obj10 = new string[2] { "Field", "Criteria1" };
								bool[] array18 = new bool[2] { true, true };
								NewLateBinding.LateCall(obj7, (Type)null, "AutoFilter", array17, obj10, (Type[])null, array18, true);
								if (array18[0])
								{
									object obj11 = NewLateBinding.LateGet(obj8, (Type)null, "Range", array11, array9, (Type[])null, new bool[1] { true });
									if (array16[num4])
									{
										curbcname = text;
									}
									NewLateBinding.LateSetComplex(obj11, (Type)null, "Column", new object[1] { RuntimeHelpers.GetObjectValue(array17[0]) }, (string[])null, (Type[])null, true, true);
								}
								if (array18[1])
								{
									curbc = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array17[1]), typeof(string));
								}
								obj4 = null;
								shALL = (Worksheet)curwb.Worksheets[jsshname];
								shALLTemp = (Worksheet)curwb.Worksheets["ALLTEMP"];
								shALLTemp.Cells.Delete(Missing.Value);
								shALL.Cells.Copy(((_Worksheet)shALLTemp).get_Range((object)"A1", (object)Missing.Value));
								ACOUNT = ((_Worksheet)shALLTemp).get_Range((object)"A1", (object)Missing.Value).CurrentRegion.Rows.Count;
								ALZ = new string[ACOUNT + 1];
								ACOMB = new string[ACOUNT + 1];
								ARF = new string[ACOUNT + 1];
								ADestination_Q = new string[ACOUNT + 1];
								APZ = new string[ACOUNT + 1];
								ALF = new string[ACOUNT + 1];
								ACOMBF = new string[ACOUNT + 1];
								int aCOUNT2 = ACOUNT;
								for (int j = 2; j <= aCOUNT2; j++)
								{
									ALZ[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jLZ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
									ARF[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jRF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
									ACOMB[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jCOMB], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
									ADestination_Q[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jQ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
									APZ[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jPZ], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
									ALF[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jLF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
									ACOMBF[j] = Conversions.ToString(NewLateBinding.LateGet(shALLTemp.Cells[j, jCOMBF], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
								}
								if (Operators.CompareString(Strings.UCase(yxflag), "LZ", false) == 0)
								{
									combSearch2(pzlist[(int)num3], "COMBF", curcomblist[(int)num6], yxflag);
									lzSearch("LF", pzlist[(int)num3]);
								}
								else
								{
									combSearch2(pzlist[(int)num3], "COMB", curcomblist[(int)num6], yxflag);
									lzSearch("LZ", pzlist[(int)num3]);
								}
								string text2 = pzlist[(int)num3] + "_" + curlzlist[(int)num6];
								if (SheetExists(text2))
								{
									Mod1.excelapp.DisplayAlerts = false;
									try
									{
										enumerator = Mod1.excelapp.ActiveWorkbook.Names.GetEnumerator();
										while (enumerator.MoveNext())
										{
											Name name = (Name)enumerator.Current;
											num7++;
											if (Operators.CompareString(text2, name.Name.ToUpper(), false) == 0)
											{
												break;
											}
										}
									}
									finally
									{
										if (enumerator is IDisposable)
										{
											(enumerator as IDisposable).Dispose();
										}
									}
									NewLateBinding.LateCall(Mod1.excelapp.Worksheets[num7], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
									Mod1.excelapp.DisplayAlerts = true;
								}
								newsh = (Worksheet)Mod1.excelapp.Sheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								newsh.Name = text2;
								long num8 = rfnum;
								for (long num9 = 0L; num9 <= num8; num9++)
								{
									newsh.Cells[num9 + 2L, 1] = rflist[(int)num9];
								}
								long num10 = combnum;
								for (long num11 = 0L; num11 <= num10; num11++)
								{
									newsh.Cells[1, num11 + 2L] = lzlist[(int)num11];
									newsh.Cells[rfnum + 3L, num11 + 2L] = comblist[(int)num11];
								}
								newsh.Activate();
								Excel.Range currentRegion = ((_Worksheet)newsh).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
								currentRegion.get_Offset((object)1, (object)1).get_Resize((object)(currentRegion.Rows.Count - 2), (object)(currentRegion.Columns.Count - 1)).Select();
								NewLateBinding.LateSetComplex(Mod1.excelapp.Selection, (Type)null, "NumberFormatLocal", new object[1] { "0.0_ " }, (string[])null, (Type[])null, false, true);
								xnSearch_bffball(pzlist[(int)num3], curwb);
								cursh.Activate();
								num++;
								PctDone = (float)((double)num / (double)((pznum + 1L) * (curcombnum + 1L)));
							}
						}
					}
				}
				else
				{
					Interaction.MsgBox((object)"当前优先选项标识只能为LF或LZ,退出!", (MsgBoxStyle)0, (object)"提示");
					result = false;
				}
			}
			return result;
		}
	}

	public static bool check_bffball()
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		string[] array = new string[11]
		{
			"LZ", "RF", "COMB", "Destination_Q", "Source_RF", "Source_Q", "Destination_RF", "delt_X", "LF", "COMBF",
			"PZ"
		};
		int num = 0;
		checked
		{
			do
			{
				if (RangeNameExists(array[num]))
				{
					num++;
					continue;
				}
				Interaction.MsgBox((object)("当前活动工作簿中没有定义有效的单元格名称 " + array[num] + " 需要先执行菜单栏中RF_QEnhance3/Q_JS."), (MsgBoxStyle)0, (object)"提示");
				return false;
			}
			while (num <= 10);
			IEnumerator enumerator = default(IEnumerator);
			int num2 = default(int);
			try
			{
				enumerator = Mod1.excelapp.ActiveWorkbook.Names.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Name name = (Name)enumerator.Current;
					num2++;
					string text = name.Name.ToUpper();
					if (Operators.CompareString(text, "COMB".ToUpper(), false) == 0)
					{
						break;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			if (num2 != 0)
			{
				num2--;
			}
			string text2 = Conversions.ToString(NewLateBinding.LateGet(Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(num2), (Type)null, "RefersTo", new object[0], (string[])null, (Type[])null, (bool[])null));
			IEnumerator enumerator2 = default(IEnumerator);
			try
			{
				enumerator2 = Mod1.excelapp.ActiveWorkbook.Names.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					Name name2 = (Name)enumerator2.Current;
					num2++;
					string text = name2.Name.ToUpper();
					if (Operators.CompareString(text, "Destination_Q".ToUpper(), false) == 0)
					{
						break;
					}
				}
			}
			finally
			{
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			if (num2 != 0)
			{
				num2--;
			}
			string text3 = Conversions.ToString(NewLateBinding.LateGet(Mod1.excelapp.ActiveWorkbook.Names.Cast<object>().ElementAtOrDefault(num2), (Type)null, "RefersTo", new object[0], (string[])null, (Type[])null, (bool[])null));
			string[] array2 = Strings.Split(text2, "!", -1, (CompareMethod)0);
			string[] array3 = Strings.Split(text3, "!", -1, (CompareMethod)0);
			if (Operators.CompareString(array2[0], array3[0], false) != 0)
			{
				Interaction.MsgBox((object)("当前活动工作簿中没有定义有效的单元格名称 " + array[num] + " 需要在【基本计算数据表】中执行菜单栏的RF_QEnhance/Q_JS."), (MsgBoxStyle)0, (object)"提示");
				return false;
			}
			jsshname = Strings.Right(array2[0], Strings.Len(array2[0]) - 1);
			string text4 = Strings.UCase(jsshname);
			Type typeFromHandle = typeof(Strings);
			object[] array4 = new object[1];
			object activeSheet = Mod1.excelapp.ActiveSheet;
			array4[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(activeSheet, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array5 = array4;
			bool[] array6 = new bool[1] { true };
			object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array5, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				NewLateBinding.LateSetComplex(activeSheet, (Type)null, "Name", new object[1] { RuntimeHelpers.GetObjectValue(array5[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (Operators.ConditionalCompareObjectNotEqual((object)text4, obj, false))
			{
				Interaction.MsgBox((object)("当前活动工作表单元格名称定义的工作表，需要激活含有单元格名称定义的数据表：" + jsshname), (MsgBoxStyle)0, (object)"提示");
				return false;
			}
			return true;
		}
	}

	public static void pzSearch()
	{
		pzcol = ((_Worksheet)cursh).get_Range((object)"PZ", (object)Missing.Value).Column;
		pzrows = ((_Worksheet)cursh).get_Range((object)"PZ", (object)Missing.Value).CurrentRegion.Rows.Count;
		checked
		{
			pzlist = new string[(int)pzrows + 1];
			if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(cursh.Cells[2, pzcol], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) == 0)
			{
				NewLateBinding.LateSetComplex(cursh.Cells[2, pzcol], (Type)null, "Value", new object[1] { "PZ" }, (string[])null, (Type[])null, false, true);
			}
			pzlist[0] = Conversions.ToString(NewLateBinding.LateGet(cursh.Cells[2, pzcol], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
			int num = 0;
			long num2 = pzrows;
			for (long num3 = 3L; num3 <= num2; num3++)
			{
				if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(cursh.Cells[num3, pzcol], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) == 0)
				{
					NewLateBinding.LateSetComplex(cursh.Cells[num3, pzcol], (Type)null, "Value", new object[1] { "PZ" }, (string[])null, (Type[])null, false, true);
				}
				bool flag = false;
				int num4 = num;
				for (int i = 0; i <= num4; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(cursh.Cells[num3, pzcol], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)pzlist[i], false))
					{
						flag = true;
					}
				}
				if (!flag)
				{
					num++;
					pzlist = (string[])Utils.CopyArray((Array)pzlist, (Array)new string[num + 1]);
					pzlist[num] = Conversions.ToString(NewLateBinding.LateGet(cursh.Cells[num3, pzcol], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
				}
			}
			pznum = num;
			pzlist = (string[])Utils.CopyArray((Array)pzlist, (Array)new string[(int)pznum + 1]);
		}
	}

	public static void combSearch2(string pz, string comb, string curcomb, string yx)
	{
		checked
		{
			comblist = new string[ACOUNT + 1];
			combrowi = new long[ACOUNT + 1];
			int num;
			if (Operators.CompareString(comb.ToUpper(), "COMB", false) == 0)
			{
				num = -1;
				int aCOUNT = ACOUNT;
				for (int i = 2; i <= aCOUNT; i++)
				{
					bool flag = false;
					if (num > -1)
					{
						int num2 = num;
						for (int j = 0; j <= num2; j++)
						{
							if (Operators.CompareString(ACOMB[i], comblist[j], false) == 0)
							{
								flag = true;
							}
						}
					}
					if (Operators.CompareString(yx.ToUpper(), "LZ", false) == 0)
					{
						if (!flag & (Operators.CompareString(pz, APZ[i], false) == 0) & (Operators.CompareString(curcomb, ACOMB[i], false) == 0))
						{
							num++;
							comblist[num] = ACOMB[i];
							combrowi[num] = i;
						}
					}
					else if (!flag & (Operators.CompareString(pz, APZ[i], false) == 0) & (Operators.CompareString(curcomb, ACOMBF[i], false) == 0))
					{
						num++;
						comblist[num] = ACOMB[i];
						combrowi[num] = i;
					}
				}
				combnum = num;
				comblist = (string[])Utils.CopyArray((Array)comblist, (Array)new string[(int)combnum + 1]);
				combrowi = (long[])Utils.CopyArray((Array)combrowi, (Array)new long[(int)combnum + 1]);
				BubbleSortComb(comblist);
				return;
			}
			num = -1;
			int aCOUNT2 = ACOUNT;
			for (int k = 2; k <= aCOUNT2; k++)
			{
				bool flag = false;
				if (num > -1)
				{
					int num3 = num;
					for (int l = 0; l <= num3; l++)
					{
						if (Operators.CompareString(ACOMBF[k], comblist[l], false) == 0)
						{
							flag = true;
						}
					}
				}
				if (Operators.CompareString(yx.ToUpper(), "LZ", false) == 0)
				{
					if (!flag & (Operators.CompareString(pz, APZ[k], false) == 0) & (Operators.CompareString(curcomb, ACOMB[k], false) == 0))
					{
						num++;
						comblist[num] = ACOMBF[k];
						combrowi[num] = k;
					}
				}
				else if (!flag & (Operators.CompareString(pz, APZ[k], false) == 0) & (Operators.CompareString(curcomb, ACOMBF[k], false) == 0))
				{
					num++;
					comblist[num] = ACOMBF[k];
					combrowi[num] = k;
				}
			}
			combnum = num;
			comblist = (string[])Utils.CopyArray((Array)comblist, (Array)new string[(int)combnum + 1]);
			combrowi = (long[])Utils.CopyArray((Array)combrowi, (Array)new long[(int)combnum + 1]);
			BubbleSortComb(comblist);
		}
	}

	public static void xnSearch_bffball(string pz, Workbook wb)
	{
		long num = 1L;
		long num2 = 1L;
		Conversions.ToString(NewLateBinding.LateGet(Mod1.excelapp.ActiveSheet, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null));
		Excel.Range currentRegion = ((_Worksheet)newsh).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
		long num3 = currentRegion.Rows.Count;
		Application.DoEvents();
		int num4 = 0;
		Conversions.ToInteger(NewLateBinding.LateGet(Mod1.excelapp.Selection, (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
		checked
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((IEnumerable)Mod1.excelapp.Selection).GetEnumerator();
				float num8 = default(float);
				float num9 = default(float);
				float num10 = default(float);
				float num11 = default(float);
				int num12 = default(int);
				while (enumerator.MoveNext())
				{
					Excel.Range range = (Excel.Range)enumerator.Current;
					blfind = false;
					num4++;
					float num5 = Conversions.ToSingle(NewLateBinding.LateGet(newsh.Cells[num, range.Column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					float num6 = Conversions.ToSingle(NewLateBinding.LateGet(newsh.Cells[range.Row, num2], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					float num7 = Conversions.ToSingle(NewLateBinding.LateGet(newsh.Cells[num3, range.Column], (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
					if (!((Operators.CompareString(num5.ToString(), "", false) != 0) & (Operators.CompareString(num6.ToString(), "", false) != 0) & (Operators.CompareString(num7.ToString(), "", false) != 0)))
					{
						continue;
					}
					int aCOUNT = ACOUNT;
					for (int i = 2; i <= aCOUNT; i++)
					{
						if (Operators.CompareString(curbcname, "LF", false) == 0)
						{
							num8 = Conversions.ToSingle(ALZ[i]);
							num9 = Conversions.ToSingle(ARF[i]);
							num10 = Conversions.ToSingle(ACOMB[i]);
						}
						if (Operators.CompareString(curbcname, "LZ", false) == 0)
						{
							num8 = Conversions.ToSingle(ALF[i]);
							num9 = Conversions.ToSingle(ARF[i]);
							num10 = Conversions.ToSingle(ACOMBF[i]);
						}
						if ((double)Math.Abs(num7 - num10) < 1E-06 && (((double)Math.Abs(num6 - num9) < 1E-06) & ((double)Math.Abs(num5 - num8) < 1E-06)))
						{
							num11 = Conversions.ToSingle(ADestination_Q[i]);
							blfind = true;
							break;
						}
					}
					if (blfind)
					{
						NewLateBinding.LateSetComplex(range.Cells[num12 + 1, 1], (Type)null, "Value", new object[1] { num11 }, (string[])null, (Type[])null, false, true);
					}
					num11 = 0f;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
	}
}
