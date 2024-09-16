using System.Text;

namespace Diamond
{
	public class Diamond
	{
		public static string Create(char targetLetter)
		{
			if (!char.IsLetter(targetLetter) || !char.IsUpper(targetLetter))
				throw new ArgumentException("Input must be an uppercase letter from A to Z.");
			
			if (targetLetter == 'A')
				return "A";
			
			int letterPosition = char.ToUpper(targetLetter) - 'A';
			int diamondWidth = (letterPosition * 2) + 1;
			StringBuilder diamond = new StringBuilder();

			CreateTopOfDiamond(diamond, letterPosition, diamondWidth);
			CreateBottomOfDiamond(diamond, letterPosition, diamondWidth);
			
			return diamond.ToString();
		}

		private static void CreateTopOfDiamond(StringBuilder diamond, int inputCharacterAlphabetPosition, int diamondWidth)
		{
			for (int row = 0; row <= inputCharacterAlphabetPosition; row++)
			{
				char currentChar = (char)('A' + row);
				int middlePosition = diamondWidth / 2;
			
				AppendDiamondRow(diamond, currentChar, middlePosition - row, middlePosition + row, diamondWidth);
				
				diamond.Append('\n');
			}
		}

		private static void CreateBottomOfDiamond(StringBuilder diamond, int letterPosition, int diamondWidth)
		{
			for (int row = letterPosition - 1; row >= 0; row--)
			{
				char currentChar = (char)('A' + row);
				int middlePosition = diamondWidth / 2;

				AppendDiamondRow(diamond, currentChar, middlePosition - row, middlePosition + row, diamondWidth);
                
				if (row > 0) diamond.Append('\n');
			}
		}

		private static void AppendDiamondRow(StringBuilder diamond, char letter, int leftPositon, int rightPositon, int diamondWidth) 
		{
			for (int pos = 0; pos < diamondWidth; pos++) 
			{
				if (pos == leftPositon || pos == rightPositon)
					diamond.Append(letter);
				else
					diamond.Append(' ');	
			}
		}
	}
}
