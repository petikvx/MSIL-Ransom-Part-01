using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceRepository()
	{
	}
}
