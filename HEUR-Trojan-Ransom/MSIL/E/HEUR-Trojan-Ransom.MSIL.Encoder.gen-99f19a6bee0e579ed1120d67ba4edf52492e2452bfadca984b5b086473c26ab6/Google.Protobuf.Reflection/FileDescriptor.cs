using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Google.Protobuf.WellKnownTypes;

namespace Google.Protobuf.Reflection;

public sealed class FileDescriptor : IDescriptor
{
	internal FileDescriptorProto Proto { get; }

	public string Name => Proto.Name;

	public string Package => Proto.Package;

	public IList<MessageDescriptor> MessageTypes { get; }

	public IList<EnumDescriptor> EnumTypes { get; }

	public IList<ServiceDescriptor> Services { get; }

	public IList<FileDescriptor> Dependencies { get; }

	public IList<FileDescriptor> PublicDependencies { get; }

	public ByteString SerializedData { get; }

	string IDescriptor.FullName => Name;

	FileDescriptor IDescriptor.File => this;

	internal DescriptorPool DescriptorPool { get; }

	public static FileDescriptor DescriptorProtoFileDescriptor => DescriptorReflection.Descriptor;

	public CustomOptions CustomOptions
	{
		get
		{
			FileOptions options = Proto.Options;
			object obj;
			if (options == null)
			{
				obj = null;
			}
			else
			{
				obj = options.CustomOptions;
				if (obj != null)
				{
					goto IL_0020;
				}
			}
			obj = CustomOptions.Empty;
			goto IL_0020;
			IL_0020:
			return (CustomOptions)obj;
		}
	}

	static FileDescriptor()
	{
		ForceReflectionInitialization<Syntax>();
		ForceReflectionInitialization<NullValue>();
		ForceReflectionInitialization<Field.Types.Cardinality>();
		ForceReflectionInitialization<Field.Types.Kind>();
		ForceReflectionInitialization<Value.KindOneofCase>();
	}

	private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
	{
		FileDescriptor file = this;
		SerializedData = descriptorData;
		DescriptorPool = pool;
		Proto = proto;
		Dependencies = new ReadOnlyCollection<FileDescriptor>((FileDescriptor[])dependencies.Clone());
		PublicDependencies = DeterminePublicDependencies(this, proto, dependencies, allowUnknownDependencies);
		pool.AddPackage(Package, this);
		MessageTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.MessageType, (DescriptorProto message, int index) => new MessageDescriptor(message, file, null, index, generatedCodeInfo.NestedTypes[index]));
		EnumTypes = DescriptorUtil.ConvertAndMakeReadOnly(proto.EnumType, (EnumDescriptorProto enumType, int index) => new EnumDescriptor(enumType, file, null, index, generatedCodeInfo.NestedEnums[index]));
		Services = DescriptorUtil.ConvertAndMakeReadOnly(proto.Service, (ServiceDescriptorProto service, int index) => new ServiceDescriptor(service, this, index));
	}

	internal string ComputeFullName(MessageDescriptor parent, string name)
	{
		if (parent != null)
		{
			return parent.FullName + "." + name;
		}
		if (Package.Length > 0)
		{
			return Package + "." + name;
		}
		return name;
	}

	private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies)
	{
		Dictionary<string, FileDescriptor> dictionary = new Dictionary<string, FileDescriptor>();
		foreach (FileDescriptor fileDescriptor in dependencies)
		{
			dictionary[fileDescriptor.Name] = fileDescriptor;
		}
		List<FileDescriptor> list = new List<FileDescriptor>();
		for (int j = 0; j < proto.PublicDependency.Count; j++)
		{
			int num = proto.PublicDependency[j];
			if (num >= 0 && num < proto.Dependency.Count)
			{
				string text = proto.Dependency[num];
				FileDescriptor fileDescriptor2 = dictionary[text];
				if (fileDescriptor2 == null)
				{
					if (!allowUnknownDependencies)
					{
						throw new DescriptorValidationException(@this, "Invalid public dependency: " + text);
					}
				}
				else
				{
					list.Add(fileDescriptor2);
				}
				continue;
			}
			throw new DescriptorValidationException(@this, "Invalid public dependency index.");
		}
		return new ReadOnlyCollection<FileDescriptor>(list);
	}

	public T FindTypeByName<T>(string name) where T : class, IDescriptor
	{
		if (name.IndexOf('.') != -1)
		{
			return null;
		}
		if (Package.Length > 0)
		{
			name = Package + "." + name;
		}
		T val = DescriptorPool.FindSymbol<T>(name);
		if (val != null && val.File == this)
		{
			return val;
		}
		return null;
	}

	private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
	{
		if (dependencies == null)
		{
			dependencies = new FileDescriptor[0];
		}
		DescriptorPool pool = new DescriptorPool(dependencies);
		FileDescriptor fileDescriptor = new FileDescriptor(descriptorData, proto, dependencies, pool, allowUnknownDependencies, generatedCodeInfo);
		if (dependencies.Length != proto.Dependency.Count)
		{
			throw new DescriptorValidationException(fileDescriptor, "Dependencies passed to FileDescriptor.BuildFrom() don't match those listed in the FileDescriptorProto.");
		}
		fileDescriptor.CrossLink();
		return fileDescriptor;
	}

	private void CrossLink()
	{
		foreach (MessageDescriptor messageType in MessageTypes)
		{
			messageType.CrossLink();
		}
		foreach (ServiceDescriptor service in Services)
		{
			service.CrossLink();
		}
	}

	public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo)
	{
		FileDescriptorProto fileDescriptorProto;
		try
		{
			fileDescriptorProto = FileDescriptorProto.Parser.ParseFrom(descriptorData);
		}
		catch (InvalidProtocolBufferException innerException)
		{
			throw new ArgumentException("Failed to parse protocol buffer descriptor for generated code.", innerException);
		}
		try
		{
			return BuildFrom(ByteString.CopyFrom(descriptorData), fileDescriptorProto, dependencies, allowUnknownDependencies: true, generatedCodeInfo);
		}
		catch (DescriptorValidationException innerException2)
		{
			throw new ArgumentException($"Invalid embedded descriptor for \"{fileDescriptorProto.Name}\".", innerException2);
		}
	}

	public override string ToString()
	{
		return $"FileDescriptor for {Name}";
	}

	public static void ForceReflectionInitialization<T>()
	{
		ReflectionUtil.ForceInitialize<T>();
	}
}
