using System;


public class Vigenere : Cipher
{

	public override string encrypt(string orjinalMetin, string anahtar)
	{
		string res = "";
		orjinalMetin = orjinalMetin.ToLower();
		for (int i = 0, j = 0; i < orjinalMetin.Length; i++)
		{
			char c = orjinalMetin[i];
			if (c > 'A' & c < 'Z')
			{
				continue;
			}
			res += (char)((c + anahtar[j] - 2 * 65) % 26 + 65);
			j = ++j % anahtar.Length;



		}
		return res;


	}

	public override string decrypt(string sifreliMetin, string anahtar)
	{

		string res = "";
		sifreliMetin = sifreliMetin.ToUpper();
		for (int i = 0, j = 0; i < sifreliMetin.Length; i++)
		{
			char c = sifreliMetin[i];
			if (c > 'A' & c < 'Z')
			{
				continue;
			}
			res = res + (char)((c - anahtar[j] + 26) % 26 + 65);
			j = ++j % anahtar.Length;



		}
		return res;

	}

}
