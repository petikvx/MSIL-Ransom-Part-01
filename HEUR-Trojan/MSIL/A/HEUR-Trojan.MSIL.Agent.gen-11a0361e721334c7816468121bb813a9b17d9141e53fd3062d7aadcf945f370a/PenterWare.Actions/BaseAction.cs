using PenterWare.Actions.Results;
using PenterWare.Utils;

namespace PenterWare.Actions;

internal abstract class BaseAction<T> : IAction<T> where T : ActionResult, new()
{
	public abstract string ActionName { get; }

	protected T Result { get; set; }

	public virtual T RunAction()
	{
		Result = new T
		{
			ActionName = ActionName
		};
		GeneralUtils.Log("Running action " + ActionName);
		Run();
		Result.Done = true;
		return Result;
	}

	protected abstract void Run();
}
