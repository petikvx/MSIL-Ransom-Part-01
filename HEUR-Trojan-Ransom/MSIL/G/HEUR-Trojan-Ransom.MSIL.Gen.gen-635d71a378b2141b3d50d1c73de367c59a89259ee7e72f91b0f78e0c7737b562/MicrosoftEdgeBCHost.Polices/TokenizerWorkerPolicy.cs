using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenizerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfacePage()
	{
	}
}
