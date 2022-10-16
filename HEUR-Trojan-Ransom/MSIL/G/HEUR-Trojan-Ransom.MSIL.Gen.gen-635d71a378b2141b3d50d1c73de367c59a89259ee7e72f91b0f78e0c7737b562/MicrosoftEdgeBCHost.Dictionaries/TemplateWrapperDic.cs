using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TemplateWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveIterator()
	{
	}
}
