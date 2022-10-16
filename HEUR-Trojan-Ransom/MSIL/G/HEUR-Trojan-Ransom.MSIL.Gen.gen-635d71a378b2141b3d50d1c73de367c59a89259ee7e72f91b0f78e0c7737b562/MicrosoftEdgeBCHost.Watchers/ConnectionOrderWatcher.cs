using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConnectionOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralRecord()
	{
	}
}
