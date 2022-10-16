using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcOrder()
	{
		WriterPropertyProducer.ResolveStub();
		StartProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartProc()
	{
	}
}
