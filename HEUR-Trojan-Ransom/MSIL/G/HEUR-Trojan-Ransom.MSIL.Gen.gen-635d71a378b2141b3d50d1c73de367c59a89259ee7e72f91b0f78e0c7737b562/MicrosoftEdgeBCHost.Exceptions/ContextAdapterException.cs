using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ContextAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceIterator()
	{
	}
}
