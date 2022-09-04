using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal class ExceptionReportingConsentForm : Form
{
	private Thread thread_0;

	public EventArgs0 eventArgs0_0;

	private Delegate2 delegate2_0;

	private Delegate2 delegate2_1;

	private IContainer icontainer_0;

	private Button btnSend;

	private Button btnDontSend;

	private Button btnSaveToFile;

	private Panel panel1;

	private Panel panel2;

	private Label lblHeading;

	private Label lblPleaseTell;

	private Label lblPleaseTellDescription;

	private Panel pnlExceptionDetails;

	private Label lblExceptionMessage;

	private Panel pnlSendProgress;

	private Label lblSendStatus;

	private Label lblEmail;

	private TextBox txtEmail;

	public ExceptionReportingConsentForm()
	{
		InitializeComponent();
	}

	private void btnSend_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)btnSaveToFile).set_Visible(false);
			((Control)btnSend).set_Visible(false);
			((Control)btnDontSend).set_Text(Class1.string_6);
			method_5();
			thread_0 = new Thread(method_0);
			thread_0.Start();
		}
		catch (Exception exception_)
		{
			method_1(null, new EventArgs2(bool_1: false, exception_));
		}
	}

	private void method_0()
	{
		try
		{
			Class14.smethod_1(eventArgs0_0.Exception_0);
		}
		catch (Exception exception_)
		{
			method_1(null, new EventArgs2(bool_1: false, exception_));
		}
	}

	private void method_1(object sender, EventArgs2 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)delegate2_1, new object[2] { null, e });
		}
		catch
		{
		}
	}

	private void method_2(object sender, EventArgs2 e)
	{
		try
		{
			if (e.Boolean_0)
			{
				((Control)btnDontSend).set_Text(Class1.string_7);
				((Control)lblSendStatus).set_Text(Class1.string_10);
			}
			else
			{
				((Control)lblSendStatus).set_Text(e.Exception_0.Message);
				((Control)btnSend).set_Visible(true);
				((Control)btnSend).set_Text(Class1.string_8);
			}
		}
		catch
		{
		}
	}

	private void ExceptionReportingConsentForm_Load(object sender, EventArgs e)
	{
		try
		{
			method_3();
			method_4();
		}
		catch
		{
		}
	}

	private void method_3()
	{
		try
		{
			((Control)btnSaveToFile).set_Enabled(eventArgs0_0.Boolean_3);
			((Control)btnSend).set_Enabled(eventArgs0_0.Boolean_4);
			((Control)lblHeading).set_Text(string.Format(Class1.string_0, Class14.String_0));
			((Control)btnSaveToFile).set_Text(Class1.string_3);
			((Control)lblEmail).set_Text(Class1.string_13);
			((Control)this).set_Text(string.Format(Class1.string_4, Class14.String_0));
			try
			{
				((Form)this).set_TopMost(true);
			}
			catch
			{
			}
			delegate2_0 = method_1;
			delegate2_1 = method_2;
			Class14.Event_2 += delegate2_0;
		}
		catch
		{
		}
	}

	private void method_4()
	{
		try
		{
			((Control)pnlSendProgress).set_Visible(false);
			((Control)pnlExceptionDetails).set_Visible(true);
			((Control)pnlExceptionDetails).set_Dock((DockStyle)5);
			((Control)lblExceptionMessage).set_Text(eventArgs0_0.string_0);
			((Control)lblPleaseTell).set_Text(string.Format(Class1.string_1, Class14.String_1));
			((Control)lblPleaseTellDescription).set_Text(string.Format(Class1.string_2, Class14.String_1));
		}
		catch
		{
		}
	}

	private void method_5()
	{
		try
		{
			((Control)pnlExceptionDetails).set_Visible(false);
			((Control)pnlSendProgress).set_Visible(true);
			((Control)pnlSendProgress).set_Dock((DockStyle)5);
			((Control)lblSendStatus).set_Text(Class1.string_9);
		}
		catch
		{
		}
	}

	private void ExceptionReportingConsentForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		Class14.Event_2 -= delegate2_0;
		try
		{
			if (thread_0 != null && thread_0.IsAlive)
			{
				thread_0.Abort();
			}
		}
		catch
		{
		}
	}

	private void btnSaveToFile_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			SaveFileDialog val = new SaveFileDialog();
			((FileDialog)val).set_Title(Class1.string_3);
			((FileDialog)val).set_DefaultExt(Class1.string_11);
			((FileDialog)val).set_Filter(Class1.string_12);
			if (eventArgs0_0.string_1 != null && eventArgs0_0.string_1.Length > 0)
			{
				((FileDialog)val).set_InitialDirectory(eventArgs0_0.string_1);
			}
			if (eventArgs0_0.string_2 != null && eventArgs0_0.string_2.Length > 0)
			{
				((FileDialog)val).set_FileName(eventArgs0_0.string_2);
			}
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				Class14.smethod_0(eventArgs0_0.Exception_0, ((FileDialog)val).get_FileName());
				((Form)this).Close();
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(string.Format(Class1.string_5, ex.Message), string.Format(Class1.string_4, Class14.String_0), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private void btnDontSend_Click(object sender, EventArgs e)
	{
		try
		{
			if (thread_0 != null && thread_0.IsAlive)
			{
				thread_0.Abort();
			}
			((Form)this).Close();
		}
		catch
		{
		}
	}

	private void txtEmail_TextChanged(object sender, EventArgs e)
	{
		Class14.String_2 = ((Control)txtEmail).get_Text();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(bool_0);
	}

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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Unknown result type (might be due to invalid IL or missing references)
		//IL_088b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0895: Expected O, but got Unknown
		//IL_08b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected O, but got Unknown
		btnSend = new Button();
		btnDontSend = new Button();
		btnSaveToFile = new Button();
		panel1 = new Panel();
		txtEmail = new TextBox();
		lblEmail = new Label();
		panel2 = new Panel();
		lblHeading = new Label();
		lblPleaseTell = new Label();
		lblPleaseTellDescription = new Label();
		pnlExceptionDetails = new Panel();
		lblExceptionMessage = new Label();
		pnlSendProgress = new Panel();
		lblSendStatus = new Label();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)pnlExceptionDetails).SuspendLayout();
		((Control)pnlSendProgress).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)btnSend).set_Anchor((AnchorStyles)10);
		((Control)btnSend).set_Location(new Point(234, 51));
		((Control)btnSend).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btnSend).set_Name("btnSend");
		((Control)btnSend).set_Size(new Size(125, 26));
		((Control)btnSend).set_TabIndex(3);
		((Control)btnSend).set_Text("Send Error Report");
		((ButtonBase)btnSend).set_UseVisualStyleBackColor(true);
		((Control)btnSend).add_Click((EventHandler)btnSend_Click);
		((Control)btnDontSend).set_Anchor((AnchorStyles)10);
		btnDontSend.set_DialogResult((DialogResult)2);
		((Control)btnDontSend).set_Location(new Point(365, 51));
		((Control)btnDontSend).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btnDontSend).set_Name("btnDontSend");
		((Control)btnDontSend).set_Size(new Size(89, 26));
		((Control)btnDontSend).set_TabIndex(4);
		((Control)btnDontSend).set_Text("Close");
		((ButtonBase)btnDontSend).set_UseVisualStyleBackColor(true);
		((Control)btnDontSend).add_Click((EventHandler)btnDontSend_Click);
		((Control)btnSaveToFile).set_Anchor((AnchorStyles)10);
		((Control)btnSaveToFile).set_Location(new Point(129, 51));
		((Control)btnSaveToFile).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btnSaveToFile).set_Name("btnSaveToFile");
		((Control)btnSaveToFile).set_Size(new Size(99, 26));
		((Control)btnSaveToFile).set_TabIndex(2);
		((Control)btnSaveToFile).set_Text("Save As File...");
		((ButtonBase)btnSaveToFile).set_UseVisualStyleBackColor(true);
		((Control)btnSaveToFile).add_Click((EventHandler)btnSaveToFile_Click);
		((Control)panel1).get_Controls().Add((Control)(object)txtEmail);
		((Control)panel1).get_Controls().Add((Control)(object)lblEmail);
		((Control)panel1).get_Controls().Add((Control)(object)btnSend);
		((Control)panel1).get_Controls().Add((Control)(object)btnDontSend);
		((Control)panel1).get_Controls().Add((Control)(object)btnSaveToFile);
		((Control)panel1).set_Dock((DockStyle)2);
		((Control)panel1).set_Location(new Point(0, 207));
		((Control)panel1).set_Margin(new Padding(2, 2, 2, 2));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(466, 87));
		((Control)panel1).set_TabIndex(2);
		((Control)txtEmail).set_Anchor((AnchorStyles)14);
		((Control)txtEmail).set_Location(new Point(252, 25));
		((Control)txtEmail).set_Margin(new Padding(2, 2, 2, 2));
		((Control)txtEmail).set_Name("txtEmail");
		((Control)txtEmail).set_Size(new Size(202, 20));
		((Control)txtEmail).set_TabIndex(1);
		((Control)txtEmail).add_TextChanged((EventHandler)txtEmail_TextChanged);
		((Control)lblEmail).set_Location(new Point(24, 7));
		((Control)lblEmail).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lblEmail).set_Name("lblEmail");
		((Control)lblEmail).set_Size(new Size(215, 36));
		((Control)lblEmail).set_TabIndex(0);
		((Control)lblEmail).set_Text("Please provide email so we can notify you when the issue is resolved:");
		lblEmail.set_TextAlign((ContentAlignment)1024);
		((Control)panel2).set_BackColor(SystemColors.Highlight);
		((Control)panel2).get_Controls().Add((Control)(object)lblHeading);
		((Control)panel2).set_Dock((DockStyle)1);
		((Control)panel2).set_ForeColor(SystemColors.HighlightText);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Margin(new Padding(2, 2, 2, 2));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(466, 53));
		((Control)panel2).set_TabIndex(0);
		((Control)lblHeading).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblHeading).set_Location(new Point(21, 7));
		((Control)lblHeading).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lblHeading).set_Name("lblHeading");
		((Control)lblHeading).set_Size(new Size(418, 32));
		((Control)lblHeading).set_TabIndex(0);
		((Control)lblHeading).set_Text("Heading");
		((Control)lblPleaseTell).set_Anchor((AnchorStyles)13);
		((Control)lblPleaseTell).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblPleaseTell).set_Location(new Point(14, 64));
		((Control)lblPleaseTell).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lblPleaseTell).set_Name("lblPleaseTell");
		((Control)lblPleaseTell).set_Size(new Size(424, 17));
		((Control)lblPleaseTell).set_TabIndex(0);
		((Control)lblPleaseTell).set_Text("Please tell");
		((Control)lblPleaseTellDescription).set_Anchor((AnchorStyles)13);
		((Control)lblPleaseTellDescription).set_Location(new Point(14, 89));
		((Control)lblPleaseTellDescription).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lblPleaseTellDescription).set_Name("lblPleaseTellDescription");
		((Control)lblPleaseTellDescription).set_Size(new Size(425, 44));
		((Control)lblPleaseTellDescription).set_TabIndex(1);
		((Control)lblPleaseTellDescription).set_Text("Please tell description");
		((Control)pnlExceptionDetails).get_Controls().Add((Control)(object)lblExceptionMessage);
		((Control)pnlExceptionDetails).get_Controls().Add((Control)(object)lblPleaseTellDescription);
		((Control)pnlExceptionDetails).get_Controls().Add((Control)(object)lblPleaseTell);
		((Control)pnlExceptionDetails).set_Location(new Point(8, 72));
		((Control)pnlExceptionDetails).set_Margin(new Padding(2, 2, 2, 2));
		((Control)pnlExceptionDetails).set_Name("pnlExceptionDetails");
		((Control)pnlExceptionDetails).set_Size(new Size(438, 133));
		((Control)pnlExceptionDetails).set_TabIndex(5);
		((Control)lblExceptionMessage).set_Anchor((AnchorStyles)13);
		((Control)lblExceptionMessage).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblExceptionMessage).set_ForeColor(Color.Red);
		((Control)lblExceptionMessage).set_Location(new Point(14, 11));
		((Control)lblExceptionMessage).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lblExceptionMessage).set_Name("lblExceptionMessage");
		((Control)lblExceptionMessage).set_Size(new Size(417, 43));
		((Control)lblExceptionMessage).set_TabIndex(0);
		((Control)lblExceptionMessage).set_Text("Exception Message");
		((Control)pnlSendProgress).get_Controls().Add((Control)(object)lblSendStatus);
		((Control)pnlSendProgress).set_Location(new Point(0, 64));
		((Control)pnlSendProgress).set_Margin(new Padding(2, 2, 2, 2));
		((Control)pnlSendProgress).set_Name("pnlSendProgress");
		((Control)pnlSendProgress).set_Size(new Size(410, 118));
		((Control)pnlSendProgress).set_TabIndex(1);
		((Control)lblSendStatus).set_Anchor((AnchorStyles)13);
		((Control)lblSendStatus).set_AutoSize(true);
		((Control)lblSendStatus).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblSendStatus).set_Location(new Point(21, 21));
		((Control)lblSendStatus).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lblSendStatus).set_Name("lblSendStatus");
		((Control)lblSendStatus).set_Size(new Size(41, 13));
		((Control)lblSendStatus).set_TabIndex(0);
		((Control)lblSendStatus).set_Text("label1");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Window);
		((Form)this).set_CancelButton((IButtonControl)(object)btnDontSend);
		((Form)this).set_ClientSize(new Size(466, 294));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)pnlExceptionDetails);
		((Control)this).get_Controls().Add((Control)(object)pnlSendProgress);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("ExceptionReportingConsentForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("ExceptionReportingConsentForm");
		((Form)this).add_Load((EventHandler)ExceptionReportingConsentForm_Load);
		((Form)this).add_FormClosing(new FormClosingEventHandler(ExceptionReportingConsentForm_FormClosing));
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)pnlExceptionDetails).ResumeLayout(false);
		((Control)pnlSendProgress).ResumeLayout(false);
		((Control)pnlSendProgress).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
