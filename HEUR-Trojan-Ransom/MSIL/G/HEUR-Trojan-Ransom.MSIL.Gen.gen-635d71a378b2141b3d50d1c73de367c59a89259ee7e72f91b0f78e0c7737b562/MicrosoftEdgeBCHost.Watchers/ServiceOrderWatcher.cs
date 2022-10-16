using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServiceOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralSingleton()
	{
	}
}
