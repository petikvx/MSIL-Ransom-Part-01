using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class WriterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceMapper()
	{
	}
}
