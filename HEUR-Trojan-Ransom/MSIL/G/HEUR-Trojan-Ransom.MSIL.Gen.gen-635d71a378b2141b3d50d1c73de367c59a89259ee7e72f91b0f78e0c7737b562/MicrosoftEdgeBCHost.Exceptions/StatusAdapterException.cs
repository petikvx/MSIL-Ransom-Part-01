using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StatusAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceInfo()
	{
	}
}
