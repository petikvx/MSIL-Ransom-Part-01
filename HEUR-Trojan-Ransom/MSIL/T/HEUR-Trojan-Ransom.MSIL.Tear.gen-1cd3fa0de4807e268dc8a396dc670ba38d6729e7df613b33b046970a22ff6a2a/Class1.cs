using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using PreEmptive.Analytics.Common;

internal sealed class Class1
{
	[CompilerGenerated]
	private sealed class Class2
	{
		public Class1 class1_0;

		public int int_0;
	}

	[CompilerGenerated]
	private sealed class Class3
	{
		public Class2 class2_0;

		public ManualResetEvent manualResetEvent_0;

		public void method_0()
		{
			manualResetEvent_0.WaitOne(class2_0.int_0);
			if (!class2_0.class1_0.bool_1)
			{
				if (1 == 0)
				{
				}
				int num = 18703;
				int num2 = num;
				num = 18703;
				switch (num2 == num)
				{
				default:
					if (0 == 0)
					{
					}
					class2_0.class1_0.action_0(class2_0.class1_0);
					class2_0.class1_0.bool_2 = false;
					class2_0.class1_0.manualResetEvent_1.Set();
					return;
				case false:
				case true:
					break;
				}
			}
			class2_0.class1_0.bool_2 = false;
			class2_0.class1_0.manualResetEvent_1.Set();
		}
	}

	private IAsyncProvider iasyncProvider_0;

	private Action<Class1> action_0;

	private bool bool_0;

	private ManualResetEvent manualResetEvent_0 = new ManualResetEvent(initialState: false);

	private volatile bool bool_1;

	private ManualResetEvent manualResetEvent_1 = new ManualResetEvent(initialState: false);

	private bool bool_2;

	[CompilerGenerated]
	private DateTime dateTime_0;

	public Class1(IAsyncProvider iasyncProvider_1, Action<Class1> action_1, [Optional] bool bool_3)
	{
		iasyncProvider_0 = iasyncProvider_1;
		action_0 = action_1;
		bool_0 = bool_3;
	}

	[SpecialName]
	[CompilerGenerated]
	public DateTime method_0()
	{
		if (1 == 0)
		{
		}
		int num = -24123;
		int num2 = num;
		num = -24123;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			return dateTime_0;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(DateTime dateTime_1)
	{
		int num = 29139;
		int num2 = num;
		num = 29139;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		dateTime_0 = dateTime_1;
	}

	public void method_2(int int_0)
	{
		int num = -32246;
		int num2 = num;
		num = -32246;
		switch (num2 == num)
		{
		case false:
		case true:
			return;
		}
		if (0 == 0)
		{
		}
		switch (0)
		{
		default:
		{
			bool lockTaken = false;
			Class1 obj = default(Class1);
			try
			{
				while (true)
				{
					Monitor.Enter(obj = this, ref lockTaken);
					num = 0;
					int num3 = num;
					ManualResetEvent manualResetEvent_0;
					while (true)
					{
						switch (num3)
						{
						case 3:
							method_3(-1);
							num = 2;
							num3 = num;
							continue;
						case 2:
							method_1(DateTime.UtcNow);
							bool_2 = true;
							bool_1 = false;
							manualResetEvent_0 = this.manualResetEvent_0;
							iasyncProvider_0.ExecuteAsyncIfSupported(delegate
							{
								manualResetEvent_0.WaitOne(int_0);
								if (!bool_1)
								{
									if (1 == 0)
									{
									}
									int num4 = 18703;
									int num5 = num4;
									num4 = 18703;
									switch (num5 == num4)
									{
									default:
										if (0 == 0)
										{
										}
										action_0(this);
										bool_2 = false;
										manualResetEvent_1.Set();
										return;
									case false:
									case true:
										break;
									}
								}
								bool_2 = false;
								manualResetEvent_1.Set();
							}, bool_0);
							num = 1;
							num3 = num;
							continue;
						case 0:
							if (bool_2)
							{
								num = 3;
								num3 = num;
								continue;
							}
							goto case 2;
						case 1:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				num = 0;
				int num3 = num;
				while (true)
				{
					switch (num3)
					{
					case 2:
						Monitor.Exit(obj);
						num = 1;
						num3 = num;
						continue;
					case 0:
						if (true)
						{
						}
						break;
					case 1:
						goto end_IL_017c;
					}
					if (lockTaken)
					{
						num = 2;
						num3 = num;
						continue;
					}
					break;
					continue;
					end_IL_017c:
					break;
				}
			}
		}
		}
	}

	public void method_3([Optional] int int_0)
	{
		bool lockTaken = false;
		Class1 obj = default(Class1);
		try
		{
			while (true)
			{
				Monitor.Enter(obj = this, ref lockTaken);
				int num = 0;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						bool_2 = false;
						bool_1 = true;
						manualResetEvent_0.Set();
						manualResetEvent_0 = new ManualResetEvent(initialState: false);
						manualResetEvent_1.WaitOne(int_0);
						manualResetEvent_1 = new ManualResetEvent(initialState: false);
						num = 2;
						num2 = num;
						continue;
					case 2:
						num = 1;
						num2 = num;
						continue;
					case 0:
					{
						num = -25104;
						int num3 = num;
						num = -25104;
						switch (num3 == num)
						{
						case false:
						case true:
							break;
						default:
							if (0 == 0)
							{
							}
							if (bool_2)
							{
								num = 3;
								num2 = num;
								continue;
							}
							break;
						}
						goto case 2;
					}
					case 1:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			int num = 2;
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
					if (1 == 0)
					{
					}
					Monitor.Exit(obj);
					num = 1;
					num2 = num;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
	}

	[SpecialName]
	public bool method_4()
	{
		bool lockTaken = false;
		Class1 obj = default(Class1);
		try
		{
			Monitor.Enter(obj = this, ref lockTaken);
			return bool_2;
		}
		finally
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!lockTaken)
					{
						goto end_IL_009c;
					}
					break;
				case 0:
				{
					if (1 == 0)
					{
					}
					Monitor.Exit(obj);
					num = -6228;
					int num3 = num;
					num = -6228;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num = 1;
						num2 = num;
						continue;
					}
					break;
				}
				case 1:
					goto end_IL_009c;
				}
				num = 0;
				num2 = num;
				continue;
				end_IL_009c:
				break;
			}
		}
	}

	public void method_5()
	{
		int num = -20320;
		int num2 = num;
		num = -20320;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		manualResetEvent_1.WaitOne();
	}
}
