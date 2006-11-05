package coffeestore.ui.test;

import org.eclipse.jface.window.ApplicationWindow;
import org.eclipse.swt.widgets.Composite;
import org.eclipse.swt.widgets.Control;
import org.eclipse.swt.widgets.Display;

import coffeestore.core.db.DataAccessorHolder;
import coffeestore.core.db.test.Utility;
import coffeestore.ui.*;



public class CompViewer extends ApplicationWindow
{
	DataAccessorHolder itsDataAccessorHolder;
	
	public CompViewer()
	{
		super(null);
		try 
		{
			itsDataAccessorHolder = new DataAccessorHolder(Utility.createDataStore());
		}
		catch (Exception e) 
		{
			System.out.println(e.getStackTrace());
		}
	}
	
	@Override
	protected Control createContents(Composite aParent)
	{
		new AddProvisionForm_2(aParent, itsDataAccessorHolder);
		return aParent;
	}
	
	public static void main(String[] args)
	{
		CompViewer cv = new CompViewer();
		cv.setBlockOnOpen(true);
		cv.open();
		Display.getCurrent().dispose();
	}
}