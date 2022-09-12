namespace MySqlX.XDevAPI.Common;

public abstract class TargetedBaseStatement<TTarget, TResult> : BaseStatement<TResult> where TTarget : DatabaseObject where TResult : BaseResult
{
	public TTarget Target { get; private set; }

	public TargetedBaseStatement(TTarget target)
		: base(target.Schema.Session)
	{
		Target = target;
	}
}
