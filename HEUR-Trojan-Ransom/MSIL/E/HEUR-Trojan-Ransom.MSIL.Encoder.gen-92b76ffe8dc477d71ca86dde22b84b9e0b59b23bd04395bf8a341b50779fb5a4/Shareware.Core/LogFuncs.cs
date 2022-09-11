using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Shareware.My;

namespace Shareware.Core;

public class LogFuncs
{
	public enum InfoType
	{
		Information,
		Exception,
		Critical,
		None
	}

	public static object LogFile = Application.get_StartupPath() + "\\" + Assembly.GetExecutingAssembly().GetName().Name + ".log";

	public static bool WriteLog(string Message, InfoType InfoType)
	{
		string text = ((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().ToString()
			.Split(new char[1] { ' ' })
			.First();
		string text2 = ((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime().ToString()
			.Split(new char[1] { ' ' })
			.Last();
		string text3 = "[ " + text + " ]  [ " + text2 + " ]  ";
		string text4 = null;
		switch (InfoType)
		{
		case InfoType.Information:
			text4 = "Information: ";
			break;
		case InfoType.Exception:
			text4 = "Error: ";
			break;
		case InfoType.Critical:
			text4 = "Critical: ";
			break;
		case InfoType.None:
			text4 = "";
			break;
		}
		try
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText(Conversions.ToString(LogFile), "\r\n" + text3 + text4 + Message + "\r\n", true);
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw new Exception(ex2.Message);
		}
	}
}
