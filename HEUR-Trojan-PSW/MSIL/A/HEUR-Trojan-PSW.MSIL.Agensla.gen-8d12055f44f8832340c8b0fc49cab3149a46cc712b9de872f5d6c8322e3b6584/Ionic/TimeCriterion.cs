using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic;

internal class TimeCriterion : SelectionCriterion
{
	internal ComparisonOperator Operator;

	internal WhichTime Which;

	internal DateTime Time;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Which.ToString()).Append(" ").Append(EnumUtil.GetDescription(Operator))
			.Append(" ")
			.Append(Time.ToString("yyyy-MM-dd-HH:mm:ss"));
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		return _Evaluate(Which switch
		{
			WhichTime.atime => File.GetLastAccessTime(filename).ToUniversalTime(), 
			WhichTime.mtime => File.GetLastWriteTime(filename).ToUniversalTime(), 
			WhichTime.ctime => File.GetCreationTime(filename).ToUniversalTime(), 
			_ => throw new ArgumentException("Operator"), 
		});
	}

	private bool _Evaluate(DateTime x)
	{
		bool flag = false;
		return Operator switch
		{
			ComparisonOperator.GreaterThan => x > Time, 
			ComparisonOperator.GreaterThanOrEqualTo => x >= Time, 
			ComparisonOperator.LesserThan => x < Time, 
			ComparisonOperator.LesserThanOrEqualTo => x <= Time, 
			ComparisonOperator.EqualTo => x == Time, 
			ComparisonOperator.NotEqualTo => x != Time, 
			_ => throw new ArgumentException("Operator"), 
		};
	}

	internal override bool Evaluate(ZipEntry entry)
	{
		return _Evaluate(Which switch
		{
			WhichTime.atime => entry.AccessedTime, 
			WhichTime.mtime => entry.ModifiedTime, 
			WhichTime.ctime => entry.CreationTime, 
			_ => throw new ArgumentException("??time"), 
		});
	}
}
