// PaSwitchGitHubAccount2018CS.cs

using System;
using System.Drawing;
using System.Windows.Forms;

class PaSwitchGitHubAccount2018CS:Form{
	private TableLayoutPanel tlp = new TableLayoutPanel();
	private AnchorStyles as1 = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
	private const int nCommandCount = 4;
	private Button[] btnCommand = new Button[nCommandCount];

	protected override Size DefaultSize {
		get{ return new Size(300, 300); }
	}

	public PaSwitchGitHubAccount2018CS(){
		this.Text = "PaSwitchGitHubAccount2018CS.cs";
		this.StartPosition = FormStartPosition.CenterScreen;
		// this.MinimumSize = new Size(400, 450);

		initUI();
	}

	public void initUI(){
		this.tlp.SuspendLayout();
		this.SuspendLayout();

		this.tlp.Anchor = as1;
		this.tlp.ColumnCount = 1;
		this.tlp.RowCount = 4;
		this.tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

		for(int i = 0; i < nCommandCount; i++){
			this.tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
		}

		Size size1 = this.ClientSize;
		int nClientWidth = size1.Width;
		// MessageBox.Show("size1.x" + size1.Width);
		for(int i = 0; i < nCommandCount; i++){
			btnCommand[i] = new Button();
			btnCommand[i].Text = "asm32cn@github.com";
			btnCommand[i].Size = new Size(nClientWidth - 10, 40);
			btnCommand[i].Location = new Point(5, i * 50 + 5 );

			btnCommand[i].Dock = DockStyle.Fill;
			btnCommand[i].Anchor = as1;

			this.tlp.Controls.Add(btnCommand[i], 0, i);
		}

		this.Controls.Add(this.tlp);
		this.Padding = new Padding(10);
		this.tlp.ResumeLayout(false);
		this.tlp.PerformLayout();
		this.ResumeLayout(false);
		this.tlp.Dock = DockStyle.Fill;

	}

	public static void Main(string[] args){
		Application.Run(new PaSwitchGitHubAccount2018CS());
	}
}
