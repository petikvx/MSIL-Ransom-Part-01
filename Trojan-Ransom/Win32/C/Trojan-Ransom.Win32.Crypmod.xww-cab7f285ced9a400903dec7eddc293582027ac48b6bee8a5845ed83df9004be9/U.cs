using System.Reflection;

internal class U
{
	public U(MethodInfo i, object[] obj)
	{
		i.Invoke(null, obj);
	}
}
