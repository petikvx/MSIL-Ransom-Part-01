using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralMapping()
	{
	}
}
