using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InvocationAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceReg()
	{
	}
}
