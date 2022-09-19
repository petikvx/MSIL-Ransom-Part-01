using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class GClass4
{
	public delegate void GDelegate1(object sender, GEventArgs3 e);

	private readonly IEnumerable<Keys> ienumerable_0;

	private readonly Dictionary<Keys, bool> dictionary_0;

	private readonly Dictionary<Keys, Keys> dictionary_1;

	private bool bool_0 = true;

	private int int_0;

	private int int_1;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private GDelegate1 gdelegate1_0;

	[CompilerGenerated]
	private GDelegate1 gdelegate1_1;

	[CompilerGenerated]
	private GDelegate1 gdelegate1_2;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public IEnumerable<Keys> HotKeys => ienumerable_0;

	public bool HotKeysActivated => int_0 == dictionary_0.Count - int_1;

	public bool Enabled
	{
		get
		{
			return bool_0;
		}
		set
		{
			if (value)
			{
				method_1();
			}
			bool_0 = value;
		}
	}

	public event GDelegate1 Event_0
	{
		[CompilerGenerated]
		add
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate1 gDelegate = gdelegate1_0;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_0, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate1 Event_1
	{
		[CompilerGenerated]
		add
		{
			GDelegate1 gDelegate = gdelegate1_1;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_1, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate1 gDelegate = gdelegate1_1;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_1, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public event GDelegate1 Event_2
	{
		[CompilerGenerated]
		add
		{
			GDelegate1 gDelegate = gdelegate1_2;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Combine(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_2, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
		[CompilerGenerated]
		remove
		{
			GDelegate1 gDelegate = gdelegate1_2;
			GDelegate1 gDelegate2;
			do
			{
				gDelegate2 = gDelegate;
				GDelegate1 value2 = (GDelegate1)Delegate.Remove(gDelegate2, value);
				gDelegate = Interlocked.CompareExchange(ref gdelegate1_2, value2, gDelegate2);
			}
			while ((object)gDelegate != gDelegate2);
		}
	}

	public GClass4(IEnumerable<Keys> hotkeys)
	{
		dictionary_0 = new Dictionary<Keys, bool>();
		dictionary_1 = new Dictionary<Keys, Keys>();
		ienumerable_0 = hotkeys;
		method_1();
	}

	private void method_0(GDelegate1 hotKeyDelegate)
	{
		hotKeyDelegate?.Invoke(this, new GEventArgs3(DateTime.Now));
	}

	private void method_1()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		foreach (Keys hotKey in HotKeys)
		{
			if (dictionary_0.ContainsKey(hotKey))
			{
				dictionary_0.Add(hotKey, value: false);
			}
			dictionary_0[hotKey] = Class22.smethod_0().method_1(hotKey);
		}
	}

	public bool method_2(Keys anyKeyInTheExclusiveOrSet)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		Keys val = method_4(anyKeyInTheExclusiveOrSet);
		if ((int)val != 0 && dictionary_1.ContainsValue(val))
		{
			List<Keys> list = new List<Keys>();
			foreach (KeyValuePair<Keys, Keys> item in dictionary_1)
			{
				if (item.Value == val)
				{
					list.Add(item.Key);
				}
			}
			foreach (Keys item2 in list)
			{
				dictionary_1.Remove(item2);
			}
			int_1--;
			return true;
		}
		return false;
	}

	public Keys method_3(IEnumerable<Keys> orKeySet)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		foreach (Keys item in orKeySet)
		{
			if (!dictionary_0.ContainsKey(item))
			{
				return (Keys)0;
			}
		}
		int num = 0;
		Keys val = (Keys)0;
		foreach (Keys item2 in orKeySet)
		{
			if (num == 0)
			{
				val = item2;
			}
			dictionary_1[item2] = val;
			num++;
		}
		int_1++;
		return val;
	}

	private Keys method_4(Keys k)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!dictionary_1.ContainsKey(k))
		{
			return (Keys)0;
		}
		return dictionary_1[k];
	}

	private Keys method_5(Keys k)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!dictionary_1.ContainsKey(k))
		{
			return k;
		}
		return dictionary_1[k];
	}

	internal void method_6(GEventArgs0 kex)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (Enabled)
		{
			Keys k = method_5(((KeyEventArgs)kex).get_KeyCode());
			if (kex.IsKeyDown)
			{
				method_7(k);
			}
			else
			{
				method_8(k);
			}
		}
	}

	private void method_7(Keys k)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (HotKeysActivated)
		{
			method_0(gdelegate1_0);
		}
		else if (dictionary_0.ContainsKey(k) && !dictionary_0[k])
		{
			dictionary_0[k] = true;
			int_0++;
			if (HotKeysActivated)
			{
				method_0(gdelegate1_2);
			}
		}
	}

	private void method_8(Keys k)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (dictionary_0.ContainsKey(k) && dictionary_0[k])
		{
			bool hotKeysActivated = HotKeysActivated;
			dictionary_0[k] = false;
			int_0--;
			if (hotKeysActivated)
			{
				method_0(gdelegate1_1);
			}
		}
	}
}
