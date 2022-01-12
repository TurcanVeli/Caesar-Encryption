
using System;


namespace main
{
    public class test
    {

        public static void Main(String[] args)
        {
            string sentence;
            string key;
            Console.WriteLine("Orjinal metni giriniz :");
            sentence = Console.ReadLine();

            Console.WriteLine("Anahtar Giriniz :");
            key = Console.ReadLine();





            Ceaser ceaser = new Ceaser();
            Console.WriteLine("CEASER");
            Console.WriteLine($"Orijinal metin: {sentence}, anahtar: {key}, Sifreli Metin: {ceaser.encrypt(sentence, key)} ");
            string sifreli = ceaser.encrypt(sentence, key).ToString();
            Console.WriteLine($"Sifreli Metin: {sifreli}, anahtar: {key}, Orjinal Metin: {ceaser.decrypt(sifreli, key)}");
            Console.WriteLine("************");

            Vigenere vigenere = new Vigenere();
            Console.WriteLine("VIGENERE");
            Console.Write($"Orijinal metin: {sentence}, anahtar: {key}, Sifreli Metin: ");
            Console.WriteLine(vigenere.encrypt(sentence, key));
            string sifreliVigenere = vigenere.encrypt(sentence, key).ToString();
            Console.Write($"Sifre metin: {sifreliVigenere}, anahtar: {key}, Orijinal Metin: ");
            Console.WriteLine(sentence);
            Console.ReadLine();


        }


    }
}