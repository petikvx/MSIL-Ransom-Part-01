using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AdapterRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterRules()
	{
		WriterPropertyProducer.ResolveStub();
		CalcConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcConfiguration()
	{
	}
}
