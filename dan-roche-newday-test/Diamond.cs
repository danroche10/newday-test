using System.Text;

namespace Diamond
{
	public class Diamond
	{
		public static string Create(char inputCharacter)
		{
			int inputCharacterAlphabestPosition = char.ToLower(inputCharacter) - 'a' + 1;
			StringBuilder outputString = new StringBuilder(string.Empty);

			for (int i = 0; i < inputCharacterAlphabestPosition; i++) 
			{
				char letter = char.ToUpper((char)('a' + i));

				if (outputString.Length > 0 && letter != outputString[i - 1])
					outputString.Append('\n');

				outputString.Append(letter);
            }
			
			for (int i = inputCharacterAlphabestPosition - 1; i >= 0; i--)
			{
				char letter = char.ToUpper((char)('a' + i));

				if (i < inputCharacterAlphabestPosition - 1 && letter != outputString[i + 1])
					outputString.Append("\n");

				outputString.Append(letter);
			}

			return outputString.ToString();
		}
	}
}
