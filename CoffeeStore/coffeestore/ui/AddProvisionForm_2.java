package coffeestore.ui;

import java.util.Arrays;

import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Combo;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Text;

import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.VendorEntity;

public class AddProvisionForm_2 extends Composite
{
	private DataAccessorHolder itsDataAccessorHolder;
	
	private int getHorizontalControlSize()
	{
		return 25;
	}

	public AddProvisionForm_2(Composite aParent, DataAccessorHolder aDataAccessorHolder)
	{
		super(aParent, SWT.NONE);
	
		itsDataAccessorHolder = aDataAccessorHolder; 
		
		Text dateText = createText("Date", 0);
		Text purchaseBillIdText = createText("PurchaseBillId", 1);
		Text purchaseBillDateText = createText("PurchaseBillDate", 2);
		Combo vendorCombo = createCombo("Vendor", 3, getVendorItems());
		Combo originCombo = createCombo("Origin", 4, new String[] { "Origin 1", "Origin 2", "Origin 3"});
		Text typeText = createText("Type", 5);
		
		Button ok = createButtonOk(6);
		Button cancel = createButtonCancel(6);
	}

	private String[] getVendorItems()
	{
		try {
		for (VendorEntity vendor : itsDataAccessorHolder.getVendorAccessor().getPrimaryIndex().entities())
			
		
		return null;
	}

	private Button createButtonCancel(int aLevelId)
	{
		Button cancel = new Button(this, SWT.PUSH);
		cancel.setText("Cancel");
		setButtonSzie(cancel, aLevelId, 250);
		return cancel;
	}

	private Button createButtonOk(int aLevelId)
	{
		Button ok = new Button(this, SWT.PUSH);
		ok.setText("Ok");
		setButtonSzie(ok, aLevelId, 180);
		return ok;
	}

	private void setButtonSzie(Button aButton, int aLevelId, int aHorizontalLocation)
	{
		aButton.setLocation(aHorizontalLocation, getHorizontalControlSize() * aLevelId);
		aButton.setSize(60, 20);
	}

	private Combo createCombo(String aText, int aLevelId, String[] someItems)
	{
		createLabel(aText, aLevelId);
		Combo combo = new Combo(this, SWT.	DROP_DOWN | SWT.READ_ONLY);
		combo.setItems(someItems);
		setInputControlSize(combo, aLevelId);
		return combo;
	}

	private Text createText(String aText, int aLevelId)
	{
		createLabel(aText, aLevelId);
		Text text = new Text(this, SWT.BORDER | SWT.SINGLE);
		setInputControlSize(text, aLevelId);
		return text;
	}

	private void setInputControlSize(Control aControl, int aLevelId)
	{
		aControl.setLocation(90, aLevelId * getHorizontalControlSize());
		aControl.setSize(220, 20);
	}

	private Label createLabel(String aText, int aLevelId)
	{
		Label label;
		label = new Label(this, SWT.NONE);
		label.setText(aText);
		label.setLocation(0, aLevelId * getHorizontalControlSize() + 3);
		label.pack();
		return label;
	}
}
