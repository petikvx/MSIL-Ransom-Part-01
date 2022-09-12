using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace InPatient_Monitoring_Automation.Classes;

internal class Processing
{
	private FileInfo[] fi;

	private string[] stringSeparators = new string[2] { "_", "." };

	public Log SummaryCreation(string path)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		Log log = new Log();
		string text = path + "\\Master Policy.xlsx";
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text + ";Extended Properties=Excel 12.0");
		Application application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		object value = Missing.Value;
		Workbook workbook = application.Workbooks.Add(value);
		try
		{
			((DbConnection)(object)val).Open();
			OleDbDataAdapter val2 = new OleDbDataAdapter("SELECT [NO], [POLIS NO], [PERUSAHAAN] FROM [Master_Policy_List$] where [POLIS NO] IS NOT NULL", val);
			DataSet dataSet = new DataSet();
			((DataAdapter)val2).Fill(dataSet);
			((DbConnection)(object)val).Close();
			((Component)(object)val).Dispose();
			DataTable dataTable = dataSet.Tables[0];
			DirectoryInfo directoryInfo = new DirectoryInfo(path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd"));
			fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
			int num = fi.Length;
			DataTable dataTable2 = new DataTable();
			dataTable2.Clear();
			dataTable2.Columns.Add("PolicyNum");
			dataTable2.Columns.Add("PolicyHolder");
			dataTable2.Columns.Add("IPTreatment");
			dataTable2.Columns.Add("IPCount");
			dataTable2.Columns.Add("Patient");
			dataTable2.Columns.Add("Certificate Number");
			foreach (DataRow row in dataTable.Rows)
			{
				string text2 = row["NO"].ToString()!.Trim();
				DataRow dataRow2 = dataTable2.NewRow();
				int num2 = 0;
				string text3 = "";
				string text4 = "";
				for (int i = 0; i < num; i++)
				{
					if (!(fi[i].Name.Split(stringSeparators, StringSplitOptions.None)[2].ToString().Trim() == text2.ToString().Trim()))
					{
						continue;
					}
					Application application2 = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
					Workbook workbook2 = application2.Workbooks.Open(fi[i].FullName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
					num2 = workbook2.Worksheets.Count;
					int num3 = 0;
					foreach (Worksheet worksheet4 in workbook2.Worksheets)
					{
						text3 = text3.ToString().Trim() + "; " + worksheet4.Name.ToString().Trim();
						num3++;
						text4 = text4.ToString().Trim() + "; " + ((dynamic)worksheet4.Cells[5, 4]).Value.ToString().Trim();
					}
					text3 = text3.Substring(text3.IndexOf(";") + 1).Trim();
					text4 = text4.Substring(text4.IndexOf(";") + 1).Trim();
					if (num3 > 2)
					{
						text3 = "";
						text4 = "";
					}
					workbook2.Close(Type.Missing, Type.Missing, Type.Missing);
					application2.Quit();
					Marshal.ReleaseComObject(application2);
				}
				dataRow2["PolicyNum"] = row["POLIS NO"].ToString()!.Trim();
				dataRow2["PolicyHolder"] = row["PERUSAHAAN"].ToString()!.Trim();
				dataRow2["IPTreatment"] = Convert.ToString((num2 > 0) ? "Y" : "N");
				dataRow2["IPCount"] = Convert.ToString(num2).Trim();
				dataRow2["Patient"] = Convert.ToString(text3)!.Trim();
				dataRow2["Certificate Number"] = text4.Trim();
				dataTable2.Rows.Add(dataRow2);
			}
			application.Visible = false;
			application.DisplayAlerts = false;
			Worksheet worksheet2 = workbook.Worksheets[1] as Worksheet;
			worksheet2.Name = "Summary Report";
			worksheet2.Range[(dynamic)worksheet2.Cells[1, 1], (dynamic)worksheet2.Cells[1, 5]].Merge();
			worksheet2.Cells[1, 1] = "IPMR-RINGKASAN - " + DateTime.Now.ToString("dd-MMMM-yyyy");
			((dynamic)worksheet2.Cells[1, 1]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			((dynamic)worksheet2.Cells[1, 1]).Font.Bold = true;
			worksheet2.Cells[2, 1] = "Nomor Polis";
			worksheet2.Cells[2, 2] = "Pemegang Polis";
			((dynamic)worksheet2.Cells[2, 2]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			worksheet2.Cells[2, 3] = "IP Perawatan";
			worksheet2.Cells[2, 4] = "IP Total Anggota";
			worksheet2.Cells[2, 5] = "Nama Pasien";
			((dynamic)worksheet2.Cells[2, 5]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			worksheet2.Cells[2, 6] = "No Sertifikat";
			int num4 = 2;
			int num5 = 0;
			foreach (DataRow row2 in dataTable2.Rows)
			{
				if (num4 == 3)
				{
					worksheet2.Cells.Font.Color = Color.Black;
					worksheet2.Cells.Font.Bold = true;
				}
				num4++;
				num5 += Convert.ToInt32(row2[3].ToString()!.Trim());
				for (int j = 1; j <= dataTable2.Columns.Count; j++)
				{
					worksheet2.Cells[num4, j] = row2[j - 1].ToString()!.Trim();
					if (num4 > 3 && j == application.Columns.Count && num4 % 2 == 0)
					{
						_ = (Microsoft.Office.Interop.Excel.Range)worksheet2.Range[(dynamic)worksheet2.Cells[num4, 1], (dynamic)worksheet2.Cells[num4, application.Columns.Count]];
					}
				}
			}
			worksheet2.Cells[num4 + 2, 1] = "Total";
			worksheet2.Cells[num4 + 2, 2] = dataTable2.Rows.Count.ToString().Trim();
			((dynamic)worksheet2.Cells[num4 + 2, 2]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			worksheet2.Cells[num4 + 2, 4] = num5.ToString().Trim();
			Microsoft.Office.Interop.Excel.Range obj = worksheet2.Range[(dynamic)worksheet2.Cells[1, 1], (dynamic)worksheet2.Cells[num4 + 2, 6]];
			obj.EntireColumn.AutoFit();
			Borders borders = obj.Borders;
			borders.LineStyle = XlLineStyle.xlContinuous;
			borders.Weight = 2.0;
			((dynamic)worksheet2.Columns["A", Type.Missing]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			((dynamic)worksheet2.Columns["C:D", Type.Missing]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			((dynamic)worksheet2.Columns["F", Type.Missing]).HorizontalAlignment = XlHAlign.xlHAlignCenter;
			((_Worksheet)worksheet2).get_Range((object)"A1:F2", Type.Missing).Interior.Color = Color.Purple;
			((_Worksheet)worksheet2).get_Range((object)"A1:F2", Type.Missing).Font.Color = Color.White;
			_ = (Microsoft.Office.Interop.Excel.Range)worksheet2.Range[(dynamic)worksheet2.Cells[1, 1], (dynamic)worksheet2.Cells[2, application.Columns.Count]];
			string text5 = "\\InPatient Monitoring_" + DateTime.Now.ToString("dd-MMMM-yyyy");
			string text6 = path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd") + "\\Summary_Report" + text5.ToString().Trim();
			if (!Directory.Exists(path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd") + "\\Summary_Report"))
			{
				Directory.CreateDirectory(path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd") + "\\Summary_Report");
			}
			foreach (Worksheet worksheet5 in workbook.Worksheets)
			{
				if (worksheet5.Name.ToString().Trim() != "Summary Report")
				{
					worksheet5.Delete();
				}
			}
			if (File.Exists(text6 + ".xlsx"))
			{
				DirectoryInfo directoryInfo2 = new DirectoryInfo(path);
				fi = directoryInfo2.GetFiles();
				int num6 = 0;
				int num7 = 0;
				for (int k = 0; k < fi.Length; k++)
				{
					if (!fi[k].Name.ToString().Trim().Contains("InPatient Monitoring_" + DateTime.Now.ToString("dd-MMMM-yyyy")))
					{
						continue;
					}
					string[] array = fi[k].Name.Split(stringSeparators, StringSplitOptions.None);
					if (array.Length > 3)
					{
						num6 = Convert.ToInt32(array[^2].ToString().Trim()) + 1;
						if (num6 > num7)
						{
							num7 = num6;
						}
					}
					else
					{
						num7 = 1;
					}
				}
				File.Move(text6.ToString().Trim() + ".xlsx", text6.ToString().Trim() + "_" + num7.ToString().Trim() + ".xlsx");
			}
			workbook.SaveAs(text6, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			log.status = true;
			log.method = "CreateSummary=>Processing=>SummaryCreation";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "CreateSummary=>Processing=>SummaryCreation";
			log.exception = "Error creating Summary file: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (((DbConnection)(object)val).State == ConnectionState.Open)
			{
				((DbConnection)(object)val).Close();
				((Component)(object)val).Dispose();
			}
			if (application != null)
			{
				workbook.Close(Type.Missing, Type.Missing, Type.Missing);
				application.Quit();
				Marshal.ReleaseComObject(application);
				application = null;
			}
		}
	}
}
