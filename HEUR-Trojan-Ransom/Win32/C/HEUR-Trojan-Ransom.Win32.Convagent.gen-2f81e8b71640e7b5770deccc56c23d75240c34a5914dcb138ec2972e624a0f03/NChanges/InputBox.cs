using System;
using System.Drawing;
using System.Windows.Forms;

namespace NChanges;

public static class InputBox
{
	public static DialogResult Show(string title, string promptText, ref string value)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		Form val = new Form();
		Label val2 = new Label();
		TextBox val3 = new TextBox();
		Button val4 = new Button();
		Button val5 = new Button();
		((Control)val).set_Text(title);
		((Control)val2).set_Text(promptText);
		((Control)val3).set_Text(value);
		((Control)val4).set_Text("OK");
		((Control)val5).set_Text("Cancel");
		val4.set_DialogResult((DialogResult)1);
		val5.set_DialogResult((DialogResult)2);
		((Control)val2).SetBounds(9, 20, 372, 13);
		((Control)val3).SetBounds(12, 36, 372, 20);
		((Control)val4).SetBounds(228, 72, 75, 23);
		((Control)val5).SetBounds(309, 72, 75, 23);
		((Control)val2).set_AutoSize(true);
		((Control)val3).set_Anchor((AnchorStyles)(((Control)val3).get_Anchor() | 8));
		((Control)val4).set_Anchor((AnchorStyles)10);
		((Control)val5).set_Anchor((AnchorStyles)10);
		val.set_ClientSize(new Size(396, 107));
		((Control)val).get_Controls().AddRange((Control[])(object)new Control[4]
		{
			(Control)val2,
			(Control)val3,
			(Control)val4,
			(Control)val5
		});
		val.set_ClientSize(new Size(Math.Max(300, ((Control)val2).get_Right() + 10), val.get_ClientSize().Height));
		val.set_FormBorderStyle((FormBorderStyle)3);
		val.set_StartPosition((FormStartPosition)1);
		val.set_MinimizeBox(false);
		val.set_MaximizeBox(false);
		val.set_AcceptButton((IButtonControl)(object)val4);
		val.set_CancelButton((IButtonControl)(object)val5);
		DialogResult result = val.ShowDialog();
		value = ((Control)val3).get_Text();
		return result;
	}
}
