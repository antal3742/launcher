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
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;
using IWshRuntimeLibrary;

namespace launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_mstart_Click(object sender, EventArgs e)
        {
            string keyPath = @"SOFTWARE\WOW6432Node\Wizet\Maple";
            string valueName = "RootPath";
            string gab = "";

            gab = ReadRegistryValue(keyPath, valueName);
            string gabdir = gab + @"\GameLauncher.exe";
            string gabshortcut = gab + @"\MapleStory.exe - Shortcut.lnk";

            Console.WriteLine(gab);

            if (!System.IO.File.Exists(gabshortcut))
            {
                using (System.IO.File.Create(gabshortcut))
                {
                    Console.WriteLine("Background File Created");
                }
            }

            CreateShortcut(gabshortcut, gabdir, gab);

            try
            {
                Process.Start(gabshortcut);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void Btn_vstart_Click(object sender, EventArgs e)
        {
            
        }
    }
}