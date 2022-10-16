using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RecordRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceServer()
	{
	}
}
