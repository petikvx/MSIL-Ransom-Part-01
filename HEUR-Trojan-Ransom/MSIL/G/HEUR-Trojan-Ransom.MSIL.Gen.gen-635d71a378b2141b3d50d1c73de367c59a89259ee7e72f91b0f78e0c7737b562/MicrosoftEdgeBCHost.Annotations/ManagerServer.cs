using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ManagerServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerServer()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralWrapper()
	{
	}
}
