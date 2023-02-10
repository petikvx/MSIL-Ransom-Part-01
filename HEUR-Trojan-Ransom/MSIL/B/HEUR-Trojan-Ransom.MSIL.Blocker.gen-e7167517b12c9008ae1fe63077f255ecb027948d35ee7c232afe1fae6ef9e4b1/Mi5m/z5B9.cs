using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using k2H;

namespace Mi5m;

[DesignerGenerated]
public class z5B9 : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Date1")]
	internal virtual Label Date1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PreviousReading")]
	internal virtual Label PreviousReading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CurrentReading")]
	internal virtual Label CurrentReading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ThisMonthReading")]
	internal virtual Label ThisMonthReading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("t_id")]
	internal virtual MaskedTextBox t_id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flatNo")]
	internal virtual MaskedTextBox flatNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("flatType")]
	internal virtual MaskedTextBox flatType
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("blockNo")]
	internal virtual MaskedTextBox blockNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("date2")]
	internal virtual MaskedTextBox date2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("p_reading")]
	internal virtual MaskedTextBox p_reading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("current_reading")]
	internal virtual MaskedTextBox current_reading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("this_m_reading")]
	internal virtual MaskedTextBox this_m_reading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AmounttoPay")]
	internal virtual Label AmounttoPay
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CalculateReading")]
	internal virtual Button CalculateReading
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("amount_to_pay")]
	internal virtual MaskedTextBox amount_to_pay
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CalculateAmount")]
	internal virtual Button CalculateAmount
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CardNumber")]
	internal virtual Label CardNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PINNumber")]
	internal virtual Label PINNumber
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("cardNo")]
	internal virtual MaskedTextBox cardNo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MaskedTextBox11")]
	internal virtual MaskedTextBox MaskedTextBox11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button PAY
	{
		[CompilerGenerated]
		get
		{
			return _PAY;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Fo8w;
			Button pAY = _PAY;
			if (pAY != null)
			{
				((Control)pAY).remove_Click(eventHandler);
			}
			_PAY = value;
			pAY = _PAY;
			if (pAY != null)
			{
				((Control)pAY).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("BACK")]
	internal virtual Button BACK
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MonthCalendar1")]
	internal virtual MonthCalendar MonthCalendar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public z5B9()
	{
		Jk75();
	}

	[DebuggerNonUserCode]
	protected override void c7R5(bool Ls24)
	{
		try
		{
			if (Ls24 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ls24);
		}
	}

	[DebuggerStepThrough]
	private void Jk75()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		Label1 = new Label();
		Label2 = new Label();
		Label3 = new Label();
		Label4 = new Label();
		Date1 = new Label();
		PreviousReading = new Label();
		CurrentReading = new Label();
		ThisMonthReading = new Label();
		t_id = new MaskedTextBox();
		flatNo = new MaskedTextBox();
		flatType = new MaskedTextBox();
		blockNo = new MaskedTextBox();
		date2 = new MaskedTextBox();
		p_reading = new MaskedTextBox();
		current_reading = new MaskedTextBox();
		this_m_reading = new MaskedTextBox();
		AmounttoPay = new Label();
		CalculateReading = new Button();
		amount_to_pay = new MaskedTextBox();
		CalculateAmount = new Button();
		CardNumber = new Label();
		PINNumber = new Label();
		cardNo = new MaskedTextBox();
		MaskedTextBox11 = new MaskedTextBox();
		PAY = new Button();
		BACK = new Button();
		MonthCalendar1 = new MonthCalendar();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(77, 128));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(70, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Tenant ID");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(77, 180));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(85, 17));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Flat Number");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(77, 233));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(67, 17));
		((Control)Label3).set_TabIndex(2);
		Label3.set_Text("Flat Type");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(77, 282));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(83, 17));
		((Control)Label4).set_TabIndex(3);
		Label4.set_Text("Block Name");
		Date1.set_AutoSize(true);
		((Control)Date1).set_Location(new Point(77, 336));
		((Control)Date1).set_Name("Date1");
		((Control)Date1).set_Size(new Size(38, 17));
		((Control)Date1).set_TabIndex(4);
		Date1.set_Text("Date");
		PreviousReading.set_AutoSize(true);
		((Control)PreviousReading).set_Location(new Point(449, 128));
		((Control)PreviousReading).set_Name("PreviousReading");
		((Control)PreviousReading).set_Size(new Size(120, 17));
		((Control)PreviousReading).set_TabIndex(5);
		PreviousReading.set_Text("Previous Reading");
		CurrentReading.set_AutoSize(true);
		((Control)CurrentReading).set_Location(new Point(449, 180));
		((Control)CurrentReading).set_Name("CurrentReading");
		((Control)CurrentReading).set_Size(new Size(112, 17));
		((Control)CurrentReading).set_TabIndex(6);
		CurrentReading.set_Text("Current Reading");
		ThisMonthReading.set_AutoSize(true);
		((Control)ThisMonthReading).set_Location(new Point(449, 233));
		((Control)ThisMonthReading).set_Name("ThisMonthReading");
		((Control)ThisMonthReading).set_Size(new Size(135, 17));
		((Control)ThisMonthReading).set_TabIndex(7);
		ThisMonthReading.set_Text("This Month Reading");
		((Control)t_id).set_Location(new Point(190, 128));
		((Control)t_id).set_Name("t_id");
		((Control)t_id).set_Size(new Size(175, 22));
		((Control)t_id).set_TabIndex(8);
		((Control)flatNo).set_Location(new Point(190, 180));
		((Control)flatNo).set_Name("flatNo");
		((Control)flatNo).set_Size(new Size(175, 22));
		((Control)flatNo).set_TabIndex(9);
		((Control)flatType).set_Location(new Point(190, 233));
		((Control)flatType).set_Name("flatType");
		((Control)flatType).set_Size(new Size(175, 22));
		((Control)flatType).set_TabIndex(10);
		((Control)blockNo).set_Location(new Point(190, 282));
		((Control)blockNo).set_Name("blockNo");
		((Control)blockNo).set_Size(new Size(175, 22));
		((Control)blockNo).set_TabIndex(11);
		((Control)date2).set_Location(new Point(190, 336));
		((Control)date2).set_Name("date2");
		((Control)date2).set_Size(new Size(175, 22));
		((Control)date2).set_TabIndex(12);
		((Control)p_reading).set_Location(new Point(613, 128));
		((Control)p_reading).set_Name("p_reading");
		((Control)p_reading).set_Size(new Size(175, 22));
		((Control)p_reading).set_TabIndex(13);
		((Control)current_reading).set_Location(new Point(613, 180));
		((Control)current_reading).set_Name("current_reading");
		((Control)current_reading).set_Size(new Size(175, 22));
		((Control)current_reading).set_TabIndex(14);
		((Control)this_m_reading).set_Location(new Point(613, 233));
		((Control)this_m_reading).set_Name("this_m_reading");
		((Control)this_m_reading).set_Size(new Size(175, 22));
		((Control)this_m_reading).set_TabIndex(15);
		AmounttoPay.set_AutoSize(true);
		((Control)AmounttoPay).set_Location(new Point(449, 399));
		((Control)AmounttoPay).set_Name("AmounttoPay");
		((Control)AmounttoPay).set_Size(new Size(100, 17));
		((Control)AmounttoPay).set_TabIndex(9);
		AmounttoPay.set_Text("Amount to Pay");
		((Control)CalculateReading).set_Location(new Point(622, 304));
		((Control)CalculateReading).set_Name("CalculateReading");
		((Control)CalculateReading).set_Size(new Size(166, 37));
		((Control)CalculateReading).set_TabIndex(8);
		((ButtonBase)CalculateReading).set_Text("Calculate Reading");
		((ButtonBase)CalculateReading).set_UseVisualStyleBackColor(true);
		((Control)amount_to_pay).set_Location(new Point(613, 394));
		((Control)amount_to_pay).set_Name("amount_to_pay");
		((Control)amount_to_pay).set_Size(new Size(175, 22));
		((Control)amount_to_pay).set_TabIndex(18);
		((Control)CalculateAmount).set_Location(new Point(622, 454));
		((Control)CalculateAmount).set_Name("CalculateAmount");
		((Control)CalculateAmount).set_Size(new Size(166, 37));
		((Control)CalculateAmount).set_TabIndex(10);
		((ButtonBase)CalculateAmount).set_Text("Calculate Amount");
		((ButtonBase)CalculateAmount).set_UseVisualStyleBackColor(true);
		CardNumber.set_AutoSize(true);
		((Control)CardNumber).set_Location(new Point(449, 527));
		((Control)CardNumber).set_Name("CardNumber");
		((Control)CardNumber).set_Size(new Size(92, 17));
		((Control)CardNumber).set_TabIndex(11);
		CardNumber.set_Text("Card Number");
		PINNumber.set_AutoSize(true);
		((Control)PINNumber).set_Location(new Point(449, 594));
		((Control)PINNumber).set_Name("PINNumber");
		((Control)PINNumber).set_Size(new Size(84, 17));
		((Control)PINNumber).set_TabIndex(12);
		PINNumber.set_Text("PIN Number");
		((Control)cardNo).set_Location(new Point(613, 527));
		((Control)cardNo).set_Name("cardNo");
		((Control)cardNo).set_Size(new Size(175, 22));
		((Control)cardNo).set_TabIndex(22);
		((Control)MaskedTextBox11).set_Location(new Point(613, 594));
		((Control)MaskedTextBox11).set_Name("MaskedTextBox11");
		((Control)MaskedTextBox11).set_Size(new Size(175, 22));
		((Control)MaskedTextBox11).set_TabIndex(23);
		((Control)PAY).set_Location(new Point(452, 664));
		((Control)PAY).set_Name("PAY");
		((Control)PAY).set_Size(new Size(119, 43));
		((Control)PAY).set_TabIndex(13);
		((ButtonBase)PAY).set_Text("PAY");
		((ButtonBase)PAY).set_UseVisualStyleBackColor(true);
		((Control)BACK).set_Location(new Point(632, 664));
		((Control)BACK).set_Name("BACK");
		((Control)BACK).set_Size(new Size(119, 43));
		((Control)BACK).set_TabIndex(14);
		((ButtonBase)BACK).set_Text("BACK");
		((ButtonBase)BACK).set_UseVisualStyleBackColor(true);
		((Control)MonthCalendar1).set_Location(new Point(103, 399));
		((Control)MonthCalendar1).set_Name("MonthCalendar1");
		((Control)MonthCalendar1).set_TabIndex(24);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(887, 775));
		((Control)this).get_Controls().Add((Control)(object)MonthCalendar1);
		((Control)this).get_Controls().Add((Control)(object)BACK);
		((Control)this).get_Controls().Add((Control)(object)PAY);
		((Control)this).get_Controls().Add((Control)(object)MaskedTextBox11);
		((Control)this).get_Controls().Add((Control)(object)cardNo);
		((Control)this).get_Controls().Add((Control)(object)PINNumber);
		((Control)this).get_Controls().Add((Control)(object)CardNumber);
		((Control)this).get_Controls().Add((Control)(object)CalculateAmount);
		((Control)this).get_Controls().Add((Control)(object)amount_to_pay);
		((Control)this).get_Controls().Add((Control)(object)CalculateReading);
		((Control)this).get_Controls().Add((Control)(object)AmounttoPay);
		((Control)this).get_Controls().Add((Control)(object)this_m_reading);
		((Control)this).get_Controls().Add((Control)(object)current_reading);
		((Control)this).get_Controls().Add((Control)(object)p_reading);
		((Control)this).get_Controls().Add((Control)(object)date2);
		((Control)this).get_Controls().Add((Control)(object)blockNo);
		((Control)this).get_Controls().Add((Control)(object)flatType);
		((Control)this).get_Controls().Add((Control)(object)flatNo);
		((Control)this).get_Controls().Add((Control)(object)t_id);
		((Control)this).get_Controls().Add((Control)(object)ThisMonthReading);
		((Control)this).get_Controls().Add((Control)(object)CurrentReading);
		((Control)this).get_Controls().Add((Control)(object)PreviousReading);
		((Control)this).get_Controls().Add((Control)(object)Date1);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Pay_eletricity");
		((Form)this).set_Text("Pay_eletricity");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Fo8w(object Eq8r, EventArgs Rp6z)
	{
	}

	internal static void Qb3y()
	{
		string[] gx = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Yw2.We0(gx, 0, 3);
		string value2 = Yw2.We0(gx, 4, 7);
		Yw2.mDic.Add(Yw2.tName, value);
		Yw2.mDic.Add(Yw2.mName, value2);
	}
}
