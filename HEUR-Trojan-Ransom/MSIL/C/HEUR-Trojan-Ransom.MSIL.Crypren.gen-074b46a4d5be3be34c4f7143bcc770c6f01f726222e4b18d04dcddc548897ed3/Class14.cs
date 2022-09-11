using System;
using System.Collections;
using System.Collections.Generic;

internal class Class14 : IEnumerable<Class23>, IList<Class23>, ICollection<Class23>, IEnumerable
{
	private readonly Class23 class23_0;

	private readonly List<Class23> list_0 = new List<Class23>();

	public int this[Class23 node]
	{
		get
		{
			int num = Delegate344.smethod_0(this, node);
			if (num == -1)
			{
				throw new ArgumentOutOfRangeException(Class86.smethod_0("\ueb91\ueb90\ueb9b\ueb9a", 60337), Class86.smethod_0("\ued21\ued00\ued0b\ued0a\ued4f\ued4d", 60750) + Delegate225.smethod_0(Delegate224.smethod_0(node, (byte)Class84.smethod_0(0) != 0)) + Class86.smethod_0("\ue4fd\ue4ff\ue4a8\ue4be\ue4ac\ue4ff\ue4b1\ue4b0\ue4ab\ue4ff\ue4b9\ue4b0\ue4aa\ue4b1\ue4bb\ue4ff\ue4b6\ue4b1\ue4ff\ue4ab\ue4b7\ue4ba\ue4ff\ue4bc\ue4b0\ue4b3\ue4b3\ue4ba\ue4bc\ue4ab\ue4b6\ue4b0\ue4b1", 58577));
			}
			return num;
		}
	}

	public Class23 this[string nodeName]
	{
		get
		{
			nodeName = nodeName.ToLower();
			int num = Class84.smethod_0(0);
			while (true)
			{
				if (num < list_0.Count)
				{
					if (list_0[num].Equals(nodeName) || 1 == 0)
					{
						break;
					}
					num += Class84.smethod_0(1);
					continue;
				}
				return null;
			}
			return list_0[num];
		}
	}

	public int Count => list_0.Count;

	public bool IsReadOnly => (byte)Class84.smethod_0(0) != 0;

	public Class23 this[int index]
	{
		get
		{
			return list_0[index];
		}
		set
		{
			list_0[index] = value;
		}
	}

	public Class14(Class23 class23_1)
	{
		class23_0 = class23_1;
	}

	public void Add(Class23 node)
	{
		list_0.Add(node);
	}

