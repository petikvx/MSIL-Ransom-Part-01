using System;
using System.Collections.Generic;
using System.Globalization;
using ns10;

namespace ns2;

internal class Class44<T, U>
{
	private readonly IDictionary<T, U> idictionary_0;

	private readonly IDictionary<U, T> idictionary_1;

	private readonly string string_0;

	private readonly string string_1;

	public Class44()
		: this((IEqualityComparer<T>)EqualityComparer<T>.Default, (IEqualityComparer<U>)EqualityComparer<U>.Default)
	{
	}

	public Class44(IEqualityComparer<T> iequalityComparer_0, IEqualityComparer<U> iequalityComparer_1)
		: this(iequalityComparer_0, iequalityComparer_1, "Duplicate item already exists for '{0}'.", "Duplicate item already exists for '{0}'.")
	{
	}

	public Class44(IEqualityComparer<T> iequalityComparer_0, IEqualityComparer<U> iequalityComparer_1, string string_2, string string_3)
	{
		idictionary_0 = new Dictionary<T, U>(iequalityComparer_0);
		idictionary_1 = new Dictionary<U, T>(iequalityComparer_1);
		string_0 = string_2;
		string_1 = string_3;
	}

	public void method_0(T gparam_0, U gparam_1)
	{
		if (idictionary_0.TryGetValue(gparam_0, out var value) && !value.Equals(gparam_1))
		{
			throw new ArgumentException(string_0.smethod_1(CultureInfo.InvariantCulture, gparam_0));
		}
		if (idictionary_1.TryGetValue(gparam_1, out var value2) && !value2.Equals(gparam_0))
		{
			throw new ArgumentException(string_1.smethod_1(CultureInfo.InvariantCulture, gparam_1));
		}
		idictionary_0.Add(gparam_0, gparam_1);
		idictionary_1.Add(gparam_1, gparam_0);
	}

	public bool method_1(T gparam_0, out U gparam_1)
	{
		return idictionary_0.TryGetValue(gparam_0, out gparam_1);
	}

	public bool method_2(U gparam_0, out T gparam_1)
	{
		return idictionary_1.TryGetValue(gparam_0, out gparam_1);
	}
}
