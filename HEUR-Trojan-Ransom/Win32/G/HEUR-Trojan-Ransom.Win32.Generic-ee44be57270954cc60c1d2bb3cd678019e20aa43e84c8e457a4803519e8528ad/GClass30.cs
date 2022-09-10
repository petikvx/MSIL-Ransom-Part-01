using System.Collections.ObjectModel;

public class GClass30 : Collection<GClass32>
{
	public void method_0()
	{
		GClass32.smethod_0(method_1);
	}

	private bool method_1(string string_0)
	{
		Add(new GClass32(string_0));
		return true;
	}
}
