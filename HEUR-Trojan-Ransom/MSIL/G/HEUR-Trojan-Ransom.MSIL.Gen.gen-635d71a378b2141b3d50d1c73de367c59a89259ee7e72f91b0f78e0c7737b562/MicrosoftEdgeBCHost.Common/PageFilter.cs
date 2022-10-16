using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PageFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveClient()
	{
	}
}
