using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceIdentifier()
	{
	}
}
