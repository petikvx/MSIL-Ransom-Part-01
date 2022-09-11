using System;
using System.Configuration;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MySql.Data.MySqlClient;

public sealed class MySqlConfiguration : ConfigurationSection
{
	private static MySqlConfiguration mySqlConfiguration_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static MySqlConfiguration Settings => mySqlConfiguration_0;

	[ConfigurationProperty("ExceptionInterceptors", IsRequired = false)]
	[ConfigurationCollection(typeof(InterceptorConfigurationElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	public GenericConfigurationElementCollection<InterceptorConfigurationElement> ExceptionInterceptors => (GenericConfigurationElementCollection<InterceptorConfigurationElement>)((ConfigurationElement)this).get_Item(getString_0(107351118));

	[ConfigurationCollection(typeof(InterceptorConfigurationElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	[ConfigurationProperty("CommandInterceptors", IsRequired = false)]
	public GenericConfigurationElementCollection<InterceptorConfigurationElement> CommandInterceptors => (GenericConfigurationElementCollection<InterceptorConfigurationElement>)((ConfigurationElement)this).get_Item(getString_0(107351601));

	[ConfigurationProperty("AuthenticationPlugins", IsRequired = false)]
	[ConfigurationCollection(typeof(AuthenticationPluginConfigurationElement), AddItemName = "add", ClearItemsName = "clear", RemoveItemName = "remove")]
	public GenericConfigurationElementCollection<AuthenticationPluginConfigurationElement> AuthenticationPlugins => (GenericConfigurationElementCollection<AuthenticationPluginConfigurationElement>)((ConfigurationElement)this).get_Item(getString_0(107351572));

	[ConfigurationProperty("Replication", IsRequired = true)]
	public ReplicationConfigurationElement Replication
	{
		get
		{
			return (ReplicationConfigurationElement)((ConfigurationElement)this).get_Item(getString_0(107351543));
		}
		set
		{
			((ConfigurationElement)this).set_Item(getString_0(107351543), (object)value);
		}
	}

	static MySqlConfiguration()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlConfiguration));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398387), getString_0(107398382)).Replace(getString_0(107398345), getString_0(107398340)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398335)))
		{
			throw new SecurityException(getString_0(107398310));
		}
		mySqlConfiguration_0 = ConfigurationManager.GetSection(getString_0(107351494)) as MySqlConfiguration;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
