using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceAttribute()
	{
	}
}
