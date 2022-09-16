using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace dfb44QxstTvciGRseP;

internal class Pmw79ZxuQeedqQP0u0A : cINrIVxf2BcU6UCYMo3
{
	private static Pmw79ZxuQeedqQP0u0A QsqilTZHIdGeJbDgfxi;

	public Pmw79ZxuQeedqQP0u0A(ICollection<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>> icollection_0, C1NbKbx1dJvOTKX6UO4 c1NbKbx1dJvOTKX6UO4_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector(icollection_0, c1NbKbx1dJvOTKX6UO4_0);
	}

	public override void Gr4FoXLNIK(string string_0)
	{
		StreamWriter streamWriter = new StreamWriter(File.Open((string)JFl4pLZkNTnITdmo6uO(string_0, "\\Summary.htm"), FileMode.Create));
		StringBuilder stringBuilder = new StringBuilder();
		y9Ih1XZG2N3JBXPOHO3(stringBuilder, "<html>");
		stringBuilder.Append("<head>");
		y9Ih1XZG2N3JBXPOHO3(stringBuilder, "<style>");
		((StringBuilder)y9Ih1XZG2N3JBXPOHO3(stringBuilder, ".tableStyle {border: none; }")).Append((string?)P54pBiZnuWCga468IgE());
		y9Ih1XZG2N3JBXPOHO3(stringBuilder.Append(".rowStyle {border:none; }"), Environment.NewLine);
		stringBuilder.Append(".cellStyle {border-width: 1px; border-style: solid; }").Append(Environment.NewLine);
		stringBuilder.Append(".headerStyle {border-width: 1px; border-style: solid; }").Append((string?)P54pBiZnuWCga468IgE());
		y9Ih1XZG2N3JBXPOHO3(stringBuilder, "</style>");
		stringBuilder.Append("</head>");
		stringBuilder.Append("<body>");
		int num = 2;
		if (xAZ6TDZe1bXOryZ0LpI() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		IEnumerator<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>> enumerator = default(IEnumerator<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>>);
		double num3 = default(double);
		int num5 = default(int);
		DateTime generatedTime = default(DateTime);
		DateTime dateTime = default(DateTime);
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num)
			{
			case 5:
				try
				{
					while (enumerator.MoveNext())
					{
						iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a> current = enumerator.Current;
						string value = (string)US39TmZTAceyB4cUmrY(eX0MyEtNq8);
						((StringBuilder)y9Ih1XZG2N3JBXPOHO3(y9Ih1XZG2N3JBXPOHO3(stringBuilder.Append("<tr class='rowStyle'><td class='cellStyle'>").Append(current.AuYMuVTa12().Count).Append("</td><td class='cellStyle'><pre>"), AJglqsZq4inNqIqsJg0(current)), "</pre></td><td class='cellStyle'>")).Append("<a href='./").Append(value).Append("'>")
							.Append(value)
							.Append("</a></td></tr>");
						if (xAZ6TDZe1bXOryZ0LpI() != null)
						{
							switch (0)
							{
							}
						}
						num3 += (double)current.AuYMuVTa12().Count;
						foreach (oPMer26JhO73WAJG4a item in current.AuYMuVTa12())
						{
							int num4 = 1;
							if (xAZ6TDZe1bXOryZ0LpI() != null)
							{
								goto IL_01d2;
							}
							goto IL_01d6;
							IL_01d2:
							num4 = num5;
							goto IL_01d6;
							IL_01d6:
							while (true)
							{
								switch (num4)
								{
								case 1:
									goto IL_01bc;
								}
								break;
								IL_01bc:
								generatedTime = item.GeneratedTime;
								num4 = 0;
								if (Mpw4kIZ1vhxrL88nyec())
								{
									continue;
								}
								goto IL_01d2;
							}
							if (generatedTime.CompareTo(dateTime) < 0)
							{
								dateTime = tMORtHZ3TeLX2wW9gCr(item);
							}
							generatedTime = item.GeneratedTime;
							if (generatedTime.CompareTo(dateTime2) > 0)
							{
								dateTime2 = item.GeneratedTime;
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						a3Bvg0ZYGhG2KF8gYWK(enumerator);
					}
				}
				goto case 4;
			case 4:
				stringBuilder.Append("</table>");
				stringBuilder.Append("<br><br><b>Total number of records processed:</b> <i>").Append(num3).Append("</i><br>");
				y9Ih1XZG2N3JBXPOHO3(stringBuilder.Append("<b>Time range:</b> [From: <i>").Append(dateTime).Append("</i> Till:<i>")
					.Append(dateTime2), "</i>]<br>");
				stringBuilder.Append("<br><br>");
				y9Ih1XZG2N3JBXPOHO3(stringBuilder, "</body>");
				num = 1;
				if (xAZ6TDZe1bXOryZ0LpI() == null)
				{
					break;
				}
				goto default;
			default:
				enumerator = HRuM9LWGmi.GetEnumerator();
				num = 1;
				if (xAZ6TDZe1bXOryZ0LpI() != null)
				{
					break;
				}
				goto case 5;
			case 3:
				dateTime2 = DateTime.MinValue;
				num = 0;
				if (Mpw4kIZ1vhxrL88nyec())
				{
					break;
				}
				goto default;
			case 2:
				WIqbhZZSMs0Gqnu38Qy(stringBuilder.Append("<h2>Analysis Summary</h2><br>Generated on: "), DateTime.Now);
				((StringBuilder)w167SmZCMEfeNg3Nmxw(y9Ih1XZG2N3JBXPOHO3(stringBuilder, "<br>No of groups: "), My0WSFZhRgkhVDse1O0(HRuM9LWGmi))).Append("<br>");
				y9Ih1XZG2N3JBXPOHO3(stringBuilder, "<h3>Grouping details</h3>");
				stringBuilder.Append("<table id='summaryTable' class='tableStyle'><tr><th class='headerStyle'>Number of occurences</th><th class='headerStyle'>Message</th><th class='headerStyle'>Details</th></tr>");
				num3 = 0.0;
				dateTime = DateTime.MaxValue;
				num = 0;
				if (!Mpw4kIZ1vhxrL88nyec())
				{
					break;
				}
				goto case 3;
			case 1:
				y9Ih1XZG2N3JBXPOHO3(stringBuilder, "</html>");
				lcDT2uZLJW9X9QLbTSR(streamWriter, stringBuilder);
				streamWriter.Close();
				return;
			}
		}
	}

	internal static object JFl4pLZkNTnITdmo6uO(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static object y9Ih1XZG2N3JBXPOHO3(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append((string?)object_1);
	}

	internal static object P54pBiZnuWCga468IgE()
	{
		return Environment.NewLine;
	}

	internal static object WIqbhZZSMs0Gqnu38Qy(object object_0, object object_1)
	{
		return ((StringBuilder)object_0).Append(object_1);
	}

	internal static int My0WSFZhRgkhVDse1O0(object object_0)
	{
		return ((ICollection<iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>>)object_0).Count;
	}

	internal static object w167SmZCMEfeNg3Nmxw(object object_0, int int_0)
	{
		return ((StringBuilder)object_0).Append(int_0);
	}

	internal static object US39TmZTAceyB4cUmrY(object object_0)
	{
		return ((C1NbKbx1dJvOTKX6UO4)object_0).bXHMDV0kIg();
	}

	internal static object AJglqsZq4inNqIqsJg0(object object_0)
	{
		return ((iYU0STxvGcMmvnWTbLh<oPMer26JhO73WAJG4a>)object_0).q9FMTnYdBd();
	}

	internal static DateTime tMORtHZ3TeLX2wW9gCr(object object_0)
	{
		return ((oPMer26JhO73WAJG4a)object_0).GeneratedTime;
	}

	internal static void a3Bvg0ZYGhG2KF8gYWK(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void lcDT2uZLJW9X9QLbTSR(object object_0, object object_1)
	{
		((TextWriter)object_0).Write(object_1);
	}

	internal static bool Mpw4kIZ1vhxrL88nyec()
	{
		return QsqilTZHIdGeJbDgfxi == null;
	}

	internal static Pmw79ZxuQeedqQP0u0A xAZ6TDZe1bXOryZ0LpI()
	{
		return QsqilTZHIdGeJbDgfxi;
	}
}
