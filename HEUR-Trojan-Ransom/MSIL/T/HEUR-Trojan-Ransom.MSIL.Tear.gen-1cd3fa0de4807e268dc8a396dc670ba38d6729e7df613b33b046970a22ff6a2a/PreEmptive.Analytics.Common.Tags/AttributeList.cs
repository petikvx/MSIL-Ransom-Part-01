using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common.Tags;

public class AttributeList : List<Attribute>
{
	[CompilerGenerated]
	private sealed class Class30
	{
		public string string_0;

		public bool method_0(Attribute attribute_0)
		{
			int num = -16514;
			int num2 = num;
			num = -16514;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return attribute_0.Name == string_0;
			}
		}
	}

	public Attribute this[string name]
	{
		get
		{
			int num = 22074;
			int num2 = num;
			num = 22074;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return this.SingleOrDefault(delegate(Attribute attribute_0)
				{
					int num3 = -16514;
					int num4 = num3;
					num3 = -16514;
					switch (num4 == num3)
					{
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						return attribute_0.Name == name;
					}
				});
			}
		}
	}
}
