using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParameterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectStruct()
	{
	}
}
