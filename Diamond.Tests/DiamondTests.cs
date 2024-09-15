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
		public void B_should_have_characters_repeated_in_correct_order_and_separate_lines()
		{
			// Arrange
			char input = 'B';
			
			// Act
        	string output = Diamond.Create(input);

			// Assert
			string expectedOutput = "A\nBB\nA";
			Assert.Equal(expectedOutput, output);
		}
	}
}