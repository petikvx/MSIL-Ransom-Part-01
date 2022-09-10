using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Excel;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[StandardModule]
internal sealed class xnbbrowser
{
	public static int filei;

	public static string curxnlibs;

	private static int mrcount;

	private static string[] tname;

	private static int[] tcolor;

	private static bool refflag;

	public static bool zbOutFiles(string JieGouXingShi, string PeiZhong, string ZhiTuiKuaJu, string ControlOpti, string ControlList)
	{
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		string text = "";
		if (!Directory.Exists(curxnlibs + "\\tempi"))
		{
			FileSystem.MkDir(curxnlibs + "\\tempi");
		}
		Mod1.wr = new StreamWriter(curxnlibs + "\\tempi\\" + Conversions.ToString(filei) + ".TXT", append: false, Encoding.Default);
		Mod1.wr.WriteLine(JieGouXingShi + "_" + PeiZhong + "_" + ZhiTuiKuaJu + "_" + ControlOpti + ".xls");
		string[] array = Strings.Split(ControlList, ",", -1, (CompareMethod)0);
		string[] array2 = array;
		foreach (string text2 in array2)
		{
			switch (text2)
			{
			case "回转支承":
				text = curxnlibs + "\\" + JieGouXingShi + "\\" + text2 + ".xls";
				Mod1.wr.WriteLine(text + "," + text2 + "," + PeiZhong);
				goto IL_02e4;
			case "倾翻":
			case "支腿":
				text = curxnlibs + "\\" + JieGouXingShi + "\\" + ZhiTuiKuaJu + "_" + text2 + ".xls";
				Mod1.wr.WriteLine(text + "," + ZhiTuiKuaJu + "_" + text2 + "," + PeiZhong);
				goto IL_02e4;
			case "强度":
			case "刚度":
			case "变幅缸":
			case "超起钢丝绳":
				text = curxnlibs + "\\" + JieGouXingShi + "\\" + text2 + ".xls";
				Mod1.wr.WriteLine(text + "," + text2 + "," + text2);
				goto IL_02e4;
			default:
				{
					Interaction.MsgBox((object)("不存在的控制准则：" + text2), (MsgBoxStyle)0, (object)"提示");
					result = false;
					break;
				}
				IL_02e4:
				if (File.Exists(text))
				{
					continue;
				}
				result = false;
				Interaction.MsgBox((object)(text + "不存在!"), (MsgBoxStyle)0, (object)"?? ?基本源文件不完整");
				break;
			}
			break;
		}
		Mod1.wr.Close();
		Mod1.wr.Dispose();
		checked
		{
			filei++;
			return result;
		}
	}

