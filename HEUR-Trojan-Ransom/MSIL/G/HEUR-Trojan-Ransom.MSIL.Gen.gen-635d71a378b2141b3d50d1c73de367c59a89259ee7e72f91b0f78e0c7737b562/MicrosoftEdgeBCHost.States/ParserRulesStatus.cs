using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceResolver()
	{
	}
}
