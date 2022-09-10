using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel;
using Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using xxx.My;

namespace xxx;

[StandardModule]
internal sealed class ModWord
{
	public static Microsoft.Office.Interop.Word.Application oWordApplic;

	private static Document oDocument;

	private static Document oDocument1;

	private static Microsoft.Office.Interop.Word.Range oRange;

	private static Selection oSelection;

	private static Bookmark bm;

	private static Table tb;

	private static ArrayList ll_lbyx = new ArrayList();

	private static ArrayList ll_lbxt = new ArrayList();

	private static ArrayList ll_lbxlslist = new ArrayList();

	private static int limitcols;

	private static string strwhich;

	private static string strf;

	private static string strxt;

	private static string stryx;

	private static string p;

	public static bool jsbgexit;

	public static void NewDocWithModel(string FileName)
	{
		Missing value = Missing.Value;
		string text = FileName;
		Documents documents = oWordApplic.Documents;
		object Template = text;
		object NewTemplate = value;
		object DocumentType = value;
		object Visible = true;
		Document document = documents.Add(ref Template, ref NewTemplate, ref DocumentType, ref Visible);
		Conversions.ToBoolean(Visible);
		value = (Missing)DocumentType;
		value = (Missing)NewTemplate;
		text = Conversions.ToString(Template);
		oDocument = document;
		oDocument.Activate();
	}

	public static void InsterMULU()
	{
		Document activeDocument = oWordApplic.ActiveDocument;
		TablesOfContents tablesOfContents = activeDocument.TablesOfContents;
		Microsoft.Office.Interop.Word.Range range = oWordApplic.Selection.Range;
		object UseHeadingStyles = true;
		object UpperHeadingLevel = 1;
		object LowerHeadingLevel = 3;
		object UseFields = Missing.Value;
		object TableID = Missing.Value;
		object RightAlignPageNumbers = true;
		object IncludePageNumbers = true;
		object AddedStyles = "";
		object UseHyperlinks = true;
		object HidePageNumbersInWeb = true;
		object UseOutlineLevels = true;
		tablesOfContents.Add(range, ref UseHeadingStyles, ref UpperHeadingLevel, ref LowerHeadingLevel, ref UseFields, ref TableID, ref RightAlignPageNumbers, ref IncludePageNumbers, ref AddedStyles, ref UseHyperlinks, ref HidePageNumbersInWeb, ref UseOutlineLevels);
		activeDocument.TablesOfContents[1].TabLeader = WdTabLeader.wdTabLeaderDots;
		activeDocument.TablesOfContents.Format = WdTocFormat.wdTOCTemplate;
		activeDocument = null;
	}

