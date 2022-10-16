using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CodeValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceException()
	{
	}
}
