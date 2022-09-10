using System.Drawing;
using iLd730DL;

namespace wMk1FHff;

internal struct CE0EOzcK
{
	private Point Q8n9xLvu;

	private Point point_0;

	public Point hAeujmCX
	{
		get
		{
			return Q8n9xLvu;
		}
		set
		{
			Q8n9xLvu = value;
		}
	}

	public Point lFfcm1r7
	{
		get
		{
			return point_0;
		}
		set
		{
			point_0 = value;
		}
	}

	public CE0EOzcK(Point point_1, Point point_2)
	{
		this = default(CE0EOzcK);
		Q8n9xLvu = point_1;
		point_0 = point_2;
	}

	public void w095CHv9(Graphics IKxpzkL4, Color eEjqiDJy)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		Class15.e6ru47tw(IKxpzkL4, new Pen(eEjqiDJy), hAeujmCX, lFfcm1r7, 53979);
	}
}
