using System;

public class MyStream
{
	public static DataInputStream readFile(string path)
	{
		//Discarded unreachable code: IL_0019, IL_0026
		path = Main.res + path;
		try
		{
			return DataInputStream.getResourceAsStream(path);
		}
		catch (Exception)
		{
			return null;
		}
	}
}
