using System;
using System.Text;

namespace CxSoftware.HexSharp
{
	public static class HexConvert
	{
		private static readonly char [] hexChars = "0123456789abcdef".ToCharArray ();

		public static string ToString (byte [] bytes)
		{
			var sb = new StringBuilder (bytes.Length * 2);
			foreach (var b in bytes)
			{
				sb.Append (hexChars [b / 0x10]);
				sb.Append (hexChars [b % 0x10]);
			}

			return sb.ToString ();
		}
	}
}

