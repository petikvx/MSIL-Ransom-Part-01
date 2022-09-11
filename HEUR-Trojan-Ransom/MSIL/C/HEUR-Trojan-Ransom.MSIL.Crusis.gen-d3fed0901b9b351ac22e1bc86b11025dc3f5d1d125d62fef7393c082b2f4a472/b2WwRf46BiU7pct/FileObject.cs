using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace b2WwRf46BiU7pct;

public class FileObject
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private byte[] byte_0;

	internal string string_0;

	public int Delay
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string SomeMetaData
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string text = (string_0 = value);
		}
	}

	public byte[] Content
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
		[CompilerGenerated]
		set
		{
			byte_0 = value;
		}
	}

	public static object Object => null;

	public static object[] paramObjects => new object[0];

	public static void M(object value)
	{
		//IL_0002: Expected O, but got I4
		//IL_000c: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		string text = (string)0;
		while (true)
		{
			if ((nint)text == 1)
			{
				MethodInfo obj = (MethodInfo)value;
				if ((MethodInfo)value == null)
				{
					break;
				}
				obj.Invoke(Object, paramObjects);
				text = (string)2;
			}
			if (text == null)
			{
				text = (string)1;
			}
			if ((nint)text == 2)
			{
				return;
			}
		}
		throw new ArgumentNullException("value");
	}
}
