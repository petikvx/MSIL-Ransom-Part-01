using System;
using System.IO;
using AjScript.Language;

namespace AjScript.Primitives;

public class WriteFunction : ICallable
{
	private TextWriter writer;

	public int Arity => 1;

	public IContext Context
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public WriteFunction()
		: this(Console.Out)
	{
	}

	public WriteFunction(TextWriter writer)
	{
		this.writer = writer;
	}

	public object Invoke(IContext context, object @this, object[] arguments)
	{
		if (arguments != null)
		{
			foreach (object value in arguments)
			{
				writer.Write(value);
			}
		}
		return null;
	}
}
