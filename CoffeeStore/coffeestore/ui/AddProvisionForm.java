package coffeestore.ui;

import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Combo;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Text;

import com.sleepycat.je.DatabaseException;
import com.sleepycat.persist.EntityCursor;

import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.VendorEntity;

public class AddProvisionForm extends FormBase
{
	private DataAccessorHolder itsDataAccessorHolder;
	
	public AddProvisionForm(Composite aParent, DataAccessorHolder aDataAccessorHolder)
	{
		super(aParent);
	
		itsDataAccessorHolder = aDataAccessorHolder; 
		
		Text dateText = createText("Date", 0);
		Text purchaseBillIdText = createText("PurchaseBillId", 1);
		Text purchaseBillDateText = createText("PurchaseBillDate", 2);
		
		Combo vendorCombo = createCombo("Vendor", 3, new ComboElemAdder() {
			public void addElem(Combo aCombo)
			{
				addVendorItemsToCombo(aCombo);
			}
		});
		
		Combo originCombo = createCombo("Origin", 4, new String[] { "Origin 1", "Origin 2", "Origin 3"});
		Text typeText = createText("Type", 5);
		
		Button ok = createButtonOk(6);
		Button cancel = createButtonCancel(6);
	}

	private void addVendorItemsToCombo(Combo aCombo)
	{
		try
		{
			EntityCursor<VendorEntity> cursor = itsDataAccessorHolder.getVendorAccessor().getPrimaryIndex().entities();
			VendorEntity vendor = null;
			while ((vendor = cursor.next()) != null)
				aCombo.add(vendor.getVendor());
			cursor.close();
		}
		catch (DatabaseException de)
		{
			de.printStackTrace();
		}
	}
}
