package coffeestore.ui.test;

import org.eclipse.jface.window.ApplicationWindow;
import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Display;
import org.eclipse.swt.widgets.List;

import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.VendorEntity;
import coffeestore.core.db.test.Utility;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.persist.EntityCursor;

public class DbViewer extends ApplicationWindow
{
	DataAccessorHolder itsDataAccessorHolder;
	
	public DbViewer()
	{
		super(null);
		try 
		{
			itsDataAccessorHolder = new DataAccessorHolder(Utility.createDataStore(true));
		}
		catch (Exception e) 
		{
			e.printStackTrace();
		}
	}
	
	@Override
	protected Control createContents(Composite aParent)
	{
		List list = new List(aParent, SWT.MULTI | SWT.V_SCROLL | SWT.H_SCROLL);
		
		try
		{
			EntityCursor<VendorEntity> cursor = itsDataAccessorHolder.getVendorAccessor().getPrimaryIndex().entities();
			VendorEntity vendor = null;
			while ((vendor = cursor.next()) != null)
				list.add(vendor.getVendor());
			cursor.close();
		}
		catch (DatabaseException de)
		{
			de.printStackTrace();
		}
		
		return aParent;
	}

	private void closeDataBase()
	{
		try
		{
			itsDataAccessorHolder.getDataStore().close();
		} 
		catch (DatabaseException e)
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args)
	{
		DbViewer db = new DbViewer();
		db.setBlockOnOpen(true);
		db.open();
		Display.getCurrent().dispose();
		db.closeDataBase();
	}
}