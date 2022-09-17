using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Policy;

namespace Server.Helper;

public class ReferenceLoader : MarshalByRefObject
{
	public string[] LoadReferences(string assemblyPath)
	{
		try
		{
			return (from x in Assembly.ReflectionOnlyLoadFrom(assemblyPath).GetReferencedAssemblies()
				select x.FullName).ToArray();
		}
		catch
		{
			return null;
		}
	}

	public void AppDomainSetup(string assemblyPath)
	{
		try
		{
			AppDomainSetup appDomainSetup = new AppDomainSetup();
			appDomainSetup.set_ApplicationBase(AppDomain.CurrentDomain.BaseDirectory);
			AppDomainSetup appDomainSetup2 = appDomainSetup;
			AppDomain appDomain = AppDomain.CreateDomain(Guid.NewGuid().ToString(), (Evidence)null, appDomainSetup2);
			((ReferenceLoader)Activator.CreateInstance(appDomain, typeof(ReferenceLoader).Assembly.FullName, typeof(ReferenceLoader).FullName, false, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder)null, (object[])null, CultureInfo.CurrentCulture, new object[0]).Unwrap()).LoadReferences(assemblyPath);
			AppDomain.Unload(appDomain);
		}
		catch
		{
		}
	}
}
