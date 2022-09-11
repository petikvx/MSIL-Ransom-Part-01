using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ik.PowerShell;

public class InputBox
{
	[DllImport("user32.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
	private static extern IntPtr MB_GetString(uint strId);

	public static DialogResult Show(string sTitle, string sPrompt, ref string sValue, bool bSecure)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		Form val = new Form();
		((ContainerControl)val).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)val).set_AutoScaleMode((AutoScaleMode)1);
		Label val2 = new Label();
		TextBox val3 = new TextBox();
		Button val4 = new Button();
		Button val5 = new Button();
		if (string.IsNullOrEmpty(sPrompt))
		{
			if (bSecure)
			{
				((Control)val2).set_Text("Secure input:   ");
			}
			else
			{
				((Control)val2).set_Text("Input:          ");
			}
		}
		else
		{
			((Control)val2).set_Text(sPrompt);
		}
		((Control)val2).set_Location(new Point(9, 19));
		((Control)val2).set_MaximumSize(new Size(Screen.FromControl((Control)(object)val).get_Bounds().Width * 5 / 8 - 18, 0));
		((Control)val2).set_AutoSize(true);
		((Control)val).get_Controls().Add((Control)(object)val2);
		if (bSecure)
		{
			val3.set_UseSystemPasswordChar(true);
		}
		((Control)val3).set_Text(sValue);
		((Control)val3).SetBounds(12, ((Control)val2).get_Bottom(), ((Control)val2).get_Right() - 12, 20);
		string text = Marshal.PtrToStringUni(MB_GetString(0u));
		if (string.IsNullOrEmpty(text))
		{
			((Control)val4).set_Text("OK");
		}
		else
		{
			((Control)val4).set_Text(text);
		}
		string text2 = Marshal.PtrToStringUni(MB_GetString(1u));
		if (string.IsNullOrEmpty(text2))
		{
			((Control)val5).set_Text("Cancel");
		}
		else
		{
			((Control)val5).set_Text(text2);
		}
		val4.set_DialogResult((DialogResult)1);
		val5.set_DialogResult((DialogResult)2);
		((Control)val4).SetBounds(Math.Max(12, ((Control)val2).get_Right() - 158), ((Control)val2).get_Bottom() + 36, 75, 23);
		((Control)val5).SetBounds(Math.Max(93, ((Control)val2).get_Right() - 77), ((Control)val2).get_Bottom() + 36, 75, 23);
		if (string.IsNullOrEmpty(sTitle))
		{
			((Control)val).set_Text(AppDomain.CurrentDomain.FriendlyName);
		}
		else
		{
			((Control)val).set_Text(sTitle);
		}
		val.set_ClientSize(new Size(Math.Max(178, ((Control)val2).get_Right() + 10), ((Control)val2).get_Bottom() + 71));
		((Control)val).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			(Control)val3,
			(Control)val4,
			(Control)val5
		});
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
		val.set_AcceptButton((IButtonControl)(object)val4);
		val.set_CancelButton((IButtonControl)(object)val5);
		DialogResult result = val.ShowDialog();
		sValue = ((Control)val3).get_Text();
		return result;
	}

	public static DialogResult Show(string sTitle, string sPrompt, ref string sValue)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return Show(sTitle, sPrompt, ref sValue, bSecure: false);
	}
}
