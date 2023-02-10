using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nc3g;
using Ps0g;
using Rm59;
using g2H;
using m5LS;

namespace f0NX;

[StandardModule]
internal sealed class g9A7
{
	private static DateTime todayday = Conversions.ToDate(Strings.Format((object)"yyyy-mmm-dd", Conversions.ToString(DateAndTime.get_Today())));

	public static void p9N1()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			x3HT.c6AD("SELECT Max(receiptNumber) From `payment_fees`  ");
			g8H5.con.Ye0f();
			int num = g8H5.cmd.ExecuteScalar;
			Gw5.Forms.DashBoard.txtRecept.set_Text(Conversions.ToString(checked(num + 1)));
			if (Operators.CompareString(Gw5.Forms.DashBoard.txtRecept.get_Text(), "", false) == 0)
			{
				Gw5.Forms.DashBoard.txtRecept.set_Text("");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		g8H5.con.Ew4k();
	}

	public static void Yc65()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Gw5.Forms.DashBoard.txtAmt.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please amount of fees paid is Required!", (MsgBoxStyle)16, (object)null);
			return;
		}
		if (Conversion.Val(Gw5.Forms.DashBoard.txtAmt.get_Text()) <= 0.0)
		{
			Interaction.MsgBox((object)"Your amount is below our standards, please we don't accept negative numbers", (MsgBoxStyle)16, (object)null);
			return;
		}
		if (Conversion.Val(Gw5.Forms.DashBoard.txtAmt.get_Text()) < 45.0)
		{
			Interaction.MsgBox((object)"Amount is below the minimum amount of $45.00", (MsgBoxStyle)16, (object)null);
			return;
		}
		g8H5.issucess = Zs8q.r3Z8("INSERT INTO `payment_fees` (`receiptNumber`,`studentID`, `term_paid`,`date_paid`,  `fees_paid`, `amount_left`,`Cashier`, `isFullyPaid`,`overfees`)  VALUES ('" + Gw5.Forms.DashBoard.txtRecept.get_Text() + "','" + Gw5.Forms.DashBoard.txtReg.get_Text() + "','" + Gw5.Forms.DashBoard.cboTerm.get_Text() + "', '" + Conversions.ToString(todayday) + "', '" + Gw5.Forms.DashBoard.txtAmt.get_Text() + "', '" + Gw5.Forms.DashBoard.txtBalance.get_Text() + "','" + Gw5.Forms.DashBoard.txtCashName.get_Text() + "',  '" + Gw5.Forms.DashBoard.cboStatus.get_Text() + "','" + Gw5.Forms.DashBoard.lblChange.get_Text() + "');");
		if (g8H5.issucess)
		{
			Interaction.MsgBox((object)"New student fees has been paid successfully", (MsgBoxStyle)64, (object)null);
			Zs8q.r3Z8("INSERT INTO `tblbackup` (`receiptNumber`,`regNumber`, `fullName`, `term_paid`,`date_paid`,  `fees_paid`, `amount_left`,`Cashier`, `isFullyPaid`,`overfees`)  VALUES ('" + Gw5.Forms.DashBoard.txtRecept.get_Text() + "','" + Gw5.Forms.DashBoard.txtReg.get_Text() + "', '" + Gw5.Forms.DashBoard.cboTerm.get_Text() + "', '" + Conversions.ToString(todayday) + "', '" + Gw5.Forms.DashBoard.txtAmt.get_Text() + "', '" + Gw5.Forms.DashBoard.txtBalance.get_Text() + "','" + Gw5.Forms.DashBoard.txtCashName.get_Text() + "',  '" + Gw5.Forms.DashBoard.cboStatus.get_Text() + "','" + Gw5.Forms.DashBoard.lblChange.get_Text() + "');");
		}
		else
		{
			Interaction.MsgBox((object)"New student fees has not been paid successfully, Please make sure all details are correct!! ", (MsgBoxStyle)0, (object)null);
		}
	}

	internal static byte[] b3H2(int Xf86)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return x3HT.m3B0(Sg31.Et5q(), Xf86);
	}

	public static void q4RC()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			x3HT.c6AD("SELECT * FROM `student_details` WHERE `stid`='" + Gw5.Forms.DashBoard.txtSearch.get_Text() + "'");
			g8H5.con.Ye0f();
			g8H5.dReader = g8H5.cmd.ExecuteReader;
			while (g8H5.dReader.t4E8())
			{
			}
			Gw5.Forms.DashBoard.txtSearch.set_Text("");
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
			g8H5.con.Ew4k();
			g8H5.da.f5F6();
		}
	}

	public static void Yk5e()
	{
		x3HT.c6AD("SELECT payment_fees.id,payment_fees.receiptNumber,student_details.stid,student_details.name,student_details.surname,student_details.class,payment_fees.term_paid,payment_fees.date_paid,payment_fees.fees_paid,payment_fees.amount_left,payment_fees.Cashier from payment_fees INNER Join student_details on payment_fees.studentID= student_details.stid order by payment_fees.id ");
		Sg31.b6X0(Gw5.Forms.Gross_Fees_Paid.FeesGrid, "payment");
	}
}
