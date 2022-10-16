using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MappingSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralAttribute()
	{
	}
}
