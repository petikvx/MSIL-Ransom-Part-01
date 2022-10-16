using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RuleValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceWorker()
	{
	}
}
