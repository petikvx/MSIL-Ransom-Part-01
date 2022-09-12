namespace AjScript.Language;

public interface IFunction : ICallable, IObject
{
	object NewInstance(object[] parameters);
}
