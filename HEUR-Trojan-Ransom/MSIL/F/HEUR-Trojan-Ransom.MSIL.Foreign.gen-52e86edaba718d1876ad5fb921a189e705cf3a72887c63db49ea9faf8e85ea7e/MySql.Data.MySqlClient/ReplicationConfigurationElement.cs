using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

public sealed class ReplicationConfigurationElement : ConfigurationElement
{
	[NonSerialized]
	internal static GetString getString_0;

	[ConfigurationProperty("ServerGroups", IsRequired = true)]
	[ConfigurationCollection(typeof(ReplicationServerGroupConfigurationElement), AddItemName = "Group")]
	public GenericConfigurationElementCollection<ReplicationServerGroupConfigurationElement> ServerGroups => (GenericConfigurationElementCollection<ReplicationServerGroupConfigurationElement>)((ConfigurationElement)this).get_Item(getString_0(107375658));

	static ReplicationConfigurationElement()
	{
		Strings.CreateGetStringDelegate(typeof(ReplicationConfigurationElement));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399391), getString_0(107399386)).Replace(getString_0(107399349), getString_0(107399344)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399339)))
		{
			throw new SecurityException(getString_0(107399314));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
