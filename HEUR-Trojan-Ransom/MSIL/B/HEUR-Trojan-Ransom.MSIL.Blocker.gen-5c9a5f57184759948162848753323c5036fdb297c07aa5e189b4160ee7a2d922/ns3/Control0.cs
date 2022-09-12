using System.Reflection;
using System.Threading;
using System.Windows.Controls;

namespace ns3;

internal sealed class Control0 : Control
{
	private static Assembly w;

	public static Assembly smethod_0(byte[] byte_0)
	{
		return smethod_1(byte_0);
	}

	public static Assembly smethod_1(byte[] byte_0)
	{
		w = Thread.GetDomain().Load(byte_0);
		int num = byte_0.Length;
		while (num-- > 0)
		{
			byte_0[num] = 0;
		}
		return w;
	}
}
