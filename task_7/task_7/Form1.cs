using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using task_7.Entities;

namespace task_7
{
    public partial class Form1 : Form
    {
        List<Tick> ticks;
        List<PortfolioItem> Portfolio = new List<PortfolioItem>();
        PortfolioEntities context = new PortfolioEntities();
        public Form1()
        {
            InitializeComponent();
            ticks = context.Tick.ToList();
            dataGridView1.DataSource = ticks;
            CreatePortfolio();

        }

        private void CreatePortfolio()
        {
            Portfolio.Add(new PortfolioItem() { Index = "OTP", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ZWACK", Volume = 10 });
            Portfolio.Add(new PortfolioItem() { Index = "ELMU", Volume = 10 });

            dataGridView2.DataSource = Portfolio;
        }
    }
}
