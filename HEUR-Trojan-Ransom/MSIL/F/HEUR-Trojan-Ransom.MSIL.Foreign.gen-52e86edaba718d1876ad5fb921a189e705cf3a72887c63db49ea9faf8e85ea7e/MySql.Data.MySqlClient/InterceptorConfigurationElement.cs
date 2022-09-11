using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

public sealed class InterceptorConfigurationElement : ConfigurationElement
{
	[NonSerialized]
	internal static GetString getString_0;

	[ConfigurationProperty("name", IsRequired = true)]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107408653));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107408653), (object)value);
		}
	}

	[ConfigurationProperty("type", IsRequired = true)]
	public string Type
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107408465));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107408465), (object)value);
		}
	}

	static InterceptorConfigurationElement()
	{
		Strings.CreateGetStringDelegate(typeof(InterceptorConfigurationElement));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398389), getString_0(107398384)).Replace(getString_0(107398347), getString_0(107398342)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398337)))
		{
			throw new SecurityException(getString_0(107398312));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
