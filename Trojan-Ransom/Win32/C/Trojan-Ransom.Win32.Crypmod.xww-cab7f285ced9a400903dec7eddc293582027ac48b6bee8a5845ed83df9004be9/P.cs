using System.Reflection;

internal class P
{
	private Assembly y;

	public P(Assembly t)
	{
		y = t;
	}

	public MethodInfo get()
	{
		return y.GetTypes()[0].GetMethods()[0];
	}
}
