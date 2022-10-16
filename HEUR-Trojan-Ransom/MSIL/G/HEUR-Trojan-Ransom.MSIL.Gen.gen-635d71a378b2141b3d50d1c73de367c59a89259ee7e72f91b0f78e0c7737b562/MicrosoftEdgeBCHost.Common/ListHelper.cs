using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralFilter()
	{
	}
}
