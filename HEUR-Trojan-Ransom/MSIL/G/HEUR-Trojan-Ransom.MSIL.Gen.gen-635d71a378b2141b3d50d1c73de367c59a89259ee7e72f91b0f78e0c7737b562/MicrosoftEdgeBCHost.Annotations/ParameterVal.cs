using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParameterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterVal()
	{
		WriterPropertyProducer.ResolveStub();
		CallAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallAnnotation()
	{
	}
}
