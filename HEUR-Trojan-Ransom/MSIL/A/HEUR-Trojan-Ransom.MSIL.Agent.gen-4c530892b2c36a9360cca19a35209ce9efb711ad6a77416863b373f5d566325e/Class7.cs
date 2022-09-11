using System.Collections.Generic;
using System.Drawing;

internal class Class7
{
	public List<Class6> list_0;

	public Class7()
	{
		list_0 = new List<Class6>();
	}

	public void method_0(Graphics graphics_0)
	{
		foreach (Class6 item in list_0)
		{
			item.method_0(graphics_0);
		}
	}
}
