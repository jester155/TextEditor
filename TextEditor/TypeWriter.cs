using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor {
	public partial class TypeWriter : Form {

		string file;

		public TypeWriter() {
			InitializeComponent();
			InitializeContextMenu();
		}
		
		private void InitializeContextMenu() {
			typeWriterField.ContextMenuStrip = contextMenuStrip;
		}
		//.MENU ITEMS
		private void pasteToolStripMenuItem_Click(object sender , EventArgs e) {
			typeWriterField.Paste();
		}
		private void saveToolStripMenuItem_Click(object sender , EventArgs e) {
			saveAction();
		}

		private void exitToolStripMenuItem_Click(object sender , EventArgs e) {
			Environment.Exit(0);
		}
	}
}
