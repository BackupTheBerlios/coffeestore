package coffeestore.core.db.test;

import static org.junit.Assert.assertEquals;

import java.io.File;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import coffeestore.core.db.DataAccessor;
import coffeestore.core.db.DataStore;
import coffeestore.core.db.VendorEntity;

public class TestDataAccessor
{
	private DataStore itsDataStore;
	private DataAccessor<String, VendorEntity> itsVendorDataAccessor;
	private File itsFile;
	
	@Before
	public void setUp() throws Exception
	{
		itsFile = Utility.createDataStoreFile();
		itsDataStore = Utility.createDataStore();
		itsVendorDataAccessor = Utility.createVendorDataAccessor(itsDataStore);
	}
	
	@After
	public void tearDown() throws Exception
	{ 
		Utility.deleteDataStoreFile(itsFile);
		itsDataStore.close();
	}
	
	@Test
	public void putAndGetVendor() throws Exception
	{
		itsVendorDataAccessor.put(new VendorEntity("Vendor"));
		VendorEntity vendorEntity = itsVendorDataAccessor.get("Vendor");
		assertEquals("Vendor", vendorEntity.getVendor());
	}
}
