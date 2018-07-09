// PaSwitchGitHubAccount2018JFrame.java
import java.awt.GridBagConstraints;
import java.awt.GridBagLayout;
import java.awt.Insets;
import javax.swing.JFrame;

class PaSwitchGitHubAccount2018JFrame extends JFrame{
	GridBagLayout gbl = new GridBagLayout();
	GridBagConstraints gbc = new GridBagConstraints();

	public PaSwitchGitHubAccount2018JFrame(){
		this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		this.setTitle("PaSwitchGitHubAccount2018JFrame");
		this.setSize(600, 450);
		this.setLocationRelativeTo(null);
		
		this.setVisible(true);

		initUI();
	}
	public void initUI(){
		gbc.fill = GridBagConstraints.BOTH;
		setLayout(gbl);

		gbc.insets = new Insets(5, 5, 5, 5);
		gbc.weightx = 10;
		gbc.weighty = 10;
		gbc.gridx = 0;
		gbc.gridy = 0;
	}
	public static void main(String[] args){
		PaSwitchGitHubAccount2018JFrame frame = new PaSwitchGitHubAccount2018JFrame();

		System.out.println("PaSwitchGitHubAccount2018JFrame.java");
	}
}