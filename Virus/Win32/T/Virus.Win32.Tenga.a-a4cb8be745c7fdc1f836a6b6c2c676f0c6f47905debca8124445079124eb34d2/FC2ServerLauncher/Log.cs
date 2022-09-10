using System;
using System.IO;

namespace FC2ServerLauncher;

internal class Log
{
	private string m_file;

	private bool m_time;

	internal Log()
	{
	}

	internal void Init(bool time)
	{
		m_file = CUtils.GetFarCry2PersonalLogsFolder();
		string text = DateTime.Now.Year.ToString();
		string text2 = DateTime.Now.Month.ToString();
		string text3 = DateTime.Now.Day.ToString();
		string file = m_file;
		m_file = file + "Log_" + text + "_" + text2 + "_" + text3;
		m_time = time;
	}

	internal void WriteLine(string msg)
	{
		string text = "";
		if (m_time)
		{
			text = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " > ";
		}
		StreamWriter streamWriter = new StreamWriter(m_file, append: true);
		streamWriter.WriteLine(text + msg);
		streamWriter.Flush();
		streamWriter.Close();
	}
}
