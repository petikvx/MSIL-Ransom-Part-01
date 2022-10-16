using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal sealed class GetterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string[] AddStub(int config_length)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopIssuer()
	{
	}
}
