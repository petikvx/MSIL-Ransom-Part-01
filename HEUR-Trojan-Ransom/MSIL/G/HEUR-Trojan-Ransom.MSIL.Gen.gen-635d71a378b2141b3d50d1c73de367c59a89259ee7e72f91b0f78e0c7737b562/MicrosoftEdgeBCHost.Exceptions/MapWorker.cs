using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapWorker()
	{
		WriterPropertyProducer.ResolveStub();
		StartAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartAccount()
	{
	}
}
