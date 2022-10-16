using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RegistryDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryDic()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralRepository()
	{
	}
}
