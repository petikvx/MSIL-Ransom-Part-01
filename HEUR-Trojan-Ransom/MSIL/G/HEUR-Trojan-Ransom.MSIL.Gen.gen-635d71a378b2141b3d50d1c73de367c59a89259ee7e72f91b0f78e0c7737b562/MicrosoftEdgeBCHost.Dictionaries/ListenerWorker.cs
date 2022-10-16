using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ListenerWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWorker()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutField()
	{
	}
}
