using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ReponseGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceSchema()
	{
	}
}
