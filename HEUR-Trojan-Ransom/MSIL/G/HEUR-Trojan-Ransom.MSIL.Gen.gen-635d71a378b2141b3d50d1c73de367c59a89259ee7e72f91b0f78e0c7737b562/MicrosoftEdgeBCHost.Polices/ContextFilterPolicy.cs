using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ContextFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveIdentifier()
	{
	}
}
