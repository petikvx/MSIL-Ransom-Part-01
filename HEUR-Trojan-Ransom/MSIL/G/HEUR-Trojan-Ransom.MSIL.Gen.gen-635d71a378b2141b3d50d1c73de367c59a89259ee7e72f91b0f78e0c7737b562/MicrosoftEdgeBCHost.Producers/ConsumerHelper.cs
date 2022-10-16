using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConsumerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralWriter()
	{
	}
}
