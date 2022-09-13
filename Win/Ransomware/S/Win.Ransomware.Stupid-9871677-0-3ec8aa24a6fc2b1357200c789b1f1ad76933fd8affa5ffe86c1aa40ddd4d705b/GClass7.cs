using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
[ComVisible(true)]
public class GClass7
{
	public bool method_0(string string_0)
	{
		return GClass9.smethod_17(string_0);
	}

	public bool method_1(string string_0)
	{
		return GClass9.smethod_18(string_0, bool_18: true);
	}

	public bool method_2(string string_0)
	{
		return GClass9.smethod_0(string_0);
	}

	public bool method_3(string string_0, string string_1)
	{
		return GClass9.smethod_3(string_0, string_1);
	}

	public void method_4(string string_0)
	{
		GClass9.smethod_2(string_0);
	}

	public string method_5()
	{
		return GClass9.Version_0.ToString();
	}
}
