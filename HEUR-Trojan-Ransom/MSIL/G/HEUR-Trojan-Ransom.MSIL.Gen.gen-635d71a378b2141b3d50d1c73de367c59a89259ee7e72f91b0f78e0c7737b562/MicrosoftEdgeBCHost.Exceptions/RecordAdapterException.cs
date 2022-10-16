using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RecordAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceRequest()
	{
	}
}
