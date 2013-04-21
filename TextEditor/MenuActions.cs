using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextEditor {
	public partial class TypeWriter {
		public void saveAction() {
			Stream stream;

			saveFileDialog.Filter = "txt files (*.txt)|*.txt|rtf files (*.rtf)|*.rtf|All files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			saveFileDialog.RestoreDirectory = true;
			saveFileDialog.Title = "Save";

			if(saveFileDialog.ShowDialog() == DialogResult.OK) {
				if((stream = saveFileDialog.OpenFile()) != null) {
					stream.Write(Encoding.ASCII.GetBytes(typeWriterField.Text) , 0 , Encoding.ASCII.GetBytes(typeWriterField.Text).Length);
					stream.Close();
					file = Path.GetFullPath(saveFileDialog.FileName);
				}
			}
		}
	}
}
