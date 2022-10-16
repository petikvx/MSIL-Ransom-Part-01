using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalObject()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralOrder();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralOrder()
	{
	}
}
