using System.Data;
using System.Diagnostics;
using System.Text;

namespace Diamond
{
	public class Diamond
	{
		public static string Create(char inputCharacter)
		{
			int inputCharacterAlphabetPosition = char.ToLower(inputCharacter) - 'a' + 1;
			StringBuilder outputString = new StringBuilder(string.Empty);

			CreateTopHalfOfDiamond(outputString, inputCharacterAlphabetPosition);

			CreateBottomHalfOfDiamond(outputString, inputCharacterAlphabetPosition);
			
			return outputString.ToString();
		}

		private static void CreateTopHalfOfDiamond(StringBuilder outputString, int inputCharacterAlphabetPosition)
		{
			for (int i = 0; i < inputCharacterAlphabetPosition; i++)
			{
				char letter = char.ToUpper((char)('a' + i));

				if (outputString.Length > 0 && letter != outputString[i - 1])
					outputString.Append('\n');

				outputString.Append(letter);
			}
		}
		
		private static void CreateBottomHalfOfDiamond(StringBuilder outputString, int inputCharacterAlphabetPosition)
		{
			for (int i = inputCharacterAlphabetPosition - 1; i >= 0; i--)
			{
				char letter = char.ToUpper((char)('a' + i));

				if (i < inputCharacterAlphabetPosition - 1 && letter != outputString[i + 1])
					outputString.Append("\n");

				outputString.Append(letter);
			}
		}
	}
}
