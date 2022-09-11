using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common;

public class BinaryInfo
{
	[CompilerGenerated]
	private Guid? nullable_0;

	[CompilerGenerated]
	private DateTime? nullable_1;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private static Func<string, string> func_0;

	[CompilerGenerated]
	private static Func<string, bool> func_1;

	[CompilerGenerated]
	private static Func<object, bool> func_2;

	[CompilerGenerated]
	private static Func<object, bool> func_3;

	public Guid? ID
	{
		[CompilerGenerated]
		get
		{
			int num = -31640;
			int num2 = num;
			num = -31640;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return nullable_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 25833;
			int num2 = num;
			num = 25833;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			nullable_0 = value;
		}
	}

	public DateTime? LastModified
	{
		[CompilerGenerated]
		get
		{
			int num = -5903;
			int num2 = num;
			num = -5903;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return nullable_1;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 7485;
			int num2 = num;
			num = 7485;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			nullable_1 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = -19680;
			int num2 = num;
			num = -19680;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 7766;
			int num2 = num;
			num = 7766;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_0 = value;
		}
	}

	public string Version
	{
		[CompilerGenerated]
		get
		{
			int num = 25852;
			int num2 = num;
			num = 25852;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_1;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 15858;
			int num2 = num;
			num = 15858;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_1 = value;
		}
	}

	public string ClassName
	{
		[CompilerGenerated]
		get
		{
			int num = -14755;
			int num2 = num;
			num = -14755;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_2;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 12734;
			int num2 = num;
			num = 12734;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_2 = value;
		}
	}

	public string MethodName
	{
		[CompilerGenerated]
		get
		{
			int num = -28510;
			int num2 = num;
			num = -28510;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_3;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = -5460;
			int num2 = num;
			num = -5460;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			string_3 = value;
		}
	}

	public static BinaryInfo GetCurrent()
	{
		int num = -267;
		int num2 = num;
		num = -267;
		switch (num2 == num)
		{
		default:
		{
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			BinaryInfo binaryInfo = new BinaryInfo();
			binaryInfo.LoadFromAssembly(callingAssembly);
			return binaryInfo;
		}
		}
	}

