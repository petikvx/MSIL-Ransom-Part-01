using System;
using System.IO;
using AjScript.Language;

namespace AjScript.Primitives;

public class WriteLineFunction : ICallable
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

	public WriteLineFunction()
		: this(Console.Out)
	{
	}

	public WriteLineFunction(TextWriter writer)
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
		writer.WriteLine();
		return null;
	}
}
