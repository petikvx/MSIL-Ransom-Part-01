using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class FilterPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralToken()
	{
	}
}
