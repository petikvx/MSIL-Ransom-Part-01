using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConfigWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigWorker()
	{
		WriterPropertyProducer.ResolveStub();
		MapInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapInvocation()
	{
	}
}
