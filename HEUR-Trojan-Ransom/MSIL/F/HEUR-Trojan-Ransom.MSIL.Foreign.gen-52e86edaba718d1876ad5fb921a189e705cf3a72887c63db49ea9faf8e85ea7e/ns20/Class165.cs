using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns24;

namespace ns20;

internal sealed class Class165
{
	[NonSerialized]
	internal static GetString getString_0;

	[DisplayName("_client_name")]
	public string ClientName => getString_0(107375508);

	[DisplayName("_pid")]
	public string PID
	{
		get
		{
			string result = string.Empty;
			try
			{
				result = Process.GetCurrentProcess().Id.ToString();
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	[DisplayName("_client_version")]
	public string ClientVersion
	{
		get
		{
			string result = string.Empty;
			try
			{
				result = typeof(Class165).GetTypeInfo().Assembly.GetName().Version!.ToString();
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	[DisplayName("_platform")]
	public string Platform
	{
		get
		{
			if (!method_0())
			{
				return getString_0(107375447);
			}
			return getString_0(107375470);
		}
	}

	[DisplayName("_os")]
	public string OS
	{
		get
		{
			string text = string.Empty;
			try
			{
				if (Class131.smethod_3())
				{
					return getString_0(107375429);
				}
				text = Environment.OSVersion.Platform.ToString();
				if (text == getString_0(107375416))
				{
					text = getString_0(107375435);
					text += (method_0() ? getString_0(107375905) : getString_0(107375910));
					return text;
				}
				return text;
			}
			catch (Exception)
			{
				return text;
			}
		}
	}

	[DisplayName("_os_details")]
	public string OSDetails
	{
		get
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			string result = string.Empty;
			try
			{
				ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(getString_0(107375900)).Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						result = enumerator.get_Current().GetPropertyValue(getString_0(107375883)).ToString();
						return result;
					}
					return result;
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	[DisplayName("_thread")]
	public string Thread
	{
		get
		{
			string result = string.Empty;
			try
			{
				result = Process.GetCurrentProcess().Threads[0].Id.ToString();
				return result;
			}
			catch (Exception)
			{
				return result;
			}
		}
	}

	private bool method_0()
	{
		return Environment.GetEnvironmentVariable(getString_0(107375838)) == getString_0(107375805);
	}

	static Class165()
	{
		Strings.CreateGetStringDelegate(typeof(Class165));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398636), getString_0(107398631)).Replace(getString_0(107398594), getString_0(107398589)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398584)))
		{
			throw new SecurityException(getString_0(107398559));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
