package coffeestore.ui;

import org.eclipse.swt.events.SelectionAdapter;
import org.eclipse.swt.events.SelectionEvent;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Text;

import com.sleepycat.je.DatabaseException;

import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.VendorEntity;

public class AddVendorForm extends FormBase
{
	private DataAccessorHolder itsDataAccessorHolder;
	
	public AddVendorForm(Composite aParent, DataAccessorHolder aDataAccessorHolder)
	{
		super(aParent);
		itsDataAccessorHolder = aDataAccessorHolder;
		
		final Text vendorText = createText("Vendor", 0);
		
		Button ok = createButtonOk(1);
		Button cancel = createButtonCancel(1);
	
		cancel.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent event)
			{
				getParent().dispose();
			}
		});
		
		ok.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent event)
			{
				addVendor(vendorText.getText());
			}
		});
		
		Button sync = createButtonCancel(2);
		 sync.addSelectionListener(new SelectionAdapter() {
			@Override
			public void widgetSelected(SelectionEvent event)
			{
				syncDatabase();
			}
		});
	}
	
	private void syncDatabase()
	{
		try
		{
			itsDataAccessorHolder.getDataStore().close();
			itsDataAccessorHolder.getDataStore().open();
			itsDataAccessorHolder.createDataAccessors();
		} 
		catch (DatabaseException e)
		{
			e.printStackTrace();
		}
	}
	
	private void addVendor(String aVendor)
	{
		try
		{
			itsDataAccessorHolder.getVendorAccessor().put(new VendorEntity(aVendor));
			System.out.println("Added vendor: " + aVendor);
		} 
		catch (DatabaseException e)
		{
			e.printStackTrace();
		}
	}
}
