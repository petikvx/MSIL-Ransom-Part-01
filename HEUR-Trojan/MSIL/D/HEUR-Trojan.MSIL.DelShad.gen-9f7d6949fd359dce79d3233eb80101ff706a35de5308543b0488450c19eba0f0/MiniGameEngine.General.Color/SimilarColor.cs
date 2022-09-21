using System;
using System.Drawing;

namespace MiniGameEngine.General.Color;

public class SimilarColor
{
	private RandomColor randomColor_0;

	public SimilarColor(System.Drawing.Color similarColor, double Depth)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		double num = Math.Abs((double)similarColor.GetHue() - Math.Abs(Depth)) % 360.0;
		double num2 = Math.Abs((double)similarColor.GetHue() + Math.Abs(Depth)) % 360.0;
		System.Drawing.Color color = RGBHSL.ModifyHue(similarColor, num / 360.0);
		System.Drawing.Color color2 = RGBHSL.ModifyHue(similarColor, num2 / 360.0);
		randomColor_0 = new RandomColor(color.R, color2.R, color.G, color2.G, color.B, color2.B, color.A, color2.A);
	}

	public System.Drawing.Color Next()
	{
		return randomColor_0.Next();
	}
}
