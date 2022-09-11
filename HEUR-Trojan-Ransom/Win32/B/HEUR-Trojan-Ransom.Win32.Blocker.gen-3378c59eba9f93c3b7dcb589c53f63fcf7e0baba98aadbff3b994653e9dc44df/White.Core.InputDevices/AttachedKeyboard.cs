using White.Core.UIItems;
using White.Core.WindowsAPI;

namespace White.Core.InputDevices;

public class AttachedKeyboard : IKeyboard
{
	private readonly UIItemContainer container;

	private readonly Keyboard keyboard;

	public virtual bool CapsLockOn
	{
		get
		{
			return keyboard.CapsLockOn;
		}
		set
		{
			container.Focus();
			keyboard.CapsLockOn = value;
		}
	}

	internal AttachedKeyboard(UIItemContainer container, Keyboard keyboard)
	{
		this.container = container;
		this.keyboard = keyboard;
	}

	public virtual void Enter(string keysToType)
	{
		container.Focus();
		keyboard.Send(keysToType, container);
	}

	public virtual void PressSpecialKey(KeyboardInput.SpecialKeys key)
	{
		container.Focus();
		keyboard.PressSpecialKey(key, container);
	}

	public virtual void HoldKey(KeyboardInput.SpecialKeys key)
	{
		container.Focus();
		keyboard.HoldKey(key, container);
	}

	public virtual void LeaveKey(KeyboardInput.SpecialKeys key)
	{
		container.Focus();
		keyboard.LeaveKey(key, container);
	}
}
