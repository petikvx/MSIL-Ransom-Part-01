using System.Windows;
using System.Windows.Controls;

namespace _0xHOverlivin1;

internal static class _0xHD4amatu4ge
{
	public static string _0xHHa8able(FrameworkElement _0xHG1nus, object _0xHSym6olizer)
	{
		if (_0xHG1nus != null && _0xHG1nus.get_ToolTip() != null)
		{
			object toolTip = _0xHG1nus.get_ToolTip();
			ToolTip val = (ToolTip)((toolTip is ToolTip) ? toolTip : null);
			if (val != null)
			{
				if (val.get_IsOpen())
				{
					return ((ContentControl)val).get_Content() as string;
				}
				if (((FrameworkElement)val).get_DataContext() == null)
				{
					((FrameworkElement)val).set_DataContext(_0xHSym6olizer);
				}
				if (val.get_PlacementTarget() == null)
				{
					val.set_PlacementTarget((UIElement)(object)_0xHG1nus);
				}
				if (((UIElement)val).get_IsEnabled() && val.get_PlacementTarget().get_IsKeyboardFocused())
				{
					val.set_IsOpen(true);
					return ((ContentControl)val).get_Content() as string;
				}
			}
			return null;
		}
		return null;
	}

	public static void _0xHGovern1ng(FrameworkElement _0xHColumn2a)
	{
		object obj = ((_0xHColumn2a != null) ? _0xHColumn2a.get_ToolTip() : null);
		ToolTip val = (ToolTip)((obj is ToolTip) ? obj : null);
		if (val != null)
		{
			val.set_IsOpen(false);
		}
	}
}
