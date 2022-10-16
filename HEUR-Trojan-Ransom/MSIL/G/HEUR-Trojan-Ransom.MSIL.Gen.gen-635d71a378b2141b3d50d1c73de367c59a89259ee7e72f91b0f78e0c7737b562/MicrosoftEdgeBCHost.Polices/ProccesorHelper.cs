using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProccesorHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralTokenizer()
	{
	}
}
