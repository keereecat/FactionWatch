using NUnit.Framework;
using System;
using System.IO;

namespace FactionWatch.Persistence.Tests {
	public class SystemTest {
		private String json = File.ReadAllText(@".\SystemTest.json");
		[SetUp]
		public void Setup() {
		}

		[Test]
		public void TestJsonParse() {
			var system = new System(json);
			Assert.AreEqual(system.Name, "HIP 18527");
			Assert.AreEqual(system.Factions["HIP 18527 Silver Energy PLC"], (0.265265d, FactionState.None));
		}
	}
}