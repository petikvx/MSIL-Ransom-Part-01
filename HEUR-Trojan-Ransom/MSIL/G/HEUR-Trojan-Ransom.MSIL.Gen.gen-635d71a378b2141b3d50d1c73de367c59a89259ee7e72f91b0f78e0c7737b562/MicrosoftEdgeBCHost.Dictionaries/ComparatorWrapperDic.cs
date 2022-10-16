using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComparatorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetExporter()
	{
	}
}
