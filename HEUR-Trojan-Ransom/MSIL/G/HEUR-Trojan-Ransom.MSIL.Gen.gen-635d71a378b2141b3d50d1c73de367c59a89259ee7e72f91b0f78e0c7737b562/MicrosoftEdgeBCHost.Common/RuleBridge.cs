using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleBridge()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyResolver()
	{
	}
}
