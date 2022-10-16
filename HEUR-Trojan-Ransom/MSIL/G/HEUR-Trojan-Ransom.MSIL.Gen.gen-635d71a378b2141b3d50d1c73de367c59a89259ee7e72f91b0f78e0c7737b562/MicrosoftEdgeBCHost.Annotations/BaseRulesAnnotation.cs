using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BaseRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		QueryProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryProcess()
	{
	}
}
