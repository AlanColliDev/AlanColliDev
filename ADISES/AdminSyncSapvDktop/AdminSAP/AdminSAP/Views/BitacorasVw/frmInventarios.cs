using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSAP.Utils;
using SAP_LIB.Models;
using SAP_LIB.Controllers;
using AdminSAP.Views.Loading;

namespace AdminSAP.Views.BitacorasVw
{
    public partial class frmInventarios : Form
    {
        bool fgFirstAccess = true;
        int countRegisters = 0;
        int registroActual = 0;
        int countSelect = 10;
        bool fgMinus = false;

        public frmInventarios()
        {
            InitializeComponent();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarInformacion()
        {
            try
            {
                DataTable tbl = new DataTable();
                DataTable tableCount = new DataTable();

                string fgFilter = txtCriterioBusqueda.Text.Trim();
                string dateFrom = chkFeInicioSinc.Checked ? dtFeInicioSinc.Value.ToString("yyyyMMdd") : string.Empty;
                string dateTo = chkFeFinSinc.Checked ? dtFeFinSinc.Value.ToString("yyyyMMdd") : string.Empty;
                string query = string.Empty;
                string queryCOunt = $"SELECT COUNT(*) FROM {parseStringBD("zAdi_SyncInventory")}";

                query = $"SELECT {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateRegister")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_ItemCode")},";
                query += $" {parseStringBD(DBConn.zAdi_SyncItems)}.{parseStringBD("zAdi_ItemName")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_WareHouse")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_OnHand")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_IsCommited")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_OnOrder")},";
                query += $" {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_Available")}";
                query += $" FROM {parseStringBD("zAdi_SyncInventory")}";
                query += $" INNER JOIN {parseStringBD("zAdi_SyncItems")}";
                query += $" ON {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_ItemCode")} = {parseStringBD("zAdi_SyncItems")}.{parseStringBD("zAdi_ItemCode")}";
                bool whereContain = false;
                if (!string.IsNullOrEmpty(fgFilter))
                {
                    string wherefilter = $" WHERE CONTAINS(({parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_ItemCode")}, {parseStringBD(DBConn.zAdi_SyncItems)}.{parseStringBD("zAdi_ItemName")}, {parseStringBD(DBConn.zAdi_SyncItems)}.{parseStringBD("zAdi_WareHouse")}),'%{fgFilter}%')";
                    query += wherefilter;
                    queryCOunt += wherefilter;
                    whereContain = true;
                }

                if (!string.IsNullOrEmpty(dateFrom))
                {
                    if (!string.IsNullOrEmpty(dateTo))
                    {
                        string whereDate = $" {(whereContain ? "AND" : "WHERE")} {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")} IS NOT NULL";
                        whereDate += $" AND {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")} BETWEEN TO_DATE('{dateFrom}')";
                        whereDate += $" AND TO_DATE('{dateTo}')";
                        query += whereDate;
                        queryCOunt += whereDate;
                    }
                    else
                    {
                        //if (whereContain)
                        string whereDate = $" {(whereContain ? "AND" : "WHERE")} {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")} IS NOT NULL AND TO_VARCHAR({parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")}, 'YYYYMMDD') = '{dateFrom}'";
                        query += whereDate;
                        queryCOunt += whereDate;
                        //else
                        //    query += $" WHERE {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")} IS NOT NULL AND TO_VARCHAR({parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")}, 'YYYYMMDD') = '{dateFrom}'";
                    }
                }

                query += $" ORDER BY {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateSend")} DESC, {parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_DateRegister")} DESC LIMIT {countSelect} OFFSET {registroActual}";

                metroTextBox1.Text = queryCOunt;
                mdLoading.ExecuteWork(this, "Procesando...", () =>
                {
                    tbl = DBConn.ExecQuery(query);

                    //string queryCOunt = string.IsNullOrEmpty(fgFilter) ? $"SELECT COUNT(*) FROM {parseStringBD("zAdi_SyncInventory")}" : $"SELECT COUNT(*) FROM {parseStringBD("zAdi_SyncInventory")} WHERE WHERE CONTAINS(({parseStringBD("zAdi_SyncInventory")}.{parseStringBD("zAdi_ItemCode")}, {parseStringBD(DBConn.zAdi_SyncItems)}.{parseStringBD("zAdi_ItemName")}, {parseStringBD(DBConn.zAdi_SyncItems)}.{parseStringBD("zAdi_WareHouse")}),'%{fgFilter}%')";
                    tableCount = DBConn.ExecQuery(queryCOunt);
                });

                if (fgFirstAccess)
                    registroActual += int.Parse(cmbRegistros.SelectedValue.ToString());

                countRegisters = tableCount != null && tableCount.Rows.Count > 0 ? int.Parse(tableCount.Rows[0].ItemArray[0].ToString()) : 0;

                lblRegistroActual.Text = $"{(registroActual > countRegisters ? countRegisters : registroActual)} de {countRegisters}";

                btnMas.Enabled = !(registroActual >= countRegisters || (registroActual + int.Parse(cmbRegistros.SelectedValue.ToString())) > countRegisters);
                btnMenos.Enabled = !(registroActual <= int.Parse(cmbRegistros.SelectedValue.ToString()));

                if(tbl != null && tbl.Rows.Count > 0)
                {
                    grvConsulta.Columns.Clear();
                    grvConsulta.DataSource = tbl;

                    //grvConsulta.Columns["zAdi_SyncItemsId"].Visible = false;
                    grvConsulta.SetFormatColumn("zAdi_DateSend", "Sincronizado", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_DateRegister", "Registro", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_ItemCode", "Código", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_ItemName", "Descripción", DataGridViewAutoSizeColumnMode.Fill);
                    grvConsulta.SetFormatColumn("zAdi_WareHouse", "Sucursal", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_OnHand", "En Stock", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_IsCommited", "Comprometido", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_OnOrder", "Pedido", DataGridViewAutoSizeColumnMode.DisplayedCells);
                    grvConsulta.SetFormatColumn("zAdi_Available", "Disponible", DataGridViewAutoSizeColumnMode.DisplayedCells);

                    grvConsulta.ScrollBars = ScrollBars.Both;


                }
                else
                {
                    MessageBox.Show("No se encontraron elementos");
                    grvConsulta.ClearGridView();
                    return;
                }
            }
            catch(Exception ex) {
                grvConsulta.ClearGridView();
                MessageBox.Show(ex.ToString());
            }
        }

        public string parseStringBD(string str)
        {
            return $"\"{str}\"";
        }

        private void frmInventarios_Load(object sender, EventArgs e)
        {
            this.ConfigureDesign();
            loadComboBox();
            cargarInformacion();
            fgFirstAccess = false;
        }
        private void loadComboBox()
        {
            try
            {
                List<comboBoxItems> lsItems = new List<comboBoxItems>()
                {
                    new comboBoxItems { valueString = "10", viewString = "10"},
                    new comboBoxItems {valueString = "20", viewString = "20" },
                    new comboBoxItems {valueString = "50", viewString = "50" },
                    new comboBoxItems {valueString = "100", viewString = "100" }
                };

                Controles.LoadDataToCombobox(cmbRegistros, lsItems, "valueString", "viewString");
            }
            catch (Exception ex)
            {

            }
        }

        private void cmbRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!fgFirstAccess)
                {
                    if (cmbRegistros.SelectedIndex != -1)
                    {
                        //registroActual += int.Parse(cmbRegistros.SelectedValue.ToString());
                        if (int.Parse(cmbRegistros.SelectedValue.ToString()) != countSelect)
                        {
                            countSelect = int.Parse(cmbRegistros.SelectedValue.ToString());
                            registroActual = 0;
                            fgFirstAccess = true;
                            cargarInformacion();
                            fgFirstAccess = false;
                        }
                        //else
                        //    cargarInformacion();
                    }
                }
            }
            catch (Exception ex) { }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            try
            {
                registroActual += int.Parse(cmbRegistros.SelectedValue.ToString());
                cargarInformacion();
            }
            catch (Exception ex) { }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            registroActual -= int.Parse(cmbRegistros.SelectedValue.ToString());
            if (registroActual < 0)
                registroActual = 0;

            cargarInformacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbRegistros.SelectedIndex = 0;
            countSelect = 10;
            registroActual = 0;
            fgFirstAccess = true;
            cargarInformacion();
            fgFirstAccess = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbRegistros.SelectedIndex = 0;
            countSelect = 10;
            registroActual = 0;
            txtCriterioBusqueda.Clear();
            chkFeFinSinc.Checked = false;
            chkFeFinSinc.Enabled = false;
            dtFeFinSinc.Enabled = false;
            chkFeInicioSinc.Checked = false;
            dtFeInicioSinc.Enabled = false;
            fgFirstAccess = true;
            cargarInformacion();
            fgFirstAccess = false;
            txtCriterioBusqueda.Select();
        }

        private void chkFeInicioSinc_CheckedChanged(object sender, EventArgs e)
        {
            dtFeInicioSinc.Enabled = chkFeInicioSinc.Checked;
            chkFeFinSinc.Enabled = chkFeInicioSinc.Checked;
        }

        private void chkFeFinSinc_CheckedChanged(object sender, EventArgs e)
        {
            dtFeFinSinc.Enabled = chkFeFinSinc.Checked;
        }
    }
}
