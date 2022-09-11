using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using PreEmptive.Analytics.Common.Tags;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common.Messages;

public class Fault : Message
{
	private string string_3;

	public override string TagName
	{
		get
		{
			int num = 13;
			int num2 = 17704;
			int num3 = num2;
			num2 = 17704;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "껈닓뛃닞뻊";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = -1865;
			int num2 = num;
			num = -1865;
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
	}

	public Fault(IPlatform platform, ExceptionInfo exceptionInfo, Guid session, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary, [Optional] bool includeAppComponents)
	{
		int num = 8;
		string_3 = "튳횪틍껗닆뛆닗뻝님";
		base._002Ector(session, keys, binary);
		string text = exceptionInfo.ExceptionType.ToString().ToLowerInvariant();
		AddAttribute("튳횤틋껜닂", text);
		AddOptionalAttribute("튵횽틃껟닓뛜닊", exceptionInfo.Comment);
		AddOptionalAttribute("튵횽틀껆닗뛑닊", exceptionInfo.Contact);
		string_3 = text + "틶" + string_3;
		Exception ex = exceptionInfo.Exception;
		if (ex == null)
		{
			ExceptionTag item = new ExceptionTag("튃횼틅껜닙뛅닐", exceptionInfo.Message)
			{
				InnerTags = { (Tag)new StackTag(0, "튃횼틅껜닙뛅닐", "튃횼틅껜닙뛅닐") }
			};
			base.InnerTags.Add(item);
		}
		else if (exceptionInfo.Message != null)
		{
			ex.Data["튓횪틍껗닆뛆닗뻝님뛿닋긡別嘳刹帷"] = exceptionInfo.Message;
		}
		int num2 = -1;
		while (ex != null)
		{
			num2++;
			ExceptionTag exceptionTag = new ExceptionTag(num2, (ex.Data["튓횪틍껗닆뛆닗뻝님뛼닏긿刳"] == null) ? ((object)ex).GetType().ToString() : (ex.Data["튓횪틍껗닆뛆닗뻝님뛼닏긿刳"] as string), (ex.Data["튓횪틍껗닆뛆닗뻝님뛿닋긡別嘳刹帷"] == null) ? ex.Message : (ex.Data["튓횪틍껗닆뛆닗뻝님뛿닋긡別嘳刹帷"] as string));
			IList<StackInfo> list = new List<StackInfo>();
			if (ex.Data["튅횦틏껑닝뛦닌뻓닕뛗"] != null)
			{
				list = GetStackInfo(ex.Data["튅횦틏껑닝뛦닌뻓닕뛗"] as string, ex.Data["튅횦틏껑닝뛦닌뻓닕뛗닼긷刱嘷刦"] as string);
			}
			try
			{
				if (list.Count == 0)
				{
					list = platform.GetStackInfo(ex);
				}
			}
			catch
			{
			}
			if (list.Count == 0)
			{
				list = GetStackInfo(ex.StackTrace);
			}
			if (list.Count == 0)
			{
				list.Add(new StackInfo(0, "튃횼틅껜닙뛅닐", "튃횼틅껜닙뛅닐", null, null, null));
			}
			foreach (StackInfo item2 in list)
			{
				exceptionTag.InnerTags.Add(new StackTag(item2.Sequence, item2.Type, item2.Method, item2.Signature, item2.File, item2.Line));
			}
			base.InnerTags.Add(exceptionTag);
			ex = ex.InnerException;
		}
		if (!includeAppComponents)
		{
			return;
		}
		IList<ComponentInfo> list2 = new List<ComponentInfo>();
		try
		{
			list2 = platform.GetComponentInfo();
		}
		catch
		{
		}
		foreach (ComponentInfo item3 in list2)
		{
			base.InnerTags.Add(new AppComponentTag(item3.Name, item3.Version, item3.FullName));
		}
	}

	public static IList<StackInfo> GetStackInfo(string stackTrace, [Optional] string customStackTraceRegex)
	{
		int num = 6;
		int num2 = 23107;
		int num3 = num2;
		num2 = 23107;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			switch (0)
			{
			}
			break;
		case false:
		case true:
			break;
		}
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		int num5 = default(int);
		while (true)
		{
			List<StackInfo> list = new List<StackInfo>();
			List<string> list2 = new List<string>();
			list2.Add("\ude8c튊횡튄꺜늜뛮닜뺚늉뚎닚긫刦嘷剠幼剽嘎剀温爨瘮牖繈爫癘片渎剸噺剡幮刻嘷勚껚늈뛮닉뺙늟뚚늑껮튥횻특\udeec튊훺틀\ueed8\uf2aa\uf6db\uf2d7ﻚ\uf2c9\uf6da\uf2b2\ueef2튊횥틵\ude8e틶훻틲꺒닪뛅늕뻮늖뚚늑깮到嘻刲帷剨噼剄湍牟瘮牄縮爁癙爲湲剾噭剢帾刿嘼勋꺌닭뚂늓뺋닫뚙늑껻튊횠틡\udef6튪훼틄\ueeae\uf284\uf6cd\uf2daﻛ");
			list2.Add("\ude8c튊횡튄껮닁뚙닢뻁늞뚍늒긿刳嘦制幬剸噸則湍爪癚牖繍牊瘔爇渾刳噬剰幸剿嘎劔꺚늉뚎닒뻛님뛗느꺉틦훿틧\ude8f틽훭틇\ueeae\uf2cc\uf6dc\uf2d4ﻖ");
			num2 = 0;
			int num4 = num2;
			while (true)
			{
				switch (num4)
				{
				case 5:
					enumerator = list2.GetEnumerator();
					num2 = 4;
					num4 = num2;
					continue;
				case 3:
					if (stackTrace != null)
					{
						num2 = 5;
						num4 = num2;
						continue;
					}
					return list;
				case 2:
					list2.Add(customStackTraceRegex);
					num2 = 1;
					num4 = num2;
					continue;
				case 1:
					num2 = 3;
					num4 = num2;
					continue;
				case 0:
					if (!string.IsNullOrEmpty(customStackTraceRegex))
					{
						num2 = 2;
						num4 = num2;
						continue;
					}
					goto case 1;
				case 4:
					if (1 == 0)
					{
					}
					try
					{
						num2 = 1;
						num4 = num2;
						while (true)
						{
							switch (num4)
							{
							case 3:
								num2 = 4;
								num4 = num2;
								break;
							case 2:
								try
								{
									while (true)
									{
										IL_0354:
										MatchCollection matchCollection = Regex.Matches(stackTrace, current, RegexOptions.Multiline);
										num2 = 0;
										num4 = num2;
										while (true)
										{
											switch (num4)
											{
											case 8:
												num2 = 6;
												num4 = num2;
												continue;
											case 1:
											case 7:
												num2 = 3;
												num4 = num2;
												continue;
											case 5:
												if (list.Count > 0)
												{
													num2 = 8;
													num4 = num2;
													continue;
												}
												goto IL_01c6;
											case 4:
												num5 = 0;
												num2 = 1;
												num4 = num2;
												continue;
											case 3:
											{
												if (num5 >= matchCollection.Count)
												{
													num2 = 2;
													num4 = num2;
													continue;
												}
												Match match = matchCollection[num5];
												StackInfo item = default(StackInfo);
												item.Sequence = num5;
												item.Type = match.Groups["\udea6튯횢틋"].Value.Sanitize();
												item.Method = match.Groups["\udebf튳횦틆"].Value.Sanitize();
												item.Signature = match.Groups["\udea1튿횵"].Value.Sanitize();
												item.File = match.Groups["\udeb4튿횾틋"].Value.Sanitize();
												item.Line = match.Groups["\udebe튿횼틋"].Value.Sanitize();
												list.Add(item);
												num5++;
												num2 = 7;
												num4 = num2;
												continue;
											}
											case 2:
												num2 = 5;
												num4 = num2;
												continue;
											case 0:
												if (matchCollection.Count > 0)
												{
													num2 = 4;
													num4 = num2;
													continue;
												}
												goto IL_01c6;
											case 6:
												goto end_IL_0325;
											case 9:
												goto IL_03b0;
												IL_01c6:
												num2 = 9;
												num4 = num2;
												continue;
											}
											goto IL_0354;
											continue;
											end_IL_0325:
											break;
										}
										break;
									}
								}
								catch
								{
									goto IL_03b0;
								}
								goto case 3;
							case 0:
								if (!enumerator.MoveNext())
								{
									num2 = 3;
									num4 = num2;
								}
								else
								{
									current = enumerator.Current;
									num2 = 2;
									num4 = num2;
								}
								break;
							default:
								goto IL_03b0;
							case 4:
								{
									return list;
								}
								IL_03b0:
								num2 = 0;
								num4 = num2;
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				break;
			}
		}
	}
}
