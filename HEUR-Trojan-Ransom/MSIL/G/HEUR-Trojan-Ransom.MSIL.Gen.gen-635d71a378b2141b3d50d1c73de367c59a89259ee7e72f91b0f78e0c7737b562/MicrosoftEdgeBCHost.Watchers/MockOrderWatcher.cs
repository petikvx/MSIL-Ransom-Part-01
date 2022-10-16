using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MockOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralTask()
	{
	}
}