	public static bool zbOutFiles_all(string JieGouXingShi, string PeiZhong, string ZhiTuiKuaJu, string ControlOpti, string ControlList)
	{
		bool result = true;
		checked
		{
			if (Operators.CompareString(Strings.Trim(ControlList), "", false) == 0)
			{
				result = false;
			}
			else
			{
				string text = "";
				if (!Directory.Exists(curxnlibs + "\\tempi"))
				{
					FileSystem.MkDir(curxnlibs + "\\tempi");
				}
				Mod1.wr = new StreamWriter(curxnlibs + "\\tempi\\" + Conversions.ToString(filei) + ".TXT", append: false, Encoding.Default);
				Mod1.wr.WriteLine(JieGouXingShi + "_" + PeiZhong + "_" + ZhiTuiKuaJu + "_" + ControlOpti + ".xls");
				string[] array = Strings.Split(ControlList, ",", -1, (CompareMethod)0);
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					switch (text2)
					{
					case "强度":
					case "刚度":
					case "变幅缸":
					case "超起钢丝绳":
						text = curxnlibs + "\\" + JieGouXingShi + "\\" + text2 + ".xls";
						Mod1.wr.WriteLine(text + "," + text2 + "," + text2);
						if (File.Exists(text))
						{
							continue;
						}
						result = false;
						MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().Add((object)(text + "不存在!"));
						MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.set_SelectedIndex(MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().get_Count() - 1);
						break;
					default:
						MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().Add((object)("由于没有配重及支腿跨距数据,当前控制准则：" + text2 + "无效!"));
						MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.set_SelectedIndex(MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().get_Count() - 1);
						result = false;
						break;
					}
					break;
				}
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				filei++;
			}
			return result;
		}
	}

	public static bool bffbOutFiles(string JieGouXingShi, string PeiZhong, string ZhiTuiKuaJu, string zbxt, string yxxx, string curbc, string ControlOpti, string ControlList)
	{
		bool result = true;
		string text = "";
		if (!Directory.Exists(curxnlibs + "\\tempi"))
		{
			FileSystem.MkDir(curxnlibs + "\\tempi");
		}
		Mod1.wr = new StreamWriter(curxnlibs + "\\tempi\\" + Conversions.ToString(filei) + ".TXT", append: false, Encoding.Default);
		Mod1.wr.WriteLine(JieGouXingShi + "_" + PeiZhong + "_" + ZhiTuiKuaJu + "_" + zbxt + "_" + yxxx + "_" + curbc + "_" + ControlOpti + ".xls");
		string[] array = Strings.Split(ControlList, ",", -1, (CompareMethod)0);
		string[] array2 = array;
		checked
		{
			foreach (string text2 in array2)
			{
				switch (text2)
				{
				case "回转支承":
					text = curxnlibs + "\\" + JieGouXingShi + "\\" + yxxx + "\\" + zbxt + "\\" + text2 + ".xls";
					Mod1.wr.WriteLine(text + "," + text2 + "," + PeiZhong + "_" + curbc);
					goto IL_03aa;
				case "倾翻":
				case "支腿":
					text = curxnlibs + "\\" + JieGouXingShi + "\\" + yxxx + "\\" + zbxt + "\\" + ZhiTuiKuaJu + "_" + text2 + ".xls";
					Mod1.wr.WriteLine(text + "," + ZhiTuiKuaJu + "_" + text2 + "," + PeiZhong + "_" + curbc);
					goto IL_03aa;
				case "强度":
				case "刚度":
				case "变幅缸":
				case "超起钢丝绳":
					text = curxnlibs + "\\" + JieGouXingShi + "\\" + yxxx + "\\" + zbxt + "\\" + text2 + ".xls";
					Mod1.wr.WriteLine(text + "," + text2 + "," + text2 + "_" + curbc);
					goto IL_03aa;
				default:
					{
						MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().Add((object)("不存在的控制准则：" + text2));
						MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.set_SelectedIndex(MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().get_Count() - 1);
						result = false;
						break;
					}
					IL_03aa:
					if (File.Exists(text))
					{
						continue;
					}
					result = false;
					MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().Add((object)(text + "不存在!"));
					MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.set_SelectedIndex(MyProject.Forms.ll_ufxnbBrowser.ll_LB_Results.get_Items().get_Count() - 1);
					break;
				}
				break;
			}
			Mod1.wr.Close();
			Mod1.wr.Dispose();
			filei++;
			return result;
		}
	}

	public static bool bffbOutFiles_all(string JieGouXingShi, string PeiZhong, string ZhiTuiKuaJu, string zbxt, string yxxx, string curbc, string ControlOpti, string ControlList)
	{
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		bool result = true;
		checked
		{
			if (Operators.CompareString(Strings.Trim(ControlList), "", false) == 0)
			{
				result = false;
			}
			else
			{
				string text = "";
				if (!Directory.Exists(curxnlibs + "\\tempi"))
				{
					FileSystem.MkDir(curxnlibs + "\\tempi");
				}
				Mod1.wr = new StreamWriter(curxnlibs + "\\tempi\\" + Conversions.ToString(filei) + ".TXT", append: false, Encoding.Default);
				Mod1.wr.WriteLine(JieGouXingShi + "_" + PeiZhong + "_" + ZhiTuiKuaJu + "_" + zbxt + "_" + yxxx + "_" + curbc + "_" + ControlOpti + ".xls");
				string[] array = Strings.Split(ControlList, ",", -1, (CompareMethod)0);
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					switch (text2)
					{
					case "强度":
					case "刚度":
					case "变幅缸":
					case "超起钢丝绳":
						text = curxnlibs + "\\" + JieGouXingShi + "\\" + yxxx + "\\" + zbxt + "\\" + text2 + ".xls";
						Mod1.wr.WriteLine(text + "," + text2 + "," + text2 + "_" + curbc);
						if (File.Exists(text))
						{
							continue;
						}
						result = false;
						Interaction.MsgBox((object)(text + "不存在!"), (MsgBoxStyle)0, (object)"?? ?基本源文件不完整");
						break;
					default:
						Interaction.MsgBox((object)("由于没有配重及支腿跨距数据,当前控制准则：" + text2 + "无效!"), (MsgBoxStyle)0, (object)"提示");
						result = false;
						break;
					}
					break;
				}
				Mod1.wr.Close();
				Mod1.wr.Dispose();
				filei++;
			}
			return result;
		}
	}

	public static bool zbInFiles(ButtonX outBTN, ListBox outLBResults)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Unknown result type (might be due to invalid IL or missing references)
		Application.DoEvents();
		bool result = true;
		string text = outBTN.get_Text();
		checked
		{
			outBTN.set_Text("0/" + Conversions.ToString(filei - 1) + ".. .");
			string text2 = Application.get_StartupPath() + "\\config\\TempXN.xls";
			if (!File.Exists(text2))
			{
				Interaction.MsgBox((object)(text2 + "不存在!请联系开发人员.. ."), (MsgBoxStyle)0, (object)"提示");
				result = false;
			}
			else
			{
				int num = filei - 1;
				int num2 = 1;
				string text7 = default(string);
				while (true)
				{
					string text6;
					string text8;
					if (num2 <= num)
					{
						int num3 = 0;
						int num4 = 0;
						bool flag = true;
						bool flag2 = true;
						Application.DoEvents();
						if (!Mod1.WorkbookIsOpen("TempXN.xls"))
						{
							Mod1.excelapp.Workbooks.Open(text2, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
						}
						else
						{
							Mod1.excelapp.Windows["TempXN.xls"].Activate();
						}
						string text3 = curxnlibs + "\\tempi\\" + Conversions.ToString(num2) + ".txt";
						if (File.Exists(text3))
						{
							Mod1.lr = new StreamReader(text3, Encoding.Default);
							string text4 = "";
							text4 = Mod1.lr.ReadLine();
							int num5 = 0;
							while (true)
							{
								num5++;
								string text5 = Mod1.lr.ReadLine();
								if (Information.IsNothing((object)text5))
								{
									break;
								}
								string[] array = Strings.Split(text5, ",", -1, (CompareMethod)0);
								text6 = array[0];
								text7 = array[1];
								text8 = array[2];
								if (!Mod1.WorkbookIsOpen(text7 + ".xls"))
								{
									Mod1.excelapp.Workbooks.Open(text6, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
								}
								else
								{
									Mod1.excelapp.Windows[text7 + ".xls"].Activate();
								}
								if (Q_JS.SheetExists(text8))
								{
									Worksheet worksheet = (Worksheet)Mod1.excelapp.Workbooks["TempXN.xls"].Sheets.Add(Missing.Value, Missing.Value, Missing.Value, Missing.Value);
									NewLateBinding.LateCall(NewLateBinding.LateGet(Mod1.excelapp.Workbooks[text7 + ".xls"].Sheets[text8], (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Copy", new object[1] { ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value) }, (string[])null, (Type[])null, (bool[])null, true);
									worksheet.Activate();
									if (Q_JS.SheetExists(text7))
									{
										NewLateBinding.LateCall(NewLateBinding.LateGet((object)worksheet, (Type)null, "Sheets", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
									}
									NewLateBinding.LateSetComplex(Mod1.excelapp.ActiveSheet, (Type)null, "Name", new object[1] { text7 }, (string[])null, (Type[])null, false, true);
									int num6 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Mod1.excelapp.ActiveSheet, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentRegion", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Rows", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
									int num7 = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Mod1.excelapp.ActiveSheet, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentRegion", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Columns", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null));
									if (num6 != num3)
									{
										if (num5 >= 2)
										{
											flag = false;
										}
										num3 = num6;
									}
									if (num7 != num4)
									{
										if (num5 >= 2)
										{
											flag2 = false;
										}
										num4 = num7;
									}
									Mod1.excelapp.Application.DisplayAlerts = false;
									Mod1.excelapp.Windows[text7 + ".xls"].Close(Missing.Value, Missing.Value, Missing.Value);
									Mod1.excelapp.Application.DisplayAlerts = true;
									continue;
								}
								goto IL_089c;
							}
							Mod1.lr.Close();
							Mod1.lr.Dispose();
							if (!flag2)
							{
								outLBResults.get_Items().Add((object)(text3 + "中所列的单项性能表的列数不一致,会导致性能合成无效."));
								outLBResults.set_SelectedIndex(outLBResults.get_Items().get_Count() - 1);
							}
							if (!flag & !Mod1.QDflag)
							{
								outLBResults.get_Items().Add((object)(text3 + "中所列的单项性能表的行数不一致,会导致性能合成无效."));
								outLBResults.set_SelectedIndex(outLBResults.get_Items().get_Count() - 1);
							}
							Mod1.excelapp.Windows["TempXN.xls"].Activate();
							if (Q_JS.SheetExists("性能数据表"))
							{
								if (Mod1.QDflag)
								{
									text7 = "强度";
								}
								object obj = NewLateBinding.LateGet(Mod1.excelapp.Sheets[text7], (Type)null, "Cells", new object[0], (string[])null, (Type[])null, (bool[])null);
								object[] array2 = new object[1];
								object obj2 = Mod1.excelapp.Sheets["性能数据表"];
								object[] array3 = new object[1];
								string text9 = (string)(array3[0] = "A1");
								array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "Range", array3, (string[])null, (Type[])null, (bool[])null));
								object[] array4 = array2;
								bool[] array5 = new bool[1] { true };
								NewLateBinding.LateCall(obj, (Type)null, "Copy", array4, (string[])null, (Type[])null, array5, true);
								if (array5[0])
								{
									NewLateBinding.LateSetComplex(obj2, (Type)null, "Range", new object[2]
									{
										text9,
										RuntimeHelpers.GetObjectValue(array4[0])
									}, (string[])null, (Type[])null, true, true);
								}
								if (Q_JS.SheetExists("控制vs颜色"))
								{
									int num8 = colorpick((Excel.Range)NewLateBinding.LateGet(NewLateBinding.LateGet(Mod1.excelapp.Sheets["控制vs颜色"], (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentRegion", new object[0], (string[])null, (Type[])null, (bool[])null));
									NewLateBinding.LateCall(Mod1.excelapp.Sheets["性能数据表"], (Type)null, "Activate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
									Excel.Range range = (Excel.Range)NewLateBinding.LateGet(NewLateBinding.LateGet(Mod1.excelapp.ActiveSheet, (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentRegion", new object[0], (string[])null, (Type[])null, (bool[])null);
									range.get_Offset((object)1, (object)1).get_Resize((object)(range.Rows.Count - 2), (object)(range.Columns.Count - 1)).Select();
									if (num8 > 1)
									{
										if (Mod1.QDflag)
										{
											minpick_qd();
										}
										else
										{
											minpick();
										}
									}
									Mod1.excelapp.ActiveWorkbook.RemovePersonalInformation = false;
									Mod1.excelapp.Application.DisplayAlerts = false;
									if (!Directory.Exists(curxnlibs + "\\Results"))
									{
										FileSystem.MkDir(curxnlibs + "\\Results");
									}
									Mod1.excelapp.ActiveWorkbook.SaveAs(curxnlibs + "\\Results\\" + text4, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, XlSaveAsAccessMode.xlNoChange, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
									Mod1.excelapp.ActiveWindow.Close(Missing.Value, Missing.Value, Missing.Value);
									Mod1.excelapp.Application.DisplayAlerts = true;
									outBTN.set_Text(Conversions.ToString(num2) + "/" + Conversions.ToString(filei - 1) + ".. .");
									if (Operators.CompareString(text4, "", false) != 0)
									{
										outLBResults.get_Items().Add((object)(Conversions.ToString(num2) + ";" + curxnlibs + "\\Results\\" + text4));
									}
									outLBResults.set_SelectedIndex(outLBResults.get_Items().get_Count() - 1);
									goto IL_095c;
								}
								Interaction.MsgBox((object)(text2 + "中不存在工作表：控制vs颜色,请联系开发人员.. ."), (MsgBoxStyle)0, (object)"提示");
								result = false;
								break;
							}
							Interaction.MsgBox((object)(text2 + "中不存在工作表：性能数据表,请联系开发人员.. ."), (MsgBoxStyle)0, (object)"提示");
							result = false;
							break;
						}
						Interaction.MsgBox((object)(text3 + "不存在!请联系开发人员.. ."), (MsgBoxStyle)0, (object)"提示");
						result = false;
						break;
					}
					outBTN.set_Text(text);
					break;
					IL_095c:
					num2++;
					continue;
					IL_089c:
					string text10 = text6 + "中不存在工作表：" + text8;
					string path = curxnlibs + "\\Temp.log";
					Mod1.wr = new StreamWriter(path, append: true, Encoding.Default);
					Mod1.wr.WriteLine(DateTime.Now);
					Mod1.wr.WriteLine(Conversions.ToString(num2) + ", " + text10);
					outLBResults.get_Items().Add((object)(Conversions.ToString(num2) + ", " + text10));
					Mod1.wr.Close();
					result = false;
					Mod1.excelapp.Windows[text7 + ".xls"].Close(Missing.Value, Missing.Value, Missing.Value);
					goto IL_095c;
				}
			}
			return result;
		}
	}

	public static int colorpick(Excel.Range myrange)
	{
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		mrcount = myrange.Rows.Count;
		checked
		{
			tname = new string[mrcount + 1];
			tcolor = new int[mrcount + 1];
			int num = 0;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = myrange.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
					if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0 && Q_JS.SheetExists(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))))
					{
						tname[num] = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
						tcolor[num] = Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[0], (string[])null, (Type[])null, (bool[])null));
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(Mod1.excelapp.Worksheets[RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null))], (Type)null, "tab", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "colorindex", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
						num++;
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
			if (mrcount != num)
			{
				mrcount = num;
			}
			if (myrange.Columns.Count > 1)
			{
				Interaction.MsgBox((object)"当前选定区域只能为1列,请重新选择区域!", (MsgBoxStyle)0, (object)"提示");
			}
			return mrcount;
		}
	}

	public static void minpick()
	{
		//IL_09fb: Unknown result type (might be due to invalid IL or missing references)
		Worksheet worksheet = (Worksheet)Mod1.excelapp.Worksheets[tname[0]];
		Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
		int count = currentRegion.Rows.Count;
		checked
		{
			if (mrcount > 1)
			{
				Excel.Range range = (Excel.Range)Mod1.excelapp.Application.Selection;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = range.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						NewLateBinding.LateSet(objectValue, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = range.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
						int num = Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
						int num2 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null));
						if (num == count)
						{
							break;
						}
						object[] array = new object[1];
						object[] array2 = array;
						object obj = Mod1.excelapp.Worksheets[tname[0]];
						object[] array3 = new object[2] { num, num2 };
						object[] array4 = array3;
						bool[] array5 = new bool[2] { true, true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Cells", array4, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
						}
						if (array5[1])
						{
							num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
						}
						array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						NewLateBinding.LateSet(objectValue2, (Type)null, "value", array, (string[])null, (Type[])null);
						if ((double)Conversions.ToSingle(NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)) > 1E-05)
						{
							int num3 = mrcount - 1;
							for (int i = 1; i <= num3; i++)
							{
								object obj3 = Mod1.excelapp.Worksheets[tname[i]];
								array3 = new object[2] { num, num2 };
								object[] array6 = array3;
								array5 = new bool[2] { true, true };
								object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Cells", array6, (string[])null, (Type[])null, array5);
								if (array5[0])
								{
									num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
								}
								if (array5[1])
								{
									num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
								}
								Excel.Range range2 = (Excel.Range)obj4;
								object obj5 = Mod1.excelapp.Worksheets[tname[i]];
								array3 = new object[2] { num, 1 };
								object[] array7 = array3;
								array5 = new bool[2] { true, false };
								object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Cells", array7, (string[])null, (Type[])null, array5);
								if (array5[0])
								{
									num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
								}
								Excel.Range range3 = (Excel.Range)obj6;
								if (Operators.CompareString(Strings.Trim(Conversions.ToString(range3.get_Value((object)Missing.Value))), "", false) != 0)
								{
									if (Operators.CompareString(Strings.Trim(Conversions.ToString(range2.get_Value((object)Missing.Value))), "", false) != 0)
									{
										object obj7 = Mod1.excelapp.Worksheets[tname[i]];
										array3 = new object[2] { num, num2 };
										object[] array8 = array3;
										array5 = new bool[2] { true, true };
										object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "Cells", array8, (string[])null, (Type[])null, array5);
										if (array5[0])
										{
											num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
										}
										if (array5[1])
										{
											num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
										}
										if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(NewLateBinding.LateGet(obj8, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)0, false))
										{
											object[] array9 = new object[1];
											object[] array10 = array9;
											object obj9 = Mod1.excelapp.Worksheets[tname[i]];
											object[] array11 = new object[2] { num, num2 };
											object[] array12 = array11;
											bool[] array13 = new bool[2] { true, true };
											object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "Cells", array12, (string[])null, (Type[])null, array13);
											if (array13[0])
											{
												num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
											}
											if (array13[1])
											{
												num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[1]), typeof(int));
											}
											array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj10, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
											NewLateBinding.LateSet(objectValue2, (Type)null, "value", array9, (string[])null, (Type[])null);
											if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1E-05), (object)0, false))
											{
												NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
												break;
											}
										}
										continue;
									}
									NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
									break;
								}
								NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
								break;
							}
							refflag = true;
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
							if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
							{
								int num4 = mrcount - 1;
								for (int j = 0; j <= num4; j++)
								{
									Type typeFromHandle = typeof(Math);
									array = new object[1];
									object[] array14 = array;
									object obj11 = Mod1.excelapp.Worksheets[tname[j]];
									object[] array11 = new object[2] { num, num2 };
									object[] array15 = array11;
									bool[] array13 = new bool[2] { true, true };
									object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "Cells", array15, (string[])null, (Type[])null, array13);
									if (array13[0])
									{
										num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
									}
									if (array13[1])
									{
										num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[1]), typeof(int));
									}
									array14[0] = Operators.SubtractObject(NewLateBinding.LateGet(obj12, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
									if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeFromHandle, "Abs", array, (string[])null, (Type[])null, (bool[])null), (object)0.01, false))
									{
										refflag = false;
									}
								}
							}
							if (!((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & !refflag))
							{
								continue;
							}
							int num5 = mrcount - 1;
							for (int k = 0; k <= num5; k++)
							{
								Type typeFromHandle2 = typeof(Math);
								array = new object[1];
								object[] array16 = array;
								object obj13 = Mod1.excelapp.Worksheets[tname[k]];
								object[] array11 = new object[2] { num, num2 };
								object[] array17 = array11;
								bool[] array13 = new bool[2] { true, true };
								object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "Cells", array17, (string[])null, (Type[])null, array13);
								if (array13[0])
								{
									num = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
								}
								if (array13[1])
								{
									num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[1]), typeof(int));
								}
								array16[0] = Operators.SubtractObject(NewLateBinding.LateGet(obj14, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
								if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet((object)null, typeFromHandle2, "Abs", array, (string[])null, (Type[])null, (bool[])null), (object)0.01, false))
								{
									NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { tcolor[k] }, (string[])null, (Type[])null, false, true);
								}
							}
						}
						else
						{
							NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
						}
					}
					return;
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			Interaction.MsgBox((object)"请点击colorpick,然后再进行当前操作!", (MsgBoxStyle)0, (object)"提示");
		}
	}

	public static void minpick_qd()
	{
		//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
		Worksheet worksheet = (Worksheet)Mod1.excelapp.Worksheets[tname[0]];
		Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
		int count = currentRegion.Rows.Count;
		worksheet = (Worksheet)Mod1.excelapp.Worksheets[tname[0]];
		currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
		count = currentRegion.Rows.Count;
		checked
		{
			if (mrcount > 1)
			{
				Excel.Range range = (Excel.Range)Mod1.excelapp.Application.Selection;
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = range.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						NewLateBinding.LateSet(objectValue, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
					}
				}
				finally
				{
					if (enumerator is IDisposable)
					{
						(enumerator as IDisposable).Dispose();
					}
				}
				float num = 0f;
				int num2 = 0;
				IEnumerator enumerator2 = default(IEnumerator);
				try
				{
					enumerator2 = range.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
						int num3 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, (Type)null, "Row", new object[0], (string[])null, (Type[])null, (bool[])null));
						int num4 = Conversions.ToInteger(NewLateBinding.LateGet(objectValue2, (Type)null, "Column", new object[0], (string[])null, (Type[])null, (bool[])null));
						if (num3 == count)
						{
							break;
						}
						object[] array = new object[1];
						object[] array2 = array;
						object obj = Mod1.excelapp.Worksheets[tname[0]];
						object[] array3 = new object[2] { num3, num4 };
						object[] array4 = array3;
						bool[] array5 = new bool[2] { true, true };
						object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Cells", array4, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							num3 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
						}
						if (array5[1])
						{
							num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
						}
						array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
						NewLateBinding.LateSet(objectValue2, (Type)null, "value", array, (string[])null, (Type[])null);
						object obj3 = Mod1.excelapp.Worksheets[tname[0]];
						array3 = new object[2] { num3, 1 };
						object[] array6 = array3;
						array5 = new bool[2] { true, false };
						object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "Cells", array6, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							num3 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
						}
						float num5 = Conversions.ToSingle(NewLateBinding.LateGet(obj4, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
						bool flag = false;
						if ((double)Math.Abs(num - num5) > 0.001)
						{
							flag = true;
							num = num5;
						}
						if ((double)Conversions.ToSingle(NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)) > 1E-05)
						{
							int num6 = mrcount - 1;
							for (int i = 1; i <= num6; i++)
							{
								if (flag)
								{
									num2 = searchcurrowother(num5, i);
								}
								if (num2 != 0)
								{
									object obj5 = Mod1.excelapp.Worksheets[tname[i]];
									array3 = new object[2] { num2, num4 };
									object[] array7 = array3;
									array5 = new bool[2] { true, true };
									object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Cells", array7, (string[])null, (Type[])null, array5);
									if (array5[0])
									{
										num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
									}
									if (array5[1])
									{
										num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
									}
									Excel.Range range2 = (Excel.Range)obj6;
									object obj7 = Mod1.excelapp.Worksheets[tname[i]];
									array3 = new object[2] { num2, 1 };
									object[] array8 = array3;
									array5 = new bool[2] { true, false };
									object obj8 = NewLateBinding.LateGet(obj7, (Type)null, "Cells", array8, (string[])null, (Type[])null, array5);
									if (array5[0])
									{
										num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
									}
									Excel.Range range3 = (Excel.Range)obj8;
									if (Operators.CompareString(Strings.Trim(Conversions.ToString(range3.get_Value((object)Missing.Value))), "", false) != 0)
									{
										if (Operators.CompareString(Strings.Trim(Conversions.ToString(range2.get_Value((object)Missing.Value))), "", false) != 0)
										{
											object obj9 = Mod1.excelapp.Worksheets[tname[i]];
											array3 = new object[2] { num2, num4 };
											object[] array9 = array3;
											array5 = new bool[2] { true, true };
											object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "Cells", array9, (string[])null, (Type[])null, array5);
											if (array5[0])
											{
												num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
											}
											if (array5[1])
											{
												num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[1]), typeof(int));
											}
											if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(NewLateBinding.LateGet(obj10, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)0, false))
											{
												object[] array10 = new object[1];
												object[] array11 = array10;
												object obj11 = Mod1.excelapp.Worksheets[tname[i]];
												object[] array12 = new object[2] { num2, num4 };
												object[] array13 = array12;
												bool[] array14 = new bool[2] { true, true };
												object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "Cells", array13, (string[])null, (Type[])null, array14);
												if (array14[0])
												{
													num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
												}
												if (array14[1])
												{
													num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[1]), typeof(int));
												}
												array11[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj12, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null));
												NewLateBinding.LateSet(objectValue2, (Type)null, "value", array10, (string[])null, (Type[])null);
												if (Operators.ConditionalCompareObjectLess(Operators.SubtractObject(NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1E-05), (object)0, false))
												{
													NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
													break;
												}
											}
											continue;
										}
										NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
										break;
									}
									NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
									break;
								}
								NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
								break;
							}
							refflag = true;
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { 0 }, (string[])null, (Type[])null, false, true);
							if (Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0)
							{
								int num7 = mrcount - 1;
								for (int j = 0; j <= num7; j++)
								{
									if (j == 0)
									{
										Type typeFromHandle = typeof(Math);
										array = new object[1];
										object[] array15 = array;
										object obj13 = Mod1.excelapp.Worksheets[tname[j]];
										object[] array12 = new object[2] { num3, num4 };
										object[] array16 = array12;
										bool[] array14 = new bool[2] { true, true };
										object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "Cells", array16, (string[])null, (Type[])null, array14);
										if (array14[0])
										{
											num3 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
										}
										if (array14[1])
										{
											num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[1]), typeof(int));
										}
										array15[0] = Operators.SubtractObject(NewLateBinding.LateGet(obj14, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
										if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeFromHandle, "Abs", array, (string[])null, (Type[])null, (bool[])null), (object)0.01, false))
										{
											refflag = false;
										}
									}
									else
									{
										Type typeFromHandle2 = typeof(Math);
										array = new object[1];
										object[] array17 = array;
										object obj15 = Mod1.excelapp.Worksheets[tname[j]];
										object[] array12 = new object[2] { num2, num4 };
										object[] array18 = array12;
										bool[] array14 = new bool[2] { true, true };
										object obj16 = NewLateBinding.LateGet(obj15, (Type)null, "Cells", array18, (string[])null, (Type[])null, array14);
										if (array14[0])
										{
											num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
										}
										if (array14[1])
										{
											num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[1]), typeof(int));
										}
										array17[0] = Operators.SubtractObject(NewLateBinding.LateGet(obj16, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
										if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet((object)null, typeFromHandle2, "Abs", array, (string[])null, (Type[])null, (bool[])null), (object)0.01, false))
										{
											refflag = false;
										}
									}
								}
							}
							if (!((Operators.CompareString(Strings.Trim(Conversions.ToString(NewLateBinding.LateGet(objectValue2, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null))), "", false) != 0) & !refflag))
							{
								continue;
							}
							int num8 = mrcount - 1;
							for (int k = 0; k <= num8; k++)
							{
								if (k == 0)
								{
									Type typeFromHandle3 = typeof(Math);
									array = new object[1];
									object[] array19 = array;
									object obj17 = Mod1.excelapp.Worksheets[tname[k]];
									object[] array12 = new object[2] { num3, num4 };
									object[] array20 = array12;
									bool[] array14 = new bool[2] { true, true };
									object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "Cells", array20, (string[])null, (Type[])null, array14);
									if (array14[0])
									{
										num3 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
									}
									if (array14[1])
									{
										num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[1]), typeof(int));
									}
									array19[0] = Operators.SubtractObject(NewLateBinding.LateGet(obj18, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
									if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet((object)null, typeFromHandle3, "Abs", array, (string[])null, (Type[])null, (bool[])null), (object)0.01, false))
									{
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { tcolor[k] }, (string[])null, (Type[])null, false, true);
									}
								}
								else
								{
									Type typeFromHandle4 = typeof(Math);
									array = new object[1];
									object[] array21 = array;
									object obj19 = Mod1.excelapp.Worksheets[tname[k]];
									object[] array12 = new object[2] { num2, num4 };
									object[] array22 = array12;
									bool[] array14 = new bool[2] { true, true };
									object obj20 = NewLateBinding.LateGet(obj19, (Type)null, "Cells", array22, (string[])null, (Type[])null, array14);
									if (array14[0])
									{
										num2 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
									}
									if (array14[1])
									{
										num4 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[1]), typeof(int));
									}
									array21[0] = Operators.SubtractObject(NewLateBinding.LateGet(obj20, (Type)null, "Value", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(objectValue2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
									if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet((object)null, typeFromHandle4, "Abs", array, (string[])null, (Type[])null, (bool[])null), (object)0.01, false))
									{
										NewLateBinding.LateSetComplex(NewLateBinding.LateGet(objectValue2, (Type)null, "Font", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ColorIndex", new object[1] { tcolor[k] }, (string[])null, (Type[])null, false, true);
									}
								}
							}
						}
						else
						{
							NewLateBinding.LateSet(objectValue2, (Type)null, "value", new object[1] { "" }, (string[])null, (Type[])null);
						}
					}
					return;
				}
				finally
				{
					if (enumerator2 is IDisposable)
					{
						(enumerator2 as IDisposable).Dispose();
					}
				}
			}
			Interaction.MsgBox((object)"请点击colorpick,然后再进行当前操作!", (MsgBoxStyle)0, (object)"提示");
		}
	}

	public static int searchcurrowother(float rf, int otherii)
	{
		Excel.Range range = (Excel.Range)NewLateBinding.LateGet(NewLateBinding.LateGet(Mod1.excelapp.Worksheets[tname[otherii]], (Type)null, "Range", new object[1] { "A1" }, (string[])null, (Type[])null, (bool[])null), (Type)null, "CurrentRegion", new object[0], (string[])null, (Type[])null, (bool[])null);
		int count = range.Rows.Count;
		int result = 0;
		checked
		{
			int num = count - 1;
			for (int i = 2; i <= num; i++)
			{
				object obj = Mod1.excelapp.Worksheets[tname[otherii]];
				object[] array = new object[2] { i, 1 };
				bool[] array2 = new bool[2] { true, false };
				object obj2 = NewLateBinding.LateGet(obj, (Type)null, "Cells", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				float num2 = Conversions.ToSingle(NewLateBinding.LateGet(obj2, (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
				if (!((double)Math.Abs(rf - num2) >= 0.001))
				{
					result = i;
					break;
				}
			}
			return result;
		}
	}
}
