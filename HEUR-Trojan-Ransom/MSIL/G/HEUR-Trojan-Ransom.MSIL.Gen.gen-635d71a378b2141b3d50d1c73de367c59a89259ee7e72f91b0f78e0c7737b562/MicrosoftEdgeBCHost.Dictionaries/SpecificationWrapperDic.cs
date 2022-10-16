using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SpecificationWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteProxy()
	{
	}
}
