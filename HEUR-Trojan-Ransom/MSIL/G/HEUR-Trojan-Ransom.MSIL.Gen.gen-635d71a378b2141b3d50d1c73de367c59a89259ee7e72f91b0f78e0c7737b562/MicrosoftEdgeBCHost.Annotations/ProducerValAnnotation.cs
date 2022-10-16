using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProducerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceReg()
	{
	}
}
