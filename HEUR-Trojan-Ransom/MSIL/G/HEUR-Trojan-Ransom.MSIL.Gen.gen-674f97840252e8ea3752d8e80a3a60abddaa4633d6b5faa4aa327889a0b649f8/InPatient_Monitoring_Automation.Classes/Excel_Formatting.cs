using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace InPatient_Monitoring_Automation.Classes;

internal class Excel_Formatting
{
	private string first_file;

	private string sec_file;

	private string[] result;

	private string firstpath;

	private string secondpath;

	private string[] stringSeparators = new string[1] { "_" };

	private FileInfo[] fi;

	private Workbook wb;

	private Workbook temp_1;

	private Worksheet worksheet;

	private DataSet _tab_Subcode_distinct;

	private DataSet _tab_Subcode;

	public Log rename(string path)
	{
		Log log = new Log();
		string[] separator = new string[2] { ".", "_" };
		_ = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		DirectoryInfo directoryInfo = new DirectoryInfo(path);
		fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
		int num = fi.Length;
		if (num == 0)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>rename";
			log.exception = "No files in the Directory";
			return log;
		}
		try
		{
			if (num == _tab_Subcode.Tables[0].Rows.Count)
			{
				for (int i = 0; i < num; i++)
				{
					fi[i].FullName.Trim();
					string text = fi[i].FullName.Trim();
					string[] array = text.Split(separator, StringSplitOptions.None);
					int count = _tab_Subcode.Tables[0].Rows.Count;
					for (int j = 0; j < count; j++)
					{
						if (_tab_Subcode.Tables[0].Rows[j].ItemArray[2]!.ToString()!.Trim() == array[1].Trim())
						{
							string text2 = _tab_Subcode.Tables[0].Rows[j].ItemArray[4]!.ToString()!.Trim();
							string destFileName = array[0].Trim() + "_" + array[1].Trim() + "_" + text2.Trim() + "." + array[2].Trim();
							File.Move(text, destFileName);
						}
					}
				}
				log.status = true;
				log.method = "Excel_Formatting=>Excel_Data=>rename";
				log.exception = "No issues";
				return log;
			}
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>rename";
			log.exception = "File download failed";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>rename";
			log.exception = "Error while renaming the excel files: " + ex.Message.ToString();
			return log;
		}
	}

	public Log sub_office_code()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		Log log = new Log();
		string text = global_variable.user_def_path + "\\Sub_Office_Codes.xlsx";
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text.Trim() + ";Extended Properties=Excel 12.0");
		OleDbConnection val2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text.Trim() + ";Extended Properties=Excel 12.0");
		try
		{
			OleDbConnection val3 = val2;
			try
			{
				OleDbDataAdapter val4 = new OleDbDataAdapter("SELECT [Policy_No], [Cert_No] ,[Claim_ID],[Sub_Office_Code],[ID] FROM [Sheet1$] where [Policy_No] IS NOT NULL", val2);
				_tab_Subcode = new DataSet();
				new OleDbDataAdapter();
				((DataAdapter)val4).Fill(_tab_Subcode);
				((Component)(object)val).Dispose();
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
			log.status = true;
			log.method = "Excel_Formatting=>Excel_Data=>sub_office_code";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>rename";
			log.exception = "Error while reading sub office code file: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (((DbConnection)(object)val2).State == ConnectionState.Open)
			{
				((DbConnection)(object)val2).Close();
				((Component)(object)val2).Dispose();
			}
		}
	}

	public Log unique_ID()
	{
		Log log = new Log();
		try
		{
			int count = _tab_Subcode_distinct.Tables[0].Rows.Count;
			string[] array = new string[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = _tab_Subcode_distinct.Tables[0].Rows[i].ItemArray[0]!.ToString()!.Trim();
			}
			log.status = true;
			log.method = "Excel_Formatting=>Excel_Data=>unique_ID";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>unique_ID";
			log.exception = "Error while reading distinct sub office codes from sub office code file: " + ex.Message.ToString();
			return log;
		}
	}

	public Log copydata(string path)
	{
		Log log = new Log();
		try
		{
			Application application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
			int num = fi.Length;
			for (int i = 0; i < num && num != i + 1; i++)
			{
				string text = fi[i].Name.Trim();
				result = text.Split(stringSeparators, StringSplitOptions.None);
				first_file = result[2].Trim();
				firstpath = fi[i].FullName.Trim();
				temp_1 = application.Workbooks.Open(firstpath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				_ = temp_1.Worksheets[1];
				for (int j = 1; j < num; j++)
				{
					if (i == j)
					{
						j++;
					}
					string text2 = fi[j].Name.Trim();
					result = text2.Split(stringSeparators, StringSplitOptions.None);
					sec_file = result[2].Trim();
					if (first_file == sec_file)
					{
						secondpath = fi[j].FullName.Trim();
						Workbook workbook = application.Workbooks.Open(secondpath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
						Worksheet obj = workbook.Worksheets[1] as Worksheet;
						obj.UsedRange.Copy(Type.Missing);
						temp_1.Worksheets.Add(Type.Missing, Type.Missing, Type.Missing, Type.Missing);
						Worksheet worksheet = temp_1.Worksheets[1] as Worksheet;
						Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)obj).get_Range((object)"A1:Z1000", Type.Missing);
						Microsoft.Office.Interop.Excel.Range destination = ((_Worksheet)worksheet).get_Range((object)"A1:Z1000", Type.Missing);
						range.Copy(destination);
						temp_1.Save();
						workbook.Close(0, Type.Missing, Type.Missing);
						File.Delete(fi[j].FullName);
						num--;
						fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
						j--;
					}
				}
				temp_1.Save();
				temp_1.Close(0, Type.Missing, Type.Missing);
				application.Quit();
			}
			log.status = true;
			log.method = "Excel_Formatting=>Excel_Data=>copydata";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>copydata";
			log.exception = "Error while merging excel files: " + ex.Message.ToString();
			return log;
		}
	}

	public Log excel_format(string path)
	{
		Log log = new Log();
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
			int num = fi.Length;
			for (int i = 0; i < num; i++)
			{
				Application application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				string filename = fi[i].FullName.Trim();
				Workbook workbook = application.Workbooks.Open(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				int count = workbook.Sheets.Count;
				for (int j = 1; j <= count; j++)
				{
					Worksheet obj = workbook.Worksheets[j] as Worksheet;
					Microsoft.Office.Interop.Excel.Range usedRange = obj.UsedRange;
					usedRange.BorderAround(XlLineStyle.xlContinuous, XlBorderWeight.xlThin, XlColorIndex.xlColorIndexAutomatic, XlColorIndex.xlColorIndexAutomatic);
					usedRange.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlContinuous;
					usedRange.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlContinuous;
					usedRange.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlContinuous;
					usedRange.Borders.get_Item(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlContinuous;
					usedRange.Columns.AutoFit();
					usedRange.WrapText = true;
					usedRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;
					usedRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
					Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)obj).get_Range((object)"a1", (object)"q3");
					range.Borders.get_Item(XlBordersIndex.xlEdgeLeft).LineStyle = XlLineStyle.xlLineStyleNone;
					range.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlLineStyleNone;
					range.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlLineStyleNone;
					range.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlLineStyleNone;
					range.Borders.get_Item(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlLineStyleNone;
					Microsoft.Office.Interop.Excel.Range range2 = ((_Worksheet)obj).get_Range((object)"n4", (object)"q6");
					range2.Borders.get_Item(XlBordersIndex.xlEdgeRight).LineStyle = XlLineStyle.xlLineStyleNone;
					range2.Borders.get_Item(XlBordersIndex.xlEdgeTop).LineStyle = XlLineStyle.xlLineStyleNone;
					range2.Borders.get_Item(XlBordersIndex.xlInsideHorizontal).LineStyle = XlLineStyle.xlLineStyleNone;
					range2.Borders.get_Item(XlBordersIndex.xlInsideVertical).LineStyle = XlLineStyle.xlLineStyleNone;
					range2.Borders.get_Item(XlBordersIndex.xlEdgeBottom).LineStyle = XlLineStyle.xlLineStyleNone;
					Microsoft.Office.Interop.Excel.Range cell = ((_Worksheet)obj).get_Range((object)"A4", Type.Missing).get_End(XlDirection.xlToRight);
					Microsoft.Office.Interop.Excel.Range range3 = ((_Worksheet)obj).get_Range((object)"A4", (object)cell);
					range3.Interior.ColorIndex = 29;
					range3.Font.ColorIndex = 2;
					range3.Font.Bold = true;
					range3.WrapText = false;
					Microsoft.Office.Interop.Excel.Range cell2 = ((_Worksheet)obj).get_Range((object)"A7", Type.Missing).get_End(XlDirection.xlToRight);
					Microsoft.Office.Interop.Excel.Range range4 = ((_Worksheet)obj).get_Range((object)"A7", (object)cell2);
					range4.Interior.ColorIndex = 29;
					range4.Font.Bold = true;
					range4.Font.ColorIndex = 2;
					range4.WrapText = false;
					string text = ((_Worksheet)obj).get_Range((object)"g5", (object)"g5").get_Value(Type.Missing).ToString()!.Trim();
					obj.Name = text.Trim();
					Microsoft.Office.Interop.Excel.Range range5 = ((_Worksheet)obj).get_Range((object)"c1", (object)"c3");
					object value = range5.get_Value(Type.Missing);
					((_Worksheet)obj).get_Range((object)"a1", (object)"a1").set_Value(Type.Missing, value);
					range5.set_Value(Type.Missing, (object)"");
					Microsoft.Office.Interop.Excel.Range range6 = ((_Worksheet)obj).get_Range((object)"a1", (object)"m1");
					range6.WrapText = false;
					range6.MergeCells = true;
					range6.Font.ColorIndex = 2;
					range6.Interior.ColorIndex = 29;
					range6.Font.Bold = true;
					usedRange.Columns.AutoFit();
					((_Worksheet)obj).get_Range((object)"p1", (object)Missing.Value).EntireColumn.Delete(Missing.Value);
				}
				workbook.Save();
				workbook.Close(0, Type.Missing, Type.Missing);
				application.Quit();
				Marshal.ReleaseComObject(application);
			}
			log.status = true;
			log.method = "Excel_Formatting=>Excel_Data=>excel_format";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>excel_format";
			log.exception = "Excel Formatting Error: " + ex.Message.ToString();
			return log;
		}
	}

	public Log nda(string path)
	{
		Log log = new Log();
		try
		{
			_ = new string[2] { " ", "0" };
			Application application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
			int num = fi.Length;
			for (int i = 0; i < num; i++)
			{
				_ = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
				string filename = fi[i].FullName.Trim();
				wb = application.Workbooks.Open(filename, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
				worksheet = wb.Worksheets[1] as Worksheet;
				string name = ((_Worksheet)worksheet).get_Range((object)"b5", (object)"b5").get_Value(Type.Missing).ToString()!.Trim();
				config_File(name);
				wb.Save();
				wb.Close(0, Type.Missing, Type.Missing);
				application.Quit();
			}
			Marshal.ReleaseComObject(application);
			log.status = true;
			log.method = "Excel_Formatting=>Excel_Data=>nda";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>nda";
			log.exception = "Error getting NDA status: " + ex.Message.ToString();
			return log;
		}
	}

	public Log config_File(string name)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		Log log = new Log();
		string text = global_variable.user_def_path + "\\Master Policy.xlsx";
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text.Trim() + ";Extended Properties=Excel 12.0");
		try
		{
			((DbConnection)(object)val).Open();
			OleDbDataAdapter val2 = new OleDbDataAdapter("SELECT [PERUSAHAAN], [NDA] FROM [Master_Policy_List$] where [POLIS NO] IS NOT NULL", val);
			DataSet dataSet = new DataSet();
			((DataAdapter)val2).Fill(dataSet);
			int num = 0;
			int num2 = 0;
			for (num2 = 0; num2 <= dataSet.Tables[0].Rows.Count - 1; num2++)
			{
				if (!(name == dataSet.Tables[0].Rows[num2].ItemArray[0]!.ToString()!.Trim()))
				{
					continue;
				}
				num = num2;
				string text2 = dataSet.Tables[0].Rows[num].ItemArray[1]!.ToString()!.Trim();
				int count = wb.Sheets.Count;
				if (text2 != "NDA")
				{
					for (int i = 1; i <= count; i++)
					{
						worksheet = wb.Worksheets[i] as Worksheet;
						Microsoft.Office.Interop.Excel.Range range = ((_Worksheet)worksheet).get_Range((object)"I7", (object)"O1000");
						range.Delete(Missing.Value);
						Marshal.ReleaseComObject(range);
					}
				}
			}
			log.status = true;
			log.method = "Excel_Formatting=>Excel_Data=>config_File";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Excel_Formatting=>Excel_Data=>config_File";
			log.exception = "Error reading Master Policy file: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (((DbConnection)(object)val).State == ConnectionState.Open)
			{
				((DbConnection)(object)val).Close();
				((Component)(object)val).Dispose();
			}
		}
	}
}
