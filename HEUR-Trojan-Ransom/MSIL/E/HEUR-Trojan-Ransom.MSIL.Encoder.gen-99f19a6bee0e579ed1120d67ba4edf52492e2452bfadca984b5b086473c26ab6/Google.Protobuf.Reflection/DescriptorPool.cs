using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

	private static readonly Regex ValidationRegex = new Regex("^[_A-Za-z][_A-Za-z0-9]*$", FrameworkPortability.CompiledRegexWhereAvailable);

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
			throw new DescriptorValidationException(file, "\"" + text + "\" is already defined (as something other than a package) in file \"" + value.File.Name + "\".");
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
			string description = ((descriptor.File != value.File) ? ("\"" + fullName + "\" is already defined in file \"" + value.File.Name + "\".") : ((num != -1) ? ("\"" + fullName.Substring(num + 1) + "\" is already defined in \"" + fullName.Substring(0, num) + "\".") : ("\"" + fullName + "\" is already defined.")));
			throw new DescriptorValidationException(descriptor, description);
		}
		descriptorsByName[fullName] = descriptor;
	}

	private static void ValidateSymbolName(IDescriptor descriptor)
	{
		if (descriptor.Name == "")
		{
			throw new DescriptorValidationException(descriptor, "Missing name.");
		}
		if (!ValidationRegex.IsMatch(descriptor.Name))
		{
			throw new DescriptorValidationException(descriptor, "\"" + descriptor.Name + "\" is not a valid identifier.");
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
			throw new DescriptorValidationException(field, "Field number " + field.FieldNumber + "has already been used in \"" + field.ContainingType.FullName + "\" by field \"" + value.Name + "\".");
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
		if (name.StartsWith("."))
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
				int num2 = stringBuilder.ToString().LastIndexOf(".");
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
			throw new DescriptorValidationException(relativeTo, "\"" + name + "\" is not defined.");
		}
		return descriptor;
	}
}
