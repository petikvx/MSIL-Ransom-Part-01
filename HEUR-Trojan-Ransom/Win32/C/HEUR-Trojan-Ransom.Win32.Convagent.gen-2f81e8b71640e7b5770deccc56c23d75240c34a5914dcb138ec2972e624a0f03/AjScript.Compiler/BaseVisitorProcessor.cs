using System;
using System.Collections.Generic;

namespace AjScript.Compiler;

public class BaseVisitorProcessor<C> : IVisitorProcessor<C> where C : IVisitorContext
{
	private IDictionary<Type, IVisitor<C>> visitors = new Dictionary<Type, IVisitor<C>>();

	public void RegisterVisitor(Type type, IVisitor<C> visitor)
	{
		visitors[type] = visitor;
	}

	public void RegisterVisitor<T>(IVisitor<T, C> visitor)
	{
		visitors[typeof(T)] = visitor;
	}

	public void Process(C context, object element)
	{
		visitors[element.GetType()].Process(this, context, element);
	}
}