	public void LoadFromAssembly(Assembly assembly_0)
	{
		int num = 8;
		switch (0)
		{
		default:
		{
			int num2 = 4;
			int num3 = num2;
			object obj = default(object);
			object obj3 = default(object);
			List<string> list = default(List<string>);
			while (true)
			{
				switch (num3)
				{
				case 9:
					obj = assembly_0.GetCustomAttributes(inherit: true).FirstOrDefault(delegate(object object_0)
					{
						int num10 = 6;
						int num11 = 18128;
						int num12 = num11;
						num11 = 18128;
						switch (num12 == num11)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							return object_0.GetType().FullName == "\ude82튤횷틫껟닆뛆닗뻄닓뚜닯긦刢嘠刷帰刣嘦刋渁牘瘰爗縜爗瘀爗渓刢嘦刬帻刴嘧勚껗";
						}
					});
					num2 = 1;
					num3 = num2;
					continue;
				case 7:
					Version = Version.Substring("튠횷틜껁닟뛝닐뺏".Length);
					num2 = 2;
					num3 = num2;
					continue;
				case 6:
					if (Version != null)
					{
						num2 = 7;
						num3 = num2;
						continue;
					}
					goto case 2;
				case 2:
					try
					{
						num2 = 4;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								obj3 = assembly_0.GetCustomAttributes(inherit: true).FirstOrDefault(delegate(object object_0)
								{
									int num7 = 17;
									int num8 = -31381;
									int num9 = num8;
									num8 = -31381;
									switch (num9 == num8)
									{
									default:
										if (1 == 0)
										{
										}
										if (0 == 0)
										{
										}
										return object_0.GetType().ToString() == "뛥닋뻍닆뛓닟꺀刀嘣刼帪刻嘻刷湀爻瘘爆縛爀瘙爂渽刷嘤判帷刱嘳刡꺀답뛃닛뻚닳뛂닆껜튻횴튧\udeaa튷";
									}
								});
								num2 = 1;
								num3 = num2;
								continue;
							case 2:
							{
								num2 = -13955;
								int num4 = num2;
								num2 = -13955;
								switch (num4 == num2)
								{
								case false:
								case true:
									break;
								default:
									if (0 == 0)
									{
									}
									ID = new Guid((string)obj3.GetType().GetProperty("튀횳틂껇닓")!.GetValue(obj3, null));
									num2 = 0;
									num3 = num2;
									continue;
								}
								goto default;
							}
							case 1:
								if (obj3 != null)
								{
									num2 = 2;
									num3 = num2;
									continue;
								}
								break;
							case 0:
								break;
							case 3:
								goto end_IL_01db;
							}
							num2 = 3;
							num3 = num2;
							continue;
							end_IL_01db:
							break;
						}
					}
					catch
					{
					}
					num2 = 9;
					num3 = num2;
					continue;
				case 5:
					Version = list.Skip(1).SingleOrDefault(delegate(string string_4)
					{
						int num13 = 3;
						int num14 = 17659;
						int num15 = num14;
						num14 = 17659;
						switch (num15 == num14)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							return string_4.ToLower().StartsWith("튤\udebb튠횥튻껁닜뚋");
						}
					});
					num2 = 6;
					num3 = num2;
					continue;
				case 1:
					if (obj != null)
					{
						num2 = 3;
						num3 = num2;
						continue;
					}
					return;
				case 0:
					if (Name == "튆횠틋껷닛뛂닊뻛닀뛗늀긓券嘳刲師刢嘻刍渁牘瘥爗縜爤瘦")
					{
						num2 = 8;
						num3 = num2;
					}
					else
					{
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 3:
					try
					{
						if (1 == 0)
						{
						}
						ID = new Guid((string)obj.GetType().GetProperty("튑횧틇껖")!.GetValue(obj, null));
						return;
					}
					catch
					{
						return;
					}
				case 8:
					return;
				}
				list = assembly_0.FullName!.Split(new char[1] { ',' }).Select(delegate(string string_4)
				{
					int num5 = -4436;
					int num6 = num5;
					num5 = -4436;
					switch (num6 == num5)
					{
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						return string_4.Trim();
					}
				}).ToList();
				Name = list[0];
				num2 = 0;
				num3 = num2;
			}
		}
		}
	}

	public BinaryInfo([Optional] string method, [Optional] string @class, [Optional] string asmnam, [Optional] string version, [Optional] Guid? nullable_2, [Optional] DateTime? modified)
	{
		Name = asmnam;
		ClassName = @class;
		MethodName = method;
		Version = version;
		ID = nullable_2;
		LastModified = modified;
	}

	public BinaryInfoTag ToTag()
	{
		int num = 9328;
		int num2 = num;
		num = 9328;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return new BinaryInfoTag(this);
		}
	}

	[CompilerGenerated]
	private static string smethod_0(string string_4)
	{
		int num = -4436;
		int num2 = num;
		num = -4436;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return string_4.Trim();
		}
	}

	[CompilerGenerated]
	private static bool smethod_1(string string_4)
	{
		int num = 3;
		int num2 = 17659;
		int num3 = num2;
		num2 = 17659;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return string_4.ToLower().StartsWith("튤\udebb튠횥튻껁닜뚋");
		}
	}

	[CompilerGenerated]
	private static bool smethod_2(object object_0)
	{
		int num = 17;
		int num2 = -31381;
		int num3 = num2;
		num2 = -31381;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return object_0.GetType().ToString() == "뛥닋뻍닆뛓닟꺀刀嘣刼帪刻嘻刷湀爻瘘爆縛爀瘙爂渽刷嘤判帷刱嘳刡꺀답뛃닛뻚닳뛂닆껜튻횴튧\udeaa튷";
		}
	}

	[CompilerGenerated]
	private static bool smethod_3(object object_0)
	{
		int num = 6;
		int num2 = 18128;
		int num3 = num2;
		num2 = 18128;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return object_0.GetType().FullName == "\ude82튤횷틫껟닆뛆닗뻄닓뚜닯긦刢嘠刷帰刣嘦刋渁牘瘰爗縜爗瘀爗渓刢嘦刬帻刴嘧勚껗";
		}
	}
}
