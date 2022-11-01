using System;
using System.Collections.Generic;

namespace xClient.Core.MouseKeyHook.HotKeys;

public sealed class HotKeySetCollection : List<HotKeySet>
{
	private delegate void KeyChainHandler(KeyEventArgsExt kex);

	private KeyChainHandler m_keyChain;

	public new void Add(HotKeySet hks)
	{
		m_keyChain = (KeyChainHandler)Delegate.Combine(m_keyChain, new KeyChainHandler(hks.OnKey));
		base.Add(hks);
	}

	public new void Remove(HotKeySet hks)
	{
		m_keyChain = (KeyChainHandler)Delegate.Remove(m_keyChain, new KeyChainHandler(hks.OnKey));
		base.Remove(hks);
	}

	internal void OnKey(KeyEventArgsExt e)
	{
		if (m_keyChain != null)
		{
			m_keyChain(e);
		}
	}
}
