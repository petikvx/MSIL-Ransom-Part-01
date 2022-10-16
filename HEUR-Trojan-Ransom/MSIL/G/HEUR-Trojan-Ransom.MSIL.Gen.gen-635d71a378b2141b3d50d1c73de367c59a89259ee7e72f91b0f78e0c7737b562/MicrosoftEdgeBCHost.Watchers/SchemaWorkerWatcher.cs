using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SchemaWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatLiteralConnection()
	{
	}
}
