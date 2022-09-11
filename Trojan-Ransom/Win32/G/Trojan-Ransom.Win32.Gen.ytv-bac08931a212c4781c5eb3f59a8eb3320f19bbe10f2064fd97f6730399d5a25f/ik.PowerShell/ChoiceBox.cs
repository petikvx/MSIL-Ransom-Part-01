using System;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Management.Automation.Host;
using System.Reflection;
using System.Windows.Forms;

namespace ik.PowerShell;

public class ChoiceBox
{
	public static int Show(Collection<ChoiceDescription> aAuswahl, int iVorgabe, string sTitle, string sPrompt)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Invalid comparison between Unknown and I4
		if (aAuswahl == null)
		{
			return -1;
		}
		if (aAuswahl.Count < 1)
		{
			return -1;
		}
		Form val = new Form();
		((ContainerControl)val).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)val).set_AutoScaleMode((AutoScaleMode)1);
		RadioButton[] array = (RadioButton[])(object)new RadioButton[aAuswahl.Count];
		ToolTip val2 = new ToolTip();
		Button val3 = new Button();
		int num = 19;
		int num2 = 0;
		if (!string.IsNullOrEmpty(sPrompt))
		{
			Label val4 = new Label();
			((Control)val4).set_Text(sPrompt);
			((Control)val4).set_Location(new Point(9, 19));
			((Control)val4).set_MaximumSize(new Size(Screen.FromControl((Control)(object)val).get_Bounds().Width * 5 / 8 - 18, 0));
			((Control)val4).set_AutoSize(true);
			((Control)val).get_Controls().Add((Control)(object)val4);
			num = ((Control)val4).get_Bottom();
			num2 = ((Control)val4).get_Right();
		}
		int num3 = 0;
		int num4 = Screen.FromControl((Control)(object)val).get_Bounds().Width * 5 / 8 - 18;
		foreach (ChoiceDescription item in aAuswahl)
		{
			array[num3] = new RadioButton();
			((Control)array[num3]).set_Text(item.get_Label());
			if (num3 == iVorgabe)
			{
				array[num3].set_Checked(true);
			}
			((Control)array[num3]).set_Location(new Point(9, num));
			((Control)array[num3]).set_AutoSize(true);
			((Control)val).get_Controls().Add((Control)(object)array[num3]);
			if (((Control)array[num3]).get_Width() > num4)
			{
				int height = ((Control)array[num3]).get_Height();
				((Control)array[num3]).set_Height(height * (1 + (((Control)array[num3]).get_Width() - 1) / num4));
				((Control)array[num3]).set_Width(num4);
				((Control)array[num3]).set_AutoSize(false);
			}
			num = ((Control)array[num3]).get_Bottom();
			if (((Control)array[num3]).get_Right() > num2)
			{
				num2 = ((Control)array[num3]).get_Right();
			}
			if (!string.IsNullOrEmpty(item.get_HelpMessage()))
			{
				val2.SetToolTip((Control)(object)array[num3], item.get_HelpMessage());
			}
			num3++;
		}
		val2.set_ShowAlways(true);
		((Control)val3).set_Text("OK");
		val3.set_DialogResult((DialogResult)1);
		((Control)val3).SetBounds(Math.Max(12, num2 - 77), num + 36, 75, 23);
		if (string.IsNullOrEmpty(sTitle))
		{
			((Control)val).set_Text(AppDomain.CurrentDomain.FriendlyName);
		}
		else
		{
			((Control)val).set_Text(sTitle);
		}
		val.set_ClientSize(new Size(Math.Max(178, num2 + 10), num + 71));
		((Control)val).get_Controls().Add((Control)(object)val3);
		val.set_FormBorderStyle((FormBorderStyle)3);
		val.set_StartPosition((FormStartPosition)1);
		try
		{
			val.set_Icon(Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location));
		}
		catch
		{
		}
		val.set_MinimizeBox(false);
		val.set_MaximizeBox(false);
		val.set_AcceptButton((IButtonControl)(object)val3);
		if ((int)val.ShowDialog() == 1)
		{
			int result = -1;
			for (num3 = 0; num3 < aAuswahl.Count; num3++)
			{
				if (array[num3].get_Checked())
				{
					result = num3;
				}
			}
			return result;
		}
		return -1;
	}
}
