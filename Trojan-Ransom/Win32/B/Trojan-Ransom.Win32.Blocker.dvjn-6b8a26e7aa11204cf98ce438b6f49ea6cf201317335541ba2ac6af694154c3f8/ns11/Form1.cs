using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns10;
using ns7;
using ns9;

namespace ns11;

[DesignerCategory("Code")]
internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Control2 control2_0 = new Control2();

	internal Button button_0 = new Button();

	internal Button button_1 = new Button();

	internal Control1 control1_0 = new Control1(string.Format(Class14.smethod_0(6648), Class14.smethod_0(5227)));

	internal Class37 class37_0 = new Class37();

	internal void method_0(object sender, EventArgs e)
	{
		eventArgs2_0.bool_0 = true;
		((Form)this).Close();
	}

	internal void method_1(object sender, EventArgs e)
	{
		eventArgs2_0.bool_0 = false;
		((Form)this).Close();
	}

	public Form1(EventArgs2 securityExceptionEventArgs)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		Class42.smethod_88(this);
		((Form)this).set_Icon(Class42.smethod_32());
		((Control)this).set_Text(Class14.smethod_0(5227));
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text(Class14.smethod_0(6749));
		}
		eventArgs2_0 = securityExceptionEventArgs;
		if (!securityExceptionEventArgs.bool_2)
		{
			((Control)button_0).set_Visible(false);
		}
		if (securityExceptionEventArgs.string_0.Length > 0)
		{
			((Control)class37_0).set_Text(securityExceptionEventArgs.string_0);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format(Class14.smethod_0(6770), Class14.smethod_0(5227)));
			if (securityExceptionEventArgs.bool_2)
			{
				stringBuilder.Append(Class14.smethod_0(7064));
			}
			stringBuilder.Append(securityExceptionEventArgs.securityException_0.Message);
			((Control)class37_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)class37_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}

	internal static bool Tu0qll4hyqWfDqiDY98()
	{
		return true;
	}

	internal static bool Cgaoer4Fqo8Xlu6qJy9()
	{
		return false;
	}
}
