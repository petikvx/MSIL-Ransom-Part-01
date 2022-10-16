using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeClient()
	{
	}
}
