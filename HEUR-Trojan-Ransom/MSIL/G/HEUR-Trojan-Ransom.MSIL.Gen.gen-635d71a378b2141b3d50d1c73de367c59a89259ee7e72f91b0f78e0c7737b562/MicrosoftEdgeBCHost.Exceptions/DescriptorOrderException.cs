using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DescriptorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceException()
	{
	}
}
