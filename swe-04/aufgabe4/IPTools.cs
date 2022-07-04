using System;
using System.Diagnostics;
using System.Linq;

namespace Program
{
	static class IPTools
	{
		public static byte[] ToInAddr(string it)
		{
			var Octets = it.Split('.');
			if (Octets.Length != 4)
				throw new ArgumentException("A version 4 internet address must consist of 4 decimal octets.");
			return Octets
				.Select(Octet => Convert.ToByte(Octet))
				.ToArray();
		}

		public static string InAddrToString(byte[] Octets)
		{
			Debug.Assert(Octets.Length == 4, $"Expected 4 octets but got ${Octets.Length} instead");
			return String.Join(".", Octets.Select(Octet => Octet.ToString()));
		}

		public static readonly byte[] LocalHost = {127, 0, 0, 1};
	}
}