	public static void Quit()
	{
		if (oWordApplic != null)
		{
			oWordApplic.DisplayAlerts = WdAlertLevel.wdAlertsNone;
			Microsoft.Office.Interop.Word.Application application = oWordApplic;
			object SaveChanges = Missing.Value;
			object OriginalFormat = Missing.Value;
			object RouteDocument = Missing.Value;
			application.Quit(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
			Marshal.ReleaseComObject(oWordApplic);
			oWordApplic = null;
		}
	}

	public static void CloseAllDocuments()
	{
		oWordApplic.Visible = false;
		oWordApplic.DisplayAlerts = WdAlertLevel.wdAlertsNone;
		Documents documents = oWordApplic.Documents;
		object SaveChanges = WdSaveOptions.wdDoNotSaveChanges;
		object OriginalFormat = Missing.Value;
		object RouteDocument = Missing.Value;
		documents.Close(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
	}

	public static void CloseCurrentDocument()
	{
		oWordApplic.Visible = false;
		oWordApplic.DisplayAlerts = WdAlertLevel.wdAlertsNone;
		Document document = oDocument1;
		object SaveChanges = WdSaveOptions.wdDoNotSaveChanges;
		object OriginalFormat = Missing.Value;
		object RouteDocument = Missing.Value;
		document.Close(ref SaveChanges, ref OriginalFormat, ref RouteDocument);
	}

	public static void SaveAs(string FileName)
	{
		Missing value = Missing.Value;
		string text = FileName;
		Document document = oDocument;
		object FileName2 = text;
		object FileFormat = value;
		object LockComments = value;
		object Password = value;
		object AddToRecentFiles = value;
		object WritePassword = value;
		object ReadOnlyRecommended = value;
		object EmbedTrueTypeFonts = value;
		object SaveNativePictureFormat = value;
		object SaveFormsData = value;
		object SaveAsAOCELetter = value;
		object Encoding = value;
		object InsertLineBreaks = value;
		object AllowSubstitutions = value;
		object LineEnding = value;
		object AddBiDiMarks = value;
		document.SaveAs(ref FileName2, ref FileFormat, ref LockComments, ref Password, ref AddToRecentFiles, ref WritePassword, ref ReadOnlyRecommended, ref EmbedTrueTypeFonts, ref SaveNativePictureFormat, ref SaveFormsData, ref SaveAsAOCELetter, ref Encoding, ref InsertLineBreaks, ref AllowSubstitutions, ref LineEnding, ref AddBiDiMarks);
		value = (Missing)AddBiDiMarks;
		value = (Missing)LineEnding;
		value = (Missing)AllowSubstitutions;
		value = (Missing)InsertLineBreaks;
		value = (Missing)Encoding;
		value = (Missing)SaveAsAOCELetter;
		value = (Missing)SaveFormsData;
		value = (Missing)SaveNativePictureFormat;
		value = (Missing)EmbedTrueTypeFonts;
		value = (Missing)ReadOnlyRecommended;
		value = (Missing)WritePassword;
		value = (Missing)AddToRecentFiles;
		value = (Missing)Password;
		value = (Missing)LockComments;
		value = (Missing)FileFormat;
		text = Conversions.ToString(FileName2);
	}

	public static void InsertText(string text)
	{
		oWordApplic.Selection.TypeText(text);
	}

	public static void OpenFile(string FileName, bool isReadOnly)
	{
		Missing value = Missing.Value;
		string text = FileName;
		Documents documents = oWordApplic.Documents;
		object FileName2 = text;
		object ConfirmConversions = value;
		object ReadOnly = isReadOnly;
		object AddToRecentFiles = value;
		object PasswordDocument = value;
		object PasswordTemplate = value;
		object Revert = value;
		object WritePasswordDocument = value;
		object WritePasswordTemplate = value;
		object Format = value;
		object Encoding = value;
		object Visible = true;
		object OpenAndRepair = value;
		object DocumentDirection = value;
		object NoEncodingDialog = value;
		object XMLTransform = value;
		Document document = documents.Open(ref FileName2, ref ConfirmConversions, ref ReadOnly, ref AddToRecentFiles, ref PasswordDocument, ref PasswordTemplate, ref Revert, ref WritePasswordDocument, ref WritePasswordTemplate, ref Format, ref Encoding, ref Visible, ref OpenAndRepair, ref DocumentDirection, ref NoEncodingDialog, ref XMLTransform);
		value = (Missing)XMLTransform;
		value = (Missing)NoEncodingDialog;
		value = (Missing)DocumentDirection;
		value = (Missing)OpenAndRepair;
		Conversions.ToBoolean(Visible);
		value = (Missing)Encoding;
		value = (Missing)Format;
		value = (Missing)WritePasswordTemplate;
		value = (Missing)WritePasswordDocument;
		value = (Missing)Revert;
		value = (Missing)PasswordTemplate;
		value = (Missing)PasswordDocument;
		value = (Missing)AddToRecentFiles;
		isReadOnly = Conversions.ToBoolean(ReadOnly);
		value = (Missing)ConfirmConversions;
		text = Conversions.ToString(FileName2);
		oDocument1 = document;
		oDocument1.Activate();
	}

	public static void FuzhiAll()
	{
		oWordApplic.Selection.WholeStory();
		oWordApplic.Selection.Copy();
	}

	public static void Zhantie()
	{
		oWordApplic.Selection.PasteExcelTable(LinkedToExcel: false, WordFormatting: false, RTF: true);
	}

	public static void InsertTable(ref DataTable table)
	{
		int num = 1;
		int num2 = 0;
		checked
		{
			int numRows = table.Rows.Count + 1;
			int count = table.Columns.Count;
			Tables tables = oDocument.Tables;
			Microsoft.Office.Interop.Word.Range range = oWordApplic.Selection.Range;
			object DefaultTableBehavior = Missing.Value;
			object AutoFitBehavior = Missing.Value;
			Table table2 = tables.Add(range, numRows, count, ref DefaultTableBehavior, ref AutoFitBehavior);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = table.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataColumn dataColumn = (DataColumn)enumerator.Current;
					num2++;
					table2.Cell(1, num2).Range.InsertAfter(dataColumn.ColumnName);
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
				enumerator2 = table.Rows.GetEnumerator();
				IEnumerator enumerator3 = default(IEnumerator);
				while (enumerator2.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator2.Current;
					num++;
					num2 = 0;
					try
					{
						enumerator3 = table.Columns.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataColumn dataColumn = (DataColumn)enumerator3.Current;
							num2++;
							table2.Cell(num, num2).Range.InsertAfter(Conversions.ToString(dataRow[dataColumn.ColumnName]));
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
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
			table2.AllowAutoFit = true;
			table2.ApplyStyleFirstColumn = true;
			table2.ApplyStyleHeadingRows = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void HQbiaoqian(string path1)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Invalid comparison between Unknown and I4
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			p = path1;
			if (Process.GetProcessesByName("WINWORD").Length < 0)
			{
				MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"当前已打开某Word文件或进程中存在某WINWORD.EXE,运行本操作前请关闭该word文件或当前进程中的WINWORD.EXE");
				return;
			}
			string text = p + "\\test.doc";
			if (File.Exists(text))
			{
				if ((int)MessageBox.Show("当前 " + p + " 目录下已经存在test.doc，是否覆盖？", "提示", (MessageBoxButtons)4, (MessageBoxIcon)64) == 7)
				{
					MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"当前操作终止.");
					return;
				}
				FileSystem.Kill(text);
			}
			limitcols = 15;
			if (limitcols == 0)
			{
				limitcols = 1;
			}
			bool flag = false;
			string text2 = Mod1.Kulujing + "\\qyxxn\\QAY.dot";
			checked
			{
				if (File.Exists(text2))
				{
					Guid clsid = new Guid("000209FF-0000-0000-C000-000000000046");
					oWordApplic = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					NewDocWithModel(text2);
					oWordApplic.Visible = MyProject.Forms.jsbaogao.CBXchuli.get_Checked();
					((Control)MyProject.Forms.jsbaogao.btnstop).set_Enabled(true);
					int num = 0;
					MyProject.Forms.jsbaogao.PBX1.set_Maximum(oDocument.Bookmarks.Count);
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = oDocument.Bookmarks.GetEnumerator();
						while (enumerator.MoveNext())
						{
							bm = (Bookmark)enumerator.Current;
							Application.DoEvents();
							num++;
							string text3 = "**** 正在进行:" + Conversions.ToString(num) + "/" + Conversions.ToString(oDocument.Bookmarks.Count);
							oWordApplic.StatusBar = text3;
							MyProject.Forms.jsbaogao.PBX1.set_Value(num);
							MyProject.Forms.jsbaogao.lbjd.set_Text(Conversions.ToString((int)Math.Round((double)num / (double)oDocument.Bookmarks.Count * 100.0)) + "%");
							((Control)MyProject.Forms.jsbaogao.lbjd).Refresh();
							Application.DoEvents();
							MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"");
							MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)(text3 + ", 书签名称: " + bm.Name));
							MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
							string[] array = Strings.Split(bm.Name, "a", -1, (CompareMethod)0);
							switch (array[0])
							{
							case "单项性能":
							{
								string[] array2 = Strings.Split(array[1], "b", -1, (CompareMethod)0);
								strwhich = array2[0];
								strf = array2[1];
								int num2 = Strings.InStr(1, strwhich, "j", (CompareMethod)0);
								if (num2 > 0)
								{
									strwhich = Strings.Replace(strwhich, "j", "+", 1, -1, (CompareMethod)0);
								}
								switch (strwhich)
								{
								default:
									MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("书签名称" + bm.Name + "定义错误,没有相应的结构形式处理." + strwhich));
									MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
									break;
								case "主臂+固定副臂":
								case "主臂+固定副臂+超起":
								case "主臂+塔式副臂":
								case "主臂+塔式副臂+超起":
								{
									fbsubpathsearch(strwhich);
									int num4 = ll_lbyx.Count - 1;
									for (int j = 0; j <= num4; j++)
									{
										int num5 = ll_lbxt.Count - 1;
										for (int k = 0; k <= num5; k++)
										{
											stryx = Conversions.ToString(ll_lbyx[j]);
											strxt = Conversions.ToString(ll_lbxt[k]);
											string curf = p + strwhich + "\\" + stryx + "\\" + strxt + "\\" + strf + ".xls";
											if (File.Exists(curf))
											{
												onlyinsert2curbookmark(curf, strf, bm.Name);
												continue;
											}
											MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("不存在相应文件." + curf));
											MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
										}
									}
									break;
								}
								case "主臂":
								case "主臂+超起":
								{
									string curf = p + "\\" + strwhich + "\\" + strf + ".xls";
									if (File.Exists(curf))
									{
										onlyinsert2curbookmark(curf, strf, bm.Name);
										break;
									}
									MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("不存在相应文件." + curf));
									MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
									break;
								}
								}
								break;
							}
							case "合成性能":
							{
								strwhich = array[1];
								int num2 = Strings.InStr(1, strwhich, "j", (CompareMethod)0);
								if (num2 > 0)
								{
									strwhich = Strings.Replace(strwhich, "j", "+", 1, -1, (CompareMethod)0);
								}
								resultxlssearch(strwhich);
								switch (strwhich)
								{
								default:
									MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("书签名称" + bm.Name + "定义错误,没有相应的结构形式处理." + strwhich));
									MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
									break;
								case "主臂":
								case "主臂+超起":
								case "主臂+固定副臂":
								case "主臂+固定副臂+超起":
								case "主臂+塔式副臂":
								case "主臂+塔式副臂+超起":
									MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"");
									if (ll_lbxlslist.Count > 0)
									{
										int num3 = ll_lbxlslist.Count - 1;
										for (int i = 0; i <= num3; i++)
										{
											string curf = Conversions.ToString(ll_lbxlslist[i]);
											resultinsert2curbookmark(curf, bm.Name, Conversions.ToString(i + 1) + "/" + Conversions.ToString(ll_lbxlslist.Count));
										}
									}
									else
									{
										MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)(strwhich + "下没有待合成的性能表."));
										MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
									}
									break;
								}
								break;
							}
							default:
								MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("书签名称" + bm.Name + "定义错误,没有相应的信息处理." + array[0]));
								MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
								break;
							case "参数":
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
					Selection selection = oWordApplic.Selection;
					object What = 1;
					object Which = Missing.Value;
					object Count = Missing.Value;
					object Name = Missing.Value;
					selection.GoTo(ref What, ref Which, ref Count, ref Name);
					Selection selection2 = oWordApplic.Selection;
					Name = 3;
					Count = Missing.Value;
					Which = Missing.Value;
					selection2.MoveRight(ref Name, ref Count, ref Which);
					InsterMULU();
					SaveAs(text);
					CloseAllDocuments();
					Quit();
					MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"");
					MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("处理完毕.请看文件;" + text));
					MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
					if (flag)
					{
						Interaction.MsgBox((object)"找到表格列数超过15列的表格!如有必要请仔细查看相应表格.", (MsgBoxStyle)0, (object)"提示");
					}
				}
				else
				{
					MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("没有找到合法的报告模版文件:" + text2));
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			if (!jsbgexit)
			{
				Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
			}
			ProjectData.ClearProjectError();
		}
	}

	public static void InsertPageBreak()
	{
	}

	public static void jindu(float val)
	{
		MyProject.Forms.jsbaogao.PBX1.set_Value(checked((int)Math.Round(Conversion.Int(val * 100f))));
		MyProject.Forms.jsbaogao.lbjd.set_Text(Conversions.ToString(Conversion.Int(val * 100f)) + "%");
		((Control)MyProject.Forms.jsbaogao.lbjd).Refresh();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private static void fbsubpathsearch(string strwhich)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Invalid comparison between Unknown and I4
		if (Operators.CompareString(Strings.Right(p, 1), "\\", false) != 0)
		{
			p += "\\";
		}
		Mod1.strpath = p + strwhich;
		if (Operators.CompareString(Strings.Right(Mod1.strpath, 1), "\\", false) != 0)
		{
			Mod1.strpath += "\\";
		}
		string text = FileSystem.Dir(Mod1.strpath, (FileAttribute)16);
		ll_lbyx.Clear();
		while (Operators.CompareString(text, "", false) != 0)
		{
			if ((FileSystem.GetAttr(Mod1.strpath + text) & 0x10) == 16 && ((Operators.CompareString(text, ".", false) != 0) & (Operators.CompareString(text, "..", false) != 0) & (Operators.CompareString(text, "合成", false) != 0)))
			{
				ll_lbyx.Add(text);
			}
			text = FileSystem.Dir();
		}
		ll_lbxt.Clear();
		checked
		{
			int num = ll_lbyx.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				Mod1.strpath = Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(p + strwhich, "\\"), ll_lbyx[i]));
				if (Operators.CompareString(Strings.Right(Mod1.strpath, 1), "\\", false) != 0)
				{
					Mod1.strpath += "\\";
				}
				text = FileSystem.Dir(Mod1.strpath, (FileAttribute)16);
				while (Operators.CompareString(text, "", false) != 0)
				{
					if ((FileSystem.GetAttr(Mod1.strpath + text) & 0x10) == 16 && ((Operators.CompareString(text, ".", false) != 0) & (Operators.CompareString(text, "..", false) != 0)))
					{
						ll_lbxt.Add(text);
					}
					text = FileSystem.Dir();
				}
			}
		}
	}

	public static void delnullrow(Table tb)
	{
		if (tb.Columns.Count >= 2)
		{
			Shading shading = tb.Rows[1].Shading;
			shading.Texture = WdTextureIndex.wdTextureNone;
			shading.ForegroundPatternColor = WdColor.wdColorAutomatic;
			shading.BackgroundPatternColor = WdColor.wdColorGray35;
			shading = null;
		}
	}

	public static void onlyinsert2curbookmark(string curf, string strf, string curbookmarkname)
	{
		//IL_0851: Unknown result type (might be due to invalid IL or missing references)
		//IL_0891: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"");
				if (File.Exists(Application.get_StartupPath() + "\\config\\ALL.xls"))
				{
					string filename = Application.get_StartupPath() + "\\config\\ALL.xls";
					Worksheet worksheet = (Worksheet)Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value).Sheets["ALL"];
					string text = "性能数据表";
					_ = strf + ".xls";
					int num = 0;
					worksheet.Cells.Delete(Missing.Value);
					Workbook workbook = Mod1.excelapp.Workbooks.Open(curf, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
					IEnumerator enumerator = default(IEnumerator);
					try
					{
						enumerator = workbook.Worksheets.GetEnumerator();
						string text4 = default(string);
						while (enumerator.MoveNext())
						{
							Worksheet worksheet2 = (Worksheet)enumerator.Current;
							Application.DoEvents();
							text = worksheet2.Name;
							if (!((Operators.CompareString(Strings.UCase(text), "ALL", false) != 0) & (Operators.CompareString(Strings.UCase(text), "ALLTEMP", false) != 0)))
							{
								continue;
							}
							num++;
							string text2 = Conversions.ToString(num) + "/" + Conversions.ToString(workbook.Worksheets.Count - 2);
							worksheet2.Cells.HorizontalAlignment = Constants.xlCenter;
							worksheet2.Cells.VerticalAlignment = Constants.xlCenter;
							Excel.Font font = worksheet2.Cells.Font;
							font.Name = "宋体";
							font.FontStyle = "常规";
							font.Size = 10;
							font.ColorIndex = Constants.xlAutomatic;
							font = null;
							worksheet2.Cells.EntireColumn.AutoFit();
							worksheet2.Cells.EntireRow.AutoFit();
							worksheet2.Cells.Copy(((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value));
							Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
							string text3;
							for (int i = currentRegion.Rows.Count - 1; i >= 2; i += -1)
							{
								bool flag = true;
								int count = currentRegion.Columns.Count;
								for (int j = 2; j <= count; j++)
								{
									text3 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[i, j], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
									if (!((double)Conversions.ToSingle(text3) <= 1E-05))
									{
										flag = false;
										break;
									}
								}
								if (flag)
								{
									NewLateBinding.LateCall(worksheet.Rows[i, Missing.Value], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
								}
							}
							text3 = "";
							currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
							if (currentRegion.Columns.Count > limitcols)
							{
								text3 = ", 列数:" + Conversions.ToString(currentRegion.Columns.Count);
							}
							currentRegion.Copy(Missing.Value);
							switch (strwhich)
							{
							case "主臂+塔式副臂":
							case "主臂+塔式副臂+超起":
							{
								string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
								switch (strf)
								{
								default:
									text4 = "主臂仰角:" + strxt + ", 控制准则:" + strf + ", 副臂长度:" + array[1];
									break;
								case "半伸_支腿":
								case "半伸_倾翻":
								case "全伸_支腿":
								case "全伸_倾翻":
								case "回转支撑":
									text4 = "主臂仰角:" + strxt + ", 控制准则:" + strf + ", 配重:" + array[0] + ", 副臂长度:" + array[1];
									break;
								}
								break;
							}
							case "主臂+固定副臂":
							case "主臂+固定副臂+超起":
							{
								string[] array = Strings.Split(text, "_", -1, (CompareMethod)0);
								switch (strf)
								{
								default:
									text4 = "安装角度:" + strxt + ", 控制准则:" + strf + ", 副臂长度:" + array[1];
									break;
								case "半伸_支腿":
								case "半伸_倾翻":
								case "全伸_支腿":
								case "全伸_倾翻":
								case "回转支撑":
									text4 = "安装角度:" + strxt + ", 控制准则:" + strf + ", 配重:" + array[0] + ", 副臂长度:" + array[1];
									break;
								}
								break;
							}
							case "主臂":
							case "主臂+超起":
								switch (strf)
								{
								default:
									text4 = "控制准则:" + strf;
									break;
								case "半伸_支腿":
								case "半伸_倾翻":
								case "全伸_支腿":
								case "全伸_倾翻":
								case "回转支撑":
									text4 = "控制准则:" + strf + ", 配重:" + text;
									break;
								}
								break;
							}
							Microsoft.Office.Interop.Word.Application application = oWordApplic;
							Selection selection = application.Selection;
							object What = WdGoToItem.wdGoToBookmark;
							object Which = Missing.Value;
							object Count = Missing.Value;
							object Name = curbookmarkname;
							selection.GoTo(ref What, ref Which, ref Count, ref Name);
							curbookmarkname = Conversions.ToString(Name);
							Selection selection2 = application.Selection;
							Styles styles = application.ActiveDocument.Styles;
							Count = "标题 4";
							Name = styles[ref Count];
							selection2.Style = ref Name;
							application.Selection.TypeText(text4);
							application.Selection.TypeParagraph();
							application.Selection.PasteExcelTable(LinkedToExcel: false, WordFormatting: false, RTF: true);
							application = null;
							tb = oWordApplic.Selection.Tables[1];
							WordFormatEnhance();
							currentRegion = null;
							text3 = text2 + " 处理完毕." + curf + ", 表格:" + text + text3;
							MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)text3);
							MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
						}
					}
					finally
					{
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					workbook.Saved = true;
					workbook.Close(Missing.Value, Missing.Value, Missing.Value);
				}
				else
				{
					string filename = default(string);
					Interaction.MsgBox((object)("没有找到文件：" + filename + " 程序执行失败！"), (MsgBoxStyle)64, (object)"提示");
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				if (!jsbgexit)
				{
					Interaction.MsgBox((object)(ex2.Message.ToString() + "\r" + ex2.StackTrace!.ToString()), (MsgBoxStyle)64, (object)"提示");
				}
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void WordFormatEnhance()
	{
		tb.Rows[1].HeadingFormat = -1;
		Shading shading = tb.Rows[1].Shading;
		shading.Texture = WdTextureIndex.wdTextureNone;
		shading.BackgroundPatternColor = WdColor.wdColorGray25;
		shading = null;
		tb.Borders[WdBorderType.wdBorderLeft].LineStyle = WdLineStyle.wdLineStyleSingle;
		tb.Borders[WdBorderType.wdBorderRight].LineStyle = WdLineStyle.wdLineStyleSingle;
		tb.Borders[WdBorderType.wdBorderTop].LineStyle = WdLineStyle.wdLineStyleSingle;
		tb.Borders[WdBorderType.wdBorderBottom].LineStyle = WdLineStyle.wdLineStyleSingle;
		tb.Borders[WdBorderType.wdBorderHorizontal].LineStyle = WdLineStyle.wdLineStyleSingle;
		tb.Borders[WdBorderType.wdBorderVertical].LineStyle = WdLineStyle.wdLineStyleSingle;
		tb.Borders[WdBorderType.wdBorderDiagonalDown].LineStyle = WdLineStyle.wdLineStyleNone;
		tb.Borders[WdBorderType.wdBorderDiagonalUp].LineStyle = WdLineStyle.wdLineStyleNone;
		tb.Borders.Shadow = false;
		tb.AutoFitBehavior(WdAutoFitBehavior.wdAutoFitWindow);
		tb.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
		tb.Range.Font.Size = 10.5f;
		tb.Range.Font.Color = WdColor.wdColorBlack;
	}

	private static void resultxlssearch(string strwhich)
	{
		Mod1.strpath = p + strwhich + "\\合成\\";
		ll_lbxlslist.Clear();
		checked
		{
			if (Directory.Exists(Mod1.strpath))
			{
				if (Operators.CompareString(Strings.Trim(Mod1.strpath), "", false) != 0)
				{
					MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)"");
					MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("当前要处理的xls路径:" + Mod1.strpath));
					MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
					string[] files = Directory.GetFiles(Mod1.strpath, "*.xls", SearchOption.AllDirectories);
					int num = files.Count() - 1;
					for (int i = 0; i <= num; i++)
					{
						ll_lbxlslist.Add(files[i]);
					}
				}
			}
			else
			{
				MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)("不存在合成文件夹:" + Mod1.strpath));
				MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
			}
		}
	}

	public static void resultinsert2curbookmark(string curf, string curbookmarkname, string strjsq)
	{
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (File.Exists(Application.get_StartupPath() + "\\config\\ALL.xls"))
			{
				string filename = Application.get_StartupPath() + "\\config\\ALL.xls";
				Worksheet worksheet = (Worksheet)Mod1.excelapp.Workbooks.Open(filename, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value).Sheets["ALL"];
				string text = "性能数据表";
				Application.DoEvents();
				string[] array = Strings.Split(curf, "\\", -1, (CompareMethod)0);
				string text2 = array[Information.UBound((Array)array, 1)];
				string text3 = Strings.Left(text2, Strings.Len(text2) - 4);
				worksheet.Cells.Delete(Missing.Value);
				Workbook workbook = Mod1.excelapp.Workbooks.Open(curf, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
				Worksheet worksheet2 = (Worksheet)workbook.Worksheets[text];
				worksheet2.Cells.HorizontalAlignment = Constants.xlCenter;
				worksheet2.Cells.VerticalAlignment = Constants.xlCenter;
				Excel.Font font = worksheet2.Cells.Font;
				font.Name = "宋体";
				font.FontStyle = "常规";
				font.Size = 10;
				font.ColorIndex = Constants.xlAutomatic;
				font = null;
				worksheet2.Cells.EntireColumn.AutoFit();
				worksheet2.Cells.EntireRow.AutoFit();
				worksheet2.Cells.Copy(((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value));
				workbook.Saved = true;
				workbook.Close(Missing.Value, Missing.Value, Missing.Value);
				Excel.Range currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
				string text4;
				for (int i = currentRegion.Rows.Count - 1; i >= 2; i += -1)
				{
					bool flag = true;
					int count = currentRegion.Columns.Count;
					for (int j = 2; j <= count; j++)
					{
						text4 = Conversions.ToString(NewLateBinding.LateGet(worksheet.Cells[i, j], (Type)null, "value", new object[0], (string[])null, (Type[])null, (bool[])null));
						if (!((double)Conversions.ToSingle(text4) <= 1E-05))
						{
							flag = false;
							break;
						}
					}
					if (flag)
					{
						NewLateBinding.LateCall(worksheet.Rows[i, Missing.Value], (Type)null, "Delete", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
				text4 = "";
				currentRegion = ((_Worksheet)worksheet).get_Range((object)"A1", (object)Missing.Value).CurrentRegion;
				if (currentRegion.Columns.Count > limitcols)
				{
					text4 = ", 列数:" + Conversions.ToString(currentRegion.Columns.Count);
				}
				currentRegion.Copy(Missing.Value);
				string text5 = text3;
				Microsoft.Office.Interop.Word.Application application = oWordApplic;
				Selection selection = application.Selection;
				object What = WdGoToItem.wdGoToBookmark;
				object Which = Missing.Value;
				object Count = Missing.Value;
				object Name = curbookmarkname;
				selection.GoTo(ref What, ref Which, ref Count, ref Name);
				curbookmarkname = Conversions.ToString(Name);
				Selection selection2 = application.Selection;
				Styles styles = application.ActiveDocument.Styles;
				Count = "标题 4";
				Name = styles[ref Count];
				selection2.Style = ref Name;
				application.Selection.TypeText(text5);
				application.Selection.TypeParagraph();
				application.Selection.PasteExcelTable(LinkedToExcel: false, WordFormatting: false, RTF: true);
				application = null;
				tb = oWordApplic.Selection.Tables[1];
				WordFormatEnhance();
				currentRegion = null;
				text4 = strjsq + " 处理完毕." + curf + ", 表格:" + text + text4;
				MyProject.Forms.jsbaogao.lb1.get_Items().Add((object)text4);
				MyProject.Forms.jsbaogao.lb1.set_SelectedIndex(MyProject.Forms.jsbaogao.lb1.get_Items().get_Count() - 1);
			}
			else
			{
				string filename = default(string);
				Interaction.MsgBox((object)("没有找到文件：" + filename + " 程序执行失败！"), (MsgBoxStyle)64, (object)"提示");
			}
		}
	}

	public static void GotoTheBegining()
	{
		Missing value = Missing.Value;
		Selection selection = oWordApplic.Selection;
		object Unit = WdUnits.wdStory;
		object Extend = value;
		selection.HomeKey(ref Unit, ref Extend);
		value = (Missing)Extend;
		Conversions.ToInteger(Unit);
	}
}
