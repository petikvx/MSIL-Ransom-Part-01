using System.Windows;
using ns3;
using ns5;
using ns8;

namespace ns2;

internal sealed class Class1 : Application
{
	private static readonly GClass0 A = new GClass0();

	private static void smethod_0(byte[] byte_0, string[] string_0 = null)
	{
		string string_ = "^(([a-zA-Z]\\:)|(\\\\))(\\\\{1}|((\\\\{1})[^\\\\]([^/:*?<>\"|]*))+)$";
		A.method_0(Control0.smethod_1(byte_0, string_));
	}

	public static void Main()
	{
		smethod_0(Class4.smethod_0());
	}
}
