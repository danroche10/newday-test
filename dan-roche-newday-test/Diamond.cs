using System.Data;
using System.Diagnostics;
using System.Text;

namespace Diamond
{
	public class Diamond
	{
		public static string Create(char inputCharacter)
		{
			if (inputCharacter == 'A')
				return "A";
			
			int inputCharacterAlphabetPosition = char.ToLower(inputCharacter) - 'a' + 1;
			StringBuilder outputString = new StringBuilder();

			CreateTopHalfOfDiamond(outputString, inputCharacterAlphabetPosition);
			
			return outputString.ToString();
		}

		private static void CreateTopHalfOfDiamond(StringBuilder outputString, int inputCharacterAlphabetPosition)
		{
			int squareSideLength = (inputCharacterAlphabetPosition * 2) - 1;
			for (int i = 0; i < inputCharacterAlphabetPosition; i++)
			{
				int diamondTopPosition = squareSideLength / 2;
				char letter = char.ToUpper((char)('a' + i));

                if (i == 0)
                {
                    for (int position = 0; position < squareSideLength; position++)
		            {
						if (position == diamondTopPosition)
							outputString.Append(letter);
						else
							outputString.Append(' ');
					}
				}	
				else
				{
					for (int position = 0; position < squareSideLength; position++)
					{
						if (position == diamondTopPosition + i || position == diamondTopPosition - i)
							outputString.Append(letter);
						else
							outputString.Append(' ');
					}
				}
				outputString.Append('\n');
			}

			for (int i = inputCharacterAlphabetPosition - 2; i >=0; i--) 
			{
				if (i == 0)
	            {
					string newRow = outputString.ToString().Substring(0, squareSideLength);
					outputString.Append(newRow);
				}
				else
				{
					string newRow = outputString.ToString().Substring((i * squareSideLength) + i, squareSideLength);
					outputString.Append(newRow + "\n");
				}
			}
		}
	}
}
