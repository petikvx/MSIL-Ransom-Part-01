using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ReponseAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralResolver()
	{
	}
}
