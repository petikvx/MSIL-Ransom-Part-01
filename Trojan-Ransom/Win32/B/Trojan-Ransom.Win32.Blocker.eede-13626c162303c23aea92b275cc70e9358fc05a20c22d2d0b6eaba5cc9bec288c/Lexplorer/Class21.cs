using System.Drawing;

namespace Lexplorer;

internal class Class21 : Class13
{
	private const int BOOL_TRUE = 1;

	private const int BOOL_FALSE = 0;

	public static int prevResolutionWidth;

	public static int prevResolutionHeight;

	public Class21()
	{
		methodTable.Add("POWER", Power);
		methodTable.Add("RESOLUTION", Resolution);
	}

	private bool Power(Class10 props, bool forced)
	{
		int num = int.Parse(props["V"]);
		Class9.SetStateEnabled(num == 1);
		return true;
	}

	private bool Resolution(Class10 props, bool forced)
	{
		if (prevResolutionHeight == 0 && prevResolutionWidth == 0)
		{
			Size currentResolution = Class9.GetCurrentResolution();
			prevResolutionWidth = currentResolution.Width;
			prevResolutionHeight = currentResolution.Height;
		}
		if (props["V"] == "default")
		{
			if (prevResolutionHeight > 0 && prevResolutionWidth > 0)
			{
				Class9.SetResolution(prevResolutionWidth, prevResolutionHeight);
			}
			return true;
		}
		string[] array = props["V"].Split(new char[1] { 'x' });
		int width = int.Parse(array[0]);
		int height = int.Parse(array[1]);
		Class9.SetResolution(width, height);
		return true;
	}

	public override string ToString()
	{
		return $"Command type: SCREEN, Method={base.ExecutionMethodName}";
	}
}
