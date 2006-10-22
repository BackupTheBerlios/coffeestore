package coffeestore.core.db.test;

import static org.junit.Assert.*;

import java.io.File;

import org.junit.Before;
import org.junit.Test;

import coffeestore.core.db.DataAccessor;
import coffeestore.core.db.DataStore;
import coffeestore.core.db.VendorEntity;

public class TestDataAccessor
{
	private DataStore itsDataStore;
	private DataAccessor<String, VendorEntity> itsDataAccessor;
	
	@Before
	public void setUp() throws Exception
	{
		File file = new File("dbEnv/");
		file.mkdir();
		
		itsDataStore = new DataStore(file);
		itsDataAccessor = new DataAccessor<String, VendorEntity>(itsDataStore, String.class, VendorEntity.class);
	}
	
	@Test
	public void putAndGetVendor() throws Exception
	{
		itsDataAccessor.put(new VendorEntity("Vendor"));
		VendorEntity vendorEntity = itsDataAccessor.get("Vendor");
		assertEquals("Vendor", vendorEntity.getVendor());
	}
}
