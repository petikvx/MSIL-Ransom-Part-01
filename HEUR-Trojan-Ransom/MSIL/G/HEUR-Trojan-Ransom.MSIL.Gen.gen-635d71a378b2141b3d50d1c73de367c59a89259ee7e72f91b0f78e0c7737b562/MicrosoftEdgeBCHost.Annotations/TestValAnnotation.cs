using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceInfo()
	{
	}
}
