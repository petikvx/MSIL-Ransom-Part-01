using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParameterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralInitializer()
	{
	}
}
