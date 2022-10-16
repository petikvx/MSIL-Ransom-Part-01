using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObserverFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceConfiguration()
	{
	}
}
