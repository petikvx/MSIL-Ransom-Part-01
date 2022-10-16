using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceRule()
	{
	}
}
