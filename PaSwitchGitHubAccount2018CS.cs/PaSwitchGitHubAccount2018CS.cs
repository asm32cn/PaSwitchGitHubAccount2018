// PaSwitchGitHubAccount2018CS.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class PaSwitchGitHubAccount2018CS:Form{
	private const int nCommandCount = 4;
	private Button[] btnCommand = new Button[nCommandCount];

	protected override Size DefaultSize {
		get{ return new Size(300, 450); }
	}

	public PaSwitchGitHubAccount2018CS(){
		this.Text = "PaSwitchGitHubAccount2018CS.cs";
		this.StartPosition = FormStartPosition.CenterScreen;
		// this.MinimumSize = new Size(400, 450);

		initUI();
	}

	public void initUI(){
		Size size1 = this.Size;
		int nClientWidth = size1.Width;
		// MessageBox.Show("size1.x" + size1.Width);
		for(int i = 0; i < nCommandCount; i++){
			btnCommand[i] = new Button();
			btnCommand[i].Text = "asm32cn@github.com";
			btnCommand[i].Size = new Size(nClientWidth - 20, 40);
			btnCommand[i].Location = new Point(5, i * 50 + 5 );

			Controls.Add(btnCommand[i]);
		}
	}

	public static void Main(string[] args){
		Application.Run(new PaSwitchGitHubAccount2018CS());
	}
}
