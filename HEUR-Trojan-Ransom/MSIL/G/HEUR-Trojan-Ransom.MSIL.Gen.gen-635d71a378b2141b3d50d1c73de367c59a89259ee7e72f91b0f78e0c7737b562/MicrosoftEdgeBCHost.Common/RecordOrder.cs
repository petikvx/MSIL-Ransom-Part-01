using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RecordOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CalcObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcObserver()
	{
	}
}
