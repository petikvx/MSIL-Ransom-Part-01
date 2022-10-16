using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AccountHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountHelper()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralSerializer()
	{
	}
}
