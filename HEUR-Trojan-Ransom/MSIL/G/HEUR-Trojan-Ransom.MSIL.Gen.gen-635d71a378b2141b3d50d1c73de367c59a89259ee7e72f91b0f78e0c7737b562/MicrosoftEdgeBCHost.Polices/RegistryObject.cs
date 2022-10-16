using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RegistryObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryObject()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralParameter()
	{
	}
}
