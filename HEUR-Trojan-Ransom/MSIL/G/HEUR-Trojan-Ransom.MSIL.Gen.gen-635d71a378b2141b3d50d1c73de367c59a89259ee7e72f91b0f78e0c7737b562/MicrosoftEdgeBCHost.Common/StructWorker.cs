using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StructWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CalcAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcAdvisor()
	{
	}
}
