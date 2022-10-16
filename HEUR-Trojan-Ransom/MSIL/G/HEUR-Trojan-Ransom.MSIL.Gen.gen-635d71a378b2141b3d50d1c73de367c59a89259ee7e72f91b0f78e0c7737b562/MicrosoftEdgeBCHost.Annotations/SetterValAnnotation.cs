using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SetterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceSystem()
	{
	}
}
