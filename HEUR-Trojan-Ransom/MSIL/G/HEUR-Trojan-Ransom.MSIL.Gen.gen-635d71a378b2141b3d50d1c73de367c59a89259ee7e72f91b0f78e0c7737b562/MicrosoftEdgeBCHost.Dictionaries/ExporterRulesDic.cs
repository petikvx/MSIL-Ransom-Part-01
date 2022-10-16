using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceReponse()
	{
	}
}
