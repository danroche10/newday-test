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


		[Theory]
		[InlineData('A', "A")]
		[InlineData('B', " A \nB B\n A ")]
		[InlineData('C', "  A  \n B B \nC   C\n B B \n  A  ")]
		[InlineData('D', "   A   \n  B B  \n C   C \nD     D\n C   C \n  B B  \n   A   ")]
		[InlineData('E', "    A    \n   B B   \n  C   C  \n D     D \nE       E\n D     D \n  C   C  \n   B B   \n    A    ")]
		[InlineData('F', "     A     \n    B B    \n   C   C   \n  D     D  \n E       E \nF         F\n E       E \n  D     D  \n   C   C   \n    B B    \n     A     ")]
		[InlineData('G', "      A      \n     B B     \n    C   C    \n   D     D   \n  E       E  \n F         F \nG           G\n F         F \n  E       E  \n   D     D   \n    C   C    \n     B B     \n      A      ")]
		[InlineData('H', "       A       \n      B B      \n     C   C     \n    D     D    \n   E       E   \n  F         F  \n G           G \nH             H\n G           G \n  F         F  \n   E       E   \n    D     D    \n     C   C     \n      B B      \n       A       ")]
		[InlineData('I', "        A        \n       B B       \n      C   C      \n     D     D     \n    E       E    \n   F         F   \n  G           G  \n H             H \nI               I\n H             H \n  G           G  \n   F         F   \n    E       E    \n     D     D     \n      C   C      \n       B B       \n        A        ")]
		[InlineData('J', "         A         \n        B B        \n       C   C       \n      D     D      \n     E       E     \n    F         F    \n   G           G   \n  H             H  \n I               I \nJ                 J\n I               I \n  H             H  \n   G           G   \n    F         F    \n     E       E     \n      D     D      \n       C   C       \n        B B        \n         A         ")]
		[InlineData('K', "          A          \n         B B         \n        C   C        \n       D     D       \n      E       E      \n     F         F     \n    G           G    \n   H             H   \n  I               I  \n J                 J \nK                   K\n J                 J \n  I               I  \n   H             H   \n    G           G    \n     F         F     \n      E       E      \n       D     D       \n        C   C        \n         B B         \n          A          ")]
		[InlineData('L', "           A           \n          B B          \n         C   C         \n        D     D        \n       E       E       \n      F         F      \n     G           G     \n    H             H    \n   I               I   \n  J                 J  \n K                   K \nL                     L\n K                   K \n  J                 J  \n   I               I   \n    H             H    \n     G           G     \n      F         F      \n       E       E       \n        D     D        \n         C   C         \n          B B          \n           A           ")]
		public void Diamond_Should_Have_Characters_Repeated_In_Correct_Order_And_Separate_Lines(char input, string expectedOutput)
		{
			// Act
			string output = Diamond.Create(input);

			// Assert
			Assert.Equal(expectedOutput, output);
		}

		[Theory]
		[InlineData('a')]
		[InlineData('1')]
		[InlineData('%')]
		public void Create_Should_Throw_Exception_For_Invalid_Input(char invalidInput)
		{
			// Act & Assert
			Assert.Throws<ArgumentException>(() => Diamond.Create(invalidInput));
		}
	}
}