package old.coffestore.core.test;


import static org.junit.Assert.*;

import old.coffestore.core.NotEnoughProvisionException;
import old.coffestore.core.Provision;
import old.coffestore.core.ProvisionUnload;

import org.junit.Before;
import org.junit.Test;



public class TestProvision
{
	private Provision itsProvision;

	@Before
	public void setUp() throws Exception
	{
		itsProvision = Factories.createProvision(3, 15);
	}
	
	@Test
	public void unload() throws Exception
	{
		itsProvision.addUnload(new ProvisionUnload(1,5));
		assertEquals(1, itsProvision.getUnloads().size());
		assertEquals(10, itsProvision.getRemainingKilos());
		assertEquals(2, itsProvision.getRemainingSacks());
	}
	
	@Test
	public void unloadTooMuchPacks()
	{
		try 
		{
			itsProvision.addUnload(new ProvisionUnload(4,5));
			fail("Exception not thrown");
		} 
		catch (NotEnoughProvisionException e)
		{
			assertEquals(0, itsProvision.getUnloads().size());
			assertEquals(15, itsProvision.getRemainingKilos());
			assertEquals(3, itsProvision.getRemainingSacks());
		}
	}
	
	@Test
	public void unloadTooMuchKilos()
	{
		try 
		{
			itsProvision.addUnload(new ProvisionUnload(1,20));
			fail("Exception not thrown");
		}
		catch (NotEnoughProvisionException e)
		{
			assertEquals(0, itsProvision.getUnloads().size());
			assertEquals(15, itsProvision.getRemainingKilos());
			assertEquals(3, itsProvision.getRemainingSacks());
		}
	}
}
