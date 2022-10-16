using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ProccesorOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorOrder()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatBase()
	{
	}
}
