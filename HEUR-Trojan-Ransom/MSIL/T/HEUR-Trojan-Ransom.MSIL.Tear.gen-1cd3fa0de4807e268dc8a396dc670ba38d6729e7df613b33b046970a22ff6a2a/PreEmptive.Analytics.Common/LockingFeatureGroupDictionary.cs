using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace PreEmptive.Analytics.Common;

public class LockingFeatureGroupDictionary : IFeatureGroupDictionary
{
	public IDictionary<string, IList<FeatureGroup>> Groups;

	private object object_0 = new object();

	public LockingFeatureGroupDictionary([Optional] IDictionary<string, IList<FeatureGroup>> groups)
	{
		Groups = groups ?? new Dictionary<string, IList<FeatureGroup>>();
	}

	public FeatureGroup TryRemove(string name, string partitionid, out bool foundpartition)
	{
		switch (0)
		{
		default:
		{
			if (1 == 0)
			{
			}
			foundpartition = false;
			bool lockTaken = false;
			object obj = default(object);
			try
			{
				FeatureGroup result = default(FeatureGroup);
				bool lockTaken2 = default(bool);
				IList<FeatureGroup> obj2 = default(IList<FeatureGroup>);
				FeatureGroup featureGroup = default(FeatureGroup);
				int num3 = default(int);
				FeatureGroup featureGroup2 = default(FeatureGroup);
				while (true)
				{
					Monitor.Enter(obj = object_0, ref lockTaken);
					IList<FeatureGroup> list = method_1(name);
					int num = 0;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							result = null;
							num = 2;
							num2 = num;
							continue;
						case 0:
							if (list == null)
							{
								num = 3;
								num2 = num;
							}
							else
							{
								lockTaken2 = false;
								num = 1;
								num2 = num;
							}
							continue;
						case 1:
							try
							{
								while (true)
								{
									Monitor.Enter(obj2 = list, ref lockTaken2);
									num = 5;
									num2 = num;
									while (true)
									{
										switch (num2)
										{
										case 16:
											if (list.Count == 0)
											{
												num = 10;
												num2 = num;
												continue;
											}
											goto case 12;
										case 12:
											result = featureGroup;
											num = 8;
											num2 = num;
											continue;
										case 15:
											foundpartition = true;
											list.RemoveAt(num3);
											num = 14;
											num2 = num;
											continue;
										case 14:
											if (list.Count == 0)
											{
												num = 6;
												num2 = num;
												continue;
											}
											goto case 2;
										case 2:
											result = featureGroup2;
											num = 1;
											num2 = num;
											continue;
										case 11:
										case 13:
											num = 9;
											num2 = num;
											continue;
										case 10:
											Groups.Remove(name);
											num = 12;
											num2 = num;
											continue;
										case 9:
											if (num3 < 0)
											{
												num = 3;
												num2 = num;
											}
											else
											{
												featureGroup2 = list[num3];
												num = 4;
												num2 = num;
											}
											continue;
										case 6:
											Groups.Remove(name);
											num = 2;
											num2 = num;
											continue;
										case 5:
											if (list.Count == 0)
											{
												num = 0;
												num2 = num;
											}
											else
											{
												num3 = list.Count - 1;
												num = 13;
												num2 = num;
											}
											continue;
										case 4:
											if (featureGroup2.PartitionId == partitionid)
											{
												num = 15;
												num2 = num;
											}
											else
											{
												num3--;
												num = 11;
												num2 = num;
											}
											continue;
										case 3:
											featureGroup = list[list.Count - 1];
											list.RemoveAt(list.Count - 1);
											num = 16;
											num2 = num;
											continue;
										case 0:
											Groups.Remove(name);
											result = null;
											num = 7;
											num2 = num;
											continue;
										case 1:
											return result;
										case 7:
											return result;
										case 8:
											return result;
										}
										break;
									}
								}
							}
							finally
							{
								num = 0;
								num2 = num;
								while (true)
								{
									switch (num2)
									{
									case 2:
										Monitor.Exit(obj2);
										num = 1;
										num2 = num;
										continue;
									default:
										if (lockTaken2)
										{
											num = 2;
											num2 = num;
											continue;
										}
										break;
									case 1:
										break;
									}
									break;
								}
							}
						case 2:
							return result;
						}
						break;
					}
				}
			}
			finally
			{
				int num = -1526;
				int num4 = num;
				num = -1526;
				int num2;
				switch (num4 == num)
				{
				default:
					if (0 == 0)
					{
					}
					num = 0;
					num2 = num;
					goto IL_03b2;
				case false:
				case true:
					{
						num = 2;
						num2 = num;
						goto IL_03b2;
					}
					IL_03b2:
					while (true)
					{
						switch (num2)
						{
						case 2:
							goto IL_039b;
						default:
							if (!lockTaken)
							{
								goto end_IL_03b2;
							}
							break;
						case 1:
							goto end_IL_03b2;
						}
						goto case false;
						IL_039b:
						Monitor.Exit(obj);
						num = 1;
						num2 = num;
						continue;
						end_IL_03b2:
						break;
					}
					break;
				}
			}
		}
		}
	}

	public void Add(string name, FeatureGroup adder)
	{
		if (1 == 0)
		{
		}
		IList<FeatureGroup> list = null;
		list = method_0(name);
		bool lockTaken = false;
		IList<FeatureGroup> obj = default(IList<FeatureGroup>);
		try
		{
			Monitor.Enter(obj = list, ref lockTaken);
			list.Add(adder);
		}
		finally
		{
			int num = 3178;
			int num2 = num;
			num = 3178;
			int num3;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				num = 0;
				num3 = num;
				goto IL_008f;
			case false:
			case true:
				{
					num = 2;
					num3 = num;
					goto IL_008f;
				}
				IL_008f:
				while (true)
				{
					switch (num3)
					{
					case 2:
						goto IL_007a;
					default:
						if (!lockTaken)
						{
							goto end_IL_008f;
						}
						break;
					case 1:
						goto end_IL_008f;
					}
					goto case false;
					IL_007a:
					Monitor.Exit(obj);
					num = 1;
					num3 = num;
					continue;
					end_IL_008f:
					break;
				}
				break;
			}
		}
	}

	private IList<FeatureGroup> method_0(string string_0)
	{
		switch (0)
		{
		default:
		{
			bool lockTaken = false;
			object obj = default(object);
			IList<FeatureGroup> list = default(IList<FeatureGroup>);
			try
			{
				IList<FeatureGroup> result = default(IList<FeatureGroup>);
				while (true)
				{
					IL_00d1:
					Monitor.Enter(obj = object_0, ref lockTaken);
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 2:
							list = new List<FeatureGroup>();
							Groups[string_0] = list;
							result = list;
							num = 3;
							num2 = num;
							continue;
						case 1:
						{
							if (!Groups.ContainsKey(string_0))
							{
								num = 2;
								num2 = num;
								continue;
							}
							num = -6879;
							int num3 = num;
							num = -6879;
							switch (num3 == num)
							{
							default:
								if (0 == 0)
								{
								}
								list = Groups[string_0];
								num = 0;
								num2 = num;
								continue;
							case false:
							case true:
								break;
							}
							break;
						}
						case 0:
							goto end_IL_00ba;
						case 3:
							return result;
						}
						goto IL_00d1;
						continue;
						end_IL_00ba:
						break;
					}
					break;
				}
			}
			finally
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (lockTaken)
						{
							num = 0;
							num2 = num;
							continue;
						}
						break;
					case 0:
						Monitor.Exit(obj);
						num = 2;
						num2 = num;
						continue;
					case 2:
						break;
					}
					break;
				}
			}
			if (1 == 0)
			{
			}
			return list;
		}
		}
	}

	private IList<FeatureGroup> method_1(string string_0)
	{
		switch (0)
		{
		default:
		{
			bool lockTaken = false;
			object obj = default(object);
			IList<FeatureGroup> result2 = default(IList<FeatureGroup>);
			try
			{
				IList<FeatureGroup> result = default(IList<FeatureGroup>);
				while (true)
				{
					IL_00be:
					Monitor.Enter(obj = object_0, ref lockTaken);
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 2:
							result = null;
							num = 3;
							num2 = num;
							continue;
						case 1:
						{
							if (!Groups.ContainsKey(string_0))
							{
								num = 2;
								num2 = num;
								continue;
							}
							num = 25477;
							int num3 = num;
							num = 25477;
							switch (num3 == num)
							{
							default:
								if (0 == 0)
								{
								}
								result2 = Groups[string_0];
								num = 0;
								num2 = num;
								continue;
							case false:
							case true:
								break;
							}
							break;
						}
						case 0:
							goto end_IL_00a7;
						case 3:
							return result;
						}
						goto IL_00be;
						continue;
						end_IL_00a7:
						break;
					}
					break;
				}
			}
			finally
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (lockTaken)
						{
							num = 0;
							num2 = num;
							continue;
						}
						break;
					case 0:
						Monitor.Exit(obj);
						num = 2;
						num2 = num;
						continue;
					case 2:
						break;
					}
					break;
				}
			}
			if (1 == 0)
			{
			}
			return result2;
		}
		}
	}
}
