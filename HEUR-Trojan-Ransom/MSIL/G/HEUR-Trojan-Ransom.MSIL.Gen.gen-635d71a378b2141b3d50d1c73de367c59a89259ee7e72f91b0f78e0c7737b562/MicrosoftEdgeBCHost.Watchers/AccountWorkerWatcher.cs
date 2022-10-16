using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AccountWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralManager()
	{
	}
}
