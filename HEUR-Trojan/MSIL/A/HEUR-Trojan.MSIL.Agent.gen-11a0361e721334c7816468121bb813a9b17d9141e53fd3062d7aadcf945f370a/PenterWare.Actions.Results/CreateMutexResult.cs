namespace PenterWare.Actions.Results;

internal class CreateMutexResult : ActionResult
{
	public string MutexName { get; set; }

	public bool Created { get; set; }
}
