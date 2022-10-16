using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SerializerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceIndexer()
	{
	}
}
