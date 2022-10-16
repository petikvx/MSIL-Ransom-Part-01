using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RulesFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesFacade()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralReg()
	{
	}
}
