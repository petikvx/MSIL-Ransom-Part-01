using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AccountValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountValDic()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralDatabase()
	{
	}
}
