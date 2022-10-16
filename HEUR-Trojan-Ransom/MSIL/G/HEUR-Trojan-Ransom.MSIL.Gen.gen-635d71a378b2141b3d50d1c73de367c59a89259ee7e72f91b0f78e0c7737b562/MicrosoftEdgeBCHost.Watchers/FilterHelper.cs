using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class FilterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralField()
	{
	}
}
