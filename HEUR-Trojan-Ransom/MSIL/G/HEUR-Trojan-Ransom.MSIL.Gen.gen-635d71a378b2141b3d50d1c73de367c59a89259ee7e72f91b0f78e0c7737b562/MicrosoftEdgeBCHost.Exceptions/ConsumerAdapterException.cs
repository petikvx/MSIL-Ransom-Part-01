using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConsumerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceSerializer()
	{
	}
}
