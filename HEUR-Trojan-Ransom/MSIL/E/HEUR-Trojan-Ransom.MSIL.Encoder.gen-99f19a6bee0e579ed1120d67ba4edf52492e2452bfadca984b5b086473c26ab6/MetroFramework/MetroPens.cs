using System.Collections.Generic;
using System.Drawing;

namespace MetroFramework;

internal static class MetroPens
{
	private static readonly Dictionary<string, Pen> metroPens = new Dictionary<string, Pen>();

	public static Pen Black => GetSavePen("Black", MetroColors.Black);

	public static Pen White => GetSavePen("White", MetroColors.White);

	public static Pen Silver => GetSavePen("Silver", MetroColors.Silver);

	public static Pen Blue => GetSavePen("Blue", MetroColors.Blue);

	public static Pen Green => GetSavePen("Green", MetroColors.Green);

	public static Pen Lime => GetSavePen("Lime", MetroColors.Lime);

	public static Pen Teal => GetSavePen("Teal", MetroColors.Teal);

	public static Pen Orange => GetSavePen("Orange", MetroColors.Orange);

	public static Pen Brown => GetSavePen("Brown", MetroColors.Brown);

	public static Pen Pink => GetSavePen("Pink", MetroColors.Pink);

	public static Pen Magenta => GetSavePen("Magenta", MetroColors.Magenta);

	public static Pen Purple => GetSavePen("Purple", MetroColors.Purple);

	public static Pen Red => GetSavePen("Red", MetroColors.Red);

	public static Pen Yellow => GetSavePen("Yellow", MetroColors.Yellow);

	private static Pen GetSavePen(string key, Color color)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		lock (metroPens)
		{
			if (!metroPens.TryGetValue(key, out var value))
			{
				value = new Pen(color, 1f);
				metroPens.Add(key, value);
			}
			return (Pen)value.Clone();
		}
	}
}
