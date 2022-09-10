using System.Drawing;

public struct GStruct0
{
	public string string_0;

	private Color color_0;

	public string String_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return string_0;
		}
	}

	public Color Color_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return color_0;
		}
		set
		{
			color_0 = value;
		}
	}

	public string String_1
	{
		get
		{
			if (1 == 0)
			{
			}
			return "#" + color_0.R.ToString("X2", null) + color_0.G.ToString("X2", null) + color_0.B.ToString("X2", null);
		}
		set
		{
			if (1 == 0)
			{
			}
			try
			{
				color_0 = ColorTranslator.FromHtml(value);
			}
			catch
			{
			}
		}
	}

	public GStruct0(string string_1, Color color_1)
	{
		if (1 == 0)
		{
		}
		string_0 = string_1;
		color_0 = color_1;
	}
}
