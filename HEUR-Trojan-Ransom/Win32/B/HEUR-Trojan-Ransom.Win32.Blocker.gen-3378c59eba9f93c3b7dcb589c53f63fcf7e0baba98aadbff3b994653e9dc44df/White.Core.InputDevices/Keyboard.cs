using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using White.Core.UIItems.Actions;
using White.Core.WindowsAPI;

namespace White.Core.InputDevices;

public class Keyboard : IKeyboard
{
	private static readonly List<KeyboardInput.SpecialKeys> scanCodeDependent = new List<KeyboardInput.SpecialKeys>
	{
		KeyboardInput.SpecialKeys.RIGHT_ALT,
		KeyboardInput.SpecialKeys.INSERT,
		KeyboardInput.SpecialKeys.DELETE,
		KeyboardInput.SpecialKeys.LEFT,
		KeyboardInput.SpecialKeys.HOME,
		KeyboardInput.SpecialKeys.END,
		KeyboardInput.SpecialKeys.UP,
		KeyboardInput.SpecialKeys.DOWN,
		KeyboardInput.SpecialKeys.PAGEUP,
		KeyboardInput.SpecialKeys.PAGEDOWN,
		KeyboardInput.SpecialKeys.RIGHT,
		KeyboardInput.SpecialKeys.LWIN,
		KeyboardInput.SpecialKeys.RWIN
	};

	private readonly List<KeyboardInput.SpecialKeys> heldKeys = new List<KeyboardInput.SpecialKeys>();

	public static readonly Keyboard Instance = new Keyboard();

	private readonly List<int> keysHeld = new List<int>();

	public virtual bool CapsLockOn
	{
		get
		{
			ushort keyState = GetKeyState(20u);
			return keyState != 0;
		}
		set
		{
			if (CapsLockOn != value)
			{
				Send(KeyboardInput.SpecialKeys.CAPS, specialKey: true);
			}
		}
	}

	public virtual KeyboardInput.SpecialKeys[] HeldKeys => heldKeys.ToArray();

	[DllImport("user32")]
	private static extern int SendInput(uint numberOfInputs, ref Input input, int structSize);

	[DllImport("user32.dll")]
	private static extern IntPtr GetMessageExtraInfo();

	[DllImport("user32.dll")]
	private static extern short VkKeyScan(char ch);

	[DllImport("user32.dll")]
	private static extern ushort GetKeyState(uint virtKey);

	private Keyboard()
	{
	}

	public virtual void Enter(string keysToType)
	{
		Send(keysToType, new NullActionListener());
	}

	public virtual void Send(string keysToType, ActionListener actionListener)
	{
		if (heldKeys.Count > 0)
		{
			keysToType = keysToType.ToLower();
		}
		CapsLockOn = false;
		string text = keysToType;
		for (int i = 0; i < text.Length; i++)
		{
			char ch = text[i];
			short key = VkKeyScan(ch);
			if (!ch.Equals('\r'))
			{
				if (ShiftKeyIsNeeded(key))
				{
					SendKeyDown(16, specialKey: false);
				}
				Press(key, specialKey: false);
				if (ShiftKeyIsNeeded(key))
				{
					SendKeyUp(16, specialKey: false);
				}
			}
		}
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	public virtual void PressSpecialKey(KeyboardInput.SpecialKeys key)
	{
		PressSpecialKey(key, new NullActionListener());
	}

	public virtual void PressSpecialKey(KeyboardInput.SpecialKeys key, ActionListener actionListener)
	{
		Send(key, specialKey: true);
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	public virtual void HoldKey(KeyboardInput.SpecialKeys key)
	{
		HoldKey(key, new NullActionListener());
	}

	internal virtual void HoldKey(KeyboardInput.SpecialKeys key, ActionListener actionListener)
	{
		SendKeyDown((short)key, specialKey: true);
		heldKeys.Add(key);
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	public virtual void LeaveKey(KeyboardInput.SpecialKeys key)
	{
		LeaveKey(key, new NullActionListener());
	}

	public virtual void LeaveKey(KeyboardInput.SpecialKeys key, ActionListener actionListener)
	{
		SendKeyUp((short)key, specialKey: true);
		heldKeys.Remove(key);
		actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
	}

	private void Press(short key, bool specialKey)
	{
		SendKeyDown(key, specialKey);
		SendKeyUp(key, specialKey);
	}

	private void Send(KeyboardInput.SpecialKeys key, bool specialKey)
	{
		Press((short)key, specialKey);
	}

	private static bool ShiftKeyIsNeeded(short key)
	{
		return ((key >> 8) & 1) == 1;
	}

	private void SendKeyUp(short b, bool specialKey)
	{
		if (!keysHeld.Contains(b))
		{
			throw new InputDeviceException($"Cannot press the key {b} as its already pressed");
		}
		keysHeld.Remove(b);
		KeyboardInput.KeyUpDown specialKeyCode = GetSpecialKeyCode(specialKey, KeyboardInput.KeyUpDown.KEYEVENTF_KEYUP);
		SendInput(GetInputFor(b, specialKeyCode));
	}

	private static KeyboardInput.KeyUpDown GetSpecialKeyCode(bool specialKey, KeyboardInput.KeyUpDown key)
	{
		if (specialKey && scanCodeDependent.Contains((KeyboardInput.SpecialKeys)key))
		{
			key |= KeyboardInput.KeyUpDown.KEYEVENTF_EXTENDEDKEY;
		}
		return key;
	}

	private void SendKeyDown(short b, bool specialKey)
	{
		if (keysHeld.Contains(b))
		{
			throw new InputDeviceException($"Cannot press the key {b} as its already pressed");
		}
		keysHeld.Add(b);
		KeyboardInput.KeyUpDown specialKeyCode = GetSpecialKeyCode(specialKey, KeyboardInput.KeyUpDown.KEYEVENTF_KEYDOWN);
		SendInput(GetInputFor(b, specialKeyCode));
	}

	private static void SendInput(Input input)
	{
		SendInput(1u, ref input, Marshal.SizeOf(typeof(Input)));
	}

	private static Input GetInputFor(short character, KeyboardInput.KeyUpDown keyUpOrDown)
	{
		return InputFactory.Keyboard(new KeyboardInput(character, keyUpOrDown, GetMessageExtraInfo()));
	}

	public virtual void LeaveAllKeys()
	{
		new List<KeyboardInput.SpecialKeys>(heldKeys).ForEach(LeaveKey);
	}
}
