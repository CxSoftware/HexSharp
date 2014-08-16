using NUnit.Framework;
using System;

namespace CxSoftware.HexSharp.Tests
{
	[TestFixture]
	public class HexConvertTest
	{
		[Test]
		public void ConvertEmptyArrayShouldBeEmptyString ()
		{
			var bytes = new byte [0];
			var result = HexConvert.ToString (bytes);
			Assert.AreEqual (0, result.Length);
		}

		[Test]
		public void ConvertOneByteShouldBeTwoCharacters ()
		{
			var bytes = new byte [] { 0x01 };
			var result = HexConvert.ToString (bytes);
			Assert.AreEqual (2, result.Length);
			Assert.AreEqual ("01", result);
		}

		[Test]
		public void ConvertFFShouldBeFF ()
		{
			var bytes = new byte [] { 0xff };
			var result = HexConvert.ToString (bytes);
			Assert.AreEqual (2, result.Length);
			Assert.AreEqual ("ff", result);
		}
	}
}

