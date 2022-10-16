using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RulesWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectRepository()
	{
	}
}
