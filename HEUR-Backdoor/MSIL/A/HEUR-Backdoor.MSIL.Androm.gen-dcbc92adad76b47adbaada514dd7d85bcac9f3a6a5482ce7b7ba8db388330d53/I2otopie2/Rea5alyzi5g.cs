using System;
using System.Reflection;
using Chol2tes;

namespace I2otopie2;

public static class Rea5alyzi5g
{
	private static string Uninjure4;

	public static string Congruent7y()
	{
		if (Uninjure4 == null)
		{
			string text = string.Empty;
			Assembly assembly = typeof(Rea5alyzi5g).GetTypeInfo().Assembly;
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
				throw new InvalidOperationException(Strings.UnableToDetemineClientVersion);
			}
			Uninjure4 = text;
		}
		return Uninjure4;
	}
}
