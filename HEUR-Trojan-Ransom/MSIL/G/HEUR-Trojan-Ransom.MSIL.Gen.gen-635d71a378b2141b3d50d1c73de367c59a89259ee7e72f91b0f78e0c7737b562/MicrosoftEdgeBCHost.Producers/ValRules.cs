using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ValRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValRules()
	{
		WriterPropertyProducer.ResolveStub();
		RevertMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertMessage()
	{
	}
}
