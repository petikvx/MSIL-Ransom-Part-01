using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Outlook;

namespace InPatient_Monitoring_Automation.Classes;

internal class Send_Email
{
	private int No_of_Sheets;

	private int No_of_Files;

	private int No_of_Compaines;

	private string Company_Name;

	private string path_Excel;

	private string First_Sheet_Name;

	private string subject;

	private string Second_Sheet_Name;

	private string policy_no;

	private string sub_office;

	private string w1;

	private string w2;

	private FileInfo[] fi;

	private string f1_name;

	private string f2_name;

	private string fileDetails;

	private string email_flag = global_variable.email_flag;

	private string nda;

	private DataSet _tab = new DataSet();

	private DateTime today;

	private string email_temp_path;

	public Log readfromexcel(string path)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		Log log = new Log();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0");
		try
		{
			((DbConnection)(object)val).Open();
			OleDbDataAdapter val2 = new OleDbDataAdapter("SELECT [PERUSAHAAN], [SUB OFFICE],[POLIS NO], [ALAMAT EMAIL PENGIRIMAN],[Copy To], [BCC To], [Sender Group (From)],[NO],[NDA] FROM [Master_Policy_List$] where [POLIS NO] IS NOT NULL ", val);
			_tab = new DataSet();
			((DataAdapter)val2).Fill(_tab);
			log.status = true;
			log.method = "Outlook_Send=>Send_Email=>readfromexcel";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Outlook_Send=>Send_Email=>readfromexcel";
			log.exception = "Problem reading mailing data from Master Policy file: " + ex.Message.ToString().Trim();
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

	public Log Opened_Excel(string path)
	{
		Log log = new Log();
		Microsoft.Office.Interop.Excel.Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
		Workbook workbook = application.Workbooks.Open(path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
		try
		{
			No_of_Sheets = application.Sheets.Count;
			if (No_of_Sheets <= 2)
			{
				Worksheet worksheet = workbook.Worksheets[1] as Worksheet;
				First_Sheet_Name = worksheet.Name.Trim();
				if (No_of_Sheets == 2)
				{
					Worksheet worksheet2 = workbook.Worksheets[2] as Worksheet;
					Second_Sheet_Name = worksheet2.Name.Trim();
				}
			}
			log = Subject_Condition(No_of_Sheets, sub_office);
			if (log.status)
			{
				log.status = true;
				log.method = "Outlook_Send=>Send_Email=>Opened_Excel";
				log.exception = "No issues";
			}
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Outlook_Send=>Send_Email=>Opened_Excel";
			log.exception = "Error forming mail: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (application != null)
			{
				workbook.Close(0, Type.Missing, Type.Missing);
				application.Quit();
				Marshal.ReleaseComObject(application);
				GC.Collect();
				application = null;
			}
		}
	}

	public Log Subject_Condition(int no, string ofc)
	{
		Log log = new Log();
		try
		{
			if (No_of_Sheets <= 2 && sub_office == "")
			{
				if (No_of_Sheets == 1)
				{
					subject = "Informasi Penjaminan " + Company_Name.Trim() + " " + policy_no.Trim() + " a.n " + First_Sheet_Name.Trim();
				}
				else
				{
					subject = "Informasi Penjaminan " + Company_Name.Trim() + " " + policy_no.Trim() + " a.n " + First_Sheet_Name.Trim() + " & " + Second_Sheet_Name.Trim();
				}
			}
			else if (No_of_Sheets <= 2 && sub_office != " ")
			{
				if (No_of_Sheets == 1)
				{
					subject = "Informasi Penjaminan " + Company_Name.Trim() + " " + policy_no.Trim() + " Suboffice " + sub_office.Trim() + "  a.n " + First_Sheet_Name.Trim();
				}
				else
				{
					subject = "Informasi Penjaminan " + Company_Name.Trim() + " " + policy_no.Trim() + " Suboffice " + sub_office.Trim() + "  a.n " + First_Sheet_Name.Trim() + " & " + Second_Sheet_Name.Trim();
				}
			}
			else if (No_of_Sheets > 2 && sub_office == "")
			{
				subject = "Informasi Penjaminan " + Company_Name.Trim() + "  - " + policy_no.Trim();
			}
			else if (No_of_Sheets > 2 && sub_office != " ")
			{
				subject = "Informasi Penjaminan " + Company_Name.Trim() + "  - " + policy_no.Trim() + " Suboffice " + sub_office.Trim();
			}
			log.status = true;
			log.method = "Outlook_Send=>Send_Email=>Subject_Condition";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Outlook_Send=>Send_Email=>Subject_Condition";
			log.exception = "Error confirming mail subject line: " + ex.Message.ToString();
			return log;
		}
	}

	public Log mail(string path)
	{
		Microsoft.Office.Interop.Outlook.Application application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
		Log log = new Log();
		try
		{
			today = DateTime.Parse(DateTime.Now.ToString().Trim());
			fileDetails = global_variable.user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd") + "\\Draft Emails\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
			if (email_flag.ToUpper() == "SAVE")
			{
				Directory.CreateDirectory(fileDetails);
			}
			w1 = global_variable.user_def_path + "\\Email Template";
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			fi = directoryInfo.GetFiles("*", SearchOption.AllDirectories);
			No_of_Files = fi.Length;
			for (int i = 0; i < No_of_Files; i++)
			{
				string[] separator = new string[2] { "_", "." };
				string[] array = fi[i].Name.Trim().Split(separator, StringSplitOptions.None);
				f1_name = array[2].Trim();
				No_of_Compaines = _tab.Tables[0].Rows.Count;
				for (int j = 0; j < No_of_Compaines; j++)
				{
					object obj = _tab.Tables[0].Rows[j].ItemArray[0];
					Company_Name = obj.ToString()!.Trim();
					f2_name = obj.ToString()!.Trim();
					if (!(_tab.Tables[0].Rows[j].ItemArray[7]!.ToString()!.Trim() == f1_name.Trim()))
					{
						continue;
					}
					object obj2 = _tab.Tables[0].Rows[j].ItemArray[2];
					object obj3 = _tab.Tables[0].Rows[j].ItemArray[1];
					object obj4 = _tab.Tables[0].Rows[j].ItemArray[8];
					policy_no = obj2.ToString()!.Trim();
					sub_office = obj3.ToString()!.Trim();
					path_Excel = fi[i].FullName.Trim();
					nda = obj4.ToString()!.Trim();
					log = Opened_Excel(path_Excel);
					if (log.status)
					{
						if (sub_office != "")
						{
							if (nda.ToUpper() != "NDA")
							{
								email_temp_path = global_variable.user_def_path + "\\Email Template\\with_Suboffice(Y).oft";
							}
							else
							{
								email_temp_path = global_variable.user_def_path + "\\Email Template\\with_Suboffice_NDA(Y).oft";
							}
							application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
							MailItem mailItem = application.CreateItemFromTemplate(email_temp_path, Missing.Value) as MailItem;
							_ = application.Session.Accounts;
							mailItem.Subject = subject.Trim();
							mailItem.HTMLBody = mailItem.HTMLBody.Replace("DD/MM/YYYY", today.Date.ToString("dd/MM/yyyy")).Trim();
							mailItem.HTMLBody = mailItem.HTMLBody.Replace("HOURS:MINUTES", today.TimeOfDay.ToString()).Trim();
							mailItem.HTMLBody = mailItem.HTMLBody.Replace("PERUSAHAAN", Company_Name).Trim();
							mailItem.HTMLBody = mailItem.HTMLBody.Replace("POLIS NO", policy_no).Trim();
							mailItem.HTMLBody = mailItem.HTMLBody.Replace("SUBOFFICECODE", sub_office).Trim();
							new StringBuilder().Append(mailItem.HTMLBody).AppendLine();
							string text = fi[i].FullName.Trim();
							string[] separator2 = new string[1] { "\\" };
							string[] array2 = text.Split(separator2, StringSplitOptions.None);
							Company_Name = null;
							Company_Name = _tab.Tables[0].Rows[j].ItemArray[0]!.ToString()!.Trim();
							string text2 = array2[0].Trim() + "//" + array2[1].Trim() + "//" + array2[2].Trim() + "//" + array2[3].Trim() + "//" + array2[4].Trim() + "//" + array2[5].Trim() + "//" + array2[6].Trim() + "//" + array2[7].Trim() + "//" + array2[8].Trim() + "//" + Company_Name.Trim() + " CLAIM MONITORING PER TGL " + DateTime.Now.ToString("dd-MM-yyyy") + ".xls";
							File.Move(text.Trim(), text2.Trim());
							mailItem.Attachments.Add(text2.Trim(), Type.Missing, Type.Missing, Type.Missing);
							_ = _tab.Tables[0].Rows.Count;
							object? obj5 = _tab.Tables[0].Rows[j].ItemArray[3];
							object obj6 = _tab.Tables[0].Rows[j].ItemArray[4];
							object obj7 = _tab.Tables[0].Rows[j].ItemArray[5];
							object obj8 = _tab.Tables[0].Rows[j].ItemArray[6];
							string text3 = Convert.ToString(obj5)!.Trim();
							string text4 = Convert.ToString(obj6)!.Trim();
							string text5 = Convert.ToString(obj7)!.Trim();
							string text6 = Convert.ToString(obj8)!.Trim();
							string[] array3 = text4.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							string[] array4 = text3.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							string[] array5 = text5.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
							Recipients recipients = mailItem.Recipients;
							for (int k = 0; k < array4.Length; k++)
							{
								if (array4[k].Trim() != "")
								{
									Recipient recipient = recipients.Add(array4[k]);
									recipient.Type = 1;
									recipient.Resolve();
								}
							}
							for (int l = 0; l < array3.Length; l++)
							{
								if (array3[l].Trim() != "")
								{
									Recipient recipient2 = recipients.Add(array3[l]);
									recipient2.Type = 2;
									recipient2.Resolve();
								}
							}
							for (int m = 0; m < array5.Length; m++)
							{
								if (array5[m].Trim() != "")
								{
									Recipient recipient3 = recipients.Add(array5[m]);
									recipient3.Type = 3;
									recipient3.Resolve();
								}
							}
							if (text6 != "" || text6 != null)
							{
								mailItem.SentOnBehalfOfName = text6;
							}
							mailItem.Importance = OlImportance.olImportanceNormal;
							string text7 = Company_Name.Trim();
							string text8 = fileDetails.Trim() + "\\" + text7.Trim() + "_" + policy_no.Trim() + "_" + sub_office.Trim() + ".msg";
							if (email_flag.ToUpper() == "SEND")
							{
								mailItem.Send();
							}
							else
							{
								mailItem.SaveAs(text8.Trim(), Type.Missing);
							}
							Marshal.ReleaseComObject(mailItem);
							application.Quit();
							mailItem = null;
							GC.Collect();
						}
						if (!(sub_office == ""))
						{
							continue;
						}
						if (nda.ToUpper() != "NDA")
						{
							email_temp_path = global_variable.user_def_path + "\\Email Template\\without_Suboffice(Y).oft";
						}
						else
						{
							email_temp_path = global_variable.user_def_path + "\\Email Template\\without_Suboffice_NDA(Y).oft";
						}
						application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
						MailItem mailItem2 = application.CreateItemFromTemplate(email_temp_path, Missing.Value) as MailItem;
						_ = application.Session.Accounts;
						mailItem2.Subject = subject.Trim();
						mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("DD/MM/YYYY", today.Date.ToString("dd/MM/yyyy")).Trim();
						mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("HOURS:MINUTES", today.TimeOfDay.ToString()).Trim();
						mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("PERUSAHAAN", Company_Name).Trim();
						mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("POLIS NO", policy_no).Trim();
						new StringBuilder().Append(mailItem2.HTMLBody).AppendLine();
						string text9 = fi[i].FullName.Trim();
						string[] separator3 = new string[1] { "\\" };
						string[] array6 = text9.Split(separator3, StringSplitOptions.None);
						Company_Name = null;
						Company_Name = _tab.Tables[0].Rows[j].ItemArray[0]!.ToString()!.Trim();
						string text10 = array6[0].Trim() + "//" + array6[1].Trim() + "//" + array6[2].Trim() + "//" + array6[3].Trim() + "//" + array6[4].Trim() + "//" + array6[5] + "//" + array6[6] + "//" + array6[7] + "//" + array6[8] + "//" + Company_Name + " CLAIM MONITORING PER TGL " + DateTime.Now.ToString("dd-MM-yyyy") + ".xls";
						File.Move(text9.Trim(), text10.Trim());
						mailItem2.Attachments.Add(text10.Trim(), Type.Missing, Type.Missing, Type.Missing);
						_ = _tab.Tables[0].Rows.Count;
						object? obj9 = _tab.Tables[0].Rows[j].ItemArray[3];
						object obj10 = _tab.Tables[0].Rows[j].ItemArray[4];
						object obj11 = _tab.Tables[0].Rows[j].ItemArray[5];
						object obj12 = _tab.Tables[0].Rows[j].ItemArray[6];
						string text11 = Convert.ToString(obj9)!.Trim();
						string text12 = Convert.ToString(obj10)!.Trim();
						string text13 = Convert.ToString(obj11)!.Trim();
						string text14 = Convert.ToString(obj12)!.Trim();
						string[] array7 = text12.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
						string[] array8 = text11.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
						string[] array9 = text13.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
						Recipients recipients2 = mailItem2.Recipients;
						for (int n = 0; n < array8.Length; n++)
						{
							if (array8[n].Trim() != "")
							{
								Recipient recipient4 = recipients2.Add(array8[n]);
								recipient4.Type = 1;
								recipient4.Resolve();
							}
						}
						for (int num = 0; num < array7.Length; num++)
						{
							if (array7[num].Trim() != "")
							{
								Recipient recipient5 = recipients2.Add(array7[num]);
								recipient5.Type = 2;
								recipient5.Resolve();
							}
						}
						for (int num2 = 0; num2 < array9.Length; num2++)
						{
							if (array9[num2].Trim() != "")
							{
								Recipient recipient6 = recipients2.Add(array9[num2]);
								recipient6.Type = 3;
								recipient6.Resolve();
							}
						}
						if (text14 != "" || text14 != null)
						{
							mailItem2.SentOnBehalfOfName = text14;
						}
						mailItem2.Importance = OlImportance.olImportanceNormal;
						string text15 = Company_Name.Trim();
						string text16 = fileDetails.Trim() + "\\" + text15.Trim() + "_" + policy_no.Trim() + "_.msg";
						if (email_flag.ToUpper() == "SEND")
						{
							mailItem2.Send();
						}
						else
						{
							mailItem2.SaveAs(text16.Trim(), Type.Missing);
						}
						Marshal.ReleaseComObject(mailItem2);
						mailItem2 = null;
						GC.Collect();
						application.Quit();
						continue;
					}
					return log;
				}
				GC.Collect();
			}
			log = send_email_N_Condition();
			string text17 = global_variable.user_def_path + "\\Master Policy.xlsx";
			if (log.status)
			{
				log = send_Manager_Mail(text17.Trim(), fileDetails.Trim());
			}
			if (log.status)
			{
				log.status = true;
				log.method = "Outlook_Send=>Send_Email=>mail";
				log.exception = "No issues";
			}
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Outlook_Send=>Send_Email=>mail";
			log.exception = "Error while sending mail: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (application != null)
			{
				application.Quit();
				Marshal.ReleaseComObject(application);
				application = null;
			}
		}
	}

	public Log send_email_N_Condition()
	{
		Microsoft.Office.Interop.Outlook.Application application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
		Log log = new Log();
		try
		{
			string[] array = new string[No_of_Files];
			for (int i = 0; i < No_of_Files; i++)
			{
				string[] separator = new string[2] { "_", "." };
				string[] array2 = fi[i].Name.Trim().Split(separator, StringSplitOptions.None);
				array2[2].Trim();
				array[i] = array2[2].Trim();
			}
			No_of_Compaines = _tab.Tables[0].Rows.Count;
			for (int j = 0; j < No_of_Compaines; j++)
			{
				string text = _tab.Tables[0].Rows[j].ItemArray[0]!.ToString()!.Trim();
				Company_Name = text.Trim();
				if (array.Contains(_tab.Tables[0].Rows[j].ItemArray[7]!.ToString()!.Trim()))
				{
					continue;
				}
				object obj = _tab.Tables[0].Rows[j].ItemArray[2];
				object obj2 = _tab.Tables[0].Rows[j].ItemArray[1];
				policy_no = obj.ToString()!.Trim();
				sub_office = obj2.ToString()!.Trim();
				if (sub_office != "")
				{
					application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
					MailItem mailItem = application.CreateItemFromTemplate(global_variable.user_def_path + "\\Email Template\\with_Suboffice(N).oft", Missing.Value) as MailItem;
					_ = application.Session.Accounts;
					No_of_Sheets = 0;
					mailItem.Subject = "Informasi Penjaminan " + Company_Name.Trim() + "  -" + policy_no.Trim() + " Suboffice " + sub_office.Trim();
					mailItem.HTMLBody = mailItem.HTMLBody.Replace("DD/MM/YYYY", today.Date.ToString("dd/MM/yyyy")).Trim();
					mailItem.HTMLBody = mailItem.HTMLBody.Replace("HOURS:MINUTES", today.TimeOfDay.ToString()).Trim();
					mailItem.HTMLBody = mailItem.HTMLBody.Replace("PERUSAHAAN", text).Trim();
					mailItem.HTMLBody = mailItem.HTMLBody.Replace("POLIS NO", policy_no).Trim();
					mailItem.HTMLBody = mailItem.HTMLBody.Replace("SUBOFFICECODE", sub_office).Trim();
					new StringBuilder().Append(mailItem.HTMLBody).AppendLine();
					_ = _tab.Tables[0].Rows.Count;
					object? obj3 = _tab.Tables[0].Rows[j].ItemArray[3];
					object obj4 = _tab.Tables[0].Rows[j].ItemArray[4];
					object obj5 = _tab.Tables[0].Rows[j].ItemArray[5];
					object obj6 = _tab.Tables[0].Rows[j].ItemArray[6];
					string text2 = Convert.ToString(obj3)!.Trim();
					string text3 = Convert.ToString(obj4)!.Trim();
					string text4 = Convert.ToString(obj5)!.Trim();
					string text5 = Convert.ToString(obj6)!.Trim();
					string[] array3 = text3.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					string[] array4 = text2.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					string[] array5 = text4.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
					Recipients recipients = mailItem.Recipients;
					for (int k = 0; k < array4.Length; k++)
					{
						if (array4[k].Trim() != "")
						{
							Recipient recipient = recipients.Add(array4[k]);
							recipient.Type = 1;
							recipient.Resolve();
						}
					}
					for (int l = 0; l < array3.Length; l++)
					{
						if (array3[l].Trim() != "")
						{
							Recipient recipient2 = recipients.Add(array3[l]);
							recipient2.Type = 2;
							recipient2.Resolve();
						}
					}
					for (int m = 0; m < array5.Length; m++)
					{
						if (array5[m].Trim() != "")
						{
							Recipient recipient3 = recipients.Add(array5[m]);
							recipient3.Type = 3;
							recipient3.Resolve();
						}
					}
					if (text5 != "" || text5 != null)
					{
						mailItem.SentOnBehalfOfName = text5;
					}
					mailItem.Importance = OlImportance.olImportanceNormal;
					string text6 = text.Trim();
					string text7 = fileDetails.Trim() + "\\" + text6.Trim() + "_" + policy_no.Trim() + "_" + sub_office.Trim() + ".msg";
					if (email_flag.ToUpper() == "SEND")
					{
						mailItem.Send();
					}
					else
					{
						mailItem.SaveAs(text7.Trim(), Type.Missing);
					}
					Marshal.ReleaseComObject(mailItem);
					application.Quit();
					mailItem = null;
					GC.Collect();
				}
				if (!(sub_office == ""))
				{
					continue;
				}
				application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
				MailItem mailItem2 = application.CreateItemFromTemplate(global_variable.user_def_path + "\\Email Template\\without_Suboffice(N).oft", Missing.Value) as MailItem;
				_ = application.Session.Accounts;
				No_of_Sheets = 0;
				mailItem2.Subject = "Informasi Penjaminan " + Company_Name.Trim() + "  -" + policy_no.Trim();
				mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("DD/MM/YYYY", today.Date.ToString("dd/MM/yyyy")).Trim();
				mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("HOURS:MINUTES", today.TimeOfDay.ToString()).Trim();
				mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("PERUSAHAAN", text).Trim();
				mailItem2.HTMLBody = mailItem2.HTMLBody.Replace("POLIS NO", policy_no).Trim();
				new StringBuilder().Append(mailItem2.HTMLBody).AppendLine();
				_ = _tab.Tables[0].Rows.Count;
				object? obj7 = _tab.Tables[0].Rows[j].ItemArray[3];
				object obj8 = _tab.Tables[0].Rows[j].ItemArray[4];
				object obj9 = _tab.Tables[0].Rows[j].ItemArray[5];
				object obj10 = _tab.Tables[0].Rows[j].ItemArray[6];
				string text8 = Convert.ToString(obj7)!.Trim();
				string text9 = Convert.ToString(obj8)!.Trim();
				string text10 = Convert.ToString(obj9)!.Trim();
				string text11 = Convert.ToString(obj10)!.Trim();
				string[] array6 = text9.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				string[] array7 = text8.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				string[] array8 = text10.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				Recipients recipients2 = mailItem2.Recipients;
				for (int n = 0; n < array7.Length; n++)
				{
					if (array7[n].Trim() != "")
					{
						Recipient recipient4 = recipients2.Add(array7[n]);
						recipient4.Type = 1;
						recipient4.Resolve();
					}
				}
				for (int num = 0; num < array6.Length; num++)
				{
					if (array6[num].Trim() != "")
					{
						Recipient recipient5 = recipients2.Add(array6[num]);
						recipient5.Type = 2;
						recipient5.Resolve();
					}
				}
				for (int num2 = 0; num2 < array8.Length; num2++)
				{
					if (array8[num2].Trim() != "")
					{
						Recipient recipient6 = recipients2.Add(array8[num2]);
						recipient6.Type = 3;
						recipient6.Resolve();
					}
				}
				if (text11 != "" || text11 != null)
				{
					mailItem2.SentOnBehalfOfName = text11;
				}
				mailItem2.Importance = OlImportance.olImportanceNormal;
				string text12 = text.Trim();
				string text13 = fileDetails.Trim() + "\\" + text12.Trim() + "_" + policy_no.Trim() + ".msg";
				if (email_flag.ToUpper() == "SEND")
				{
					mailItem2.Send();
				}
				else
				{
					mailItem2.SaveAs(text13.Trim(), Type.Missing);
				}
				Marshal.ReleaseComObject(mailItem2);
				mailItem2 = null;
				GC.Collect();
				application.Quit();
			}
			log.status = true;
			log.method = "Outlook_Send=>Send_Email=>send_email_N_Condition";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Outlook_Send=>Send_Email=>send_email_N_Condition";
			log.exception = "Error forming mail body: " + ex.Message.ToString();
			return log;
		}
		finally
		{
			if (application != null)
			{
				application.Quit();
				Marshal.ReleaseComObject(application);
				application = null;
			}
		}
	}

	public Log send_Manager_Mail(string path, string Saved_Emails_FDR)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		Log log = new Log();
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0");
		Microsoft.Office.Interop.Outlook.Application application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
		try
		{
			((DbConnection)(object)val).Open();
			OleDbDataAdapter val2 = new OleDbDataAdapter("SELECT [To Manager],[From Sender] FROM [Confirmation_Email$] where [To Manager] IS NOT NULL", val);
			_tab = new DataSet();
			((DataAdapter)val2).Fill(_tab);
			((DbConnection)(object)val).Close();
			((Component)(object)val).Dispose();
			today = DateTime.Parse(DateTime.Now.ToString());
			w1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Inpatient Monitoring Report\\Email Template";
			w2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Inpatient Monitoring Report\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd") + "\\Summary_Report\\InPatient Monitoring_" + DateTime.Now.ToString("dd-MMMM-yyyy") + ".xlsx";
			int count = _tab.Tables[0].Rows.Count;
			for (int i = 0; i < count; i++)
			{
				object obj = _tab.Tables[0].Rows[i].ItemArray[0];
				f2_name = obj.ToString()!.Trim();
				application = (Microsoft.Office.Interop.Outlook.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
				MailItem mailItem = application.CreateItemFromTemplate(global_variable.user_def_path + "\\Email Template\\Manager_Template.oft", Missing.Value) as MailItem;
				_ = application.Session.Accounts;
				mailItem.Subject = "Inpatient Monitoring Summary Report- " + DateTime.Now.ToString("dd-MMMM-yyyy");
				mailItem.HTMLBody = mailItem.HTMLBody.Replace("DD/MM/YYYY", today.Date.ToString("dd-MMMM-yyyy")).Trim();
				new StringBuilder().Append(mailItem.HTMLBody).AppendLine();
				mailItem.Attachments.Add(w2, Type.Missing, Type.Missing, Type.Missing);
				_ = _tab.Tables[0].Rows.Count;
				string[] array = Convert.ToString(_tab.Tables[0].Rows[i].ItemArray[0])!.Trim().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				string text = _tab.Tables[0].Rows[i].ItemArray[1]!.ToString()!.Trim();
				if (text != "" || text != null)
				{
					mailItem.SentOnBehalfOfName = text;
				}
				Recipients recipients = mailItem.Recipients;
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Trim() != "")
					{
						Recipient recipient = recipients.Add(array[j]);
						recipient.Type = 1;
						recipient.Resolve();
					}
				}
				mailItem.Importance = OlImportance.olImportanceNormal;
				string text2 = Saved_Emails_FDR.Trim() + "\\_Execution Completion Summary_" + DateTime.Now.ToString("HHmmss") + ".msg";
				if (email_flag.ToUpper() == "SEND")
				{
					mailItem.Send();
				}
				else
				{
					mailItem.SaveAs(text2.Trim(), Type.Missing);
				}
				Marshal.ReleaseComObject(mailItem);
				application.Quit();
				mailItem = null;
				GC.Collect();
			}
			log.status = true;
			log.method = "Outlook_Send=>Send_Email=>send_Manager_Mail";
			log.exception = "No issues";
			return log;
		}
		catch (Exception ex)
		{
			log.status = false;
			log.method = "Outlook_Send=>Send_Email=>send_Manager_Mail";
			log.exception = "Error sending summary mail: " + ex.Message.ToString();
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
				application.Quit();
				Marshal.ReleaseComObject(application);
				application = null;
			}
		}
	}
}
