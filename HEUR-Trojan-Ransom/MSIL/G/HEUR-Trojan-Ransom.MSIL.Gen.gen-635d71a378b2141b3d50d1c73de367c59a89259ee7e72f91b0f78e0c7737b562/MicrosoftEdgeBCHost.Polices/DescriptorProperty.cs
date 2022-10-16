using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class DescriptorProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorProperty()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceService()
	{
	}
}
