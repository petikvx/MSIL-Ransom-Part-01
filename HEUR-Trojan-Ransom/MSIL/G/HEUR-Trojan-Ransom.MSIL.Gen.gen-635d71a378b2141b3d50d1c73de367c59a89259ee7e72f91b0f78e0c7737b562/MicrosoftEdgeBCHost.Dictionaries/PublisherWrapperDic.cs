using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PublisherWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		EnableExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableExporter()
	{
	}
}
