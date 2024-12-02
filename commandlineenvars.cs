using System;
using System.IO;
using System.Windows.Forms;
class Program {
static void Main(string[] args) {
try {
string nameOfVar = Path.GetFileNameWithoutExtension(args[0]);
string contentOfVar = File.ReadAllText(args[0]);
DialogResult setIt = MessageBox.Show("Set the variable?", "CommandLineEnVars", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
if (setIt == DialogResult.Yes) {
Environment.SetEnvironmentVariable(nameOfVar, contentOfVar, EnvironmentVariableTarget.User);
MessageBox.Show("Variable " + nameOfVar + " set to " + contentOfVar + ".", "CommandLineEnVars", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
}
catch (Exception ex) {
MessageBox.Show(ex.ToString() + "\n\nPlease try dragging a .txt file onto this program", "CommandLineEnVars", MessageBoxButtons.OK, MessageBoxIcon.Error);
}
}
}