using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SetterFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralProccesor()
	{
	}
}
