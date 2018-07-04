// PaSwitchGitHubAccount2018JSC.js

import System;
import System.Drawing;
import System.Windows.Forms;
import Accessibility;

public class PaSwitchGitHubAccount2018JSC extends Form {
	var _this = this;

	protected override function get_DefaultSize(){
		return new System.Drawing.Size(300, 300);
	}

	function PaSwitchGitHubAccount2018JSC(){
		_this.set_Text("PaSwitchGitHubAccount2018JSC.js");
		_this.StartPosition = FormStartPosition.CenterScreen;
		_this.set_MiniumSize(new System.Drawing.Size(300, 300));
	}
}

(function(){
	// MessageBox.Show("PaSwitchGitHubAccount2018JSC.js");
	Application.Run(new PaSwitchGitHubAccount2018JSC());
})();
