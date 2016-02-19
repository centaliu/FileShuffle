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

namespace FileShuffle
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}
		private int exchTimes = 100;

		private List<int> nums = new List<int>();
		private List<string> mp3Files = new List<string>();

		// user hit the button to select the directory which includes the files
		private void btnSelDir_Click(object sender, EventArgs e)
		{
			folderSel.ShowNewFolderButton = false;
			folderSel.RootFolder = Environment.SpecialFolder.MyComputer;
			DialogResult res = folderSel.ShowDialog();
			if (res == DialogResult.OK) txtPath.Text = folderSel.SelectedPath;
		}

		private void frmMain_Load(object sender, EventArgs e)
		{

		}

		private void btnShuffle_Click(object sender, EventArgs e)
		{
			nums.Clear();
			mp3Files.Clear();
			// step 1: get all filenames;
			if (txtPath.Text.Substring(txtPath.Text.Length - 2, 1) != @"\") txtPath.Text = txtPath.Text + @"\";
			string[] allFiles = Directory.GetFiles(txtPath.Text);
			// step 2: fulfill a list nums of sequential integers, and a list of all file names in the folder
			foreach (string fn in allFiles)
			{
				mp3Files.Add(fn);
				nums.Add(nums.Count);
			}
			// step 3: randomely swap two numbers in the list nums
			Random rnd = new Random();
			for (int i = 0; i < exchTimes; i++) swapPos(rnd.Next(nums.Count), rnd.Next(nums.Count));
			// step 4: rename all files in the folder with an additional '_', for ex: .mp3 to mp3_
			for (int i = 0; i < nums.Count; i++) File.Move(mp3Files[i], mp3Files[i] + "_");
			// step 5: rename all files back to mp3 base on the the values in nums list
			for (int i = 0; i < nums.Count; i++) File.Move(mp3Files[i] + "_", txtPath.Text + paddingTo3(nums[i]) + ".mp3");
			MessageBox.Show("Files Shuffled Completely!!");
		}

		// swap positions of two items in the array
		private void swapPos(int v1, int v2)
		{
			int tmp = nums[v1];
			nums[v1] = nums[v2];
			nums[v2] = tmp;
		}

		// this is a function to make a 3-digit string of a number which is less than 1000\
		private string paddingTo3(int income)
		{
			if (income < 10) return "00" + income.ToString();
			else if (income < 100) return "0" + income.ToString();
			else return income.ToString();
		}

	}
}
