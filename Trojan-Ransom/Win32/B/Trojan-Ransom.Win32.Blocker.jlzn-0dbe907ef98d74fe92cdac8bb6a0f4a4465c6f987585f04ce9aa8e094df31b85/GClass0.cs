using System;

public class GClass0 : IDisposable
{
	private bool bool_0;

	static GClass0()
	{
		GClass1 gClass = new GClass1();
		gClass.Dispose();
	}

	[STAThread]
	public static void Main(string[] args)
	{
		Environment.Exit(103020);
	}

	protected virtual void vmethod_0(bool bool_1)
	{
		if (bool_0)
		{
		}
		bool_0 = true;
	}

	public void Dispose()
	{
		vmethod_0(bool_1: true);
		GC.SuppressFinalize(this);
	}
}
