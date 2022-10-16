using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParameterOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralRepository()
	{
	}
}
