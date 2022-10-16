using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DescriptorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralHelper()
	{
	}
}
