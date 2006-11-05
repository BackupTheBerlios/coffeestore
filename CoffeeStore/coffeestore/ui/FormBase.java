package coffeestore.ui;

import org.eclipse.swt.SWT;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Combo;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Text;

public class FormBase extends Composite
{
	public FormBase(Composite aParent)
	{
		super(aParent, SWT.NONE);
	}

	protected int getHorizontalControlSize()
	{
		return 25;
	}
	
	protected Button createButtonCancel(int aLevelId)
	{
		Button cancel = new Button(this, SWT.PUSH);
		cancel.setText("Cancel");
		setButtonSzie(cancel, aLevelId, 250);
		return cancel;
	}

	protected Button createButtonOk(int aLevelId)
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

	@Deprecated
	protected Combo createCombo(String aText, int aLevelId, String[] someItems)
	{
		createLabel(aText, aLevelId);
		Combo combo = new Combo(this, SWT.DROP_DOWN | SWT.READ_ONLY);
		combo.setItems(someItems);
		setInputControlSize(combo, aLevelId);
		return combo;
	}

	protected Combo createCombo(String aText, int aLevelId, ComboElemAdder adder)
	{
		createLabel(aText, aLevelId);
		Combo combo = new Combo(this, SWT.DROP_DOWN | SWT.READ_ONLY);
		adder.addElem(combo);
		setInputControlSize(combo, aLevelId);
		return combo;
	}

	protected Text createText(String aText, int aLevelId)
	{
		createLabel(aText, aLevelId);
		Text text = new Text(this, SWT.BORDER | SWT.SINGLE);
		setInputControlSize(text, aLevelId);
		return text;
	}

	protected void setInputControlSize(Control aControl, int aLevelId)
	{
		aControl.setLocation(90, aLevelId * getHorizontalControlSize());
		aControl.setSize(220, 20);
	}

	protected Label createLabel(String aText, int aLevelId)
	{
		Label label;
		label = new Label(this, SWT.NONE);
		label.setText(aText);
		label.setLocation(0, aLevelId * getHorizontalControlSize() + 3);
		label.pack();
		return label;
	}

}