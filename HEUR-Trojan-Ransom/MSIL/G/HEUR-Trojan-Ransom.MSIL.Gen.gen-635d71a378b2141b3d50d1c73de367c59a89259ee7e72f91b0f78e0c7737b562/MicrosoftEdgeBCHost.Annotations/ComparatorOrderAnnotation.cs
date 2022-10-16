using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralBase()
	{
	}
}
