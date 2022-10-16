using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeLiteralGetter()
	{
	}
}
