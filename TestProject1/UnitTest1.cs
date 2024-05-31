using _1.SemesterProjekt;
using _1.SemesterProjekt.DataAccess;
using _1.SemesterProjekt.Models;
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
            AfdelingDbHandler db = new AfdelingDbHandler();
            Afdeling afdeling = new Afdeling();

            string actualNavn;
			string expectedNavn = "Nordjylland";


            //Act
            afdeling = db.Get(1);
			actualNavn = afdeling.Afdelings_Navn;

            //Assert
            Assert.AreSame(expectedNavn, actualNavn);
        }
	}
}