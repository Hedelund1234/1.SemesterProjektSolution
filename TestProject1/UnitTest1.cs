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
			string navn = "Nordjylland";
			AfdelingDbHandler db = new AfdelingDbHandler();
            Afdelinga = db.Get(navn);

			//Act & Assert
			Assert.That(a.Afdelings_Nr.GetAmount(), Is.EqualTo("1"));
		}
	}
}