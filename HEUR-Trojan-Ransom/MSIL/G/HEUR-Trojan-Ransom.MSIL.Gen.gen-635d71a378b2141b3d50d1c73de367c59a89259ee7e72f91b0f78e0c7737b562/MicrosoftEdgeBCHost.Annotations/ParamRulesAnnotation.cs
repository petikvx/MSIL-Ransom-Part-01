using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetMock()
	{
	}
}
