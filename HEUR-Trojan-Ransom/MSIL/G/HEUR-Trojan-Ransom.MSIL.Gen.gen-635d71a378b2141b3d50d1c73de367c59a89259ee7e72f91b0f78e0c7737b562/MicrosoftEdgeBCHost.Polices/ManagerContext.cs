using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ManagerContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerContext()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceSpecification()
	{
	}
}
