using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class OrderValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeSpecification()
	{
	}
}
