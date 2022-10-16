using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceAdapter()
	{
	}
}
