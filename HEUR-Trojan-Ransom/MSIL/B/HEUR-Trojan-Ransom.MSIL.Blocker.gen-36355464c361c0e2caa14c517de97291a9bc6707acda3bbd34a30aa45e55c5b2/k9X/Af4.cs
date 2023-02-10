using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xi1;
using Yk7;
using Yw6;
using t8C;
using w0M;

namespace k9X;

[StandardModule]
internal sealed class Af4
{
	private static DateTime todayday = Conversions.ToDate(Strings.Format((object)"yyyy-mmm-dd", Conversions.ToString(DateAndTime.get_Today())));

	public static void d8E()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			j5J.Cn2("SELECT Max(receiptNumber) From `payment_fees`  ");
			Xe9.con.k4F();
			int num = Xe9.cmd.ExecuteScalar;
			Ng2.Forms.DashBoard.txtRecept.set_Text(Conversions.ToString(checked(num + 1)));
			if (Operators.CompareString(Ng2.Forms.DashBoard.txtRecept.get_Text(), "", false) == 0)
			{
				Ng2.Forms.DashBoard.txtRecept.set_Text("");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		Xe9.con.Xb4();
	}

	public static void k1W()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Ng2.Forms.DashBoard.txtAmt.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please amount of fees paid is Required!", (MsgBoxStyle)16, (object)null);
			return;
		}
		if (Conversion.Val(Ng2.Forms.DashBoard.txtAmt.get_Text()) <= 0.0)
		{
			Interaction.MsgBox((object)"Your amount is below our standards, please we don't accept negative numbers", (MsgBoxStyle)16, (object)null);
			return;
		}
		if (Conversion.Val(Ng2.Forms.DashBoard.txtAmt.get_Text()) < 45.0)
		{
			Interaction.MsgBox((object)"Amount is below the minimum amount of $45.00", (MsgBoxStyle)16, (object)null);
			return;
		}
		Xe9.issucess = y8T.f3E("INSERT INTO `payment_fees` (`receiptNumber`,`studentID`, `term_paid`,`date_paid`,  `fees_paid`, `amount_left`,`Cashier`, `isFullyPaid`,`overfees`)  VALUES ('" + Ng2.Forms.DashBoard.txtRecept.get_Text() + "','" + Ng2.Forms.DashBoard.txtReg.get_Text() + "','" + Ng2.Forms.DashBoard.cboTerm.get_Text() + "', '" + Conversions.ToString(todayday) + "', '" + Ng2.Forms.DashBoard.txtAmt.get_Text() + "', '" + Ng2.Forms.DashBoard.txtBalance.get_Text() + "','" + Ng2.Forms.DashBoard.txtCashName.get_Text() + "',  '" + Ng2.Forms.DashBoard.cboStatus.get_Text() + "','" + Ng2.Forms.DashBoard.lblChange.get_Text() + "');");
		if (Xe9.issucess)
		{
			Interaction.MsgBox((object)"New student fees has been paid successfully", (MsgBoxStyle)64, (object)null);
			y8T.f3E("INSERT INTO `tblbackup` (`receiptNumber`,`regNumber`, `fullName`, `term_paid`,`date_paid`,  `fees_paid`, `amount_left`,`Cashier`, `isFullyPaid`,`overfees`)  VALUES ('" + Ng2.Forms.DashBoard.txtRecept.get_Text() + "','" + Ng2.Forms.DashBoard.txtReg.get_Text() + "', '" + Ng2.Forms.DashBoard.cboTerm.get_Text() + "', '" + Conversions.ToString(todayday) + "', '" + Ng2.Forms.DashBoard.txtAmt.get_Text() + "', '" + Ng2.Forms.DashBoard.txtBalance.get_Text() + "','" + Ng2.Forms.DashBoard.txtCashName.get_Text() + "',  '" + Ng2.Forms.DashBoard.cboStatus.get_Text() + "','" + Ng2.Forms.DashBoard.lblChange.get_Text() + "');");
		}
		else
		{
			Interaction.MsgBox((object)"New student fees has not been paid successfully, Please make sure all details are correct!! ", (MsgBoxStyle)0, (object)null);
		}
	}

	internal static byte[] o0A(int Fe2)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return j5J.Mi1(Fr0.Am2(), Fe2);
	}

	public static void Ep9()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			j5J.Cn2("SELECT * FROM `student_details` WHERE `stid`='" + Ng2.Forms.DashBoard.txtSearch.get_Text() + "'");
			Xe9.con.k4F();
			Xe9.dReader = Xe9.cmd.ExecuteReader;
			while (Xe9.dReader.Kb8())
			{
			}
			Ng2.Forms.DashBoard.txtSearch.set_Text("");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		finally
		{
			Xe9.con.Xb4();
			Xe9.da.Ns5();
		}
	}

	public static void e3E()
	{
		j5J.Cn2("SELECT payment_fees.id,payment_fees.receiptNumber,student_details.stid,student_details.name,student_details.surname,student_details.class,payment_fees.term_paid,payment_fees.date_paid,payment_fees.fees_paid,payment_fees.amount_left,payment_fees.Cashier from payment_fees INNER Join student_details on payment_fees.studentID= student_details.stid order by payment_fees.id ");
		Fr0.t0C(Ng2.Forms.Gross_Fees_Paid.FeesGrid, "payment");
	}
}
