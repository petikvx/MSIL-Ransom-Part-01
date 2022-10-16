using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DefinitionFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceAnnotation()
	{
	}
}
