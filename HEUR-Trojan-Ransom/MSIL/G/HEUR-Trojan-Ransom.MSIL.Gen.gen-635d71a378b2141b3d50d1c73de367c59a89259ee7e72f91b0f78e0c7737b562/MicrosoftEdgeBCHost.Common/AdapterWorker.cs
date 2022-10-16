using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdapterWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CalcProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcProcess()
	{
	}
}
