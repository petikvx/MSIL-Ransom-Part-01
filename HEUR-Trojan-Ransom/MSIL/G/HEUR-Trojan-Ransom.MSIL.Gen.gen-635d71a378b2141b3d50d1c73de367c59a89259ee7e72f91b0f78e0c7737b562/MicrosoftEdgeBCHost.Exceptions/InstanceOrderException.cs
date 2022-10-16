using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InstanceOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceCode()
	{
	}
}
