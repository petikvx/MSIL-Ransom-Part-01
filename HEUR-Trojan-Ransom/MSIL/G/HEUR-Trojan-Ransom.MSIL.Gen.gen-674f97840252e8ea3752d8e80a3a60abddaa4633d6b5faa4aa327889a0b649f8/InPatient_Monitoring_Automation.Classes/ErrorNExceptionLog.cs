using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Office.Interop.Outlook;

namespace InPatient_Monitoring_Automation.Classes;

internal class ErrorNExceptionLog
{
	public void CreateLog(Log log)
	{
		string text = global_variable.user_def_path + "\\Logs\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		string path = text + "\\Log_" + DateTime.Now.ToString("ddMMMyyyy") + ".txt";
		if (!File.Exists(path))
		{
			using (StreamWriter streamWriter = File.CreateText(path))
			{
				streamWriter.Write("\r\nLog Entry : ");
				streamWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
				streamWriter.Write(" At       : ");
				streamWriter.WriteLine("{0}", log.method.ToString().Trim());
				streamWriter.Write(" Error    : ");
				streamWriter.WriteLine("{0}", log.exception.ToString().Trim());
				streamWriter.WriteLine("------------------------------");
				return;
			}
		}
		using StreamWriter streamWriter2 = File.AppendText(path);
		streamWriter2.Write("\r\nLog Entry : ");
		streamWriter2.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
		streamWriter2.Write(" At       : ");
		streamWriter2.WriteLine("{0}", log.method.ToString().Trim());
		streamWriter2.Write(" Error    : ");
		streamWriter2.WriteLine("{0}", log.exception.ToString().Trim());
		streamWriter2.WriteLine("------------------------------");
	}

	public void SendLogMail(Log log)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		string text = global_variable.user_def_path + "\\Master Policy.xlsx";
		string text2 = global_variable.user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd") + "\\Draft Emails\\Error Mail\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
		_ = global_variable.user_def_path + "\\Email Template";
		OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + text + ";Extended Properties=Excel 12.0");
		Application application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
		DataSet dataSet = new DataSet();
		if (log.method == null)
		{
			return;
		}
		try
		{
			((DbConnection)(object)val).Open();
			OleDbDataAdapter val2 = new OleDbDataAdapter("SELECT [To Manager] FROM [Confirmation_Email$] where [To Manager] IS NOT NULL", val);
			dataSet = new DataSet();
			((DataAdapter)val2).Fill(dataSet);
			((DbConnection)(object)val).Close();
			((Component)(object)val).Dispose();
			DateTime dateTime = DateTime.Parse(DateTime.Now.ToString());
			int count = dataSet.Tables[0].Rows.Count;
			for (int i = 0; i < count; i++)
			{
				dataSet.Tables[0].Rows[i].ItemArray[0]!.ToString()!.Trim();
				application = (Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("0006F03A-0000-0000-C000-000000000046")));
				MailItem mailItem = application.CreateItemFromTemplate(global_variable.user_def_path + "\\Email Template\\Error_Template.oft", Missing.Value) as MailItem;
				mailItem.Subject = "Inpatient Monitoring Execution failure Report- " + DateTime.Now.ToString("dd-MMMM-yyyy");
				mailItem.HTMLBody = mailItem.HTMLBody.Replace("DD/MM/YYYY", dateTime.Date.ToString("dd-MMMM-yyyy")).Trim();
				mailItem.HTMLBody = mailItem.HTMLBody.Replace("HH:mm:ss", DateTime.Now.ToString("HH:mm:ss")).Trim();
				new StringBuilder().Append(mailItem.HTMLBody).AppendLine();
				_ = dataSet.Tables[0].Rows.Count;
				string[] array = Convert.ToString(dataSet.Tables[0].Rows[i].ItemArray[0])!.Trim().Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
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
				_ = text2.Trim() + "\\_Execution Fail_" + DateTime.Now.ToString("HHmmss") + ".msg";
				mailItem.Send();
				Marshal.ReleaseComObject(mailItem);
				application.Quit();
				mailItem = null;
				GC.Collect();
			}
		}
		catch (Exception ex)
		{
			Log log2 = new Log();
			log2.status = false;
			log2.method = "ErrorNExceptionLog=>ErrorNExceptionLog=>SendLogMail";
			log2.exception = "Error while sending execution error mail: " + ex.Message.ToString();
			CreateLog(log2);
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
