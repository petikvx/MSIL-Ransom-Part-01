namespace Nbuujxdbv.Configurations;

internal class Mapper
{
	private static Mapper CalcContext;

	internal void ResolveProducer()
	{
	}

	internal static bool MapContext()
	{
		return CalcContext == null;
	}

	internal static Mapper AddContext()
	{
		return CalcContext;
	}
}
