using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReaderAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceServer()
	{
	}
}
