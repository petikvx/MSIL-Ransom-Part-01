using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConnectionWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectAttribute()
	{
	}
}
