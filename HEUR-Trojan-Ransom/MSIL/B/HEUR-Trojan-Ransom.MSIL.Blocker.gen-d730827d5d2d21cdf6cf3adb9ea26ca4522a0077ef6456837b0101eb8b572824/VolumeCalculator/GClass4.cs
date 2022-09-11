using System.ComponentModel;

namespace VolumeCalculator;

public class GClass4 : Component
{
	public byte[] byte_0 = null;

	public string string_0 = "O4fhRWlSc4fQtuvO1lTQf4tDeLmGz";

	public string string_1 = "vM8mgySaFwcRaDrEINaUplHb2hF0A";

	public string string_2 = "fZeFk7tfwNqZngjo5rlqpR2hiaraA";

	public string string_3 = "U7WZOQkzM1F8gUqpCXtng5dcMQLMC";

	public string string_4 = "Yi32DTMOqNV8NysFq362ucn8CcPCu";

	public string string_5 = "3iKQIxZLySepPC4jnmMqJNUC5HaK4";

	private IContainer icontainer_0 = null;

	public GClass4()
	{
		method_0();
	}

	public GClass4(IContainer icontainer_1)
	{
		icontainer_1.Add(this);
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
	}
}
