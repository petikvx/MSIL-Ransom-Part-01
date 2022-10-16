using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RuleFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceList()
	{
	}
}
