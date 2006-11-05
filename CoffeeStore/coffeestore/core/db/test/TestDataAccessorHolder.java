package coffeestore.core.db.test;

import java.io.File;

import org.junit.After;
import org.junit.Before;
import org.junit.Test;

import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.DataStore;
import coffeestore.core.db.OriginEntity;
import coffeestore.core.db.ProvisionEntity;
import coffeestore.core.db.TypeEntity;
import coffeestore.core.db.VendorEntity;

public class TestDataAccessorHolder
{
	private DataStore itsDataStore;
	private DataAccessorHolder itsDataAccessorHolder;
	private File itsFile;

	@Before
	public void setUp() throws Exception
	{
		itsFile = Utility.createDataStoreFile();
		itsDataStore = Utility.createDataStore(false);
		itsDataAccessorHolder = new DataAccessorHolder(itsDataStore);
	}
	@After
	public void tearDown() throws Exception
	{
		Utility.deleteDataStoreFile(itsFile);
		itsDataStore.close();
	}
	
	@Test
	public void testPutProvision() throws Exception
	{
		itsDataAccessorHolder.getVendorAccessor().put(new VendorEntity("Vendor"));
		itsDataAccessorHolder.getOriginAccessor().put(new OriginEntity("Origin"));
		itsDataAccessorHolder.getTypeAccessor().put(new TypeEntity("Type"));
			
		ProvisionEntity provisionEntity = new ProvisionEntity(null, "PurchaseBillId", null, "Vendor", "Origin", "Type", "Tag", 0, 0);
		
		itsDataAccessorHolder.getProvisionAccessor().put(provisionEntity);
	}
}
