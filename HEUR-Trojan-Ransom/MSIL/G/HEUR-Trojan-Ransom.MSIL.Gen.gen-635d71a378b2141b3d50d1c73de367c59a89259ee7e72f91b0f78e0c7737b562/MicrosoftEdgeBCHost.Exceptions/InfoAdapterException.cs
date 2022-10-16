using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InfoAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceThread()
	{
	}
}
