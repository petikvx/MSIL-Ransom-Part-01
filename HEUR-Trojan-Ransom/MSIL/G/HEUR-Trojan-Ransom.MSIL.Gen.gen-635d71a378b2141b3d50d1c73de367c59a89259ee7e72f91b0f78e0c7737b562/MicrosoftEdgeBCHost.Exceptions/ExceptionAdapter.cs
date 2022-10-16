using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExceptionAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceConnection()
	{
	}
}
