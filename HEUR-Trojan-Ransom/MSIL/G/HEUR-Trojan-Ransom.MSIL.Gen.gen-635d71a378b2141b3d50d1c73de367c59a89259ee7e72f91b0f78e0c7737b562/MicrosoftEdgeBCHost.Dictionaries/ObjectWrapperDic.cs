using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeDescriptor()
	{
	}
}
