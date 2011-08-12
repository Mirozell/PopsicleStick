/*
PopsicleStick - A tool to pick random items out of a set.
Copyright (C) 2011  Mirozell

Website: https://github.com/Mirozell/PopsicleStick

PopsicleStick is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PopsicleStick is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with PopsicleStick.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PopsicleStick
{
    public partial class PopsicleStickForm : Form
    {
        private const string CALLED = "[CALLED]";
        private readonly Random R = new Random();

        private string filepath = null;

        public PopsicleStickForm()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() != DialogResult.OK) return;
            if (!File.Exists(dlg.FileName)) return;

            filepath = dlg.FileName;
            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
            {
                string name = line.Replace(CALLED, "");

                if (name == line)
                    NotCalledList.Items.Add(name);
                else
                    CalledList.Items.Add(name);
            }
        }

        private void ClearCalledButton_Click(object sender, EventArgs e)
        {
            while (CalledList.Items.Count > 0)
            {
                NotCalledList.Items.Add(CalledList.Items[0]);
                CalledList.Items.RemoveAt(0);
            }

            WriteFile();
        }

        private void WriteFile()
        {
            if (filepath == null) return;

            File.WriteAllLines(filepath, NotCalledList.Items.Cast<string>());
            File.AppendAllLines(filepath, CalledList.Items.Cast<string>().Select((s) => { return s + " " + CALLED; }));
        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            if (NotCalledList.Items.Count == 0) return;

            int index = R.Next(NotCalledList.Items.Count);
            string name = (string)NotCalledList.Items[index];
            NotCalledList.Items.RemoveAt(index);
            CalledList.Items.Add(name);
            NameLabel.Text = name;

            WriteFile();
        }

        private void SetNotCalledButton_Click(object sender, EventArgs e)
        {
            if (CalledList.SelectedItem == null) return;

            NotCalledList.Items.Add(CalledList.SelectedItem);
            CalledList.Items.RemoveAt(CalledList.SelectedIndex);

            WriteFile();
        }

        private void SetCalledButton_Click(object sender, EventArgs e)
        {
            if (NotCalledList.SelectedItem == null) return;

            CalledList.Items.Add(NotCalledList.SelectedItem);
            NotCalledList.Items.RemoveAt(NotCalledList.SelectedIndex);

            WriteFile();
        }
    }
}
