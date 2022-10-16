using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DescriptorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorObject()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralProduct()
	{
	}
}
