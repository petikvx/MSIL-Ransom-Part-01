namespace AjScript.Compiler;

public interface IVisitorProcessor<C> where C : IVisitorContext
{
	void Process(C context, object element);
}
