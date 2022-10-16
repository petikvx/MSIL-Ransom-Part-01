using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InstanceOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralBase()
	{
	}
}