	public void Clear()
	{
		using (List<Class23>.Enumerator enumerator = list_0.GetEnumerator())
		{
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				while (true)
				{
					int num = Class89.smethod_1(52);
					while (true)
					{
						switch (num ^ Class84.smethod_0(48))
						{
						case -105:
							Delegate345.smethod_0(current, null);
							num = -16;
							continue;
						case -106:
							num = -13;
							continue;
						case -107:
							Delegate346.smethod_0(current, null);
							num = Class46.Class47.smethod_0(75);
							continue;
						case -104:
							goto end_IL_005f;
						}
						break;
					}
					continue;
					end_IL_005f:
					break;
				}
				Delegate347.smethod_0(current, null);
			}
		}
		list_0.Clear();
	}

	public bool Contains(Class23 item)
	{
		return list_0.Contains(item);
	}

	public void CopyTo(Class23[] array, int arrayIndex)
	{
		list_0.CopyTo(array, arrayIndex);
	}

	IEnumerator<Class23> IEnumerable<Class23>.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return list_0.GetEnumerator();
	}

	public int IndexOf(Class23 item)
	{
		return list_0.IndexOf(item);
	}

	public void Insert(int index, Class23 node)
	{
		Class23 @class = null;
		Class23 class2 = default(Class23);
		while (true)
		{
			int num = Class84.smethod_0(75);
			while (true)
			{
				switch (num ^ Class84.smethod_0(407))
				{
				case 103:
					if (index > Class84.smethod_0(0))
					{
						num = 6;
						continue;
					}
					goto IL_0064;
				case 102:
					class2 = null;
					num = 9;
					continue;
				case 101:
					num = Class84.smethod_0(20);
					continue;
				case 104:
					{
						class2 = list_0[index - Class84.smethod_0(1)];
						goto IL_0064;
					}
					IL_0064:
					if (index < list_0.Count)
					{
						@class = list_0[index];
					}
					list_0.Insert(index, node);
					if (class2 != null || 1 == 0)
					{
						if (node == class2)
						{
							throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
						}
						class2.class23_1 = node;
					}
					if (@class != null || 1 == 0)
					{
						@class.class23_3 = node;
					}
					node.class23_3 = class2;
					if (@class == node)
					{
						throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
					}
					node.class23_1 = @class;
					node.class23_2 = class23_0;
					return;
				}
				break;
			}
		}
	}

	public bool Remove(Class23 item)
	{
		int int_ = list_0.IndexOf(item);
		Delegate348.smethod_0(this, int_);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public void RemoveAt(int index)
	{
		Class23 @class = null;
		Class23 class3 = default(Class23);
		Class23 class2 = default(Class23);
		while (true)
		{
			int num = Class84.smethod_0(0);
			while (true)
			{
				switch (num ^ Class84.smethod_0(412))
				{
				case 111:
					class3 = list_0[index];
					num = 1;
					continue;
				case 110:
					num = 2;
					continue;
				case 109:
					if (index > Class84.smethod_0(0))
					{
						num = Class84.smethod_0(396);
						continue;
					}
					goto IL_007a;
				case 108:
					class2 = null;
					num = 3;
					continue;
				case 112:
					{
						class2 = list_0[index - Class84.smethod_0(1)];
						goto IL_007a;
					}
					IL_007a:
					if (index < list_0.Count - Class84.smethod_0(1))
					{
						@class = list_0[index + Class84.smethod_0(1)];
					}
					list_0.RemoveAt(index);
					if (class2 != null || 1 == 0)
					{
						if (@class == class2)
						{
							throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
						}
						class2.class23_1 = @class;
					}
					if (@class != null || 1 == 0)
					{
						@class.class23_3 = class2;
					}
					class3.class23_3 = null;
					class3.class23_1 = null;
					class3.class23_2 = null;
					return;
				}
				break;
			}
		}
	}

	public static Class23 smethod_0(Class14 class14_0, string string_0)
	{
		IEnumerator<Class23> enumerator = ((IEnumerable<Class23>)class14_0).GetEnumerator();
		try
		{
			Class23 @class = default(Class23);
			while (enumerator.MoveNext() ? true : false)
			{
				Class23 current = enumerator.Current;
				if ((!Delegate207.smethod_0(current).ToLower().Contains(string_0)) ? true : false)
				{
					if ((!Delegate218.smethod_0(current)) ? true : false)
					{
						continue;
					}
					while (true)
					{
						int num = Class89.smethod_2(92);
						while (true)
						{
							switch (num ^ Class84.smethod_0(67))
							{
							case -97:
								break;
							case -98:
								num = -10;
								continue;
							case -99:
								@class = Delegate349.smethod_0(Delegate203.smethod_0(current), string_0);
								num = -9;
								continue;
							default:
								goto end_IL_0063;
							case -96:
								goto IL_00b5;
							}
							if (@class != null)
							{
								num = -56;
								continue;
							}
							if (true)
							{
								goto end_IL_0089;
							}
							goto IL_00b5;
							IL_00b5:
							return @class;
							continue;
							end_IL_0063:
							break;
						}
						continue;
						end_IL_0089:
						break;
					}
					continue;
				}
				return current;
			}
		}
		finally
		{
			if (enumerator != null || 1 == 0)
			{
				enumerator.Dispose();
			}
		}
		return null;
	}

	public void method_0(Class23 class23_1)
	{
		Class23 @class = null;
		if (list_0.Count > Class84.smethod_0(0))
		{
			@class = list_0[list_0.Count - Class84.smethod_0(1)];
		}
		list_0.Add(class23_1);
		while (true)
		{
			int num = Class89.smethod_1(57);
			int num2 = Class89.smethod_1(52);
			while (true)
			{
				num2 ^= Class84.smethod_0(411);
				while (true)
				{
					int num3 = Class84.smethod_0(5);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(410))
						{
						case 113:
							break;
						case 112:
							num3 = Class84.smethod_0(55);
							continue;
						case 111:
							goto IL_0061;
						default:
							goto end_IL_00f0;
						case 114:
							goto end_IL_0116;
						}
						goto IL_0044;
						IL_0061:
						switch (num2)
						{
						case -102:
							goto IL_007f;
						case -99:
							goto IL_00de;
						case -100:
							goto IL_0124;
						case -101:
							goto end_IL_0127;
						}
						num3 = 24;
						continue;
						IL_0124:
						num2 = -13;
						goto end_IL_0116;
						IL_007f:
						switch (num)
						{
						case -111:
							break;
						case -110:
							goto IL_00ad;
						case -109:
							goto IL_00be;
						case -108:
							goto IL_00c3;
						case -107:
							goto IL_00d4;
						default:
							goto IL_011f;
						case -106:
							goto IL_014e;
						}
						if (@class != null)
						{
							num = -3;
							goto IL_00de;
						}
						if (true)
						{
							return;
						}
						goto IL_014e;
						IL_011f:
						num2 = -12;
						goto end_IL_0116;
						IL_00d4:
						class23_1.class23_1 = null;
						num = -7;
						goto IL_00de;
						IL_00c3:
						class23_1.class23_3 = @class;
						num = Class49.smethod_0(83);
						goto IL_00de;
						IL_00be:
						num = -8;
						goto IL_00de;
						IL_00ad:
						class23_1.class23_2 = class23_0;
						num = -6;
						goto IL_00de;
						IL_014e:
						if (@class == class23_1)
						{
							throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
						}
						@class.class23_1 = class23_1;
						return;
						IL_0044:
						num2 = Class89.smethod_2(92);
						num3 = 27;
						continue;
						IL_00de:
						num ^= Class84.smethod_0(414);
						goto IL_0044;
						continue;
						end_IL_00f0:
						break;
					}
					continue;
					end_IL_0116:
					break;
				}
				continue;
				end_IL_0127:
				break;
			}
		}
	}

	public Class23 method_1(string string_0)
	{
		return Delegate349.smethod_0(this, string_0);
	}

	public int method_2(Class23 class23_1)
	{
		int num = Class84.smethod_0(0);
		while (true)
		{
			if (num < list_0.Count)
			{
				if (class23_1 == list_0[num])
				{
					break;
				}
				num += Class84.smethod_0(1);
				continue;
			}
			return -1;
		}
		return num;
	}

	public void method_3(Class23 class23_1)
	{
		Class23 @class = null;
		if (list_0.Count > Class84.smethod_0(0))
		{
			@class = list_0[Class84.smethod_0(0)];
		}
		list_0.Insert(Class84.smethod_0(0), class23_1);
		if (class23_1 == @class)
		{
			throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
		}
		class23_1.class23_1 = @class;
		while (true)
		{
			int num = Class89.smethod_1(55);
			int num2 = -13;
			while (true)
			{
				num2 ^= Class84.smethod_0(411);
				while (true)
				{
					int num3 = Class89.smethod_2(93);
					while (true)
					{
						switch (num3 ^ Class84.smethod_0(407))
						{
						case -113:
							break;
						case -114:
							goto IL_00dd;
						case -115:
							num3 = -29;
							continue;
						default:
							goto end_IL_00ed;
						case -112:
							goto end_IL_0113;
						}
						switch (num2)
						{
						case -101:
							goto IL_0081;
						case -100:
							goto IL_00d3;
						case -103:
							goto IL_011d;
						case -102:
							goto end_IL_012a;
						}
						num3 = Class49.smethod_0(80);
						continue;
						IL_00d3:
						num ^= Class84.smethod_0(51);
						goto IL_00dd;
						IL_011d:
						num2 = Class46.Class47.smethod_0(76);
						goto end_IL_0113;
						IL_0081:
						switch (num)
						{
						case -107:
							break;
						case -106:
							if (@class != null)
							{
								goto IL_00b5;
							}
							if (true)
							{
								return;
							}
							goto case -103;
						case -105:
							goto IL_00ba;
						case -104:
							goto IL_00bf;
						default:
							goto IL_0127;
						case -103:
							@class.class23_3 = class23_1;
							return;
						}
						class23_1.class23_3 = null;
						num = -11;
						goto IL_00d3;
						IL_0127:
						num2 = -11;
						goto end_IL_0113;
						IL_00bf:
						class23_1.class23_2 = class23_0;
						num = Class89.smethod_1(60);
						goto IL_00d3;
						IL_00ba:
						num = -6;
						goto IL_00d3;
						IL_00b5:
						num = -12;
						goto IL_00d3;
						IL_00dd:
						num2 = Class89.smethod_1(66);
						num3 = -2;
						continue;
						end_IL_00ed:
						break;
					}
					continue;
					end_IL_0113:
					break;
				}
				continue;
				end_IL_012a:
				break;
			}
		}
	}

	public bool method_4(int int_0)
	{
		Delegate348.smethod_0(this, int_0);
		return (byte)Class84.smethod_0(1) != 0;
	}

	public void method_5(int int_0, Class23 class23_1)
	{
		Class23 @class = null;
		Class23 class2 = null;
		Class23 class3 = default(Class23);
		while (true)
		{
			int num = Class84.smethod_0(43);
			while (true)
			{
				switch (num ^ Class84.smethod_0(59))
				{
				case 109:
					num = 28;
					continue;
				case 108:
					class3 = list_0[int_0];
					num = 26;
					continue;
				case 107:
					if (int_0 > Class84.smethod_0(0))
					{
						num = Class84.smethod_0(91);
						continue;
					}
					goto IL_0076;
				case 110:
					{
						class2 = list_0[int_0 - Class84.smethod_0(1)];
						goto IL_0076;
					}
					IL_0076:
					if (int_0 < list_0.Count - Class84.smethod_0(1))
					{
						@class = list_0[int_0 + Class84.smethod_0(1)];
					}
					list_0[int_0] = class23_1;
					if (class2 != null || 1 == 0)
					{
						if (class23_1 == class2)
						{
							throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
						}
						class2.class23_1 = class23_1;
					}
					if (@class != null || 1 == 0)
					{
						@class.class23_3 = class23_1;
					}
					class23_1.class23_3 = class2;
					if (@class == class23_1)
					{
						throw new InvalidProgramException(Class86.smethod_0("\uf2ce\uf2f5\uf2fe\uf2e3\uf2eb\uf2fe\uf2f8\uf2ef\uf2fe\uf2ff\uf2bb\uf2fe\uf2e9\uf2e9\uf2f4\uf2e9\uf2b5", 61978));
					}
					class23_1.class23_1 = @class;
					while (true)
					{
						int num2 = Class94.smethod_0(108);
						int num3 = -19;
						while (true)
						{
							switch (num3 ^ Class84.smethod_0(413))
							{
							case -98:
								num2 ^= Class84.smethod_0(59);
								goto default;
							default:
								num3 = Class89.smethod_2(90);
								continue;
							case -99:
								num3 = Class46.Class47.smethod_0(79);
								continue;
							case -100:
								switch (num2)
								{
								default:
									num3 = -24;
									continue;
								case -101:
									num2 = -22;
									break;
								case -100:
									class23_1.class23_2 = class23_0;
									num2 = -18;
									break;
								case -99:
									class3.class23_1 = null;
									num2 = Class89.smethod_2(90);
									break;
								case -98:
									class3.class23_2 = null;
									num2 = -47;
									break;
								case -97:
									class3.class23_3 = null;
									num2 = -20;
									break;
								case -96:
									return;
								}
								goto case -98;
							case -101:
								break;
							}
							break;
						}
					}
				}
				break;
			}
		}
	}

	public IEnumerable<Class23> method_6()
	{
		Class15 @class = Delegate350.smethod_0(Class84.smethod_0(134));
		@class.class14_0 = this;
		return @class;
	}

	public IEnumerable<Class23> method_7()
	{
		Class16 @class = Delegate351.smethod_0(Class84.smethod_0(134));
		@class.class14_0 = this;
		return @class;
	}

	public IEnumerable<Class23> method_8(string string_0)
	{
		Class17 @class = Delegate352.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class49.smethod_0(81);
			while (true)
			{
				switch (num ^ Class84.smethod_0(50))
				{
				case -100:
					num = -18;
					continue;
				case -101:
					@class.class14_0 = this;
					num = -24;
					continue;
				case -102:
					@class.string_1 = string_0;
					num = -17;
					continue;
				case -99:
					return @class;
				}
				break;
			}
		}
	}

	public IEnumerable<Class23> method_9()
	{
		Class18 @class = Delegate353.smethod_0(Class84.smethod_0(134));
		@class.class14_0 = this;
		return @class;
	}

	public IEnumerable<Class23> method_10(string string_0)
	{
		Class19 @class = Delegate354.smethod_0(Class84.smethod_0(134));
		while (true)
		{
			int num = Class89.smethod_2(90);
			while (true)
			{
				switch (num ^ Class84.smethod_0(60))
				{
				case -99:
					@class.string_1 = string_0;
					num = -22;
					continue;
				case -100:
					num = -24;
					continue;
				case -101:
					@class.class14_0 = this;
					num = Class49.smethod_0(81);
					continue;
				case -98:
					return @class;
				}
				break;
			}
		}
	}

	public IEnumerable<Class23> method_11()
	{
		Class20 @class = Delegate355.smethod_0(Class84.smethod_0(134));
		@class.class14_0 = this;
		return @class;
	}
}
