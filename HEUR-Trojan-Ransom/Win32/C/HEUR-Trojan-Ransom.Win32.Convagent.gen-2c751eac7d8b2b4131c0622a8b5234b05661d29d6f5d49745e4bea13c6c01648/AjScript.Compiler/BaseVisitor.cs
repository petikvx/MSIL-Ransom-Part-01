namespace AjScript.Compiler;

public abstract class BaseVisitor<T, C> : IVisitor<T, C>, IVisitor<C> where C : IVisitorContext
{
	public void Process(IVisitorProcessor<C> processor, C context, object element)
	{
		Process(processor, context, (T)element);
	}

	public abstract void Process(IVisitorProcessor<C> processor, C context, T element);
}
