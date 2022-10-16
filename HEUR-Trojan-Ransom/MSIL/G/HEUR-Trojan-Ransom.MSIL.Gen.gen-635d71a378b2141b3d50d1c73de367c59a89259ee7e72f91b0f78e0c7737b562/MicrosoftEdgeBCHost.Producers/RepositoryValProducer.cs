using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RepositoryValProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryValProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcClient()
	{
	}
}
