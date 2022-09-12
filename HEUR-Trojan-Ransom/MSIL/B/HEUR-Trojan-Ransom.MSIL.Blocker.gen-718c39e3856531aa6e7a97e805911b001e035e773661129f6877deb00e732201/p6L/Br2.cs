using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fc96;
using Gr4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Px68;
using i0R;

namespace p6L;

[DesignerGenerated]
public class Br2 : Form
{
	private IContainer components;

	internal virtual PictureBox LogoPictureBox
	{
		[CompilerGenerated]
		get
		{
			return _LogoPictureBox;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a4B;
			PictureBox logoPictureBox = _LogoPictureBox;
			if (logoPictureBox != null)
			{
				((Control)logoPictureBox).remove_Click(eventHandler);
			}
			_LogoPictureBox = value;
			logoPictureBox = _LogoPictureBox;
			if (logoPictureBox != null)
			{
				((Control)logoPictureBox).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("UsernameLabel")]
	internal virtual Label UsernameLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PasswordLabel")]
	internal virtual Label PasswordLabel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UsernameTextBox")]
	internal virtual TextBox UsernameTextBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = t2P;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Button OK
	{
		[CompilerGenerated]
		get
		{
			return _OK;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o6Z;
			Button oK = _OK;
			if (oK != null)
			{
				((Control)oK).remove_Click(eventHandler);
			}
			_OK = value;
			oK = _OK;
			if (oK != null)
			{
				((Control)oK).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Cancel
	{
		[CompilerGenerated]
		get
		{
			return _Cancel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e9X;
			Button cancel = _Cancel;
			if (cancel != null)
			{
				((Control)cancel).remove_Click(eventHandler);
			}
			_Cancel = value;
			cancel = _Cancel;
			if (cancel != null)
			{
				((Control)cancel).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Hk8;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public Br2()
	{
		((Form)this).add_Load((EventHandler)y3L);
		d6R();
	}

	[DebuggerNonUserCode]
	protected override void t5G(bool Kb8)
	{
		try
		{
			if (Kb8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Kb8);
		}
	}

	[DebuggerStepThrough]
	private void d6R()
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Br2));
		LogoPictureBox = new PictureBox();
		UsernameLabel = new Label();
		PasswordLabel = new Label();
		UsernameTextBox = new TextBox();
		TextBox1 = new TextBox();
		OK = new Button();
		Cancel = new Button();
		ComboBox1 = new ComboBox();
		((ISupportInitialize)LogoPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		LogoPictureBox.set_Image((Image)componentResourceManager.GetObject("LogoPictureBox.Image"));
		((Control)LogoPictureBox).set_Location(new Point(4, -5));
		((Control)LogoPictureBox).set_Name("LogoPictureBox");
		((Control)LogoPictureBox).set_Size(new Size(165, 193));
		LogoPictureBox.set_SizeMode((PictureBoxSizeMode)4);
		LogoPictureBox.set_TabIndex(0);
		LogoPictureBox.set_TabStop(false);
		((Control)UsernameLabel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UsernameLabel).set_Location(new Point(172, 24));
		((Control)UsernameLabel).set_Name("UsernameLabel");
		((Control)UsernameLabel).set_Size(new Size(220, 23));
		((Control)UsernameLabel).set_TabIndex(0);
		UsernameLabel.set_Text("&User name :-");
		UsernameLabel.set_TextAlign((ContentAlignment)16);
		((Control)PasswordLabel).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)PasswordLabel).set_Location(new Point(172, 81));
		((Control)PasswordLabel).set_Name("PasswordLabel");
		((Control)PasswordLabel).set_Size(new Size(220, 23));
		((Control)PasswordLabel).set_TabIndex(2);
		PasswordLabel.set_Text("&Password :-");
		PasswordLabel.set_TextAlign((ContentAlignment)16);
		((Control)UsernameTextBox).set_Location(new Point(174, 50));
		((Control)UsernameTextBox).set_Name("UsernameTextBox");
		((Control)UsernameTextBox).set_Size(new Size(220, 20));
		((Control)UsernameTextBox).set_TabIndex(1);
		((TextBoxBase)TextBox1).set_BackColor(Color.White);
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)TextBox1).set_Location(new Point(175, 107));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		TextBox1.set_PasswordChar('*');
		((Control)TextBox1).set_Size(new Size(220, 24));
		((Control)TextBox1).set_TabIndex(3);
		((ButtonBase)OK).set_BackColor(Color.White);
		((ButtonBase)OK).get_FlatAppearance().set_BorderColor(Color.Lime);
		((ButtonBase)OK).get_FlatAppearance().set_BorderSize(5);
		((Control)OK).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)OK).set_Location(new Point(175, 155));
		((Control)OK).set_Name("OK");
		((Control)OK).set_Size(new Size(94, 29));
		((Control)OK).set_TabIndex(4);
		((ButtonBase)OK).set_Text("&Login");
		((ButtonBase)OK).set_UseVisualStyleBackColor(false);
		((ButtonBase)Cancel).set_BackColor(Color.White);
		Cancel.set_DialogResult((DialogResult)2);
		((ButtonBase)Cancel).get_FlatAppearance().set_BorderColor(Color.Red);
		((ButtonBase)Cancel).get_FlatAppearance().set_BorderSize(5);
		((Control)Cancel).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Cancel).set_Location(new Point(298, 155));
		((Control)Cancel).set_Name("Cancel");
		((Control)Cancel).set_Size(new Size(94, 29));
		((Control)Cancel).set_TabIndex(5);
		((ButtonBase)Cancel).set_Text("&Cancel");
		((ButtonBase)Cancel).set_UseVisualStyleBackColor(false);
		ComboBox1.set_BackColor(Color.White);
		((Control)ComboBox1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		ComboBox1.set_ForeColor(SystemColors.WindowText);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		((Control)ComboBox1).set_Location(new Point(174, 46));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(220, 24));
		((Control)ComboBox1).set_TabIndex(6);
		((Form)this).set_AcceptButton((IButtonControl)(object)OK);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.MintCream);
		((Form)this).set_CancelButton((IButtonControl)(object)Cancel);
		((Form)this).set_ClientSize(new Size(401, 192));
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Cancel);
		((Control)this).get_Controls().Add((Control)(object)OK);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)UsernameTextBox);
		((Control)this).get_Controls().Add((Control)(object)PasswordLabel);
		((Control)this).get_Controls().Add((Control)(object)UsernameLabel);
		((Control)this).get_Controls().Add((Control)(object)LogoPictureBox);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_HelpButton(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MaximumSize(new Size(407, 221));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MinimumSize(new Size(407, 221));
		((Control)this).set_Name("LoginForm1");
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Login Form");
		((ISupportInitialize)LogoPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void o6Z(object sender, EventArgs e)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		int count = Nn6.ds.Tables["login"]!.Rows.Count;
		checked
		{
			try
			{
				int num = count - 1;
				int num2 = default(int);
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(Nn6.ds.Tables["login"]!.Rows[i][0], (object)UsernameTextBox.get_Text(), false), Operators.CompareObjectEqual(Nn6.ds.Tables["login"]!.Rows[i][1], (object)TextBox1.get_Text(), false))))
					{
						num2 = 1;
					}
				}
				if (num2 == 1)
				{
					((Control)r6W7.Forms.MENUS).Show();
					((Control)this).Hide();
				}
				else
				{
					Interaction.MsgBox((object)"Wrong Password. Plese use correct password.", (MsgBoxStyle)0, (object)null);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				Interaction.MsgBox((object)"Wrong Password. Plese use correct password.", (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void e9X(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void y3L(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		Nn6.y6G();
		Nn6.cn.Open();
		Nn6.str = "select * from login";
		Nn6.cmd = new SqlCommand(Nn6.str, Nn6.cn);
		Nn6.da.set_SelectCommand(Nn6.cmd);
		((DbDataAdapter)(object)Nn6.da).Fill(Nn6.ds, "login");
		checked
		{
			int num = Nn6.ds.Tables["login"]!.Rows.Count - 1;
			int num2 = num;
			for (int i = 0; i <= num2; i++)
			{
				ComboBox1.get_Items().Add((object)Nn6.ds.Tables["login"]!.Rows[i][0].ToString());
			}
			Nn6.cn.Close();
		}
	}

	private void a4B(object sender, EventArgs e)
	{
	}

	internal static byte[] k8H(int Gj1)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return a0A.Rn3(Je5d.Jp6r(), Gj1);
	}

	private void Hk8(object sender, EventArgs e)
	{
		UsernameTextBox.set_Text(ComboBox1.get_Text());
	}

	private void t2P(object sender, EventArgs e)
	{
	}
}
