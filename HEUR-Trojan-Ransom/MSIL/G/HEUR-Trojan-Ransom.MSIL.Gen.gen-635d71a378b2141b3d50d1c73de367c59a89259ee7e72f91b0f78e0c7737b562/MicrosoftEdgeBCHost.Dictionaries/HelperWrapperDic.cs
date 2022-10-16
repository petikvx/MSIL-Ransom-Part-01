using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class HelperWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginImporter()
	{
	}
}
