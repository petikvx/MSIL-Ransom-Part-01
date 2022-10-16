using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObserverValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceTokenizer()
	{
	}
}
