using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class IssuerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceReader()
	{
	}
}
