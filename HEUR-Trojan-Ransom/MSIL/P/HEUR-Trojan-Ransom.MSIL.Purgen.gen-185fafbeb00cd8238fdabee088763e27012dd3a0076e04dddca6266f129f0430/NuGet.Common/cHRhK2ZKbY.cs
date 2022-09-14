using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NuGet.Common;

public abstract class cHRhK2ZKbY : ILogger
{
	public void SsNaXxQXYc(HVe4ZaB2Yt of8TscAKam, string vwvklptUfd)
	{
		switch (of8TscAKam)
		{
		case HVe4ZaB2Yt.Debug:
			eymbEcVhfy(vwvklptUfd);
			break;
		case HVe4ZaB2Yt.Error:
			_1zDJlK8Fuz(vwvklptUfd);
			break;
		case HVe4ZaB2Yt.Information:
			Sg7Fj6r1Q2(vwvklptUfd);
			break;
		case HVe4ZaB2Yt.Minimal:
			CuZ7lh7Y3w(vwvklptUfd);
			break;
		case HVe4ZaB2Yt.Verbose:
			_8oNdLxD4rg(vwvklptUfd);
			break;
		case HVe4ZaB2Yt.Warning:
			azRuervZyF(vwvklptUfd);
			break;
		}
	}

	public Task nHPk54V6gb(HVe4ZaB2Yt no1q131b3a, string zbJnNWnQIc)
	{
		SsNaXxQXYc(no1q131b3a, zbJnNWnQIc);
		return Task.FromResult(0);
	}

	public virtual void _0IjfGpgxBO(ILogMessage gGpEGxOWNw)
	{
		SsNaXxQXYc(gGpEGxOWNw.Level, gGpEGxOWNw.Message);
	}

	[AsyncStateMachine(typeof(_003CLogAsync_003Ed__3))]
	public virtual Task CZuM3zZSeM(ILogMessage _5dbu2BVosl)
	{
		QliwmidwQg stateMachine = default(QliwmidwQg);
		stateMachine.r5P1KOrrzv = this;
		stateMachine.PX6hVoc6gI = _5dbu2BVosl;
		stateMachine.iW4Yo7mKEN = AsyncTaskMethodBuilder.Create();
		stateMachine.cCi3xCwH83 = -1;
		AsyncTaskMethodBuilder iW4Yo7mKEN = stateMachine.iW4Yo7mKEN;
		iW4Yo7mKEN.Start(ref stateMachine);
		return stateMachine.iW4Yo7mKEN.Task;
	}

	public abstract void eymbEcVhfy(string w8q8EnTccC);

	public abstract void _8oNdLxD4rg(string cYymgzHLME);

	public abstract void Sg7Fj6r1Q2(string isl01P0Tl6);

	public abstract void CuZ7lh7Y3w(string _4CzsYUqgEh);

	public abstract void azRuervZyF(string gb0ow7MC3v);

	public abstract void _1zDJlK8Fuz(string fSeVkRIqGp);

	public abstract void zmRBj4SyrG(string W8fgUgwVJ5);
}
