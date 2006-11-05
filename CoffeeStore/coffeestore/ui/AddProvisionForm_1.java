package coffeestore.ui;

import org.eclipse.swt.SWT;
import org.eclipse.swt.layout.FormAttachment;
import org.eclipse.swt.layout.FormData;
import org.eclipse.swt.layout.FormLayout;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Label;
import org.eclipse.swt.widgets.Text;

public class AddProvisionForm_1 extends AbstractForm
{

	public AddProvisionForm_1(Composite aParent)
	{
		super(aParent, "Add Provision");
	}

	@Override
	protected Control createContent()
	{
		Composite composite = new Composite(this, SWT.NONE);
		
		composite.setLayout(new FormLayout());
		
		Label l1 = new Label(composite, SWT.RIGHT);	
		l1.setText("First Name");
		Text t1 = new Text(composite, SWT.BORDER | SWT.SINGLE);

		FormData fd = new FormData();
		fd.top = new FormAttachment(0);
		fd.left = new FormAttachment(0);
		l1.setLayoutData(fd);

		fd = new FormData();
		fd.top = new FormAttachment(0);
		fd.left = new FormAttachment(l1, 10);
		fd.right = new FormAttachment(100);
	    t1.setLayoutData(fd);
		
		Label l2 = new Label(composite, SWT.RIGHT);
		l2.setText("Last Name");
		Text t2 = new Text(composite, SWT.BORDER | SWT.SINGLE);
		
		fd = new FormData();
		fd.top = new FormAttachment(l1, 10);
		fd.left = new FormAttachment(0);	
		l2.setLayoutData(fd);

		fd = new FormData();
		fd.top = new FormAttachment(t1, 5);
		fd.left = new FormAttachment(l2, 10);
		fd.right = new FormAttachment(100);
		t2.setLayoutData(fd);

		Label l3 = new Label(composite, SWT.RIGHT);
		l3.setText("Another Name");
		Text t3 = new Text(composite, SWT.BORDER | SWT.SINGLE);
		
		fd = new FormData();
		fd.top = new FormAttachment(l2, 10);
		fd.left = new FormAttachment(0);	
		l3.setLayoutData(fd);

		fd = new FormData();
		fd.top = new FormAttachment(t2, 5);
		fd.left = new FormAttachment(l3, 10);
		fd.right = new FormAttachment(100);
		t3.setLayoutData(fd);
		
		return composite;
	}		
}

