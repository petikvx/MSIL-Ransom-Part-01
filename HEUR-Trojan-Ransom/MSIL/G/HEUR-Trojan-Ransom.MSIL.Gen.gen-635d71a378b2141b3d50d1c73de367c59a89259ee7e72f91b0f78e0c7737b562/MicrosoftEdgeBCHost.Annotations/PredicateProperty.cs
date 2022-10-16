using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PredicateProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateProperty()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceRole()
	{
	}
}
