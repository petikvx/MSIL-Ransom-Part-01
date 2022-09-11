using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic;

internal class AttributesCriterion : SelectionCriterion
{
	private FileAttributes _Attributes;

	internal ComparisonOperator Operator;

	internal string AttributeString
	{
		get
		{
			string text = "";
			if ((_Attributes & FileAttributes.Hidden) != 0)
			{
				text += "H";
			}
			if ((_Attributes & FileAttributes.System) != 0)
			{
				text += "S";
			}
			if ((_Attributes & FileAttributes.ReadOnly) != 0)
			{
				text += "R";
			}
			if ((_Attributes & FileAttributes.Archive) != 0)
			{
				text += "A";
			}
			if ((_Attributes & FileAttributes.ReparsePoint) != 0)
			{
				text += "L";
			}
			if ((_Attributes & FileAttributes.NotContentIndexed) != 0)
			{
				text += "I";
			}
			return text;
		}
		set
		{
			_Attributes = FileAttributes.Normal;
			string text = value.ToUpper();
			foreach (char c in text)
			{
				switch (c)
				{
				case 'H':
					if ((_Attributes & FileAttributes.Hidden) == 0)
					{
						_Attributes |= FileAttributes.Hidden;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'I':
					if ((_Attributes & FileAttributes.NotContentIndexed) == 0)
					{
						_Attributes |= FileAttributes.NotContentIndexed;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'L':
					if ((_Attributes & FileAttributes.ReparsePoint) == 0)
					{
						_Attributes |= FileAttributes.ReparsePoint;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'A':
					if ((_Attributes & FileAttributes.Archive) == 0)
					{
						_Attributes |= FileAttributes.Archive;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'S':
					if ((_Attributes & FileAttributes.System) == 0)
					{
						_Attributes |= FileAttributes.System;
						break;
					}
					throw new ArgumentException($"Repeated flag. ({c})", "value");
				case 'R':
					if ((_Attributes & FileAttributes.ReadOnly) == 0)
					{
						_Attributes |= FileAttributes.ReadOnly;
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
		stringBuilder.Append("attributes ").Append(EnumUtil.GetDescription(Operator)).Append(" ")
			.Append(AttributeString);
		return stringBuilder.ToString();
	}

	private bool _EvaluateOne(FileAttributes fileAttrs, FileAttributes criterionAttrs)
	{
		bool flag = false;
		if ((_Attributes & criterionAttrs) == criterionAttrs)
		{
			return (fileAttrs & criterionAttrs) == criterionAttrs;
		}
		return true;
	}

	internal override bool Evaluate(string filename)
	{
		if (Directory.Exists(filename))
		{
			return Operator != ComparisonOperator.EqualTo;
		}
		FileAttributes attributes = File.GetAttributes(filename);
		return _Evaluate(attributes);
	}

	private bool _Evaluate(FileAttributes fileAttrs)
	{
		bool flag;
		if (flag = _EvaluateOne(fileAttrs, FileAttributes.Hidden))
		{
			flag = _EvaluateOne(fileAttrs, FileAttributes.System);
		}
		if (flag)
		{
			flag = _EvaluateOne(fileAttrs, FileAttributes.ReadOnly);
		}
		if (flag)
		{
			flag = _EvaluateOne(fileAttrs, FileAttributes.Archive);
		}
		if (flag)
		{
			flag = _EvaluateOne(fileAttrs, FileAttributes.NotContentIndexed);
		}
		if (flag)
		{
			flag = _EvaluateOne(fileAttrs, FileAttributes.ReparsePoint);
		}
		if (Operator != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool Evaluate(ZipEntry entry)
	{
		FileAttributes attributes = entry.Attributes;
		return _Evaluate(attributes);
	}
}
