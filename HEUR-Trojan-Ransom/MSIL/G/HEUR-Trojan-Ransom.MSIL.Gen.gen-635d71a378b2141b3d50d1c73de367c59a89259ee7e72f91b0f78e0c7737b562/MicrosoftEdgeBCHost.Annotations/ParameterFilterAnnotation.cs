using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParameterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceParameter()
	{
	}
}
