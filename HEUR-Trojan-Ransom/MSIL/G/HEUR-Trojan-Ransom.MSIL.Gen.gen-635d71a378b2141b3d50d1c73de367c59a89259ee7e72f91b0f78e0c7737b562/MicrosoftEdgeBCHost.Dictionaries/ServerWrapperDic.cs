using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ServerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartDescriptor()
	{
	}
}
