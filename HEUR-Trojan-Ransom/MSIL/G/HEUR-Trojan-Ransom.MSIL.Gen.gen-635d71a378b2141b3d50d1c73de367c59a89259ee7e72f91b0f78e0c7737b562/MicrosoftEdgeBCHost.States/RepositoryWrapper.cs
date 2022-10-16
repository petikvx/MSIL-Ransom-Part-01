using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RepositoryWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareTest()
	{
	}
}
