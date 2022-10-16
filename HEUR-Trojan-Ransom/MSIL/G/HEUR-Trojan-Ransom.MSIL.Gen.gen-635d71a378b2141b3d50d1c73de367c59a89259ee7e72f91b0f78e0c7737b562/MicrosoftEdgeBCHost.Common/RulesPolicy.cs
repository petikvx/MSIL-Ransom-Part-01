using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RulesPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceAnnotation()
	{
	}
}
