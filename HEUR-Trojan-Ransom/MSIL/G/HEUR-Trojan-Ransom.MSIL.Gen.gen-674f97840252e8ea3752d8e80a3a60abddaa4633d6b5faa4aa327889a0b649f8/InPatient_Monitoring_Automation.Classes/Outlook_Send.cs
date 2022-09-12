using System;

namespace InPatient_Monitoring_Automation.Classes;

internal class Outlook_Send
{
	public Log Outlook_SendMail()
	{
		Log log = new Log();
		string path = global_variable.user_def_path + "\\Master Policy.xlsx";
		string path2 = global_variable.user_def_path + "\\Inpatient Monitoring Report\\" + DateTime.Now.ToString("yyyy") + "\\" + DateTime.Now.ToString("MMM") + "\\" + DateTime.Now.ToString("dd");
		_ = global_variable.user_def_path + "\\Email Template";
		Send_Email send_Email = new Send_Email();
		log = send_Email.readfromexcel(path);
		if (log.status)
		{
			log = send_Email.mail(path2);
		}
		return log;
	}
}
