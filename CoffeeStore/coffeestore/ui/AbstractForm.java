package coffeestore.ui;

import org.eclipse.swt.SWT;
import org.eclipse.swt.graphics.Point;
import org.eclipse.swt.layout.FormAttachment;
import org.eclipse.swt.layout.FormData;
import org.eclipse.swt.layout.FormLayout;
import org.eclipse.swt.widgets.Button;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Label;

public abstract class AbstractForm extends Composite
{
	private Control itsContent; 
	
	public AbstractForm(Composite aParent, String aLabel)
	{
		super(aParent, SWT.NONE);
		
		Label label = createLabel(aLabel);
		Button ok = createButtonOk();
		Button cancel = createButtonCancel();
		
		createFormLayout();

		layoutLabel(label);
		layoutButtonCancel(cancel);
		layoutButtonOk(ok, cancel);
		layoutContent(label, cancel);
	}

	private void layoutContent(Label label, Button cancel)
	{
		FormData contentData = new FormData();
		contentData.left = new FormAttachment(0, 0);
		contentData.right = new FormAttachment(100, 0);
		contentData.top = new FormAttachment(label, 5);
		contentData.bottom = new FormAttachment(cancel, -5);

		itsContent = createContent();
		itsContent.setLayoutData(contentData);
	}

	private void layoutButtonOk(Button ok, Button cancel)
	{
		FormData okData = new FormData();
		okData.right = new FormAttachment(cancel, -5);
		okData.bottom = new FormAttachment(100, 0);
		ok.setLayoutData(okData);
	}

	private void layoutButtonCancel(Button cancel)
	{
		FormData cancelData = new FormData();
		cancelData.right = new FormAttachment(100, -5);
		cancelData.bottom = new FormAttachment(100, 0);
		cancel.setLayoutData(cancelData);
	}

	private void layoutLabel(Label label)
	{
		Point size = label.computeSize(SWT.DEFAULT, SWT.DEFAULT);
		FormData labelData = new FormData(size.x, SWT.DEFAULT);
		labelData.left = new FormAttachment(0, 0);
		labelData.right = new FormAttachment(100, 0);
		label.setLayoutData(labelData);
	}

	private void createFormLayout()
	{
		FormLayout formLayout = new FormLayout();
		formLayout.marginWidth = 5;
		formLayout.marginHeight = 5;
		setLayout(formLayout);
	}

	private Button createButtonCancel()
	{
		Button cancel = new Button(this, SWT.PUSH);
		cancel.setText("Cancel");
		return cancel;
	}

	private Button createButtonOk()
	{
		Button ok = new Button(this, SWT.PUSH);
		ok.setText("Ok");
		return ok;
	}

	private Label createLabel(String aLabel)
	{
		Label label = new Label(this, SWT.WRAP);
		label.setText(aLabel);
		return label;
	}

	protected abstract Control createContent();
}
