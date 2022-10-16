using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SchemaWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceVisitor()
	{
	}
}
