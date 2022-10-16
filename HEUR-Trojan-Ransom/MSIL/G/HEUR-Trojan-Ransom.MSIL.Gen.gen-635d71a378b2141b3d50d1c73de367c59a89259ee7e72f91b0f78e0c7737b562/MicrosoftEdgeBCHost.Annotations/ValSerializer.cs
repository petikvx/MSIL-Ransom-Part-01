using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralGetter()
	{
	}
}
