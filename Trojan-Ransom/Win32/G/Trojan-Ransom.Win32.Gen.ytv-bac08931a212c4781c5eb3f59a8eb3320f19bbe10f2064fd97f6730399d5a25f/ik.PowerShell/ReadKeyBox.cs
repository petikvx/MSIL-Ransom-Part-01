using System;
using System.Drawing;
using System.Management.Automation.Host;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ik.PowerShell;

public class ReadKeyBox
{
	private class KeyboardForm : Form
	{
		public bool checkKeyDown = true;

		public KeyInfo keyinfo;

		public KeyboardForm()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
			((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
			((Control)this).add_KeyDown(new KeyEventHandler(KeyboardForm_KeyDown));
			((Control)this).add_KeyUp(new KeyEventHandler(KeyboardForm_KeyUp));
		}

		private void KeyboardForm_KeyDown(object sender, KeyEventArgs e)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Invalid comparison between Unknown and I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Invalid comparison between Unknown and I4
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			if (!checkKeyDown)
			{
				return;
			}
			((KeyInfo)(ref keyinfo)).set_VirtualKeyCode(e.get_KeyValue());
			((KeyInfo)(ref keyinfo)).set_Character(GetCharFromKeys(e.get_KeyCode(), e.get_Shift(), e.get_Alt() & e.get_Control())[0]);
			((KeyInfo)(ref keyinfo)).set_KeyDown(false);
			((KeyInfo)(ref keyinfo)).set_ControlKeyState((ControlKeyStates)0);
			if (e.get_Alt())
			{
				((KeyInfo)(ref keyinfo)).set_ControlKeyState((ControlKeyStates)3);
			}
			if (e.get_Control())
			{
				ref KeyInfo reference = ref keyinfo;
				((KeyInfo)(ref reference)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference)).get_ControlKeyState() | 0xC));
				if (!e.get_Alt() && e.get_KeyValue() > 64 && e.get_KeyValue() < 96)
				{
					((KeyInfo)(ref keyinfo)).set_Character((char)(e.get_KeyValue() - 64));
				}
			}
			if (e.get_Shift())
			{
				ref KeyInfo reference2 = ref keyinfo;
				((KeyInfo)(ref reference2)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference2)).get_ControlKeyState() | 0x10));
			}
			if ((e.get_Modifiers() & 0x14) > 0)
			{
				ref KeyInfo reference3 = ref keyinfo;
				((KeyInfo)(ref reference3)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference3)).get_ControlKeyState() | 0x80));
			}
			if ((e.get_Modifiers() & 0x90) > 0)
			{
				ref KeyInfo reference4 = ref keyinfo;
				((KeyInfo)(ref reference4)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference4)).get_ControlKeyState() | 0x20));
			}
			((Form)this).Close();
		}

		private void KeyboardForm_KeyUp(object sender, KeyEventArgs e)
		{
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Invalid comparison between Unknown and I4
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Invalid comparison between Unknown and I4
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			if (checkKeyDown)
			{
				return;
			}
			((KeyInfo)(ref keyinfo)).set_VirtualKeyCode(e.get_KeyValue());
			((KeyInfo)(ref keyinfo)).set_Character(GetCharFromKeys(e.get_KeyCode(), e.get_Shift(), e.get_Alt() & e.get_Control())[0]);
			((KeyInfo)(ref keyinfo)).set_KeyDown(true);
			((KeyInfo)(ref keyinfo)).set_ControlKeyState((ControlKeyStates)0);
			if (e.get_Alt())
			{
				((KeyInfo)(ref keyinfo)).set_ControlKeyState((ControlKeyStates)3);
			}
			if (e.get_Control())
			{
				ref KeyInfo reference = ref keyinfo;
				((KeyInfo)(ref reference)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference)).get_ControlKeyState() | 0xC));
				if (!e.get_Alt() && e.get_KeyValue() > 64 && e.get_KeyValue() < 96)
				{
					((KeyInfo)(ref keyinfo)).set_Character((char)(e.get_KeyValue() - 64));
				}
			}
			if (e.get_Shift())
			{
				ref KeyInfo reference2 = ref keyinfo;
				((KeyInfo)(ref reference2)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference2)).get_ControlKeyState() | 0x10));
			}
			if ((e.get_Modifiers() & 0x14) > 0)
			{
				ref KeyInfo reference3 = ref keyinfo;
				((KeyInfo)(ref reference3)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference3)).get_ControlKeyState() | 0x80));
			}
			if ((e.get_Modifiers() & 0x90) > 0)
			{
				ref KeyInfo reference4 = ref keyinfo;
				((KeyInfo)(ref reference4)).set_ControlKeyState((ControlKeyStates)(((KeyInfo)(ref reference4)).get_ControlKeyState() | 0x20));
			}
			((Form)this).Close();
		}
	}

	[DllImport("user32.dll")]
	public static extern int ToUnicode(uint wVirtKey, uint wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, uint wFlags);

	private static string GetCharFromKeys(Keys keys, bool bShift, bool bAltGr)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		StringBuilder stringBuilder = new StringBuilder(64);
		byte[] array = new byte[256];
		if (bShift)
		{
			array[16] = byte.MaxValue;
		}
		if (bAltGr)
		{
			array[17] = byte.MaxValue;
			array[18] = byte.MaxValue;
		}
		if (ToUnicode((uint)(int)keys, 0u, array, stringBuilder, 64, 0u) >= 1)
		{
			return stringBuilder.ToString();
		}
		return "\0";
	}

	public static KeyInfo Show(string sTitle, string sPrompt, bool bIncludeKeyDown)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		KeyboardForm keyboardForm = new KeyboardForm();
		Label val = new Label();
		if (string.IsNullOrEmpty(sPrompt))
		{
			((Control)val).set_Text("Press a key");
		}
		else
		{
			((Control)val).set_Text(sPrompt);
		}
		((Control)val).set_Location(new Point(9, 19));
		((Control)val).set_MaximumSize(new Size(Screen.FromControl((Control)(object)keyboardForm).get_Bounds().Width * 5 / 8 - 18, 0));
		((Control)val).set_AutoSize(true);
		((Control)keyboardForm).get_Controls().Add((Control)(object)val);
		if (string.IsNullOrEmpty(sTitle))
		{
			((Control)keyboardForm).set_Text(AppDomain.CurrentDomain.FriendlyName);
		}
		else
		{
			((Control)keyboardForm).set_Text(sTitle);
		}
		((Form)keyboardForm).set_ClientSize(new Size(Math.Max(178, ((Control)val).get_Right() + 10), ((Control)val).get_Bottom() + 55));
		((Form)keyboardForm).set_FormBorderStyle((FormBorderStyle)3);
		((Form)keyboardForm).set_StartPosition((FormStartPosition)1);
		try
		{
			((Form)keyboardForm).set_Icon(Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location));
		}
		catch
		{
		}
		((Form)keyboardForm).set_MinimizeBox(false);
		((Form)keyboardForm).set_MaximizeBox(false);
		keyboardForm.checkKeyDown = bIncludeKeyDown;
		((Form)keyboardForm).ShowDialog();
		return keyboardForm.keyinfo;
	}
}
