using System.Windows;
using ns2;
using ns5;
using ns6;

namespace ns4;

internal sealed class Class3 : Application
{
	private static readonly Class4 q = new Class4();

	private static void smethod_0(byte[] byte_0, string[] string_0 = null)
	{
		string string_ = "^(([a-zA-Z]\\:)|(\\\\))(\\\\{1}|((\\\\{1})[^\\\\]([^/:*?<>\"|]*))+)$";
		q.method_0(Control0.smethod_1(byte_0, string_));
	}

	public static void Main()
	{
		smethod_0(Class1.smethod_0());
	}
}
