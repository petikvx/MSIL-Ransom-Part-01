using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using t6TA;

namespace Gn2b;

public class Yx8b : Button
{
	public Yx8b()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).add_Click((EventHandler)delegate
		{
			s7QF();
		});
		((ButtonBase)this).set_AutoSize(false);
		((Control)this).set_Dock((DockStyle)1);
		((ButtonBase)this).set_BackColor(Color.AliceBlue);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((Control)this).set_Margin(new Padding(4, 4, 4, 0));
		((Control)this).set_Size(new Size(602, 30));
		((ButtonBase)this).set_TextAlign((ContentAlignment)16);
	}

	private void s7QF()
	{
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			try
			{
				string text = ((ButtonBase)this).get_Text();
				short num = 0;
				Array array = text.ToArray();
				text = "";
				int num2 = array.Length - 1;
				for (int i = 1; i <= num2 && !Operators.ConditionalCompareObjectEqual(array.GetValue(i), (object)"N", false); i++)
				{
					if (num == 1)
					{
						text = Conversions.ToString(Operators.ConcatenateObject((object)text, array.GetValue(i)));
					}
					if (Operators.ConditionalCompareObjectEqual(array.GetValue(i), (object)":", false))
					{
						num = 1;
					}
				}
				text.Trim();
				if (Operators.CompareString(Cm20.Forms.Form12.Label1.get_Text(), "SEARCH Patients BY", false) == 0)
				{
					Cm20.Forms.Form41.TextBox2.set_Text(Conversions.ToString(Conversions.ToInteger(text)));
					((Control)Cm20.Forms.Form41).Show();
				}
				if (Operators.CompareString(Cm20.Forms.Form12.Label1.get_Text(), "SEARCH Doctors BY", false) == 0)
				{
					Cm20.Forms.Form17.user.set_Text(Conversions.ToString(Conversions.ToInteger(text)));
					((Control)Cm20.Forms.Form17).Show();
				}
				if (Operators.CompareString(Cm20.Forms.Form12.Label1.get_Text(), "SEARCH Pharmacists BY", false) == 0)
				{
					Cm20.Forms.Form19.TextBox6.set_Text(Conversions.ToString(Conversions.ToInteger(text)));
					((Control)Cm20.Forms.Form19).Show();
				}
				if (Operators.CompareString(Cm20.Forms.Form12.Label1.get_Text(), "SEARCH Nurses BY", false) == 0)
				{
					Cm20.Forms.Form11.GroupBox2.set_Text("Nurse Information");
					Cm20.Forms.Form11.TextBox6.set_Text(Conversions.ToString(Conversions.ToInteger(text)));
					((Control)Cm20.Forms.Form11).Show();
				}
				if (Operators.CompareString(Cm20.Forms.Form12.Label1.get_Text(), "SEARCH Laboratorists BY", false) == 0)
				{
					Cm20.Forms.Form11.GroupBox2.set_Text("Laboratorist Information");
					Cm20.Forms.Form11.TextBox6.set_Text(Conversions.ToString(Conversions.ToInteger(text)));
					((Control)Cm20.Forms.Form11).Show();
				}
				if (Operators.CompareString(Cm20.Forms.Form12.Label1.get_Text(), "SEARCH Appointments BY", false) != 0)
				{
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerHidden]
	private void Gw39(object z6F8, EventArgs n1F4)
	{
		s7QF();
	}
}
