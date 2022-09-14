using System;
using System.Reflection;

namespace NuGet.Common;

public static class myM33D8A2T
{
	private static string IIdQvFmeba;

	public static string zp0eiWrhJo()
	{
		if (IIdQvFmeba == null)
		{
			string text = string.Empty;
			Assembly assembly = typeof(myM33D8A2T).GetTypeInfo().Assembly;
			AssemblyInformationalVersionAttribute customAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
			if (customAttribute != null)
			{
				text = customAttribute.InformationalVersion;
			}
			else
			{
				AssemblyVersionAttribute customAttribute2 = assembly.GetCustomAttribute<AssemblyVersionAttribute>();
				if (customAttribute2 != null)
				{
					text = customAttribute2.Version.ToString();
				}
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new InvalidOperationException(vK4KTOtZYy.bS2ygMRJEw);
			}
			IIdQvFmeba = text;
		}
		return IIdQvFmeba;
	}
}
