using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InstanceFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateRef()
	{
	}
}
