using System.Runtime.InteropServices;
using ns5;

namespace ns0;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
[ComVisible(true)]
public sealed class GClass3
{
	private const int int_0 = 8192;

	internal uint uint_0;

	internal long long_0;

	internal bool bool_0;

	internal uint[] uint_1;

	internal uint uint_2 = uint.MaxValue;

	public long TotalBytesRead => long_0;

	public int Crc32Result => (int)(~uint_2);

	public GClass3()
		: this(bool_1: false)
	{
	}

	public GClass3(bool bool_1)
		: this(-306674912, bool_1)
	{
	}

	public GClass3(int int_1, bool bool_1)
	{
		bool_0 = bool_1;
		uint_0 = (uint)int_1;
		Class6.smethod_410(this);
	}
}
