package coffestore.core;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;

public class Application
{
	private WareHouse itsWareHouse;
	
	public Application()
	{
		itsWareHouse = new WareHouse(); 
	}

	public WareHouse getWareHouse()
	{
		return itsWareHouse;
	}
	
	public void load(String aFileName) throws FileNotFoundException, IOException, ClassNotFoundException
	{
		FileInputStream fileStream = new FileInputStream(aFileName);
		ObjectInputStream objectStream = new ObjectInputStream(fileStream);
		itsWareHouse = (WareHouse) objectStream.readObject();
	}
	
	public void save(String aFileName) throws FileNotFoundException, IOException
	{
		FileOutputStream fileStream = new FileOutputStream(aFileName);
		ObjectOutputStream objectStream = new ObjectOutputStream(fileStream);
		objectStream.writeObject(itsWareHouse);
	}
}
