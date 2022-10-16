using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceWriter()
	{
	}
}
