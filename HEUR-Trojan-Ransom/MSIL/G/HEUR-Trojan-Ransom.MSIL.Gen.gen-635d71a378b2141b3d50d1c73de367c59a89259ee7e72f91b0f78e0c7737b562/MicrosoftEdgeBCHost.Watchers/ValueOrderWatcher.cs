using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValueOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralModel()
	{
	}
}
