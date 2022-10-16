using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PrototypeAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceInvocation()
	{
	}
}
