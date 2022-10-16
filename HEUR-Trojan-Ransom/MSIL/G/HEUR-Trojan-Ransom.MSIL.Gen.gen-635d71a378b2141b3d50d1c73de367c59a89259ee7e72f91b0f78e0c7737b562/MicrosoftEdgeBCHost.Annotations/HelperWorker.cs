using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class HelperWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CollectDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectDatabase()
	{
	}
}
