using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AttrObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrObject()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralSchema()
	{
	}
}
