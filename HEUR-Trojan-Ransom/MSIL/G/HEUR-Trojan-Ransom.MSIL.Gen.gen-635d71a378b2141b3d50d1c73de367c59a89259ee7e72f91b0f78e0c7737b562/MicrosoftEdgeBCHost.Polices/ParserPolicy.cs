using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParserPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceSystem()
	{
	}
}
