using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DescriptorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralReader()
	{
	}
}
