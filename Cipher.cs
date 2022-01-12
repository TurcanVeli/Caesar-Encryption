using System;



public abstract class Cipher
{
    public abstract String encrypt(String orjinalMetin, String anahtar);
    public abstract String decrypt(String sifreliMetin, String anahtar);
}
