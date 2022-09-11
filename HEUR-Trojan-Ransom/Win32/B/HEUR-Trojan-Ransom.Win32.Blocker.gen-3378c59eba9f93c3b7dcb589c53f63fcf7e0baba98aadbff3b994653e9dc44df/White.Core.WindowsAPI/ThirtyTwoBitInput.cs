using System.Runtime.InteropServices;

namespace White.Core.WindowsAPI;

[StructLayout(LayoutKind.Explicit)]
public struct ThirtyTwoBitInput
{
	[FieldOffset(0)]
	private int type;

	[FieldOffset(4)]
	private MouseInput mi;

	[FieldOffset(4)]
	private KeyboardInput ki;

	[FieldOffset(4)]
	private readonly HardwareInput hi;

	public static ThirtyTwoBitInput Mouse(MouseInput mouseInput)
	{
		ThirtyTwoBitInput result = default(ThirtyTwoBitInput);
		result.type = 0;
		result.mi = mouseInput;
		return result;
	}

	public static ThirtyTwoBitInput Keyboard(KeyboardInput keyboardInput)
	{
		ThirtyTwoBitInput result = default(ThirtyTwoBitInput);
		result.type = 1;
		result.ki = keyboardInput;
		return result;
	}
}
