using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RepositoryWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeParameter()
	{
	}
}
