using System;
using System.IO;
using System.Text;
using Ionic;

internal class Class5 : Class0
{
	private FileAttributes fileAttributes_0;

	internal ComparisonOperator comparisonOperator_0;

	internal string String_0
	{
		get
		{
			string text = "";
			if ((fileAttributes_0 & FileAttributes.Hidden) != 0)
			{
				text += "H";
			}
			if ((fileAttributes_0 & FileAttributes.System) != 0)
			{
				text += "S";
			}
			if ((fileAttributes_0 & FileAttributes.ReadOnly) != 0)
			{
				text += "R";
			}
			if ((fileAttributes_0 & FileAttributes.Archive) != 0)
			{
				text += "A";
			}
			if ((fileAttributes_0 & FileAttributes.ReparsePoint) != 0)
			{
				text += "L";
			}
			if ((fileAttributes_0 & FileAttributes.NotContentIndexed) != 0)
			{
				text += "I";
			}
			return text;
		}
		set
		{
			fileAttributes_0 = FileAttributes.Normal;
			string text = value.ToUpper();
			foreach (char c in text)
			{
				switch (c)
				{
				case 'H':
					if ((fileAttributes_0 & FileAttributes.Hidden) == 0)
					{
						fileAttributes_0 |= FileAttributes.Hidden;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'I':
					if ((fileAttributes_0 & FileAttributes.NotContentIndexed) == 0)
					{
						fileAttributes_0 |= FileAttributes.NotContentIndexed;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'L':
					if ((fileAttributes_0 & FileAttributes.ReparsePoint) == 0)
					{
						fileAttributes_0 |= FileAttributes.ReparsePoint;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'A':
					if ((fileAttributes_0 & FileAttributes.Archive) == 0)
					{
						fileAttributes_0 |= FileAttributes.Archive;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'S':
					if ((fileAttributes_0 & FileAttributes.System) == 0)
					{
						fileAttributes_0 |= FileAttributes.System;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'R':
					if ((fileAttributes_0 & FileAttributes.ReadOnly) == 0)
					{
						fileAttributes_0 |= FileAttributes.ReadOnly;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				default:
					throw new ArgumentException(value);
				}
			}
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("attributes ").Append(Class8.smethod_0(comparisonOperator_0)).Append(" ")
			.Append(String_0);
		return stringBuilder.ToString();
	}

	private bool method_0(FileAttributes fileAttributes_1, FileAttributes fileAttributes_2)
	{
		bool flag = false;
		if ((fileAttributes_0 & fileAttributes_2) == fileAttributes_2)
		{
			return (fileAttributes_1 & fileAttributes_2) == fileAttributes_2;
		}
		return true;
	}

	internal override bool Evaluate(string filename)
	{
		if (Directory.Exists(filename))
		{
			return comparisonOperator_0 != ComparisonOperator.EqualTo;
		}
		FileAttributes attributes = File.GetAttributes(filename);
		return method_1(attributes);
	}

	private bool method_1(FileAttributes fileAttributes_1)
	{
		bool flag;
		if (flag = method_0(fileAttributes_1, FileAttributes.Hidden))
		{
			flag = method_0(fileAttributes_1, FileAttributes.System);
		}
		if (flag)
		{
			flag = method_0(fileAttributes_1, FileAttributes.ReadOnly);
		}
		if (flag)
		{
			flag = method_0(fileAttributes_1, FileAttributes.Archive);
		}
		if (flag)
		{
			flag = method_0(fileAttributes_1, FileAttributes.NotContentIndexed);
		}
		if (flag)
		{
			flag = method_0(fileAttributes_1, FileAttributes.ReparsePoint);
		}
		if (comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool Evaluate(GClass8 entry)
	{
		FileAttributes fileAttributes_ = entry.FileAttributes_0;
		return method_1(fileAttributes_);
	}
}
