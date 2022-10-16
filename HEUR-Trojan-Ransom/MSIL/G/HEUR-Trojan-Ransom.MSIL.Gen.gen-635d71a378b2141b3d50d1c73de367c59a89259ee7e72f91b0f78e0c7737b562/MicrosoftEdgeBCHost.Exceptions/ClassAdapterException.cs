using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ClassAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceClient()
	{
	}
}
