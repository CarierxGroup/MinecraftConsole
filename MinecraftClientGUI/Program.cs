using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftClientGUI
{
    static class Program
    {
        /// <summary>
        /// Minecraft Console Client GUI by ORelio (c) 2013.
        /// Allows to use Minecraft Console Client in a more user friendly interface
        /// This source code is released under the CDDL 1.0 License.
        /// </summary>

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!System.IO.File.Exists(MinecraftClient.ExePath))
            {
                OpenFileDialog o = new OpenFileDialog();
                if (o.ShowDialog() == DialogResult.OK)
                {
                    MinecraftClient.ExePath = o.FileName;
                }
                else
                {
                    MessageBox.Show("File not found: " + MinecraftClient.ExePath, "Minecraft client not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Application.Run(new Form1(args));

        }
    }
}
