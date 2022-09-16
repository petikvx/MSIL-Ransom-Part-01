using System;
using System.Threading.Tasks;
using Rhachide7;

namespace Auntlie6;

public static class Hypox2c
{
	public static Rhachide7.En0rgids<T> smethod_0<T>(Func<Task<T>> Det4ches)
	{
		return new Rhachide7.En0rgids<T>(Det4ches);
	}

	public static Rhachide7.En0rgids<T> Motionle11ne11<T>(Func<T> func_0)
	{
		return new Rhachide7.En0rgids<T>(() => Task.Run(func_0));
	}

	public static Rhachide7.En0rgids<T> Re2iremen2s<T>(Lazy<Task<T>> Eff3ses)
	{
		return new Rhachide7.En0rgids<T>(Eff3ses);
	}

	public static Rhachide7.En0rgids<T> C2gn2vit<T>(T gparam_0)
	{
		return new Rhachide7.En0rgids<T>(() => Task.FromResult(gparam_0));
	}
}
