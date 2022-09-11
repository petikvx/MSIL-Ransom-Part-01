namespace White.Core.WindowsAPI;

public class InputFactory
{
	public static Input Mouse(MouseInput mouseInput)
	{
		return Input.MouseInput(0, mouseInput);
	}

	public static Input Keyboard(KeyboardInput keyboardInput)
	{
		return Input.KeyboardInput(1, keyboardInput);
	}
}
