using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using Microsoft.Cct.Services;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using _0xH2ignifiers;
using _0xHChan6ries;
using _0xHHa8kamore;

namespace _0xHS3ashed;

internal static class _0xHCol8cky
{
	internal static bool _0xHCounte3plans(Exception _0xHDraggl6)
	{
		if (_0xHDraggl6 is COMException)
		{
			return ((COMException)_0xHDraggl6).ErrorCode == -2147221492;
		}
		return false;
	}

	internal static void _0xHPai6ed(IServiceProvider _0xHGroupi5, WatError _0xH7abirussa, params object[] _0xHR2typ2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		string text = string.Format(CultureInfo.CurrentCulture, _0xH7abirussa._0xHN6tur6lize(), _0xHR2typ2);
		_0xHL1mniscus._0xHIndividualisin4(_0xH7abirussa);
		if (!VsShellUtilities.IsInAutomationFunction(_0xHGroupi5))
		{
			string officialName = Resources_Common.OfficialName;
			VsShellUtilities.ShowMessageBox(_0xHGroupi5, text, officialName, (OLEMSGICON)3, (OLEMSGBUTTON)0, (OLEMSGDEFBUTTON)0);
		}
	}

	internal static void _0xH7eltzer(IServiceProvider _0xHRe7alidates, string _0xHPrematurene44)
	{
		_0xHCrusi6y(_0xHRe7alidates, _0xHPrematurene44, _0xHChirogra1hy: true);
	}

	internal static void _0xHCrusi6y(IServiceProvider _0xHT2ngles, string _0xHWa5erborne, bool _0xHChirogra1hy)
	{
		if (!string.IsNullOrEmpty(_0xHWa5erborne))
		{
			_0xHL1mniscus._0xHWhimsi2al();
			if (!VsShellUtilities.IsInAutomationFunction(_0xHT2ngles))
			{
				string officialName = Resources_Common.OfficialName;
				VsShellUtilities.ShowMessageBox(_0xHT2ngles, _0xHWa5erborne, officialName, (OLEMSGICON)3, (OLEMSGBUTTON)0, (OLEMSGDEFBUTTON)0);
			}
		}
	}

	internal static string _0xHO0tspan(Exception _0xHAntee4)
	{
		return _0xHS8ibni8e(_0xHAntee4, _0xHD3nut: false);
	}

	internal static string _0xHS8ibni8e(Exception _0xHEe6grass, bool _0xHD3nut)
	{
		string result = null;
		if (_0xHEe6grass is TargetInvocationException)
		{
			_0xHEe6grass = _0xHEe6grass.InnerException;
		}
		if (_0xHEe6grass != null && !_0xHCounte3plans(_0xHEe6grass))
		{
			result = ((!_0xHD3nut) ? _0xHEe6grass.Message : (_0xHEe6grass.GetType().Name + ": " + _0xHEe6grass.Message));
		}
		return result;
	}

	internal static string _0xHCor2oreal(ValidationError _0xHPlum0te)
	{
		string text = null;
		text = _0xHO0tspan(_0xHPlum0te.get_Exception());
		if (text == null && _0xHPlum0te.get_ErrorContent() != null)
		{
			text = _0xHPlum0te.get_ErrorContent().ToString();
		}
		return text;
	}
}
