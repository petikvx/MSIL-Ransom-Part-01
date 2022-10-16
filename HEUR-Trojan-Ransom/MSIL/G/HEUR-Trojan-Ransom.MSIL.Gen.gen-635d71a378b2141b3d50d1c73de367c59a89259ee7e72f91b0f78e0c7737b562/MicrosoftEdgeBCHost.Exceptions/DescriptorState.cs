using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DescriptorState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorState()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceInitializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceInitializer()
	{
	}
}
