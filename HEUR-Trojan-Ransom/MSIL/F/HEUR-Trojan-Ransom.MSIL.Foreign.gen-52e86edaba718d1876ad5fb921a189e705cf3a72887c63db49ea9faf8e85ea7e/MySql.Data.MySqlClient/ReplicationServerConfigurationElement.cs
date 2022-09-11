using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

public sealed class ReplicationServerConfigurationElement : ConfigurationElement
{
	[NonSerialized]
	internal static GetString getString_0;

	[ConfigurationProperty("name", IsRequired = true)]
	public string Name
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107409657));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107409657), (object)value);
		}
	}

	[ConfigurationProperty("IsMaster", IsRequired = false, DefaultValue = false)]
	public bool IsMaster
	{
		get
		{
			return (bool)((ConfigurationElement)this).get_Item(getString_0(107376116));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107376116), (object)value);
		}
	}

	[ConfigurationProperty("connectionstring", IsRequired = true)]
	public string ConnectionString
	{
		get
		{
			return (string)((ConfigurationElement)this).get_Item(getString_0(107376135));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107376135), (object)value);
		}
	}

	static ReplicationServerConfigurationElement()
	{
		Strings.CreateGetStringDelegate(typeof(ReplicationServerConfigurationElement));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399393), getString_0(107399388)).Replace(getString_0(107399351), getString_0(107399346)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399341)))
		{
			throw new SecurityException(getString_0(107399316));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
