using System;
using System.Drawing;

namespace MiniGameEngine.General.Color;

public class ColorTools
{
	public ColorTools()
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
	}

	public static bool smethod_0(System.Drawing.Color Color1, System.Drawing.Color Color2)
	{
		return Color1.A == Color2.A && Color1.R == Color2.R && Color1.G == Color2.G && Color1.B == Color2.B;
	}

	public static double[] ColorToArray(System.Drawing.Color color)
	{
		return new double[4]
		{
			(int)color.A,
			(int)color.R,
			(int)color.G,
			(int)color.B
		};
	}

	public static System.Drawing.Color ColorFromArray(double[] color)
	{
		byte[] array = new byte[4];
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Math.Round(Math.Min(255.0, Math.Max(0.0, color[i])));
			}
			return System.Drawing.Color.FromArgb(array[0], array[1], array[2], array[3]);
		}
	}
}
