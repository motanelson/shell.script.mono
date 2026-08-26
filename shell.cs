
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace shells
{
partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 24);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newToolStripMenuItem,
            this.clearMessagesToolStripMenuItem,
            this.saveMessagesToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.runToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(800, 195);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 228);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(800, 195);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "new";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // clearMessagesToolStripMenuItem
            // 
            this.clearMessagesToolStripMenuItem.Name = "clearMessagesToolStripMenuItem";
            this.clearMessagesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearMessagesToolStripMenuItem.Text = "clear messages";
            this.clearMessagesToolStripMenuItem.Click += new System.EventHandler(this.clearMessagesToolStripMenuItem_Click);
            // 
            // saveMessagesToolStripMenuItem
            // 
            this.saveMessagesToolStripMenuItem.Name = "saveMessagesToolStripMenuItem";
            this.saveMessagesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveMessagesToolStripMenuItem.Text = "save messages";
            this.saveMessagesToolStripMenuItem.Click += new System.EventHandler(this.saveMessagesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.runToolStripMenuItem.Text = "run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "shell scripter";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    }
public partial class Form1 : Form
    {
        private string files = "new.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s =Application.ExecutablePath;
            openFileDialog1.InitialDirectory = s;
            s = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "open shell script";
            openFileDialog1.CheckFileExists = true;

            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                files = openFileDialog1.FileName;
                s =File.ReadAllText(openFileDialog1.FileName);
                textBox1.Text = s;
            }
           

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = Application.ExecutablePath;
            openFileDialog1.InitialDirectory = s;
            s = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "save shell script";
            openFileDialog1.CheckFileExists = false;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                File.WriteAllText(openFileDialog1.FileName,textBox1.Text);
                
            }


        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = Application.ExecutablePath;
            openFileDialog1.InitialDirectory = s;
            s = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "save shell script";
            openFileDialog1.CheckFileExists = false;

            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                File.WriteAllText(openFileDialog1.FileName, textBox1.Text);

            }
            textBox1.Text = "";


        }

        private void clearMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void saveMessagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String s = Application.ExecutablePath;
            openFileDialog1.InitialDirectory = s;
            s = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "save shell script";
            openFileDialog1.CheckFileExists = false;

            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                File.WriteAllText(openFileDialog1.FileName, textBox2.Text);

            }
           

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] s = textBox1.Text.Split('\n');
            String ss = "";
            int a = 0;
            String args = "";

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].Trim();
                s[i] = s[i].Replace("\n", "");
                textBox2.Text = textBox2.Text + s[i] + "\r\n";
                args = s[i];
                try
                {
                    if (s[i] != "") Process.Start(s[i]);




                }
                catch (Exception ex)
                {



                    // Configure the process start info
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = "cmd.exe",              // Run CMD
                        Arguments = "/c " + args,       // /c = run command and exit
                        RedirectStandardOutput = true,     // Capture output
                        RedirectStandardError = true,      // Capture errors
                        UseShellExecute = false,           // Required for redirection
                        CreateNoWindow = true              // Hide CMD window
                    };
                    using (Process process = new Process())
                    {
                        process.StartInfo = psi;
                        process.Start();

                        // Read the output and errors
                        string output = process.StandardOutput.ReadToEnd();
                        string errors = process.StandardError.ReadToEnd();

                        process.WaitForExit();

                        // Display results

                        textBox2.Text = textBox2.Text + output + "\n";
                        textBox2.Text = textBox2.Text + errors + "\n";

                    }

                }
            }
                
                


            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
