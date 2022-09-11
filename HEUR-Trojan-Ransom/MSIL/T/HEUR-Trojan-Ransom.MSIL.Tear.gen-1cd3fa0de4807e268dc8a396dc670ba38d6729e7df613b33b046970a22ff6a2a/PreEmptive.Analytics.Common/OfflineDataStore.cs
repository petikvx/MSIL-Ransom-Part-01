using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public class OfflineDataStore : IDisposable, IOfflineDataStore
{
	[CompilerGenerated]
	private sealed class Class12
	{
		public string string_0;

		public OfflineDataStore offlineDataStore_0;

		public void method_0()
		{
			int num = 23195;
			int num2 = num;
			num = 23195;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			offlineDataStore_0.iofflineStorageManager_0.DeleteFile(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class13
	{
		public string string_0;

		public OfflineDataStore offlineDataStore_0;

		public void method_0()
		{
			if (1 == 0)
			{
			}
			int num = -21314;
			int num2 = num;
			num = -21314;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			offlineDataStore_0.iofflineStorageManager_0.DeleteFile(string_0);
		}

		public void method_1()
		{
			int num = 23752;
			int num2 = num;
			num = 23752;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			offlineDataStore_0.iofflineStorageManager_0.DeleteFile(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public Class13 class13_0;

		public string string_0;

		public void method_0()
		{
			int num = 10;
			int num2 = -23023;
			int num3 = num2;
			num2 = -23023;
			switch (num3 == num2)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			class13_0.offlineDataStore_0.iofflineStorageManager_0.MoveFile(string_0, string_0 + "훼틟");
		}

		public string method_1()
		{
			int num = 5;
			int num2 = -17107;
			int num3 = num2;
			num2 = -17107;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return class13_0.offlineDataStore_0.iofflineStorageManager_0.ReadFile(string_0 + "\udef0튣");
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class15
	{
		public string string_0;

		public OfflineDataStore offlineDataStore_0;

		public void method_0()
		{
			int num = 11387;
			int num2 = num;
			num = 11387;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			offlineDataStore_0.iofflineStorageManager_0.DeleteFile(string_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class16
	{
		public string string_0;

		public OfflineDataStore offlineDataStore_0;

		public void method_0()
		{
			int num = -19922;
			int num2 = num;
			num = -19922;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			offlineDataStore_0.iofflineStorageManager_0.DeleteFile(string_0);
		}
	}

	private IOfflineStorageManager iofflineStorageManager_0;

	private static object object_0;

	protected readonly ILogger Logger;

	[CompilerGenerated]
	private static Func<string, string> func_0;

	[CompilerGenerated]
	private static Func<string, string> func_1;

	public OfflineDataStore(IOfflineStorageManager manager, [Optional] ILogger logger)
	{
		int num = 13;
		base._002Ector();
		Logger = logger ?? new BlankLogger();
		iofflineStorageManager_0 = manager;
		foreach (string item in iofflineStorageManager_0.GetFilesEndingWith("꺀닀뛟닁뺐닃", ""))
		{
			try
			{
				iofflineStorageManager_0.MoveFile(item, item.Substring(0, item.Length - 2));
			}
			catch (Exception exception_)
			{
				Logger.LogException(exception_, "껯닜뚖닇뻐닗뛎닂껋刱嘢刷帺割嘳刪渍爗瘆爆縗爝瘘牒渁刱嘵刧帬刷嘲割껙닚뛟닞뻛늒뛂닀껗튻횸튵\udefe튦횹틲\uee8d\uf29e\uf693\uf293ﺌ\uf2d2\uf682\uf297\uee83튢횹튠\udebf튠횯틲껟닇뛓닇뻛늒뛙닔꺎刽嘰刴帲刻嘸刷湎爁瘂爝縌爓瘑爗");
			}
		}
	}

	public void SaveBatch(MessageBatch messagebatch)
	{
		int num = -4991;
		int num2 = num;
		num = -4991;
		switch (num2 == num)
		{
		case false:
		case true:
			return;
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			Monitor.Enter(obj = object_0, ref lockTaken);
			method_0(messagebatch);
		}
		finally
		{
			num = 0;
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 1:
					Monitor.Exit(obj);
					num = 2;
					num3 = num;
					continue;
				default:
					if (lockTaken)
					{
						num = 1;
						num3 = num;
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
		}
	}

	private void method_0(MessageBatch messageBatch_0)
	{
		int num = 19;
		switch (0)
		{
		}
		bool flag2 = default(bool);
		bool flag = default(bool);
		IEnumerator<string> enumerator = default(IEnumerator<string>);
		IEnumerator<string> enumerator2 = default(IEnumerator<string>);
		IEnumerable<string> filesEndingWith3 = default(IEnumerable<string>);
		string current2 = default(string);
		string text = default(string);
		while (true)
		{
			if (true)
			{
			}
			Action action = null;
			IEnumerable<string> filesEndingWith = iofflineStorageManager_0.GetFilesEndingWith("늟" + messageBatch_0.ID + "늜뻌닛뛅", "");
			int num2 = 15;
			int num3 = num2;
			string string_ = default(string);
			while (true)
			{
				switch (num3)
				{
				case 17:
					flag2 = false;
					num2 = 5;
					num3 = num2;
					continue;
				case 15:
				{
					if (filesEndingWith.Any())
					{
						num2 = 13;
						num3 = num2;
						continue;
					}
					IEnumerable<string> filesEndingWith2 = iofflineStorageManager_0.GetFilesEndingWith("늟" + messageBatch_0.ID + "늜뻌닛뛅늜껟", "");
					flag = false;
					enumerator = filesEndingWith2.GetEnumerator();
					num2 = 9;
					num3 = num2;
					continue;
				}
				case 14:
					action = delegate
					{
						int num7 = 23195;
						int num8 = num7;
						num7 = 23195;
						switch (num8 == num7)
						{
						default:
							if (0 == 0)
							{
							}
							if (1 == 0)
							{
							}
							iofflineStorageManager_0.DeleteFile(string_);
							break;
						}
					};
					num2 = 0;
					num3 = num2;
					continue;
				case 12:
					enumerator2 = filesEndingWith3.OrderBy(delegate(string string_0)
					{
						int num5 = -31502;
						int num6 = num5;
						num5 = -31502;
						switch (num6 == num5)
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
					}).GetEnumerator();
					num2 = 10;
					num3 = num2;
					continue;
				case 10:
					try
					{
						num2 = 3;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 5:
								try
								{
									iofflineStorageManager_0.DeleteFile(current2);
								}
								catch (Exception exception_)
								{
									Logger.LogExceptionWarning(exception_, "닳뻐늒뛃닜껋刪嘦刷帽刦嘳制湎爜瘙爜繓爑瘄爛渚刻嘵刳帲割嘳刪껍닗뛆닆뻗닝뛘늒껁튱횵튧\udeac튷횲");
									goto default;
								}
								Logger.LogInfo("닰뻟닆뛕닚꺎刡嘣刱帽刷嘥刡済爇瘚爞縇牒瘒爗渂刷嘢刷帺割嘢刽꺎닟뛗닙뻛늒뛄닝껁튿훶튴\udeb1튠훶튼\uee8b\uf285\uf6d6\uf290ﺟ\uf286\uf695\uf29a\uee8b튡훬틲" + current2);
								num2 = 1;
								num3 = num2;
								continue;
							default:
								num2 = 2;
								num3 = num2;
								continue;
							case 2:
								if (!enumerator2.MoveNext())
								{
									num2 = 0;
									num3 = num2;
								}
								else
								{
									current2 = enumerator2.Current;
									num2 = 5;
									num3 = num2;
								}
								continue;
							case 0:
							case 1:
								num2 = 4;
								num3 = num2;
								continue;
							case 4:
								break;
							}
							break;
						}
					}
					finally
					{
						num2 = 0;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 1:
								enumerator2.Dispose();
								num2 = 2;
								num3 = num2;
								continue;
							default:
								if (enumerator2 != null)
								{
									num2 = 1;
									num3 = num2;
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
					}
					goto IL_02c8;
				case 9:
					try
					{
						num2 = 2;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 3:
								num2 = 4;
								num3 = num2;
								continue;
							default:
								num2 = 1;
								num3 = num2;
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num2 = 3;
									num3 = num2;
									continue;
								}
								string current = enumerator.Current;
								flag = true;
								iofflineStorageManager_0.WriteToFile(current, messageBatch_0.ToString());
								iofflineStorageManager_0.MoveFile(current, current.Substring(0, current.Length - 2));
								num2 = -17146;
								int num4 = num2;
								num2 = -17146;
								switch (num4 == num2)
								{
								case false:
								case true:
									continue;
								}
								if (0 == 0)
								{
								}
								num2 = 0;
								num3 = num2;
								continue;
							}
							case 4:
								break;
							}
							break;
						}
					}
					finally
					{
						num2 = 0;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 1:
								enumerator.Dispose();
								num2 = 2;
								num3 = num2;
								continue;
							default:
								if (enumerator != null)
								{
									num2 = 1;
									num3 = num2;
									continue;
								}
								break;
							case 2:
								break;
							}
							break;
						}
					}
					num2 = 3;
					num3 = num2;
					continue;
				case 7:
					if (flag2)
					{
						num2 = 4;
						num3 = num2;
						continue;
					}
					goto IL_02c8;
				case 6:
					if (!filesEndingWith3.Any())
					{
						num2 = 8;
						num3 = num2;
					}
					else
					{
						num2 = 12;
						num3 = num2;
					}
					continue;
				case 5:
					try
					{
						iofflineStorageManager_0.WriteToFile(string_, text);
					}
					catch (Exception exception_2)
					{
						Logger.LogExceptionWarning(exception_2, "닳뻐늒뛃닜껋刪嘦刷帽刦嘳制湎爗瘎爑縛爂瘂爛渁刼噶刽帽刱嘣删껋닖뚘늒뻪닀뛏닛껀튵훶튳\udeb9튳횿튼");
						flag2 = true;
					}
					num2 = 7;
					num3 = num2;
					continue;
				case 4:
					Logger.LogWarning("닶뻗닁뛝늒껏刢嘦刷帿删嘥割渚爝癖爐縛牒瘐爇渂刾噸割帚刷嘺刷껚닛뛘닕뺞닝뛚닖꺎튰횷튦\udebd튺훶튦\uee81\uf2d2\uf690\uf29bﺊ\uf2d2\uf698\uf297\uee99틲횴튳\udeaa튱횾");
					num2 = 1;
					num3 = num2;
					continue;
				case 3:
					if (flag)
					{
						num2 = 16;
						num3 = num2;
						continue;
					}
					string_ = string.Format("닉뺎닏뚛닉꺟刯噸删帷刡", new object[2]
					{
						messageBatch_0.DateCreated.ToString("닋뻇닋뛏닿껣制嘲刚帖刿嘻刡渝爔瘐爔縘爔瘐爔"),
						messageBatch_0.ID
					});
					text = messageBatch_0.ToString();
					flag2 = false;
					num2 = 17;
					num3 = num2;
					continue;
				case 2:
					if (!flag2)
					{
						num2 = 11;
						num3 = num2;
						continue;
					}
					goto case 17;
				case 1:
					if (action == null)
					{
						num2 = 14;
						num3 = num2;
						continue;
					}
					goto case 0;
				case 0:
					Utils.Attempt(action, Logger);
					filesEndingWith3 = iofflineStorageManager_0.GetFilesEndingWith("늜뻌닛뛅", "");
					num2 = 6;
					num3 = num2;
					continue;
				case 8:
					Logger.LogError("닼뻑늒뛕닓껍刺嘳制幾刿嘳刡渝爓瘑爗縍牒瘕爝減刾嘲割帼刷噶刴껁닇뛘닖뺞닆뛙늒껌튷훶튶\udebb튾횳튦\uee8b\uf296\uf6d8\uf2d2ﺼ\uf293\uf682\uf291\uee86틲횡튻\udeb2튾훶튼껁닆뚖닐뻛늒뛅닓께刷嘲割帪刽噶刽済爔瘚爛縐爗癖爁渚刽嘤刳帹刷噶制껛닗뚖닆뻑늒뛚닓껍특훶튽\udeb8틲횥튢\uee8f\uf291\uf693\uf2d3");
					return;
				case 11:
					return;
				case 13:
					return;
				case 16:
					return;
					IL_02c8:
					num2 = 2;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	public MessageBatch GetSavedBatch()
	{
		int num = 13;
		switch (0)
		{
		}
		object obj = default(object);
		bool lockTaken = default(bool);
		List<string> list = default(List<string>);
		Action action3 = default(Action);
		Func<string> func = default(Func<string>);
		Class14 @class = default(Class14);
		MessageBatch messageBatch2 = default(MessageBatch);
		while (true)
		{
			Action action = null;
			Action action2 = null;
			Class13 CS_0024_003C_003E8__locals0 = new Class13();
			CS_0024_003C_003E8__locals0.offlineDataStore_0 = this;
			string text = null;
			CS_0024_003C_003E8__locals0.string_0 = null;
			int num2 = 12;
			int num3 = num2;
			while (true)
			{
				MessageBatch messageBatch;
				switch (num3)
				{
				case 20:
					if (1 == 0)
					{
					}
					num2 = 9;
					num3 = num2;
					continue;
				case 19:
					try
					{
						Monitor.Enter(obj = object_0, ref lockTaken);
						using List<string>.Enumerator enumerator = list.GetEnumerator();
						num2 = 4;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 3:
								if (!enumerator.MoveNext())
								{
									num2 = 0;
									num3 = num2;
									continue;
								}
								action3 = null;
								func = null;
								@class = new Class14();
								@class.class13_0 = CS_0024_003C_003E8__locals0;
								@class.string_0 = enumerator.Current;
								num2 = 1;
								num3 = num2;
								continue;
							case 1:
								try
								{
									num2 = 3;
									num3 = num2;
									while (true)
									{
										switch (num3)
										{
										case 12:
											if (func == null)
											{
												num2 = 0;
												num3 = num2;
												continue;
											}
											goto case 4;
										case 4:
											text = Utils.Attempt(func, Logger);
											num2 = 1;
											num3 = num2;
											continue;
										case 11:
											if (!string.IsNullOrEmpty(text))
											{
												num2 = 5;
												num3 = num2;
											}
											else
											{
												num2 = 10;
												num3 = num2;
											}
											continue;
										case 8:
											num2 = 6;
											num3 = num2;
											continue;
										case 7:
											action3 = @class.method_0;
											num2 = 2;
											num3 = num2;
											continue;
										case 5:
											num2 = 9;
											num3 = num2;
											continue;
										default:
										{
											num2 = 15058;
											int num4 = num2;
											num2 = 15058;
											switch (num4 == num2)
											{
											case false:
											case true:
												goto IL_0207;
											}
											if (0 == 0)
											{
											}
											if (action3 == null)
											{
												num2 = 7;
												num3 = num2;
												continue;
											}
											goto case 2;
										}
										case 2:
											Utils.Attempt(action3, Logger);
											goto IL_0207;
										case 1:
											if (text == null)
											{
												num2 = 8;
												num3 = num2;
											}
											else
											{
												CS_0024_003C_003E8__locals0.string_0 = @class.string_0 + "꺀닃";
												num2 = 11;
												num3 = num2;
											}
											continue;
										case 0:
											func = @class.method_1;
											num2 = 4;
											num3 = num2;
											continue;
										case 6:
											break;
										case 10:
											break;
										case 9:
											goto IL_02d1;
											IL_0207:
											num2 = 12;
											num3 = num2;
											continue;
										}
										break;
									}
								}
								catch (Exception exception_)
								{
									Logger.LogExceptionWarning(exception_, "껯닜뚖닇뻐닗뛎닂껋刱嘢刷帺割嘸刽渀牟瘕爀縗爆瘟爑渏刾噶刷带刱嘳刢껚닛뛙닜뺞닝뛕닑껛튠횳튶");
								}
								break;
							case 0:
								goto IL_02d1;
							case 2:
								goto end_IL_0072;
								IL_02d1:
								num2 = 2;
								num3 = num2;
								continue;
							}
							num2 = 3;
							num3 = num2;
							continue;
							end_IL_0072:
							break;
						}
					}
					finally
					{
						num2 = 2;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								if (lockTaken)
								{
									num2 = 1;
									num3 = num2;
									continue;
								}
								break;
							case 1:
								Monitor.Exit(obj);
								num2 = 0;
								num3 = num2;
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					num2 = 15;
					num3 = num2;
					continue;
				case 18:
					if (!list.Any())
					{
						num2 = 13;
						num3 = num2;
					}
					else
					{
						lockTaken = false;
						num2 = 19;
						num3 = num2;
					}
					continue;
				case 17:
					Utils.Attempt(action2, Logger);
					num2 = 7;
					num3 = num2;
					continue;
				case 16:
					num2 = 3;
					num3 = num2;
					continue;
				case 15:
					if (string.IsNullOrEmpty(text))
					{
						num2 = 20;
						num3 = num2;
					}
					else
					{
						messageBatch2 = MessageBatch.FromString(text);
						num2 = 6;
						num3 = num2;
					}
					continue;
				case 14:
					num2 = 8;
					num3 = num2;
					continue;
				case 12:
					list = iofflineStorageManager_0.GetFilesEndingWith("꺀닀뛟닁", "").OrderBy(delegate(string string_0)
					{
						if (1 == 0)
						{
						}
						int num5 = 7122;
						int num6 = num5;
						num5 = 7122;
						switch (num6 == num5)
						{
						default:
							if (0 == 0)
							{
							}
							return string_0;
						}
					}).ToList();
					num2 = 18;
					num3 = num2;
					continue;
				case 10:
					Utils.Attempt(action, Logger);
					num2 = 21;
					num3 = num2;
					continue;
				case 9:
					if (CS_0024_003C_003E8__locals0.string_0 != null)
					{
						num2 = 14;
						num3 = num2;
						continue;
					}
					goto case 21;
				case 8:
					if (action == null)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					goto case 10;
				case 7:
					num2 = 5;
					num3 = num2;
					continue;
				case 6:
					if (messageBatch2 == null)
					{
						num2 = 4;
						num3 = num2;
						continue;
					}
					goto case 7;
				case 5:
					messageBatch = messageBatch2;
					if (messageBatch == null)
					{
						num2 = 11;
						num3 = num2;
						continue;
					}
					goto IL_0645;
				case 4:
					num2 = 1;
					num3 = num2;
					continue;
				case 3:
					if (action2 == null)
					{
						num2 = 0;
						num3 = num2;
						continue;
					}
					goto case 17;
				case 2:
					action = delegate
					{
						if (1 == 0)
						{
						}
						int num7 = -21314;
						int num8 = num7;
						num7 = -21314;
						switch (num8 == num7)
						{
						default:
							if (0 == 0)
							{
							}
							CS_0024_003C_003E8__locals0.offlineDataStore_0.iofflineStorageManager_0.DeleteFile(CS_0024_003C_003E8__locals0.string_0);
							break;
						}
					};
					num2 = 10;
					num3 = num2;
					continue;
				case 1:
					if (CS_0024_003C_003E8__locals0.string_0 != null)
					{
						num2 = 16;
						num3 = num2;
						continue;
					}
					goto case 7;
				case 0:
					action2 = delegate
					{
						int num9 = 23752;
						int num10 = num9;
						num9 = 23752;
						switch (num10 == num9)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							CS_0024_003C_003E8__locals0.offlineDataStore_0.iofflineStorageManager_0.DeleteFile(CS_0024_003C_003E8__locals0.string_0);
							break;
						}
					};
					num2 = 17;
					num3 = num2;
					continue;
				case 11:
					messageBatch = new MessageBatch();
					goto IL_0645;
				case 13:
					return new MessageBatch();
				case 21:
					{
						return new MessageBatch();
					}
					IL_0645:
					return messageBatch;
				}
				break;
			}
		}
	}

	public void ClearBatch(MessageBatch messagebatch)
	{
		int num = 10;
		switch (0)
		{
		default:
		{
			bool lockTaken = false;
			object obj = default(object);
			try
			{
				Action action2 = default(Action);
				Class15 class2 = default(Class15);
				IEnumerator<string> enumerator2 = default(IEnumerator<string>);
				Action action = default(Action);
				Class16 @class = default(Class16);
				while (true)
				{
					Monitor.Enter(obj = object_0, ref lockTaken);
					IEnumerator<string> enumerator = iofflineStorageManager_0.GetFilesEndingWith(messagebatch.ID + "훼틜껛닅", "").GetEnumerator();
					int num2 = 2;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 2:
							try
							{
								num2 = 2;
								num3 = num2;
								while (true)
								{
									switch (num3)
									{
									default:
										num2 = 6;
										num3 = num2;
										continue;
									case 6:
										if (!enumerator.MoveNext())
										{
											num2 = 3;
											num3 = num2;
											continue;
										}
										action2 = null;
										class2 = new Class15();
										class2.offlineDataStore_0 = this;
										class2.string_0 = enumerator.Current;
										num2 = 0;
										num3 = num2;
										continue;
									case 4:
										action2 = class2.method_0;
										num2 = 1;
										num3 = num2;
										continue;
									case 3:
										num2 = 5;
										num3 = num2;
										continue;
									case 1:
										Utils.Attempt(action2, Logger);
										num2 = 7;
										num3 = num2;
										continue;
									case 0:
										if (action2 == null)
										{
											num2 = 4;
											num3 = num2;
											continue;
										}
										goto case 1;
									case 5:
										break;
									}
									break;
								}
							}
							finally
							{
								num2 = 2;
								num3 = num2;
								while (true)
								{
									switch (num3)
									{
									default:
										if (enumerator != null)
										{
											num2 = 1;
											num3 = num2;
											continue;
										}
										break;
									case 1:
										enumerator.Dispose();
										num2 = 0;
										num3 = num2;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							enumerator2 = iofflineStorageManager_0.GetFilesEndingWith(messagebatch.ID + "훼틜껛닅뚜닏", "").GetEnumerator();
							num2 = 1;
							num3 = num2;
							continue;
						case 1:
							try
							{
								num2 = 2;
								num3 = num2;
								while (true)
								{
									switch (num3)
									{
									case 7:
										Utils.Attempt(action, Logger);
										num2 = 6;
										num3 = num2;
										continue;
									default:
										num2 = 3;
										num3 = num2;
										continue;
									case 4:
										action = @class.method_0;
										num2 = 7;
										num3 = num2;
										continue;
									case 3:
										if (!enumerator2.MoveNext())
										{
											num2 = 1;
											num3 = num2;
											continue;
										}
										action = null;
										@class = new Class16();
										@class.offlineDataStore_0 = this;
										@class.string_0 = enumerator2.Current;
										num2 = 0;
										num3 = num2;
										continue;
									case 2:
									{
										num2 = 15737;
										int num4 = num2;
										num2 = 15737;
										switch (num4 == num2)
										{
										default:
											if (0 == 0)
											{
											}
											break;
										case false:
										case true:
											goto end_IL_02dc;
										}
										goto default;
									}
									case 1:
										num2 = 5;
										num3 = num2;
										continue;
									case 0:
										if (action == null)
										{
											num2 = 4;
											num3 = num2;
											continue;
										}
										goto case 7;
									case 5:
										break;
										end_IL_02dc:
										break;
									}
									break;
								}
							}
							finally
							{
								num2 = 2;
								num3 = num2;
								while (true)
								{
									switch (num3)
									{
									default:
										if (enumerator2 != null)
										{
											num2 = 1;
											num3 = num2;
											continue;
										}
										break;
									case 1:
										enumerator2.Dispose();
										num2 = 0;
										num3 = num2;
										continue;
									case 0:
										break;
									}
									break;
								}
							}
							num2 = 0;
							num3 = num2;
							continue;
						case 0:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				int num2 = 2;
				int num3 = num2;
				while (true)
				{
					if (true)
					{
					}
					switch (num3)
					{
					case 1:
						Monitor.Exit(obj);
						num2 = 0;
						num3 = num2;
						continue;
					default:
						if (lockTaken)
						{
							num2 = 1;
							num3 = num2;
							continue;
						}
						break;
					case 0:
						break;
					}
					break;
				}
			}
		}
		}
	}

	public void Dispose()
	{
		int num = 27474;
		int num2 = num;
		num = 27474;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		iofflineStorageManager_0.Dispose();
	}

	[CompilerGenerated]
	private static string smethod_0(string string_0)
	{
		int num = -31502;
		int num2 = num;
		num = -31502;
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
	private static string smethod_1(string string_0)
	{
		if (1 == 0)
		{
		}
		int num = 7122;
		int num2 = num;
		num = 7122;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			return string_0;
		}
	}

	static OfflineDataStore()
	{
		if (1 == 0)
		{
		}
		int num = 13021;
		int num2 = num;
		num = 13021;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		object_0 = new object();
	}
}
