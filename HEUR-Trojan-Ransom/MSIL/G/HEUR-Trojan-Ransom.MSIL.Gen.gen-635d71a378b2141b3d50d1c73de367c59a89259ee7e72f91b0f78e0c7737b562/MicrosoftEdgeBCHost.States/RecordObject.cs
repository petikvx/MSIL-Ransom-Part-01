using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RecordObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordObject()
	{
		WriterPropertyProducer.ResolveStub();
		DisableLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableLiteralSchema()
	{
	}
}
