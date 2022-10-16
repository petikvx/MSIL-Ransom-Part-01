using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AdapterValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReadSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadSpecification()
	{
	}
}
