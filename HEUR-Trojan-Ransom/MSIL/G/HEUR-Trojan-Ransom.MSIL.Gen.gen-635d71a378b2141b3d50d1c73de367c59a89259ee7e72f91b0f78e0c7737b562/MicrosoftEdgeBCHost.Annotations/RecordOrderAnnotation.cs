using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RecordOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralRegistry()
	{
	}
}
