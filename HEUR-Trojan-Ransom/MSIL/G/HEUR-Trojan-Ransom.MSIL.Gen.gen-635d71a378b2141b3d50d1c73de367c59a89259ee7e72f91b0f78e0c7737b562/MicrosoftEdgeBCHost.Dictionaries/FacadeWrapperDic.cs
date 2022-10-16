using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateImporter()
	{
	}
}
