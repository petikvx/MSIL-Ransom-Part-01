using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SchemaProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaProperty()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceState()
	{
	}
}
