using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AlgoUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceParser()
	{
	}
}
