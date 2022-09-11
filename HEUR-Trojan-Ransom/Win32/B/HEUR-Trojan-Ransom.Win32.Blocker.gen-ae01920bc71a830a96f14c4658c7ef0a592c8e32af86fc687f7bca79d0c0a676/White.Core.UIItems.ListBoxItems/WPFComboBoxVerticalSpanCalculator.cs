using System.Windows;
using log4net;

namespace White.Core.UIItems.ListBoxItems;

public class WPFComboBoxVerticalSpanCalculator
{
	private readonly Rect firstItem;

	private readonly Rect lastItem;

	private readonly Rect combo;

	private readonly double percentVisible;

	private readonly ILog logger = LogManager.GetLogger(typeof(WPFComboBoxVerticalSpanCalculator));

	public virtual VerticalSpan VerticalSpan
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			Rect val = firstItem;
			double top = ((Rect)(ref val)).get_Top();
			Rect val2 = lastItem;
			double bottom = ((Rect)(ref val2)).get_Bottom();
			Rect val3 = combo;
			double bottom2 = ((Rect)(ref val3)).get_Bottom();
			if (DropUp())
			{
				logger.Debug((object)"ComboBox is dropping up");
				return new VerticalSpan(top, top + VisibleHeight(top, bottom));
			}
			return new VerticalSpan(bottom2, bottom2 + VisibleHeight(top, bottom));
		}
	}

	public WPFComboBoxVerticalSpanCalculator(Rect combo, Rect firstItem, Rect lastItem, double percentVisible)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		this.firstItem = firstItem;
		this.lastItem = lastItem;
		this.combo = combo;
		this.percentVisible = percentVisible;
	}

	private double VisibleHeight(double listTop, double listBottom)
	{
		return (listBottom - listTop) * percentVisible / 100.0;
	}

	private bool DropUp()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Rect val = combo;
		double top = ((Rect)(ref val)).get_Top();
		Rect val2 = firstItem;
		return top > ((Rect)(ref val2)).get_Top();
	}
}
