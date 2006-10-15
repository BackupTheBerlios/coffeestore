package coffestore.ui;

import javax.swing.JFrame;
import javax.swing.JLabel;

public class MainWin
{
	private static void createMainWin()
	{
		JFrame.setDefaultLookAndFeelDecorated(true);

		JFrame frame = new JFrame("MainWin");
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

		JLabel label = new JLabel("MainWin");
		frame.getContentPane().add(label);

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
