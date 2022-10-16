using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class UtilsFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsFilter()
	{
		WriterPropertyProducer.ResolveStub();
		FlushPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushPage()
	{
	}
}
