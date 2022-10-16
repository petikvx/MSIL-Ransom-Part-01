using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeBridge()
	{
	}
}
