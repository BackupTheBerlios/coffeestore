package old.coffestore.core.test;

import static org.junit.Assert.*;

import java.io.File;


import old.coffestore.core.Application;
import old.coffestore.core.WareHouse;

import org.junit.Before;
import org.junit.Test;

public class TestApplication
{
	private String itsFileName;
	
	@Before
	public void setUp()
	{
		itsFileName = "dbFileName";
		new File(itsFileName).delete();
	}
	
	private void fillApplication(Application anApplication)
	{
		WareHouse wareHouse = anApplication.getWareHouse();
		wareHouse.add(Factories.createProvision(0, 0));
	}

	@Test
	public void saveAndLoad() throws Exception
	{
		Application applicationSaved = new Application();
		fillApplication(applicationSaved);
		applicationSaved.save(itsFileName);
		
		Application applicationLoaded = new Application(); 
		applicationLoaded.load(itsFileName);
		
		assertEquals(1, applicationLoaded.getWareHouse().getProvisions().size());
		assertEquals(Factories.createProvision(0, 0), applicationLoaded.getWareHouse().getProvisions().iterator().next());
	}
}
