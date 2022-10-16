using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContainerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceRule()
	{
	}
}
