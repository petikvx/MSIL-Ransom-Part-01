using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;

internal sealed class FontEvents_EventProvider : IDisposable, FontEvents_Event
{
	private UCOMIConnectionPointContainer m_ConnectionPointContainer;

	private ArrayList m_aEventSinkHelpers;

	private UCOMIConnectionPoint m_ConnectionPoint;

	public override event FontEvents_FontChangedEventHandler FontChanged
	{
		add
		{
			Monitor.Enter(this);
			try
			{
				if (m_ConnectionPoint == null)
				{
					_003CFixedUpdate_003Eb__4_0Initializeset_Assembly();
				}
				FontEvents_SinkHelper fontEvents_SinkHelper = new FontEvents_SinkHelper();
				int dwCookie = 0;
				m_ConnectionPoint.Advise((object)fontEvents_SinkHelper, ref dwCookie);
				fontEvents_SinkHelper.m_dwCookie = dwCookie;
				fontEvents_SinkHelper.m_FontChangedDelegate = value;
				m_aEventSinkHelpers.Add(fontEvents_SinkHelper);
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
		remove
		{
			Monitor.Enter(this);
			try
			{
				int count = m_aEventSinkHelpers.Count;
				int num = 0;
				if (0 >= count)
				{
					return;
				}
				FontEvents_SinkHelper fontEvents_SinkHelper;
				while (true)
				{
					fontEvents_SinkHelper = (FontEvents_SinkHelper)m_aEventSinkHelpers[num];
					if (fontEvents_SinkHelper.m_FontChangedDelegate == null || ((fontEvents_SinkHelper.m_FontChangedDelegate.Equals(value) ? 1u : 0u) & 0xFFu) == 0)
					{
						num++;
						if (num >= count)
						{
							return;
						}
						continue;
					}
					break;
				}
				m_aEventSinkHelpers.RemoveAt(num);
				m_ConnectionPoint.Unadvise(fontEvents_SinkHelper.m_dwCookie);
				if (count <= 1)
				{
					m_ConnectionPoint = null;
					m_aEventSinkHelpers = null;
				}
			}
			finally
			{
				Monitor.Exit(this);
			}
		}
	}

	private void _003CFixedUpdate_003Eb__4_0Initializeset_Assembly()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		UCOMIConnectionPoint val = null;
		Guid guid = new Guid(new byte[16]
		{
			10, 16, 246, 78, 136, 175, 208, 17, 152, 70,
			0, 192, 79, 194, 153, 147
		});
		m_ConnectionPointContainer.FindConnectionPoint(ref guid, ref val);
		m_ConnectionPoint = val;
		m_aEventSinkHelpers = new ArrayList();
	}

	public FontEvents_EventProvider(object A_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		m_ConnectionPointContainer = (UCOMIConnectionPointContainer)A_1;
	}

	public override void Finalize()
	{
		Monitor.Enter(this);
		try
		{
			if (m_ConnectionPoint == null)
			{
				return;
			}
			int count = m_aEventSinkHelpers.Count;
			int num = 0;
			if (0 < count)
			{
				do
				{
					FontEvents_SinkHelper fontEvents_SinkHelper = (FontEvents_SinkHelper)m_aEventSinkHelpers[num];
					m_ConnectionPoint.Unadvise(fontEvents_SinkHelper.m_dwCookie);
					num++;
				}
				while (num < count);
			}
		}
		catch (Exception)
		{
		}
		finally
		{
			Monitor.Exit(this);
		}
	}

	public override void Dispose()
	{
		Finalize();
		GC.SuppressFinalize(this);
	}
}
