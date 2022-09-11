using System.Runtime.InteropServices;

namespace White.Core.WindowsAPI;

[StructLayout(LayoutKind.Explicit)]
public struct Input
{
	[FieldOffset(0)]
	private int type;

	[FieldOffset(4)]
	private MouseInput mi;

	[FieldOffset(4)]
	private KeyboardInput ki;

	[FieldOffset(4)]
	private readonly HardwareInput hi;

	public static Input MouseInput(int type, MouseInput mouseInput)
	{
		Input result = default(Input);
		result.type = type;
		result.mi = mouseInput;
		return result;
	}

	public static Input KeyboardInput(int type, KeyboardInput keyboardInput)
	{
		Input result = default(Input);
		result.type = type;
		result.ki = keyboardInput;
		return result;
	}
}
