using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class UtilsAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceMock()
	{
	}
}
