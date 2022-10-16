using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IdentifierValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		ResetPrototype();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetPrototype()
	{
	}
}
