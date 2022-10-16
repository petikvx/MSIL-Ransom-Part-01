using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceClient()
	{
	}
}
