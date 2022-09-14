using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NuGet.Common;

[CLSCompliant(true)]
public class shrswO5SI5<T>
{
	private readonly Lazy<Task<T>> _6fDNwAIiGj;

	public shrswO5SI5(Func<Task<T>> valueFactory)
	{
		this._inner = new Lazy<Task<T>>(valueFactory);
	}

	public shrswO5SI5(Lazy<Task<T>> inner)
	{
		this._inner = inner;
	}

	public TaskAwaiter<T> _7SoT6u09Cu()
	{
		return this._inner.Value.GetAwaiter();
	}

	public static implicit operator Lazy<Task<T>>(NuGet.Common.shrswO5SI5<T> outer)
	{
		return outer._inner;
	}
}
