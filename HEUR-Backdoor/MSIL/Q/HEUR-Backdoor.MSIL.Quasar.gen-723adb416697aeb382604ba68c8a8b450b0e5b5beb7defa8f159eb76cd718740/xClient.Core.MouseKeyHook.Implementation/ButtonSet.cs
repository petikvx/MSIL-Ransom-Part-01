using System.Windows.Forms;

namespace xClient.Core.MouseKeyHook.Implementation;

internal class ButtonSet
{
	private MouseButtons m_Set;

	public ButtonSet()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		m_Set = (MouseButtons)0;
	}

	public void Add(MouseButtons element)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		m_Set = (MouseButtons)(m_Set | element);
	}

	public void Remove(MouseButtons element)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		m_Set = (MouseButtons)(m_Set & ~element);
	}

	public bool Contains(MouseButtons element)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I4
		return (m_Set & element) > 0;
	}
}
