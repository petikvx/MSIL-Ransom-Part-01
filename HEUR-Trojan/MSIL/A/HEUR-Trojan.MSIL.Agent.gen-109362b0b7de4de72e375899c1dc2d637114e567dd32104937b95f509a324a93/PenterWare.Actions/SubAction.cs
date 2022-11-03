using PenterWare.Actions.Results;

namespace PenterWare.Actions;

public abstract class SubAction<T> : BaseAction<T> where T : ActionResult, new()
{
	public override T RunAction()
	{
		base.Result = base.RunAction();
		return base.Result;
	}
}
