using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProxyAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceUtils()
	{
	}
}
