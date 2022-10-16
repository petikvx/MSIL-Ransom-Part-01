using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContextAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralProperty()
	{
	}
}
