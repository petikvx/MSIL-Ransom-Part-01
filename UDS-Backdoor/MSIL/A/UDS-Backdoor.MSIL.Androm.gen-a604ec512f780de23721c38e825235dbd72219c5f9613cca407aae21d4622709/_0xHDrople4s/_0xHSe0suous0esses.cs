using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.WindowsAzure;

namespace _0xHDrople4s;

public static class _0xHSe0suous0esses
{
	public static T _0xH0ppers<T>(this DependencyObject _0xHSpeech4f4es) where T : DependencyObject
	{
		DependencyObject val = _0xHSpeech4f4es;
		T val2;
		while (true)
		{
			if (val != null)
			{
				val2 = (T)(object)((val is T) ? val : null);
				if (val2 != null)
				{
					break;
				}
				val = VisualTreeHelper.GetParent(val);
				continue;
			}
			return default(T);
		}
		return val2;
	}

	public static T _0xHBan6sias<T>(this DependencyObject _0xH7scapism, Func<T, bool> _0xHVentle33) where T : DependencyObject
	{
		DependencyObject val = _0xH7scapism;
		T val2;
		while (true)
		{
			if (val != null)
			{
				val2 = (T)(object)((val is T) ? val : null);
				if (val2 != null && _0xHVentle33(val2))
				{
					break;
				}
				val = VisualTreeHelper.GetParent(val);
				continue;
			}
			return default(T);
		}
		return val2;
	}

	public static T _0xHUnbe5r5ble<T>(this DependencyObject _0xHUrb7nists) where T : DependencyObject
	{
		if (_0xHUrb7nists == null)
		{
			throw new ArgumentNullException("reference");
		}
		int num = 0;
		DependencyObject child;
		while (true)
		{
			if (num < VisualTreeHelper.GetChildrenCount(_0xHUrb7nists))
			{
				child = VisualTreeHelper.GetChild(_0xHUrb7nists, num);
				if (!(child is T))
				{
					child = (DependencyObject)(object)child._0xHUnbe5r5ble<T>();
					if (child != null)
					{
						break;
					}
					num++;
					continue;
				}
				return (T)(object)child;
			}
			return default(T);
		}
		return (T)(object)child;
	}

	public static IEnumerable<T> _0xHDe7ayed<T>(this DependencyObject _0xH4iceros) where T : DependencyObject
	{
		if (_0xH4iceros == null)
		{
			throw new ArgumentNullException("reference");
		}
		for (int i = 0; i < VisualTreeHelper.GetChildrenCount(_0xH4iceros); i++)
		{
			DependencyObject child = VisualTreeHelper.GetChild(_0xH4iceros, i);
			if (child is T)
			{
				yield return (T)(object)child;
			}
			foreach (T item in child._0xHDe7ayed<T>())
			{
				yield return item;
			}
		}
	}

	public static T _0xHRefound8ng<T>(this DependencyObject _0xHUpgra4able, string _0xHSyn2opating) where T : FrameworkElement
	{
		if (_0xHUpgra4able == null)
		{
			throw new ArgumentNullException("reference");
		}
		return _0xHUpgra4able._0xHDe7ayed<T>().FirstOrDefault((T c) => string.Compare(((FrameworkElement)c).get_Name(), _0xHSyn2opating, StringComparison.Ordinal) == 0);
	}

	public static void _0xHT7m7rr7w(this DependencyObject _0xHS3eekers, IServiceProvider _0xHNotorio5s, CommandID _0xHR6strictiv6n6ss, Visual _0xHCarvacro3, double _0xHEffaceab1e, double _0xHCuddl5d, double _0xHDu4t, double _0xHB6le)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		IMenuCommandService service = ServiceProviderExtensions.GetService<IMenuCommandService, IMenuCommandService>(_0xHNotorio5s);
		OleMenuCommandService val = (OleMenuCommandService)((service is OleMenuCommandService) ? service : null);
		if (val == null)
		{
			return;
		}
		Point val2 = default(Point);
		((Point)(ref val2))._002Ector(_0xHDu4t, _0xHB6le);
		if (_0xHDu4t != -1.0 && _0xHB6le != -1.0)
		{
			if (_0xHS3eekers is Visual)
			{
				_0xHCarvacro3 = (Visual)_0xHS3eekers;
			}
		}
		else
		{
			((Point)(ref val2)).set_X(_0xHEffaceab1e);
			((Point)(ref val2)).set_Y(_0xHCuddl5d);
		}
		Point val3 = _0xHCarvacro3.PointToScreen(val2);
		((MenuCommandService)val).ShowContextMenu(_0xHR6strictiv6n6ss, (int)((Point)(ref val3)).get_X(), (int)((Point)(ref val3)).get_Y());
	}
}
