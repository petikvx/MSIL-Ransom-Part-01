using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Microsoft.Build.Shared;

internal class TypeLoader
{
	private Dictionary<AssemblyLoadInfo, List<Type>> cacheOfAllDesiredTypesInAnAssembly = new Dictionary<AssemblyLoadInfo, List<Type>>();

	private TypeFilter isDesiredType;

	internal TypeLoader(TypeFilter isDesiredType)
	{
		ErrorUtilities.VerifyThrow(isDesiredType != null, "need a type filter");
		this.isDesiredType = isDesiredType;
	}

	internal LoadedType Load(string typeName, AssemblyLoadInfo assembly)
	{
		Type type = null;
		List<Type> value = null;
		cacheOfAllDesiredTypesInAnAssembly.TryGetValue(assembly, out value);
		if (assembly.AssemblyName != null && typeName.Length > 0 && value == null)
		{
			try
			{
				type = Type.GetType(typeName + "," + assembly.AssemblyName, throwOnError: false, ignoreCase: true);
			}
			catch (ArgumentException)
			{
			}
		}
		if ((object)type != null)
		{
			if (!isDesiredType(type, null))
			{
				return null;
			}
		}
		else
		{
			if (value == null)
			{
				Assembly assembly2;
				try
				{
					assembly2 = ((assembly.AssemblyName == null) ? Assembly.LoadFrom(assembly.AssemblyFile) : Assembly.Load(assembly.AssemblyName));
				}
				catch (ArgumentException innerException)
				{
					throw new FileNotFoundException(null, assembly.ToString(), innerException);
				}
				Type[] exportedTypes = assembly2.GetExportedTypes();
				value = new List<Type>();
				Type[] array = exportedTypes;
				foreach (Type type2 in array)
				{
					if (isDesiredType(type2, null))
					{
						value.Add(type2);
					}
				}
				cacheOfAllDesiredTypesInAnAssembly[assembly] = value;
			}
			foreach (Type item in value)
			{
				if (typeName.Length == 0 || IsPartialTypeNameMatch(item.FullName, typeName))
				{
					type = item;
					break;
				}
			}
		}
		if ((object)type != null)
		{
			return new LoadedType(type, assembly);
		}
		return null;
	}

	internal static bool IsPartialTypeNameMatch(string typeName1, string typeName2)
	{
		bool result = false;
		if (typeName1.Length != typeName2.Length)
		{
			string text;
			string text2;
			if (typeName1.Length > typeName2.Length)
			{
				text = typeName1;
				text2 = typeName2;
			}
			else
			{
				text = typeName2;
				text2 = typeName1;
			}
			if (text.EndsWith(text2, StringComparison.OrdinalIgnoreCase))
			{
				int num = text.Length - text2.Length;
				if (text[num - 1] == '.' || text[num - 1] == '+')
				{
					int num2 = 0;
					int num3 = num - 2;
					while (num3 >= 0 && text[num3] == '\\')
					{
						num2++;
						num3--;
					}
					if (num2 % 2 == 0)
					{
						result = true;
					}
				}
			}
		}
		else
		{
			result = string.Compare(typeName1, typeName2, StringComparison.OrdinalIgnoreCase) == 0;
		}
		return result;
	}
}
