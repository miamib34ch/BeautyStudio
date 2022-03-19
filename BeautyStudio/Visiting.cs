﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BeautyStudio
{
    public partial class Visiting : Form
    {
        string idClient;
        Clients clients;

        public Visiting(string idClient, Clients clients)
        {
            InitializeComponent();
            this.посещениеTableAdapter.Fill(this.beautyStudioDataSet.Посещение);
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet.Скидка);
            this.тип_иглыTableAdapter.Fill(this.beautyStudioDataSet.Тип_иглы);
            посещениеBindingSource.AddNew();
            this.idClient = idClient;
            this.clients = clients;
        }

        private void Visiting_Load(object sender, EventArgs e)
        {
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet1.Процедура);
            this.скидкаTableAdapter.Fill(this.beautyStudioDataSet1.Скидка);
            this.пигментыTableAdapter.Fill(this.beautyStudioDataSet.Пигменты);
            this.процедураTableAdapter.Fill(this.beautyStudioDataSet.Процедура);
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
            this.процедуры_в_посещенииTableAdapter.Fill(this.beautyStudioDataSet.Процедуры_в_посещении);
            итоговая_ценаTextBox.Text = "0";
            comboBox1.SelectedItem = 0;
            comboBox1.SelectedValue = 0;
            maskedTextBox1.Text = DateTime.Now.ToString();
            id_клиентаTextBox.Text = idClient;
        }

        private void addProcedure_Click(object sender, EventArgs e)
        {
            посещениеBindingSource.EndEdit();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            Procedure procedure = new Procedure(id_посещенияTextBox.Text);
            procedure.MdiParent = this.MdiParent;
            procedure.Show();
        }

        private void Visiting_Activated(object sender, EventArgs e)
        {
            updateMoney();
            посещениеBindingSource.EndEdit();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            this.процедуры_клиентаTableAdapter.FillBy(this.beautyStudioDataSet.Процедуры_клиента, int.Parse(id_посещенияTextBox.Text));
        }

        private void Visiting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (clients != null)
                clients.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Вы уверены, что хотите добавить данное посещение?", "Добавление посещение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                посещениеBindingSource.EndEdit();
                посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            процедуры_клиентаTableAdapter.DeleteQuery(int.Parse(id_посещенияTextBox.Text));
            посещениеBindingSource.RemoveCurrent();
            посещениеTableAdapter.Update(this.beautyStudioDataSet.Посещение);
            Close();
        }

        private void процедуры_клиентаDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void процедуры_клиентаDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            e.ContextMenuStrip = contextMenuStrip1;
        }

        private void удалитьПроцедуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Удаление процедуры {процедуры_клиентаDataGridView.CurrentRow.Cells[0].Value.ToString()}", "Удалить?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DeleteRow(int.Parse(процедуры_клиентаDataGridView.CurrentRow.Cells[0].Value.ToString()));
                процедуры_клиентаDataGridView.Rows.Remove(процедуры_клиентаDataGridView.CurrentRow);
                процедуры_клиентаDataGridView.Refresh();
            }
            updateMoney();
        }

        void DeleteRow(int id)
        {
            SqlConnection conn = new SqlConnection($@"Data Source={clients.connectionSourse};Initial Catalog= {clients.bdName};Integrated Security=True;");
            conn.Open();
            var sqlq = $"DELETE FROM [dbo].[Процедуры клиента] WHERE [Id процедуры клиента] = @id";
            var cmd = new SqlCommand(sqlq, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void updateMoney()
        {
            try
            {
                int sale = int.Parse(comboBox2.Text);
                if (посещениеTableAdapter.sumPrice(int.Parse(id_посещенияTextBox.Text)) == null)
                {
                    итоговая_ценаTextBox.Text = $"{0 - sale}";
                }
                else
                {
                    итоговая_ценаTextBox.Text = $"{(int)посещениеTableAdapter.sumPrice(int.Parse(id_посещенияTextBox.Text)) - sale}";
                }
            }
            catch
            {

            }
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            updateMoney();
        }
    }
}
