using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DatabaseWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PostAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostAlgo()
	{
	}
}
