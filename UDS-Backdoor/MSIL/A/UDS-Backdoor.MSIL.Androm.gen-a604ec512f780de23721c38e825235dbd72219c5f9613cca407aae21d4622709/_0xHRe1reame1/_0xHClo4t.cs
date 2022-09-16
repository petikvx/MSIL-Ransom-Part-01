using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _0xHRe1reame1;

internal static class _0xHClo4t
{
	public static bool _0xHGildin8(this TextBlock _0xHO4tillion)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		Typeface val = new Typeface(_0xHO4tillion.get_FontFamily(), _0xHO4tillion.get_FontStyle(), _0xHO4tillion.get_FontWeight(), _0xHO4tillion.get_FontStretch());
		string text = _0xHO4tillion.get_Text();
		CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
		FlowDirection flowDirection = ((FrameworkElement)_0xHO4tillion).get_FlowDirection();
		double fontSize = _0xHO4tillion.get_FontSize();
		Brush foreground = _0xHO4tillion.get_Foreground();
		DpiScale dpi = VisualTreeHelper.GetDpi((Visual)(object)_0xHO4tillion);
		return new FormattedText(text, currentCulture, flowDirection, val, fontSize, foreground, ((DpiScale)(ref dpi)).get_PixelsPerDip()).get_Width() > ((FrameworkElement)_0xHO4tillion).get_ActualWidth();
	}
}
