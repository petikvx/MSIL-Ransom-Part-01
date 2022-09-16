using System.Reflection;
using System.Threading;

internal sealed class Class3
{
	internal Assembly method_0()
	{
		return Thread.GetDomain().Load(Class2.smethod_1());
	}
}
