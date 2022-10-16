using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PageWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceAnnotation()
	{
	}
}
