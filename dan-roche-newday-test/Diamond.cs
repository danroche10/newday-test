namespace Diamond
{
	public class Diamond
	{
		public static string Create(char inputCharacter)
		{
			int inputCharacterAlphabestPosition = char.ToLower(inputCharacter) - 'a' + 1;
			string outputString = string.Empty; // use string builder?

			for (int i = 0; i < inputCharacterAlphabestPosition; i++) 
			{
				char letter = char.ToUpper((char)('a' + i));
				outputString += letter;
            }

			return outputString;
		}
	}
}
