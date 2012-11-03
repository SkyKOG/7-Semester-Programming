import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
/*
<applet code="JTextFieldDemo" width=300 height=50>
</applet>
*/
	public class JTextFieldDemo extends JApplet {
		JTextField jtf;
		public void init() {
			SwingUtilities.invokeAndWait(
					new Runnable() {
						public void run() {
						makeGUI();
					}
				}
			);
		}

	private void makeGUI() {

		setLayout(new FlowLayout());

		jtf = new JTextField(15);
		add(jtf);

		JLabel jlab = new JLabel();
		add(jlab); 

		jtf.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent ae) {

			showStatus(jtf.getText());
		}
		});
	}
}