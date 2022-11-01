using PenterWare.Actions.Results;

namespace PenterWare.Actions;

internal interface IAction<out T> where T : ActionResult, new()
{
	T RunAction();
}
