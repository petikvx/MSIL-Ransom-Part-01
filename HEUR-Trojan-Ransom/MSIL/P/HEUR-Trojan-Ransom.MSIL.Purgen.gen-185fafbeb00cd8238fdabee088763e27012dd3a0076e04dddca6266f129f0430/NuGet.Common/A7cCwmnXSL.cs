using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace NuGet.Common;

public static class A7cCwmnXSL
{
	[CompilerGenerated]
	private sealed class Ml3axcFjNj<T>
	{
		public Func<T> xngfGUDL0E;

		internal Task<T> qD1R0UIMGu()
		{
			return Task.Run(this.valueFactory);
		}
	}

	[CompilerGenerated]
	private sealed class oIwWoETB8o<T>
	{
		public T _3YhcCHvbHJ;

		internal Task<T> il0B63ube1()
		{
			return Task.FromResult(this.innerData);
		}
	}

	public static NuGet.Common.shrswO5SI5<T> tVFGfsibgW<T>(Func<Task<T>> nh93D3clWF)
	{
		return new NuGet.Common.shrswO5SI5<T>(nh93D3clWF);
	}

	public static NuGet.Common.shrswO5SI5<T> WO88te1PYw<T>(Func<T> FAROlR4PE7)
	{
		Ml3axcFjNj<T> ml3axcFjNj = new Ml3axcFjNj<T>();
		ml3axcFjNj.valueFactory = FAROlR4PE7;
		return new NuGet.Common.shrswO5SI5<T>((Func<Task<T>>)ml3axcFjNj._003CNew_003Eb__0);
	}

	public static NuGet.Common.shrswO5SI5<T> BGGdsXrW2C<T>(Lazy<Task<T>> AqKF44OsKb)
	{
		return new NuGet.Common.shrswO5SI5<T>(AqKF44OsKb);
	}

	public static NuGet.Common.shrswO5SI5<T> _9fcphcnraG<T>(T AQyMEneEFI)
	{
		oIwWoETB8o<T> oIwWoETB8o = new oIwWoETB8o<T>();
		oIwWoETB8o.innerData = AQyMEneEFI;
		return new NuGet.Common.shrswO5SI5<T>((Func<Task<T>>)oIwWoETB8o._003CNew_003Eb__0);
	}
}
