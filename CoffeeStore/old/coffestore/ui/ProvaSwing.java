package old.coffestore.ui;

import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.BorderFactory;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

public class ProvaSwing
{
	private static class MyPanelWithButton implements ActionListener
	{
		private JPanel itsPanel;
		private JLabel itsLabel;
		private JButton itsButton;
		private int itsClickCounter;
		
		public MyPanelWithButton()
		{
			itsPanel = new JPanel(new GridLayout(0, 1));
			itsLabel = new JLabel("ProvaWin NumClick: " + itsClickCounter);
			itsButton = new JButton("I'm a Swing button!");
			
			itsButton.addActionListener(this);
			itsClickCounter = 0;
			
			itsPanel.add(itsLabel);
			itsPanel.add(itsButton);
		}
		
		public JPanel getPanel()
		{
			return itsPanel;
		}

		public void actionPerformed(ActionEvent anEvent)
		{
			itsClickCounter++;
			itsLabel.setText("ProvaWin NumClick: " + itsClickCounter);
		}
	}
	
	private static class MyPanelWithForElements
	{
		private JPanel itsPanel;
		private JLabel itsLabel1;
		private JLabel itsLabel2;
		private JButton itsButton;
		private JTextField itsTextField;
		
		public MyPanelWithForElements()
		{
			itsPanel = new JPanel(new GridLayout(2,2)); 
			itsButton = new JButton("Button");
			itsTextField = new JTextField("Text Field");
			itsLabel1 = new JLabel("On Button: " + itsTextField.getText());
			itsLabel2 = new JLabel("On Text: " + itsTextField.getText());
			
			itsTextField.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent anAction)
				{
					itsLabel2.setText("On Text: " + itsTextField.getText());
				}	
			});
			
			itsButton.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent anAction)
				{
					itsLabel1.setText("On Button: " + itsTextField.getText());
				}	
			});
			
			itsPanel.add(itsTextField);
			itsPanel.add(itsLabel2);
			itsPanel.add(itsButton);
			itsPanel.add(itsLabel1);
		}
		
		public JPanel getPanel()
		{
			return itsPanel;
		}
	}
	
	private static void createMainWin()
	{
		JFrame frame = new JFrame("Test");
	
		MyPanelWithForElements myPanel = new MyPanelWithForElements();
		
		frame.add(new AddProvisionPanel());
		
		frame.pack();
		frame.setVisible(true);
	}

	public static void main(String[] args)
	{
		javax.swing.SwingUtilities.invokeLater(new Runnable() {
			public void run()
			{
				createMainWin();
			}
		});
	}
}
