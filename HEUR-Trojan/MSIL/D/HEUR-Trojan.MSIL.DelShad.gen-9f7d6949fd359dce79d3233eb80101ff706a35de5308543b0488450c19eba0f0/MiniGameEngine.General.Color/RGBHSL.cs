using System;
using System.Drawing;

namespace MiniGameEngine.General.Color;

public class RGBHSL
{
	public class HSL
	{
		private double double_0;

		private double double_1;

		private double double_2;

		public double H
		{
			get
			{
				return double_0;
			}
			set
			{
				double_0 = value;
				double_0 = ((double_0 > 1.0) ? 1.0 : ((double_0 < 0.0) ? 0.0 : double_0));
			}
		}

		public double S
		{
			get
			{
				return double_1;
			}
			set
			{
				double_1 = value;
				double_1 = ((double_1 > 1.0) ? 1.0 : ((double_1 < 0.0) ? 0.0 : double_1));
			}
		}

		public double L
		{
			get
			{
				return double_2;
			}
			set
			{
				double_2 = value;
				double_2 = ((double_2 > 1.0) ? 1.0 : ((double_2 < 0.0) ? 0.0 : double_2));
			}
		}

		public HSL()
		{
			Class11.NQ1E32yzjMukk();
			base._002Ector();
			double_0 = 0.0;
			double_1 = 0.0;
			double_2 = 0.0;
		}
	}

	public RGBHSL()
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
	}

	public static System.Drawing.Color SetBrightness(System.Drawing.Color c, double brightness)
	{
		HSL hSL = RGB_to_HSL(c);
		hSL.L = brightness;
		return HSL_to_RGB(hSL);
	}

	public static System.Drawing.Color ModifyBrightness(System.Drawing.Color c, double brightness)
	{
		HSL hSL = RGB_to_HSL(c);
		hSL.L *= brightness;
		return HSL_to_RGB(hSL);
	}

	public static System.Drawing.Color SetSaturation(System.Drawing.Color c, double Saturation)
	{
		HSL hSL = RGB_to_HSL(c);
		hSL.S = Saturation;
		return HSL_to_RGB(hSL);
	}

	public static System.Drawing.Color ModifySaturation(System.Drawing.Color c, double Saturation)
	{
		HSL hSL = RGB_to_HSL(c);
		hSL.S *= Saturation;
		return HSL_to_RGB(hSL);
	}

	public static System.Drawing.Color SetHue(System.Drawing.Color c, double Hue)
	{
		HSL hSL = RGB_to_HSL(c);
		hSL.H = Hue;
		return HSL_to_RGB(hSL);
	}

	public static System.Drawing.Color ModifyHue(System.Drawing.Color c, double Hue)
	{
		HSL hSL = RGB_to_HSL(c);
		hSL.H *= Hue;
		return HSL_to_RGB(hSL);
	}

	public static System.Drawing.Color HSL_to_RGB(HSL hsl)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		checked
		{
			if (hsl.L == 0.0)
			{
				num = 0.0;
				num2 = 0.0;
				num3 = 0.0;
			}
			else if (hsl.S == 0.0)
			{
				num = hsl.L;
				num2 = hsl.L;
				num3 = hsl.L;
			}
			else
			{
				double num4 = ((hsl.L <= 0.5) ? (hsl.L * (1.0 + hsl.S)) : (hsl.L + hsl.S - hsl.L * hsl.S));
				double num5 = 2.0 * hsl.L - num4;
				double[] array = new double[3]
				{
					hsl.H + 1.0 / 3.0,
					hsl.H,
					hsl.H - 1.0 / 3.0
				};
				double[] array2 = new double[3];
				int num6 = 0;
				do
				{
					if (array[num6] < 0.0)
					{
						array[num6] += 1.0;
					}
					if (array[num6] > 1.0)
					{
						array[num6] -= 1.0;
					}
					if (6.0 * array[num6] < 1.0)
					{
						array2[num6] = num5 + (num4 - num5) * array[num6] * 6.0;
					}
					else if (2.0 * array[num6] < 1.0)
					{
						array2[num6] = num4;
					}
					else if (3.0 * array[num6] < 2.0)
					{
						array2[num6] = num5 + (num4 - num5) * (2.0 / 3.0 - array[num6]) * 6.0;
					}
					else
					{
						array2[num6] = num5;
					}
					num6++;
				}
				while (num6 <= 2);
				num = array2[0];
				num2 = array2[1];
				num3 = array2[2];
			}
			return System.Drawing.Color.FromArgb((int)Math.Round(255.0 * num), (int)Math.Round(255.0 * num2), (int)Math.Round(255.0 * num3));
		}
	}

	public static HSL RGB_to_HSL(System.Drawing.Color c)
	{
		HSL hSL = new HSL();
		hSL.H = (double)c.GetHue() / 360.0;
		hSL.L = c.GetBrightness();
		hSL.S = c.GetSaturation();
		return hSL;
	}
}
