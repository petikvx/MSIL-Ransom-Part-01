using System.IO;
using System.Runtime.CompilerServices;

internal class Class1
{
	private FileInfo fileInfo_0;

	private bool bool_0;

	public FileInfo FileInfo_0
	{
		get
		{
			return fileInfo_0;
		}
		set
		{
			fileInfo_0 = value;
		}
	}

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	public Class1()
	{
	}

	public Class1(FileInfo file, bool enc)
	{
		fileInfo_0 = file;
		bool_0 = enc;
	}

	[SpecialName]
	public static bool smethod_0(Class1 class1_0, Class1 class1_1)
	{
		if (object.ReferenceEquals(class1_0, class1_1))
		{
			return true;
		}
		if (class1_0 != null && class1_1 != null)
		{
			return class1_0.FileInfo_0.FullName == class1_1.FileInfo_0.FullName;
		}
		return false;
	}

	[SpecialName]
	public static bool smethod_1(Class1 class1_0, Class1 class1_1)
	{
		if (object.ReferenceEquals(class1_0, class1_1))
		{
			return false;
		}
		if (class1_0 != null && class1_1 != null)
		{
			return class1_0.FileInfo_0.FullName != class1_1.FileInfo_0.FullName;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is Class1 @class))
		{
			return false;
		}
		return @class.FileInfo_0.FullName == fileInfo_0.FullName;
	}

	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
