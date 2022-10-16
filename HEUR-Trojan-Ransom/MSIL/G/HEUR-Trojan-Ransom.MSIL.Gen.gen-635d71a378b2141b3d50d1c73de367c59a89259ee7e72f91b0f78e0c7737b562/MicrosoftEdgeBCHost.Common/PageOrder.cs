using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PageOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageOrder()
	{
		WriterPropertyProducer.ResolveStub();
		FillBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillBase()
	{
	}
}
