using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace HtmlAgilityPack;

internal static class Tools
{
	internal delegate TResult HAPFunc<T, TResult>(T arg);

	internal static bool IsDefinedAttribute(this Type type, Type attributeType)
	{
		if (type == null)
		{
			throw new ArgumentNullException("Parameter type is null when checking type defined attributeType or not.");
		}
		if (attributeType == null)
		{
			throw new ArgumentNullException("Parameter attributeType is null when checking type defined attributeType or not.");
		}
		if (type.IsDefined(attributeType, inherit: false))
		{
			return true;
		}
		return false;
	}

	internal static IEnumerable<PropertyInfo> GetPropertiesDefinedXPath(this Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("Parameter type is null while retrieving properties defined XPathAttribute of Type type.");
		}
		return type.GetProperties().HAPWhere((PropertyInfo x) => x.IsDefined(typeof(XPathAttribute), inherit: false));
	}

	internal static bool IsIEnumerable(this PropertyInfo propertyInfo)
	{
		if (propertyInfo == null)
		{
			throw new ArgumentNullException("Parameter propertyInfo is null while checking propertyInfo for being IEnumerable or not.");
		}
		if (propertyInfo.PropertyType == typeof(string))
		{
			return false;
		}
		return typeof(IEnumerable).IsAssignableFrom(propertyInfo.PropertyType);
	}

	internal static IEnumerable<Type> GetGenericTypes(this PropertyInfo propertyInfo)
	{
		if (propertyInfo == null)
		{
			throw new ArgumentNullException("Parameter propertyInfo is null while Getting generic types of Property.");
		}
		return propertyInfo.PropertyType.GetGenericArguments();
	}

	internal static MethodInfo GetMethodByItsName(this Type type, string methodName)
	{
		if (type == null)
		{
			throw new ArgumentNullException("Parameter type is null while Getting method from it.");
		}
		if (methodName == null || methodName == "")
		{
			throw new ArgumentNullException("Parameter methodName is null while Getting method from Type type.");
		}
		return type.GetMethod(methodName);
	}

	internal static IList CreateIListOfType(this Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("Parameter type is null while creating List<type>.");
		}
		return Activator.CreateInstance(typeof(List<>).MakeGenericType(type)) as IList;
	}

	internal static T GetNodeValueBasedOnXPathReturnType<T>(HtmlNode htmlNode, XPathAttribute xPathAttribute)
	{
		if (htmlNode == null)
		{
			throw new ArgumentNullException("parameter html node is null");
		}
		if (xPathAttribute == null)
		{
			throw new ArgumentNullException("parameter xpathAttribute is null");
		}
		Type typeFromHandle = typeof(T);
		return (T)(xPathAttribute.NodeReturnType switch
		{
			ReturnType.InnerText => Convert.ChangeType(htmlNode.InnerText, typeFromHandle), 
			ReturnType.InnerHtml => Convert.ChangeType(htmlNode.InnerHtml, typeFromHandle), 
			ReturnType.OuterHtml => Convert.ChangeType(htmlNode.OuterHtml, typeFromHandle), 
			_ => throw new Exception(), 
		});
	}

	internal static IList GetNodesValuesBasedOnXPathReturnType(HtmlNodeCollection htmlNodeCollection, XPathAttribute xPathAttribute, Type listGenericType)
	{
		if (htmlNodeCollection != null && htmlNodeCollection.Count != 0)
		{
			if (xPathAttribute == null)
			{
				throw new ArgumentNullException("parameter xpathAttribute is null");
			}
			IList list = listGenericType.CreateIListOfType();
			switch (xPathAttribute.NodeReturnType)
			{
			case ReturnType.InnerText:
			{
				foreach (HtmlNode item in (IEnumerable<HtmlNode>)htmlNodeCollection)
				{
					list.Add(Convert.ChangeType(item.InnerText, listGenericType));
				}
				return list;
			}
			case ReturnType.InnerHtml:
			{
				foreach (HtmlNode item2 in (IEnumerable<HtmlNode>)htmlNodeCollection)
				{
					list.Add(Convert.ChangeType(item2.InnerHtml, listGenericType));
				}
				return list;
			}
			case ReturnType.OuterHtml:
			{
				foreach (HtmlNode item3 in (IEnumerable<HtmlNode>)htmlNodeCollection)
				{
					list.Add(Convert.ChangeType(item3.OuterHtml, listGenericType));
				}
				return list;
			}
			default:
				return list;
			}
		}
		throw new ArgumentNullException("parameter htmlNodeCollection is null or empty.");
	}

	internal static IEnumerable<TSource> HAPWhere<TSource>(this IEnumerable<TSource> source, HAPFunc<TSource, bool> predicate)
	{
		foreach (TSource item in source)
		{
			if (predicate(item))
			{
				yield return item;
			}
		}
	}

	internal static bool IsInstantiable(this Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type is null");
		}
		if (type.GetConstructor(Type.EmptyTypes) == null)
		{
			return false;
		}
		return true;
	}

	internal static int CountOfIEnumerable<T>(this IEnumerable<T> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("Parameter source is null while counting the IEnumerable");
		}
		int num = 0;
		foreach (T item in source)
		{
			_ = item;
			num++;
		}
		return num;
	}
}
