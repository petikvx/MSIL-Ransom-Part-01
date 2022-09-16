using System.Diagnostics.CodeAnalysis;
using System.Windows;
using Microsoft.VisualStudio.PlatformUI;

namespace _0xH7rimmed;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Theming", Justification = "Correctly spelled")]
public static class _0xHScru8inises
{
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Theming", Justification = "Correctly spelled")]
	public static readonly DependencyProperty _0xHR1entgen1l1gy = DependencyProperty.RegisterAttached("DisableScrollBarTheming", typeof(bool), typeof(_0xHScru8inises), new PropertyMetadata((object)false, (PropertyChangedCallback)delegate(DependencyObject d, DependencyPropertyChangedEventArgs e)
	{
		bool flag = !(bool)((DependencyPropertyChangedEventArgs)(ref e)).get_NewValue();
		d.SetValue(ImageThemingUtilities.ThemeScrollBarsProperty, (object)flag);
	}));

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Theming", Justification = "Correctly spelled")]
	public static bool _0xHM6ser6cords(DependencyObject _0xHRedict7te)
	{
		return (bool)_0xHRedict7te.GetValue(_0xHR1entgen1l1gy);
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Theming", Justification = "Correctly spelled")]
	public static void _0xHChat1hka(DependencyObject _0xHStu88ers, bool _0xHPso3tic)
	{
		_0xHStu88ers.SetValue(_0xHR1entgen1l1gy, (object)_0xHPso3tic);
	}
}
