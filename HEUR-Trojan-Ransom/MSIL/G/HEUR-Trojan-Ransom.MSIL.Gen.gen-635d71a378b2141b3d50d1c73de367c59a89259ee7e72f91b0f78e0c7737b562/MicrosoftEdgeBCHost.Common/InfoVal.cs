using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InfoVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoVal()
	{
		WriterPropertyProducer.ResolveStub();
		FlushProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushProducer()
	{
	}
}
