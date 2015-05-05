using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository.Entity.Models;
using RepositorySample.Repository;

namespace Repository.WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var genericRepository = new GenericRepository<TaskVm>(new OrganiserContext());

            var list = genericRepository.GetAll();

            PopulateData(list.ToList());
            PupulateApplications();
        }
        private void PupulateApplications()
        {
            var genericRepository = new GenericRepository<ApplicationVm>(new OrganiserContext());
            var list = genericRepository.GetAll().ToList();
            dataGridView2.DataSource = list;
        }

        private void PopulateData(List<TaskVm> list)
        {
            dataGridView1.DataSource = list;
        }
    }
}
