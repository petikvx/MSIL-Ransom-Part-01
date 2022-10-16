using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class VisitorRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceComposer()
	{
	}
}
