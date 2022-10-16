using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralRegistry()
	{
	}
}
