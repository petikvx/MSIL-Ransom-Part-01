using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal sealed class RulesFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object[] DisableStub(int task_Ptr)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotServer()
	{
	}
}
