using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConnectionWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWorker()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveDatabase()
	{
	}
}
