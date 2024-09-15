namespace Diamond.Tests
{
	public class DiamondTests
	{
		[Fact]
		public void A_should_return_only_A()
		{
			// Arrange
			char input = 'A';

			// Act
			string output = Diamond.Create(input);

			// Assert
			string expectedOutput = "A";
			Assert.Equal(expectedOutput, output);
		}
	
        [Fact]
		public void B_should_give_correct_character_sequence()
		{
			//Arrange
			char input = 'B';

	        // Act
			string output = Diamond.Create(input);

			// Assert
			string expectedOutput = "AB";
			Assert.Equal(expectedOutput, output);
		}
	}
}