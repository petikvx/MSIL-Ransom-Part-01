using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SystemFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceRecord()
	{
	}
}
