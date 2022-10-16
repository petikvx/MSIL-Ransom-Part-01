using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InstanceValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralWatcher()
	{
	}
}
