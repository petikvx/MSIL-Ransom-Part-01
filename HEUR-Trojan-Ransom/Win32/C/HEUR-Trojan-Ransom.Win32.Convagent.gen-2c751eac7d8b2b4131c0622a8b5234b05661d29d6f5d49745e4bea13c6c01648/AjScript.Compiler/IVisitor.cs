namespace AjScript.Compiler;

public interface IVisitor<C> where C : IVisitorContext
{
	void Process(IVisitorProcessor<C> processor, C context, object element);
}
public interface IVisitor<T, C> : IVisitor<C> where C : IVisitorContext
{
	void Process(IVisitorProcessor<C> processor, C context, T element);
}
