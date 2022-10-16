using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceFilter()
	{
	}
}
