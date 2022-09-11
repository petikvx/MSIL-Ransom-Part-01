using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace Google.Protobuf.Reflection;

internal sealed class DescriptorPool
{
	private struct DescriptorIntPair : IEquatable<DescriptorIntPair>
	{
		private readonly int number;

		private readonly IDescriptor descriptor;

		internal DescriptorIntPair(IDescriptor descriptor, int number)
		{
			this.number = number;
			this.descriptor = descriptor;
		}

		public bool Equals(DescriptorIntPair other)
		{
			if (descriptor == other.descriptor)
			{
				return number == other.number;
			}
			return false;
		}

		public override bool Equals(object obj)
		{
			if (obj is DescriptorIntPair)
			{
				return Equals((DescriptorIntPair)obj);
			}
			return false;
		}

		public override int GetHashCode()
		{
			return descriptor.GetHashCode() * 65535 + number;
		}
	}

	private readonly IDictionary<string, IDescriptor> descriptorsByName = new Dictionary<string, IDescriptor>();

	private readonly IDictionary<DescriptorIntPair, FieldDescriptor> fieldsByNumber = new Dictionary<DescriptorIntPair, FieldDescriptor>();

	private readonly IDictionary<DescriptorIntPair, EnumValueDescriptor> enumValuesByNumber = new Dictionary<DescriptorIntPair, EnumValueDescriptor>();

	private readonly HashSet<FileDescriptor> dependencies;

	private static readonly Regex ValidationRegex;

	[NonSerialized]
	internal static GetString getString_0;

	internal DescriptorPool(FileDescriptor[] dependencyFiles)
	{
		dependencies = new HashSet<FileDescriptor>();
		for (int i = 0; i < dependencyFiles.Length; i++)
		{
			dependencies.Add(dependencyFiles[i]);
			ImportPublicDependencies(dependencyFiles[i]);
		}
		foreach (FileDescriptor fileDescriptor in dependencyFiles)
		{
			AddPackage(fileDescriptor.Package, fileDescriptor);
		}
	}

	private void ImportPublicDependencies(FileDescriptor file)
	{
		foreach (FileDescriptor publicDependency in file.PublicDependencies)
		{
			if (dependencies.Add(publicDependency))
			{
				ImportPublicDependencies(publicDependency);
			}
		}
	}

	internal T FindSymbol<T>(string fullName) where T : class
	{
		descriptorsByName.TryGetValue(fullName, out var value);
		if (value is T result)
		{
			return result;
		}
		foreach (FileDescriptor dependency in dependencies)
		{
			dependency.DescriptorPool.descriptorsByName.TryGetValue(fullName, out value);
			if (value is T result2)
			{
				return result2;
			}
		}
		return null;
	}

	internal void AddPackage(string fullName, FileDescriptor file)
	{
		int num = fullName.LastIndexOf('.');
		string text;
		if (num != -1)
		{
			AddPackage(fullName.Substring(0, num), file);
			text = fullName.Substring(num + 1);
		}
		else
		{
			text = fullName;
		}
		if (descriptorsByName.TryGetValue(fullName, out var value) && !(value is PackageDescriptor))
		{
			throw new DescriptorValidationException(file, getString_0(107411324) + text + getString_0(107474541) + value.File.Name + getString_0(107474452));
		}
		descriptorsByName[fullName] = new PackageDescriptor(text, fullName, file);
	}

	internal void AddSymbol(IDescriptor descriptor)
	{
		ValidateSymbolName(descriptor);
		string fullName = descriptor.FullName;
		if (descriptorsByName.TryGetValue(fullName, out var value))
		{
			int num = fullName.LastIndexOf('.');
			string description = ((descriptor.File != value.File) ? (getString_0(107411324) + fullName + getString_0(107473869) + value.File.Name + getString_0(107474452)) : ((num != -1) ? (getString_0(107411324) + fullName.Substring(num + 1) + getString_0(107473906) + fullName.Substring(0, num) + getString_0(107474452)) : (getString_0(107411324) + fullName + getString_0(107474447))));
			throw new DescriptorValidationException(descriptor, description);
		}
		descriptorsByName[fullName] = descriptor;
	}

	private static void ValidateSymbolName(IDescriptor descriptor)
	{
		if (descriptor.Name == getString_0(107400440))
		{
			throw new DescriptorValidationException(descriptor, getString_0(107473796));
		}
		if (!ValidationRegex.IsMatch(descriptor.Name))
		{
			throw new DescriptorValidationException(descriptor, getString_0(107411324) + descriptor.Name + getString_0(107473807));
		}
	}

	internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number)
	{
		fieldsByNumber.TryGetValue(new DescriptorIntPair(messageDescriptor, number), out var value);
		return value;
	}

	internal EnumValueDescriptor FindEnumValueByNumber(EnumDescriptor enumDescriptor, int number)
	{
		enumValuesByNumber.TryGetValue(new DescriptorIntPair(enumDescriptor, number), out var value);
		return value;
	}

	internal void AddFieldByNumber(FieldDescriptor field)
	{
		DescriptorIntPair key = new DescriptorIntPair(field.ContainingType, field.FieldNumber);
		if (fieldsByNumber.TryGetValue(key, out var value))
		{
			throw new DescriptorValidationException(field, getString_0(107473766) + field.FieldNumber + getString_0(107473745) + field.ContainingType.FullName + getString_0(107473708) + value.Name + getString_0(107474452));
		}
		fieldsByNumber[key] = field;
	}

	internal void AddEnumValueByNumber(EnumValueDescriptor enumValue)
	{
		DescriptorIntPair key = new DescriptorIntPair(enumValue.EnumDescriptor, enumValue.Number);
		if (!enumValuesByNumber.ContainsKey(key))
		{
			enumValuesByNumber[key] = enumValue;
		}
	}

	internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo)
	{
		IDescriptor descriptor;
		if (name.StartsWith(getString_0(107400215)))
		{
			descriptor = FindSymbol<IDescriptor>(name.Substring(1));
		}
		else
		{
			int num = name.IndexOf('.');
			string value = ((num == -1) ? name : name.Substring(0, num));
			StringBuilder stringBuilder = new StringBuilder(relativeTo.FullName);
			while (true)
			{
				int num2 = stringBuilder.ToString().LastIndexOf(getString_0(107400215));
				if (num2 != -1)
				{
					stringBuilder.Length = num2 + 1;
					stringBuilder.Append(value);
					descriptor = FindSymbol<IDescriptor>(stringBuilder.ToString());
					if (descriptor == null)
					{
						stringBuilder.Length = num2;
						continue;
					}
					if (num != -1)
					{
						stringBuilder.Length = num2 + 1;
						stringBuilder.Append(name);
						descriptor = FindSymbol<IDescriptor>(stringBuilder.ToString());
					}
					break;
				}
				descriptor = FindSymbol<IDescriptor>(name);
				break;
			}
		}
		if (descriptor == null)
		{
			throw new DescriptorValidationException(relativeTo, getString_0(107411324) + name + getString_0(107473659));
		}
		return descriptor;
	}

	static DescriptorPool()
	{
		Strings.CreateGetStringDelegate(typeof(DescriptorPool));
		ValidationRegex = new Regex(getString_0(107474146), FrameworkPortability.CompiledRegexWhereAvailable);
	}
}
