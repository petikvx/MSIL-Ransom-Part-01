using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FactoryWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		VisitExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitExporter()
	{
	}
}
