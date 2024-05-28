using _1.SemesterProjekt;
using _AfdelingDbHandler;
namespace TestProject1
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}
		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
		[Test]
		public void Test2()
		{
			//Arrange
			string AfdelingsNavn = "Nordjylland";
			string expectedAfdelingsNr = "1";
            AfdelingDbHandler db = new AfdelingDbHandler();

            //Act
            AfdelingsNr = db.Get(AfdelingsNavn);
            string actualAfdelingsNr = AfdelingsNr.Afdelings_Nr;

			//Assert
			Assert.That(expectedAfdelingsNr, actualAfdelingsNr);
		}
	}
}