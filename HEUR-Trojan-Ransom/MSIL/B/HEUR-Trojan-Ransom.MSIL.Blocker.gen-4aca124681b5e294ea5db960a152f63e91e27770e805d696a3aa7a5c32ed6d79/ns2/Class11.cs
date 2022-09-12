using System.Security.Principal;

namespace ns2;

internal static class Class11
{
	public static string smethod_0()
	{
		return WindowsIdentity.GetCurrent().User!.ToString();
	}
}
