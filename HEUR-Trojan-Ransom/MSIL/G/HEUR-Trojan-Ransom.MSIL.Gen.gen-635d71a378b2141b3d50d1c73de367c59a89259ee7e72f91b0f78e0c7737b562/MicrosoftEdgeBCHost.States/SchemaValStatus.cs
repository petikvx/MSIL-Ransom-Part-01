using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SchemaValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralProperty()
	{
	}
}
