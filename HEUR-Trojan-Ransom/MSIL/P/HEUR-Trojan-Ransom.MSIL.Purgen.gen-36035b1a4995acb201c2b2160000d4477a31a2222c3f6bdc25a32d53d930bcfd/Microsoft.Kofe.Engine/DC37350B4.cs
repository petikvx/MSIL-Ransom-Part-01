using System.Linq;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class DC37350B4
{
	private FE8030C1E AE1EBA524;

	private bool A727374F3;

	private StepDepth E525E151E;

	private StepSize CA7184654;

	private bool C4E38D90C;

	public bool E39720991
	{
		get
		{
			lock (this)
			{
				return A727374F3;
			}
		}
	}

	public StepDepth CCA9EEDFB
	{
		get
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			lock (this)
			{
				return E525E151E;
			}
		}
	}

	public StepSize F8A25BC0A
	{
		get
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			lock (this)
			{
				return CA7184654;
			}
		}
	}

	public DC37350B4(FE8030C1E thread)
	{
		AE1EBA524 = thread;
		B9696FDB7();
	}

	public void B9696FDB7()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		lock (this)
		{
			A727374F3 = false;
			E525E151E = (StepDepth)0;
			CA7184654 = (StepSize)1;
			C4E38D90C = false;
		}
	}

	public void BF93FFDBD(StepDepth EB104E2F8, StepSize FCF3FFE1A)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		lock (this)
		{
			A727374F3 = true;
			E525E151E = EB104E2F8;
			CA7184654 = FCF3FFE1A;
			C4E38D90C = false;
		}
	}

	internal bool C521F9647(out StepDepth BCB57B034)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		lock (this)
		{
			BCB57B034 = (StepDepth)1;
			if ((int)CA7184654 == 0)
			{
				return true;
			}
			IJdwpStackFrame topStackFrame = AE1EBA524.C11BEDF60.B3E3893F5.GetTopStackFrame(AE1EBA524.BAB7FF789());
			IJdwpClass @class = AE1EBA524.C11BEDF60.B3E3893F5.GetClass(topStackFrame.get_Location().get_ClassID());
			IJdwpMethod method = @class.GetMethod(topStackFrame.get_Location().get_MethodID());
			if (@class.get_Name().Contains("java.lang.ClassLoader"))
			{
				BCB57B034 = (StepDepth)2;
				C4E38D90C = true;
				return false;
			}
			if ((int)E525E151E == 0 && method.get_Name().Equals("valueOf") && (@class.get_Name().Equals("java.lang.Integer") || @class.get_Name().Equals("java.lang.String") || @class.get_Name().Equals("java.lang.Byte") || @class.get_Name().Equals("java.lang.Double") || @class.get_Name().Equals("java.lang.Short") || @class.get_Name().Equals("java.lang.Float") || @class.get_Name().Equals("java.lang.Long") || @class.get_Name().Equals("java.lang.Character")))
			{
				BCB57B034 = (StepDepth)2;
				C4E38D90C = true;
				return false;
			}
			if (C4E38D90C)
			{
				BCB57B034 = (StepDepth)0;
				C4E38D90C = false;
				return false;
			}
			IJdwpCodeLine[] lines = method.GetLines();
			if (lines.Any() && topStackFrame.get_Location().get_Index() < lines[0].get_LineCodeIndex())
			{
				BCB57B034 = (StepDepth)1;
				return false;
			}
			return true;
		}
	}
}
