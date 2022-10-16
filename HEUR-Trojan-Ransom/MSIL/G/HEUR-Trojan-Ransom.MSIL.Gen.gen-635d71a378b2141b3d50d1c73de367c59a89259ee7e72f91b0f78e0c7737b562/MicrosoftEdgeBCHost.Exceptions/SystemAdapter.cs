using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SystemAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceError()
	{
	}
}
