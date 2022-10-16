using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamsWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorker()
	{
		WriterPropertyProducer.ResolveStub();
		StopField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopField()
	{
	}
}
