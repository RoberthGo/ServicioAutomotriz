using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoRepair.Data;

namespace AutoRepair
{
    public partial class Form1 : Form
    {
        private BindingList<Service> servicesList = new BindingList<Service>();
        private BindingList<Part> partsList = new BindingList<Part>();

        private enum CurrentView
        {
            Services,
            Parts
        }

        private CurrentView currentView = CurrentView.Services;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            SetupGridForServices();
        }

        private void InitializeData()
        {
            // Seed with some sample data
            servicesList.Add(new Service { Id = 1, Description = "Cambio de aceite", Price = 29.99m });
            servicesList.Add(new Service { Id = 2, Description = "Alineación", Price = 49.50m });

            partsList.Add(new Part { Id = 1, Name = "Filtro de aceite", Stock = 10, Price = 9.99m });
            partsList.Add(new Part { Id = 2, Name = "Bujía", Stock = 25, Price = 4.50m });
        }

        private void SetupGridForServices()
        {
            currentView = CurrentView.Services;
            dataGrid.DataSource = servicesList;
            // Adjust column headers to Spanish but keep property names in English
            dataGrid.Columns[nameof(Service.Id)].HeaderText = "ID";
            dataGrid.Columns[nameof(Service.Description)].HeaderText = "Descripción";
            dataGrid.Columns[nameof(Service.Price)].HeaderText = "Precio";
        }

        private void SetupGridForParts()
        {
            currentView = CurrentView.Parts;
            dataGrid.DataSource = partsList;
            dataGrid.Columns[nameof(Part.Id)].HeaderText = "ID";
            dataGrid.Columns[nameof(Part.Name)].HeaderText = "Nombre";
            dataGrid.Columns[nameof(Part.Stock)].HeaderText = "Existencias";
            dataGrid.Columns[nameof(Part.Price)].HeaderText = "Precio";
        }

        private void BtnServices_Click(object sender, EventArgs e)
        {
            SetupGridForServices();
        }

        private void BtnParts_Click(object sender, EventArgs e)
        {
            SetupGridForParts();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (currentView == CurrentView.Services)
            {
                int newId = (servicesList.Count > 0) ? servicesList.Max(s => s.Id) + 1 : 1;
                servicesList.Add(new Service { Id = newId, Description = "", Price = 0m });
            }
            else
            {
                int newId = (partsList.Count > 0) ? partsList.Max(p => p.Id) + 1 : 1;
                partsList.Add(new Part { Id = newId, Name = "", Stock = 0, Price = 0m });
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null) return;

            var item = dataGrid.CurrentRow.DataBoundItem;
            if (item == null) return;

            if (currentView == CurrentView.Services)
            {
                var svc = item as Service;
                if (svc != null)
                {
                    servicesList.Remove(svc);
                }
            }
            else
            {
                var prt = item as Part;
                if (prt != null)
                {
                    partsList.Remove(prt);
                }
            }
        }
    }
}
