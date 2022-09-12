namespace AjScript.Language;

public interface ICallable
{
	int Arity { get; }

	IContext Context { get; }

	object Invoke(IContext context, object @this, object[] arguments);
}
