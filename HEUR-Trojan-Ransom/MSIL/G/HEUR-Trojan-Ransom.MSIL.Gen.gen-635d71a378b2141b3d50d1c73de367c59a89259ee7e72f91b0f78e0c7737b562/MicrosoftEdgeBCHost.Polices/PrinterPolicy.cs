using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PrinterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrinterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceAdvisor()
	{
	}
}
