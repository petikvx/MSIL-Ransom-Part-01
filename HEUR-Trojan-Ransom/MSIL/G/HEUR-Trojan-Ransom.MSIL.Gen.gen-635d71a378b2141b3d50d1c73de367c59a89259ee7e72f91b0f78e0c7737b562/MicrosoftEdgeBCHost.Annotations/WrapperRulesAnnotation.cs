using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterRecord()
	{
	}
}
