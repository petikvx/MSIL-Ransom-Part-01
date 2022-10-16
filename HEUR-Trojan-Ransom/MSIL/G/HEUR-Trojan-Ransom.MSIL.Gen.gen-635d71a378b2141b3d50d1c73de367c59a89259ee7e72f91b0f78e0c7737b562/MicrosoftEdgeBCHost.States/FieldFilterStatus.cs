using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class FieldFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveInterfaceAdvisor()
	{
	}
}
