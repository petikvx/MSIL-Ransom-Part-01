using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PolicyFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicyFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PublishIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishIdentifier()
	{
	}
}
