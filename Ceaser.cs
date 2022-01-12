using System;

public class Ceaser : Cipher
{


	public override string encrypt(String orjinalMetin, string anahtar)
	{
		string result = "";
		char ch;
		int s = anahtar.Length;
		for (int i = 0; i < orjinalMetin.Length; i++)
		{
			if (Char.IsUpper(orjinalMetin[i]))
			{

				ch = (char)(((int)orjinalMetin[i] + s - 65) % 26 + 65);

				result = result + ch;

			}
			else
			{

				ch = (char)(((int)orjinalMetin[i] + s - 97) % 26 + 97);

				result = result + ch;
			}
		}
		return result;
	}


	public override string decrypt(string sifreliMetin, string anahtar)
	{
		string result = "";
		char ch;
		int shift = 26 - anahtar.Length;
		for (int i = 0; i < sifreliMetin.Length; i++)
		{
			if (Char.IsUpper(sifreliMetin[i]))
			{
				ch = (char)(((int)sifreliMetin[i] + shift - 65) % 26 + 65);

				result = result + ch;
			}
			else
			{
				ch = (char)(((int)sifreliMetin[i] + shift - 97) % 26 + 97);

				result = result + ch;
			}



		}
		return result;

	}
}
