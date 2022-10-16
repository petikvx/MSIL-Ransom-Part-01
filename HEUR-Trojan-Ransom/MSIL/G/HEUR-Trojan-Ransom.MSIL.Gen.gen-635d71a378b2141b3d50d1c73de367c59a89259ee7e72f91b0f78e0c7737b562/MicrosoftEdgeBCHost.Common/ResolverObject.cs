using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ResolverObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverObject()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralConfig()
	{
	}
}
