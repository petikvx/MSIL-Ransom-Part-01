using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TokenFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenFilter()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveConfig()
	{
	}
}
