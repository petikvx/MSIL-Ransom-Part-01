using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenVal()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeWrapper()
	{
	}
}
