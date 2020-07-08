using CopyDirectory.Libs.Services;
using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace CopyDirectory
{
    public partial class Main : Form
    {

        BackgroundWorker worker = new BackgroundWorker();
        private readonly ICopyService _copyService;
        private bool CopyInProgress = false;
        Libs.Models.CopyItem _CopyItem = Libs.Models.CopyItem.FILE;

        public Main(ICopyService icopyService)
        {

            _copyService = icopyService ?? throw new ArgumentNullException($"{GetType().Name} {"ConstructorInitFailure"} {nameof(icopyService)}");

            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true; ;

            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {

            Invoke(new Action(() => { lblProcentage.Text = "Actively copying"; }));

            //_copyService.
            var result = _copyService.Copy(txtSource.Text, txtTarget.Text, _CopyItem);

            if (result.succes)
            {
                result.error = "Success";
            }

            Invoke(new Action(() => { lblProcentage.Text = result.error; }));

            CopyInProgress = false;

        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            lblProcentage.Text = "InProgress";
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btmOpenSrc_Click(object sender, EventArgs e)
        {
            if((cbxFile.Checked && cbxFolder.Checked) || (!cbxFile.Checked && !cbxFolder.Checked)) 
            {
                MessageBox.Show("Please specify copy option");
                return;
            }
        }

        private void CallDialog()
        {
            if (_CopyItem == Libs.Models.CopyItem.FILE)
            {
                OpenFileDialog o = new OpenFileDialog();
                if (o.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = o.FileName;
                }
            }
            else
            {
                FolderBrowserDialog o = new FolderBrowserDialog();
                if (o.ShowDialog() == DialogResult.OK)
                {
                    txtSource.Text = o.SelectedPath;
                }
            }
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = Path.Combine(fbd.SelectedPath, Path.GetFileName(txtSource.Text));
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblProcentage.Text = "";

            if (!CopyInProgress)
            {
                worker.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("CopyInProgress, Please wait");
            }
        }

        private void cbxFile_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFile.Checked)
            {
                _CopyItem = Libs.Models.CopyItem.FILE;
            }
        }

        private void cbxFolder_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxFolder.Checked)
            {
                _CopyItem = Libs.Models.CopyItem.FOLDER;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CopyInProgress)
            {
                DialogResult dialogResult = MessageBox.Show("Copy process is not finish. Close?", "CopyDirectory", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }


        }
    }
}
