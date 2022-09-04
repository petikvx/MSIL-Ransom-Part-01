using System.Runtime.CompilerServices;
using Microsoft.Win32;

namespace ns0;

internal sealed class Class2
{
	internal static object object_0;

	internal static string string_0;

	internal static string string_1 = Class6.smethod_0(10);

	private static RegistryKey registryKey_0 = Registry.LocalMachine.OpenSubKey(Class6.smethod_0(59), writable: false);

	internal static object object_1 = RuntimeHelpers.GetObjectValue(registryKey_0.GetValue(Class6.smethod_0(120)));

	internal static string string_2 = Class6.smethod_0(133);
}
