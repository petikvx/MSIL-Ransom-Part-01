using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerContext()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceWrapper()
	{
	}
}
