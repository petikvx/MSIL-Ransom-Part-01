using System.Collections.Generic;
using System.Drawing;

namespace MetroFramework;

internal static class MetroBrushes
{
	private static readonly Dictionary<string, SolidBrush> metroBrushes = new Dictionary<string, SolidBrush>();

	public static SolidBrush Black => GetSaveBrush("Black", MetroColors.Black);

	public static SolidBrush White => GetSaveBrush("White", MetroColors.White);

	public static SolidBrush Silver => GetSaveBrush("Silver", MetroColors.Silver);

	public static SolidBrush Blue => GetSaveBrush("Blue", MetroColors.Blue);

	public static SolidBrush Green => GetSaveBrush("Green", MetroColors.Green);

	public static SolidBrush Lime => GetSaveBrush("Lime", MetroColors.Lime);

	public static SolidBrush Teal => GetSaveBrush("Teal", MetroColors.Teal);

	public static SolidBrush Orange => GetSaveBrush("Orange", MetroColors.Orange);

	public static SolidBrush Brown => GetSaveBrush("Brown", MetroColors.Brown);

	public static SolidBrush Pink => GetSaveBrush("Pink", MetroColors.Pink);

	public static SolidBrush Magenta => GetSaveBrush("Magenta", MetroColors.Magenta);

	public static SolidBrush Purple => GetSaveBrush("Purple", MetroColors.Purple);

	public static SolidBrush Red => GetSaveBrush("Red", MetroColors.Red);

	public static SolidBrush Yellow => GetSaveBrush("Yellow", MetroColors.Yellow);

	private static SolidBrush GetSaveBrush(string key, Color color)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		lock (metroBrushes)
		{
			if (!metroBrushes.TryGetValue(key, out var value))
			{
				value = new SolidBrush(color);
				metroBrushes.Add(key, value);
			}
			return (SolidBrush)((Brush)value).Clone();
		}
	}
}
