using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace xbot_wpf.Extensions;

public static class BaseClassExtensions
{
	public static TDerived ToDerived<TBase, TDerived>(this TBase tBase) where TDerived : TBase, new()
	{
		TDerived val = new TDerived();
		PropertyInfo[] properties = typeof(TBase).GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			typeof(TDerived).GetProperty(propertyInfo.Name)!.SetValue(val, propertyInfo.GetValue(tBase, null), null);
		}
		return val;
	}

	public static TDestination Transform<TDestination>(this object obj) where TDestination : new()
	{
		TDestination val = new TDestination();
		PropertyInfo[] properties = typeof(TDestination).GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			PropertyInfo property = obj.GetType().GetProperty(propertyInfo.Name);
			if (property != null)
			{
				if (propertyInfo.Name == "MaxOrderThreshold")
				{
					propertyInfo.SetValue(val, property.GetValue(obj.ToString(), null), null);
				}
				else
				{
					propertyInfo.SetValue(val, property.GetValue(obj, null), null);
				}
			}
		}
		return val;
	}

	public static IList<TDestination> Transform<TSource, TDestination>(this IList<TSource> objs) where TSource : new()where TDestination : new()
	{
		return objs.Select((TSource obj) => obj.Transform<TDestination>()).ToList();
	}

	public static TDestination Clone<TDestination>(this TDestination obj) where TDestination : new()
	{
		TDestination val = new TDestination();
		PropertyInfo[] properties = typeof(TDestination).GetProperties();
		foreach (PropertyInfo propertyInfo in properties)
		{
			PropertyInfo property = obj.GetType().GetProperty(propertyInfo.Name);
			if (property != null)
			{
				propertyInfo.SetValue(val, property.GetValue(obj, null), null);
			}
		}
		return val;
	}
}
