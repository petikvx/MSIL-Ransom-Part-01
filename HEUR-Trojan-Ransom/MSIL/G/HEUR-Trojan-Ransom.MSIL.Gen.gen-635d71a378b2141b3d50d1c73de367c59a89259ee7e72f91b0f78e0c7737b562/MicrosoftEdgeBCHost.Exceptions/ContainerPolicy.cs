using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContainerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContainerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceAdvisor()
	{
	}
}
