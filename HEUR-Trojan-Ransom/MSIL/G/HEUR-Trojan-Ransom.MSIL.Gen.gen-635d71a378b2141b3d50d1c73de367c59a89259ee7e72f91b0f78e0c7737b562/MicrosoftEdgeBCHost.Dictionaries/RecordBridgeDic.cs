using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RecordBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInvocation()
	{
	}
}
